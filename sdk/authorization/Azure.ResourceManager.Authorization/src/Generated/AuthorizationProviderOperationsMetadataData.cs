// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Authorization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Authorization
{
    /// <summary>
    /// A class representing the AuthorizationProviderOperationsMetadata data model.
    /// Provider Operations metadata
    /// </summary>
    public partial class AuthorizationProviderOperationsMetadataData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="AuthorizationProviderOperationsMetadataData"/>. </summary>
        internal AuthorizationProviderOperationsMetadataData()
        {
            ResourceTypes = new ChangeTrackingList<AuthorizationProviderResourceType>();
            Operations = new ChangeTrackingList<AuthorizationProviderOperationInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="AuthorizationProviderOperationsMetadataData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> The provider display name. </param>
        /// <param name="resourceTypes"> The provider resource types. </param>
        /// <param name="operations"> The provider operations. </param>
        internal AuthorizationProviderOperationsMetadataData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string displayName, IReadOnlyList<AuthorizationProviderResourceType> resourceTypes, IReadOnlyList<AuthorizationProviderOperationInfo> operations) : base(id, name, resourceType, systemData)
        {
            DisplayName = displayName;
            ResourceTypes = resourceTypes;
            Operations = operations;
        }

        /// <summary> The provider display name. </summary>
        public string DisplayName { get; }
        /// <summary> The provider resource types. </summary>
        public IReadOnlyList<AuthorizationProviderResourceType> ResourceTypes { get; }
        /// <summary> The provider operations. </summary>
        public IReadOnlyList<AuthorizationProviderOperationInfo> Operations { get; }
    }
}
