// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Configuration of an App Service app.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class SiteConfigInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the SiteConfigInner class.
        /// </summary>
        public SiteConfigInner() { }

        /// <summary>
        /// Initializes a new instance of the SiteConfigInner class.
        /// </summary>
        /// <param name="numberOfWorkers">Number of workers.</param>
        /// <param name="defaultDocuments">Default documents.</param>
        /// <param name="netFrameworkVersion">.NET Framework version.</param>
        /// <param name="phpVersion">Version of PHP.</param>
        /// <param name="pythonVersion">Version of Python.</param>
        /// <param name="nodeVersion">Version of Node.js.</param>
        /// <param name="requestTracingEnabled"><code>true</code> if request
        /// tracing is enabled; otherwise, <code>false</code>.</param>
        /// <param name="requestTracingExpirationTime">Request tracing
        /// expiration time.</param>
        /// <param name="remoteDebuggingEnabled"><code>true</code> if remote
        /// debugging is enabled; otherwise, <code>false</code>.</param>
        /// <param name="remoteDebuggingVersion">Remote debugging
        /// version.</param>
        /// <param name="httpLoggingEnabled"><code>true</code> if HTTP logging
        /// is enabled; otherwise, <code>false</code>.</param>
        /// <param name="logsDirectorySizeLimit">HTTP logs directory size
        /// limit.</param>
        /// <param name="detailedErrorLoggingEnabled"><code>true</code> if
        /// detailed error logging is enabled; otherwise,
        /// <code>false</code>.</param>
        /// <param name="publishingUsername">Publishing user name.</param>
        /// <param name="machineKey">Site MachineKey.</param>
        /// <param name="handlerMappings">Handler mappings.</param>
        /// <param name="documentRoot">Document root.</param>
        /// <param name="scmType">SCM type.</param>
        /// <param name="use32BitWorkerProcess"><code>true</code> to use
        /// 32-bit worker process; otherwise, <code>false</code>.</param>
        /// <param name="webSocketsEnabled"><code>true</code> if WebSocket is
        /// enabled; otherwise, <code>false</code>.</param>
        /// <param name="alwaysOn"><code>true</code> if Always On is enabled;
        /// otherwise, <code>false</code>.</param>
        /// <param name="javaVersion">Java version.</param>
        /// <param name="javaContainer">Java container.</param>
        /// <param name="javaContainerVersion">Java container version.</param>
        /// <param name="appCommandLine">App command line to launch.</param>
        /// <param name="managedPipelineMode">Managed pipeline mode. Possible
        /// values include: 'Integrated', 'Classic'</param>
        /// <param name="virtualApplications">Virtual applications.</param>
        /// <param name="loadBalancing">Site load balancing. Possible values
        /// include: 'WeightedRoundRobin', 'LeastRequests',
        /// 'LeastResponseTime', 'WeightedTotalTraffic', 'RequestHash'</param>
        /// <param name="experiments">This is work around for polymophic
        /// types.</param>
        /// <param name="limits">Site limits.</param>
        /// <param name="autoHealEnabled"><code>true</code> if Auto Heal is
        /// enabled; otherwise, <code>false</code>.</param>
        /// <param name="autoHealRules">Auto Heal rules.</param>
        /// <param name="tracingOptions">Tracing options.</param>
        /// <param name="vnetName">Virtual Network name.</param>
        /// <param name="cors">Cross-Origin Resource Sharing (CORS)
        /// settings.</param>
        /// <param name="push">Push endpoint settings.</param>
        /// <param name="apiDefinition">Information about the formal API
        /// definition for the app.</param>
        /// <param name="autoSwapSlotName">Auto-swap slot name.</param>
        /// <param name="localMySqlEnabled"><code>true</code> to enable local
        /// MySQL; otherwise, <code>false</code>.</param>
        /// <param name="ipSecurityRestrictions">IP security
        /// restrictions.</param>
        public SiteConfigInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), int? numberOfWorkers = default(int?), System.Collections.Generic.IList<string> defaultDocuments = default(System.Collections.Generic.IList<string>), string netFrameworkVersion = default(string), string phpVersion = default(string), string pythonVersion = default(string), string nodeVersion = default(string), bool? requestTracingEnabled = default(bool?), System.DateTime? requestTracingExpirationTime = default(System.DateTime?), bool? remoteDebuggingEnabled = default(bool?), string remoteDebuggingVersion = default(string), bool? httpLoggingEnabled = default(bool?), int? logsDirectorySizeLimit = default(int?), bool? detailedErrorLoggingEnabled = default(bool?), string publishingUsername = default(string), SiteMachineKey machineKey = default(SiteMachineKey), System.Collections.Generic.IList<HandlerMapping> handlerMappings = default(System.Collections.Generic.IList<HandlerMapping>), string documentRoot = default(string), string scmType = default(string), bool? use32BitWorkerProcess = default(bool?), bool? webSocketsEnabled = default(bool?), bool? alwaysOn = default(bool?), string javaVersion = default(string), string javaContainer = default(string), string javaContainerVersion = default(string), string appCommandLine = default(string), ManagedPipelineMode? managedPipelineMode = default(ManagedPipelineMode?), System.Collections.Generic.IList<VirtualApplication> virtualApplications = default(System.Collections.Generic.IList<VirtualApplication>), SiteLoadBalancing? loadBalancing = default(SiteLoadBalancing?), Experiments experiments = default(Experiments), SiteLimits limits = default(SiteLimits), bool? autoHealEnabled = default(bool?), AutoHealRules autoHealRules = default(AutoHealRules), string tracingOptions = default(string), string vnetName = default(string), CorsSettings cors = default(CorsSettings), PushSettingsInner push = default(PushSettingsInner), ApiDefinitionInfo apiDefinition = default(ApiDefinitionInfo), string autoSwapSlotName = default(string), bool? localMySqlEnabled = default(bool?), System.Collections.Generic.IList<IpSecurityRestriction> ipSecurityRestrictions = default(System.Collections.Generic.IList<IpSecurityRestriction>))
            : base(location, id, name, type, tags)
        {
            NumberOfWorkers = numberOfWorkers;
            DefaultDocuments = defaultDocuments;
            NetFrameworkVersion = netFrameworkVersion;
            PhpVersion = phpVersion;
            PythonVersion = pythonVersion;
            NodeVersion = nodeVersion;
            RequestTracingEnabled = requestTracingEnabled;
            RequestTracingExpirationTime = requestTracingExpirationTime;
            RemoteDebuggingEnabled = remoteDebuggingEnabled;
            RemoteDebuggingVersion = remoteDebuggingVersion;
            HttpLoggingEnabled = httpLoggingEnabled;
            LogsDirectorySizeLimit = logsDirectorySizeLimit;
            DetailedErrorLoggingEnabled = detailedErrorLoggingEnabled;
            PublishingUsername = publishingUsername;
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
            Cors = cors;
            Push = push;
            ApiDefinition = apiDefinition;
            AutoSwapSlotName = autoSwapSlotName;
            LocalMySqlEnabled = localMySqlEnabled;
            IpSecurityRestrictions = ipSecurityRestrictions;
        }

        /// <summary>
        /// Gets or sets number of workers.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.numberOfWorkers")]
        public int? NumberOfWorkers { get; set; }

        /// <summary>
        /// Gets or sets default documents.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.defaultDocuments")]
        public System.Collections.Generic.IList<string> DefaultDocuments { get; set; }

        /// <summary>
        /// Gets or sets .NET Framework version.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.netFrameworkVersion")]
        public string NetFrameworkVersion { get; set; }

        /// <summary>
        /// Gets or sets version of PHP.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.phpVersion")]
        public string PhpVersion { get; set; }

        /// <summary>
        /// Gets or sets version of Python.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.pythonVersion")]
        public string PythonVersion { get; set; }

        /// <summary>
        /// Gets or sets version of Node.js.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.nodeVersion")]
        public string NodeVersion { get; set; }

        /// <summary>
        /// Gets or sets &lt;code&gt;true&lt;/code&gt; if request tracing is
        /// enabled; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.requestTracingEnabled")]
        public bool? RequestTracingEnabled { get; set; }

        /// <summary>
        /// Gets or sets request tracing expiration time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.requestTracingExpirationTime")]
        public System.DateTime? RequestTracingExpirationTime { get; set; }

        /// <summary>
        /// Gets or sets &lt;code&gt;true&lt;/code&gt; if remote debugging is
        /// enabled; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.remoteDebuggingEnabled")]
        public bool? RemoteDebuggingEnabled { get; set; }

        /// <summary>
        /// Gets or sets remote debugging version.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.remoteDebuggingVersion")]
        public string RemoteDebuggingVersion { get; set; }

        /// <summary>
        /// Gets or sets &lt;code&gt;true&lt;/code&gt; if HTTP logging is
        /// enabled; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.httpLoggingEnabled")]
        public bool? HttpLoggingEnabled { get; set; }

        /// <summary>
        /// Gets or sets HTTP logs directory size limit.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.logsDirectorySizeLimit")]
        public int? LogsDirectorySizeLimit { get; set; }

        /// <summary>
        /// Gets or sets &lt;code&gt;true&lt;/code&gt; if detailed error
        /// logging is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.detailedErrorLoggingEnabled")]
        public bool? DetailedErrorLoggingEnabled { get; set; }

        /// <summary>
        /// Gets or sets publishing user name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.publishingUsername")]
        public string PublishingUsername { get; set; }

        /// <summary>
        /// Gets site MachineKey.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.machineKey")]
        public SiteMachineKey MachineKey { get; private set; }

        /// <summary>
        /// Gets or sets handler mappings.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.handlerMappings")]
        public System.Collections.Generic.IList<HandlerMapping> HandlerMappings { get; set; }

        /// <summary>
        /// Gets or sets document root.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.documentRoot")]
        public string DocumentRoot { get; set; }

        /// <summary>
        /// Gets SCM type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.scmType")]
        public string ScmType { get; set; }

        /// <summary>
        /// Gets or sets &lt;code&gt;true&lt;/code&gt; to use 32-bit worker
        /// process; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.use32BitWorkerProcess")]
        public bool? Use32BitWorkerProcess { get; set; }

        /// <summary>
        /// Gets or sets &lt;code&gt;true&lt;/code&gt; if WebSocket is
        /// enabled; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.webSocketsEnabled")]
        public bool? WebSocketsEnabled { get; set; }

        /// <summary>
        /// Gets or sets &lt;code&gt;true&lt;/code&gt; if Always On is
        /// enabled; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.alwaysOn")]
        public bool? AlwaysOn { get; set; }

        /// <summary>
        /// Gets or sets java version.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.javaVersion")]
        public string JavaVersion { get; set; }

        /// <summary>
        /// Gets or sets java container.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.javaContainer")]
        public string JavaContainer { get; set; }

        /// <summary>
        /// Gets or sets java container version.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.javaContainerVersion")]
        public string JavaContainerVersion { get; set; }

        /// <summary>
        /// Gets or sets app command line to launch.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.appCommandLine")]
        public string AppCommandLine { get; set; }

        /// <summary>
        /// Gets or sets managed pipeline mode. Possible values include:
        /// 'Integrated', 'Classic'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.managedPipelineMode")]
        public ManagedPipelineMode? ManagedPipelineMode { get; set; }

        /// <summary>
        /// Gets or sets virtual applications.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.virtualApplications")]
        public System.Collections.Generic.IList<VirtualApplication> VirtualApplications { get; set; }

        /// <summary>
        /// Gets or sets site load balancing. Possible values include:
        /// 'WeightedRoundRobin', 'LeastRequests', 'LeastResponseTime',
        /// 'WeightedTotalTraffic', 'RequestHash'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.loadBalancing")]
        public SiteLoadBalancing? LoadBalancing { get; set; }

        /// <summary>
        /// Gets or sets this is work around for polymophic types.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.experiments")]
        public Experiments Experiments { get; set; }

        /// <summary>
        /// Gets or sets site limits.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.limits")]
        public SiteLimits Limits { get; set; }

        /// <summary>
        /// Gets or sets &lt;code&gt;true&lt;/code&gt; if Auto Heal is
        /// enabled; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.autoHealEnabled")]
        public bool? AutoHealEnabled { get; set; }

        /// <summary>
        /// Gets or sets auto Heal rules.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.autoHealRules")]
        public AutoHealRules AutoHealRules { get; set; }

        /// <summary>
        /// Gets or sets tracing options.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.tracingOptions")]
        public string TracingOptions { get; set; }

        /// <summary>
        /// Gets or sets virtual Network name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.vnetName")]
        public string VnetName { get; set; }

        /// <summary>
        /// Gets or sets cross-Origin Resource Sharing (CORS) settings.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.cors")]
        public CorsSettings Cors { get; set; }

        /// <summary>
        /// Gets or sets push endpoint settings.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.push")]
        public PushSettingsInner Push { get; set; }

        /// <summary>
        /// Gets or sets information about the formal API definition for the
        /// app.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.apiDefinition")]
        public ApiDefinitionInfo ApiDefinition { get; set; }

        /// <summary>
        /// Gets or sets auto-swap slot name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.autoSwapSlotName")]
        public string AutoSwapSlotName { get; set; }

        /// <summary>
        /// Gets or sets &lt;code&gt;true&lt;/code&gt; to enable local MySQL;
        /// otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.localMySqlEnabled")]
        public bool? LocalMySqlEnabled { get; set; }

        /// <summary>
        /// Gets or sets IP security restrictions.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.ipSecurityRestrictions")]
        public System.Collections.Generic.IList<IpSecurityRestriction> IpSecurityRestrictions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Push != null)
            {
                this.Push.Validate();
            }
            if (this.IpSecurityRestrictions != null)
            {
                foreach (var element in this.IpSecurityRestrictions)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
