// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The LinkConnectionCompute. </summary>
    public partial class LinkConnectionCompute
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LinkConnectionCompute"/>. </summary>
        public LinkConnectionCompute()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LinkConnectionCompute"/>. </summary>
        /// <param name="coreCount"> Compute core count used by the link connection. </param>
        /// <param name="computeType"> Link connection's compute type. </param>
        /// <param name="dataProcessIntervalMinutes"> Link connection's data process interval in minutes. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LinkConnectionCompute(int? coreCount, string computeType, int? dataProcessIntervalMinutes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CoreCount = coreCount;
            ComputeType = computeType;
            DataProcessIntervalMinutes = dataProcessIntervalMinutes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Compute core count used by the link connection. </summary>
        public int? CoreCount { get; set; }
        /// <summary> Link connection's compute type. </summary>
        public string ComputeType { get; set; }
        /// <summary> Link connection's data process interval in minutes. </summary>
        public int? DataProcessIntervalMinutes { get; set; }
    }
}
