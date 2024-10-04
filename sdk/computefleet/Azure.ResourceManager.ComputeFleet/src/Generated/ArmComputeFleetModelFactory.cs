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
        /// <param name="properties"></param>
        /// <param name="zones"></param>
        /// <param name="identity"></param>
        /// <param name="plan"> Gets or sets the plan. </param>
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
        /// <param name="provisioningState"></param>
        /// <param name="spotPriorityProfile"></param>
        /// <param name="regularPriorityProfile"></param>
        /// <param name="vmSizesProfile"></param>
        /// <param name="computeProfile"></param>
        /// <param name="createdOn"></param>
        /// <param name="uniqueId"></param>
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
        /// <param name="osProfile"></param>
        /// <param name="storageProfile"></param>
        /// <param name="networkProfile"></param>
        /// <param name="securityProfile"></param>
        /// <param name="bootDiagnostics"></param>
        /// <param name="extensionProfile"></param>
        /// <param name="licenseType"></param>
        /// <param name="scheduledEventsProfile"></param>
        /// <param name="userData"></param>
        /// <param name="capacityReservationGroupId"></param>
        /// <param name="galleryApplications"></param>
        /// <param name="hardwareVmSizeProperties"></param>
        /// <param name="serviceArtifactReferenceId"> Gets or sets the service artifact reference. </param>
        /// <param name="securityPostureReference"></param>
        /// <param name="createdOn"></param>
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
        /// <param name="id"></param>
        /// <param name="publisher"></param>
        /// <param name="offer"></param>
        /// <param name="sku"></param>
        /// <param name="version"></param>
        /// <param name="exactVersion"></param>
        /// <param name="sharedGalleryImageId"></param>
        /// <param name="communityGalleryImageId"></param>
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
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="extensionType"></param>
        /// <param name="properties"></param>
        /// <returns> A new <see cref="Models.ComputeFleetVmssExtension"/> instance for mocking. </returns>
        public static ComputeFleetVmssExtension ComputeFleetVmssExtension(ResourceIdentifier id = null, string name = null, string extensionType = null, ComputeFleetVmssExtensionProperties properties = null)
        {
            return new ComputeFleetVmssExtension(id, name, extensionType, properties, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ComputeFleetVmssExtensionProperties"/>. </summary>
        /// <param name="forceUpdateTag"></param>
        /// <param name="publisher"></param>
        /// <param name="extensionType"></param>
        /// <param name="typeHandlerVersion"></param>
        /// <param name="shouldAutoUpgradeMinorVersion"></param>
        /// <param name="isAutomaticUpgradeEnabled"></param>
        /// <param name="settings"></param>
        /// <param name="protectedSettings"></param>
        /// <param name="provisioningState"></param>
        /// <param name="provisionAfterExtensions"></param>
        /// <param name="isSuppressFailuresEnabled"></param>
        /// <param name="protectedSettingsFromKeyVault"></param>
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
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="operationStatus"></param>
        /// <param name="error"></param>
        /// <returns> A new <see cref="Models.ComputeFleetVmss"/> instance for mocking. </returns>
        public static ComputeFleetVmss ComputeFleetVmss(string id = null, string type = null, ComputeFleetProvisioningState operationStatus = default, ComputeFleetApiError error = null)
        {
            return new ComputeFleetVmss(id, type, operationStatus, error, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ComputeFleetApiError"/>. </summary>
        /// <param name="code"></param>
        /// <param name="target"></param>
        /// <param name="message"></param>
        /// <param name="details"></param>
        /// <param name="innererror"></param>
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
        /// <param name="code"></param>
        /// <param name="target"></param>
        /// <param name="message"></param>
        /// <returns> A new <see cref="Models.ComputeFleetApiErrorInfo"/> instance for mocking. </returns>
        public static ComputeFleetApiErrorInfo ComputeFleetApiErrorInfo(string code = null, string target = null, string message = null)
        {
            return new ComputeFleetApiErrorInfo(code, target, message, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ComputeFleetInnerError"/>. </summary>
        /// <param name="exceptionType"></param>
        /// <param name="errorDetail"></param>
        /// <returns> A new <see cref="Models.ComputeFleetInnerError"/> instance for mocking. </returns>
        public static ComputeFleetInnerError ComputeFleetInnerError(string exceptionType = null, string errorDetail = null)
        {
            return new ComputeFleetInnerError(exceptionType, errorDetail, serializedAdditionalRawData: null);
        }
    }
}
