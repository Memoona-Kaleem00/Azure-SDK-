// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StorageMover.Models
{
    /// <summary> The properties of Azure Storage SMB file share endpoint to update. </summary>
    public partial class AzureStorageSmbFileShareEndpointUpdateProperties : EndpointBaseUpdateProperties
    {
        /// <summary> Initializes a new instance of <see cref="AzureStorageSmbFileShareEndpointUpdateProperties"/>. </summary>
        public AzureStorageSmbFileShareEndpointUpdateProperties()
        {
            EndpointType = EndpointType.AzureStorageSmbFileShare;
        }

        /// <summary> Initializes a new instance of <see cref="AzureStorageSmbFileShareEndpointUpdateProperties"/>. </summary>
        /// <param name="endpointType"> The Endpoint resource type. </param>
        /// <param name="description"> A description for the Endpoint. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureStorageSmbFileShareEndpointUpdateProperties(EndpointType endpointType, string description, Dictionary<string, BinaryData> rawData) : base(endpointType, description, rawData)
        {
            EndpointType = endpointType;
        }
    }
}
