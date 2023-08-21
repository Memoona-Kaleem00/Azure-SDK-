// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> Properties that define an Log Analytics QueryPack-Query search properties. </summary>
    public partial class LogAnalyticsQuerySearchProperties
    {
        /// <summary> Initializes a new instance of LogAnalyticsQuerySearchProperties. </summary>
        public LogAnalyticsQuerySearchProperties()
        {
            Tags = new Core.ChangeTrackingDictionary<string, IList<string>>();
        }

        /// <summary> The related metadata items for the function. </summary>
        public LogAnalyticsQuerySearchRelatedMetadata Related { get; set; }
        /// <summary> Tags associated with the query. </summary>
        public IDictionary<string, IList<string>> Tags { get; }
    }
}
