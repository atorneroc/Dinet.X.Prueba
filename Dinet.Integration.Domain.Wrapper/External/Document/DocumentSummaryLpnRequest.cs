namespace Dinet.Integration.Domain.Wrapper.External.Document
{
    /// <summary>
    /// 
    /// </summary>
    public class DocumentSummaryLpnRequest
    {
        /// <summary>
        /// Code Article
        /// </summary>
        public string ArticleCode { get; set; }

        /// <summary>
        /// Lpn
        /// </summary>
        public string Lpn { get; set; }

        /// <summary>
        /// Cantidad Lpn Articulo
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Weight
        /// </summary>
        public decimal? Weight { get; set; }

        /// <summary>
        /// Volume
        /// </summary>
        public decimal? Volume { get; set; }
    }
}