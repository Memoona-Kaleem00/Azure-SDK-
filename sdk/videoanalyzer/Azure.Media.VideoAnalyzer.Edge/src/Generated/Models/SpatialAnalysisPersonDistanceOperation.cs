// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Defines a Spatial Analysis person distance operation. This requires the Azure Cognitive Services Spatial analysis module to be deployed alongside the Video Analyzer module, please see https://aka.ms/ava-spatial-analysis for more information. </summary>
    public partial class SpatialAnalysisPersonDistanceOperation : SpatialAnalysisTypedOperationBase
    {
        /// <summary> Initializes a new instance of <see cref="SpatialAnalysisPersonDistanceOperation"/>. </summary>
        /// <param name="zones"> The list of zones with optional events. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="zones"/> is null. </exception>
        public SpatialAnalysisPersonDistanceOperation(IEnumerable<SpatialAnalysisPersonDistanceZoneEvents> zones)
        {
            Argument.AssertNotNull(zones, nameof(zones));

            Zones = zones.ToList();
            Type = "#Microsoft.VideoAnalyzer.SpatialAnalysisPersonDistanceOperation";
        }

        /// <summary> Initializes a new instance of <see cref="SpatialAnalysisPersonDistanceOperation"/>. </summary>
        /// <param name="type"> The Type discriminator for the derived types. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="debug"> If set to 'true', enables debugging mode for this operation. </param>
        /// <param name="calibrationConfiguration"> Advanced calibration configuration. </param>
        /// <param name="cameraConfiguration"> Advanced camera configuration. </param>
        /// <param name="cameraCalibratorNodeConfiguration"> Advanced camera calibrator configuration. </param>
        /// <param name="detectorNodeConfiguration"> Advanced detector node configuration. </param>
        /// <param name="trackerNodeConfiguration"> Advanced tracker node configuration. </param>
        /// <param name="enableFaceMaskClassifier"> If set to 'true', enables face mask detection for this operation. </param>
        /// <param name="zones"> The list of zones with optional events. </param>
        internal SpatialAnalysisPersonDistanceOperation(string type, IDictionary<string, BinaryData> serializedAdditionalRawData, string debug, string calibrationConfiguration, string cameraConfiguration, string cameraCalibratorNodeConfiguration, string detectorNodeConfiguration, string trackerNodeConfiguration, string enableFaceMaskClassifier, IList<SpatialAnalysisPersonDistanceZoneEvents> zones) : base(type, serializedAdditionalRawData, debug, calibrationConfiguration, cameraConfiguration, cameraCalibratorNodeConfiguration, detectorNodeConfiguration, trackerNodeConfiguration, enableFaceMaskClassifier)
        {
            Zones = zones;
            Type = type ?? "#Microsoft.VideoAnalyzer.SpatialAnalysisPersonDistanceOperation";
        }

        /// <summary> Initializes a new instance of <see cref="SpatialAnalysisPersonDistanceOperation"/> for deserialization. </summary>
        internal SpatialAnalysisPersonDistanceOperation()
        {
        }

        /// <summary> The list of zones with optional events. </summary>
        public IList<SpatialAnalysisPersonDistanceZoneEvents> Zones { get; }
    }
}
