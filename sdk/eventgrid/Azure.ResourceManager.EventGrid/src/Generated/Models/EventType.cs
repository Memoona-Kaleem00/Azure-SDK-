// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Event Type for a subject under a topic. </summary>
    public partial class EventType : ResourceData
    {
        /// <summary> Initializes a new instance of EventType. </summary>
        public EventType()
        {
        }

        /// <summary> Initializes a new instance of EventType. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> Display name of the event type. </param>
        /// <param name="description"> Description of the event type. </param>
        /// <param name="schemaUri"> Url of the schema for this event type. </param>
        /// <param name="isInDefaultSet"> IsInDefaultSet flag of the event type. </param>
        internal EventType(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string displayName, string description, Uri schemaUri, bool? isInDefaultSet) : base(id, name, resourceType, systemData)
        {
            DisplayName = displayName;
            Description = description;
            SchemaUri = schemaUri;
            IsInDefaultSet = isInDefaultSet;
        }

        /// <summary> Display name of the event type. </summary>
        public string DisplayName { get; set; }
        /// <summary> Description of the event type. </summary>
        public string Description { get; set; }
        /// <summary> Url of the schema for this event type. </summary>
        public Uri SchemaUri { get; set; }
        /// <summary> IsInDefaultSet flag of the event type. </summary>
        public bool? IsInDefaultSet { get; set; }
    }
}
