using System;

namespace Dinet.Integration.Domain.Wrapper.Interfaces.Tracking
{
    /// <summary>
    /// 
    /// </summary>
    public partial class TrackingDetalleRequest
    {
        /// <summary>
        /// 
        /// </summary>
        public Int32? Secuencia { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string NroDocumentoInterno { get; set; }

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
        public string CodigoArticulo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Articulo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CodigoUMArticulo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CodigoUMCtrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Int32? CantidadDocumento { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Int32? CantidadEvento { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string EstadoArticulo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CodigoLpn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CodigoUbicacion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CodigoSeccion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CodigoEstadoLPN { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string EstadoLPN { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Decimal? Volumen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TipoBL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string NroContenedor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Decimal? Peso { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Int32? Bulto { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string FlagRecojo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CodigoLinea { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Linea { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CodigoClase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Clase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CodigoSubClase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SubClase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Int32? CantidadEnProceso { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Int32? CantidadZonaDespacho { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Int32? CantidadDespachada { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Int32? CantidadRecibida { get; set; }
    }
}