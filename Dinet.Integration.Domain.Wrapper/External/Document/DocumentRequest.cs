using System;
using System.Collections.Generic;

namespace Dinet.Integration.Domain.Wrapper.External.Document
{
    /// <summary>
    /// 
    /// </summary>
    public class DocumentRequest
    {
        /// <summary>
        /// Cuenta
        /// </summary>
        //[Required]
        //[StringLength(5, ErrorMessage = "El parámetro Account debe tener un máximo de 5 caracteres.")]
        public string Account { get; set; }

        /// <summary>
        /// Numero Documento
        /// </summary>
        //[Required]
        //[StringLength(500, ErrorMessage = "El parámetro NumberDocument debe tener un máximo de 500 caracteres.")]
        public string NumberDocument { get; set; }

        /// <summary>
        /// Tipo Documento
        /// </summary>
        //[Required]
        //[StringLength(1, ErrorMessage = "El parámetro TypeDocument debe tener un máximo de 1 caracter.")]
        public string TypeDocument { get; set; }

        /// <summary>
        /// Numero Orden
        /// </summary>
        public string NumberOrder { get; set; }

        /// <summary>
        /// Tipo Documento Referencia
        /// </summary>
        public string TypeDocumentReference { get; set; }

        /// <summary>
        /// Numero Documento Referencia
        /// </summary>
        public string NumberDocumentReference { get; set; }

        /// <summary>
        /// Numero Documento Referencia Almacen
        /// </summary>
        public string NumberDocumentReferenceAlm { get; set; }

        /// <summary>
        /// Numero Documento Referencia Transporte
        /// </summary>
        public string NumberDocReferenceTra { get; set; }

        /// <summary>
        /// Flag Appointment
        /// </summary>
        public string FlagAppointment { get; set; }

        /// <summary>
        /// Tipo Atencion
        /// </summary>
        public string TypeAttention { get; set; }

        /// <summary>
        /// Fecha Emision
        /// </summary>
        //[Required]
        public DateTime? DateIssue { get; set; }

        /// <summary>
        /// Fecha Estimada
        /// </summary>
        //[Required]
        public DateTime? DateEstimatedIssue { get; set; }

        /// <summary>
        /// Fecha Estimada Entrega
        /// </summary>
        //[Required]
        public DateTime? DateEstimateDelivery { get; set; }

        /// <summary>
        /// Tipo Origen
        /// </summary>
        //[Required]
        //[StringLength(1, ErrorMessage = "El parámetro TypeOrigin debe tener un máximo de 1 caracter.")]
        public string TypeOrigin { get; set; }

        /// <summary>
        /// Codigo Entidad Origen
        /// </summary>
        //[Required]
        //[StringLength(60, ErrorMessage = "El parámetro CodeEntityOrigin debe tener un máximo de 60 caracteres.")]
        public string CodeEntityOrigin { get; set; }

        /// <summary>
        /// Entidad Origen
        /// </summary>
        //[Required]
        //[StringLength(60, ErrorMessage = "El parámetro NameEntityOrigin debe tener un máximo de 60 caracteres.")]
        public string NameEntityOrigin { get; set; }

        /// <summary>
        /// Direccion Origen
        /// </summary>
        public string AddressOrigin { get; set; }

        /// <summary>
        /// Ubigeo Origen
        /// </summary>
        //[Required]
        //[StringLength(6, ErrorMessage = "El parámetro UbigeoOrigin debe tener un máximo de 6 caracteres.")]
        public string UbigeoOrigin { get; set; }

        /// <summary>
        /// Tipo Destino
        /// </summary>
        //[Required]
        //[StringLength(1, ErrorMessage = "El parámetro TypeDestiny debe tener un máximo de 1 caracter.")]
        public string TypeDestiny { get; set; }

        /// <summary>
        /// Codigo Entidad Destino
        /// </summary>
        //[Required]
        //[StringLength(60, ErrorMessage = "El parámetro CodeEntityDestination debe tener un máximo de 60 caracteres.")]
        public string CodeEntityDestination { get; set; }

        /// <summary>
        /// Entidad Destino
        /// </summary>
        //[Required]
        //[StringLength(60, ErrorMessage = "El parámetro NameEntityDestination debe tener un máximo de 60 caracteres.")]
        public string NameEntityDestination { get; set; }

        /// <summary>
        /// Direccion Destino
        /// </summary>
        //[Required]
        //[StringLength(500, ErrorMessage = "El parámetro AddressDestination debe tener un máximo de 500 caracteres.")]
        public string AddressDestination { get; set; }

