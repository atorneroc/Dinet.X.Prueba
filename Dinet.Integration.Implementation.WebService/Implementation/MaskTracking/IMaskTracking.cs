using Dinet.Integration.Implementation.WebService.Wrappers.Tracking;
using System;
using System.ServiceModel;

namespace Dinet.Integration.Implementation.WebService
{
    /// <summary>
    /// 
    /// </summary>
    [ServiceContract(Namespace = "urn:dinet:integration:tracking")]
    public interface IMaskTracking
    {
        #region [Register]
        /// <summary>
        ///
        /// </summary>
        /// <param name="iRequest"></param>
        /// <param name="callback"></param> 
        /// <param name="asyncState"></param>
        /// <returns></returns>
        [OperationContractAttribute(Action = "urn:dinet:integration:tracking:register", ReplyAction = "", AsyncPattern = true)]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        IAsyncResult BeginRegisterAsync(TrackingRequest iRequest, AsyncCallback callback, object asyncState);

        /// <summary>
        ///
        /// </summary>
        /// <param name="iResult"></param>
        /// <returns></returns>
        TrackingResponse EndRegisterAsync(IAsyncResult iResult);
        #endregion
    }
}