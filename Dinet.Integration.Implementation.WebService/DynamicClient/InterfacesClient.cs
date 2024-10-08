using Dinet.Integration.Domain.Common.Constants;
using Dinet.Integration.Domain.Wrapper.Interfaces.Documento;
using Dinet.Integration.Domain.Wrapper.Interfaces.Tracking;
using Newtonsoft.Json;
using System;
using System.Configuration;

namespace Dinet.Integration.Implementation.WebService.DynamicClient
{
    /// <summary>
    /// 
    /// </summary>
    public class InterfacesClient : BaseClient
    {
        static string keyUrlEndpoint = ConfigurationManager.AppSettings["WebApiInterfacesService"];

        #region [Documentos]
        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemRequest"></param>
        /// <returns></returns>
        public static DocumentoResponse DocumentoRegistrar(DocumentoRequest itemRequest)
        {
            DocumentoResponse result = new DocumentoResponse();

            try
            {
                string sUrlWebService = keyUrlEndpoint + "Documento/Registrar";
                var wsHeaderRequest = PostHeaderRequest(sUrlWebService);

                var resultService = PostServiceClient(wsHeaderRequest, itemRequest);
                if (resultService.ErrorCode != Enumerated.ResponseCode.CorrectCode)
                    throw new Exception(resultService.ErrorDescription);

                result = JsonConvert.DeserializeObject<DocumentoResponse>(resultService.ErrorDescription);
            }
            catch (Exception ex)
            {
                result.ErrorCode = Enumerated.ResponseCode.ErrorCodeApplication;
                result.ErrorDescription = ex.Message;
            }

            return result;
        }
        #endregion

        #region [Tracking]
        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemRequest"></param>
        /// <returns></returns>
        public static TrackingResponse TrackingRegistrar(TrackingRequest itemRequest)
        {
            TrackingResponse result = new TrackingResponse();

            try
            {
                string sUrlWebService = keyUrlEndpoint + "Tracking/Registrar";
                var wsHeaderRequest = PostHeaderRequest(sUrlWebService);

                var resultService = PostServiceClient(wsHeaderRequest, itemRequest);
                if (resultService.ErrorCode != Enumerated.ResponseCode.CorrectCode)
                    throw new Exception(resultService.ErrorDescription);

                result = JsonConvert.DeserializeObject<TrackingResponse>(resultService.ErrorDescription);
            }
            catch (Exception ex)
            {
                result.ErrorCode = Enumerated.ResponseCode.ErrorCodeApplication;
                result.ErrorDescription = ex.Message;
            }

            return result;
        }
        #endregion
    }
}