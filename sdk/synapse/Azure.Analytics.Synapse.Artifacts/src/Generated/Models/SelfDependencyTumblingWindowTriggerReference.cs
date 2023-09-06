// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Self referenced tumbling window trigger dependency. </summary>
    public partial class SelfDependencyTumblingWindowTriggerReference : DependencyReference
    {
        /// <summary> Initializes a new instance of <see cref="SelfDependencyTumblingWindowTriggerReference"/>. </summary>
        /// <param name="offset"> Timespan applied to the start time of a tumbling window when evaluating dependency. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="offset"/> is null. </exception>
        public SelfDependencyTumblingWindowTriggerReference(string offset)
        {
            Argument.AssertNotNull(offset, nameof(offset));

            Offset = offset;
            Type = "SelfDependencyTumblingWindowTriggerReference";
        }

        /// <summary> Initializes a new instance of <see cref="SelfDependencyTumblingWindowTriggerReference"/>. </summary>
        /// <param name="type"> The type of dependency reference. </param>
        /// <param name="offset"> Timespan applied to the start time of a tumbling window when evaluating dependency. </param>
        /// <param name="size"> The size of the window when evaluating the dependency. If undefined the frequency of the tumbling window will be used. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SelfDependencyTumblingWindowTriggerReference(string type, string offset, string size, Dictionary<string, BinaryData> rawData) : base(type, rawData)
        {
            Offset = offset;
            Size = size;
            Type = type ?? "SelfDependencyTumblingWindowTriggerReference";
        }

        /// <summary> Initializes a new instance of <see cref="SelfDependencyTumblingWindowTriggerReference"/> for deserialization. </summary>
        internal SelfDependencyTumblingWindowTriggerReference()
        {
        }

        /// <summary> Timespan applied to the start time of a tumbling window when evaluating dependency. </summary>
        public string Offset { get; set; }
        /// <summary> The size of the window when evaluating the dependency. If undefined the frequency of the tumbling window will be used. </summary>
        public string Size { get; set; }
    }
}
