// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Defines a Spatial Analysis person distance operation eventing configuration. </summary>
    public partial class SpatialAnalysisPersonDistanceEvent : SpatialAnalysisOperationEventBase
    {
        /// <summary> Initializes a new instance of <see cref="SpatialAnalysisPersonDistanceEvent"/>. </summary>
        public SpatialAnalysisPersonDistanceEvent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SpatialAnalysisPersonDistanceEvent"/>. </summary>
        /// <param name="threshold"> The event threshold. </param>
        /// <param name="focus"> The operation focus type. </param>
        /// <param name="trigger"> The event trigger type. </param>
        /// <param name="outputFrequency"> The event or interval output frequency. </param>
        /// <param name="minimumDistanceThreshold"> The minimum distance threshold. </param>
        /// <param name="maximumDistanceThreshold"> The maximum distance threshold. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SpatialAnalysisPersonDistanceEvent(string threshold, SpatialAnalysisOperationFocus? focus, SpatialAnalysisPersonDistanceEventTrigger? trigger, string outputFrequency, string minimumDistanceThreshold, string maximumDistanceThreshold, Dictionary<string, BinaryData> rawData) : base(threshold, focus, rawData)
        {
            Trigger = trigger;
            OutputFrequency = outputFrequency;
            MinimumDistanceThreshold = minimumDistanceThreshold;
            MaximumDistanceThreshold = maximumDistanceThreshold;
        }

        /// <summary> The event trigger type. </summary>
        public SpatialAnalysisPersonDistanceEventTrigger? Trigger { get; set; }
        /// <summary> The event or interval output frequency. </summary>
        public string OutputFrequency { get; set; }
        /// <summary> The minimum distance threshold. </summary>
        public string MinimumDistanceThreshold { get; set; }
        /// <summary> The maximum distance threshold. </summary>
        public string MaximumDistanceThreshold { get; set; }
    }
}
