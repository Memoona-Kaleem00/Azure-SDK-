// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the WebSite data model. </summary>
    public partial class WebSiteData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of WebSiteData. </summary>
        /// <param name="location"> The location. </param>
        public WebSiteData(AzureLocation location) : base(location)
        {
            HostNames = new ChangeTrackingList<string>();
            EnabledHostNames = new ChangeTrackingList<string>();
            HostNameSslStates = new ChangeTrackingList<HostNameSslState>();
            TrafficManagerHostNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of WebSiteData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity">
        /// Managed service identity.
        /// Serialized Name: Site.identity
        /// </param>
        /// <param name="extendedLocation">
        /// Extended Location.
        /// Serialized Name: Site.extendedLocation
        /// </param>
        /// <param name="state">
        /// Current state of the app.
        /// Serialized Name: Site.properties.state
        /// </param>
        /// <param name="hostNames">
        /// Hostnames associated with the app.
        /// Serialized Name: Site.properties.hostNames
        /// </param>
        /// <param name="repositorySiteName">
        /// Name of the repository site.
        /// Serialized Name: Site.properties.repositorySiteName
        /// </param>
        /// <param name="usageState">
        /// State indicating whether the app has exceeded its quota usage. Read-only.
        /// Serialized Name: Site.properties.usageState
        /// </param>
        /// <param name="isEnabled">
        /// &lt;code&gt;true&lt;/code&gt; if the app is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. Setting this value to false disables the app (takes the app offline).
        /// Serialized Name: Site.properties.enabled
        /// </param>
        /// <param name="enabledHostNames">
        /// Enabled hostnames for the app.Hostnames need to be assigned (see HostNames) AND enabled. Otherwise,
        /// the app is not served on those hostnames.
        /// Serialized Name: Site.properties.enabledHostNames
        /// </param>
        /// <param name="availabilityState">
        /// Management information availability state for the app.
        /// Serialized Name: Site.properties.availabilityState
        /// </param>
        /// <param name="hostNameSslStates">
        /// Hostname SSL states are used to manage the SSL bindings for app&apos;s hostnames.
        /// Serialized Name: Site.properties.hostNameSslStates
        /// </param>
        /// <param name="serverFarmId">
        /// Resource ID of the associated App Service plan, formatted as: &quot;/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}&quot;.
        /// Serialized Name: Site.properties.serverFarmId
        /// </param>
        /// <param name="reserved">
        /// &lt;code&gt;true&lt;/code&gt; if reserved; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// Serialized Name: Site.properties.reserved
        /// </param>
        /// <param name="isXenon">
        /// Obsolete: Hyper-V sandbox.
        /// Serialized Name: Site.properties.isXenon
        /// </param>
        /// <param name="isHyperV">
        /// Hyper-V sandbox.
        /// Serialized Name: Site.properties.hyperV
        /// </param>
        /// <param name="lastModifiedTimeUtc">
        /// Last time the app was modified, in UTC. Read-only.
        /// Serialized Name: Site.properties.lastModifiedTimeUtc
        /// </param>
        /// <param name="siteConfig">
        /// Configuration of the app.
        /// Serialized Name: Site.properties.siteConfig
        /// </param>
        /// <param name="trafficManagerHostNames">
        /// Azure Traffic Manager hostnames associated with the app. Read-only.
        /// Serialized Name: Site.properties.trafficManagerHostNames
        /// </param>
        /// <param name="scmSiteAlsoStopped">
        /// &lt;code&gt;true&lt;/code&gt; to stop SCM (KUDU) site when the app is stopped; otherwise, &lt;code&gt;false&lt;/code&gt;. The default is &lt;code&gt;false&lt;/code&gt;.
        /// Serialized Name: Site.properties.scmSiteAlsoStopped
        /// </param>
        /// <param name="targetSwapSlot">
        /// Specifies which deployment slot this app will swap into. Read-only.
        /// Serialized Name: Site.properties.targetSwapSlot
        /// </param>
        /// <param name="hostingEnvironmentProfile">
        /// App Service Environment to use for the app.
        /// Serialized Name: Site.properties.hostingEnvironmentProfile
        /// </param>
        /// <param name="isClientAffinityEnabled">
        /// &lt;code&gt;true&lt;/code&gt; to enable client affinity; &lt;code&gt;false&lt;/code&gt; to stop sending session affinity cookies, which route client requests in the same session to the same instance. Default is &lt;code&gt;true&lt;/code&gt;.
        /// Serialized Name: Site.properties.clientAffinityEnabled
        /// </param>
        /// <param name="isClientCertEnabled">
        /// &lt;code&gt;true&lt;/code&gt; to enable client certificate authentication (TLS mutual authentication); otherwise, &lt;code&gt;false&lt;/code&gt;. Default is &lt;code&gt;false&lt;/code&gt;.
        /// Serialized Name: Site.properties.clientCertEnabled
        /// </param>
        /// <param name="clientCertMode">
        /// This composes with ClientCertEnabled setting.
        /// - ClientCertEnabled: false means ClientCert is ignored.
        /// - ClientCertEnabled: true and ClientCertMode: Required means ClientCert is required.
        /// - ClientCertEnabled: true and ClientCertMode: Optional means ClientCert is optional or accepted.
        /// Serialized Name: Site.properties.clientCertMode
        /// </param>
        /// <param name="clientCertExclusionPaths">
        /// client certificate authentication comma-separated exclusion paths
        /// Serialized Name: Site.properties.clientCertExclusionPaths
        /// </param>
        /// <param name="isHostNamesDisabled">
        /// &lt;code&gt;true&lt;/code&gt; to disable the public hostnames of the app; otherwise, &lt;code&gt;false&lt;/code&gt;.
        ///  If &lt;code&gt;true&lt;/code&gt;, the app is only accessible via API management process.
        /// Serialized Name: Site.properties.hostNamesDisabled
        /// </param>
        /// <param name="customDomainVerificationId">
        /// Unique identifier that verifies the custom domains assigned to the app. Customer will add this id to a txt record for verification.
        /// Serialized Name: Site.properties.customDomainVerificationId
        /// </param>
        /// <param name="outboundIPAddresses">
        /// List of IP addresses that the app uses for outbound connections (e.g. database access). Includes VIPs from tenants that site can be hosted with current settings. Read-only.
        /// Serialized Name: Site.properties.outboundIpAddresses
        /// </param>
        /// <param name="possibleOutboundIPAddresses">
        /// List of IP addresses that the app uses for outbound connections (e.g. database access). Includes VIPs from all tenants except dataComponent. Read-only.
        /// Serialized Name: Site.properties.possibleOutboundIpAddresses
        /// </param>
        /// <param name="containerSize">
        /// Size of the function container.
        /// Serialized Name: Site.properties.containerSize
        /// </param>
        /// <param name="dailyMemoryTimeQuota">
        /// Maximum allowed daily memory-time quota (applicable on dynamic apps only).
        /// Serialized Name: Site.properties.dailyMemoryTimeQuota
        /// </param>
        /// <param name="suspendedTill">
        /// App suspended till in case memory-time quota is exceeded.
        /// Serialized Name: Site.properties.suspendedTill
        /// </param>
        /// <param name="maxNumberOfWorkers">
        /// Maximum number of workers.
        /// This only applies to Functions container.
        /// Serialized Name: Site.properties.maxNumberOfWorkers
        /// </param>
        /// <param name="cloningInfo">
        /// If specified during app creation, the app is cloned from a source app.
        /// Serialized Name: Site.properties.cloningInfo
        /// </param>
        /// <param name="resourceGroup">
        /// Name of the resource group the app belongs to. Read-only.
        /// Serialized Name: Site.properties.resourceGroup
        /// </param>
        /// <param name="isDefaultContainer">
        /// &lt;code&gt;true&lt;/code&gt; if the app is a default container; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// Serialized Name: Site.properties.isDefaultContainer
        /// </param>
        /// <param name="defaultHostName">
        /// Default hostname of the app. Read-only.
        /// Serialized Name: Site.properties.defaultHostName
        /// </param>
        /// <param name="slotSwapStatus">
        /// Status of the last deployment slot swap operation.
        /// Serialized Name: Site.properties.slotSwapStatus
        /// </param>
        /// <param name="isHttpsOnly">
        /// HttpsOnly: configures a web site to accept only https requests. Issues redirect for
        /// http requests
        /// Serialized Name: Site.properties.httpsOnly
        /// </param>
        /// <param name="redundancyMode">
        /// Site redundancy mode
        /// Serialized Name: Site.properties.redundancyMode
        /// </param>
        /// <param name="inProgressOperationId">
        /// Specifies an operation id if this site has a pending operation.
        /// Serialized Name: Site.properties.inProgressOperationId
        /// </param>
        /// <param name="isStorageAccountRequired">
        /// Checks if Customer provided storage account is required
        /// Serialized Name: Site.properties.storageAccountRequired
        /// </param>
        /// <param name="keyVaultReferenceIdentity">
        /// Identity to use for Key Vault Reference authentication.
        /// Serialized Name: Site.properties.keyVaultReferenceIdentity
        /// </param>
        /// <param name="virtualNetworkSubnetId">
        /// Azure Resource Manager ID of the Virtual network and subnet to be joined by Regional VNET Integration.
        /// This must be of the form /subscriptions/{subscriptionName}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}
        /// Serialized Name: Site.properties.virtualNetworkSubnetId
        /// </param>
        /// <param name="kind">
        /// Kind of resource.
        /// Serialized Name: Resource.kind
        /// </param>
        internal WebSiteData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, ExtendedLocation extendedLocation, string state, IReadOnlyList<string> hostNames, string repositorySiteName, UsageState? usageState, bool? isEnabled, IReadOnlyList<string> enabledHostNames, SiteAvailabilityState? availabilityState, IList<HostNameSslState> hostNameSslStates, string serverFarmId, bool? reserved, bool? isXenon, bool? isHyperV, DateTimeOffset? lastModifiedTimeUtc, SiteConfigProperties siteConfig, IReadOnlyList<string> trafficManagerHostNames, bool? scmSiteAlsoStopped, string targetSwapSlot, HostingEnvironmentProfile hostingEnvironmentProfile, bool? isClientAffinityEnabled, bool? isClientCertEnabled, ClientCertMode? clientCertMode, string clientCertExclusionPaths, bool? isHostNamesDisabled, string customDomainVerificationId, string outboundIPAddresses, string possibleOutboundIPAddresses, int? containerSize, int? dailyMemoryTimeQuota, DateTimeOffset? suspendedTill, int? maxNumberOfWorkers, CloningInfo cloningInfo, string resourceGroup, bool? isDefaultContainer, string defaultHostName, SlotSwapStatus slotSwapStatus, bool? isHttpsOnly, RedundancyMode? redundancyMode, Guid? inProgressOperationId, bool? isStorageAccountRequired, string keyVaultReferenceIdentity, string virtualNetworkSubnetId, string kind) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            ExtendedLocation = extendedLocation;
            State = state;
            HostNames = hostNames;
            RepositorySiteName = repositorySiteName;
            UsageState = usageState;
            IsEnabled = isEnabled;
            EnabledHostNames = enabledHostNames;
            AvailabilityState = availabilityState;
            HostNameSslStates = hostNameSslStates;
            ServerFarmId = serverFarmId;
            Reserved = reserved;
            IsXenon = isXenon;
            IsHyperV = isHyperV;
            LastModifiedTimeUtc = lastModifiedTimeUtc;
            SiteConfig = siteConfig;
            TrafficManagerHostNames = trafficManagerHostNames;
            ScmSiteAlsoStopped = scmSiteAlsoStopped;
            TargetSwapSlot = targetSwapSlot;
            HostingEnvironmentProfile = hostingEnvironmentProfile;
            IsClientAffinityEnabled = isClientAffinityEnabled;
            IsClientCertEnabled = isClientCertEnabled;
            ClientCertMode = clientCertMode;
            ClientCertExclusionPaths = clientCertExclusionPaths;
            IsHostNamesDisabled = isHostNamesDisabled;
            CustomDomainVerificationId = customDomainVerificationId;
            OutboundIPAddresses = outboundIPAddresses;
            PossibleOutboundIPAddresses = possibleOutboundIPAddresses;
            ContainerSize = containerSize;
            DailyMemoryTimeQuota = dailyMemoryTimeQuota;
            SuspendedTill = suspendedTill;
            MaxNumberOfWorkers = maxNumberOfWorkers;
            CloningInfo = cloningInfo;
            ResourceGroup = resourceGroup;
            IsDefaultContainer = isDefaultContainer;
            DefaultHostName = defaultHostName;
            SlotSwapStatus = slotSwapStatus;
            IsHttpsOnly = isHttpsOnly;
            RedundancyMode = redundancyMode;
            InProgressOperationId = inProgressOperationId;
            IsStorageAccountRequired = isStorageAccountRequired;
            KeyVaultReferenceIdentity = keyVaultReferenceIdentity;
            VirtualNetworkSubnetId = virtualNetworkSubnetId;
            Kind = kind;
        }

        /// <summary>
        /// Managed service identity.
        /// Serialized Name: Site.identity
        /// </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary>
        /// Extended Location.
        /// Serialized Name: Site.extendedLocation
        /// </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary>
        /// Current state of the app.
        /// Serialized Name: Site.properties.state
        /// </summary>
        public string State { get; }
        /// <summary>
        /// Hostnames associated with the app.
        /// Serialized Name: Site.properties.hostNames
        /// </summary>
        public IReadOnlyList<string> HostNames { get; }
        /// <summary>
        /// Name of the repository site.
        /// Serialized Name: Site.properties.repositorySiteName
        /// </summary>
        public string RepositorySiteName { get; }
        /// <summary>
        /// State indicating whether the app has exceeded its quota usage. Read-only.
        /// Serialized Name: Site.properties.usageState
        /// </summary>
        public UsageState? UsageState { get; }
        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if the app is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. Setting this value to false disables the app (takes the app offline).
        /// Serialized Name: Site.properties.enabled
        /// </summary>
        public bool? IsEnabled { get; set; }
        /// <summary>
        /// Enabled hostnames for the app.Hostnames need to be assigned (see HostNames) AND enabled. Otherwise,
        /// the app is not served on those hostnames.
        /// Serialized Name: Site.properties.enabledHostNames
        /// </summary>
        public IReadOnlyList<string> EnabledHostNames { get; }
        /// <summary>
        /// Management information availability state for the app.
        /// Serialized Name: Site.properties.availabilityState
        /// </summary>
        public SiteAvailabilityState? AvailabilityState { get; }
        /// <summary>
        /// Hostname SSL states are used to manage the SSL bindings for app&apos;s hostnames.
        /// Serialized Name: Site.properties.hostNameSslStates
        /// </summary>
        public IList<HostNameSslState> HostNameSslStates { get; }
        /// <summary>
        /// Resource ID of the associated App Service plan, formatted as: &quot;/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}&quot;.
        /// Serialized Name: Site.properties.serverFarmId
        /// </summary>
        public string ServerFarmId { get; set; }
        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if reserved; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// Serialized Name: Site.properties.reserved
        /// </summary>
        public bool? Reserved { get; set; }
        /// <summary>
        /// Obsolete: Hyper-V sandbox.
        /// Serialized Name: Site.properties.isXenon
        /// </summary>
        public bool? IsXenon { get; set; }
        /// <summary>
        /// Hyper-V sandbox.
        /// Serialized Name: Site.properties.hyperV
        /// </summary>
        public bool? IsHyperV { get; set; }
        /// <summary>
        /// Last time the app was modified, in UTC. Read-only.
        /// Serialized Name: Site.properties.lastModifiedTimeUtc
        /// </summary>
        public DateTimeOffset? LastModifiedTimeUtc { get; }
        /// <summary>
        /// Configuration of the app.
        /// Serialized Name: Site.properties.siteConfig
        /// </summary>
        public SiteConfigProperties SiteConfig { get; set; }
        /// <summary>
        /// Azure Traffic Manager hostnames associated with the app. Read-only.
        /// Serialized Name: Site.properties.trafficManagerHostNames
        /// </summary>
        public IReadOnlyList<string> TrafficManagerHostNames { get; }
        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; to stop SCM (KUDU) site when the app is stopped; otherwise, &lt;code&gt;false&lt;/code&gt;. The default is &lt;code&gt;false&lt;/code&gt;.
        /// Serialized Name: Site.properties.scmSiteAlsoStopped
        /// </summary>
        public bool? ScmSiteAlsoStopped { get; set; }
        /// <summary>
        /// Specifies which deployment slot this app will swap into. Read-only.
        /// Serialized Name: Site.properties.targetSwapSlot
        /// </summary>
        public string TargetSwapSlot { get; }
        /// <summary>
        /// App Service Environment to use for the app.
        /// Serialized Name: Site.properties.hostingEnvironmentProfile
        /// </summary>
        public HostingEnvironmentProfile HostingEnvironmentProfile { get; set; }
        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; to enable client affinity; &lt;code&gt;false&lt;/code&gt; to stop sending session affinity cookies, which route client requests in the same session to the same instance. Default is &lt;code&gt;true&lt;/code&gt;.
        /// Serialized Name: Site.properties.clientAffinityEnabled
        /// </summary>
        public bool? IsClientAffinityEnabled { get; set; }
        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; to enable client certificate authentication (TLS mutual authentication); otherwise, &lt;code&gt;false&lt;/code&gt;. Default is &lt;code&gt;false&lt;/code&gt;.
        /// Serialized Name: Site.properties.clientCertEnabled
        /// </summary>
        public bool? IsClientCertEnabled { get; set; }
        /// <summary>
        /// This composes with ClientCertEnabled setting.
        /// - ClientCertEnabled: false means ClientCert is ignored.
        /// - ClientCertEnabled: true and ClientCertMode: Required means ClientCert is required.
        /// - ClientCertEnabled: true and ClientCertMode: Optional means ClientCert is optional or accepted.
        /// Serialized Name: Site.properties.clientCertMode
        /// </summary>
        public ClientCertMode? ClientCertMode { get; set; }
        /// <summary>
        /// client certificate authentication comma-separated exclusion paths
        /// Serialized Name: Site.properties.clientCertExclusionPaths
        /// </summary>
        public string ClientCertExclusionPaths { get; set; }
        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; to disable the public hostnames of the app; otherwise, &lt;code&gt;false&lt;/code&gt;.
        ///  If &lt;code&gt;true&lt;/code&gt;, the app is only accessible via API management process.
        /// Serialized Name: Site.properties.hostNamesDisabled
        /// </summary>
        public bool? IsHostNamesDisabled { get; set; }
        /// <summary>
        /// Unique identifier that verifies the custom domains assigned to the app. Customer will add this id to a txt record for verification.
        /// Serialized Name: Site.properties.customDomainVerificationId
        /// </summary>
        public string CustomDomainVerificationId { get; set; }
        /// <summary>
        /// List of IP addresses that the app uses for outbound connections (e.g. database access). Includes VIPs from tenants that site can be hosted with current settings. Read-only.
        /// Serialized Name: Site.properties.outboundIpAddresses
        /// </summary>
        public string OutboundIPAddresses { get; }
        /// <summary>
        /// List of IP addresses that the app uses for outbound connections (e.g. database access). Includes VIPs from all tenants except dataComponent. Read-only.
        /// Serialized Name: Site.properties.possibleOutboundIpAddresses
        /// </summary>
        public string PossibleOutboundIPAddresses { get; }
        /// <summary>
        /// Size of the function container.
        /// Serialized Name: Site.properties.containerSize
        /// </summary>
        public int? ContainerSize { get; set; }
        /// <summary>
        /// Maximum allowed daily memory-time quota (applicable on dynamic apps only).
        /// Serialized Name: Site.properties.dailyMemoryTimeQuota
        /// </summary>
        public int? DailyMemoryTimeQuota { get; set; }
        /// <summary>
        /// App suspended till in case memory-time quota is exceeded.
        /// Serialized Name: Site.properties.suspendedTill
        /// </summary>
        public DateTimeOffset? SuspendedTill { get; }
        /// <summary>
        /// Maximum number of workers.
        /// This only applies to Functions container.
        /// Serialized Name: Site.properties.maxNumberOfWorkers
        /// </summary>
        public int? MaxNumberOfWorkers { get; }
        /// <summary>
        /// If specified during app creation, the app is cloned from a source app.
        /// Serialized Name: Site.properties.cloningInfo
        /// </summary>
        public CloningInfo CloningInfo { get; set; }
        /// <summary>
        /// Name of the resource group the app belongs to. Read-only.
        /// Serialized Name: Site.properties.resourceGroup
        /// </summary>
        public string ResourceGroup { get; }
        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if the app is a default container; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// Serialized Name: Site.properties.isDefaultContainer
        /// </summary>
        public bool? IsDefaultContainer { get; }
        /// <summary>
        /// Default hostname of the app. Read-only.
        /// Serialized Name: Site.properties.defaultHostName
        /// </summary>
        public string DefaultHostName { get; }
        /// <summary>
        /// Status of the last deployment slot swap operation.
        /// Serialized Name: Site.properties.slotSwapStatus
        /// </summary>
        public SlotSwapStatus SlotSwapStatus { get; }
        /// <summary>
        /// HttpsOnly: configures a web site to accept only https requests. Issues redirect for
        /// http requests
        /// Serialized Name: Site.properties.httpsOnly
        /// </summary>
        public bool? IsHttpsOnly { get; set; }
        /// <summary>
        /// Site redundancy mode
        /// Serialized Name: Site.properties.redundancyMode
        /// </summary>
        public RedundancyMode? RedundancyMode { get; set; }
        /// <summary>
        /// Specifies an operation id if this site has a pending operation.
        /// Serialized Name: Site.properties.inProgressOperationId
        /// </summary>
        public Guid? InProgressOperationId { get; }
        /// <summary>
        /// Checks if Customer provided storage account is required
        /// Serialized Name: Site.properties.storageAccountRequired
        /// </summary>
        public bool? IsStorageAccountRequired { get; set; }
        /// <summary>
        /// Identity to use for Key Vault Reference authentication.
        /// Serialized Name: Site.properties.keyVaultReferenceIdentity
        /// </summary>
        public string KeyVaultReferenceIdentity { get; set; }
        /// <summary>
        /// Azure Resource Manager ID of the Virtual network and subnet to be joined by Regional VNET Integration.
        /// This must be of the form /subscriptions/{subscriptionName}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}
        /// Serialized Name: Site.properties.virtualNetworkSubnetId
        /// </summary>
        public string VirtualNetworkSubnetId { get; set; }
        /// <summary>
        /// Kind of resource.
        /// Serialized Name: Resource.kind
        /// </summary>
        public string Kind { get; set; }
    }
}
