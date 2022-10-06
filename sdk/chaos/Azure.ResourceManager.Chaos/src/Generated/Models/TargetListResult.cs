// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Chaos;

namespace Azure.ResourceManager.Chaos.Models
{
    /// <summary> Model that represents a list of Target resources and a link for pagination. </summary>
    internal partial class TargetListResult
    {
        /// <summary> Initializes a new instance of TargetListResult. </summary>
        internal TargetListResult()
        {
            Value = new ChangeTrackingList<TargetData>();
        }

        /// <summary> Initializes a new instance of TargetListResult. </summary>
        /// <param name="value"> List of Target resources. </param>
        /// <param name="nextLink"> URL to retrieve the next page of Target resources. </param>
        internal TargetListResult(IReadOnlyList<TargetData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of Target resources. </summary>
        public IReadOnlyList<TargetData> Value { get; }
        /// <summary> URL to retrieve the next page of Target resources. </summary>
        public string NextLink { get; }
    }
}
