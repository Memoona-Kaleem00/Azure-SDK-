// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the SiteConfig data model. </summary>
    public partial class SiteConfigData : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of SiteConfigData. </summary>
        public SiteConfigData()
        {
            DefaultDocuments = new ChangeTrackingList<string>();
            AppSettings = new ChangeTrackingList<NameValuePair>();
            ConnectionStrings = new ChangeTrackingList<ConnStringInfo>();
            HandlerMappings = new ChangeTrackingList<HandlerMapping>();
            VirtualApplications = new ChangeTrackingList<VirtualApplication>();
            IPSecurityRestrictions = new ChangeTrackingList<IPSecurityRestriction>();
            ScmIPSecurityRestrictions = new ChangeTrackingList<IPSecurityRestriction>();
            AzureStorageAccounts = new ChangeTrackingDictionary<string, AzureStorageInfoValue>();
        }

        /// <summary> Initializes a new instance of SiteConfigData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="numberOfWorkers"> Number of workers. </param>
        /// <param name="defaultDocuments"> Default documents. </param>
        /// <param name="netFrameworkVersion"> .NET Framework version. </param>
        /// <param name="phpVersion"> Version of PHP. </param>
        /// <param name="pythonVersion"> Version of Python. </param>
        /// <param name="nodeVersion"> Version of Node.js. </param>
        /// <param name="powerShellVersion"> Version of PowerShell. </param>
        /// <param name="linuxFxVersion"> Linux App Framework and version. </param>
        /// <param name="windowsFxVersion"> Xenon App Framework and version. </param>
        /// <param name="requestTracingEnabled"> &lt;code&gt;true&lt;/code&gt; if request tracing is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="requestTracingExpirationOn"> Request tracing expiration time. </param>
        /// <param name="remoteDebuggingEnabled"> &lt;code&gt;true&lt;/code&gt; if remote debugging is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="remoteDebuggingVersion"> Remote debugging version. </param>
        /// <param name="httpLoggingEnabled"> &lt;code&gt;true&lt;/code&gt; if HTTP logging is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="acrUseManagedIdentityCreds"> Flag to use Managed Identity Creds for ACR pull. </param>
        /// <param name="acrUserManagedIdentityId"> If using user managed identity, the user managed identity ClientId. </param>
        /// <param name="logsDirectorySizeLimit"> HTTP logs directory size limit. </param>
        /// <param name="detailedErrorLoggingEnabled"> &lt;code&gt;true&lt;/code&gt; if detailed error logging is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="publishingUsername"> Publishing user name. </param>
        /// <param name="appSettings"> Application settings. </param>
        /// <param name="connectionStrings"> Connection strings. </param>
        /// <param name="machineKey"> Site MachineKey. </param>
        /// <param name="handlerMappings"> Handler mappings. </param>
        /// <param name="documentRoot"> Document root. </param>
        /// <param name="scmType"> SCM type. </param>
        /// <param name="use32BitWorkerProcess"> &lt;code&gt;true&lt;/code&gt; to use 32-bit worker process; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="webSocketsEnabled"> &lt;code&gt;true&lt;/code&gt; if WebSocket is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="alwaysOn"> &lt;code&gt;true&lt;/code&gt; if Always On is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="javaVersion"> Java version. </param>
        /// <param name="javaContainer"> Java container. </param>
        /// <param name="javaContainerVersion"> Java container version. </param>
        /// <param name="appCommandLine"> App command line to launch. </param>
        /// <param name="managedPipelineMode"> Managed pipeline mode. </param>
        /// <param name="virtualApplications"> Virtual applications. </param>
        /// <param name="loadBalancing"> Site load balancing. </param>
        /// <param name="experiments"> This is work around for polymorphic types. </param>
        /// <param name="limits"> Site limits. </param>
        /// <param name="autoHealEnabled"> &lt;code&gt;true&lt;/code&gt; if Auto Heal is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="autoHealRules"> Auto Heal rules. </param>
        /// <param name="tracingOptions"> Tracing options. </param>
        /// <param name="vnetName"> Virtual Network name. </param>
        /// <param name="vnetRouteAllEnabled"> Virtual Network Route All enabled. This causes all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied. </param>
        /// <param name="vnetPrivatePortsCount"> The number of private ports assigned to this app. These will be assigned dynamically on runtime. </param>
        /// <param name="cors"> Cross-Origin Resource Sharing (CORS) settings. </param>
        /// <param name="push"> Push endpoint settings. </param>
        /// <param name="apiDefinition"> Information about the formal API definition for the app. </param>
        /// <param name="apiManagementConfig"> Azure API management settings linked to the app. </param>
        /// <param name="autoSwapSlotName"> Auto-swap slot name. </param>
        /// <param name="localMySqlEnabled"> &lt;code&gt;true&lt;/code&gt; to enable local MySQL; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="managedServiceIdentityId"> Managed Service Identity Id. </param>
        /// <param name="xManagedServiceIdentityId"> Explicit Managed Service Identity Id. </param>
        /// <param name="keyVaultReferenceIdentity"> Identity to use for Key Vault Reference authentication. </param>
        /// <param name="ipSecurityRestrictions"> IP security restrictions for main. </param>
        /// <param name="scmIPSecurityRestrictions"> IP security restrictions for scm. </param>
        /// <param name="scmIPSecurityRestrictionsUseMain"> IP security restrictions for scm to use main. </param>
        /// <param name="http20Enabled"> Http20Enabled: configures a web site to allow clients to connect over http2.0. </param>
        /// <param name="minTlsVersion"> MinTlsVersion: configures the minimum version of TLS required for SSL requests. </param>
        /// <param name="scmMinTlsVersion"> ScmMinTlsVersion: configures the minimum version of TLS required for SSL requests for SCM site. </param>
        /// <param name="ftpsState"> State of FTP / FTPS service. </param>
        /// <param name="preWarmedInstanceCount">
        /// Number of preWarmed instances.
        /// This setting only applies to the Consumption and Elastic Plans
        /// </param>
        /// <param name="functionAppScaleLimit">
        /// Maximum number of workers that a site can scale out to.
        /// This setting only applies to the Consumption and Elastic Premium Plans
        /// </param>
        /// <param name="healthCheckPath"> Health check path. </param>
        /// <param name="functionsRuntimeScaleMonitoringEnabled">
        /// Gets or sets a value indicating whether functions runtime scale monitoring is enabled. When enabled,
        /// the ScaleController will not monitor event sources directly, but will instead call to the
        /// runtime to get scale status.
        /// </param>
        /// <param name="websiteTimeZone"> Sets the time zone a site uses for generating timestamps. Compatible with Linux and Windows App Service. Setting the WEBSITE_TIME_ZONE app setting takes precedence over this config. For Linux, expects tz database values https://www.iana.org/time-zones (for a quick reference see https://en.wikipedia.org/wiki/List_of_tz_database_time_zones). For Windows, expects one of the time zones listed under HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Time Zones. </param>
        /// <param name="minimumElasticInstanceCount">
        /// Number of minimum instance count for a site
        /// This setting only applies to the Elastic Plans
        /// </param>
        /// <param name="azureStorageAccounts"> List of Azure Storage Accounts. </param>
        /// <param name="publicNetworkAccess"> Property to allow or block all public traffic. </param>
        internal SiteConfigData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, int? numberOfWorkers, IList<string> defaultDocuments, string netFrameworkVersion, string phpVersion, string pythonVersion, string nodeVersion, string powerShellVersion, string linuxFxVersion, string windowsFxVersion, bool? requestTracingEnabled, DateTimeOffset? requestTracingExpirationOn, bool? remoteDebuggingEnabled, string remoteDebuggingVersion, bool? httpLoggingEnabled, bool? acrUseManagedIdentityCreds, string acrUserManagedIdentityId, int? logsDirectorySizeLimit, bool? detailedErrorLoggingEnabled, string publishingUsername, IList<NameValuePair> appSettings, IList<ConnStringInfo> connectionStrings, SiteMachineKey machineKey, IList<HandlerMapping> handlerMappings, string documentRoot, ScmType? scmType, bool? use32BitWorkerProcess, bool? webSocketsEnabled, bool? alwaysOn, string javaVersion, string javaContainer, string javaContainerVersion, string appCommandLine, ManagedPipelineMode? managedPipelineMode, IList<VirtualApplication> virtualApplications, SiteLoadBalancing? loadBalancing, Experiments experiments, SiteLimits limits, bool? autoHealEnabled, AutoHealRules autoHealRules, string tracingOptions, string vnetName, bool? vnetRouteAllEnabled, int? vnetPrivatePortsCount, CorsSettings cors, PushSettings push, ApiDefinitionInfo apiDefinition, ApiManagementConfig apiManagementConfig, string autoSwapSlotName, bool? localMySqlEnabled, int? managedServiceIdentityId, int? xManagedServiceIdentityId, string keyVaultReferenceIdentity, IList<IPSecurityRestriction> ipSecurityRestrictions, IList<IPSecurityRestriction> scmIPSecurityRestrictions, bool? scmIPSecurityRestrictionsUseMain, bool? http20Enabled, SupportedTlsVersion? minTlsVersion, SupportedTlsVersion? scmMinTlsVersion, FtpsState? ftpsState, int? preWarmedInstanceCount, int? functionAppScaleLimit, string healthCheckPath, bool? functionsRuntimeScaleMonitoringEnabled, string websiteTimeZone, int? minimumElasticInstanceCount, IDictionary<string, AzureStorageInfoValue> azureStorageAccounts, string publicNetworkAccess) : base(id, name, resourceType, systemData, kind)
        {
            NumberOfWorkers = numberOfWorkers;
            DefaultDocuments = defaultDocuments;
            NetFrameworkVersion = netFrameworkVersion;
            PhpVersion = phpVersion;
            PythonVersion = pythonVersion;
            NodeVersion = nodeVersion;
            PowerShellVersion = powerShellVersion;
            LinuxFxVersion = linuxFxVersion;
            WindowsFxVersion = windowsFxVersion;
            RequestTracingEnabled = requestTracingEnabled;
            RequestTracingExpirationOn = requestTracingExpirationOn;
            RemoteDebuggingEnabled = remoteDebuggingEnabled;
            RemoteDebuggingVersion = remoteDebuggingVersion;
            HttpLoggingEnabled = httpLoggingEnabled;
            AcrUseManagedIdentityCreds = acrUseManagedIdentityCreds;
            AcrUserManagedIdentityId = acrUserManagedIdentityId;
            LogsDirectorySizeLimit = logsDirectorySizeLimit;
            DetailedErrorLoggingEnabled = detailedErrorLoggingEnabled;
            PublishingUsername = publishingUsername;
            AppSettings = appSettings;
            ConnectionStrings = connectionStrings;
            MachineKey = machineKey;
            HandlerMappings = handlerMappings;
            DocumentRoot = documentRoot;
            ScmType = scmType;
            Use32BitWorkerProcess = use32BitWorkerProcess;
            WebSocketsEnabled = webSocketsEnabled;
            AlwaysOn = alwaysOn;
            JavaVersion = javaVersion;
            JavaContainer = javaContainer;
            JavaContainerVersion = javaContainerVersion;
            AppCommandLine = appCommandLine;
            ManagedPipelineMode = managedPipelineMode;
            VirtualApplications = virtualApplications;
            LoadBalancing = loadBalancing;
            Experiments = experiments;
            Limits = limits;
            AutoHealEnabled = autoHealEnabled;
            AutoHealRules = autoHealRules;
            TracingOptions = tracingOptions;
            VnetName = vnetName;
            VnetRouteAllEnabled = vnetRouteAllEnabled;
            VnetPrivatePortsCount = vnetPrivatePortsCount;
            Cors = cors;
            Push = push;
            ApiDefinition = apiDefinition;
            ApiManagementConfig = apiManagementConfig;
            AutoSwapSlotName = autoSwapSlotName;
            LocalMySqlEnabled = localMySqlEnabled;
            ManagedServiceIdentityId = managedServiceIdentityId;
            XManagedServiceIdentityId = xManagedServiceIdentityId;
            KeyVaultReferenceIdentity = keyVaultReferenceIdentity;
            IPSecurityRestrictions = ipSecurityRestrictions;
            ScmIPSecurityRestrictions = scmIPSecurityRestrictions;
            ScmIPSecurityRestrictionsUseMain = scmIPSecurityRestrictionsUseMain;
            Http20Enabled = http20Enabled;
            MinTlsVersion = minTlsVersion;
            ScmMinTlsVersion = scmMinTlsVersion;
            FtpsState = ftpsState;
            PreWarmedInstanceCount = preWarmedInstanceCount;
            FunctionAppScaleLimit = functionAppScaleLimit;
            HealthCheckPath = healthCheckPath;
            FunctionsRuntimeScaleMonitoringEnabled = functionsRuntimeScaleMonitoringEnabled;
            WebsiteTimeZone = websiteTimeZone;
            MinimumElasticInstanceCount = minimumElasticInstanceCount;
            AzureStorageAccounts = azureStorageAccounts;
            PublicNetworkAccess = publicNetworkAccess;
        }

        /// <summary> Number of workers. </summary>
        public int? NumberOfWorkers { get; set; }
        /// <summary> Default documents. </summary>
        public IList<string> DefaultDocuments { get; set; }
        /// <summary> .NET Framework version. </summary>
        public string NetFrameworkVersion { get; set; }
        /// <summary> Version of PHP. </summary>
        public string PhpVersion { get; set; }
        /// <summary> Version of Python. </summary>
        public string PythonVersion { get; set; }
        /// <summary> Version of Node.js. </summary>
        public string NodeVersion { get; set; }
        /// <summary> Version of PowerShell. </summary>
        public string PowerShellVersion { get; set; }
        /// <summary> Linux App Framework and version. </summary>
        public string LinuxFxVersion { get; set; }
        /// <summary> Xenon App Framework and version. </summary>
        public string WindowsFxVersion { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if request tracing is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? RequestTracingEnabled { get; set; }
        /// <summary> Request tracing expiration time. </summary>
        public DateTimeOffset? RequestTracingExpirationOn { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if remote debugging is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? RemoteDebuggingEnabled { get; set; }
        /// <summary> Remote debugging version. </summary>
        public string RemoteDebuggingVersion { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if HTTP logging is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? HttpLoggingEnabled { get; set; }
        /// <summary> Flag to use Managed Identity Creds for ACR pull. </summary>
        public bool? AcrUseManagedIdentityCreds { get; set; }
        /// <summary> If using user managed identity, the user managed identity ClientId. </summary>
        public string AcrUserManagedIdentityId { get; set; }
        /// <summary> HTTP logs directory size limit. </summary>
        public int? LogsDirectorySizeLimit { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if detailed error logging is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? DetailedErrorLoggingEnabled { get; set; }
        /// <summary> Publishing user name. </summary>
        public string PublishingUsername { get; set; }
        /// <summary> Application settings. </summary>
        public IList<NameValuePair> AppSettings { get; set; }
        /// <summary> Connection strings. </summary>
        public IList<ConnStringInfo> ConnectionStrings { get; set; }
        /// <summary> Site MachineKey. </summary>
        public SiteMachineKey MachineKey { get; }
        /// <summary> Handler mappings. </summary>
        public IList<HandlerMapping> HandlerMappings { get; set; }
        /// <summary> Document root. </summary>
        public string DocumentRoot { get; set; }
        /// <summary> SCM type. </summary>
        public ScmType? ScmType { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; to use 32-bit worker process; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? Use32BitWorkerProcess { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if WebSocket is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? WebSocketsEnabled { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if Always On is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? AlwaysOn { get; set; }
        /// <summary> Java version. </summary>
        public string JavaVersion { get; set; }
        /// <summary> Java container. </summary>
        public string JavaContainer { get; set; }
        /// <summary> Java container version. </summary>
        public string JavaContainerVersion { get; set; }
        /// <summary> App command line to launch. </summary>
        public string AppCommandLine { get; set; }
        /// <summary> Managed pipeline mode. </summary>
        public ManagedPipelineMode? ManagedPipelineMode { get; set; }
        /// <summary> Virtual applications. </summary>
        public IList<VirtualApplication> VirtualApplications { get; set; }
        /// <summary> Site load balancing. </summary>
        public SiteLoadBalancing? LoadBalancing { get; set; }
        /// <summary> This is work around for polymorphic types. </summary>
        internal Experiments Experiments { get; set; }
        /// <summary> List of ramp-up rules. </summary>
        public IList<RampUpRule> ExperimentsRampUpRules
        {
            get
            {
                if (Experiments is null)
                    Experiments = new Experiments();
                return Experiments.RampUpRules;
            }
        }

        /// <summary> Site limits. </summary>
        public SiteLimits Limits { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if Auto Heal is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? AutoHealEnabled { get; set; }
        /// <summary> Auto Heal rules. </summary>
        public AutoHealRules AutoHealRules { get; set; }
        /// <summary> Tracing options. </summary>
        public string TracingOptions { get; set; }
        /// <summary> Virtual Network name. </summary>
        public string VnetName { get; set; }
        /// <summary> Virtual Network Route All enabled. This causes all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied. </summary>
        public bool? VnetRouteAllEnabled { get; set; }
        /// <summary> The number of private ports assigned to this app. These will be assigned dynamically on runtime. </summary>
        public int? VnetPrivatePortsCount { get; set; }
        /// <summary> Cross-Origin Resource Sharing (CORS) settings. </summary>
        public CorsSettings Cors { get; set; }
        /// <summary> Push endpoint settings. </summary>
        public PushSettings Push { get; set; }
        /// <summary> Information about the formal API definition for the app. </summary>
        internal ApiDefinitionInfo ApiDefinition { get; set; }
        /// <summary> The URL of the API definition. </summary>
        public Uri ApiDefinitionUri
        {
            get => ApiDefinition is null ? default : ApiDefinition.Uri;
            set
            {
                if (ApiDefinition is null)
                    ApiDefinition = new ApiDefinitionInfo();
                ApiDefinition.Uri = value;
            }
        }

        /// <summary> Azure API management settings linked to the app. </summary>
        internal ApiManagementConfig ApiManagementConfig { get; set; }
        /// <summary> APIM-Api Identifier. </summary>
        public string ApiManagementConfigId
        {
            get => ApiManagementConfig is null ? default : ApiManagementConfig.Id;
            set
            {
                if (ApiManagementConfig is null)
                    ApiManagementConfig = new ApiManagementConfig();
                ApiManagementConfig.Id = value;
            }
        }

        /// <summary> Auto-swap slot name. </summary>
        public string AutoSwapSlotName { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; to enable local MySQL; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? LocalMySqlEnabled { get; set; }
        /// <summary> Managed Service Identity Id. </summary>
        public int? ManagedServiceIdentityId { get; set; }
        /// <summary> Explicit Managed Service Identity Id. </summary>
        public int? XManagedServiceIdentityId { get; set; }
        /// <summary> Identity to use for Key Vault Reference authentication. </summary>
        public string KeyVaultReferenceIdentity { get; set; }
        /// <summary> IP security restrictions for main. </summary>
        public IList<IPSecurityRestriction> IPSecurityRestrictions { get; set; }
        /// <summary> IP security restrictions for scm. </summary>
        public IList<IPSecurityRestriction> ScmIPSecurityRestrictions { get; set; }
        /// <summary> IP security restrictions for scm to use main. </summary>
        public bool? ScmIPSecurityRestrictionsUseMain { get; set; }
        /// <summary> Http20Enabled: configures a web site to allow clients to connect over http2.0. </summary>
        public bool? Http20Enabled { get; set; }
        /// <summary> MinTlsVersion: configures the minimum version of TLS required for SSL requests. </summary>
        public SupportedTlsVersion? MinTlsVersion { get; set; }
        /// <summary> ScmMinTlsVersion: configures the minimum version of TLS required for SSL requests for SCM site. </summary>
        public SupportedTlsVersion? ScmMinTlsVersion { get; set; }
        /// <summary> State of FTP / FTPS service. </summary>
        public FtpsState? FtpsState { get; set; }
        /// <summary>
        /// Number of preWarmed instances.
        /// This setting only applies to the Consumption and Elastic Plans
        /// </summary>
        public int? PreWarmedInstanceCount { get; set; }
        /// <summary>
        /// Maximum number of workers that a site can scale out to.
        /// This setting only applies to the Consumption and Elastic Premium Plans
        /// </summary>
        public int? FunctionAppScaleLimit { get; set; }
        /// <summary> Health check path. </summary>
        public string HealthCheckPath { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether functions runtime scale monitoring is enabled. When enabled,
        /// the ScaleController will not monitor event sources directly, but will instead call to the
        /// runtime to get scale status.
        /// </summary>
        public bool? FunctionsRuntimeScaleMonitoringEnabled { get; set; }
        /// <summary> Sets the time zone a site uses for generating timestamps. Compatible with Linux and Windows App Service. Setting the WEBSITE_TIME_ZONE app setting takes precedence over this config. For Linux, expects tz database values https://www.iana.org/time-zones (for a quick reference see https://en.wikipedia.org/wiki/List_of_tz_database_time_zones). For Windows, expects one of the time zones listed under HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Time Zones. </summary>
        public string WebsiteTimeZone { get; set; }
        /// <summary>
        /// Number of minimum instance count for a site
        /// This setting only applies to the Elastic Plans
        /// </summary>
        public int? MinimumElasticInstanceCount { get; set; }
        /// <summary> List of Azure Storage Accounts. </summary>
        public IDictionary<string, AzureStorageInfoValue> AzureStorageAccounts { get; set; }
        /// <summary> Property to allow or block all public traffic. </summary>
        public string PublicNetworkAccess { get; set; }
    }
}
