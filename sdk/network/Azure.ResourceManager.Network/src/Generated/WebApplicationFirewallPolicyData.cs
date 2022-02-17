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
    /// <summary> A class representing the WebApplicationFirewallPolicy data model. </summary>
    public partial class WebApplicationFirewallPolicyData : Resource
    {
        /// <summary> Initializes a new instance of WebApplicationFirewallPolicyData. </summary>
        public WebApplicationFirewallPolicyData()
        {
            CustomRules = new ChangeTrackingList<WebApplicationFirewallCustomRule>();
            ApplicationGateways = new ChangeTrackingList<ApplicationGatewayData>();
            HttpListeners = new ChangeTrackingList<WritableSubResource>();
            PathBasedRules = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of WebApplicationFirewallPolicyData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="policySettings"> The PolicySettings for policy. </param>
        /// <param name="customRules"> The custom rules inside the policy. </param>
        /// <param name="applicationGateways"> A collection of references to application gateways. </param>
        /// <param name="provisioningState"> The provisioning state of the web application firewall policy resource. </param>
        /// <param name="resourceState"> Resource status of the policy. </param>
        /// <param name="managedRules"> Describes the managedRules structure. </param>
        /// <param name="httpListeners"> A collection of references to application gateway http listeners. </param>
        /// <param name="pathBasedRules"> A collection of references to application gateway path rules. </param>
        internal WebApplicationFirewallPolicyData(string id, string name, string type, string location, IDictionary<string, string> tags, string etag, PolicySettings policySettings, IList<WebApplicationFirewallCustomRule> customRules, IReadOnlyList<ApplicationGatewayData> applicationGateways, ProvisioningState? provisioningState, WebApplicationFirewallPolicyResourceState? resourceState, ManagedRulesDefinition managedRules, IReadOnlyList<WritableSubResource> httpListeners, IReadOnlyList<WritableSubResource> pathBasedRules) : base(id, name, type, location, tags)
        {
            Etag = etag;
            PolicySettings = policySettings;
            CustomRules = customRules;
            ApplicationGateways = applicationGateways;
            ProvisioningState = provisioningState;
            ResourceState = resourceState;
            ManagedRules = managedRules;
            HttpListeners = httpListeners;
            PathBasedRules = pathBasedRules;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> The PolicySettings for policy. </summary>
        public PolicySettings PolicySettings { get; set; }
        /// <summary> The custom rules inside the policy. </summary>
        public IList<WebApplicationFirewallCustomRule> CustomRules { get; }
        /// <summary> A collection of references to application gateways. </summary>
        public IReadOnlyList<ApplicationGatewayData> ApplicationGateways { get; }
        /// <summary> The provisioning state of the web application firewall policy resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Resource status of the policy. </summary>
        public WebApplicationFirewallPolicyResourceState? ResourceState { get; }
        /// <summary> Describes the managedRules structure. </summary>
        public ManagedRulesDefinition ManagedRules { get; set; }
        /// <summary> A collection of references to application gateway http listeners. </summary>
        public IReadOnlyList<WritableSubResource> HttpListeners { get; }
        /// <summary> A collection of references to application gateway path rules. </summary>
        public IReadOnlyList<WritableSubResource> PathBasedRules { get; }
    }
}
