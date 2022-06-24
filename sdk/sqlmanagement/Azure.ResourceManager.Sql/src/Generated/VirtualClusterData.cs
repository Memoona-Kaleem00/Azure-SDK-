// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the VirtualCluster data model. </summary>
    public partial class VirtualClusterData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of VirtualClusterData. </summary>
        /// <param name="location"> The location. </param>
        public VirtualClusterData(AzureLocation location) : base(location)
        {
            ChildResources = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of VirtualClusterData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="subnetId"> Subnet resource ID for the virtual cluster. </param>
        /// <param name="family"> If the service has different generations of hardware, for the same SKU, then that can be captured here. </param>
        /// <param name="childResources"> List of resources in this virtual cluster. </param>
        /// <param name="maintenanceConfigurationId"> Specifies maintenance configuration id to apply to this virtual cluster. </param>
        internal VirtualClusterData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ResourceIdentifier subnetId, string family, IReadOnlyList<string> childResources, ResourceIdentifier maintenanceConfigurationId) : base(id, name, resourceType, systemData, tags, location)
        {
            SubnetId = subnetId;
            Family = family;
            ChildResources = childResources;
            MaintenanceConfigurationId = maintenanceConfigurationId;
        }

        /// <summary> Subnet resource ID for the virtual cluster. </summary>
        public ResourceIdentifier SubnetId { get; }
        /// <summary> If the service has different generations of hardware, for the same SKU, then that can be captured here. </summary>
        public string Family { get; set; }
        /// <summary> List of resources in this virtual cluster. </summary>
        public IReadOnlyList<string> ChildResources { get; }
        /// <summary> Specifies maintenance configuration id to apply to this virtual cluster. </summary>
        public ResourceIdentifier MaintenanceConfigurationId { get; set; }
    }
}
