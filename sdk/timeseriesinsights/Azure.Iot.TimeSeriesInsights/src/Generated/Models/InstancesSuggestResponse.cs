// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Iot.TimeSeriesInsights
{
    /// <summary> Response of getting suggestions for search for time series instances. </summary>
    public partial class InstancesSuggestResponse
    {
        /// <summary> Initializes a new instance of InstancesSuggestResponse. </summary>
        internal InstancesSuggestResponse()
        {
            Suggestions = new ChangeTrackingList<SearchSuggestion>();
        }

        /// <summary> Initializes a new instance of InstancesSuggestResponse. </summary>
        /// <param name="suggestions"> List of instance suggestions for searching time series models. </param>
        internal InstancesSuggestResponse(IReadOnlyList<SearchSuggestion> suggestions)
        {
            Suggestions = suggestions;
        }

        /// <summary> List of instance suggestions for searching time series models. </summary>
        public IReadOnlyList<SearchSuggestion> Suggestions { get; }
    }
}
