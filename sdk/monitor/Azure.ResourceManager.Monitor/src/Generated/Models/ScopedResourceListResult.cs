// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> A list of scoped resources in a private link scope. </summary>
    internal partial class ScopedResourceListResult
    {
        /// <summary> Initializes a new instance of ScopedResourceListResult. </summary>
        internal ScopedResourceListResult()
        {
            Value = new Core.ChangeTrackingList<MonitorPrivateLinkScopedResourceData>();
        }

        /// <summary> Initializes a new instance of ScopedResourceListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal ScopedResourceListResult(IReadOnlyList<MonitorPrivateLinkScopedResourceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<MonitorPrivateLinkScopedResourceData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
