// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StorageMover.Models
{
    /// <summary> The properties of Azure Storage blob container endpoint. </summary>
    public partial class AzureStorageBlobContainerEndpointProperties : EndpointBaseProperties
    {
        /// <summary> Initializes a new instance of <see cref="AzureStorageBlobContainerEndpointProperties"/>. </summary>
        /// <param name="storageAccountResourceId"> The Azure Resource ID of the storage account that is the target destination. </param>
        /// <param name="blobContainerName"> The name of the Storage blob container that is the target destination. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageAccountResourceId"/> or <paramref name="blobContainerName"/> is null. </exception>
        public AzureStorageBlobContainerEndpointProperties(string storageAccountResourceId, string blobContainerName)
        {
            Argument.AssertNotNull(storageAccountResourceId, nameof(storageAccountResourceId));
            Argument.AssertNotNull(blobContainerName, nameof(blobContainerName));

            StorageAccountResourceId = storageAccountResourceId;
            BlobContainerName = blobContainerName;
            EndpointType = EndpointType.AzureStorageBlobContainer;
        }

        /// <summary> Initializes a new instance of <see cref="AzureStorageBlobContainerEndpointProperties"/>. </summary>
        /// <param name="endpointType"> The Endpoint resource type. </param>
        /// <param name="description"> A description for the Endpoint. </param>
        /// <param name="provisioningState"> The provisioning state of this resource. </param>
        /// <param name="storageAccountResourceId"> The Azure Resource ID of the storage account that is the target destination. </param>
        /// <param name="blobContainerName"> The name of the Storage blob container that is the target destination. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureStorageBlobContainerEndpointProperties(EndpointType endpointType, string description, StorageMoverProvisioningState? provisioningState, string storageAccountResourceId, string blobContainerName, Dictionary<string, BinaryData> rawData) : base(endpointType, description, provisioningState, rawData)
        {
            StorageAccountResourceId = storageAccountResourceId;
            BlobContainerName = blobContainerName;
            EndpointType = endpointType;
        }

        /// <summary> Initializes a new instance of <see cref="AzureStorageBlobContainerEndpointProperties"/> for deserialization. </summary>
        internal AzureStorageBlobContainerEndpointProperties()
        {
        }

        /// <summary> The Azure Resource ID of the storage account that is the target destination. </summary>
        public string StorageAccountResourceId { get; set; }
        /// <summary> The name of the Storage blob container that is the target destination. </summary>
        public string BlobContainerName { get; set; }
    }
}
