namespace Dinet.Integration.Domain.Wrapper.External.Document
{
    /// <summary>
    /// 
    /// </summary>
    public class DocumentLpnRequest
    {
        /// <summary>
        /// Codigo Cuenta
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// Numero Documento
        /// </summary>
        public string NumberDocument { get; set; }

        /// <summary>
        /// Correlativo Interno
        /// </summary>
        public int InternalCorrelative { get; set; }

        /// <summary>
        /// Lpn
        /// </summary>
        public string Lpn { get; set; }

        /// <summary>
        /// Cantidad Lpn Articulo
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// User
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Terminal
        /// </summary>
        public string Terminal { get; set; }

        /// <summary>
        /// Flag Force Lpn 
        /// </summary>
        public int FlagForceLpn { get; set; }

        /// <summary>
        /// Customer Order Number
        /// </summary>
        public string CustomerOrderNumber { get; set; }

        /// <summary>
        /// Code Article
        /// </summary>
        public string ArticleCode { get; set; }
    }
}