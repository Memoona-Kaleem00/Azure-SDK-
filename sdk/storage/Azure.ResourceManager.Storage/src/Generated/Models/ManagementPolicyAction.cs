// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Actions are applied to the filtered blobs when the execution condition is met. </summary>
    public partial class ManagementPolicyAction
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagementPolicyAction"/>. </summary>
        public ManagementPolicyAction()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagementPolicyAction"/>. </summary>
        /// <param name="baseBlob"> The management policy action for base blob. </param>
        /// <param name="snapshot"> The management policy action for snapshot. </param>
        /// <param name="version"> The management policy action for version. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagementPolicyAction(ManagementPolicyBaseBlob baseBlob, ManagementPolicySnapShot snapshot, ManagementPolicyVersion version, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            BaseBlob = baseBlob;
            Snapshot = snapshot;
            Version = version;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The management policy action for base blob. </summary>
        public ManagementPolicyBaseBlob BaseBlob { get; set; }
        /// <summary> The management policy action for snapshot. </summary>
        public ManagementPolicySnapShot Snapshot { get; set; }
        /// <summary> The management policy action for version. </summary>
        public ManagementPolicyVersion Version { get; set; }
    }
}
