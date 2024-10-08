using System.ServiceModel;

namespace Dinet.Integration.Implementation.WebService.Wrappers.Document
{
    /// <summary>
    /// 
    /// </summary>
    [MessageContract(IsWrapped = false)]
    public partial class DocumentSummaryResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [MessageBodyMemberAttribute(Name = "DocumentSummaryResponse", Namespace = "", Order = 0)]
        public DocumentSummaryTypeResponse itemResponse;

        /// <summary>
        /// 
        /// </summary>
        public DocumentSummaryResponse()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemResponse"></param>
        public DocumentSummaryResponse(DocumentSummaryTypeResponse itemResponse)
        {
            this.itemResponse = itemResponse;
        }
    }
}