using System.Web.Http;
using System.Web.Mvc;

namespace Dinet.Integration.WebApi.Areas.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public class InterfacesAreaRegistration : AreaRegistration
    {
        /// <summary>
        /// 
        /// </summary>
        public override string AreaName
        {
            get
            {
                return "Interfaces";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.Routes.MapHttpRoute(
                "Interfaces_default2",
                "api/Interfaces/{controller}/{action}/{id}",
                new { id = UrlParameter.Optional }
            );

            context.MapRoute(
                "Interfaces_default",
                "Interfaces/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}