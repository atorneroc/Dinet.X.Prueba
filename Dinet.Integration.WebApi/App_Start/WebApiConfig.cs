using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;

namespace Dinet.Integration.WebApi
{
    /// <summary>
    /// Clase que representa las Aplicaciones Web
    /// </summary>
    /// <remarks>
    /// Creación: Dinet 202107 <br />
    /// Modificación: 
    /// </remarks>
    public static class WebApiConfig
    {
        /// <summary>
        /// Clase  Estatica que Registra
        /// </summary>
        /// <param name="config">Configuración</param>
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.EnableSystemDiagnosticsTracing();

            config.Formatters.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter());
            config.Formatters.JsonFormatter.MediaTypeMappings.Add(new QueryStringMapping("type", "json", new MediaTypeHeaderValue("application/json")));

            config.Formatters.Add(new XmlMediaTypeFormatter());
            config.Formatters.XmlFormatter.MediaTypeMappings.Add(new QueryStringMapping("type", "xml", new MediaTypeHeaderValue("application/xml")));
            config.Formatters.XmlFormatter.UseXmlSerializer = true;
        }
    }
}