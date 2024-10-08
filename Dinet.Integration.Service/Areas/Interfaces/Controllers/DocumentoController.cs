using Dinet.Integration.Domain.Wrapper.Interfaces.Documento;
using Dinet.Integration.Service.Areas.Interfaces.Contexts;
using System.Web.Http;

namespace Dinet.Integration.Service.Areas.Interfaces.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class DocumentoController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemRequest"></param>
        /// <returns></returns>
        [HttpPost]
        public DocumentoResponse Registrar(DocumentoRequest itemRequest)
        {
            var result = new DocumentoContext().Registrar(itemRequest);
            return result;
        }
    }
}