// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A workspace. </summary>
    public partial class Workspace : TrackedResource
    {
        /// <summary> Initializes a new instance of <see cref="Workspace"/>. </summary>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public Workspace(string location) : base(location)
        {
            Argument.AssertNotNull(location, nameof(location));

            ConnectivityEndpoints = new ChangeTrackingDictionary<string, string>();
            PrivateEndpointConnections = new ChangeTrackingList<PrivateEndpointConnection>();
            ExtraProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of <see cref="Workspace"/>. </summary>
        /// <param name="id"> Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts". </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="identity"> Identity of the workspace. </param>
        /// <param name="defaultDataLakeStorage"> Workspace default data lake storage account details. </param>
        /// <param name="sqlAdministratorLoginPassword"> SQL administrator login password. </param>
        /// <param name="managedResourceGroupName"> Workspace managed resource group. The resource group name uniquely identifies the resource group within the user subscriptionId. The resource group name must be no longer than 90 characters long, and must be alphanumeric characters (Char.IsLetterOrDigit()) and '-', '_', '(', ')' and'.'. Note that the name cannot end with '.'. </param>
        /// <param name="provisioningState"> Resource provisioning state. </param>
        /// <param name="sqlAdministratorLogin"> Login for workspace SQL active directory administrator. </param>
        /// <param name="virtualNetworkProfile"> Virtual Network profile. </param>
        /// <param name="connectivityEndpoints"> Connectivity endpoints. </param>
        /// <param name="managedVirtualNetwork"> Setting this to 'default' will ensure that all compute for this workspace is in a virtual network managed on behalf of the user. </param>
        /// <param name="privateEndpointConnections"> Private endpoint connections to the workspace. </param>
        /// <param name="encryption"> The encryption details of the workspace. </param>
        /// <param name="workspaceUID"> The workspace unique identifier. </param>
        /// <param name="extraProperties"> Workspace level configs and feature flags. </param>
        /// <param name="managedVirtualNetworkSettings"> Managed Virtual Network Settings. </param>
        /// <param name="workspaceRepositoryConfiguration"> Git integration settings. </param>
        /// <param name="purviewConfiguration"> Purview Configuration. </param>
        /// <param name="adlaResourceId"> The ADLA resource ID. </param>
        internal Workspace(string id, string name, string type, IDictionary<string, string> tags, string location, ManagedIdentity identity, DataLakeStorageAccountDetails defaultDataLakeStorage, string sqlAdministratorLoginPassword, string managedResourceGroupName, string provisioningState, string sqlAdministratorLogin, VirtualNetworkProfile virtualNetworkProfile, IDictionary<string, string> connectivityEndpoints, string managedVirtualNetwork, IList<PrivateEndpointConnection> privateEndpointConnections, EncryptionDetails encryption, Guid? workspaceUID, IReadOnlyDictionary<string, object> extraProperties, ManagedVirtualNetworkSettings managedVirtualNetworkSettings, WorkspaceRepositoryConfiguration workspaceRepositoryConfiguration, PurviewConfiguration purviewConfiguration, string adlaResourceId) : base(id, name, type, tags, location)
        {
            Identity = identity;
            DefaultDataLakeStorage = defaultDataLakeStorage;
            SqlAdministratorLoginPassword = sqlAdministratorLoginPassword;
            ManagedResourceGroupName = managedResourceGroupName;
            ProvisioningState = provisioningState;
            SqlAdministratorLogin = sqlAdministratorLogin;
            VirtualNetworkProfile = virtualNetworkProfile;
            ConnectivityEndpoints = connectivityEndpoints;
            ManagedVirtualNetwork = managedVirtualNetwork;
            PrivateEndpointConnections = privateEndpointConnections;
            Encryption = encryption;
            WorkspaceUID = workspaceUID;
            ExtraProperties = extraProperties;
            ManagedVirtualNetworkSettings = managedVirtualNetworkSettings;
            WorkspaceRepositoryConfiguration = workspaceRepositoryConfiguration;
            PurviewConfiguration = purviewConfiguration;
            AdlaResourceId = adlaResourceId;
        }

        /// <summary> Identity of the workspace. </summary>
        public ManagedIdentity Identity { get; set; }
        /// <summary> Workspace default data lake storage account details. </summary>
        public DataLakeStorageAccountDetails DefaultDataLakeStorage { get; set; }
        /// <summary> SQL administrator login password. </summary>
        public string SqlAdministratorLoginPassword { get; set; }
        /// <summary> Workspace managed resource group. The resource group name uniquely identifies the resource group within the user subscriptionId. The resource group name must be no longer than 90 characters long, and must be alphanumeric characters (Char.IsLetterOrDigit()) and '-', '_', '(', ')' and'.'. Note that the name cannot end with '.'. </summary>
        public string ManagedResourceGroupName { get; set; }
        /// <summary> Resource provisioning state. </summary>
        public string ProvisioningState { get; }
        /// <summary> Login for workspace SQL active directory administrator. </summary>
        public string SqlAdministratorLogin { get; set; }
        /// <summary> Virtual Network profile. </summary>
        public VirtualNetworkProfile VirtualNetworkProfile { get; set; }
        /// <summary> Connectivity endpoints. </summary>
        public IDictionary<string, string> ConnectivityEndpoints { get; }
        /// <summary> Setting this to 'default' will ensure that all compute for this workspace is in a virtual network managed on behalf of the user. </summary>
        public string ManagedVirtualNetwork { get; set; }
        /// <summary> Private endpoint connections to the workspace. </summary>
        public IList<PrivateEndpointConnection> PrivateEndpointConnections { get; }
        /// <summary> The encryption details of the workspace. </summary>
        public EncryptionDetails Encryption { get; set; }
        /// <summary> The workspace unique identifier. </summary>
        public Guid? WorkspaceUID { get; }
        /// <summary> Workspace level configs and feature flags. </summary>
        public IReadOnlyDictionary<string, object> ExtraProperties { get; }
        /// <summary> Managed Virtual Network Settings. </summary>
        public ManagedVirtualNetworkSettings ManagedVirtualNetworkSettings { get; set; }
        /// <summary> Git integration settings. </summary>
        public WorkspaceRepositoryConfiguration WorkspaceRepositoryConfiguration { get; set; }
        /// <summary> Purview Configuration. </summary>
        public PurviewConfiguration PurviewConfiguration { get; set; }
        /// <summary> The ADLA resource ID. </summary>
        public string AdlaResourceId { get; }
    }
}
