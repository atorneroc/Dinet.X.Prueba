using Dinet.Integration.Domain.Common.Constants;
using System;
using System.IdentityModel.Selectors;
using System.Security.Principal;
using System.ServiceModel;
using System.Threading;

namespace Dinet.Integration.Implementation.WebService
{
    /// <summary>
    /// 
    /// </summary>
    public class Authenticator : UserNamePasswordValidator
    {
        /// <summary>
        /// Método que valida el nombre de usuario y la contraseña.
        /// </summary>
        /// <param name="userName">Nombre de usuario</param>
        /// <param name="password">Contraseña</param>
        public override void Validate(string userName, string password)
        {
            // Validar que el nombre de usuario y la contraseña no sean nulos o vacíos
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
                throw new ArgumentException("El nombre de usuario o la contraseña no pueden estar vacíos.");

            // Validar la identidad del usuario
            var oConfig = new System.Configuration.AppSettingsReader();

            if (userName != oConfig.GetValue("UsuarioHost", typeof(System.String)).ToString() ||
                password != oConfig.GetValue("ContraseniaHost", typeof(System.String)).ToString())
            {
                throw new FaultException("Usuario y/o contraseña no válida.");
            }

            // Almacenar las credenciales temporalmente en el hilo principal de la solicitud
            Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(userName), null);
            SetPasswordInPrincipal(password);
        }

        /// <summary>
        /// Almacenar el password en el hilo principal de la solicitud.
        /// </summary>
        private void SetPasswordInPrincipal(string password)
        {
            // Se usa una identidad personalizada que también almacena la contraseña
            var principal = Thread.CurrentPrincipal as GenericPrincipal;
            if (principal != null)
            {
                // Añadimos la contraseña como parte de la identidad (en un entorno real, considera encriptar la contraseña)
                Thread.SetData(Thread.GetNamedDataSlot("Password"), password);
            }
        }
    }
    
    /// <summary>
    /// Clase para almacenar las credenciales en el contexto de la solicitud.
    /// </summary>
    public class UserPasswordExtension : IExtension<OperationContext>
    {
        public string UserName { get; }
        public string Password { get; }

        /// <summary>
        /// Constructor para la clase UserPasswordExtension.
        /// </summary>
        /// <param name="userName">Nombre de usuario</param>
        /// <param name="password">Contraseña</param>
        public UserPasswordExtension(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        // Métodos requeridos por la interfaz IExtension
        public void Attach(OperationContext owner) { }
        public void Detach(OperationContext owner) { }
    }
}