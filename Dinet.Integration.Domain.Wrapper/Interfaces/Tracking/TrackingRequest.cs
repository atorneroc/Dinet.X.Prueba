using System;
using System.Collections.Generic;

namespace Dinet.Integration.Domain.Wrapper.Interfaces.Tracking
{
    /// <summary>
    /// 
    /// </summary>
    public partial class TrackingRequest
    {
        /// <summary>
        /// 
        /// </summary>
        public string CodigoSistema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CodigoCuenta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CodigoAlmacen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Almacen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TipoDocumentoCliente { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string NroDocumentoCliente { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string NroExternoGuia { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string NroDocumentoInterno { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string NroGuia { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string NroPicking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CodigoMotivo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Motivo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TipoDocumentoInterno { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string StatusDocumento { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string StatusEvento { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? FechaDocumento { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? FechaHoraEvento { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CodigoClienteProveedor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ClienteProveedor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CodigoProveedorTransporte { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ProveedorTransporte { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PlacaVehiculo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CodigoConductor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Conductor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Decimal? GeoLongitudX { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Decimal? GeoLatitudY { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string RazonNoEntrega { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? FechaEntrega { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string NroTracking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Int32? IdImagen1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Int32? IdImagen2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Int32? IdImagen3 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Int32? IdImagen4 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CodigoDocumentoReferencia1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string NroDocumentoReferencia1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CodigoDocumentoReferencia2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string NroDocumentoReferencia2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CodigoDocumentoReferencia3 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string NroDocumentoReferencia3 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string UbigeoOrigen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string UbigeoDestino { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CodigoEntidadOrigen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string EntidadOrigen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CodigoCDTMS { get; set; }

        /// <summary>
        /// TelefonoContacto
        /// </summary>
        public string TelefonoContacto { get; set; }

        /// <summary>
        /// Correo Contacto
        /// </summary>
        public string CorreoContacto { get; set; }

        /// <summary>
        /// DNI Contacto
        /// </summary>
        public string DniContacto { get; set; }

        /// <summary>
        /// Nombre Contacto
        /// </summary>
        public string NombreContacto { get; set; }

        /// <summary>
        /// TelefonoContacto 2
        /// </summary>
        public string TelefonoContacto2 { get; set; }

        /// <summary>
        /// Correo Contacto 2
        /// </summary>
        public string CorreoContacto2 { get; set; }

        /// <summary>
        /// DNI Contacto 2
        /// </summary>
        public string DniContacto2 { get; set; }

        /// <summary>
        /// Nombre Contacto 2
        /// </summary>
        public string NombreContacto2 { get; set; }

        /// <summary>
        /// TelefonoContacto 3
        /// </summary>
        public string TelefonoContacto3 { get; set; }

        /// <summary>
        /// Correo Contacto 3
        /// </summary>
        public string CorreoContacto3 { get; set; }

        /// <summary>
        /// DNI Contacto 3
        /// </summary>
        public string DniContacto3 { get; set; }

        /// <summary>
        /// Nombre Contacto 3
        /// </summary>
        public string NombreContacto3 { get; set; }

        /// <summary>
        /// Direccion 1
        /// </summary>
        public string Direccion1 { get; set; }

        /// <summary>
        /// Direccion 2
        /// </summary>
        public string Direccion2 { get; set; }

        /// <summary>
        /// Direccion 3
        /// </summary>
        public string Direccion3 { get; set; }

        /// <summary>
        /// RUC
        /// </summary>
        public string Ruc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<TrackingDetalleRequest> DetalleRequest { get; set; }
    }
}