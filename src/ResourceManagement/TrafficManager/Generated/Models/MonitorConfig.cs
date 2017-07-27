// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.TrafficManager.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.TrafficManager;
    using Microsoft.Azure.Management.TrafficManager.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Class containing endpoint monitoring settings in a Traffic Manager
    /// profile.
    /// </summary>
    public partial class MonitorConfig
    {
        /// <summary>
        /// Initializes a new instance of the MonitorConfig class.
        /// </summary>
        public MonitorConfig()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MonitorConfig class.
        /// </summary>
        /// <param name="profileMonitorStatus">The profile-level monitoring
        /// status of the Traffic Manager profile. Possible values include:
        /// 'CheckingEndpoints', 'Online', 'Degraded', 'Disabled',
        /// 'Inactive'</param>
        /// <param name="protocol">The protocol (HTTP, HTTPS or TCP) used to
        /// probe for endpoint health. Possible values include: 'HTTP',
        /// 'HTTPS', 'TCP'</param>
        /// <param name="port">The TCP port used to probe for endpoint
        /// health.</param>
        /// <param name="path">The path relative to the endpoint domain name
        /// used to probe for endpoint health.</param>
        /// <param name="intervalInSeconds">The monitor interval for endpoints
        /// in this profile. This is the interval at which Traffic Manager will
        /// check the health of each endpoint in this profile.</param>
        /// <param name="timeoutInSeconds">The monitor timeout for endpoints in
        /// this profile. This is the time that Traffic Manager allows
        /// endpoints in this profile to response to the health check.</param>
        /// <param name="toleratedNumberOfFailures">The number of consecutive
        /// failed health check that Traffic Manager tolerates before declaring
        /// an endpoint in this profile Degraded after the next failed health
        /// check.</param>
        public MonitorConfig(string profileMonitorStatus = default(string), string protocol = default(string), long? port = default(long?), string path = default(string), long? intervalInSeconds = default(long?), long? timeoutInSeconds = default(long?), long? toleratedNumberOfFailures = default(long?))
        {
            ProfileMonitorStatus = profileMonitorStatus;
            Protocol = protocol;
            Port = port;
            Path = path;
            IntervalInSeconds = intervalInSeconds;
            TimeoutInSeconds = timeoutInSeconds;
            ToleratedNumberOfFailures = toleratedNumberOfFailures;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the profile-level monitoring status of the Traffic
        /// Manager profile. Possible values include: 'CheckingEndpoints',
        /// 'Online', 'Degraded', 'Disabled', 'Inactive'
        /// </summary>
        [JsonProperty(PropertyName = "profileMonitorStatus")]
        public string ProfileMonitorStatus { get; set; }

        /// <summary>
        /// Gets or sets the protocol (HTTP, HTTPS or TCP) used to probe for
        /// endpoint health. Possible values include: 'HTTP', 'HTTPS', 'TCP'
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets the TCP port used to probe for endpoint health.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public long? Port { get; set; }

        /// <summary>
        /// Gets or sets the path relative to the endpoint domain name used to
        /// probe for endpoint health.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the monitor interval for endpoints in this profile.
        /// This is the interval at which Traffic Manager will check the health
        /// of each endpoint in this profile.
        /// </summary>
        [JsonProperty(PropertyName = "intervalInSeconds")]
        public long? IntervalInSeconds { get; set; }

        /// <summary>
        /// Gets or sets the monitor timeout for endpoints in this profile.
        /// This is the time that Traffic Manager allows endpoints in this
        /// profile to response to the health check.
        /// </summary>
        [JsonProperty(PropertyName = "timeoutInSeconds")]
        public long? TimeoutInSeconds { get; set; }

        /// <summary>
        /// Gets or sets the number of consecutive failed health check that
        /// Traffic Manager tolerates before declaring an endpoint in this
        /// profile Degraded after the next failed health check.
        /// </summary>
        [JsonProperty(PropertyName = "toleratedNumberOfFailures")]
        public long? ToleratedNumberOfFailures { get; set; }

    }
}
