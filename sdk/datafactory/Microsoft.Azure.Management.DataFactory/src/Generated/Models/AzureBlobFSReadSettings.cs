// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Azure blobFS read settings.
    /// </summary>
    public partial class AzureBlobFSReadSettings : StoreReadSettings
    {
        /// <summary>
        /// Initializes a new instance of the AzureBlobFSReadSettings class.
        /// </summary>
        public AzureBlobFSReadSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureBlobFSReadSettings class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="maxConcurrentConnections">The maximum concurrent
        /// connection count for the source data store. Type: integer (or
        /// Expression with resultType integer).</param>
        /// <param name="recursive">If true, files under the folder path will
        /// be read recursively. Default is true. Type: boolean (or Expression
        /// with resultType boolean).</param>
        /// <param name="wildcardFolderPath">Azure blobFS wildcardFolderPath.
        /// Type: string (or Expression with resultType string).</param>
        /// <param name="wildcardFileName">Azure blobFS wildcardFileName. Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="enablePartitionDiscovery">Indicates whether to enable
        /// partition discovery.</param>
        /// <param name="modifiedDatetimeStart">The start of file's modified
        /// datetime. Type: string (or Expression with resultType
        /// string).</param>
        /// <param name="modifiedDatetimeEnd">The end of file's modified
        /// datetime. Type: string (or Expression with resultType
        /// string).</param>
        public AzureBlobFSReadSettings(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object maxConcurrentConnections = default(object), object recursive = default(object), object wildcardFolderPath = default(object), object wildcardFileName = default(object), bool? enablePartitionDiscovery = default(bool?), object modifiedDatetimeStart = default(object), object modifiedDatetimeEnd = default(object))
            : base(additionalProperties, maxConcurrentConnections)
        {
            Recursive = recursive;
            WildcardFolderPath = wildcardFolderPath;
            WildcardFileName = wildcardFileName;
            EnablePartitionDiscovery = enablePartitionDiscovery;
            ModifiedDatetimeStart = modifiedDatetimeStart;
            ModifiedDatetimeEnd = modifiedDatetimeEnd;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets if true, files under the folder path will be read
        /// recursively. Default is true. Type: boolean (or Expression with
        /// resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "recursive")]
        public object Recursive { get; set; }

        /// <summary>
        /// Gets or sets azure blobFS wildcardFolderPath. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "wildcardFolderPath")]
        public object WildcardFolderPath { get; set; }

        /// <summary>
        /// Gets or sets azure blobFS wildcardFileName. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "wildcardFileName")]
        public object WildcardFileName { get; set; }

        /// <summary>
        /// Gets or sets indicates whether to enable partition discovery.
        /// </summary>
        [JsonProperty(PropertyName = "enablePartitionDiscovery")]
        public bool? EnablePartitionDiscovery { get; set; }

        /// <summary>
        /// Gets or sets the start of file's modified datetime. Type: string
        /// (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "modifiedDatetimeStart")]
        public object ModifiedDatetimeStart { get; set; }

        /// <summary>
        /// Gets or sets the end of file's modified datetime. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "modifiedDatetimeEnd")]
        public object ModifiedDatetimeEnd { get; set; }

    }
}
