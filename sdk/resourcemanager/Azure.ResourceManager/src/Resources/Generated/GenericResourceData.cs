// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing the GenericResource data model. </summary>
    public partial class GenericResourceData : TrackedResourceExtended
    {
        /// <summary> Initializes a new instance of GenericResourceData. </summary>
        /// <param name="location"> The location. </param>
        public GenericResourceData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of GenericResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> Resource extended location. </param>
        /// <param name="plan"> The plan of the resource. </param>
        /// <param name="properties"> The resource properties. </param>
        /// <param name="kind"> The kind of the resource. </param>
        /// <param name="managedBy"> ID of the resource that manages this resource. </param>
        /// <param name="sku"> The SKU of the resource. </param>
        /// <param name="identity"> The identity of the resource. </param>
        /// <param name="createdTime"> The created time of the resource. This is only present if requested via the $expand query parameter. </param>
        /// <param name="changedTime"> The changed time of the resource. This is only present if requested via the $expand query parameter. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. This is only present if requested via the $expand query parameter. </param>
        internal GenericResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ExtendedLocation extendedLocation, ArmPlan plan, BinaryData properties, string kind, string managedBy, ResourcesSku sku, ManagedServiceIdentity identity, DateTimeOffset? createdTime, DateTimeOffset? changedTime, string provisioningState) : base(id, name, resourceType, systemData, tags, location, extendedLocation)
        {
            Plan = plan;
            Properties = properties;
            Kind = kind;
            ManagedBy = managedBy;
            Sku = sku;
            Identity = identity;
            CreatedTime = createdTime;
            ChangedTime = changedTime;
            ProvisioningState = provisioningState;
        }

        /// <summary> The plan of the resource. </summary>
        public ArmPlan Plan { get; set; }
        /// <summary> The resource properties. </summary>
        public BinaryData Properties { get; set; }
        /// <summary> The kind of the resource. </summary>
        public string Kind { get; set; }
        /// <summary> ID of the resource that manages this resource. </summary>
        public string ManagedBy { get; set; }
        /// <summary> The SKU of the resource. </summary>
        public ResourcesSku Sku { get; set; }
        /// <summary> The identity of the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The created time of the resource. This is only present if requested via the $expand query parameter. </summary>
        public DateTimeOffset? CreatedTime { get; }
        /// <summary> The changed time of the resource. This is only present if requested via the $expand query parameter. </summary>
        public DateTimeOffset? ChangedTime { get; }
        /// <summary> The provisioning state of the resource. This is only present if requested via the $expand query parameter. </summary>
        public string ProvisioningState { get; }
    }
}
