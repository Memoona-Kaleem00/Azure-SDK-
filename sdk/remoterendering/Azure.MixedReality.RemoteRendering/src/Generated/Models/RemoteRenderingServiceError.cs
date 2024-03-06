// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.MixedReality.RemoteRendering
{
    /// <summary> The error object containing details of why the request failed. </summary>
    public partial class RemoteRenderingServiceError
    {
        /// <summary> Initializes a new instance of <see cref="RemoteRenderingServiceError"/>. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> A human-readable representation of the error. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/> or <paramref name="message"/> is null. </exception>
        internal RemoteRenderingServiceError(string code, string message)
        {
            Argument.AssertNotNull(code, nameof(code));
            Argument.AssertNotNull(message, nameof(message));

            Code = code;
            Message = message;
            Details = new ChangeTrackingList<RemoteRenderingServiceError>();
        }

        /// <summary> Initializes a new instance of <see cref="RemoteRenderingServiceError"/>. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> A human-readable representation of the error. </param>
        /// <param name="details"> An array of details about specific errors that led to this reported error. </param>
        /// <param name="target"> The target of the particular error (e.g., the name of the property in error). </param>
        /// <param name="innerError"> An object containing more specific information than the current object about the error. </param>
        internal RemoteRenderingServiceError(string code, string message, IReadOnlyList<RemoteRenderingServiceError> details, string target, RemoteRenderingServiceError innerError)
        {
            Code = code;
            Message = message;
            Details = details;
            Target = target;
            InnerError = innerError;
        }

        /// <summary> Error code. </summary>
        public string Code { get; }
        /// <summary> A human-readable representation of the error. </summary>
        public string Message { get; }
        /// <summary> An array of details about specific errors that led to this reported error. </summary>
        public IReadOnlyList<RemoteRenderingServiceError> Details { get; }
        /// <summary> The target of the particular error (e.g., the name of the property in error). </summary>
        public string Target { get; }
        /// <summary> An object containing more specific information than the current object about the error. </summary>
        public RemoteRenderingServiceError InnerError { get; }
    }
}
