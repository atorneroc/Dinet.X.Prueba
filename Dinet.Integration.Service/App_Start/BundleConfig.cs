using System.Web;
using System.Web.Optimization;

namespace Dinet.Integration.Service
{
    /// <summary>
    /// Clase que representa la Configuración de Bundle
    /// </summary>
    /// <remarks>
    /// Creación: Dinet 202109 <br />
    /// Modificación: 
    /// </remarks>
    public class BundleConfig
    {
        /// <summary>
        /// Constructor por Defecto de implementación de la clase
        /// </summary>
        public BundleConfig()
        {
        }

        /// <summary>
        /// Clase Estatica que Registra bundles
        /// </summary>
        /// <param name="bundles">Colección de bundles</param>
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Core
            bundles.Add(new ScriptBundle("~/bundles/core").Include(
                        "~/Scripts/Core/jquery.js",
                        "~/Scripts/Core/jquery.scrollLock.js",
                        "~/Scripts/Core/jquery.appear.js",
                        "~/Scripts/Core/codebase.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));
        }
    }
}