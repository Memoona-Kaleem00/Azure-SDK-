// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> A container holding only the Tags for a resource, allowing the user to update the tags on a QueryPack instance. </summary>
    public partial class LogAnalyticsQueryPackPatch
    {
        /// <summary> Initializes a new instance of LogAnalyticsQueryPackPatch. </summary>
        public LogAnalyticsQueryPackPatch()
        {
            Tags = new Core.ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
