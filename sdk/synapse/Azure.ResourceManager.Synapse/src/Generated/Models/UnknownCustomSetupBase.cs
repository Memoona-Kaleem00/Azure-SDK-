// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The UnknownCustomSetupBase. </summary>
    internal partial class UnknownCustomSetupBase : SynapseCustomSetupBase
    {
        /// <summary> Initializes a new instance of <see cref="UnknownCustomSetupBase"/>. </summary>
        /// <param name="customSetupBaseType"> The type of custom setup. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownCustomSetupBase(string customSetupBaseType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(customSetupBaseType, serializedAdditionalRawData)
        {
            CustomSetupBaseType = customSetupBaseType ?? "Unknown";
        }
    }
}
