using Dinet.Integration.Domain.Common.Constants;
using Dinet.Integration.Domain.Wrapper;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;

namespace Dinet.Integration.WebApi.DynamicClient
{
    /// <summary>
    /// 
    /// </summary>
    public class BaseClient
    {
        #region [GET]
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private static HttpWebRequest GetHeaderRequest(string url)
        {
            #region [Force TLS 2.0]
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            #endregion

            HttpWebRequest headerRequest = (HttpWebRequest)WebRequest.Create(url);
            headerRequest.ContentType = "application/json";
            headerRequest.Method = "GET";

            //if (!String.IsNullOrEmpty(valueToken))
            //    headerRequest.Headers.Add("Authorization", "Bearer " + valueToken);

            return headerRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="wsRequest"></param>
        /// <returns></returns>
        private static BaseResponse GetServiceClient(HttpWebRequest wsRequest)
        {
            BaseResponse result = new BaseResponse();

            try
            {
                HttpWebResponse wsResponse = null;

                try
                {
                    wsResponse = (HttpWebResponse)wsRequest.GetResponse();
                }
                catch (WebException wex)
                {
                    wsResponse = (HttpWebResponse)wex.Response;

                    if (wsResponse == null)
                        throw new Exception(wex.GetBaseException().Message);
                }

                var sResponseJson = new StreamReader(wsResponse.GetResponseStream()).ReadToEnd();

                if (String.IsNullOrEmpty(sResponseJson))
                    throw new Exception("Response is Null");

                switch (wsResponse.StatusCode)
                {
                    case HttpStatusCode.OK:
                        result.ErrorCode = Enumerated.ResponseCode.CorrectCode;
                        result.ErrorDescription = sResponseJson;
                        break;

                    case HttpStatusCode.InternalServerError:
                        result.ErrorCode = Enumerated.ResponseCode.ErrorCodeControlled;
                        result.ErrorDescription = sResponseJson;
                        break;

                    default:
                        result.ErrorCode = Enumerated.ResponseCode.ErrorCodeApplication;
                        result.ErrorDescription = "Error in Http Status Code: " + wsResponse.StatusDescription;
                        break;
                }

                result.ErrorDescription = sResponseJson;
            }
            catch (Exception ex)
            {
                result.ErrorCode = Enumerated.ResponseCode.ErrorCodeControlled;
                result.ErrorDescription = "Method: BaseClient.GetServiceClient => " + ex.Message;
            }

            return result;
        }
        #endregion

        #region [POST]
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static HttpWebRequest PostHeaderRequest(string url)
        {
            #region [Force TLS 2.0]
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            #endregion

            HttpWebRequest headerRequest = (HttpWebRequest)WebRequest.Create(url);
            headerRequest.ContentType = "application/json";
            headerRequest.Method = "POST";

            //if (!String.IsNullOrEmpty(valueToken))
            //    headerRequest.Headers.Add("Authorization", "Bearer " + valueToken);

            return headerRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="wsRequest"></param>
        /// <param name="itemRequest"></param>
        /// <returns></returns>
        public static BaseResponse PostServiceClient<T>(HttpWebRequest wsRequest, T itemRequest)
        {
            BaseResponse result = new BaseResponse();

            try
            {
                using (var streamWriter = new StreamWriter(wsRequest.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(itemRequest);

                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                HttpWebResponse wsResponse = null;

                try
                {
                    wsResponse = (HttpWebResponse)wsRequest.GetResponse();
                }
                catch (WebException wex)
                {
                    wsResponse = (HttpWebResponse)wex.Response;

                    if (wsResponse == null)
                        throw new Exception(wex.GetBaseException().Message);
                }

                var sResponseJson = new StreamReader(wsResponse.GetResponseStream()).ReadToEnd();

                if (String.IsNullOrEmpty(sResponseJson))
                    throw new Exception("Response is Null");

                switch (wsResponse.StatusCode)
                {
                    case HttpStatusCode.OK:
                        result.ErrorCode = Enumerated.ResponseCode.CorrectCode;
                        result.ErrorDescription = sResponseJson;
                        break;

                    case HttpStatusCode.InternalServerError:
                        result.ErrorCode = Enumerated.ResponseCode.ErrorCodeControlled;
                        result.ErrorDescription = sResponseJson;
                        break;

                    default:
                        result.ErrorCode = Enumerated.ResponseCode.ErrorCodeApplication;
                        result.ErrorDescription = "Error in Http Status Code: " + wsResponse.StatusDescription;
                        break;
                }

                result.ErrorDescription = sResponseJson;
            }
            catch (Exception ex)
            {
                result.ErrorCode = Enumerated.ResponseCode.ErrorCodeControlled;
                result.ErrorDescription = "Method: BaseClient.ServiceClient => " + ex.Message;
            }

            return result;
        }
        #endregion
    }
}