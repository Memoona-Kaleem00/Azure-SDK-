// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> The updatable properties of the FirewallResource. </summary>
    public partial class FirewallUpdateProperties
    {
        /// <summary> Initializes a new instance of FirewallUpdateProperties. </summary>
        public FirewallUpdateProperties()
        {
            FrontEndSettings = new Core.ChangeTrackingList<FirewallFrontendSetting>();
        }

        /// <summary> panEtag info. </summary>
        public ETag? PanETag { get; set; }
        /// <summary> Network settings. </summary>
        public FirewallNetworkProfile NetworkProfile { get; set; }
        /// <summary> Panorama Managed: Default is False. Default will be CloudSec managed. </summary>
        public FirewallBooleanType? IsPanoramaManaged { get; set; }
        /// <summary> Panorama Configuration. </summary>
        public FirewallPanoramaConfiguration PanoramaConfig { get; set; }
        /// <summary> Associated Rulestack. </summary>
        public RulestackDetails AssociatedRulestack { get; set; }
        /// <summary> DNS settings for Firewall. </summary>
        public FirewallDnsSettings DnsSettings { get; set; }
        /// <summary> Frontend settings for Firewall. </summary>
        public IList<FirewallFrontendSetting> FrontEndSettings { get; }
        /// <summary> Billing plan information. </summary>
        public FirewallBillingPlanInfo PlanData { get; set; }
        /// <summary> Marketplace details. </summary>
        public PanFirewallMarketplaceDetails MarketplaceDetails { get; set; }
    }
}
