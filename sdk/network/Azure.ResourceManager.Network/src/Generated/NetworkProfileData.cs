// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the NetworkProfile data model.
    /// Network profile resource.
    /// </summary>
    public partial class NetworkProfileData : NetworkTrackedResourceData
    {
        /// <summary> Initializes a new instance of NetworkProfileData. </summary>
        public NetworkProfileData()
        {
            ContainerNetworkInterfaces = new Core.ChangeTrackingList<ContainerNetworkInterface>();
            ContainerNetworkInterfaceConfigurations = new Core.ChangeTrackingList<ContainerNetworkInterfaceConfiguration>();
        }

        /// <summary> Initializes a new instance of NetworkProfileData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="containerNetworkInterfaces"> List of child container network interfaces. </param>
        /// <param name="containerNetworkInterfaceConfigurations"> List of chid container network interface configurations. </param>
        /// <param name="resourceGuid"> The resource GUID property of the network profile resource. </param>
        /// <param name="provisioningState"> The provisioning state of the network profile resource. </param>
        internal NetworkProfileData(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, ETag? etag, IReadOnlyList<ContainerNetworkInterface> containerNetworkInterfaces, IList<ContainerNetworkInterfaceConfiguration> containerNetworkInterfaceConfigurations, Guid? resourceGuid, NetworkProvisioningState? provisioningState) : base(id, name, resourceType, location, tags)
        {
            ETag = etag;
            ContainerNetworkInterfaces = containerNetworkInterfaces;
            ContainerNetworkInterfaceConfigurations = containerNetworkInterfaceConfigurations;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> List of child container network interfaces. </summary>
        public IReadOnlyList<ContainerNetworkInterface> ContainerNetworkInterfaces { get; }
        /// <summary> List of chid container network interface configurations. </summary>
        public IList<ContainerNetworkInterfaceConfiguration> ContainerNetworkInterfaceConfigurations { get; }
        /// <summary> The resource GUID property of the network profile resource. </summary>
        public Guid? ResourceGuid { get; }
        /// <summary> The provisioning state of the network profile resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
