using System;
using System.Xml.Serialization;

namespace Dinet.Integration.Implementation.WebService.Wrappers.Document
{
    /// <summary>
    /// 
    /// </summary>
    [SerializableAttribute]
    [XmlTypeAttribute]
    public partial class DocumentSummaryLpnRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 1)]
        public string ArticleCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 2)]
        public string Lpn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 3)]
        public int Quantity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 4)]
        public decimal Volume { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 5)]
        public decimal Weight { get; set; }
    }
}