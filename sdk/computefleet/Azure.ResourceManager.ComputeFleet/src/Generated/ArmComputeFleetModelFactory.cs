// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ComputeFleet.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmComputeFleetModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="ComputeFleet.ComputeFleetData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> The resource-specific properties for this resource. </param>
        /// <param name="zones"> Zones in which the Compute Fleet is available. </param>
        /// <param name="identity"> The managed service identities assigned to this resource. </param>
        /// <param name="plan"> Details of the resource plan. </param>
        /// <returns> A new <see cref="ComputeFleet.ComputeFleetData"/> instance for mocking. </returns>
        public static ComputeFleetData ComputeFleetData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ComputeFleetProperties properties = null, IEnumerable<string> zones = null, ManagedServiceIdentity identity = null, ArmPlan plan = null)
        {
            tags ??= new Dictionary<string, string>();
            zones ??= new List<string>();

            return new ComputeFleetData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                properties,
                zones?.ToList(),
                identity,
                plan,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ComputeFleetProperties"/>. </summary>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <param name="spotPriorityProfile"> Configuration Options for Spot instances in Compute Fleet. </param>
        /// <param name="regularPriorityProfile"> Configuration Options for Regular instances in Compute Fleet. </param>
        /// <param name="vmSizesProfile"> List of VM sizes supported for Compute Fleet. </param>
        /// <param name="computeProfile"> Compute Profile to use for running user's workloads. </param>
        /// <param name="createdOn"> Specifies the time at which the Compute Fleet is created. </param>
        /// <param name="uniqueId"> Specifies the ID which uniquely identifies a Compute Fleet. </param>
        /// <returns> A new <see cref="Models.ComputeFleetProperties"/> instance for mocking. </returns>
        public static ComputeFleetProperties ComputeFleetProperties(ComputeFleetProvisioningState? provisioningState = null, SpotPriorityProfile spotPriorityProfile = null, RegularPriorityProfile regularPriorityProfile = null, IEnumerable<ComputeFleetVmSizeProfile> vmSizesProfile = null, ComputeFleetComputeProfile computeProfile = null, DateTimeOffset? createdOn = null, string uniqueId = null)
        {
            vmSizesProfile ??= new List<ComputeFleetVmSizeProfile>();

            return new ComputeFleetProperties(
                provisioningState,
                spotPriorityProfile,
                regularPriorityProfile,
                vmSizesProfile?.ToList(),
                computeProfile,
                createdOn,
                uniqueId,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ComputeFleetVmProfile"/>. </summary>
        /// <param name="osProfile">
        /// Specifies the operating system settings for the virtual machines in the scale
        /// set.
        /// </param>
        /// <param name="storageProfile"> Specifies the storage settings for the virtual machine disks. </param>
        /// <param name="networkProfile">
        /// Specifies properties of the network interfaces of the virtual machines in the
        /// scale set.
        /// </param>
        /// <param name="securityProfile">
        /// Specifies the Security related profile settings for the virtual machines in the
        /// scale set.
        /// </param>
        /// <param name="bootDiagnostics"> Specifies the boot diagnostic settings state. </param>
        /// <param name="extensionProfile">
        /// Specifies a collection of settings for extensions installed on virtual machines
        /// in the scale set.
        /// </param>
        /// <param name="licenseType">
        /// Specifies that the image or disk that is being used was licensed on-premises.
        /// &lt;br&gt;&lt;br&gt; Possible values for Windows Server operating system are: &lt;br&gt;&lt;br&gt;
        /// Windows_Client &lt;br&gt;&lt;br&gt; Windows_Server &lt;br&gt;&lt;br&gt; Possible values for Linux
        /// Server operating system are: &lt;br&gt;&lt;br&gt; RHEL_BYOS (for RHEL) &lt;br&gt;&lt;br&gt; SLES_BYOS
        /// (for SUSE) &lt;br&gt;&lt;br&gt; For more information, see [Azure Hybrid Use Benefit for
        /// Windows
        /// Server](https://docs.microsoft.com/azure/virtual-machines/windows/hybrid-use-benefit-licensing)
        /// &lt;br&gt;&lt;br&gt; [Azure Hybrid Use Benefit for Linux
        /// Server](https://docs.microsoft.com/azure/virtual-machines/linux/azure-hybrid-benefit-linux)
        /// &lt;br&gt;&lt;br&gt; Minimum api-version: 2015-06-15
        /// </param>
        /// <param name="scheduledEventsProfile"> Specifies Scheduled Event related configurations. </param>
        /// <param name="userData">
        /// UserData for the virtual machines in the scale set, which must be base-64
        /// encoded. Customer should not pass any secrets in here. Minimum api-version:
        /// 2021-03-01.
        /// </param>
        /// <param name="capacityReservationGroupId">
        /// Specifies the capacity reservation related details of a scale set. Minimum
        /// api-version: 2021-04-01.
        /// </param>
        /// <param name="galleryApplications"> Specifies the gallery applications that should be made available to the VM/VMSS. </param>
        /// <param name="hardwareVmSizeProperties">
        /// Specifies the hardware profile related details of a scale set. Minimum
        /// api-version: 2021-11-01.
        /// </param>
        /// <param name="serviceArtifactReferenceId">
        /// Specifies the service artifact reference id used to set same image version for
        /// all virtual machines in the scale set when using 'latest' image version.
        /// Minimum api-version: 2022-11-01
        /// </param>
        /// <param name="securityPostureReference">
        /// Specifies the security posture to be used for all virtual machines in the scale
        /// set. Minimum api-version: 2023-03-01
        /// </param>
        /// <param name="createdOn">
        /// Specifies the time in which this VM profile for the Virtual Machine Scale Set
        /// was created. Minimum API version for this property is 2023-09-01. This value
        /// will be added to VMSS Flex VM tags when creating/updating the VMSS VM Profile
        /// with minimum api-version 2023-09-01. Examples: "2024-07-01T00:00:01.1234567+00:00"
        /// </param>
        /// <returns> A new <see cref="Models.ComputeFleetVmProfile"/> instance for mocking. </returns>
        public static ComputeFleetVmProfile ComputeFleetVmProfile(ComputeFleetVmssOSProfile osProfile = null, ComputeFleetVmssStorageProfile storageProfile = null, ComputeFleetVmssNetworkProfile networkProfile = null, ComputeFleetSecurityProfile securityProfile = null, ComputeFleetBootDiagnostics bootDiagnostics = null, ComputeFleetVmssExtensionProfile extensionProfile = null, string licenseType = null, ComputeFleetScheduledEventsProfile scheduledEventsProfile = null, string userData = null, ResourceIdentifier capacityReservationGroupId = null, IEnumerable<ComputeFleetVmGalleryApplication> galleryApplications = null, ComputeFleetVmSizeProperties hardwareVmSizeProperties = null, ResourceIdentifier serviceArtifactReferenceId = null, ComputeFleetSecurityPostureReference securityPostureReference = null, DateTimeOffset? createdOn = null)
        {
            galleryApplications ??= new List<ComputeFleetVmGalleryApplication>();

            return new ComputeFleetVmProfile(
                osProfile,
                storageProfile,
                networkProfile,
                securityProfile,
                bootDiagnostics != null ? new ComputeFleetDiagnosticsProfile(bootDiagnostics, serializedAdditionalRawData: null) : null,
                extensionProfile,
                licenseType,
                scheduledEventsProfile,
                userData,
                capacityReservationGroupId != null ? new CapacityReservationProfile(ResourceManagerModelFactory.WritableSubResource(capacityReservationGroupId), serializedAdditionalRawData: null) : null,
                galleryApplications != null ? new ComputeFleetApplicationProfile(galleryApplications?.ToList(), serializedAdditionalRawData: null) : null,
                hardwareVmSizeProperties != null ? new ComputeFleetVmssHardwareProfile(hardwareVmSizeProperties, serializedAdditionalRawData: null) : null,
                serviceArtifactReferenceId != null ? ResourceManagerModelFactory.WritableSubResource(serviceArtifactReferenceId) : null,
                securityPostureReference,
                createdOn,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ComputeFleetImageReference"/>. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="publisher"> The image publisher. </param>
        /// <param name="offer">
        /// Specifies the offer of the platform image or marketplace image used to create
        /// the virtual machine.
        /// </param>
        /// <param name="sku"> The image SKU. </param>
        /// <param name="version">
        /// Specifies the version of the platform image or marketplace image used to create
        /// the virtual machine. The allowed formats are Major.Minor.Build or 'latest'.
        /// Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest
        /// version of an image available at deploy time. Even if you use 'latest', the VM
        /// image will not automatically update after deploy time even if a new version
        /// becomes available. Please do not use field 'version' for gallery image
        /// deployment, gallery image should always use 'id' field for deployment, to use 'latest'
        /// version of gallery image, just set
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{imageName}'
        /// in the 'id' field without version input.
        /// </param>
        /// <param name="exactVersion">
        /// Specifies in decimal numbers, the version of platform image or marketplace
        /// image used to create the virtual machine. This readonly field differs from 'version',
        /// only if the value specified in 'version' field is 'latest'.
        /// </param>
        /// <param name="sharedGalleryImageId">
        /// Specified the shared gallery image unique id for vm deployment. This can be
        /// fetched from shared gallery image GET call.
        /// </param>
        /// <param name="communityGalleryImageId">
        /// Specified the community gallery image unique id for vm deployment. This can be
        /// fetched from community gallery image GET call.
        /// </param>
        /// <returns> A new <see cref="Models.ComputeFleetImageReference"/> instance for mocking. </returns>
        public static ComputeFleetImageReference ComputeFleetImageReference(ResourceIdentifier id = null, string publisher = null, string offer = null, string sku = null, string version = null, string exactVersion = null, string sharedGalleryImageId = null, string communityGalleryImageId = null)
        {
            return new ComputeFleetImageReference(
                id,
                publisher,
                offer,
                sku,
                version,
                exactVersion,
                sharedGalleryImageId,
                communityGalleryImageId,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ComputeFleetVmssExtension"/>. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> The name of the extension. </param>
        /// <param name="extensionType"> Resource type. </param>
        /// <param name="properties"> Describes the properties of a Virtual Machine Scale Set Extension. </param>
        /// <returns> A new <see cref="Models.ComputeFleetVmssExtension"/> instance for mocking. </returns>
        public static ComputeFleetVmssExtension ComputeFleetVmssExtension(ResourceIdentifier id = null, string name = null, string extensionType = null, ComputeFleetVmssExtensionProperties properties = null)
        {
            return new ComputeFleetVmssExtension(id, name, extensionType, properties, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ComputeFleetVmssExtensionProperties"/>. </summary>
        /// <param name="forceUpdateTag">
        /// If a value is provided and is different from the previous value, the extension
        /// handler will be forced to update even if the extension configuration has not
        /// changed.
        /// </param>
        /// <param name="publisher"> The name of the extension handler publisher. </param>
        /// <param name="extensionType"> Specifies the type of the extension; an example is "CustomScriptExtension". </param>
        /// <param name="typeHandlerVersion"> Specifies the version of the script handler. </param>
        /// <param name="shouldAutoUpgradeMinorVersion">
        /// Indicates whether the extension should use a newer minor version if one is
        /// available at deployment time. Once deployed, however, the extension will not
        /// upgrade minor versions unless redeployed, even with this property set to true.
        /// </param>
        /// <param name="isAutomaticUpgradeEnabled">
        /// Indicates whether the extension should be automatically upgraded by the
        /// platform if there is a newer version of the extension available.
        /// </param>
        /// <param name="settings"> Json formatted public settings for the extension. </param>
        /// <param name="protectedSettings">
        /// The extension can contain either protectedSettings or
        /// protectedSettingsFromKeyVault or no protected settings at all.
        /// </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="provisionAfterExtensions">
        /// Collection of extension names after which this extension needs to be
        /// provisioned.
        /// </param>
        /// <param name="isSuppressFailuresEnabled">
        /// Indicates whether failures stemming from the extension will be suppressed
        /// (Operational failures such as not connecting to the VM will not be suppressed
        /// regardless of this value). The default is false.
        /// </param>
        /// <param name="protectedSettingsFromKeyVault">
        /// The extensions protected settings that are passed by reference, and consumed
        /// from key vault
        /// </param>
        /// <returns> A new <see cref="Models.ComputeFleetVmssExtensionProperties"/> instance for mocking. </returns>
        public static ComputeFleetVmssExtensionProperties ComputeFleetVmssExtensionProperties(string forceUpdateTag = null, string publisher = null, string extensionType = null, string typeHandlerVersion = null, bool? shouldAutoUpgradeMinorVersion = null, bool? isAutomaticUpgradeEnabled = null, IDictionary<string, BinaryData> settings = null, IDictionary<string, BinaryData> protectedSettings = null, string provisioningState = null, IEnumerable<string> provisionAfterExtensions = null, bool? isSuppressFailuresEnabled = null, ComputeFleetKeyVaultSecretReference protectedSettingsFromKeyVault = null)
        {
            settings ??= new Dictionary<string, BinaryData>();
            protectedSettings ??= new Dictionary<string, BinaryData>();
            provisionAfterExtensions ??= new List<string>();

            return new ComputeFleetVmssExtensionProperties(
                forceUpdateTag,
                publisher,
                extensionType,
                typeHandlerVersion,
                shouldAutoUpgradeMinorVersion,
                isAutomaticUpgradeEnabled,
                settings,
                protectedSettings,
                provisioningState,
                provisionAfterExtensions?.ToList(),
                isSuppressFailuresEnabled,
                protectedSettingsFromKeyVault,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ComputeFleetVmss"/>. </summary>
        /// <param name="id">
        /// The compute RP resource id of the virtualMachineScaleSet
        /// "subscriptions/{subId}/resourceGroups/{rgName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmssName}"
        /// </param>
        /// <param name="type"> Type of the virtualMachineScaleSet. </param>
        /// <param name="operationStatus"> This represents the operationStatus of the VMSS in response to the last operation that was performed on it by Azure Fleet resource. </param>
        /// <param name="error"> Error Information when `operationStatus` is `Failed`. </param>
        /// <returns> A new <see cref="Models.ComputeFleetVmss"/> instance for mocking. </returns>
        public static ComputeFleetVmss ComputeFleetVmss(string id = null, string type = null, ComputeFleetProvisioningState operationStatus = default, ComputeFleetApiError error = null)
        {
            return new ComputeFleetVmss(id, type, operationStatus, error, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ComputeFleetApiError"/>. </summary>
        /// <param name="code"> The error code. </param>
        /// <param name="target"> The target of the particular error. </param>
        /// <param name="message"> The error message. </param>
        /// <param name="details"> The API error details. </param>
        /// <param name="innererror"> The API inner error. </param>
        /// <returns> A new <see cref="Models.ComputeFleetApiError"/> instance for mocking. </returns>
        public static ComputeFleetApiError ComputeFleetApiError(string code = null, string target = null, string message = null, IEnumerable<ComputeFleetApiErrorInfo> details = null, ComputeFleetInnerError innererror = null)
        {
            details ??= new List<ComputeFleetApiErrorInfo>();

            return new ComputeFleetApiError(
                code,
                target,
                message,
                details?.ToList(),
                innererror,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ComputeFleetApiErrorInfo"/>. </summary>
        /// <param name="code"> The error code. </param>
        /// <param name="target"> The target of the particular error. </param>
        /// <param name="message"> The error message. </param>
        /// <returns> A new <see cref="Models.ComputeFleetApiErrorInfo"/> instance for mocking. </returns>
        public static ComputeFleetApiErrorInfo ComputeFleetApiErrorInfo(string code = null, string target = null, string message = null)
        {
            return new ComputeFleetApiErrorInfo(code, target, message, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ComputeFleetInnerError"/>. </summary>
        /// <param name="exceptionType"> The exception type. </param>
        /// <param name="errorDetail"> The internal error message or exception dump. </param>
        /// <returns> A new <see cref="Models.ComputeFleetInnerError"/> instance for mocking. </returns>
        public static ComputeFleetInnerError ComputeFleetInnerError(string exceptionType = null, string errorDetail = null)
        {
            return new ComputeFleetInnerError(exceptionType, errorDetail, serializedAdditionalRawData: null);
        }
    }
}
