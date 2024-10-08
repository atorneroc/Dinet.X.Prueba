using System.ServiceModel;

namespace Dinet.Integration.Implementation.WebService.Wrappers.Tracking
{
    /// <summary>
    /// 
    /// </summary>
    [MessageContract(IsWrapped = false)]
    public partial class TrackingRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [MessageBodyMemberAttribute(Name = "TrackingRequest", Namespace = "", Order = 0)]
        public TrackingTypeRequest itemRequest;

        /// <summary>
        /// 
        /// </summary>
        public TrackingRequest()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemRequest"></param>
        public TrackingRequest(TrackingTypeRequest itemRequest)
        {
            this.itemRequest = itemRequest;
        }
    }
}