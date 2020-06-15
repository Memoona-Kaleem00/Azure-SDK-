// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SignalR.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Settings used to provision or configure the resource.
    /// </summary>
    public partial class SignalRCreateOrUpdateProperties
    {
        /// <summary>
        /// Initializes a new instance of the SignalRCreateOrUpdateProperties
        /// class.
        /// </summary>
        public SignalRCreateOrUpdateProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SignalRCreateOrUpdateProperties
        /// class.
        /// </summary>
        /// <param name="hostNamePrefix">Prefix for the hostName of the SignalR
        /// service. Retained for future use.
        /// The hostname will be of format:
        /// &amp;lt;hostNamePrefix&amp;gt;.service.signalr.net.</param>
        /// <param name="features">List of SignalR featureFlags. e.g.
        /// ServiceMode.
        ///
        /// FeatureFlags that are not included in the parameters for the update
        /// operation will not be modified.
        /// And the response will only include featureFlags that are explicitly
        /// set.
        /// When a featureFlag is not explicitly set, SignalR service will use
        /// its globally default value.
        /// But keep in mind, the default value doesn't mean "false". It varies
        /// in terms of different FeatureFlags.</param>
        /// <param name="cors">Cross-Origin Resource Sharing (CORS)
        /// settings.</param>
        /// <param name="upstream">Upstream settings when the Azure SignalR is
        /// in server-less mode.</param>
        /// <param name="networkACLs">Network ACLs</param>
        public SignalRCreateOrUpdateProperties(string hostNamePrefix = default(string), IList<SignalRFeature> features = default(IList<SignalRFeature>), SignalRCorsSettings cors = default(SignalRCorsSettings), ServerlessUpstreamSettings upstream = default(ServerlessUpstreamSettings), SignalRNetworkACLs networkACLs = default(SignalRNetworkACLs))
        {
            HostNamePrefix = hostNamePrefix;
            Features = features;
            Cors = cors;
            Upstream = upstream;
            NetworkACLs = networkACLs;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets prefix for the hostName of the SignalR service.
        /// Retained for future use.
        /// The hostname will be of format:
        /// &amp;amp;lt;hostNamePrefix&amp;amp;gt;.service.signalr.net.
        /// </summary>
        [JsonProperty(PropertyName = "hostNamePrefix")]
        public string HostNamePrefix { get; set; }

        /// <summary>
        /// Gets or sets list of SignalR featureFlags. e.g. ServiceMode.
        ///
        /// FeatureFlags that are not included in the parameters for the update
        /// operation will not be modified.
        /// And the response will only include featureFlags that are explicitly
        /// set.
        /// When a featureFlag is not explicitly set, SignalR service will use
        /// its globally default value.
        /// But keep in mind, the default value doesn't mean "false". It varies
        /// in terms of different FeatureFlags.
        /// </summary>
        [JsonProperty(PropertyName = "features")]
        public IList<SignalRFeature> Features { get; set; }

        /// <summary>
        /// Gets or sets cross-Origin Resource Sharing (CORS) settings.
        /// </summary>
        [JsonProperty(PropertyName = "cors")]
        public SignalRCorsSettings Cors { get; set; }

        /// <summary>
        /// Gets or sets upstream settings when the Azure SignalR is in
        /// server-less mode.
        /// </summary>
        [JsonProperty(PropertyName = "upstream")]
        public ServerlessUpstreamSettings Upstream { get; set; }

        /// <summary>
        /// Gets or sets network ACLs
        /// </summary>
        [JsonProperty(PropertyName = "networkACLs")]
        public SignalRNetworkACLs NetworkACLs { get; set; }

    }
}
