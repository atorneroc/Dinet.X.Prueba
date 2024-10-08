using System;
using System.Xml.Serialization;

namespace Dinet.Integration.Implementation.WebService.Wrappers.Document
{
    /// <summary>
    /// 
    /// </summary>
    [SerializableAttribute]
    [XmlTypeAttribute]
    public partial class DocumentSummaryTypeResponse
    {
        /// <summary>
        /// Código de error
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 1)]
        public int ErrorCode { get; set; }

        /// <summary>
        /// Descripción del error
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 2)]
        public string ErrorDescription { get; set; }

        /// <summary>
        /// Nro interno de documento
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 3)]
        public string NumberInternalDocument { get; set; }

        /// <summary>
        /// Nro de Tracking
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 4)]
        public string TrackingNumber { get; set; }
    }
}