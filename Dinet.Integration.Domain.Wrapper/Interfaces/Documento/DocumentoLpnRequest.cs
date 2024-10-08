namespace Dinet.Integration.Domain.Wrapper.Interfaces.Documento
{
    /// <summary>
    /// 
    /// </summary>
    public class DocumentoLpnRequest
    {
        /// <summary>
        /// Numero Documento
        /// </summary>
        public string NumeroDocumento { get; set; }

        /// <summary>
        /// Correlativo Interno
        /// </summary>
        public int? CorrelativoInterno { get; set; }

        /// <summary>
        /// Cantiad de LPN por Articulo
        /// </summary>
        public int? CantidadLPN { get; set; }
        /// <summary>
        /// Lpn
        /// </summary>
        public string Lpn { get; set; }

        /// <summary>
        /// Cantidad Lpn Articulo
        /// </summary>
        public int? Cantidad { get; set; }

        /// <summary>
        /// Codigo de Articulo
        /// </summary>
        public string CodigoArticulo { get; set; }

        /// <summary>
        /// Peso
        /// </summary>
        public decimal? Peso { get; set; }

        /// <summary>
        /// Volumen
        /// </summary>
        public decimal? Volumen { get; set; }

        /// <summary>
        /// Alto
        /// </summary>
        public decimal? Alto { get; set; }

        /// <summary>
        /// Largo
        /// </summary>
        public decimal? Largo { get; set; }

        /// <summary>
        /// Ancho
        /// </summary>
        public decimal? Ancho { get; set; }
    }
}