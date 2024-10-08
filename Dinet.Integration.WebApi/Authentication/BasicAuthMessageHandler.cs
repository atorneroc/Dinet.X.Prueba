using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;

namespace Dinet.Integration.WebApi.Authentication
{
    /// <summary>
    /// 
    /// </summary>
    public class BasicAuthMessageHandler : DelegatingHandler
    {
        private const string BasicAuthResponseHeader = "WWW-Authenticate";
        private const string BasicAuthResponseHeaderValue = "Basic";
        private const string BearerResponseHeaderValue = "Bearer";

        /// <summary>
        /// 
        /// </summary>
        public IPrincipalProvider PrincipalProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        protected override System.Threading.Tasks.Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            CredentialRequest parsedCredentials = null;

            if (request.Headers.Authorization == null)
            {
                var item = request.Headers.ToList().Find(x => x.Key.ToUpper().Equals("X-AUTH-TOKEN"));
                if (!String.IsNullOrEmpty(item.Key))
                {
                    String itemValue = item.Value.FirstOrDefault();
                    if (!String.IsNullOrEmpty(itemValue))
                    {
                        JwtSecurityTokenHandler jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
                        JwtSecurityToken jwtSecurityToken = jwtSecurityTokenHandler.ReadJwtToken(itemValue);

                        if (jwtSecurityToken.SignatureAlgorithm == SecurityAlgorithms.HmacSha512)
                            parsedCredentials = ParseAuthorizationHeaderBearse(jwtSecurityToken);
                    }
                }
            }
            else if(request.Headers.Authorization != null && request.Headers.Authorization.Scheme == "Basic")
            {
                parsedCredentials = ParseAuthorizationHeader(request.Headers.Authorization.Parameter);
            }

            if (parsedCredentials != null)
            {
                var oCurrentPrincipal = PrincipalProvider.CreatePrincipal(parsedCredentials.UserName, parsedCredentials.Password);
                if (oCurrentPrincipal != null && oCurrentPrincipal.Identity.IsAuthenticated)
                {
                    request.GetRequestContext().Principal = oCurrentPrincipal;
                    Thread.CurrentPrincipal = oCurrentPrincipal;
                }
            }

            return base.SendAsync(request, cancellationToken)
                .ContinueWith(task =>
                {
                    var response = task.Result;
                    if (response.StatusCode == HttpStatusCode.Unauthorized
                        && !response.Headers.Contains(BasicAuthResponseHeader))
                    {
                        response.Headers.Add(BasicAuthResponseHeader, BasicAuthResponseHeaderValue);
                    }
                    return response;
                });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="authHeader"></param>
        /// <returns></returns>
        private CredentialRequest ParseAuthorizationHeader(string authHeader)
        {
            string[] credentials = Encoding.ASCII.GetString(Convert.FromBase64String(authHeader)).Split(new[] { ':' });

            if (credentials.Length != 2 || string.IsNullOrEmpty(credentials[0]) || string.IsNullOrEmpty(credentials[1]))
                return null;

            return new CredentialRequest()
            {
                UserName = credentials[0],
                Password = credentials[1],
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        private CredentialRequest ParseAuthorizationHeaderBearse(JwtSecurityToken token)
        {
            string dinetApiUser = String.Empty;
            string dinetApiPassword = String.Empty;

            try
            {
                dinetApiUser = token.Payload["D4WIntegrationUsr"].ToString();
                dinetApiPassword = token.Payload["D4WIntegrationPass"].ToString();
            }
            catch
            {
                dinetApiUser = token.Payload["DinetApiUser"].ToString();
                dinetApiPassword = token.Payload["DinetApiPassword"].ToString();
            }

            return new CredentialRequest()
            {
                UserName = dinetApiUser,
                Password = dinetApiPassword
            };
        }
    }
}