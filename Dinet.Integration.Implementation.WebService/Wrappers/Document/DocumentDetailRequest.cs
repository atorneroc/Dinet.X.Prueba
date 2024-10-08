using System;
using System.Xml.Serialization;

namespace Dinet.Integration.Implementation.WebService.Wrappers.Document
{
    /// <summary>
    /// 
    /// </summary>
    [SerializableAttribute]
    [XmlTypeAttribute]
    public partial class DocumentDetailRequest
    {
        /// <summary>
        ///
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 1)]
        public string NumberDocument { get; set; }

        /// <summary>
        ///
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 2)]
        public int InternalCorrelative { get; set; }

        /// <summary>
        ///
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 3)]
        public string CorrelativeClient { get; set; }

        /// <summary>
        ///
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 4)]
        public string CodeArticle { get; set; }

        /// <summary>
        ///
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 5)]
        public string DescriptionArticle { get; set; }

        /// <summary>
        ///
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 6)]
        public string UnitSize { get; set; }

        /// <summary>
        ///
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 7)]
        public int Quantity { get; set; }

        /// <summary>
        ///
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 8)]
        public double Weight { get; set; }

        /// <summary>
        ///
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 9)]
        public double Volume { get; set; }

        /// <summary>
        ///
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 10)]
        public string BatchSeries { get; set; }

        /// <summary>
        ///
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 11)]
        public string CodeLine { get; set; }

        /// <summary>
        ///
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 12)]
        public string CodeClass { get; set; }

        /// <summary>
        ///
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 13)]
        public string CodeSubClass { get; set; }

        /// <summary>
        ///
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 14)]
        public string NameLine { get; set; }

        /// <summary>
        ///
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 15)]
        public string NameClass { get; set; }

        /// <summary>
        ///
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 16)]
        public string NameSubClass { get; set; }

        /// <summary>
        ///
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 17)]
        public string FlagIQPF { get; set; }

        /// <summary>
        ///
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 18)]
        public string Wildcard1 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 19)]
        public string Wildcard2 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 20)]
        public string Wildcard3 { get; set; }        
    }
}