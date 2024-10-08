using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dinet.Integration.Service.Controllers
{
    /// <summary>
    ///
    /// </summary>
    /// <remarks>
    /// Creación:       DINET 202109  <br />
    /// Modificación:                 <br />
    /// </remarks>
    public class HomeController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}