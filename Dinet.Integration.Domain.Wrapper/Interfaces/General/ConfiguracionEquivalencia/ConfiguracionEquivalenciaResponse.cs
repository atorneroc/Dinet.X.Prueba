using System.Collections.Generic;

namespace Dinet.Integration.Domain.Wrapper.Interfaces.General
{
    /// <summary>
    /// 
    /// </summary>
    public class ConfiguracionEquivalenciaResponse : BaseResponse
    {
        /// <summary>
        /// Lista Configuracion Equivalencia
        /// </summary>
        public List<ConfiguracionEquivalenciaEL> ListaConfiguracionEquivalencia { get; set; }
    }
}