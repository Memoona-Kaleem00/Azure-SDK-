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
    /// Express Route Circuit Connection in an ExpressRouteCircuitPeering
    /// resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ExpressRouteCircuitConnection : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuitConnection
        /// class.
        /// </summary>
        public ExpressRouteCircuitConnection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuitConnection
        /// class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="expressRouteCircuitPeering">Reference to Express Route
        /// Circuit Private Peering Resource of the circuit initiating
        /// connection.</param>
        /// <param name="peerExpressRouteCircuitPeering">Reference to Express
        /// Route Circuit Private Peering Resource of the peered
        /// circuit.</param>
        /// <param name="addressPrefix">/29 IP address space to carve out
        /// Customer addresses for tunnels.</param>
        /// <param name="authorizationKey">The authorization key.</param>
        /// <param name="circuitConnectionStatus">Express Route Circuit
        /// connection state. Possible values include: 'Connected',
        /// 'Connecting', 'Disconnected'</param>
        /// <param name="provisioningState">Provisioning state of the circuit
        /// connection resource. Possible values are: 'Succeeded', 'Updating',
        /// 'Deleting', and 'Failed'.</param>
        /// <param name="name">Gets name of the resource that is unique within
        /// a resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public ExpressRouteCircuitConnection(string id = default(string), SubResource expressRouteCircuitPeering = default(SubResource), SubResource peerExpressRouteCircuitPeering = default(SubResource), string addressPrefix = default(string), string authorizationKey = default(string), string circuitConnectionStatus = default(string), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            ExpressRouteCircuitPeering = expressRouteCircuitPeering;
            PeerExpressRouteCircuitPeering = peerExpressRouteCircuitPeering;
            AddressPrefix = addressPrefix;
            AuthorizationKey = authorizationKey;
            CircuitConnectionStatus = circuitConnectionStatus;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets reference to Express Route Circuit Private Peering
        /// Resource of the circuit initiating connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.expressRouteCircuitPeering")]
        public SubResource ExpressRouteCircuitPeering { get; set; }

        /// <summary>
        /// Gets or sets reference to Express Route Circuit Private Peering
        /// Resource of the peered circuit.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peerExpressRouteCircuitPeering")]
        public SubResource PeerExpressRouteCircuitPeering { get; set; }

        /// <summary>
        /// Gets or sets /29 IP address space to carve out Customer addresses
        /// for tunnels.
        /// </summary>
        [JsonProperty(PropertyName = "properties.addressPrefix")]
        public string AddressPrefix { get; set; }

        /// <summary>
        /// Gets or sets the authorization key.
        /// </summary>
        [JsonProperty(PropertyName = "properties.authorizationKey")]
        public string AuthorizationKey { get; set; }

        /// <summary>
        /// Gets or sets express Route Circuit connection state. Possible
        /// values include: 'Connected', 'Connecting', 'Disconnected'
        /// </summary>
        [JsonProperty(PropertyName = "properties.circuitConnectionStatus")]
        public string CircuitConnectionStatus { get; set; }

        /// <summary>
        /// Gets provisioning state of the circuit connection resource.
        /// Possible values are: 'Succeeded', 'Updating', 'Deleting', and
        /// 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets name of the resource that is unique within a resource group.
        /// This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

    }
}