        /// <summary>
        /// Ubigeo Destino
        /// </summary>
        //[Required]
        //[StringLength(6, ErrorMessage = "El parámetro UbigeoDestination debe tener un máximo de 6 caracteres.")]
        public string UbigeoDestination { get; set; }

        /// <summary>
        /// Cantidad
        /// </summary>
        //[Required]
        public int Quantity { get; set; }

        /// <summary>
        /// Peso
        /// </summary>
        //[Required]
        public decimal? Weight { get; set; }

        /// <summary>
        /// Volumen
        /// </summary>
        //[Required]
        public decimal? Volume { get; set; }

        /// <summary>
        /// Valor Mercaderia 
        /// </summary>
        public decimal? ValueCommodity { get; set; }

        /// <summary>
        /// Amount Value Commodity
        /// </summary>
        public string AmountValueCommodity { get; set; }

        /// <summary>
        /// Obaservacion
        /// </summary>
        public string Observation { get; set; }

        /// <summary>
        /// DNI Comprador
        /// </summary>
        public string DniPurchased { get; set; }

        /// <summary>
        /// Telefono Comprador
        /// </summary>
        public string PhonePurchased { get; set; }

        /// <summary>
        /// Correo Comprador
        /// </summary>
        public string MailPurchased { get; set; }

        /// <summary>
        /// Nombre Contacto
        /// </summary>
        public string NameContact { get; set; }

        /// <summary>
        /// DNI Contacto
        /// </summary>
        public string DniContact { get; set; }

        /// <summary>
        /// Number Order Entry
        /// </summary>
        public int NumberOrderEntry { get; set; }

        /// <summary>
        /// Time Approximate Order
        /// </summary>
        public int TimeApproximateOrder { get; set; }

        /// <summary>
        /// Reference Address
        /// </summary>
        public string ReferenceAddress { get; set; }

        /// <summary>
        /// Latitud
        /// </summary>
        public decimal Latitude { get; set; }

        /// <summary>
        /// Longitud
        /// </summary>
        public decimal Longitude { get; set; }

        /// <summary>
        /// Clasificacion Documento
        /// </summary>
        //[Required]
        //[StringLength(500, ErrorMessage = "El parámetro ClassificationDocument debe tener un máximo de 500 caracteres.")]
        public string ClassificationDocument { get; set; }

        /// <summary>
        /// Type Commodity Document
        /// </summary>
        public string TypeCommodityDocument { get; set; }

        /// <summary>
        /// Flag Cuadrilla
        /// </summary>
        public string FlagCuadrilla { get; set; }

        /// <summary>
        /// Flag Guard
        /// </summary>
        public string FlagGuard { get; set; }

        /// <summary>
        /// Flag Subject Hazard
        /// </summary>
        public string FlagSubjectHazard { get; set; }

        /// <summary>
        /// Type Load
        /// </summary>
        public string TypeLoad { get; set; }

        /// <summary>
        /// Via Transport
        /// </summary>
        public string ViaTransport { get; set; }

        /// <summary>
        /// Description Merchandise
        /// </summary>
        public string DescriptionMerchandise { get; set; }

        /// <summary>
        /// Number Container
        /// </summary>
        public string NumberContainer { get; set; }

        /// <summary>
        /// Date Return Container
        /// </summary>
        public DateTime? DateReturnContainer { get; set; }

        /// <summary>
        /// Code Place ReturnContainer
        /// </summary>
        public string CodePlaceReturnContainer { get; set; }

        /// <summary>
        /// Name PlaceDelivery Container
        /// </summary>
        public string NamePlaceDeliveryContainer { get; set; }

        /// <summary>
        /// Address Place Delivery Container
        /// </summary>
        public string AddressPlaceDeliveryContainer { get; set; }

        /// <summary>
        /// Ubigeo Place Delivery Container
        /// </summary>
        public string UbigeoPlaceDeliveryContainer { get; set; }

        /// <summary>
        /// Payment Type
        /// </summary>
        public string PaymentType { get; set; }

        /// <summary>
        /// Tracking
        /// </summary>
        public string Tracking { get; set; }

        /// <summary>
        /// Wildcard1
        /// </summary>
        public string Wildcard1 { get; set; }

        /// <summary>
        /// Wildcard2
        /// </summary>
        public string Wildcard2 { get; set; }

