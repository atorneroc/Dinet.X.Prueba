using System.Collections.Generic;

namespace Dinet.Integration.Domain.Wrapper.Interfaces.Documento
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DocumentoResponse : BaseResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public string sNroIntDocu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string sNroTracking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<DocumentoEL> ListadoDocumento { get; set; }
    }
}