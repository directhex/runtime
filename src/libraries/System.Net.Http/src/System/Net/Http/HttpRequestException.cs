// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace System.Net.Http
{
    public class HttpRequestException : Exception
    {
        internal RequestRetryType AllowRetry { get; } = RequestRetryType.NoRetry;

        public HttpRequestException()
            : this(null, null)
        { }

        public HttpRequestException(string message)
            : this(message, null)
        { }

        public HttpRequestException(string message, Exception inner)
            : base(message, inner)
        {
            if (inner != null)
            {
                HResult = inner.HResult;
            }
        }

        // This constructor is used internally to indicate that a request was not successfully sent due to an IOException,
        // and the exception occurred early enough so that the request may be retried on another connection.
        internal HttpRequestException(string message, Exception inner, RequestRetryType allowRetry)
            : this(message, inner)
        {
            AllowRetry = allowRetry;
        }
    }
}
