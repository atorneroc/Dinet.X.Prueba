using System;
using System.Collections.Generic;

namespace Dinet.Integration.Domain.Wrapper.External.Document
{
    /// <summary>
    /// 
    /// </summary>
    public class DocumentSummaryRequest
    {
        /// <summary>
        /// codigo Cuenta
        /// </summary>
        public string AccountCode { get; set; }

        /// <summary>
        /// Numero de pedido del cliente
        /// </summary>
        public string CustomerOrderNumber { get; set; }

        /// <summary>
        /// Codigo referencial
        /// </summary>
        public string NumberDocumentReference { get; set; }

        /// <summary>
        /// Clasificacion Documento
        /// </summary>
        public string ClassificationDocument { get; set; }

        /// <summary>
        /// Fecha y hora estimada de entrega del pedido
        /// </summary>
        public DateTime? EstimatedDeliveryDate { get; set; }

        /// <summary>
        /// Código del lugar de donde se recoge el pedido
        /// </summary>
        public string OriginEntityCode { get; set; }

        /// <summary>
        /// Nombre del origen de donde se recoge el pedido
        /// </summary>
        public string OriginEntity { get; set; }

        /// <summary>
        /// Dirección origen de donde se recoge el pedido
        /// </summary>
        public string OriginAddress { get; set; }

        /// <summary>
        /// departamento origen
        /// </summary>
        public string OriginDepartment { get; set; }

        /// <summary>
        /// provincia origen
        /// </summary>
        public string OriginProvince { get; set; }

        /// <summary>
        /// Distrito origen
        /// </summary>
        public string OriginDistrict { get; set; }

        /// <summary>
        /// Ubigeo origen
        /// </summary>
        public string OriginUbigeoCode { get; set; }

        /// <summary>
        /// Código del lugar donde entrega el pedido
        /// </summary>
        public string DestinationEntityCode { get; set; }

        /// <summary>
        /// Nombre del destino de entrega
        /// </summary>
        public string DestinationEntity { get; set; }

        /// <summary>
        /// Direccion destino entrega pedido
        /// </summary>
        public string DestinationAddress { get; set; }

        /// <summary>
        /// Referencia de direccion destino entrega pedido
        /// </summary>
        public string AddressReference { get; set; }

        /// <summary>
        /// Ubigeo de destino
        /// </summary>
        public string DestinationUbigeoCode { get; set; }

        /// <summary>
        /// Departamento destino
        /// </summary>
        public string DestinationDepartment { get; set; }

        /// <summary>
        /// Provincia destino
        /// </summary>
        public string DestinationProvince { get; set; }

        /// <summary>
        /// Distrito destino
        /// </summary>
        public string DestinationDistrict { get; set; }

        /// <summary>
        /// DNI del comprodor
        /// </summary>
        public string PurchaserDNI { get; set; }

        /// <summary>
        /// Telefono del comprador
        /// </summary>
        public string PurchaserPhone { get; set; }

        /// <summary>
        /// Correo del comprador
        /// </summary>
        public string PurchaserMail { get; set; }

        /// <summary>
        /// Nombre del que recibirá  el pedido
        /// </summary>
        public string ReceiveName { get; set; }

        /// <summary>
        /// DNI del que recibirá el pedido
        /// </summary>
        public string ReceiveDNI { get; set; }

        /// <summary>
        /// Cantidad total de unidades
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Cantidad de bultos a entregar
        /// </summary>
        public int QuantityPackages { get; set; }

        /// <summary>
        /// Observacion
        /// </summary>
        public string Observation { get; set; }

        /// <summary>
        /// Peso total de la mercadería
        /// </summary>
        public decimal? Weight { get; set; }

        /// <summary>
        /// Volumen total de la mercadería 
        /// </summary>
        public decimal? Volume { get; set; }

        /// <summary>
        /// Valor de la mercaderian a trasladar
        /// </summary>
        public decimal? MerchandiseValue { get; set; }

        /// <summary>
        /// Valor de la mercaderian a trasladar
        /// </summary>
        public string MerchandiseValueCurrency { get; set; }

        /// <summary>
        /// Coordenada Y de latitud
        /// </summary>
        public decimal? Latitude { get; set; }

        /// <summary>
        /// Coordenada X de longitud
        /// </summary>
        public decimal? Longitude { get; set; }

        /// <summary>
        /// Tipo de pago del cliente
        /// </summary>
        public string PaymentType { get; set; }

        /// <summary>
        /// Dato comodin 1
        /// </summary>
        public string Wildcard1 { get; set; }

        /// <summary>
        /// Dato comodin 2
        /// </summary>
        public string Wildcard2 { get; set; }

        /// <summary>
        /// Dato comodin 3
        /// </summary>
        public string Wildcard3 { get; set; }

        /// <summary>
        /// Dato comodin 4
        /// </summary>
        public string Wildcard4 { get; set; }

        /// <summary>
        /// Usuario
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Usuario
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Numero Documento Referencia Transportes
        /// </summary>
        public string NumberDocReferenceTra { get; set; }

        /// <summary>
        /// Detalle del pedido
        /// </summary>
        public List<DocumentSummaryDetailRequest> DetailRequest { get; set; }

        /// <summary>
        /// Detalle LPN será requerido según la operación del cliente
        /// </summary>
        public List<DocumentSummaryLpnRequest> LpnRequest { get; set; }
    }
}