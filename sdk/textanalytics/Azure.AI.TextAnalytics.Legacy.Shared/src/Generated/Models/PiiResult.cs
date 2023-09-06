// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> The PiiResult. </summary>
    internal partial class PiiResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PiiResult"/>. </summary>
        /// <param name="documents"> Response by document. </param>
        /// <param name="errors"> Errors by document id. </param>
        /// <param name="modelVersion"> This field indicates which model is used for scoring. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="documents"/>, <paramref name="errors"/> or <paramref name="modelVersion"/> is null. </exception>
        internal PiiResult(IEnumerable<PiiDocumentEntities> documents, IEnumerable<DocumentError> errors, string modelVersion)
        {
            Argument.AssertNotNull(documents, nameof(documents));
            Argument.AssertNotNull(errors, nameof(errors));
            Argument.AssertNotNull(modelVersion, nameof(modelVersion));

            Documents = documents.ToList();
            Errors = errors.ToList();
            ModelVersion = modelVersion;
        }

        /// <summary> Initializes a new instance of <see cref="PiiResult"/>. </summary>
        /// <param name="documents"> Response by document. </param>
        /// <param name="errors"> Errors by document id. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the request payload. </param>
        /// <param name="modelVersion"> This field indicates which model is used for scoring. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PiiResult(IReadOnlyList<PiiDocumentEntities> documents, IReadOnlyList<DocumentError> errors, RequestStatistics statistics, string modelVersion, Dictionary<string, BinaryData> rawData)
        {
            Documents = documents;
            Errors = errors;
            Statistics = statistics;
            ModelVersion = modelVersion;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="PiiResult"/> for deserialization. </summary>
        internal PiiResult()
        {
        }

        /// <summary> Response by document. </summary>
        public IReadOnlyList<PiiDocumentEntities> Documents { get; }
        /// <summary> Errors by document id. </summary>
        public IReadOnlyList<DocumentError> Errors { get; }
        /// <summary> if showStats=true was specified in the request this field will contain information about the request payload. </summary>
        public RequestStatistics Statistics { get; }
        /// <summary> This field indicates which model is used for scoring. </summary>
        public string ModelVersion { get; }
    }
}
