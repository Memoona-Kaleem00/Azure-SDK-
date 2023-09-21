// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.RecoveryServices;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmRecoveryServicesModelFactory
    {
        /// <summary> Initializes a new instance of VaultCertificateResult. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties">
        /// Certificate details representing the Vault credentials.
        /// Please note <see cref="ResourceCertificateDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ResourceCertificateAndAcsDetails"/> and <see cref="ResourceCertificateAndAadDetails"/>.
        /// </param>
        /// <returns> A new <see cref="Models.VaultCertificateResult"/> instance for mocking. </returns>
        public static VaultCertificateResult VaultCertificateResult(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ResourceCertificateDetails properties = null)
        {
            return new VaultCertificateResult(id, name, resourceType, systemData, properties);
        }

        /// <summary> Initializes a new instance of ResourceCertificateDetails. </summary>
        /// <param name="authType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="certificate"> The base64 encoded certificate raw data string. </param>
        /// <param name="friendlyName"> Certificate friendly name. </param>
        /// <param name="issuer"> Certificate issuer. </param>
        /// <param name="resourceId"> Resource ID of the vault. </param>
        /// <param name="subject"> Certificate Subject Name. </param>
        /// <param name="thumbprint"> Certificate thumbprint. </param>
        /// <param name="validStartOn"> Certificate Validity start Date time. </param>
        /// <param name="validEndOn"> Certificate Validity End Date time. </param>
        /// <returns> A new <see cref="Models.ResourceCertificateDetails"/> instance for mocking. </returns>
        public static ResourceCertificateDetails ResourceCertificateDetails(string authType = null, byte[] certificate = null, string friendlyName = null, string issuer = null, long? resourceId = null, string subject = null, BinaryData thumbprint = null, DateTimeOffset? validStartOn = null, DateTimeOffset? validEndOn = null)
        {
            return new UnknownResourceCertificateDetails(authType, certificate, friendlyName, issuer, resourceId, subject, thumbprint, validStartOn, validEndOn);
        }

        /// <summary> Initializes a new instance of ReplicationUsage. </summary>
        /// <param name="monitoringSummary"> Summary of the replication monitoring data for this vault. </param>
        /// <param name="jobsSummary"> Summary of the replication jobs data for this vault. </param>
        /// <param name="protectedItemCount"> Number of replication protected items for this vault. </param>
        /// <param name="recoveryPlanCount"> Number of replication recovery plans for this vault. </param>
        /// <param name="registeredServersCount"> Number of servers registered to this vault. </param>
        /// <param name="recoveryServicesProviderAuthType"> The authentication type of recovery service providers in the vault. </param>
        /// <returns> A new <see cref="Models.ReplicationUsage"/> instance for mocking. </returns>
        public static ReplicationUsage ReplicationUsage(VaultMonitoringSummary monitoringSummary = null, ReplicationJobSummary jobsSummary = null, int? protectedItemCount = null, int? recoveryPlanCount = null, int? registeredServersCount = null, int? recoveryServicesProviderAuthType = null)
        {
            return new ReplicationUsage(monitoringSummary, jobsSummary, protectedItemCount, recoveryPlanCount, registeredServersCount, recoveryServicesProviderAuthType);
        }

        /// <summary> Initializes a new instance of VaultMonitoringSummary. </summary>
        /// <param name="unHealthyVmCount"> Count of unhealthy VMs. </param>
        /// <param name="unHealthyProviderCount"> Count of unhealthy replication providers. </param>
        /// <param name="eventsCount"> Count of all critical warnings. </param>
        /// <param name="deprecatedProviderCount"> Count of all deprecated recovery service providers. </param>
        /// <param name="supportedProviderCount"> Count of all the supported recovery service providers. </param>
        /// <param name="unsupportedProviderCount"> Count of all the unsupported recovery service providers. </param>
        /// <returns> A new <see cref="Models.VaultMonitoringSummary"/> instance for mocking. </returns>
        public static VaultMonitoringSummary VaultMonitoringSummary(int? unHealthyVmCount = null, int? unHealthyProviderCount = null, int? eventsCount = null, int? deprecatedProviderCount = null, int? supportedProviderCount = null, int? unsupportedProviderCount = null)
        {
            return new VaultMonitoringSummary(unHealthyVmCount, unHealthyProviderCount, eventsCount, deprecatedProviderCount, supportedProviderCount, unsupportedProviderCount);
        }

        /// <summary> Initializes a new instance of ReplicationJobSummary. </summary>
        /// <param name="failedJobs"> Count of failed jobs. </param>
        /// <param name="suspendedJobs"> Count of suspended jobs. </param>
        /// <param name="inProgressJobs"> Count of in-progress jobs. </param>
        /// <returns> A new <see cref="Models.ReplicationJobSummary"/> instance for mocking. </returns>
        public static ReplicationJobSummary ReplicationJobSummary(int? failedJobs = null, int? suspendedJobs = null, int? inProgressJobs = null)
        {
            return new ReplicationJobSummary(failedJobs, suspendedJobs, inProgressJobs);
        }

        /// <summary> Initializes a new instance of RecoveryServicesPrivateLinkResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="groupId"> e.g. f9ad6492-33d4-4690-9999-6bfd52a0d081 (Backup) or f9ad6492-33d4-4690-9999-6bfd52a0d082 (SiteRecovery). </param>
        /// <param name="requiredMembers"> [backup-ecs1, backup-prot1, backup-prot1b, backup-prot1c, backup-id1]. </param>
        /// <param name="requiredZoneNames"> The private link resource Private link DNS zone name. </param>
        /// <returns> A new <see cref="RecoveryServices.RecoveryServicesPrivateLinkResourceData"/> instance for mocking. </returns>
        public static RecoveryServicesPrivateLinkResourceData RecoveryServicesPrivateLinkResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string groupId = null, IEnumerable<string> requiredMembers = null, IEnumerable<string> requiredZoneNames = null)
        {
            requiredMembers ??= new List<string>();
            requiredZoneNames ??= new List<string>();

            return new RecoveryServicesPrivateLinkResourceData(id, name, resourceType, systemData, groupId, requiredMembers?.ToList(), requiredZoneNames?.ToList());
        }

        /// <summary> Initializes a new instance of RecoveryServicesNameAvailabilityResult. </summary>
        /// <param name="isNameAvailable"></param>
        /// <param name="reason"></param>
        /// <param name="message"></param>
        /// <returns> A new <see cref="Models.RecoveryServicesNameAvailabilityResult"/> instance for mocking. </returns>
        public static RecoveryServicesNameAvailabilityResult RecoveryServicesNameAvailabilityResult(bool? isNameAvailable = null, string reason = null, string message = null)
        {
            return new RecoveryServicesNameAvailabilityResult(isNameAvailable, reason, message);
        }

        /// <summary> Initializes a new instance of RecoveryServicesVaultData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Identity for the resource. </param>
        /// <param name="properties"> Properties of the vault. </param>
        /// <param name="sku"> Identifies the unique system identifier for each Azure resource. </param>
        /// <param name="etag"> Optional ETag. </param>
        /// <returns> A new <see cref="RecoveryServices.RecoveryServicesVaultData"/> instance for mocking. </returns>
        public static RecoveryServicesVaultData RecoveryServicesVaultData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ManagedServiceIdentity identity = null, RecoveryServicesVaultProperties properties = null, RecoveryServicesSku sku = null, ETag? etag = null)
        {
            tags ??= new Dictionary<string, string>();

            return new RecoveryServicesVaultData(id, name, resourceType, systemData, tags, location, identity, properties, sku, etag);
        }

        /// <summary> Initializes a new instance of RecoveryServicesVaultProperties. </summary>
        /// <param name="provisioningState"> Provisioning State. </param>
        /// <param name="upgradeDetails"> Details for upgrading vault. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connection. </param>
        /// <param name="privateEndpointStateForBackup"> Private endpoint state for backup. </param>
        /// <param name="privateEndpointStateForSiteRecovery"> Private endpoint state for site recovery. </param>
        /// <param name="encryption"> Customer Managed Key details of the resource. </param>
        /// <param name="moveDetails"> The details of the latest move operation performed on the Azure Resource. </param>
        /// <param name="moveState"> The State of the Resource after the move operation. </param>
        /// <param name="backupStorageVersion"> Backup storage version. </param>
        /// <param name="publicNetworkAccess"> property to enable or disable resource provider inbound network traffic from public clients. </param>
        /// <param name="monitoringSettings"> Monitoring Settings of the vault. </param>
        /// <param name="crossSubscriptionRestoreState"> Restore Settings of the vault. </param>
        /// <param name="redundancySettings"> The redundancy Settings of a Vault. </param>
        /// <param name="securitySettings"> Security Settings of the vault. </param>
        /// <param name="secureScore"> Secure Score of Recovery Services Vault. </param>
        /// <returns> A new <see cref="Models.RecoveryServicesVaultProperties"/> instance for mocking. </returns>
        public static RecoveryServicesVaultProperties RecoveryServicesVaultProperties(string provisioningState = null, VaultUpgradeDetails upgradeDetails = null, IEnumerable<RecoveryServicesPrivateEndpointConnectionVaultProperties> privateEndpointConnections = null, VaultPrivateEndpointState? privateEndpointStateForBackup = null, VaultPrivateEndpointState? privateEndpointStateForSiteRecovery = null, VaultPropertiesEncryption encryption = null, VaultPropertiesMoveDetails moveDetails = null, ResourceMoveState? moveState = null, BackupStorageVersion? backupStorageVersion = null, VaultPublicNetworkAccess? publicNetworkAccess = null, VaultMonitoringSettings monitoringSettings = null, CrossSubscriptionRestoreState? crossSubscriptionRestoreState = null, VaultPropertiesRedundancySettings redundancySettings = null, RecoveryServicesSecuritySettings securitySettings = null, SecureScoreLevel? secureScore = null)
        {
            privateEndpointConnections ??= new List<RecoveryServicesPrivateEndpointConnectionVaultProperties>();

            return new RecoveryServicesVaultProperties(provisioningState, upgradeDetails, privateEndpointConnections?.ToList(), privateEndpointStateForBackup, privateEndpointStateForSiteRecovery, encryption, moveDetails, moveState, backupStorageVersion, publicNetworkAccess, monitoringSettings, crossSubscriptionRestoreState != null ? new RestoreSettings(new CrossSubscriptionRestoreSettings(crossSubscriptionRestoreState)) : null, redundancySettings, securitySettings, secureScore);
        }

        /// <summary> Initializes a new instance of VaultUpgradeDetails. </summary>
        /// <param name="operationId"> ID of the vault upgrade operation. </param>
        /// <param name="startOn"> UTC time at which the upgrade operation has started. </param>
        /// <param name="lastUpdatedOn"> UTC time at which the upgrade operation status was last updated. </param>
        /// <param name="endOn"> UTC time at which the upgrade operation has ended. </param>
        /// <param name="status"> Status of the vault upgrade operation. </param>
        /// <param name="message"> Message to the user containing information about the upgrade operation. </param>
        /// <param name="triggerType"> The way the vault upgrade was triggered. </param>
        /// <param name="upgradedResourceId"> Resource ID of the upgraded vault. </param>
        /// <param name="previousResourceId"> Resource ID of the vault before the upgrade. </param>
        /// <returns> A new <see cref="Models.VaultUpgradeDetails"/> instance for mocking. </returns>
        public static VaultUpgradeDetails VaultUpgradeDetails(string operationId = null, DateTimeOffset? startOn = null, DateTimeOffset? lastUpdatedOn = null, DateTimeOffset? endOn = null, VaultUpgradeState? status = null, string message = null, VaultUpgradeTriggerType? triggerType = null, ResourceIdentifier upgradedResourceId = null, ResourceIdentifier previousResourceId = null)
        {
            return new VaultUpgradeDetails(operationId, startOn, lastUpdatedOn, endOn, status, message, triggerType, upgradedResourceId, previousResourceId);
        }

        /// <summary> Initializes a new instance of RecoveryServicesPrivateEndpointConnectionVaultProperties. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Private Endpoint Connection Response Properties. </param>
        /// <param name="location"> The location of the private Endpoint connection. </param>
        /// <returns> A new <see cref="Models.RecoveryServicesPrivateEndpointConnectionVaultProperties"/> instance for mocking. </returns>
        public static RecoveryServicesPrivateEndpointConnectionVaultProperties RecoveryServicesPrivateEndpointConnectionVaultProperties(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, RecoveryServicesPrivateEndpointConnection properties = null, AzureLocation? location = null)
        {
            return new RecoveryServicesPrivateEndpointConnectionVaultProperties(id, name, resourceType, systemData, properties, location);
        }

        /// <summary> Initializes a new instance of RecoveryServicesPrivateEndpointConnection. </summary>
        /// <param name="provisioningState"> Gets or sets provisioning state of the private endpoint connection. </param>
        /// <param name="privateEndpointId"> The Private Endpoint network resource that is linked to the Private Endpoint connection. </param>
        /// <param name="privateLinkServiceConnectionState"> Gets or sets private link service connection state. </param>
        /// <param name="groupIds"> Group Ids for the Private Endpoint. </param>
        /// <returns> A new <see cref="Models.RecoveryServicesPrivateEndpointConnection"/> instance for mocking. </returns>
        public static RecoveryServicesPrivateEndpointConnection RecoveryServicesPrivateEndpointConnection(RecoveryServicesPrivateEndpointConnectionProvisioningState? provisioningState = null, ResourceIdentifier privateEndpointId = null, RecoveryServicesPrivateLinkServiceConnectionState privateLinkServiceConnectionState = null, IEnumerable<VaultSubResourceType> groupIds = null)
        {
            groupIds ??= new List<VaultSubResourceType>();

            return new RecoveryServicesPrivateEndpointConnection(provisioningState, privateEndpointId != null ? ResourceManagerModelFactory.SubResource(privateEndpointId) : null, privateLinkServiceConnectionState, groupIds?.ToList());
        }

        /// <summary> Initializes a new instance of RecoveryServicesPrivateLinkServiceConnectionState. </summary>
        /// <param name="status"> Gets or sets the status. </param>
        /// <param name="description"> Gets or sets description. </param>
        /// <param name="actionsRequired"> Gets or sets actions required. </param>
        /// <returns> A new <see cref="Models.RecoveryServicesPrivateLinkServiceConnectionState"/> instance for mocking. </returns>
        public static RecoveryServicesPrivateLinkServiceConnectionState RecoveryServicesPrivateLinkServiceConnectionState(RecoveryServicesPrivateEndpointConnectionStatus? status = null, string description = null, string actionsRequired = null)
        {
            return new RecoveryServicesPrivateLinkServiceConnectionState(status, description, actionsRequired);
        }

        /// <summary> Initializes a new instance of VaultPropertiesMoveDetails. </summary>
        /// <param name="operationId"> OperationId of the Resource Move Operation. </param>
        /// <param name="startOn"> Start Time of the Resource Move Operation. </param>
        /// <param name="completedOn"> End Time of the Resource Move Operation. </param>
        /// <param name="sourceResourceId"> Source Resource of the Resource Move Operation. </param>
        /// <param name="targetResourceId"> Target Resource of the Resource Move Operation. </param>
        /// <returns> A new <see cref="Models.VaultPropertiesMoveDetails"/> instance for mocking. </returns>
        public static VaultPropertiesMoveDetails VaultPropertiesMoveDetails(string operationId = null, DateTimeOffset? startOn = null, DateTimeOffset? completedOn = null, ResourceIdentifier sourceResourceId = null, ResourceIdentifier targetResourceId = null)
        {
            return new VaultPropertiesMoveDetails(operationId, startOn, completedOn, sourceResourceId, targetResourceId);
        }

        /// <summary> Initializes a new instance of VaultPropertiesRedundancySettings. </summary>
        /// <param name="standardTierStorageRedundancy"> The storage redundancy setting of a vault. </param>
        /// <param name="crossRegionRestore"> Flag to show if Cross Region Restore is enabled on the Vault or not. </param>
        /// <returns> A new <see cref="Models.VaultPropertiesRedundancySettings"/> instance for mocking. </returns>
        public static VaultPropertiesRedundancySettings VaultPropertiesRedundancySettings(StandardTierStorageRedundancy? standardTierStorageRedundancy = null, CrossRegionRestore? crossRegionRestore = null)
        {
            return new VaultPropertiesRedundancySettings(standardTierStorageRedundancy, crossRegionRestore);
        }

        /// <summary> Initializes a new instance of RecoveryServicesSecuritySettings. </summary>
        /// <param name="immutabilityState"> Immutability Settings of a vault. </param>
        /// <param name="softDeleteSettings"> Soft delete Settings of a vault. </param>
        /// <param name="multiUserAuthorization"> MUA Settings of a vault. </param>
        /// <returns> A new <see cref="Models.RecoveryServicesSecuritySettings"/> instance for mocking. </returns>
        public static RecoveryServicesSecuritySettings RecoveryServicesSecuritySettings(ImmutabilityState? immutabilityState = null, RecoveryServicesSoftDeleteSettings softDeleteSettings = null, MultiUserAuthorization? multiUserAuthorization = null)
        {
            return new RecoveryServicesSecuritySettings(immutabilityState != null ? new ImmutabilitySettings(immutabilityState) : null, softDeleteSettings, multiUserAuthorization);
        }

        /// <summary> Initializes a new instance of RecoveryServicesVaultPatch. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> Properties of the vault. </param>
        /// <param name="sku"> Identifies the unique system identifier for each Azure resource. </param>
        /// <param name="identity"> Identity for the resource. </param>
        /// <param name="etag"> Optional ETag. </param>
        /// <returns> A new <see cref="Models.RecoveryServicesVaultPatch"/> instance for mocking. </returns>
        public static RecoveryServicesVaultPatch RecoveryServicesVaultPatch(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, RecoveryServicesVaultProperties properties = null, RecoveryServicesSku sku = null, ManagedServiceIdentity identity = null, ETag? etag = null)
        {
            tags ??= new Dictionary<string, string>();

            return new RecoveryServicesVaultPatch(id, name, resourceType, systemData, tags, location, properties, sku, identity, etag);
        }

        /// <summary> Initializes a new instance of RecoveryServicesVaultExtendedInfoData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="integrityKey"> Integrity key. </param>
        /// <param name="encryptionKey"> Encryption key. </param>
        /// <param name="encryptionKeyThumbprint"> Encryption key thumbprint. </param>
        /// <param name="algorithm"> Algorithm for Vault ExtendedInfo. </param>
        /// <param name="etag"> Optional ETag. </param>
        /// <returns> A new <see cref="RecoveryServices.RecoveryServicesVaultExtendedInfoData"/> instance for mocking. </returns>
        public static RecoveryServicesVaultExtendedInfoData RecoveryServicesVaultExtendedInfoData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string integrityKey = null, string encryptionKey = null, string encryptionKeyThumbprint = null, string algorithm = null, ETag? etag = null)
        {
            return new RecoveryServicesVaultExtendedInfoData(id, name, resourceType, systemData, integrityKey, encryptionKey, encryptionKeyThumbprint, algorithm, etag);
        }

        /// <summary> Initializes a new instance of VaultUsage. </summary>
        /// <param name="unit"> Unit of the usage. </param>
        /// <param name="quotaPeriod"> Quota period of usage. </param>
        /// <param name="nextResetOn"> Next reset time of usage. </param>
        /// <param name="currentValue"> Current value of usage. </param>
        /// <param name="limit"> Limit of usage. </param>
        /// <param name="name"> Name of usage. </param>
        /// <returns> A new <see cref="Models.VaultUsage"/> instance for mocking. </returns>
        public static VaultUsage VaultUsage(VaultUsageUnit? unit = null, string quotaPeriod = null, DateTimeOffset? nextResetOn = null, long? currentValue = null, long? limit = null, VaultUsageNameInfo name = null)
        {
            return new VaultUsage(unit, quotaPeriod, nextResetOn, currentValue, limit, name);
        }

        /// <summary> Initializes a new instance of VaultUsageNameInfo. </summary>
        /// <param name="value"> Value of usage. </param>
        /// <param name="localizedValue"> Localized value of usage. </param>
        /// <returns> A new <see cref="Models.VaultUsageNameInfo"/> instance for mocking. </returns>
        public static VaultUsageNameInfo VaultUsageNameInfo(string value = null, string localizedValue = null)
        {
            return new VaultUsageNameInfo(value, localizedValue);
        }

        /// <summary> Initializes a new instance of ResourceCertificateAndAadDetails. </summary>
        /// <param name="certificate"> The base64 encoded certificate raw data string. </param>
        /// <param name="friendlyName"> Certificate friendly name. </param>
        /// <param name="issuer"> Certificate issuer. </param>
        /// <param name="resourceId"> Resource ID of the vault. </param>
        /// <param name="subject"> Certificate Subject Name. </param>
        /// <param name="thumbprint"> Certificate thumbprint. </param>
        /// <param name="validStartOn"> Certificate Validity start Date time. </param>
        /// <param name="validEndOn"> Certificate Validity End Date time. </param>
        /// <param name="aadAuthority"> AAD tenant authority. </param>
        /// <param name="aadTenantId"> AAD tenant Id. </param>
        /// <param name="servicePrincipalClientId"> AAD service principal clientId. </param>
        /// <param name="servicePrincipalObjectId"> AAD service principal ObjectId. </param>
        /// <param name="azureManagementEndpointAudience"> Azure Management Endpoint Audience. </param>
        /// <param name="serviceResourceId"> Service Resource Id. </param>
        /// <param name="aadAudience"> AAD audience for the resource. </param>
        /// <returns> A new <see cref="Models.ResourceCertificateAndAadDetails"/> instance for mocking. </returns>
        public static ResourceCertificateAndAadDetails ResourceCertificateAndAadDetails(byte[] certificate = null, string friendlyName = null, string issuer = null, long? resourceId = null, string subject = null, BinaryData thumbprint = null, DateTimeOffset? validStartOn = null, DateTimeOffset? validEndOn = null, string aadAuthority = null, Guid aadTenantId = default, string servicePrincipalClientId = null, string servicePrincipalObjectId = null, string azureManagementEndpointAudience = null, ResourceIdentifier serviceResourceId = null, string aadAudience = null)
        {
            return new ResourceCertificateAndAadDetails("AzureActiveDirectory", certificate, friendlyName, issuer, resourceId, subject, thumbprint, validStartOn, validEndOn, aadAuthority, aadTenantId, servicePrincipalClientId, servicePrincipalObjectId, azureManagementEndpointAudience, serviceResourceId, aadAudience);
        }

        /// <summary> Initializes a new instance of ResourceCertificateAndAcsDetails. </summary>
        /// <param name="certificate"> The base64 encoded certificate raw data string. </param>
        /// <param name="friendlyName"> Certificate friendly name. </param>
        /// <param name="issuer"> Certificate issuer. </param>
        /// <param name="resourceId"> Resource ID of the vault. </param>
        /// <param name="subject"> Certificate Subject Name. </param>
        /// <param name="thumbprint"> Certificate thumbprint. </param>
        /// <param name="validStartOn"> Certificate Validity start Date time. </param>
        /// <param name="validEndOn"> Certificate Validity End Date time. </param>
        /// <param name="globalAcsNamespace"> ACS namespace name - tenant for our service. </param>
        /// <param name="globalAcsHostName"> Acs mgmt host name to connect to. </param>
        /// <param name="globalAcsRPRealm"> Global ACS namespace RP realm. </param>
        /// <returns> A new <see cref="Models.ResourceCertificateAndAcsDetails"/> instance for mocking. </returns>
        public static ResourceCertificateAndAcsDetails ResourceCertificateAndAcsDetails(byte[] certificate = null, string friendlyName = null, string issuer = null, long? resourceId = null, string subject = null, BinaryData thumbprint = null, DateTimeOffset? validStartOn = null, DateTimeOffset? validEndOn = null, string globalAcsNamespace = null, string globalAcsHostName = null, string globalAcsRPRealm = null)
        {
            return new ResourceCertificateAndAcsDetails("AccessControlService", certificate, friendlyName, issuer, resourceId, subject, thumbprint, validStartOn, validEndOn, globalAcsNamespace, globalAcsHostName, globalAcsRPRealm);
        }
    }
}
