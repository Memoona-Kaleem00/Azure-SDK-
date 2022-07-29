// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    /// <summary> A class representing the PrivateLinkScope data model. </summary>
    public partial class PrivateLinkScopeData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of PrivateLinkScopeData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="accessModeSettings"> Access mode settings. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accessModeSettings"/> is null. </exception>
        public PrivateLinkScopeData(AzureLocation location, AccessModeSettings accessModeSettings) : base(location)
        {
            if (accessModeSettings == null)
            {
                throw new ArgumentNullException(nameof(accessModeSettings));
            }

            PrivateEndpointConnections = new ChangeTrackingList<MonitorPrivateEndpointConnectionData>();
            AccessModeSettings = accessModeSettings;
        }

        /// <summary> Initializes a new instance of PrivateLinkScopeData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> Current state of this PrivateLinkScope: whether or not is has been provisioned within the resource group it is defined. Users cannot change this value but are able to read from it. Values will include Provisioning ,Succeeded, Canceled and Failed. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connections. </param>
        /// <param name="accessModeSettings"> Access mode settings. </param>
        internal PrivateLinkScopeData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string provisioningState, IReadOnlyList<MonitorPrivateEndpointConnectionData> privateEndpointConnections, AccessModeSettings accessModeSettings) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            PrivateEndpointConnections = privateEndpointConnections;
            AccessModeSettings = accessModeSettings;
        }

        /// <summary> Current state of this PrivateLinkScope: whether or not is has been provisioned within the resource group it is defined. Users cannot change this value but are able to read from it. Values will include Provisioning ,Succeeded, Canceled and Failed. </summary>
        public string ProvisioningState { get; }
        /// <summary> List of private endpoint connections. </summary>
        public IReadOnlyList<MonitorPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> Access mode settings. </summary>
        public AccessModeSettings AccessModeSettings { get; set; }
    }
}
