// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Details of an DatasetDto. </summary>
    public partial class DataVersion
    {
        /// <summary> Initializes a new instance of DataVersion. </summary>
        public DataVersion()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            Properties = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of DataVersion. </summary>
        /// <param name="datasetType"> The Format of dataset. </param>
        /// <param name="datastoreId"> The asset datastoreId. </param>
        /// <param name="assetPath"> Details of an AssetUri. </param>
        /// <param name="description"> The asset description text. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        internal DataVersion(DatasetType? datasetType, string datastoreId, AssetPath assetPath, string description, IDictionary<string, string> tags, IDictionary<string, string> properties)
        {
            DatasetType = datasetType;
            DatastoreId = datastoreId;
            AssetPath = assetPath;
            Description = description;
            Tags = tags;
            Properties = properties;
        }

        /// <summary> The Format of dataset. </summary>
        public DatasetType? DatasetType { get; set; }
        /// <summary> The asset datastoreId. </summary>
        public string DatastoreId { get; set; }
        /// <summary> Details of an AssetUri. </summary>
        public AssetPath AssetPath { get; set; }
        /// <summary> The asset description text. </summary>
        public string Description { get; set; }
        /// <summary> Tag dictionary. Tags can be added, removed, and updated. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The asset property dictionary. </summary>
        public IDictionary<string, string> Properties { get; }
    }
}
