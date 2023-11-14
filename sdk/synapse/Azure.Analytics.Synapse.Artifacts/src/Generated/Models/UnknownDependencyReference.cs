// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The UnknownDependencyReference. </summary>
    internal partial class UnknownDependencyReference : DependencyReference
    {
        /// <summary> Initializes a new instance of <see cref="UnknownDependencyReference"/>. </summary>
        /// <param name="type"> The type of dependency reference. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownDependencyReference(string type, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(type, serializedAdditionalRawData)
        {
            Type = type ?? "Unknown";
        }
    }
}
