// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;
using Azure.ResourceManager.Avs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Avs
{
    /// <summary> A class representing the GlobalReachConnection data model. </summary>
    public partial class GlobalReachConnectionData : Resource
    {
        /// <summary> Initializes a new instance of GlobalReachConnectionData. </summary>
        public GlobalReachConnectionData()
        {
        }

        /// <summary> Initializes a new instance of GlobalReachConnectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="provisioningState"> The state of the  ExpressRoute Circuit Authorization provisioning. </param>
        /// <param name="addressPrefix"> The network used for global reach carved out from the original network block provided for the private cloud. </param>
        /// <param name="authorizationKey"> Authorization key from the peer express route used for the global reach connection. </param>
        /// <param name="circuitConnectionStatus"> The connection status of the global reach connection. </param>
        /// <param name="peerExpressRouteCircuit"> Identifier of the ExpressRoute Circuit to peer with in the global reach connection. </param>
        /// <param name="expressRouteId"> The ID of the Private Cloud&apos;s ExpressRoute Circuit that is participating in the global reach connection. </param>
        internal GlobalReachConnectionData(ResourceIdentifier id, string name, ResourceType type, GlobalReachConnectionProvisioningState? provisioningState, string addressPrefix, string authorizationKey, GlobalReachConnectionStatus? circuitConnectionStatus, string peerExpressRouteCircuit, string expressRouteId) : base(id, name, type)
        {
            ProvisioningState = provisioningState;
            AddressPrefix = addressPrefix;
            AuthorizationKey = authorizationKey;
            CircuitConnectionStatus = circuitConnectionStatus;
            PeerExpressRouteCircuit = peerExpressRouteCircuit;
            ExpressRouteId = expressRouteId;
        }

        /// <summary> The state of the  ExpressRoute Circuit Authorization provisioning. </summary>
        public GlobalReachConnectionProvisioningState? ProvisioningState { get; }
        /// <summary> The network used for global reach carved out from the original network block provided for the private cloud. </summary>
        public string AddressPrefix { get; }
        /// <summary> Authorization key from the peer express route used for the global reach connection. </summary>
        public string AuthorizationKey { get; set; }
        /// <summary> The connection status of the global reach connection. </summary>
        public GlobalReachConnectionStatus? CircuitConnectionStatus { get; }
        /// <summary> Identifier of the ExpressRoute Circuit to peer with in the global reach connection. </summary>
        public string PeerExpressRouteCircuit { get; set; }
        /// <summary> The ID of the Private Cloud&apos;s ExpressRoute Circuit that is participating in the global reach connection. </summary>
        public string ExpressRouteId { get; set; }
    }
}
