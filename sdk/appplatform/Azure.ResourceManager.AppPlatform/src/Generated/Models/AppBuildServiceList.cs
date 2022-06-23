// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppPlatform;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Object that includes an array of Build service resources and a possible link for next set. </summary>
    internal partial class AppBuildServiceList
    {
        /// <summary> Initializes a new instance of AppBuildServiceList. </summary>
        internal AppBuildServiceList()
        {
            Value = new ChangeTrackingList<AppBuildServiceData>();
        }

        /// <summary> Initializes a new instance of AppBuildServiceList. </summary>
        /// <param name="value"> Collection of Build service resources. </param>
        /// <param name="nextLink">
        /// URL client should use to fetch the next page (per server side paging).
        /// It&apos;s null for now, added for future use.
        /// </param>
        internal AppBuildServiceList(IReadOnlyList<AppBuildServiceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Collection of Build service resources. </summary>
        public IReadOnlyList<AppBuildServiceData> Value { get; }
        /// <summary>
        /// URL client should use to fetch the next page (per server side paging).
        /// It&apos;s null for now, added for future use.
        /// </summary>
        public string NextLink { get; }
    }
}
