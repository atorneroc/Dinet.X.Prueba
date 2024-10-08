using Dinet.Integration.Implementation.WebService.Wrappers.Document;
using System;
using System.ServiceModel;

namespace Dinet.Integration.Implementation.WebService
{
    /// <summary>
    /// 
    /// </summary>
    [ServiceContract(Namespace = "urn:dinet:integration:document")]
    public interface IMaskDocument
    {
        #region [Register]
        /// <summary>
        ///
        /// </summary>
        /// <param name="iRequest"></param>
        /// <param name="callback"></param>
        /// <param name="asyncState"></param>
        /// <returns></returns>
        [OperationContractAttribute(Action = "urn:dinet:integration:document:register", ReplyAction = "", AsyncPattern = true)]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        IAsyncResult BeginRegisterAsync(DocumentRequest iRequest, AsyncCallback callback, object asyncState);

        /// <summary>
        ///
        /// </summary>
        /// <param name="iResult"></param>
        /// <returns></returns>
        DocumentResponse EndRegisterAsync(IAsyncResult iResult);
        #endregion
    }
}