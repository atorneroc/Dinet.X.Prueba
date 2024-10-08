using System.ServiceModel;

namespace Dinet.Integration.Implementation.WebService.Wrappers.Document
{
    /// <summary>
    /// 
    /// </summary>
    [MessageContract(IsWrapped = false)]
    public partial class DocumentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [MessageBodyMemberAttribute(Name = "DocumentRequest", Namespace = "", Order = 0)]
        public DocumentTypeRequest itemRequest;

        /// <summary>
        /// 
        /// </summary>
        public DocumentRequest()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemRequest"></param>
        public DocumentRequest(DocumentTypeRequest itemRequest)
        {
            this.itemRequest = itemRequest;
        }
    }
}