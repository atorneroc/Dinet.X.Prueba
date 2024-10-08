using System;
using System.Security.Principal;
using System.ServiceModel;
using log4net;

namespace Dinet.Integration.WebApi.Authentication
{
    /// <summary>
    /// 
    /// </summary>
    public class PrincipalProvider : IPrincipalProvider
    {
        #region Properties
        ILog logAPI = LogManager.GetLogger("Integration");
        #endregion

        #region Constructor
        /// <summary>
        /// 
        /// </summary>
        public PrincipalProvider()
        {

        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public IPrincipal CreatePrincipal(string username, string password)
        {
            IPrincipal rPrincipal = null;

            try
            {
                // Validar la identidad del usuario
                var oConfig = new System.Configuration.AppSettingsReader();
                if (username != oConfig.GetValue("UsuarioHost", typeof(System.String)).ToString() ||
                    password != oConfig.GetValue("ContraseniaHost", typeof(System.String)).ToString())
                {
                    throw new FaultException("Usuario y/o contraseña no válida.");
                }

                var identity = new GenericIdentity(username);
                rPrincipal = new GenericPrincipal(identity, new[] { "User" });
            }
            catch (Exception ex)
            {
                logAPI.Error("Detail => " + ex.Message);
                throw ex;
            }

            return rPrincipal;
        }
    }
}