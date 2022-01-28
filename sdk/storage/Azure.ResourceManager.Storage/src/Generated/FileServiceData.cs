// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    /// <summary> A class representing the FileService data model. </summary>
    public partial class FileServiceData : Resource
    {
        /// <summary> Initializes a new instance of FileServiceData. </summary>
        public FileServiceData()
        {
        }

        /// <summary> Initializes a new instance of FileServiceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="sku"> Sku name and tier. </param>
        /// <param name="cors"> Specifies CORS rules for the File service. You can include up to five CorsRule elements in the request. If no CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the File service. </param>
        /// <param name="shareDeleteRetentionPolicy"> The file service properties for share soft delete. </param>
        /// <param name="protocolSettings"> Protocol settings for file service. </param>
        internal FileServiceData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, Models.Sku sku, CorsRules cors, DeleteRetentionPolicy shareDeleteRetentionPolicy, ProtocolSettings protocolSettings) : base(id, name, type, systemData)
        {
            Sku = sku;
            Cors = cors;
            ShareDeleteRetentionPolicy = shareDeleteRetentionPolicy;
            ProtocolSettings = protocolSettings;
        }

        /// <summary> Sku name and tier. </summary>
        public Models.Sku Sku { get; }
        /// <summary> Specifies CORS rules for the File service. You can include up to five CorsRule elements in the request. If no CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the File service. </summary>
        public CorsRules Cors { get; set; }
        /// <summary> The file service properties for share soft delete. </summary>
        public DeleteRetentionPolicy ShareDeleteRetentionPolicy { get; set; }
        /// <summary> Protocol settings for file service. </summary>
        public ProtocolSettings ProtocolSettings { get; set; }
    }
}
