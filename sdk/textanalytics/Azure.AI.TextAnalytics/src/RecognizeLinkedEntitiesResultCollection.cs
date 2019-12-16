﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Azure.AI.TextAnalytics
{
    /// <summary>
    /// Collection of <see cref="RecognizeLinkedEntitiesResult"/> objects corresponding
    /// to a batch of input documents, and annotated with information about the
    /// batch operation.
    /// </summary>
    public class RecognizeLinkedEntitiesResultCollection : ReadOnlyCollection<RecognizeLinkedEntitiesResult>
    {
        internal RecognizeLinkedEntitiesResultCollection(IList<RecognizeLinkedEntitiesResult> list, TextDocumentBatchStatistics statistics, string modelVersion) : base(list)
        {
            Statistics = statistics;
            ModelVersion = modelVersion;
        }

        /// <summary>
        /// Gets statistics about the input document batch and how it was processed
        /// by the service.  This property will have a value when IncludeStatistics
        /// is set to true in the client call.
        /// </summary>
        public TextDocumentBatchStatistics Statistics { get; }

        /// <summary>
        /// Gets the version of the text analytics model used to identify linked
        /// entities in this batch of input documents.
        /// </summary>
        public string ModelVersion { get; }
    }
}
