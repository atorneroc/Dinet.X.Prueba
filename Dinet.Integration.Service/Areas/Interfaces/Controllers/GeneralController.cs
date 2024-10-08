using Dinet.Integration.Domain.Wrapper.Interfaces.General;
using Dinet.Integration.Service.Areas.Interfaces.Contexts;
using System.Web.Http;

namespace Dinet.Integration.Service.Areas.Interfaces.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class GeneralController : ApiController
    {
        #region [Configuraciones]
        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemRequest"></param>
        /// <returns></returns>
        [HttpPost]
        public ConfiguracionEquivalenciaResponse ConfiguracionEquivalenciaListar(ConfiguracionEquivalenciaRequest itemRequest)
        {
            var result = new GeneralContext().ConfiguracionEquivalenciaListar(itemRequest);
            return result;
        }
        #endregion

        #region [Equivalencias]
        /// <summary>
        /// Metodo para Listar la equivalencia del ubigeo
        /// </summary>
        /// <param name="itemRequest">Representa los parametros</param>
        /// <returns>Contiene el Resultado de la consulta</returns>
        [HttpPost]
        public EquivalenciaUbigeoResponse EquivalenciaUbigeoListar(EquivalenciaUbigeoRequest itemRequest)
        {
            var result = new GeneralContext().EquivalenciaUbigeoListar(itemRequest);
            return result;
        }
        #endregion
    }
}