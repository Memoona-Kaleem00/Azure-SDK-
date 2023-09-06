// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Live Pipeline represents an unique instance of a pipeline topology which is used for real-time content ingestion and analysis. </summary>
    public partial class LivePipeline
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LivePipeline"/>. </summary>
        /// <param name="name"> Live pipeline unique identifier. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public LivePipeline(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="LivePipeline"/>. </summary>
        /// <param name="name"> Live pipeline unique identifier. </param>
        /// <param name="systemData"> Read-only system metadata associated with this object. </param>
        /// <param name="properties"> Live pipeline properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LivePipeline(string name, SystemData systemData, LivePipelineProperties properties, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            SystemData = systemData;
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="LivePipeline"/> for deserialization. </summary>
        internal LivePipeline()
        {
        }

        /// <summary> Live pipeline unique identifier. </summary>
        public string Name { get; set; }
        /// <summary> Read-only system metadata associated with this object. </summary>
        public SystemData SystemData { get; set; }
        /// <summary> Live pipeline properties. </summary>
        public LivePipelineProperties Properties { get; set; }
    }
}
