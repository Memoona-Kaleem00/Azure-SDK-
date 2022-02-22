// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ResourceGroupExtensions
    {
        private static ResourceGroupExtensionClient GetExtensionClient(ResourceGroup resourceGroup)
        {
            return resourceGroup.GetCachedClient((client) =>
            {
                return new ResourceGroupExtensionClient(client, resourceGroup.Id);
            }
            );
        }

        /// <summary> Gets a collection of AvailabilitySets in the AvailabilitySet. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of AvailabilitySets and their operations over a AvailabilitySet. </returns>
        public static AvailabilitySetCollection GetAvailabilitySets(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetAvailabilitySets();
        }

        /// <summary> Gets a collection of ProximityPlacementGroups in the ProximityPlacementGroup. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ProximityPlacementGroups and their operations over a ProximityPlacementGroup. </returns>
        public static ProximityPlacementGroupCollection GetProximityPlacementGroups(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetProximityPlacementGroups();
        }

        /// <summary> Gets a collection of DedicatedHostGroups in the DedicatedHostGroup. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DedicatedHostGroups and their operations over a DedicatedHostGroup. </returns>
        public static DedicatedHostGroupCollection GetDedicatedHostGroups(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetDedicatedHostGroups();
        }

        /// <summary> Gets a collection of SshPublicKeys in the SshPublicKey. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of SshPublicKeys and their operations over a SshPublicKey. </returns>
        public static SshPublicKeyCollection GetSshPublicKeys(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetSshPublicKeys();
        }

        /// <summary> Gets a collection of VirtualMachines in the VirtualMachine. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of VirtualMachines and their operations over a VirtualMachine. </returns>
        public static VirtualMachineCollection GetVirtualMachines(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetVirtualMachines();
        }

        /// <summary> Gets a collection of VirtualMachineScaleSets in the VirtualMachineScaleSet. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of VirtualMachineScaleSets and their operations over a VirtualMachineScaleSet. </returns>
        public static VirtualMachineScaleSetCollection GetVirtualMachineScaleSets(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetVirtualMachineScaleSets();
        }

        /// <summary> Gets a collection of Images in the Image. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of Images and their operations over a Image. </returns>
        public static ImageCollection GetImages(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetImages();
        }

        /// <summary> Gets a collection of RestorePointGroups in the RestorePointGroup. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of RestorePointGroups and their operations over a RestorePointGroup. </returns>
        public static RestorePointGroupCollection GetRestorePointGroups(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetRestorePointGroups();
        }

        /// <summary> Gets a collection of CapacityReservationGroups in the CapacityReservationGroup. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of CapacityReservationGroups and their operations over a CapacityReservationGroup. </returns>
        public static CapacityReservationGroupCollection GetCapacityReservationGroups(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetCapacityReservationGroups();
        }

        /// <summary> Gets a collection of Disks in the Disk. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of Disks and their operations over a Disk. </returns>
        public static DiskCollection GetDisks(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetDisks();
        }

        /// <summary> Gets a collection of Snapshots in the Snapshot. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of Snapshots and their operations over a Snapshot. </returns>
        public static SnapshotCollection GetSnapshots(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetSnapshots();
        }

        /// <summary> Gets a collection of DiskEncryptionSets in the DiskEncryptionSet. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DiskEncryptionSets and their operations over a DiskEncryptionSet. </returns>
        public static DiskEncryptionSetCollection GetDiskEncryptionSets(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetDiskEncryptionSets();
        }

        /// <summary> Gets a collection of DiskAccesses in the DiskAccess. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DiskAccesses and their operations over a DiskAccess. </returns>
        public static DiskAccessCollection GetDiskAccesses(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetDiskAccesses();
        }

        /// <summary> Gets a collection of Galleries in the Gallery. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of Galleries and their operations over a Gallery. </returns>
        public static GalleryCollection GetGalleries(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetGalleries();
        }

        /// <summary> Gets a collection of CloudServices in the CloudService. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of CloudServices and their operations over a CloudService. </returns>
        public static CloudServiceCollection GetCloudServices(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetCloudServices();
        }
    }
}
