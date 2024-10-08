using System.Collections.Generic;

namespace Dinet.Integration.Domain.Wrapper
{
    /// <summary>
    /// 
    /// </summary>
    public class BaseResponse
    {
        /// <summary>
        /// Codigo del Error
        /// </summary>
        public int ErrorCode { get; set; }

        /// <summary>
        /// Descripcion del Error
        /// </summary>
        public string ErrorDescription { get; set; }

        /// <summary>
        /// List de Errores Generales
        /// </summary>
        public List<BaseErrorEL> ListError { get; set; }
    }
}