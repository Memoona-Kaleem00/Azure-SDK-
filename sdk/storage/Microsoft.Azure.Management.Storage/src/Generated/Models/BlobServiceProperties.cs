// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The properties of a storage account’s Blob service.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class BlobServiceProperties : Resource
    {
        /// <summary>
        /// Initializes a new instance of the BlobServiceProperties class.
        /// </summary>
        public BlobServiceProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BlobServiceProperties class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="cors">Specifies CORS rules for the Blob service. You
        /// can include up to five CorsRule elements in the request. If no
        /// CorsRule elements are included in the request body, all CORS rules
        /// will be deleted, and CORS will be disabled for the Blob
        /// service.</param>
        /// <param name="defaultServiceVersion">DefaultServiceVersion indicates
        /// the default version to use for requests to the Blob service if an
        /// incoming request’s version is not specified. Possible values
        /// include version 2008-10-27 and all more recent versions.</param>
        /// <param name="deleteRetentionPolicy">The blob service properties for
        /// blob soft delete.</param>
        /// <param name="isVersioningEnabled">Versioning is enabled if set to
        /// true.</param>
        /// <param name="automaticSnapshotPolicyEnabled">Deprecated in favor of
        /// isVersioningEnabled property.</param>
        /// <param name="changeFeed">The blob service properties for change
        /// feed events.</param>
        /// <param name="restorePolicy">The blob service properties for blob
        /// restore policy.</param>
        /// <param name="containerDeleteRetentionPolicy">The blob service
        /// properties for container soft delete.</param>
        /// <param name="lastAccessTimeTrackingPolicy">The blob service
        /// property to configure last access time based tracking
        /// policy.</param>
        /// <param name="sku">Sku name and tier.</param>
        public BlobServiceProperties(string id = default(string), string name = default(string), string type = default(string), CorsRules cors = default(CorsRules), string defaultServiceVersion = default(string), DeleteRetentionPolicy deleteRetentionPolicy = default(DeleteRetentionPolicy), bool? isVersioningEnabled = default(bool?), bool? automaticSnapshotPolicyEnabled = default(bool?), ChangeFeed changeFeed = default(ChangeFeed), RestorePolicyProperties restorePolicy = default(RestorePolicyProperties), DeleteRetentionPolicy containerDeleteRetentionPolicy = default(DeleteRetentionPolicy), LastAccessTimeTrackingPolicy lastAccessTimeTrackingPolicy = default(LastAccessTimeTrackingPolicy), Sku sku = default(Sku))
            : base(id, name, type)
        {
            Cors = cors;
            DefaultServiceVersion = defaultServiceVersion;
            DeleteRetentionPolicy = deleteRetentionPolicy;
            IsVersioningEnabled = isVersioningEnabled;
            AutomaticSnapshotPolicyEnabled = automaticSnapshotPolicyEnabled;
            ChangeFeed = changeFeed;
            RestorePolicy = restorePolicy;
            ContainerDeleteRetentionPolicy = containerDeleteRetentionPolicy;
            LastAccessTimeTrackingPolicy = lastAccessTimeTrackingPolicy;
            Sku = sku;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies CORS rules for the Blob service. You can
        /// include up to five CorsRule elements in the request. If no CorsRule
        /// elements are included in the request body, all CORS rules will be
        /// deleted, and CORS will be disabled for the Blob service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.cors")]
        public CorsRules Cors { get; set; }

        /// <summary>
        /// Gets or sets defaultServiceVersion indicates the default version to
        /// use for requests to the Blob service if an incoming request’s
        /// version is not specified. Possible values include version
        /// 2008-10-27 and all more recent versions.
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultServiceVersion")]
        public string DefaultServiceVersion { get; set; }

        /// <summary>
        /// Gets or sets the blob service properties for blob soft delete.
        /// </summary>
        [JsonProperty(PropertyName = "properties.deleteRetentionPolicy")]
        public DeleteRetentionPolicy DeleteRetentionPolicy { get; set; }

        /// <summary>
        /// Gets or sets versioning is enabled if set to true.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isVersioningEnabled")]
        public bool? IsVersioningEnabled { get; set; }

        /// <summary>
        /// Gets or sets deprecated in favor of isVersioningEnabled property.
        /// </summary>
        [JsonProperty(PropertyName = "properties.automaticSnapshotPolicyEnabled")]
        public bool? AutomaticSnapshotPolicyEnabled { get; set; }

        /// <summary>
        /// Gets or sets the blob service properties for change feed events.
        /// </summary>
        [JsonProperty(PropertyName = "properties.changeFeed")]
        public ChangeFeed ChangeFeed { get; set; }

        /// <summary>
        /// Gets or sets the blob service properties for blob restore policy.
        /// </summary>
        [JsonProperty(PropertyName = "properties.restorePolicy")]
        public RestorePolicyProperties RestorePolicy { get; set; }

        /// <summary>
        /// Gets or sets the blob service properties for container soft delete.
        /// </summary>
        [JsonProperty(PropertyName = "properties.containerDeleteRetentionPolicy")]
        public DeleteRetentionPolicy ContainerDeleteRetentionPolicy { get; set; }

        /// <summary>
        /// Gets or sets the blob service property to configure last access
        /// time based tracking policy.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastAccessTimeTrackingPolicy")]
        public LastAccessTimeTrackingPolicy LastAccessTimeTrackingPolicy { get; set; }

        /// <summary>
        /// Gets sku name and tier.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DeleteRetentionPolicy != null)
            {
                DeleteRetentionPolicy.Validate();
            }
            if (RestorePolicy != null)
            {
                RestorePolicy.Validate();
            }
            if (ContainerDeleteRetentionPolicy != null)
            {
                ContainerDeleteRetentionPolicy.Validate();
            }
            if (LastAccessTimeTrackingPolicy != null)
            {
                LastAccessTimeTrackingPolicy.Validate();
            }
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}
