// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> The get schema operation response. </summary>
    internal partial class SearchGetSchemaResponse
    {
        /// <summary> Initializes a new instance of <see cref="SearchGetSchemaResponse"/>. </summary>
        internal SearchGetSchemaResponse()
        {
            Value = new ChangeTrackingList<OperationalInsightsSearchSchemaValue>();
        }

        /// <summary> Initializes a new instance of <see cref="SearchGetSchemaResponse"/>. </summary>
        /// <param name="metadata"> The metadata from search results. </param>
        /// <param name="value"> The array of result values. </param>
        internal SearchGetSchemaResponse(SearchMetadata metadata, IReadOnlyList<OperationalInsightsSearchSchemaValue> value)
        {
            Metadata = metadata;
            Value = value;
        }

        /// <summary> The metadata from search results. </summary>
        public SearchMetadata Metadata { get; }
        /// <summary> The array of result values. </summary>
        public IReadOnlyList<OperationalInsightsSearchSchemaValue> Value { get; }
    }
}
