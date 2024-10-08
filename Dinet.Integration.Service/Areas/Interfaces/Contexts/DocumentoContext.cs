using Dinet.Integration.Domain.Common.Constants;
using Dinet.Integration.Domain.Wrapper.Interfaces.Documento;
using System;

namespace Dinet.Integration.Service.Areas.Interfaces.Contexts
{
    /// <summary>
    /// 
    /// </summary>
    public class DocumentoContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemRequest"></param>
        /// <returns></returns>
        public DocumentoResponse Registrar(DocumentoRequest itemRequest)
        {
            DocumentoResponse result = new DocumentoResponse();

            try
            {

            }
            catch (Exception ex)
            {
                result.ErrorCode = Enumerated.ResponseCode.ErrorCodeApplication;
                result.ErrorDescription = ex.Message;
            }

            return result;
        }
    }
}