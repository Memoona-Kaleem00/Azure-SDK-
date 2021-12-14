// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Verticals.AgriFood.Farming.Models
{
    /// <summary>
    /// An error response from the Azure AgPlatform service.
    /// &lt;see href=&quot;https://github.com/Microsoft/api-guidelines/blob/vNext/Guidelines.md#7102-error-condition-responses&quot;&gt;ErrorResponse reference document.&lt;/see&gt;.
    /// </summary>
    internal partial class ErrorResponse
    {
        /// <summary> Initializes a new instance of ErrorResponse. </summary>
        internal ErrorResponse()
        {
        }

        /// <summary> Initializes a new instance of ErrorResponse. </summary>
        /// <param name="error"> An error from the Azure AgPlatform service. </param>
        /// <param name="traceId"> Unique trace ID. </param>
        internal ErrorResponse(Error error, string traceId)
        {
            Error = error;
            TraceId = traceId;
        }

        /// <summary> An error from the Azure AgPlatform service. </summary>
        public Error Error { get; }
        /// <summary> Unique trace ID. </summary>
        public string TraceId { get; }
    }
}
