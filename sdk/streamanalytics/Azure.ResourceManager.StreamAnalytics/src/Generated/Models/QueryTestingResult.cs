// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary>
    /// The result of the query testing request.
    /// Serialized Name: QueryTestingResult
    /// </summary>
    public partial class QueryTestingResult : StreamAnalyticsError
    {
        /// <summary> Initializes a new instance of QueryTestingResult. </summary>
        internal QueryTestingResult()
        {
        }

        /// <summary> Initializes a new instance of QueryTestingResult. </summary>
        /// <param name="code">
        /// Error code.
        /// Serialized Name: StreamAnalyticsError.error.code
        /// </param>
        /// <param name="message">
        /// Error message.
        /// Serialized Name: StreamAnalyticsError.error.message
        /// </param>
        /// <param name="target">
        /// Error target.
        /// Serialized Name: StreamAnalyticsError.error.target
        /// </param>
        /// <param name="details">
        /// Error details.
        /// Serialized Name: StreamAnalyticsError.error.details
        /// </param>
        /// <param name="status">
        /// The status of the query testing request.
        /// Serialized Name: QueryTestingResult.status
        /// </param>
        /// <param name="outputUri">
        /// The SAS URL to the outputs payload.
        /// Serialized Name: QueryTestingResult.outputUri
        /// </param>
        internal QueryTestingResult(string code, string message, string target, IReadOnlyList<StreamAnalyticsErrorDetails> details, QueryTestingResultStatus? status, Uri outputUri) : base(code, message, target, details)
        {
            Status = status;
            OutputUri = outputUri;
        }

        /// <summary>
        /// The status of the query testing request.
        /// Serialized Name: QueryTestingResult.status
        /// </summary>
        public QueryTestingResultStatus? Status { get; }
        /// <summary>
        /// The SAS URL to the outputs payload.
        /// Serialized Name: QueryTestingResult.outputUri
        /// </summary>
        public Uri OutputUri { get; }
    }
}
