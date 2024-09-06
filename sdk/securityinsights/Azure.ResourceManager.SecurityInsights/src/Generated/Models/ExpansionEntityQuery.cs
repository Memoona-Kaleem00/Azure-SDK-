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
    /// <summary> Represents Expansion entity query. </summary>
    public partial class ExpansionEntityQuery : SecurityInsightsEntityQueryData
    {
        /// <summary> Initializes a new instance of <see cref="ExpansionEntityQuery"/>. </summary>
        public ExpansionEntityQuery()
        {
            DataSources = new ChangeTrackingList<string>();
            InputFields = new ChangeTrackingList<string>();
            OutputEntityTypes = new ChangeTrackingList<EntityType>();
            Kind = EntityQueryKind.Expansion;
        }

        /// <summary> Initializes a new instance of <see cref="ExpansionEntityQuery"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> the entity query kind. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="dataSources"> List of the data sources that are required to run the query. </param>
        /// <param name="displayName"> The query display name. </param>
        /// <param name="inputEntityType"> The type of the query's source entity. </param>
        /// <param name="inputFields"> List of the fields of the source entity that are required to run the query. </param>
        /// <param name="outputEntityTypes"> List of the desired output types to be constructed from the result. </param>
        /// <param name="queryTemplate"> The template query string to be parsed and formatted. </param>
        internal ExpansionEntityQuery(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, EntityQueryKind kind, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<string> dataSources, string displayName, EntityType? inputEntityType, IList<string> inputFields, IList<EntityType> outputEntityTypes, string queryTemplate) : base(id, name, resourceType, systemData, kind, etag, serializedAdditionalRawData)
        {
            DataSources = dataSources;
            DisplayName = displayName;
            InputEntityType = inputEntityType;
            InputFields = inputFields;
            OutputEntityTypes = outputEntityTypes;
            QueryTemplate = queryTemplate;
            Kind = kind;
        }

        /// <summary> List of the data sources that are required to run the query. </summary>
        [WirePath("properties.dataSources")]
        public IList<string> DataSources { get; }
        /// <summary> The query display name. </summary>
        [WirePath("properties.displayName")]
        public string DisplayName { get; set; }
        /// <summary> The type of the query's source entity. </summary>
        [WirePath("properties.inputEntityType")]
        public EntityType? InputEntityType { get; set; }
        /// <summary> List of the fields of the source entity that are required to run the query. </summary>
        [WirePath("properties.inputFields")]
        public IList<string> InputFields { get; }
        /// <summary> List of the desired output types to be constructed from the result. </summary>
        [WirePath("properties.outputEntityTypes")]
        public IList<EntityType> OutputEntityTypes { get; }
        /// <summary> The template query string to be parsed and formatted. </summary>
        [WirePath("properties.queryTemplate")]
        public string QueryTemplate { get; set; }
    }
}
