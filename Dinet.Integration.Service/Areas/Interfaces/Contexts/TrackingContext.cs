using Dinet.Integration.Domain.Common.Constants;
using Dinet.Integration.Domain.Wrapper.Interfaces.Tracking;
using System;

namespace Dinet.Integration.Service.Areas.Interfaces.Contexts
{
    /// <summary>
    /// 
    /// </summary>
    public class TrackingContext
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="itemRequest"></param>
        /// <returns></returns>
        public TrackingResponse Registrar(TrackingRequest itemRequest)
        {
            TrackingResponse result = new TrackingResponse();

            try
            {

            }
            catch (Exception ex)
            {
                result.ErrorCode = Enumerated.ResponseCode.ErrorCodeApplication;
                result.ErrorDescription = ex.Message;
            }

            return result;
        }
    }
}