// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// The ContainerThrottlingData.
    /// Serialized Name: ContainerThrottlingData
    /// </summary>
    public partial class ContainerThrottlingData
    {
        /// <summary> Initializes a new instance of ContainerThrottlingData. </summary>
        public ContainerThrottlingData()
        {
        }

        /// <summary> Initializes a new instance of ContainerThrottlingData. </summary>
        /// <param name="periods"> Serialized Name: ContainerThrottlingData.periods. </param>
        /// <param name="throttledPeriods"> Serialized Name: ContainerThrottlingData.throttledPeriods. </param>
        /// <param name="throttledTime"> Serialized Name: ContainerThrottlingData.throttledTime. </param>
        internal ContainerThrottlingData(int? periods, int? throttledPeriods, int? throttledTime)
        {
            Periods = periods;
            ThrottledPeriods = throttledPeriods;
            ThrottledTime = throttledTime;
        }

        /// <summary> Serialized Name: ContainerThrottlingData.periods. </summary>
        public int? Periods { get; set; }
        /// <summary> Serialized Name: ContainerThrottlingData.throttledPeriods. </summary>
        public int? ThrottledPeriods { get; set; }
        /// <summary> Serialized Name: ContainerThrottlingData.throttledTime. </summary>
        public int? ThrottledTime { get; set; }
    }
}
