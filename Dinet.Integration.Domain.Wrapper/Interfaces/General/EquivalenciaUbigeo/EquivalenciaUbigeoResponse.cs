using System.Collections.Generic;

namespace Dinet.Integration.Domain.Wrapper.Interfaces.General
{
    /// <summary>
    /// 
    /// </summary>
    public class EquivalenciaUbigeoResponse : BaseResponse
    {
        /// <summary>
        /// Numero Documento
        /// </summary>
        public List<EquivalenciaUbigeoEL> ListaEquivalenciaUbigeo { get; set; }
    }
}