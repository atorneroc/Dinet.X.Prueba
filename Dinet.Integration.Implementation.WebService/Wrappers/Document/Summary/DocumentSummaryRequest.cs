using System.ServiceModel;

namespace Dinet.Integration.Implementation.WebService.Wrappers.Document
{
    /// <summary>
    /// 
    /// </summary>
    [MessageContract(IsWrapped = false)]
    public partial class DocumentSummaryRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [MessageBodyMemberAttribute(Name = "DocumentSummaryRequest", Namespace = "", Order = 0)]
        public DocumentSummaryTypeRequest itemRequest;

        /// <summary>
        /// 
        /// </summary>
        public DocumentSummaryRequest()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemRequest"></param>
        public DocumentSummaryRequest(DocumentSummaryTypeRequest itemRequest)
        {
            this.itemRequest = itemRequest;
        }
    }
}