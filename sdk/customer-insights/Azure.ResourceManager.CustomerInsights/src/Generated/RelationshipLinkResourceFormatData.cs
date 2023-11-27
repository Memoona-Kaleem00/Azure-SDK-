// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CustomerInsights.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CustomerInsights
{
    /// <summary>
    /// A class representing the RelationshipLinkResourceFormat data model.
    /// The relationship link resource format.
    /// </summary>
    public partial class RelationshipLinkResourceFormatData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="RelationshipLinkResourceFormatData"/>. </summary>
        public RelationshipLinkResourceFormatData()
        {
            DisplayName = new ChangeTrackingDictionary<string, string>();
            Description = new ChangeTrackingDictionary<string, string>();
            Mappings = new ChangeTrackingList<RelationshipLinkFieldMapping>();
            ProfilePropertyReferences = new ChangeTrackingList<ParticipantProfilePropertyReference>();
            RelatedProfilePropertyReferences = new ChangeTrackingList<ParticipantProfilePropertyReference>();
        }

        /// <summary> Initializes a new instance of <see cref="RelationshipLinkResourceFormatData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> Localized display name for the Relationship Link. </param>
        /// <param name="description"> Localized descriptions for the Relationship Link. </param>
        /// <param name="interactionType"> The InteractionType associated with the Relationship Link. </param>
        /// <param name="linkName"> The name of the Relationship Link. </param>
        /// <param name="mappings"> The mappings between Interaction and Relationship fields. </param>
        /// <param name="profilePropertyReferences"> The property references for the Profile of the Relationship. </param>
        /// <param name="provisioningState"> Provisioning state. </param>
        /// <param name="relatedProfilePropertyReferences"> The property references for the Related Profile of the Relationship. </param>
        /// <param name="relationshipName"> The Relationship associated with the Link. </param>
        /// <param name="relationshipGuidId"> The relationship guid id. </param>
        /// <param name="tenantId"> The hub name. </param>
        internal RelationshipLinkResourceFormatData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> displayName, IDictionary<string, string> description, string interactionType, string linkName, IList<RelationshipLinkFieldMapping> mappings, IList<ParticipantProfilePropertyReference> profilePropertyReferences, ProvisioningState? provisioningState, IList<ParticipantProfilePropertyReference> relatedProfilePropertyReferences, string relationshipName, string relationshipGuidId, Guid? tenantId) : base(id, name, resourceType, systemData)
        {
            DisplayName = displayName;
            Description = description;
            InteractionType = interactionType;
            LinkName = linkName;
            Mappings = mappings;
            ProfilePropertyReferences = profilePropertyReferences;
            ProvisioningState = provisioningState;
            RelatedProfilePropertyReferences = relatedProfilePropertyReferences;
            RelationshipName = relationshipName;
            RelationshipGuidId = relationshipGuidId;
            TenantId = tenantId;
        }

        /// <summary> Localized display name for the Relationship Link. </summary>
        public IDictionary<string, string> DisplayName { get; }
        /// <summary> Localized descriptions for the Relationship Link. </summary>
        public IDictionary<string, string> Description { get; }
        /// <summary> The InteractionType associated with the Relationship Link. </summary>
        public string InteractionType { get; set; }
        /// <summary> The name of the Relationship Link. </summary>
        public string LinkName { get; }
        /// <summary> The mappings between Interaction and Relationship fields. </summary>
        public IList<RelationshipLinkFieldMapping> Mappings { get; }
        /// <summary> The property references for the Profile of the Relationship. </summary>
        public IList<ParticipantProfilePropertyReference> ProfilePropertyReferences { get; }
        /// <summary> Provisioning state. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The property references for the Related Profile of the Relationship. </summary>
        public IList<ParticipantProfilePropertyReference> RelatedProfilePropertyReferences { get; }
        /// <summary> The Relationship associated with the Link. </summary>
        public string RelationshipName { get; set; }
        /// <summary> The relationship guid id. </summary>
        public string RelationshipGuidId { get; }
        /// <summary> The hub name. </summary>
        public Guid? TenantId { get; }
    }
}
