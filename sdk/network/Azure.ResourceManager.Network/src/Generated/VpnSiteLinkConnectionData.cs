// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the VpnSiteLinkConnection data model. </summary>
    public partial class VpnSiteLinkConnectionData : Models.SubResource
    {
        /// <summary> Initializes a new instance of VpnSiteLinkConnectionData. </summary>
        public VpnSiteLinkConnectionData()
        {
            IPsecPolicies = new ChangeTrackingList<IPsecPolicy>();
            IngressNatRules = new ChangeTrackingList<WritableSubResource>();
            EgressNatRules = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of VpnSiteLinkConnectionData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> The name of the resource that is unique within a resource group. This name can be used to access the resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="vpnSiteLink"> Id of the connected vpn site link. </param>
        /// <param name="routingWeight"> Routing weight for vpn connection. </param>
        /// <param name="vpnLinkConnectionMode"> Vpn link connection mode. </param>
        /// <param name="connectionStatus"> The connection status. </param>
        /// <param name="vpnConnectionProtocolType"> Connection protocol used for this connection. </param>
        /// <param name="ingressBytesTransferred"> Ingress bytes transferred. </param>
        /// <param name="egressBytesTransferred"> Egress bytes transferred. </param>
        /// <param name="connectionBandwidth"> Expected bandwidth in MBPS. </param>
        /// <param name="sharedKey"> SharedKey for the vpn connection. </param>
        /// <param name="enableBgp"> EnableBgp flag. </param>
        /// <param name="usePolicyBasedTrafficSelectors"> Enable policy-based traffic selectors. </param>
        /// <param name="iPsecPolicies"> The IPSec Policies to be considered by this connection. </param>
        /// <param name="enableRateLimiting"> EnableBgp flag. </param>
        /// <param name="useLocalAzureIPAddress"> Use local azure ip to initiate connection. </param>
        /// <param name="provisioningState"> The provisioning state of the VPN site link connection resource. </param>
        /// <param name="ingressNatRules"> List of ingress NatRules. </param>
        /// <param name="egressNatRules"> List of egress NatRules. </param>
        internal VpnSiteLinkConnectionData(string id, string name, string etag, string type, WritableSubResource vpnSiteLink, int? routingWeight, VpnLinkConnectionMode? vpnLinkConnectionMode, VpnConnectionStatus? connectionStatus, VirtualNetworkGatewayConnectionProtocol? vpnConnectionProtocolType, long? ingressBytesTransferred, long? egressBytesTransferred, int? connectionBandwidth, string sharedKey, bool? enableBgp, bool? usePolicyBasedTrafficSelectors, IList<IPsecPolicy> iPsecPolicies, bool? enableRateLimiting, bool? useLocalAzureIPAddress, ProvisioningState? provisioningState, IList<WritableSubResource> ingressNatRules, IList<WritableSubResource> egressNatRules) : base(id)
        {
            Name = name;
            Etag = etag;
            Type = type;
            VpnSiteLink = vpnSiteLink;
            RoutingWeight = routingWeight;
            VpnLinkConnectionMode = vpnLinkConnectionMode;
            ConnectionStatus = connectionStatus;
            VpnConnectionProtocolType = vpnConnectionProtocolType;
            IngressBytesTransferred = ingressBytesTransferred;
            EgressBytesTransferred = egressBytesTransferred;
            ConnectionBandwidth = connectionBandwidth;
            SharedKey = sharedKey;
            EnableBgp = enableBgp;
            UsePolicyBasedTrafficSelectors = usePolicyBasedTrafficSelectors;
            IPsecPolicies = iPsecPolicies;
            EnableRateLimiting = enableRateLimiting;
            UseLocalAzureIPAddress = useLocalAzureIPAddress;
            ProvisioningState = provisioningState;
            IngressNatRules = ingressNatRules;
            EgressNatRules = egressNatRules;
        }

        /// <summary> The name of the resource that is unique within a resource group. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Resource type. </summary>
        public string Type { get; }
        /// <summary> Id of the connected vpn site link. </summary>
        internal WritableSubResource VpnSiteLink { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier VpnSiteLinkId
        {
            get => VpnSiteLink is null ? default : VpnSiteLink.Id;
            set
            {
                if (VpnSiteLink is null)
                    VpnSiteLink = new WritableSubResource();
                VpnSiteLink.Id = value;
            }
        }

        /// <summary> Routing weight for vpn connection. </summary>
        public int? RoutingWeight { get; set; }
        /// <summary> Vpn link connection mode. </summary>
        public VpnLinkConnectionMode? VpnLinkConnectionMode { get; set; }
        /// <summary> The connection status. </summary>
        public VpnConnectionStatus? ConnectionStatus { get; }
        /// <summary> Connection protocol used for this connection. </summary>
        public VirtualNetworkGatewayConnectionProtocol? VpnConnectionProtocolType { get; set; }
        /// <summary> Ingress bytes transferred. </summary>
        public long? IngressBytesTransferred { get; }
        /// <summary> Egress bytes transferred. </summary>
        public long? EgressBytesTransferred { get; }
        /// <summary> Expected bandwidth in MBPS. </summary>
        public int? ConnectionBandwidth { get; set; }
        /// <summary> SharedKey for the vpn connection. </summary>
        public string SharedKey { get; set; }
        /// <summary> EnableBgp flag. </summary>
        public bool? EnableBgp { get; set; }
        /// <summary> Enable policy-based traffic selectors. </summary>
        public bool? UsePolicyBasedTrafficSelectors { get; set; }
        /// <summary> The IPSec Policies to be considered by this connection. </summary>
        public IList<IPsecPolicy> IPsecPolicies { get; }
        /// <summary> EnableBgp flag. </summary>
        public bool? EnableRateLimiting { get; set; }
        /// <summary> Use local azure ip to initiate connection. </summary>
        public bool? UseLocalAzureIPAddress { get; set; }
        /// <summary> The provisioning state of the VPN site link connection resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> List of ingress NatRules. </summary>
        public IList<WritableSubResource> IngressNatRules { get; }
        /// <summary> List of egress NatRules. </summary>
        public IList<WritableSubResource> EgressNatRules { get; }
    }
}
