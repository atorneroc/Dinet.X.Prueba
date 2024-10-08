using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Dinet.Integration.Implementation.WebService.Wrappers.Document
{
    /// <summary>
    /// 
    /// </summary>
    [SerializableAttribute]
    [XmlTypeAttribute]
    public partial class DocumentTypeResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 1)]
        public int ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 2)]
        public string ErrorDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 3)]
        public string NumberInternalDocument { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 4)]
        public string NumberTracking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 5)]
        public List<DocumentEL> ListDocument { get; set; }
    }
}