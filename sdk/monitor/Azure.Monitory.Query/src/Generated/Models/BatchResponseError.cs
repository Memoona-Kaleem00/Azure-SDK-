// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Monitory.Query.Models
{
    /// <summary> Error response for a batch request. </summary>
    public partial class BatchResponseError
    {
        /// <summary> Initializes a new instance of BatchResponseError. </summary>
        internal BatchResponseError()
        {
        }

        /// <summary> Initializes a new instance of BatchResponseError. </summary>
        /// <param name="message"> The error message describing the cause of the error. </param>
        /// <param name="code"> The error code. </param>
        /// <param name="innerError"> . </param>
        internal BatchResponseError(string message, string code, BatchResponseErrorInnerError innerError)
        {
            Message = message;
            Code = code;
            InnerError = innerError;
        }

        /// <summary> The error message describing the cause of the error. </summary>
        public string Message { get; }
        /// <summary> The error code. </summary>
        public string Code { get; }
        public BatchResponseErrorInnerError InnerError { get; }
    }
}
