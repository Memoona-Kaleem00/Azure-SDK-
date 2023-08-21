// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> The filters that will be applied to determine which resources to remediate. </summary>
    internal partial class RemediationFilters
    {
        /// <summary> Initializes a new instance of RemediationFilters. </summary>
        public RemediationFilters()
        {
            Locations = new Core.ChangeTrackingList<AzureLocation>();
        }

        /// <summary> Initializes a new instance of RemediationFilters. </summary>
        /// <param name="locations"> The resource locations that will be remediated. </param>
        internal RemediationFilters(IList<AzureLocation> locations)
        {
            Locations = locations;
        }

        /// <summary> The resource locations that will be remediated. </summary>
        public IList<AzureLocation> Locations { get; }
    }
}
