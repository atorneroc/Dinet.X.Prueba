namespace Dinet.Integration.Domain.Wrapper.External.Document
{
    /// <summary>
    /// 
    /// </summary>
    public class DocumentDetailRequest
    {
        /// <summary>
        /// Number Document
        /// </summary>
        public string NumberDocument { get; set; }

        /// <summary>
        /// Internal Correlative
        /// </summary>
        public int InternalCorrelative { get; set; }

        /// <summary>
        /// Correlative Client
        /// </summary>
        public string CorrelativeClient { get; set; }

        /// <summary>
        /// Code Article
        /// </summary>
        public string CodeArticle { get; set; }

        /// <summary>
        /// Description Article
        /// </summary>
        public string DescriptionArticle { get; set; }

        /// <summary>
        /// Unit Size
        /// </summary>
        public string UnitSize { get; set; }

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
        /// Batch Series
        /// </summary>
        public string BatchSeries { get; set; }

        /// <summary>
        /// Code Line
        /// </summary>
        public string CodeLine { get; set; }

        /// <summary>
        /// Code Class
        /// </summary>
        public string CodeClass { get; set; }

        /// <summary>
        /// Code SubClass
        /// </summary>
        public string CodeSubClass { get; set; }

        /// <summary>
        /// Name Line
        /// </summary>
        public string NameLine { get; set; }

        /// <summary>
        /// Name Class
        /// </summary>
        public string NameClass { get; set; }

        /// <summary>
        /// Name SubClass
        /// </summary>
        public string NameSubClass { get; set; }

        /// <summary>
        /// Flag IQPF
        /// </summary>
        public string FlagIQPF { get; set; }

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
        /// Customer Order Number
        /// </summary>
        public string CustomerOrderNumber { get; set; }
    }
}