using Dinet.Integration.Domain.Common.Constants;
using Dinet.Integration.Domain.Wrapper.External.Document;
using Dinet.Integration.WebApi.Areas.Interfaces.Contexts;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.SessionState;

namespace Dinet.Integration.WebApi.Areas.Interfaces.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class DocumentController : ApiController, IRequiresSessionState
    {
        /// <summary>
        /// Método que permite registrar los documentos
        /// </summary>
        /// <param name="itemRequest">Representa los parametros del registro de documento</param>
        /// <returns>Retorna la respuesta de la peticion</returns>
        [HttpPost]
        [Authorize]
        public HttpResponseMessage Register([FromBody] DocumentRequest itemRequest)
        {
            DocumentResponse result = new DocumentContext().Register(itemRequest);

            if (result.ErrorCode != Enumerated.ResponseCode.CorrectCode)
                return Request.CreateResponse(HttpStatusCode.BadRequest, result);
            else
                return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        /// <summary>
        /// Método que permite registrar los documentos - versión mas reducida
        /// </summary>
        /// <param name="itemRequest">Representa los parametros del registro de documento</param>
        /// <returns>Retorna la respuesta de la peticion</returns>
        [HttpPost]
        [Authorize]
        public HttpResponseMessage SummaryRegister([FromBody] DocumentSummaryRequest itemRequest)
        {
            DocumentSummaryResponse result = new DocumentContext().SummaryRegister(itemRequest);

            if (result.ErrorCode != Enumerated.ResponseCode.CorrectCode)
                return Request.CreateResponse(HttpStatusCode.BadRequest, result);

            else
                return Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}