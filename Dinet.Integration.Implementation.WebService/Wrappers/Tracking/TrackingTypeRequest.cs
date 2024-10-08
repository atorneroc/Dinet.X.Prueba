using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Dinet.Integration.Implementation.WebService.Wrappers.Tracking
{
    /// <summary>
    /// 
    /// </summary>
    [XmlTypeAttribute]
    public partial class TrackingTypeRequest
    {
        /// <summary>
        /// CodigoSistema
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 1)]
        public string SystemCode { get; set; }

        /// <summary>
        /// CodigoCuenta
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 2)]
        public string AccountCode { get; set; }

        /// <summary>
        /// CodigoAlmacen
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 3)]
        public string WarehouseCode { get; set; }

        /// <summary>
        /// Almacen
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 4)]
        public string Warehouse { get; set; }

        /// <summary>
        /// TipoDocumentoCliente
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 5)]
        public string DocumentTypeClient { get; set; }

        /// <summary>
        /// NroDocumentoCliente
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 6)]
        public string ClientDocumentNumber { get; set; }

        /// <summary>
        /// NroExternoGuia
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 7)]
        public string NumberOfExternalGuide { get; set; }

        /// <summary>
        /// NroDocumentoInterno
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 8)]
        public string InternalDocumentNumber { get; set; }

        /// <summary>
        /// NroGuia
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 9)]
        public string GuideNumber { get; set; }

        /// <summary>
        /// NroPicking
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 10)]
        public string PickingNumber { get; set; }

        /// <summary>
        /// CodigoMotivo
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 11)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// Motivo
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 12)]
        public string Reason { get; set; }

        /// <summary>
        /// TipoDocumentoInterno
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 13)]
        public string TypeOfInternalDocument { get; set; }

        /// <summary>
        /// StatusDocumento
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 14)]
        public string StatusDocument { get; set; }

        /// <summary>
        /// StatusEvento
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 15)]
        public string StatusEvent { get; set; }

        /// <summary>
        /// FechaDocumento
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = true, Order = 16)]
        public DateTime? DocumentDate { get; set; }

        /// <summary>
        /// FechaHoraEvento
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = true, Order = 17)]
        public DateTime? DateTimeOfEvent { get; set; }

        /// <summary>
        /// CodigoClienteProveedor
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 18)]
        public string ClientProviderCode { get; set; }

        /// <summary>
        /// ClienteProveedor
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 19)]
        public string ClientProvider { get; set; }

        /// <summary>
        /// CodigoProveedorTransporte
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 20)]
        public string SupplierTransportationCode { get; set; }

        /// <summary>
        /// ProveedorTransporte
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 21)]
        public string TransportationProvider { get; set; }

        /// <summary>
        /// PlacaVehiculo
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 22)]
        public string VehicleLicensePlate { get; set; }

        /// <summary>
        /// CodigoConductor
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 23)]
        public string DriverCode { get; set; }

        /// <summary>
        /// Conductor
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 24)]
        public string Driver { get; set; }

        /// <summary>
        /// GeoLongitudX
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = true, Order = 25)]
        public Decimal? GeoLengthX { get; set; }

        /// <summary>
        /// GeoLatitudY
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = true, Order = 26)]
        public Decimal? GeoLatitudeY { get; set; }

        /// <summary>
        /// RazonNoEntrega
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 27)]
        public string ReasonNoDelivery { get; set; }

        /// <summary>
        /// FechaEntrega
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = true, Order = 28)]
        public DateTime? DateOfDelivery { get; set; }

        /// <summary>
        /// NroTracking
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 29)]
        public string NumberOfTracking { get; set; }

        /// <summary>
        /// IdImagen1
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = true, Order = 30)]
        public Int32? IdImage1 { get; set; }

        /// <summary>
        /// IdImagen2
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = true, Order = 31)]
        public Int32? IdImage2 { get; set; }

        /// <summary>
        /// IdImagen3
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = true, Order = 32)]
        public Int32? IdImage3 { get; set; }

        /// <summary>
        /// IdImagen4
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = true, Order = 33)]
        public Int32? IdImage4 { get; set; }

        /// <summary>
        /// CodigoDocumentoReferencia1
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 34)]
        public string DocumentCodeReference1 { get; set; }

        /// <summary>
        /// NroDocumentoReferencia1
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 35)]
        public string DocumentNumberReference1 { get; set; }

        /// <summary>
        /// CodigoDocumentoReferencia2
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 36)]
        public string DocumentCodeReference2 { get; set; }

        /// <summary>
        /// NroDocumentoReferencia2
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 37)]
        public string DocumentNumberReference2 { get; set; }

        /// <summary>
        /// CodigoDocumentoReferencia3
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 38)]
        public string DocumentCodeReference3 { get; set; }

        /// <summary>
        /// NroDocumentoReferencia3
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 39)]
        public string DocumentNumberReference3 { get; set; }

        /// <summary>
        /// UbigeoOrigen
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 40)]
        public string UbigeoOrigin { get; set; }

        /// <summary>
        /// UbigeoDestino
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 41)]
        public string UbigeoDestination { get; set; }

        /// <summary>
        /// CodigoEntidadOrigen
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 42)]
        public string SourceEntityCode { get; set; }

        /// <summary>
        /// EntidadOrigen
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 43)]
        public string OriginEntity { get; set; }

        /// <summary>
        /// CodigoCDTMS
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 44)]
        public string CDTMSCode { get; set; }

        /// <summary>
        /// Contact Phone
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 45)]
        public string ContactPhone { get; set; }

        /// <summary>
        /// Contact Mail
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 46)]
        public string ContactMail { get; set; }

        /// <summary>
        /// Contact Identity Document
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 47)]
        public string ContactIdentityDocument { get; set; }

        /// <summary>
        /// Contact Name
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 48)]
        public string ContactName { get; set; }

        /// <summary>
        /// Contact Phone
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 49)]
        public string ContactPhone2 { get; set; }

        /// <summary>
        /// Contact Mail
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 50)]
        public string ContactMail2 { get; set; }

        /// <summary>
        /// Contact Identity Document
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 51)]
        public string ContactIdentityDocument2 { get; set; }

        /// <summary>
        /// Contact Name
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 52)]
        public string ContactName2 { get; set; }

        /// <summary>
        /// Contact Phone
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 53)]
        public string ContactPhone3 { get; set; }

        /// <summary>
        /// Contact Mail
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 54)]
        public string ContactMail3 { get; set; }

        /// <summary>
        /// Contact Identity Document
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 55)]
        public string ContactIdentityDocument3 { get; set; }

        /// <summary>
        /// Contact Name
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 56)]
        public string ContactName3 { get; set; }

        /// <summary>
        /// Address 1
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 57)]
        public string Address1 { get; set; }

        /// <summary>
        /// Address 2
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 58)]
        public string Address2 { get; set; }

        /// <summary>
        /// Address3
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 59)]
        public string Address3 { get; set; }

        /// <summary>
        /// Ruc
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 60)]
        public string Ruc { get; set; }

        /// <summary>
        /// DetalleRequest
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 61)]
        public List<TrackingDetailRequest> DetailRequest { get; set; }
    }
}