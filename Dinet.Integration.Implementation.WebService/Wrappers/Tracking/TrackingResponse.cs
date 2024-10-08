using System.ServiceModel;

namespace Dinet.Integration.Implementation.WebService.Wrappers.Tracking
{
    /// <summary>
    /// 
    /// </summary>
    [MessageContract(IsWrapped = false)]
    public partial class TrackingResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [MessageBodyMemberAttribute(Name = "TrackingResponse", Namespace = "", Order = 0)]
        public TrackingTypeResponse itemResponse;

        /// <summary>
        /// 
        /// </summary>
        public TrackingResponse()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemResponse"></param>
        public TrackingResponse(TrackingTypeResponse itemResponse)
        {
            this.itemResponse = itemResponse;
        }
    }
}