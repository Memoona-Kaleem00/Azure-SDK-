// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Dynatrace.Models
{
    /// <summary> Response of a list VM Host Operation. </summary>
    internal partial class VmHostsListResponse
    {
        /// <summary> Initializes a new instance of VmHostsListResponse. </summary>
        internal VmHostsListResponse()
        {
            Value = new ChangeTrackingList<DynatraceMonitorVmInfo>();
        }

        /// <summary> Initializes a new instance of VmHostsListResponse. </summary>
        /// <param name="value"> The items on this page. </param>
        /// <param name="nextLink"> The link to the next page of items. </param>
        internal VmHostsListResponse(IReadOnlyList<DynatraceMonitorVmInfo> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The items on this page. </summary>
        public IReadOnlyList<DynatraceMonitorVmInfo> Value { get; }
        /// <summary> The link to the next page of items. </summary>
        public string NextLink { get; }
    }
}
