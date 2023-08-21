// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetworkCloud.Models;

namespace Azure.ResourceManager.NetworkCloud
{
    /// <summary>
    /// A class representing the NetworkCloudVirtualMachine data model.
    /// VirtualMachine represents the on-premises Network Cloud virtual machine.
    /// </summary>
    public partial class NetworkCloudVirtualMachineData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of NetworkCloudVirtualMachineData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extended location of the cluster associated with the resource. </param>
        /// <param name="adminUsername"> The name of the administrator to which the ssh public keys will be added into the authorized keys. </param>
        /// <param name="cloudServicesNetworkAttachment"> The cloud service network that provides platform-level services for the virtual machine. </param>
        /// <param name="cpuCores"> The number of CPU cores in the virtual machine. </param>
        /// <param name="memorySizeInGB"> The memory size of the virtual machine in GB. </param>
        /// <param name="storageProfile"> The storage profile that specifies size and other parameters about the disks related to the virtual machine. </param>
        /// <param name="vmImage"> The virtual machine image that is currently provisioned to the OS disk, using the full url and tag notation used to pull the image. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="extendedLocation"/>, <paramref name="adminUsername"/>, <paramref name="cloudServicesNetworkAttachment"/>, <paramref name="storageProfile"/> or <paramref name="vmImage"/> is null. </exception>
        public NetworkCloudVirtualMachineData(AzureLocation location, ExtendedLocation extendedLocation, string adminUsername, NetworkAttachment cloudServicesNetworkAttachment, long cpuCores, long memorySizeInGB, NetworkCloudStorageProfile storageProfile, string vmImage) : base(location)
        {
            Argument.AssertNotNull(extendedLocation, nameof(extendedLocation));
            Argument.AssertNotNull(adminUsername, nameof(adminUsername));
            Argument.AssertNotNull(cloudServicesNetworkAttachment, nameof(cloudServicesNetworkAttachment));
            Argument.AssertNotNull(storageProfile, nameof(storageProfile));
            Argument.AssertNotNull(vmImage, nameof(vmImage));

            ExtendedLocation = extendedLocation;
            AdminUsername = adminUsername;
            CloudServicesNetworkAttachment = cloudServicesNetworkAttachment;
            CpuCores = cpuCores;
            MemorySizeInGB = memorySizeInGB;
            NetworkAttachments = new Core.ChangeTrackingList<NetworkAttachment>();
            PlacementHints = new Core.ChangeTrackingList<VirtualMachinePlacementHint>();
            SshPublicKeys = new Core.ChangeTrackingList<NetworkCloudSshPublicKey>();
            StorageProfile = storageProfile;
            VmImage = vmImage;
            Volumes = new Core.ChangeTrackingList<ResourceIdentifier>();
        }

