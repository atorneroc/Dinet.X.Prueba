namespace Dinet.Integration.Domain.Wrapper.External.Document
{
    /// <summary>
    /// 
    /// </summary>
    public class DocumentSummaryDetailRequest
    {

        /// <summary>
        /// Code Article
        /// </summary>
        public string ArticleCode { get; set; }

        /// <summary>
        /// Code Article
        /// </summary>
        public string Article { get; set; }

        /// <summary>
        /// Code Article 
        /// </summary>
        public string UnitMeasureCode { get; set; }

        /// <summary>
        /// Quantity
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
    }
}