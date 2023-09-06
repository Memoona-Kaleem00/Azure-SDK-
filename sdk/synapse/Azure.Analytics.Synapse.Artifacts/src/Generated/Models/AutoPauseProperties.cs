// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Auto-pausing properties of a Big Data pool powered by Apache Spark. </summary>
    public partial class AutoPauseProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AutoPauseProperties"/>. </summary>
        public AutoPauseProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AutoPauseProperties"/>. </summary>
        /// <param name="delayInMinutes"> Number of minutes of idle time before the Big Data pool is automatically paused. </param>
        /// <param name="enabled"> Whether auto-pausing is enabled for the Big Data pool. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AutoPauseProperties(int? delayInMinutes, bool? enabled, Dictionary<string, BinaryData> rawData)
        {
            DelayInMinutes = delayInMinutes;
            Enabled = enabled;
            _rawData = rawData;
        }

        /// <summary> Number of minutes of idle time before the Big Data pool is automatically paused. </summary>
        public int? DelayInMinutes { get; set; }
        /// <summary> Whether auto-pausing is enabled for the Big Data pool. </summary>
        public bool? Enabled { get; set; }
    }
}
