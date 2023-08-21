// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> SwapResource List with single entry to represent slot type on the specified cloud service. </summary>
    internal partial class CloudServiceSwapListResult
    {
        /// <summary> Initializes a new instance of CloudServiceSwapListResult. </summary>
        internal CloudServiceSwapListResult()
        {
            Value = new Core.ChangeTrackingList<CloudServiceSwapData>();
        }

        /// <summary> Initializes a new instance of CloudServiceSwapListResult. </summary>
        /// <param name="value"></param>
        internal CloudServiceSwapListResult(IReadOnlyList<CloudServiceSwapData> value)
        {
            Value = value;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<CloudServiceSwapData> Value { get; }
    }
}
