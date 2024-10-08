namespace Dinet.Integration.Domain.Wrapper
{
    /// <summary>
    /// 
    /// </summary>
    public class BaseErrorEL
    {
        /// <summary>
        /// Codigo de Error
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Descripcion de Error
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Parametros de error, si esque lo necesita
        /// </summary>
        public string Parameters { get; set; }
    }
}