        /// <summary> Initializes a new instance of NetworkCloudVirtualMachineData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extended location of the cluster associated with the resource. </param>
        /// <param name="adminUsername"> The name of the administrator to which the ssh public keys will be added into the authorized keys. </param>
        /// <param name="availabilityZone"> The cluster availability zone containing this virtual machine. </param>
        /// <param name="bareMetalMachineId"> The resource ID of the bare metal machine the virtual machine has landed to. </param>
        /// <param name="bootMethod"> Selects the boot method for the virtual machine. </param>
        /// <param name="cloudServicesNetworkAttachment"> The cloud service network that provides platform-level services for the virtual machine. </param>
        /// <param name="clusterId"> The resource ID of the cluster the virtual machine is created for. </param>
        /// <param name="cpuCores"> The number of CPU cores in the virtual machine. </param>
        /// <param name="detailedStatus"> The more detailed status of the virtual machine. </param>
        /// <param name="detailedStatusMessage"> The descriptive message about the current detailed status. </param>
        /// <param name="isolateEmulatorThread"> Field Deprecated, the value will be ignored if provided. The indicator of whether one of the specified CPU cores is isolated to run the emulator thread for this virtual machine. </param>
        /// <param name="memorySizeInGB"> The memory size of the virtual machine in GB. </param>
        /// <param name="networkAttachments"> The list of network attachments to the virtual machine. </param>
        /// <param name="networkData"> The Base64 encoded cloud-init network data. </param>
        /// <param name="placementHints"> The scheduling hints for the virtual machine. </param>
        /// <param name="powerState"> The power state of the virtual machine. </param>
        /// <param name="provisioningState"> The provisioning state of the virtual machine. </param>
        /// <param name="sshPublicKeys"> The list of ssh public keys. Each key will be added to the virtual machine using the cloud-init ssh_authorized_keys mechanism for the adminUsername. </param>
        /// <param name="storageProfile"> The storage profile that specifies size and other parameters about the disks related to the virtual machine. </param>
        /// <param name="userData"> The Base64 encoded cloud-init user data. </param>
        /// <param name="virtioInterface"> Field Deprecated, use virtualizationModel instead. The type of the virtio interface. </param>
        /// <param name="vmDeviceModel"> The type of the device model to use. </param>
        /// <param name="vmImage"> The virtual machine image that is currently provisioned to the OS disk, using the full url and tag notation used to pull the image. </param>
        /// <param name="vmImageRepositoryCredentials"> The credentials used to login to the image repository that has access to the specified image. </param>
        /// <param name="volumes"> The resource IDs of volumes that are attached to the virtual machine. </param>
        internal NetworkCloudVirtualMachineData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ExtendedLocation extendedLocation, string adminUsername, string availabilityZone, ResourceIdentifier bareMetalMachineId, VirtualMachineBootMethod? bootMethod, NetworkAttachment cloudServicesNetworkAttachment, ResourceIdentifier clusterId, long cpuCores, VirtualMachineDetailedStatus? detailedStatus, string detailedStatusMessage, VirtualMachineIsolateEmulatorThread? isolateEmulatorThread, long memorySizeInGB, IList<NetworkAttachment> networkAttachments, string networkData, IList<VirtualMachinePlacementHint> placementHints, VirtualMachinePowerState? powerState, VirtualMachineProvisioningState? provisioningState, IList<NetworkCloudSshPublicKey> sshPublicKeys, NetworkCloudStorageProfile storageProfile, string userData, VirtualMachineVirtioInterfaceType? virtioInterface, VirtualMachineDeviceModelType? vmDeviceModel, string vmImage, ImageRepositoryCredentials vmImageRepositoryCredentials, IReadOnlyList<ResourceIdentifier> volumes) : base(id, name, resourceType, systemData, tags, location)
        {
            ExtendedLocation = extendedLocation;
            AdminUsername = adminUsername;
            AvailabilityZone = availabilityZone;
            BareMetalMachineId = bareMetalMachineId;
            BootMethod = bootMethod;
            CloudServicesNetworkAttachment = cloudServicesNetworkAttachment;
            ClusterId = clusterId;
            CpuCores = cpuCores;
            DetailedStatus = detailedStatus;
            DetailedStatusMessage = detailedStatusMessage;
            IsolateEmulatorThread = isolateEmulatorThread;
            MemorySizeInGB = memorySizeInGB;
            NetworkAttachments = networkAttachments;
            NetworkData = networkData;
            PlacementHints = placementHints;
            PowerState = powerState;
            ProvisioningState = provisioningState;
            SshPublicKeys = sshPublicKeys;
            StorageProfile = storageProfile;
            UserData = userData;
            VirtioInterface = virtioInterface;
            VmDeviceModel = vmDeviceModel;
            VmImage = vmImage;
            VmImageRepositoryCredentials = vmImageRepositoryCredentials;
            Volumes = volumes;
        }

        /// <summary> The extended location of the cluster associated with the resource. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> The name of the administrator to which the ssh public keys will be added into the authorized keys. </summary>
        public string AdminUsername { get; set; }
        /// <summary> The cluster availability zone containing this virtual machine. </summary>
        public string AvailabilityZone { get; }
        /// <summary> The resource ID of the bare metal machine the virtual machine has landed to. </summary>
        public ResourceIdentifier BareMetalMachineId { get; }
        /// <summary> Selects the boot method for the virtual machine. </summary>
        public VirtualMachineBootMethod? BootMethod { get; set; }
        /// <summary> The cloud service network that provides platform-level services for the virtual machine. </summary>
        public NetworkAttachment CloudServicesNetworkAttachment { get; set; }
        /// <summary> The resource ID of the cluster the virtual machine is created for. </summary>
        public ResourceIdentifier ClusterId { get; }
        /// <summary> The number of CPU cores in the virtual machine. </summary>
        public long CpuCores { get; set; }
        /// <summary> The more detailed status of the virtual machine. </summary>
        public VirtualMachineDetailedStatus? DetailedStatus { get; }
        /// <summary> The descriptive message about the current detailed status. </summary>
        public string DetailedStatusMessage { get; }
        /// <summary> Field Deprecated, the value will be ignored if provided. The indicator of whether one of the specified CPU cores is isolated to run the emulator thread for this virtual machine. </summary>
        public VirtualMachineIsolateEmulatorThread? IsolateEmulatorThread { get; set; }
        /// <summary> The memory size of the virtual machine in GB. </summary>
        public long MemorySizeInGB { get; set; }
        /// <summary> The list of network attachments to the virtual machine. </summary>
        public IList<NetworkAttachment> NetworkAttachments { get; }
        /// <summary> The Base64 encoded cloud-init network data. </summary>
        public string NetworkData { get; set; }
        /// <summary> The scheduling hints for the virtual machine. </summary>
        public IList<VirtualMachinePlacementHint> PlacementHints { get; }
        /// <summary> The power state of the virtual machine. </summary>
        public VirtualMachinePowerState? PowerState { get; }
        /// <summary> The provisioning state of the virtual machine. </summary>
        public VirtualMachineProvisioningState? ProvisioningState { get; }
        /// <summary> The list of ssh public keys. Each key will be added to the virtual machine using the cloud-init ssh_authorized_keys mechanism for the adminUsername. </summary>
        public IList<NetworkCloudSshPublicKey> SshPublicKeys { get; }
        /// <summary> The storage profile that specifies size and other parameters about the disks related to the virtual machine. </summary>
        public NetworkCloudStorageProfile StorageProfile { get; set; }
        /// <summary> The Base64 encoded cloud-init user data. </summary>
        public string UserData { get; set; }
        /// <summary> Field Deprecated, use virtualizationModel instead. The type of the virtio interface. </summary>
        public VirtualMachineVirtioInterfaceType? VirtioInterface { get; set; }
        /// <summary> The type of the device model to use. </summary>
        public VirtualMachineDeviceModelType? VmDeviceModel { get; set; }
        /// <summary> The virtual machine image that is currently provisioned to the OS disk, using the full url and tag notation used to pull the image. </summary>
        public string VmImage { get; set; }
        /// <summary> The credentials used to login to the image repository that has access to the specified image. </summary>
        public ImageRepositoryCredentials VmImageRepositoryCredentials { get; set; }
        /// <summary> The resource IDs of volumes that are attached to the virtual machine. </summary>
        public IReadOnlyList<ResourceIdentifier> Volumes { get; }
    }
}
