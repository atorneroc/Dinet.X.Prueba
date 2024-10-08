using System;
using System.Xml.Serialization;

namespace Dinet.Integration.Implementation.WebService.Wrappers.Document
{
    /// <summary>
    /// 
    /// </summary>
    [SerializableAttribute]
    [XmlTypeAttribute]
    public partial class DocumentLpnRequest
    {
        /// <summary>
        /// Numero Documento
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 1)]
        public string NumberDocument { get; set; }

        /// <summary>
        /// Correlativo Interno
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 2)]
        public int InternalCorrelative { get; set; }

        /// <summary>
        /// Lpn
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 3)]
        public string Lpn { get; set; }

        /// <summary>
        /// Cantidad Lpn Articulo
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 4)]
        public int Quantity { get; set; }
    }
}