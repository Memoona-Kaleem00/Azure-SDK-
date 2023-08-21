// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    /// <summary>
    /// A class representing the GlobalRulestack data model.
    /// PaloAltoNetworks GlobalRulestack
    /// </summary>
    public partial class GlobalRulestackData : ResourceData
    {
        /// <summary> Initializes a new instance of GlobalRulestackData. </summary>
        /// <param name="location"> Global Location. </param>
        public GlobalRulestackData(AzureLocation location)
        {
            Location = location;
            AssociatedSubscriptions = new Core.ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of GlobalRulestackData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Global Location. </param>
        /// <param name="identity"> The managed service identities assigned to this resource. </param>
        /// <param name="panETag"> PanEtag info. </param>
        /// <param name="panLocation"> Rulestack Location, Required for GlobalRulestacks, Not for LocalRulestacks. </param>
        /// <param name="scope"> Rulestack Type. </param>
        /// <param name="associatedSubscriptions"> subscription scope of global rulestack. </param>
        /// <param name="description"> rulestack description. </param>
        /// <param name="defaultMode"> Mode for default rules creation. </param>
        /// <param name="minAppIdVersion"> minimum version. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="securityServices"> Security Profile. </param>
        internal GlobalRulestackData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation location, ManagedServiceIdentity identity, ETag? panETag, AzureLocation? panLocation, RulestackScopeType? scope, IList<string> associatedSubscriptions, string description, RuleCreationDefaultMode? defaultMode, string minAppIdVersion, FirewallProvisioningState? provisioningState, RulestackSecurityServices securityServices) : base(id, name, resourceType, systemData)
        {
            Location = location;
            Identity = identity;
            PanETag = panETag;
            PanLocation = panLocation;
            Scope = scope;
            AssociatedSubscriptions = associatedSubscriptions;
            Description = description;
            DefaultMode = defaultMode;
            MinAppIdVersion = minAppIdVersion;
            ProvisioningState = provisioningState;
            SecurityServices = securityServices;
        }

        /// <summary> Global Location. </summary>
        public AzureLocation Location { get; set; }
        /// <summary> The managed service identities assigned to this resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> PanEtag info. </summary>
        public ETag? PanETag { get; set; }
        /// <summary> Rulestack Location, Required for GlobalRulestacks, Not for LocalRulestacks. </summary>
        public AzureLocation? PanLocation { get; set; }
        /// <summary> Rulestack Type. </summary>
        public RulestackScopeType? Scope { get; set; }
        /// <summary> subscription scope of global rulestack. </summary>
        public IList<string> AssociatedSubscriptions { get; }
        /// <summary> rulestack description. </summary>
        public string Description { get; set; }
        /// <summary> Mode for default rules creation. </summary>
        public RuleCreationDefaultMode? DefaultMode { get; set; }
        /// <summary> minimum version. </summary>
        public string MinAppIdVersion { get; set; }
        /// <summary> Provisioning state of the resource. </summary>
        public FirewallProvisioningState? ProvisioningState { get; }
        /// <summary> Security Profile. </summary>
        public RulestackSecurityServices SecurityServices { get; set; }
    }
}
