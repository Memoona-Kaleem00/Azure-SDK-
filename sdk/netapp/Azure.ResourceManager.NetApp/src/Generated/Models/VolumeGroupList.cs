// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> List of volume group resources. </summary>
    internal partial class VolumeGroupList
    {
        /// <summary> Initializes a new instance of VolumeGroupList. </summary>
        internal VolumeGroupList()
        {
            Value = new Core.ChangeTrackingList<NetAppVolumeGroupResult>();
        }

        /// <summary> Initializes a new instance of VolumeGroupList. </summary>
        /// <param name="value"> List of volume Groups. </param>
        internal VolumeGroupList(IReadOnlyList<NetAppVolumeGroupResult> value)
        {
            Value = value;
        }

        /// <summary> List of volume Groups. </summary>
        public IReadOnlyList<NetAppVolumeGroupResult> Value { get; }
    }
}
