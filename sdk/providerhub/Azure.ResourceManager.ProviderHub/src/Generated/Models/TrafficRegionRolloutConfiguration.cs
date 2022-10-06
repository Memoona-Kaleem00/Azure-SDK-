// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The TrafficRegionRolloutConfiguration. </summary>
    public partial class TrafficRegionRolloutConfiguration : TrafficRegions
    {
        /// <summary> Initializes a new instance of TrafficRegionRolloutConfiguration. </summary>
        public TrafficRegionRolloutConfiguration()
        {
        }

        /// <summary> Initializes a new instance of TrafficRegionRolloutConfiguration. </summary>
        /// <param name="regions"></param>
        /// <param name="waitDuration"></param>
        internal TrafficRegionRolloutConfiguration(IList<string> regions, TimeSpan? waitDuration) : base(regions)
        {
            WaitDuration = waitDuration;
        }

        /// <summary> Gets or sets the wait duration. </summary>
        public TimeSpan? WaitDuration { get; set; }
    }
}
