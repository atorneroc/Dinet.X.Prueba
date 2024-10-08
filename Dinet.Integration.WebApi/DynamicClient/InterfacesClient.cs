using Dinet.Integration.Domain.Common.Constants;
using Dinet.Integration.Domain.Wrapper.Interfaces.General;
using Dinet.Integration.Domain.Wrapper.Interfaces.Documento;
using Newtonsoft.Json;
using System;
using System.Configuration;

namespace Dinet.Integration.WebApi.DynamicClient
{
    /// <summary>
    /// 
    /// </summary>
    public class InterfacesClient : BaseClient
    {
        static string keyUrlEndpoint = ConfigurationManager.AppSettings["WebApiInterfacesService"];

        #region [General]
        #region [Configuraciones]
        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemRequest"></param>
        /// <returns></returns>
        public static ConfiguracionEquivalenciaResponse GeneralConfiguracionEquivalenciaListar(ConfiguracionEquivalenciaRequest itemRequest)
        {
            ConfiguracionEquivalenciaResponse result = new ConfiguracionEquivalenciaResponse();

            try
            {
                string sUrlWebService = keyUrlEndpoint + "General/ConfiguracionEquivalenciaListar";
                var wsHeaderRequest = PostHeaderRequest(sUrlWebService);

                var resultService = PostServiceClient(wsHeaderRequest, itemRequest);
                if (resultService.ErrorCode != Enumerated.ResponseCode.CorrectCode)
                    throw new Exception(resultService.ErrorDescription);

                result = JsonConvert.DeserializeObject<ConfiguracionEquivalenciaResponse>(resultService.ErrorDescription);
            }
            catch (Exception ex)
            {
                result.ErrorCode = Enumerated.ResponseCode.ErrorCodeApplication;
                result.ErrorDescription = ex.Message;
            }

            return result;
        }
        #endregion

        #region [Equivalencias]
        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemRequest"></param>
        /// <returns></returns>
        public static EquivalenciaUbigeoResponse GeneralEquivalenciaUbigeoListar(EquivalenciaUbigeoRequest itemRequest)
        {
            EquivalenciaUbigeoResponse result = new EquivalenciaUbigeoResponse();

            try
            {
                string sUrlWebService = keyUrlEndpoint + "General/EquivalenciaUbigeoListar";
                var wsHeaderRequest = PostHeaderRequest(sUrlWebService);

                var resultService = PostServiceClient(wsHeaderRequest, itemRequest);
                if (resultService.ErrorCode != Enumerated.ResponseCode.CorrectCode)
                    throw new Exception(resultService.ErrorDescription);

                result = JsonConvert.DeserializeObject<EquivalenciaUbigeoResponse>(resultService.ErrorDescription);
            }
            catch (Exception ex)
            {
                result.ErrorCode = Enumerated.ResponseCode.ErrorCodeApplication;
                result.ErrorDescription = ex.Message;
            }

            return result;
        }
        #endregion
        #endregion

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
    }
}