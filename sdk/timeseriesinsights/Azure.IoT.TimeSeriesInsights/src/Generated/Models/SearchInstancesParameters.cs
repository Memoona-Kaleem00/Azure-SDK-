// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Parameters of how to return time series instances by search instances call. </summary>
    internal partial class SearchInstancesParameters
    {
        /// <summary> Initializes a new instance of SearchInstancesParameters. </summary>
        public SearchInstancesParameters()
        {
        }

        /// <summary> Definition of which instances are returned. When recursive is set to &apos;true&apos;, all instances that have the path that starts with path the path parameter are returned. When recursive is set to &apos;false&apos;, only instances that have the path that exactly matches the path parameter are returned. Using recursive search allows to implement search user experience, while using non-recursive search allows to implement navigation experience. Optional, default is &apos;true&apos;. </summary>
        public bool? Recursive { get; set; }
        /// <summary> Definition of how time series instances are sorted before being returned by search instances call - relevance or alphabetical. Optional, default is &quot;Rank&quot;. </summary>
        public InstancesSortParameter Sort { get; set; }
        /// <summary> Definition of highlighted search results or not. When it is set to &apos;true&apos;, the highlighted search results are returned. When it is set to &apos;false&apos;, the highlighted search results are not returned. Default is &apos;true&apos;. </summary>
        public bool? Highlights { get; set; }
        /// <summary> Maximum number of instances expected in each page of the result. Defaults to 10 when not set. Ranges from 1 to 100. If there are results beyond the page size, the user can use the continuation token to fetch the next page. </summary>
        public int? PageSize { get; set; }
    }
}
