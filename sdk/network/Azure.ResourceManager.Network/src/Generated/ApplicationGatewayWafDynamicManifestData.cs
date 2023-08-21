// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the ApplicationGatewayWafDynamicManifest data model.
    /// Response for ApplicationGatewayWafDynamicManifest API service call.
    /// </summary>
    public partial class ApplicationGatewayWafDynamicManifestData : ResourceData
    {
        /// <summary> Initializes a new instance of ApplicationGatewayWafDynamicManifestData. </summary>
        internal ApplicationGatewayWafDynamicManifestData()
        {
            AvailableRuleSets = new Core.ChangeTrackingList<ApplicationGatewayFirewallManifestRuleSet>();
        }

        /// <summary> Initializes a new instance of ApplicationGatewayWafDynamicManifestData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="availableRuleSets"> The available rulesets. </param>
        /// <param name="ruleSetType"> The type of the web application firewall rule set. </param>
        /// <param name="ruleSetVersion"> The version of the web application firewall rule set type. </param>
        internal ApplicationGatewayWafDynamicManifestData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IReadOnlyList<ApplicationGatewayFirewallManifestRuleSet> availableRuleSets, string ruleSetType, string ruleSetVersion) : base(id, name, resourceType, systemData)
        {
            AvailableRuleSets = availableRuleSets;
            RuleSetType = ruleSetType;
            RuleSetVersion = ruleSetVersion;
        }

        /// <summary> The available rulesets. </summary>
        public IReadOnlyList<ApplicationGatewayFirewallManifestRuleSet> AvailableRuleSets { get; }
        /// <summary> The type of the web application firewall rule set. </summary>
        public string RuleSetType { get; }
        /// <summary> The version of the web application firewall rule set type. </summary>
        public string RuleSetVersion { get; }
    }
}
