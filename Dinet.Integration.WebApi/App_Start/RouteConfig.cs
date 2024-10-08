using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Dinet.Integration.WebApi
{
    /// <summary>
    /// Clase que representa Configura la Ruta
    /// </summary>
    /// <remarks>
    /// Creación: Dinet 202107 <br />
    /// Modificación: 
    /// </remarks>
    public class RouteConfig
    {
        /// <summary>
        /// Constructor por Defecto de implementación de la clase
        /// </summary>
        public RouteConfig()
        {
        }

        /// <summary>
        /// Clase Estatica que registra Rutas
        /// </summary>
        /// <param name="routes">Ruta</param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}