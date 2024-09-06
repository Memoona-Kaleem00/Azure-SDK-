// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Unknown version of TIObject. </summary>
    internal partial class UnknownTIObject : TIObject
    {
        /// <summary> Initializes a new instance of <see cref="UnknownTIObject"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The kind of the TI object. </param>
        /// <param name="data"> The core STIX object that this TI object represents. </param>
        /// <param name="createdBy"> The UserInfo of the user/entity which originally created this TI object. </param>
        /// <param name="source"> The source name for this TI object. </param>
        /// <param name="firstIngestedOn"> The timestamp for the first time this object was ingested. </param>
        /// <param name="lastIngestedOn"> The timestamp for the last time this object was ingested. </param>
        /// <param name="ingestionRulesVersion"> The ID of the rules version that was active when this TI object was last ingested. </param>
        /// <param name="lastUpdateMethod"> The name of the method/application that initiated the last write to this TI object. </param>
        /// <param name="lastModifiedBy"> The UserInfo of the user/entity which last modified this TI object. </param>
        /// <param name="lastUpdatedOn"> The timestamp for the last time this TI object was updated. </param>
        /// <param name="relationshipHints"> A dictionary used to help follow relationships from this object to other STIX objects. The keys are field names from the STIX object (in the 'data' field), and the values are lists of sources that can be prepended to the object ID in order to efficiently locate the target TI object. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownTIObject(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, TIObjectKind kind, IReadOnlyDictionary<string, BinaryData> data, ThreatIntelligenceUserInfo createdBy, string source, DateTimeOffset? firstIngestedOn, DateTimeOffset? lastIngestedOn, Guid? ingestionRulesVersion, string lastUpdateMethod, ThreatIntelligenceUserInfo lastModifiedBy, DateTimeOffset? lastUpdatedOn, IReadOnlyList<RelationshipHint> relationshipHints, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, kind, data, createdBy, source, firstIngestedOn, lastIngestedOn, ingestionRulesVersion, lastUpdateMethod, lastModifiedBy, lastUpdatedOn, relationshipHints, serializedAdditionalRawData)
        {
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownTIObject"/> for deserialization. </summary>
        internal UnknownTIObject()
        {
        }
    }
}
