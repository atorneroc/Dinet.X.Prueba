using System;
using System.Security.Principal;
using System.ServiceModel;
using System.Threading;

namespace Dinet.Integration.Implementation.WebService
{
    /// <summary>
    /// 
    /// </summary>
    public static class CredentialManager
    {
        /// <summary>
        /// Método para almacenar las credenciales en el contexto de la sesión
        /// </summary>
        /// <exception cref="InvalidOperationException"></exception>
        public static void StoreCredentialsInSession()
        {
            var principal = Thread.CurrentPrincipal as GenericPrincipal;
            if (principal != null)
            {
                var userName = principal.Identity.Name;
                var password = (string)Thread.GetData(Thread.GetNamedDataSlot("Password"));

                // Guardar las credenciales en la sesión de WCF (OperationContext Extensions)
                OperationContext.Current.Extensions.Add(new UserPasswordExtension(userName, password));
            }
            else
            {
                throw new InvalidOperationException("No se han encontrado las credenciales del usuario.");
            }
        }

        // Método para obtener las credenciales almacenadas en el contexto de la operación
        public static UserPasswordExtension GetCredentials()
        {
            var credentials = OperationContext.Current.Extensions.Find<UserPasswordExtension>();
            if (credentials == null)
            {
                throw new InvalidOperationException("Las credenciales no están disponibles en el contexto de la operación.");
            }
            return credentials;
        }
    }
}