// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The ExtractiveSummarizationResult. </summary>
    internal partial class ExtractiveSummarizationResult : PreBuiltResult
    {
        /// <summary> Initializes a new instance of <see cref="ExtractiveSummarizationResult"/>. </summary>
        /// <param name="errors"> Errors by document id. </param>
        /// <param name="modelVersion"> This field indicates which model is used for scoring. </param>
        /// <param name="documents"> Response by document. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="errors"/>, <paramref name="modelVersion"/> or <paramref name="documents"/> is null. </exception>
        public ExtractiveSummarizationResult(IEnumerable<DocumentError> errors, string modelVersion, IEnumerable<ExtractedSummaryDocumentResult> documents) : base(errors, modelVersion)
        {
            Argument.AssertNotNull(errors, nameof(errors));
            Argument.AssertNotNull(modelVersion, nameof(modelVersion));
            Argument.AssertNotNull(documents, nameof(documents));

            Documents = documents.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ExtractiveSummarizationResult"/>. </summary>
        /// <param name="errors"> Errors by document id. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the request payload. </param>
        /// <param name="modelVersion"> This field indicates which model is used for scoring. </param>
        /// <param name="documents"> Response by document. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ExtractiveSummarizationResult(IList<DocumentError> errors, TextDocumentBatchStatistics statistics, string modelVersion, IList<ExtractedSummaryDocumentResult> documents, Dictionary<string, BinaryData> rawData) : base(errors, statistics, modelVersion, rawData)
        {
            Documents = documents;
        }

        /// <summary> Initializes a new instance of <see cref="ExtractiveSummarizationResult"/> for deserialization. </summary>
        internal ExtractiveSummarizationResult()
        {
        }

        /// <summary> Response by document. </summary>
        public IList<ExtractedSummaryDocumentResult> Documents { get; }
    }
}
