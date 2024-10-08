using System.ServiceModel;

namespace Dinet.Integration.Implementation.WebService.Wrappers.Document
{
    /// <summary>
    /// 
    /// </summary>
    [MessageContract(IsWrapped = false)]
    public partial class DocumentResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [MessageBodyMemberAttribute(Name = "DocumentResponse", Namespace = "", Order = 0)]
        public DocumentTypeResponse itemResponse;

        /// <summary>
        /// 
        /// </summary>
        public DocumentResponse()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemResponse"></param>
        public DocumentResponse(DocumentTypeResponse itemResponse)
        {
            this.itemResponse = itemResponse;
        }
    }
}