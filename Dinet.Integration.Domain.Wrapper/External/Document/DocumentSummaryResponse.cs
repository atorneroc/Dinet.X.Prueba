namespace Dinet.Integration.Domain.Wrapper.External.Document
{
    /// <summary>
    /// 
    /// </summary>
    public class DocumentSummaryResponse
    {
        /// <summary>
        /// Number Internal Document
        /// </summary>
        public string DocumentInternalNumber { get; set; }

        /// <summary>
        /// Number Tracking
        /// </summary>
        public string TrackingNumber { get; set; }

        /// <summary>
        /// Código del Error
        /// </summary>
        public int ErrorCode { get; set; }

        /// <summary>
        /// Descripción del Error
        /// </summary>
        public string ErrorDescription { get; set; }
    }
}