        /// <summary>
        /// Wildcard3
        /// </summary>
        public string Wildcard3 { get; set; }

        /// <summary>
        /// Wildcard4
        /// </summary>
        public string Wildcard4 { get; set; }

        /// <summary>
        /// Wildcard5
        /// </summary>
        public string Wildcard5 { get; set; }

        /// <summary>
        /// User Code
        /// </summary>
        public string UserCode { get; set; }

        /// <summary>
        /// Quantity Packages
        /// </summary>
        public double QuantityPackages { get; set; }

        /// <summary>
        /// Number Internal Document
        /// </summary>
        public string NumberInternalDocument { get; set; }

        /// <summary>
        /// Number Tracking
        /// </summary>
        public string NumberTracking { get; set; }

        /// <summary>
        /// Nombre del archivo
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Fecha Fin de Emision
        /// </summary>
        public DateTime? DateIssueEnd { get; set; }

        /// <summary>
        /// Flag Impreso
        /// </summary>
        public int? FlagPrinted { get; set; }

        /// <summary>
        /// Departamento
        /// </summary>
        public string Departamento { get; set; }

        /// <summary>
        /// Provincia
        /// </summary>
        public string Provincia { get; set; }

        /// <summary>
        /// Distrito
        /// </summary>
        public string Distrito { get; set; }

        /// <summary>
        /// Origin Department 
        /// </summary>
        public string OriginDepartment { get; set; }

        /// <summary>
        /// Origin Province 
        /// </summary>
        public string OriginProvince { get; set; }

        /// <summary>
        /// Origin District 
        /// </summary>
        public string OriginDistrict { get; set; }

        /// <summary>
        /// Destiny Department 
        /// </summary>
        public string DestinationDepartment { get; set; }

        /// <summary>
        /// Destination Province 
        /// </summary>
        public string DestinationProvince { get; set; }

        /// <summary>
        /// Destiny District 
        /// </summary>
        public string DestinationDistrict { get; set; }

        /// <summary>
        /// Receive Name  
        /// </summary>
        public string ReceiveName { get; set; }

        /// <summary>
        /// Receive DNI   
        /// </summary>
        public string ReceiveDNI { get; set; }

        /// <summary>
        /// Account Code
        /// </summary>
        public string AccountCode { get; set; }

        /// <summary>
        /// Customer Order Number
        /// </summary>
        public string CustomerOrderNumber { get; set; }

        /// <summary>
        /// Address Origin
        /// </summary>
        public string OriginAddress { get; set; }

        /// <summary>
        /// Estimated Delivery Date
        /// </summary>
        public DateTime? EstimatedDeliveryDate { get; set; }

        /// <summary>
        /// Origin Entity Code
        /// </summary>
        public string OriginEntityCode { get; set; }

        /// <summary>
        /// Name Entity Origin
        /// </summary>
        public string OriginEntity { get; set; }

        /// <summary>
        /// Origin Ubigeo Code
        /// </summary>
        public string OriginUbigeoCode { get; set; }

        /// <summary>
        /// Destination Entity Code
        /// </summary>
        public string DestinationEntityCode { get; set; }

        /// <summary>
        /// Entidad Destino
        /// </summary>
        public string DestinationEntity { get; set; }

        /// <summary>
        /// Destination Address
        /// </summary>
        public string DestinationAddress { get; set; }

        /// <summary>
        /// Reference Address 
        /// </summary>
        public string AddressReference { get; set; }

        /// <summary>
        /// Destination Ubigeo Code
        /// </summary>
        public string DestinationUbigeoCode { get; set; }

        /// <summary>
        /// DNI Purchaser
        /// </summary>
        public string PurchaserDNI { get; set; }

        /// <summary>
        /// Phone Purchaser
        /// </summary>
        public string PurchaserPhone { get; set; }

        /// <summary>
        /// Mail Purchaser
        /// </summary>
        public string PurchaserMail { get; set; }

        /// <summary>
        /// User Code
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Id log Interface
        /// </summary>
        public Int32? IDLogInterface { get; set; }

        /// <summary>
        /// Id log Interface Detalle
        /// </summary>
        public Int32? IDLogInterfaceDetalle { get; set; }

        /// <summary>
        /// Marca de la cuenta
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// DetailRequest
        /// </summary>
        public List<DocumentDetailRequest> DetailRequest { get; set; }

        /// <summary>
        /// LpnRequest
        /// </summary>
        public List<DocumentLpnRequest> LpnRequest { get; set; }

    }
}