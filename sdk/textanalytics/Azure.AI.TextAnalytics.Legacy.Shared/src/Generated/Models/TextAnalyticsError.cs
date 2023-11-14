// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.TextAnalytics.Legacy.Models;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> The TextAnalyticsError. </summary>
    internal partial class TextAnalyticsError
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TextAnalyticsError"/>. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Error message. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="message"/> is null. </exception>
        internal TextAnalyticsError(ErrorCodeValue code, string message)
        {
            Argument.AssertNotNull(message, nameof(message));

            Code = code;
            Message = message;
            Details = new ChangeTrackingList<TextAnalyticsError>();
        }

        /// <summary> Initializes a new instance of <see cref="TextAnalyticsError"/>. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Error message. </param>
        /// <param name="target"> Error target. </param>
        /// <param name="innererror"> Inner error contains more specific information. </param>
        /// <param name="details"> Details about specific errors that led to this reported error. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TextAnalyticsError(ErrorCodeValue code, string message, string target, InnerError innererror, IReadOnlyList<TextAnalyticsError> details, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            Message = message;
            Target = target;
            Innererror = innererror;
            Details = details;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TextAnalyticsError"/> for deserialization. </summary>
        internal TextAnalyticsError()
        {
        }

        /// <summary> Error code. </summary>
        public ErrorCodeValue Code { get; }
        /// <summary> Error message. </summary>
        public string Message { get; }
        /// <summary> Error target. </summary>
        public string Target { get; }
        /// <summary> Inner error contains more specific information. </summary>
        public InnerError Innererror { get; }
        /// <summary> Details about specific errors that led to this reported error. </summary>
        public IReadOnlyList<TextAnalyticsError> Details { get; }
    }
}
