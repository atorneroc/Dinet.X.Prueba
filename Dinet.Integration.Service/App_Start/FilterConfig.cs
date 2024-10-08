using System.Web;
using System.Web.Mvc;

namespace Dinet.Integration.Service
{
    /// <summary>
    /// Clase que representa la Configuracion de Filtro
    /// </summary>
    /// <remarks>
    /// Creación: Dinet 202109 <br />
    /// Modificación: 
    /// </remarks>
    public class FilterConfig
    {
        /// <summary>
        /// Constructor por Defecto de implementación de la clase
        /// </summary>
        public FilterConfig()
        {
        }

        /// <summary>
        /// Clase estatica que Registra Filtros Golbales
        /// </summary>
        /// <param name="filters">Filtro</param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}