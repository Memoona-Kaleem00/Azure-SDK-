// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Support
{
    /// <summary>
    /// A class representing the FileDetail data model.
    /// Object that represents File Details resource
    /// </summary>
    public partial class FileDetailData : ResourceData
    {
        /// <summary> Initializes a new instance of FileDetailData. </summary>
        public FileDetailData()
        {
        }

        /// <summary> Initializes a new instance of FileDetailData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="createdOn"> Time in UTC (ISO 8601 format) when file workspace was created. </param>
        /// <param name="chunkSize"> Size of each chunk. </param>
        /// <param name="fileSize"> Size of the file to be uploaded. </param>
        /// <param name="numberOfChunks"> Number of chunks to be uploaded. </param>
        internal FileDetailData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset? createdOn, float? chunkSize, float? fileSize, float? numberOfChunks) : base(id, name, resourceType, systemData)
        {
            CreatedOn = createdOn;
            ChunkSize = chunkSize;
            FileSize = fileSize;
            NumberOfChunks = numberOfChunks;
        }

        /// <summary> Time in UTC (ISO 8601 format) when file workspace was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Size of each chunk. </summary>
        public float? ChunkSize { get; set; }
        /// <summary> Size of the file to be uploaded. </summary>
        public float? FileSize { get; set; }
        /// <summary> Number of chunks to be uploaded. </summary>
        public float? NumberOfChunks { get; set; }
    }
}
