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
    public partial class DocumentSummaryTypeRequest
    {
        /// <summary>
        /// Código de cuenta
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 1)]
        public string AccountCode { get; set; }

        /// <summary>
        /// Nro de pedido
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 2)]
        public string CustomerOrderNumber { get; set; }

        /// <summary>
        /// Nro documento de referencia
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 3)]
        public string NumberDocumentReference { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 4)]
        public string ClassificationDocument { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 5)]
        public DateTime EstimatedDeliveryDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 6)]
        public string OriginEntityCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 7)]
        public string OriginEntity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 8)]
        public string OriginAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 9)]
        public string OriginDepartment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 10)]
        public string OriginProvince { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 11)]
        public string OriginDistrict { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 12)]
        public string OriginUbigeoCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 13)]
        public string DestinationEntityCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 14)]
        public string DestinationEntity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 15)]
        public string DestinationAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 16)]
        public string AddressReference { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 17)]
        public string DestinationUbigeoCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 18)]
        public string DestinationDepartment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 19)]
        public string DestinationProvince { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 20)]
        public string DestinationDistrict { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 21)]
        public string PurchaserDNI { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 22)]
        public string PurchaserPhone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 23)]
        public string PurchaserMail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 24)]
        public string ReceiveName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 25)]
        public string ReceiveDNI { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 26)]
        public int Quantity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 27)]
        public int QuantityPackages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 28)]
        public string Observation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = true, Order = 29)]
        public decimal? Weight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = true, Order = 30)]
        public decimal? Volume { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = true, Order = 31)]
        public decimal? MerchandiseValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 32)]
        public string MerchandiseValueCurrency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 33)]
        public decimal Latitude { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 34)]
        public decimal Longitude { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 35)]
        public string PaymentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 36)]
        public string Brand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 37)]
        public string Wildcard1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 38)]
        public string Wildcard2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 39)]
        public string Wildcard3 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 40)]
        public string Wildcard4 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 41)]
        public string User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 42)]
        public List<DocumentSummaryDetailRequest> DetailRequest { get; set; } = new List<DocumentSummaryDetailRequest>();

        /// <summary>
        /// 
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 43)]
        public List<DocumentSummaryLpnRequest> LpnRequest { get; set; } = new List<DocumentSummaryLpnRequest>();

        /// <summary>
        /// Para iniciar los valores por defecto
        /// </summary>
        public DocumentSummaryTypeRequest()
        {
            InitializeDefaults();
        }
        private void InitializeDefaults()
        {
            Weight = Weight ?? 0;
            Volume = Volume ?? 0;
            Latitude = Latitude != 0 ? Latitude : 0; // Asegurar que Latitude no sea nula
            Longitude = Longitude != 0 ? Longitude : 0; // Asegurar que Longitude no sea nula
            MerchandiseValue = MerchandiseValue ?? 0;
        }
    }
}