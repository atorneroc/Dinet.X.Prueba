using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Dinet.Integration.Domain.Common
{
    /// <summary>
    ///
    /// </summary>
    /// <remarks>
    ///
    /// </remarks>
    public class CompletedAsyncResult<T> : IAsyncResult
    {
        T data;

        /// <summary>
        ///
        /// </summary>
        public CompletedAsyncResult(T data)
        { this.data = data; }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public T Data
        { get { return data; } }

        #region IAsyncResult Members

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public object AsyncState
        { get { return (object)data; } }


        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public WaitHandle AsyncWaitHandle
        { get { throw new Exception("The method or operation is not implemented."); } }


        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public bool CompletedSynchronously
        { get { return true; } }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public bool IsCompleted
        { get { return true; } }
        #endregion
    }
}