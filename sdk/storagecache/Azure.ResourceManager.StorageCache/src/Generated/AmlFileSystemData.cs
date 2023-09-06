// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.StorageCache.Models;

namespace Azure.ResourceManager.StorageCache
{
    /// <summary>
    /// A class representing the AmlFileSystem data model.
    /// An AML file system instance. Follows Azure Resource Manager standards: https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/resource-api-reference.md
    /// </summary>
    public partial class AmlFileSystemData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AmlFileSystemData"/>. </summary>
        /// <param name="location"> The location. </param>
        public AmlFileSystemData(AzureLocation location) : base(location)
        {
            Zones = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AmlFileSystemData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The managed identity used by the AML file system, if configured. Current supported identity types: None, UserAssigned. </param>
        /// <param name="sku"> SKU for the resource. </param>
        /// <param name="zones"> Availability zones for resources. This field should only contain a single element in the array. </param>
        /// <param name="storageCapacityTiB"> The size of the AML file system, in TiB. This might be rounded up. </param>
        /// <param name="health"> Health of the AML file system. </param>
        /// <param name="provisioningState"> ARM provisioning state. </param>
        /// <param name="filesystemSubnet"> Subnet used for managing the AML file system and for client-facing operations. This subnet should have at least a /24 subnet mask within the VNET's address space. </param>
        /// <param name="clientInfo"> Client information for the AML file system. </param>
        /// <param name="throughputProvisionedMBps"> Throughput provisioned in MB per sec, calculated as storageCapacityTiB * per-unit storage throughput. </param>
        /// <param name="encryptionSettings"> Specifies encryption settings of the AML file system. </param>
        /// <param name="maintenanceWindow"> Start time of a 30-minute weekly maintenance window. </param>
        /// <param name="hsm"> Hydration and archive settings and status. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AmlFileSystemData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, StorageCacheSkuName sku, IList<string> zones, float? storageCapacityTiB, AmlFileSystemHealth health, AmlFileSystemProvisioningStateType? provisioningState, string filesystemSubnet, AmlFileSystemClientInfo clientInfo, int? throughputProvisionedMBps, AmlFileSystemEncryptionSettings encryptionSettings, AmlFileSystemPropertiesMaintenanceWindow maintenanceWindow, AmlFileSystemPropertiesHsm hsm, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            Sku = sku;
            Zones = zones;
            StorageCapacityTiB = storageCapacityTiB;
            Health = health;
            ProvisioningState = provisioningState;
            FilesystemSubnet = filesystemSubnet;
            ClientInfo = clientInfo;
            ThroughputProvisionedMBps = throughputProvisionedMBps;
            EncryptionSettings = encryptionSettings;
            MaintenanceWindow = maintenanceWindow;
            Hsm = hsm;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="AmlFileSystemData"/> for deserialization. </summary>
        internal AmlFileSystemData()
        {
        }

        /// <summary> The managed identity used by the AML file system, if configured. Current supported identity types: None, UserAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> SKU for the resource. </summary>
        internal StorageCacheSkuName Sku { get; set; }
        /// <summary> SKU name for this resource. </summary>
        public string SkuName
        {
            get => Sku is null ? default : Sku.Name;
            set
            {
                if (Sku is null)
                    Sku = new StorageCacheSkuName();
                Sku.Name = value;
            }
        }

        /// <summary> Availability zones for resources. This field should only contain a single element in the array. </summary>
        public IList<string> Zones { get; }
        /// <summary> The size of the AML file system, in TiB. This might be rounded up. </summary>
        public float? StorageCapacityTiB { get; set; }
        /// <summary> Health of the AML file system. </summary>
        public AmlFileSystemHealth Health { get; }
        /// <summary> ARM provisioning state. </summary>
        public AmlFileSystemProvisioningStateType? ProvisioningState { get; }
        /// <summary> Subnet used for managing the AML file system and for client-facing operations. This subnet should have at least a /24 subnet mask within the VNET's address space. </summary>
        public string FilesystemSubnet { get; set; }
        /// <summary> Client information for the AML file system. </summary>
        public AmlFileSystemClientInfo ClientInfo { get; }
        /// <summary> Throughput provisioned in MB per sec, calculated as storageCapacityTiB * per-unit storage throughput. </summary>
        public int? ThroughputProvisionedMBps { get; }
        /// <summary> Specifies encryption settings of the AML file system. </summary>
        internal AmlFileSystemEncryptionSettings EncryptionSettings { get; set; }
        /// <summary> Specifies the location of the encryption key in Key Vault. </summary>
        public StorageCacheEncryptionKeyVaultKeyReference KeyEncryptionKey
        {
            get => EncryptionSettings is null ? default : EncryptionSettings.KeyEncryptionKey;
            set
            {
                if (EncryptionSettings is null)
                    EncryptionSettings = new AmlFileSystemEncryptionSettings();
                EncryptionSettings.KeyEncryptionKey = value;
            }
        }

        /// <summary> Start time of a 30-minute weekly maintenance window. </summary>
        public AmlFileSystemPropertiesMaintenanceWindow MaintenanceWindow { get; set; }
        /// <summary> Hydration and archive settings and status. </summary>
        public AmlFileSystemPropertiesHsm Hsm { get; set; }
    }
}
