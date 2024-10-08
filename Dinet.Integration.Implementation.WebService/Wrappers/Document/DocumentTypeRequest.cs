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
    public partial class DocumentTypeRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 1)]
        public string Account { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 2)]
        public string NumberDocument { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 3)]
        public string TypeDocument { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 4)]
        public string NumberOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 5)]
        public string TypeDocumentReference { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 6)]
        public string NumberDocumentReference { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 7)]
        public string NumberDocumentReferenceAlm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 8)]
        public string NumberDocReferenceTra { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 9)]
        public string FlagAppointment { get; set; }

        //[XmlElementAttribute(Namespace = "", IsNullable = false, Order = 10)]
        //public string FlagSpecial { get; set; }

        //[XmlElementAttribute(Namespace = "", IsNullable = false, Order = 11)]
        //public string FlagUrgent { get; set; }

        //[XmlElementAttribute(Namespace = "", IsNullable = false, Order = 12)]
        //public string FlagCollet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 10)] //New
        public string TypeAttention { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 11)]
        public DateTime DateIssue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 12)]
        public DateTime DateEstimatedIssue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 13)]
        public DateTime DateEstimateDelivery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 14)]
        public string TypeOrigin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 15)]
        public string CodeEntityOrigin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 16)]
        public string NameEntityOrigin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 17)]
        public string AddressOrigin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 18)]
        public string UbigeoOrigin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 19)]
        public string TypeDestiny { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 20)]
        public string CodeEntityDestination { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 21)]
        public string NameEntityDestination { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 22)]
        public string AddressDestination { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 23)]
        public string UbigeoDestination { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 24)]
        public int Quantity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 25)]
        public double Weight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 26)]
        public double Volume { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 27)]
        public double ValueCommodity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 28)]
        public string AmountValueCommodity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 29)]
        public string Observation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 30)]
        public string DniPurchased { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 31)]
        public string PhonePurchased { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 32)]
        public string MailPurchased { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 33)]
        public string NameContact { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 34)]
        public string DniContact { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 35)]
        public int NumberOrderEntry { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 36)]
        public int TimeApproximateOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 37)]
        public string ReferenceAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 38)]
        public decimal Latitude { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 39)]
        public decimal Longitude { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 40)]
        public string ClassificationDocument { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 41)]
        public string TypeCommodityDocument { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 42)]
        public string FlagCuadrilla { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 43)]
        public string FlagGuard { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 44)]
        public string FlagSubjectHazard { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 45)]
        public string TypeLoad { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 46)]
        public string ViaTransport { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 47)]
        public string DescriptionMerchandise { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 48)]
        public string NumberContainer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 49)]
        public DateTime DateReturnContainer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 50)]
        public string CodePlaceReturnContainer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 51)]
        public string NamePlaceDeliveryContainer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 52)]
        public string AddressPlaceDeliveryContainer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 53)]
        public string UbigeoPlaceDeliveryContainer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 54)]
        public string PaymentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 55)]
        public string Tracking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 56)]
        public string Wildcard1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 57)]
        public string Wildcard2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 58)]
        public string Wildcard3 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 59)]
        public string Wildcard4 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 60)]
        public string Wildcard5 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 61)]
        public string UserCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 62)]
        public double QuantityPackages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 63)]
        public List<DocumentDetailRequest> DetailRequest;

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 64)]
        public List<DocumentLpnRequest> LpnRequest;
    }
}