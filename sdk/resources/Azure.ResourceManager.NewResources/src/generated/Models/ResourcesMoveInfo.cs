// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NewResources
{
    /// <summary> Parameters of move resources. </summary>
    internal partial class ResourcesMoveInfo
    {
        /// <summary> Initializes a new instance of ResourcesMoveInfo. </summary>
        internal ResourcesMoveInfo()
        {
            Resources = new ChangeTrackingList<string>();
        }

        /// <summary> The IDs of the resources. </summary>
        public IReadOnlyList<string> Resources { get; }
        /// <summary> The target resource group. </summary>
        public string TargetResourceGroup { get; }
    }
}
