// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The extended error info. </summary>
    public partial class IntegrationServiceErrorInfo
    {
        /// <summary> Initializes a new instance of IntegrationServiceErrorInfo. </summary>
        /// <param name="code"> The error code. </param>
        /// <param name="message"> The error message. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="message"/> is null. </exception>
        internal IntegrationServiceErrorInfo(IntegrationServiceErrorCode code, string message)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            Code = code;
            Message = message;
            Details = new ChangeTrackingList<IntegrationServiceErrorInfo>();
        }

        /// <summary> Initializes a new instance of IntegrationServiceErrorInfo. </summary>
        /// <param name="code"> The error code. </param>
        /// <param name="message"> The error message. </param>
        /// <param name="details"> The error message details. </param>
        /// <param name="innerError"> The inner error. </param>
        internal IntegrationServiceErrorInfo(IntegrationServiceErrorCode code, string message, IReadOnlyList<IntegrationServiceErrorInfo> details, BinaryData innerError)
        {
            Code = code;
            Message = message;
            Details = details;
            InnerError = innerError;
        }

        /// <summary> The error code. </summary>
        public IntegrationServiceErrorCode Code { get; }
        /// <summary> The error message. </summary>
        public string Message { get; }
        /// <summary> The error message details. </summary>
        public IReadOnlyList<IntegrationServiceErrorInfo> Details { get; }
        /// <summary> The inner error. </summary>
        public BinaryData InnerError { get; }
    }
}
