// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Migrate.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the load balancer resource settings.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Microsoft.Network/loadBalancers")]
    public partial class LoadBalancerResourceSettings : ResourceSettings
    {
        /// <summary>
        /// Initializes a new instance of the LoadBalancerResourceSettings
        /// class.
        /// </summary>
        public LoadBalancerResourceSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LoadBalancerResourceSettings
        /// class.
        /// </summary>
        /// <param name="targetResourceName">Gets or sets the target Resource
        /// name.</param>
        /// <param name="sku">Gets or sets load balancer sku
        /// (Basic/Standard).</param>
        /// <param name="frontendIPConfigurations">Gets or sets the frontend IP
        /// configurations of the load balancer.</param>
        /// <param name="backendAddressPools">Gets or sets the backend address
        /// pools of the load balancer.</param>
        /// <param name="zones">Gets or sets the csv list of zones common for
        /// all frontend IP configurations. Note this is given
        /// precedence only if frontend IP configurations settings are not
        /// present.</param>
        public LoadBalancerResourceSettings(string targetResourceName, string sku = default(string), IList<LBFrontendIPConfigurationResourceSettings> frontendIPConfigurations = default(IList<LBFrontendIPConfigurationResourceSettings>), IList<LBBackendAddressPoolResourceSettings> backendAddressPools = default(IList<LBBackendAddressPoolResourceSettings>), string zones = default(string))
            : base(targetResourceName)
        {
            Sku = sku;
            FrontendIPConfigurations = frontendIPConfigurations;
            BackendAddressPools = backendAddressPools;
            Zones = zones;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets load balancer sku (Basic/Standard).
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public string Sku { get; set; }

        /// <summary>
        /// Gets or sets the frontend IP configurations of the load balancer.
        /// </summary>
        [JsonProperty(PropertyName = "frontendIPConfigurations")]
        public IList<LBFrontendIPConfigurationResourceSettings> FrontendIPConfigurations { get; set; }

        /// <summary>
        /// Gets or sets the backend address pools of the load balancer.
        /// </summary>
        [JsonProperty(PropertyName = "backendAddressPools")]
        public IList<LBBackendAddressPoolResourceSettings> BackendAddressPools { get; set; }

        /// <summary>
        /// Gets or sets the csv list of zones common for all frontend IP
        /// configurations. Note this is given
        /// precedence only if frontend IP configurations settings are not
        /// present.
        /// </summary>
        [JsonProperty(PropertyName = "zones")]
        public string Zones { get; set; }

    }
}
