namespace Dinet.Integration.WebApi.Authentication
{
    /// <summary>
    /// 
    /// </summary>
    public class CredentialRequest
    {
        /// <summary>
        /// Usuario
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Contraseña
        /// </summary>
        public string Password { get; set; }
    }
}