// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> List Replications. </summary>
    internal partial class ListReplications
    {
        /// <summary> Initializes a new instance of ListReplications. </summary>
        internal ListReplications()
        {
            Value = new ChangeTrackingList<NetAppVolumeReplication>();
        }

        /// <summary> Initializes a new instance of ListReplications. </summary>
        /// <param name="value"> A list of replications. </param>
        internal ListReplications(IReadOnlyList<NetAppVolumeReplication> value)
        {
            Value = value;
        }

        /// <summary> A list of replications. </summary>
        public IReadOnlyList<NetAppVolumeReplication> Value { get; }
    }
}
