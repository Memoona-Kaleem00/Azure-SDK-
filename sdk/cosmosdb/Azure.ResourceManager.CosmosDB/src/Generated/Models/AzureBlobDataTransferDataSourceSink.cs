// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> An Azure Blob Storage data source/sink. </summary>
    public partial class AzureBlobDataTransferDataSourceSink : DataTransferDataSourceSink
    {
        /// <summary> Initializes a new instance of <see cref="AzureBlobDataTransferDataSourceSink"/>. </summary>
        /// <param name="containerName"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public AzureBlobDataTransferDataSourceSink(string containerName)
        {
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }

            ContainerName = containerName;
            Component = DataTransferComponent.AzureBlobStorage;
        }

        /// <summary> Initializes a new instance of <see cref="AzureBlobDataTransferDataSourceSink"/>. </summary>
        /// <param name="component"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="containerName"></param>
        /// <param name="endpointUri"></param>
        internal AzureBlobDataTransferDataSourceSink(DataTransferComponent component, IDictionary<string, BinaryData> serializedAdditionalRawData, string containerName, Uri endpointUri) : base(component, serializedAdditionalRawData)
        {
            ContainerName = containerName;
            EndpointUri = endpointUri;
            Component = component;
        }

        /// <summary> Initializes a new instance of <see cref="AzureBlobDataTransferDataSourceSink"/> for deserialization. </summary>
        internal AzureBlobDataTransferDataSourceSink()
        {
        }

        /// <summary> Gets or sets the container name. </summary>
        [WirePath("containerName")]
        public string ContainerName { get; set; }
        /// <summary> Gets or sets the endpoint uri. </summary>
        [WirePath("endpointUrl")]
        public Uri EndpointUri { get; set; }
    }
}
