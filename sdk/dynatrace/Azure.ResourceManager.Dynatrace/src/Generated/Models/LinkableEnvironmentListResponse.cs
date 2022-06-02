// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Dynatrace.Models
{
    /// <summary> Response for getting all the linkable environments. </summary>
    internal partial class LinkableEnvironmentListResponse
    {
        /// <summary> Initializes a new instance of LinkableEnvironmentListResponse. </summary>
        internal LinkableEnvironmentListResponse()
        {
            Value = new ChangeTrackingList<LinkableEnvironmentResult>();
        }

        /// <summary> Initializes a new instance of LinkableEnvironmentListResponse. </summary>
        /// <param name="value"> List of environments for which user is an admin. </param>
        /// <param name="nextLink"> Link to the next set of results, if any. </param>
        internal LinkableEnvironmentListResponse(IReadOnlyList<LinkableEnvironmentResult> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of environments for which user is an admin. </summary>
        public IReadOnlyList<LinkableEnvironmentResult> Value { get; }
        /// <summary> Link to the next set of results, if any. </summary>
        public string NextLink { get; }
    }
}
