// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Online endpoint configuration. </summary>
    public partial class OnlineEndpointProperties
    {
        /// <summary> Initializes a new instance of OnlineEndpointProperties. </summary>
        /// <param name="authMode"> Inference endpoint authentication mode type. </param>
        public OnlineEndpointProperties(EndpointAuthModeType authMode)
        {
            Properties = new ChangeTrackingDictionary<string, string>();
            TrafficRules = new ChangeTrackingDictionary<string, int>();
            AuthMode = authMode;
        }

        /// <summary> Initializes a new instance of OnlineEndpointProperties. </summary>
        /// <param name="description"> Description of the inference endpoint. </param>
        /// <param name="properties"> Property dictionary. Properties can be added, but not removed or altered. </param>
        /// <param name="trafficRules"> Traffic rules on how the traffic will be routed across deployments. </param>
        /// <param name="computeConfiguration"> . </param>
        /// <param name="provisioningState"> State of provisioning. </param>
        /// <param name="endpoint"> Endpoint URI. </param>
        /// <param name="swaggerEndpoint"> Endpoint Swagger URI. </param>
        /// <param name="authMode"> Inference endpoint authentication mode type. </param>
        /// <param name="keys"> . </param>
        /// <param name="error"> . </param>
        internal OnlineEndpointProperties(string description, IDictionary<string, string> properties, IDictionary<string, int> trafficRules, ComputeConfiguration computeConfiguration, EndpointProvisioningState? provisioningState, string endpoint, string swaggerEndpoint, EndpointAuthModeType authMode, AuthKeys keys, RootError error)
        {
            Description = description;
            Properties = properties;
            TrafficRules = trafficRules;
            ComputeConfiguration = computeConfiguration;
            ProvisioningState = provisioningState;
            Endpoint = endpoint;
            SwaggerEndpoint = swaggerEndpoint;
            AuthMode = authMode;
            Keys = keys;
            Error = error;
        }

        /// <summary> Description of the inference endpoint. </summary>
        public string Description { get; set; }
        /// <summary> Property dictionary. Properties can be added, but not removed or altered. </summary>
        public IDictionary<string, string> Properties { get; }
        /// <summary> Traffic rules on how the traffic will be routed across deployments. </summary>
        public IDictionary<string, int> TrafficRules { get; }
        public ComputeConfiguration ComputeConfiguration { get; set; }
        /// <summary> State of provisioning. </summary>
        public EndpointProvisioningState? ProvisioningState { get; }
        /// <summary> Endpoint URI. </summary>
        public string Endpoint { get; }
        /// <summary> Endpoint Swagger URI. </summary>
        public string SwaggerEndpoint { get; }
        /// <summary> Inference endpoint authentication mode type. </summary>
        public EndpointAuthModeType AuthMode { get; set; }
        public AuthKeys Keys { get; set; }
        public RootError Error { get; set; }
    }
}
