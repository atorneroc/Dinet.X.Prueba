using System;
using System.Xml.Serialization;

namespace Dinet.Integration.Implementation.WebService.Wrappers.Document
{
    /// <summary>
    /// 
    /// </summary>
    [SerializableAttribute]
    [XmlTypeAttribute]
    public partial class DocumentSummaryDetailRequest
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
        public string Article { get; set; }

        /// <summary>
        ///
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 3)]
        public string UnitMeasureCode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 4)]
        public int Quantity { get; set; }

        /// <summary>
        ///
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 5)]
        public decimal Weight { get; set; }

        /// <summary>
        ///
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 6)]
        public decimal Volume { get; set; }

        /// <summary>
        ///
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 7)]
        public string Wildcard1 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 8)]
        public string Wildcard2 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 9)]
        public string Wildcard3 { get; set; }
    }
}