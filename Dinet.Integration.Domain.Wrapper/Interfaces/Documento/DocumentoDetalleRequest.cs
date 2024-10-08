using System;

namespace Dinet.Integration.Domain.Wrapper.Interfaces.Documento
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DocumentoDetalleRequest
    {
        /// <summary>
        ///
        /// </summary>
        public string SNRO_DOC { get; set; }

        /// <summary>
        ///
        /// </summary>
        public int? NCORR_INTERNO { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string SCORR_CLIE { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string SCOD_ARTICULO { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string SDES_ARTICULO { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string SUNIDAD_MED { get; set; }

        /// <summary>
        ///
        /// </summary>
        public Int32? NCANTIDAD { get; set; }

        /// <summary>
        ///
        /// </summary>
        public decimal? NPESO { get; set; }

        /// <summary>
        ///
        /// </summary>
        public decimal? NVOLUMEN { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string SSERIE_LOTE { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string SCOD_LINEA { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string SCOD_CLASE { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string SCOD_SUB_CLASE { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string SNOM_LINEA { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string SNOM_CLASE { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string SNOM_SUB_CLASE { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string SFLAG_IQPF { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string SCOMODIN1 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string SCOMODIN2 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string SCOMODIN3 { get; set; }
    }
}