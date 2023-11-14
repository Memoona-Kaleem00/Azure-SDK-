// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The resource names object for shared storage. </summary>
    public partial class SharedStorageResourceNames
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SharedStorageResourceNames"/>. </summary>
        public SharedStorageResourceNames()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SharedStorageResourceNames"/>. </summary>
        /// <param name="sharedStorageAccountName"> The full name of the shared storage account. If it is not provided, it will be defaulted to {SID}nfs{guid of 15 chars}. </param>
        /// <param name="sharedStorageAccountPrivateEndPointName"> The full name of private end point for the shared storage account. If it is not provided, it will be defaulted to {storageAccountName}_pe. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SharedStorageResourceNames(string sharedStorageAccountName, string sharedStorageAccountPrivateEndPointName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SharedStorageAccountName = sharedStorageAccountName;
            SharedStorageAccountPrivateEndPointName = sharedStorageAccountPrivateEndPointName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The full name of the shared storage account. If it is not provided, it will be defaulted to {SID}nfs{guid of 15 chars}. </summary>
        public string SharedStorageAccountName { get; set; }
        /// <summary> The full name of private end point for the shared storage account. If it is not provided, it will be defaulted to {storageAccountName}_pe. </summary>
        public string SharedStorageAccountPrivateEndPointName { get; set; }
    }
}
