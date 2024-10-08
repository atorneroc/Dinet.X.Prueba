using Dinet.Integration.Domain.Wrapper.Interfaces.Tracking;
using Dinet.Integration.Service.Areas.Interfaces.Contexts;
using System.Web.Http;

namespace Dinet.Integration.Service.Areas.Interfaces.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class TrackingController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemRequest"></param>
        /// <returns></returns>
        [HttpPost]
        public TrackingResponse Registrar(TrackingRequest itemRequest)
        {
            var result = new TrackingContext().Registrar(itemRequest);
            return result;
        }
    }
}