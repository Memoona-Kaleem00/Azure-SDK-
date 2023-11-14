// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> ORC dataset. </summary>
    public partial class OrcDataset : Dataset
    {
        /// <summary> Initializes a new instance of <see cref="OrcDataset"/>. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public OrcDataset(LinkedServiceReference linkedServiceName) : base(linkedServiceName)
        {
            Argument.AssertNotNull(linkedServiceName, nameof(linkedServiceName));

            Type = "Orc";
        }

        /// <summary> Initializes a new instance of <see cref="OrcDataset"/>. </summary>
        /// <param name="type"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="location">
        /// The location of the ORC data storage.
        /// Please note <see cref="DatasetLocation"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonS3Location"/>, <see cref="AzureBlobFSLocation"/>, <see cref="AzureBlobStorageLocation"/>, <see cref="AzureDataLakeStoreLocation"/>, <see cref="AzureFileStorageLocation"/>, <see cref="FileServerLocation"/>, <see cref="FtpServerLocation"/>, <see cref="GoogleCloudStorageLocation"/>, <see cref="HdfsLocation"/>, <see cref="HttpServerLocation"/> and <see cref="SftpLocation"/>.
        /// </param>
        /// <param name="orcCompressionCodec"> The data orcCompressionCodec. Type: string (or Expression with resultType string). </param>
        internal OrcDataset(string type, string description, object structure, object schema, LinkedServiceReference linkedServiceName, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, DatasetFolder folder, IDictionary<string, object> additionalProperties, DatasetLocation location, object orcCompressionCodec) : base(type, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            Location = location;
            OrcCompressionCodec = orcCompressionCodec;
            Type = type ?? "Orc";
        }

        /// <summary> Initializes a new instance of <see cref="OrcDataset"/> for deserialization. </summary>
        internal OrcDataset()
        {
        }

        /// <summary>
        /// The location of the ORC data storage.
        /// Please note <see cref="DatasetLocation"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonS3Location"/>, <see cref="AzureBlobFSLocation"/>, <see cref="AzureBlobStorageLocation"/>, <see cref="AzureDataLakeStoreLocation"/>, <see cref="AzureFileStorageLocation"/>, <see cref="FileServerLocation"/>, <see cref="FtpServerLocation"/>, <see cref="GoogleCloudStorageLocation"/>, <see cref="HdfsLocation"/>, <see cref="HttpServerLocation"/> and <see cref="SftpLocation"/>.
        /// </summary>
        public DatasetLocation Location { get; set; }
        /// <summary> The data orcCompressionCodec. Type: string (or Expression with resultType string). </summary>
        public object OrcCompressionCodec { get; set; }
    }
}
