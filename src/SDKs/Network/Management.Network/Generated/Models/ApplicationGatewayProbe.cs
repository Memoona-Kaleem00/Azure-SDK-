// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Probe of the application gateway.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ApplicationGatewayProbe : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayProbe class.
        /// </summary>
        public ApplicationGatewayProbe()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayProbe class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="protocol">The protocol used for the probe. Possible
        /// values are 'Http' and 'Https'. Possible values include: 'Http',
        /// 'Https'</param>
        /// <param name="host">Host name to send the probe to.</param>
        /// <param name="path">Relative path of probe. Valid path starts from
        /// '/'. Probe is sent to
        /// &lt;Protocol&gt;://&lt;host&gt;:&lt;port&gt;&lt;path&gt;</param>
        /// <param name="interval">The probing interval in seconds. This is the
        /// time interval between two consecutive probes. Acceptable values are
        /// from 1 second to 86400 seconds.</param>
        /// <param name="timeout">The probe timeout in seconds. Probe marked as
        /// failed if valid response is not received with this timeout period.
        /// Acceptable values are from 1 second to 86400 seconds.</param>
        /// <param name="unhealthyThreshold">The probe retry count. Backend
        /// server is marked down after consecutive probe failure count reaches
        /// UnhealthyThreshold. Acceptable values are from 1 second to
        /// 20.</param>
        /// <param name="pickHostNameFromBackendHttpSettings">Whether the host
        /// header should be picked from the backend http settings. Default
        /// value is false.</param>
        /// <param name="minServers">Minimum number of servers that are always
        /// marked healthy. Default value is 0.</param>
        /// <param name="match">Criterion for classifying a healthy probe
        /// response.</param>
        /// <param name="provisioningState">Provisioning state of the backend
        /// http settings resource. Possible values are: 'Updating',
        /// 'Deleting', and 'Failed'.</param>
        /// <param name="name">Name of the probe that is unique within an
        /// Application Gateway.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="type">Type of the resource.</param>
        public ApplicationGatewayProbe(string id = default(string), string protocol = default(string), string host = default(string), string path = default(string), int? interval = default(int?), int? timeout = default(int?), int? unhealthyThreshold = default(int?), bool? pickHostNameFromBackendHttpSettings = default(bool?), int? minServers = default(int?), ApplicationGatewayProbeHealthResponseMatch match = default(ApplicationGatewayProbeHealthResponseMatch), string provisioningState = default(string), string name = default(string), string etag = default(string), string type = default(string))
            : base(id)
        {
            Protocol = protocol;
            Host = host;
            Path = path;
            Interval = interval;
            Timeout = timeout;
            UnhealthyThreshold = unhealthyThreshold;
            PickHostNameFromBackendHttpSettings = pickHostNameFromBackendHttpSettings;
            MinServers = minServers;
            Match = match;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the protocol used for the probe. Possible values are
        /// 'Http' and 'Https'. Possible values include: 'Http', 'Https'
        /// </summary>
        [JsonProperty(PropertyName = "properties.protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets host name to send the probe to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.host")]
        public string Host { get; set; }

        /// <summary>
        /// Gets or sets relative path of probe. Valid path starts from '/'.
        /// Probe is sent to
        /// &amp;lt;Protocol&amp;gt;://&amp;lt;host&amp;gt;:&amp;lt;port&amp;gt;&amp;lt;path&amp;gt;
        /// </summary>
        [JsonProperty(PropertyName = "properties.path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the probing interval in seconds. This is the time
        /// interval between two consecutive probes. Acceptable values are from
        /// 1 second to 86400 seconds.
        /// </summary>
        [JsonProperty(PropertyName = "properties.interval")]
        public int? Interval { get; set; }

        /// <summary>
        /// Gets or sets the probe timeout in seconds. Probe marked as failed
        /// if valid response is not received with this timeout period.
        /// Acceptable values are from 1 second to 86400 seconds.
        /// </summary>
        [JsonProperty(PropertyName = "properties.timeout")]
        public int? Timeout { get; set; }

        /// <summary>
        /// Gets or sets the probe retry count. Backend server is marked down
        /// after consecutive probe failure count reaches UnhealthyThreshold.
        /// Acceptable values are from 1 second to 20.
        /// </summary>
        [JsonProperty(PropertyName = "properties.unhealthyThreshold")]
        public int? UnhealthyThreshold { get; set; }

        /// <summary>
        /// Gets or sets whether the host header should be picked from the
        /// backend http settings. Default value is false.
        /// </summary>
        [JsonProperty(PropertyName = "properties.pickHostNameFromBackendHttpSettings")]
        public bool? PickHostNameFromBackendHttpSettings { get; set; }

        /// <summary>
        /// Gets or sets minimum number of servers that are always marked
        /// healthy. Default value is 0.
        /// </summary>
        [JsonProperty(PropertyName = "properties.minServers")]
        public int? MinServers { get; set; }

        /// <summary>
        /// Gets or sets criterion for classifying a healthy probe response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.match")]
        public ApplicationGatewayProbeHealthResponseMatch Match { get; set; }

        /// <summary>
        /// Gets or sets provisioning state of the backend http settings
        /// resource. Possible values are: 'Updating', 'Deleting', and
        /// 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets name of the probe that is unique within an Application
        /// Gateway.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets type of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
