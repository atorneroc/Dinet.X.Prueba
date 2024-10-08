using System.Security.Principal;

namespace Dinet.Integration.WebApi.Authentication
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPrincipalProvider
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        IPrincipal CreatePrincipal(string username, string password);
    }
}