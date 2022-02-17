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
    /// <summary> A class representing the VpnSite data model. </summary>
    public partial class VpnSiteData : Resource
    {
        /// <summary> Initializes a new instance of VpnSiteData. </summary>
        public VpnSiteData()
        {
            VpnSiteLinks = new ChangeTrackingList<VpnSiteLinkData>();
        }

        /// <summary> Initializes a new instance of VpnSiteData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="virtualWan"> The VirtualWAN to which the vpnSite belongs. </param>
        /// <param name="deviceProperties"> The device properties. </param>
        /// <param name="iPAddress"> The ip-address for the vpn-site. </param>
        /// <param name="siteKey"> The key for vpn-site that can be used for connections. </param>
        /// <param name="addressSpace"> The AddressSpace that contains an array of IP address ranges. </param>
        /// <param name="bgpProperties"> The set of bgp properties. </param>
        /// <param name="provisioningState"> The provisioning state of the VPN site resource. </param>
        /// <param name="isSecuritySite"> IsSecuritySite flag. </param>
        /// <param name="vpnSiteLinks"> List of all vpn site links. </param>
        /// <param name="o365Policy"> Office365 Policy. </param>
        internal VpnSiteData(string id, string name, string type, string location, IDictionary<string, string> tags, string etag, WritableSubResource virtualWan, DeviceProperties deviceProperties, string iPAddress, string siteKey, AddressSpace addressSpace, BgpSettings bgpProperties, ProvisioningState? provisioningState, bool? isSecuritySite, IList<VpnSiteLinkData> vpnSiteLinks, O365PolicyProperties o365Policy) : base(id, name, type, location, tags)
        {
            Etag = etag;
            VirtualWan = virtualWan;
            DeviceProperties = deviceProperties;
            IPAddress = iPAddress;
            SiteKey = siteKey;
            AddressSpace = addressSpace;
            BgpProperties = bgpProperties;
            ProvisioningState = provisioningState;
            IsSecuritySite = isSecuritySite;
            VpnSiteLinks = vpnSiteLinks;
            O365Policy = o365Policy;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> The VirtualWAN to which the vpnSite belongs. </summary>
        public WritableSubResource VirtualWan { get; set; }
        /// <summary> The device properties. </summary>
        public DeviceProperties DeviceProperties { get; set; }
        /// <summary> The ip-address for the vpn-site. </summary>
        public string IPAddress { get; set; }
        /// <summary> The key for vpn-site that can be used for connections. </summary>
        public string SiteKey { get; set; }
        /// <summary> The AddressSpace that contains an array of IP address ranges. </summary>
        public AddressSpace AddressSpace { get; set; }
        /// <summary> The set of bgp properties. </summary>
        public BgpSettings BgpProperties { get; set; }
        /// <summary> The provisioning state of the VPN site resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> IsSecuritySite flag. </summary>
        public bool? IsSecuritySite { get; set; }
        /// <summary> List of all vpn site links. </summary>
        public IList<VpnSiteLinkData> VpnSiteLinks { get; }
        /// <summary> Office365 Policy. </summary>
        public O365PolicyProperties O365Policy { get; set; }
    }
}
