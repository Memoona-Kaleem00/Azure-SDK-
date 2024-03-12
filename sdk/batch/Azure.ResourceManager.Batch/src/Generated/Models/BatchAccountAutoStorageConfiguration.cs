// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Batch;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Contains information about the auto-storage account associated with a Batch account. </summary>
    public partial class BatchAccountAutoStorageConfiguration : BatchAccountAutoStorageBaseConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="BatchAccountAutoStorageConfiguration"/>. </summary>
        /// <param name="storageAccountId"> The resource ID of the storage account to be used for auto-storage account. </param>
        /// <param name="lastKeySyncedOn"> The UTC time at which storage keys were last synchronized with the Batch account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageAccountId"/> is null. </exception>
        public BatchAccountAutoStorageConfiguration(ResourceIdentifier storageAccountId, DateTimeOffset lastKeySyncedOn) : base(storageAccountId)
        {
            Argument.AssertNotNull(storageAccountId, nameof(storageAccountId));

            LastKeySyncedOn = lastKeySyncedOn;
        }

        /// <summary> Initializes a new instance of <see cref="BatchAccountAutoStorageConfiguration"/>. </summary>
        /// <param name="storageAccountId"> The resource ID of the storage account to be used for auto-storage account. </param>
        /// <param name="authenticationMode"> The authentication mode which the Batch service will use to manage the auto-storage account. </param>
        /// <param name="nodeIdentity"> The identity referenced here must be assigned to pools which have compute nodes that need access to auto-storage. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="lastKeySyncedOn"> The UTC time at which storage keys were last synchronized with the Batch account. </param>
        internal BatchAccountAutoStorageConfiguration(ResourceIdentifier storageAccountId, BatchAutoStorageAuthenticationMode? authenticationMode, ComputeNodeIdentityReference nodeIdentity, IDictionary<string, BinaryData> serializedAdditionalRawData, DateTimeOffset lastKeySyncedOn) : base(storageAccountId, authenticationMode, nodeIdentity, serializedAdditionalRawData)
        {
            LastKeySyncedOn = lastKeySyncedOn;
        }

        /// <summary> Initializes a new instance of <see cref="BatchAccountAutoStorageConfiguration"/> for deserialization. </summary>
        internal BatchAccountAutoStorageConfiguration()
        {
        }

        /// <summary> The UTC time at which storage keys were last synchronized with the Batch account. </summary>
        public DateTimeOffset LastKeySyncedOn { get; set; }
    }
}
