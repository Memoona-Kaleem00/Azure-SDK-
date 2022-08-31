// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> Summarize action results. </summary>
    internal partial class SummarizeResults
    {
        /// <summary> Initializes a new instance of SummarizeResults. </summary>
        internal SummarizeResults()
        {
            Value = new ChangeTrackingList<Summary>();
        }

        /// <summary> Initializes a new instance of SummarizeResults. </summary>
        /// <param name="odataContext"> OData context string; used by OData clients to resolve type information based on metadata. </param>
        /// <param name="odataCount"> OData entity count; represents the number of summaries returned; always set to 1. </param>
        /// <param name="value"> Summarize action results. </param>
        internal SummarizeResults(string odataContext, int? odataCount, IReadOnlyList<Summary> value)
        {
            OdataContext = odataContext;
            OdataCount = odataCount;
            Value = value;
        }

        /// <summary> OData context string; used by OData clients to resolve type information based on metadata. </summary>
        public string OdataContext { get; }
        /// <summary> OData entity count; represents the number of summaries returned; always set to 1. </summary>
        public int? OdataCount { get; }
        /// <summary> Summarize action results. </summary>
        public IReadOnlyList<Summary> Value { get; }
    }
}
