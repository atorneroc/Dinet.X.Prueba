using System;
using System.Xml.Serialization;

namespace Dinet.Integration.Implementation.WebService.Wrappers.Tracking
{
    /// <summary>
    /// 
    /// </summary>
    [XmlTypeAttribute]
    public partial class TrackingDetailRequest
    {
        /// <summary>
        /// Secuencia
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = true, Order = 1)]
        public Int32? Sequence { get; set; }

        /// <summary>
        /// NroDocumentoInterno
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 2)]
        public string InternalDocumentNumber { get; set; }

        /// <summary>
        /// TipoDocumentoInterno
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 3)]
        public string TypeInternalDocument { get; set; }

        /// <summary>
        /// StatusDocumento
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 4)]
        public string DocumentStatus { get; set; }

        /// <summary>
        /// CodigoArticulo
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 5)]
        public string ItemCode { get; set; }

        /// <summary>
        /// Articulo
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 6)]
        public string Article { get; set; }

        /// <summary>
        /// CodigoUMArticulo
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 7)]
        public string UMArticleCode { get; set; }

        /// <summary>
        /// CodigoUMCtrl
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 8)]
        public string UMCtrlCode { get; set; }

        /// <summary>
        /// CantidadDocumento
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = true, Order = 9)]
        public Int32? AmountDocument { get; set; }

        /// <summary>
        /// CantidadEvento
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = true, Order = 10)]
        public Int32? AmountEvent { get; set; }

        /// <summary>
        /// EstadoArticulo
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 11)]
        public string StateArticle { get; set; }

        /// <summary>
        /// CodigoLpn
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 12)]
        public string LPNCode { get; set; }

        /// <summary>
        /// CodigoUbicacion
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 13)]
        public string LocationCode { get; set; }

        /// <summary>
        /// CodigoSeccion
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 14)]
        public string SectionCode { get; set; }

        /// <summary>
        /// CodigoEstadoLPN
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 15)]
        public string LPNStateCode { get; set; }

        /// <summary>
        /// EstadoLPN
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 16)]
        public string StateLPN { get; set; }

        /// <summary>
        /// Volumen
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = true, Order = 17)]
        public Decimal? Volume { get; set; }

        /// <summary>
        /// TipoBL
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 18)]
        public string TypeBL { get; set; }

        /// <summary>
        /// NroContenedor
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 19)]
        public string ContainerNumber { get; set; }

        /// <summary>
        /// Peso
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = true, Order = 20)]
        public Decimal? Weight { get; set; }

        /// <summary>
        /// Bulto
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = true, Order = 21)]
        public Int32? Package { get; set; }

        /// <summary>
        /// FlagRecojo
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 22)]
        public string PickupFlag { get; set; }

        /// <summary>
        /// CodigoLinea
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 23)]
        public string LineCode { get; set; }

        /// <summary>
        /// Linea
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 24)]
        public string Line { get; set; }

        /// <summary>
        /// CodigoClase
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 25)]
        public string ClassCode { get; set; }

        /// <summary>
        /// Clase
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 26)]
        public string Class { get; set; }

        /// <summary>
        /// CodigoSubclase
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 27)]
        public string SubclassCode { get; set; }

        /// <summary>
        /// Subclase
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = false, Order = 28)]
        public string Subclass { get; set; }

        /// <summary>
        /// CantidadEnProceso
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = true, Order = 29)]
        public Int32? QuantityInProcess { get; set; }

        /// <summary>
        /// CantidadZonaDespacho
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = true, Order = 30)]
        public Int32? QuantityDispatchArea { get; set; }

        /// <summary>
        /// CantidadDespachada
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = true, Order = 31)]
        public Int32? DispatchedQuantity { get; set; }

        /// <summary>
        /// CantidadRecibida
        /// </summary>
        [XmlElementAttribute(Namespace = "", IsNullable = true, Order = 32)]
        public Int32? ReceivedAmount { get; set; }
    }
}