// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents a url entity. </summary>
    public partial class UrlEntity : EntityData
    {
        /// <summary> Initializes a new instance of UrlEntity. </summary>
        public UrlEntity()
        {
            AdditionalData = new ChangeTrackingDictionary<string, BinaryData>();
            Kind = EntityKind.Url;
        }

        /// <summary> Initializes a new instance of UrlEntity. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The kind of the entity. </param>
        /// <param name="additionalData"> A bag of custom fields that should be part of the entity and will be presented to the user. </param>
        /// <param name="friendlyName"> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </param>
        /// <param name="uri"> A full URL the entity points to. </param>
        internal UrlEntity(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, EntityKind kind, IReadOnlyDictionary<string, BinaryData> additionalData, string friendlyName, Uri uri) : base(id, name, resourceType, systemData, kind)
        {
            AdditionalData = additionalData;
            FriendlyName = friendlyName;
            Uri = uri;
            Kind = kind;
        }

        /// <summary> A bag of custom fields that should be part of the entity and will be presented to the user. </summary>
        public IReadOnlyDictionary<string, BinaryData> AdditionalData { get; }
        /// <summary> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </summary>
        public string FriendlyName { get; }
        /// <summary> A full URL the entity points to. </summary>
        public Uri Uri { get; }
    }
}
