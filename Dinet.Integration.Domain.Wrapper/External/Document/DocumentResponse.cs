using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinet.Integration.Domain.Wrapper.External.Document
{
    /// <summary>
    /// Response que representa la informacion del documento
    /// </summary>
    /// <remarks>
    /// Creación: Dinet 202107 <br />
    /// Modificación: 
    /// </remarks>
    public class DocumentResponse : BaseResponse
    {
        /// <summary>
        /// Number Internal Document
        /// </summary>
        public string DocumentInternalNumber { get; set; }

        /// <summary>
        /// Number Tracking
        /// </summary>
        public string TrackingNumber { get; set; }
    }
}