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
    /// <summary> Represents Activity entity query. </summary>
    public partial class ActivityCustomEntityQuery : SecurityInsightsEntityQueryCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of <see cref="ActivityCustomEntityQuery"/>. </summary>
        public ActivityCustomEntityQuery()
        {
            RequiredInputFieldsSets = new ChangeTrackingList<IList<string>>();
            EntitiesFilter = new ChangeTrackingDictionary<string, IList<string>>();
            Kind = CustomEntityQueryKind.Activity;
        }

        /// <summary> Initializes a new instance of <see cref="ActivityCustomEntityQuery"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> the entity query kind. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="title"> The entity query title. </param>
        /// <param name="content"> The entity query content to display in timeline. </param>
        /// <param name="description"> The entity query description. </param>
        /// <param name="queryDefinitions"> The Activity query definitions. </param>
        /// <param name="inputEntityType"> The type of the query's source entity. </param>
        /// <param name="requiredInputFieldsSets"> List of the fields of the source entity that are required to run the query. </param>
        /// <param name="entitiesFilter"> The query applied only to entities matching to all filters. </param>
        /// <param name="templateName"> The template id this activity was created from. </param>
        /// <param name="isEnabled"> Determines whether this activity is enabled or disabled. </param>
        /// <param name="createdOn"> The time the activity was created. </param>
        /// <param name="lastModifiedOn"> The last time the activity was updated. </param>
        internal ActivityCustomEntityQuery(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, CustomEntityQueryKind kind, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData, string title, string content, string description, ActivityEntityQueriesPropertiesQueryDefinitions queryDefinitions, EntityType? inputEntityType, IList<IList<string>> requiredInputFieldsSets, IDictionary<string, IList<string>> entitiesFilter, string templateName, bool? isEnabled, DateTimeOffset? createdOn, DateTimeOffset? lastModifiedOn) : base(id, name, resourceType, systemData, kind, etag, serializedAdditionalRawData)
        {
            Title = title;
            Content = content;
            Description = description;
            QueryDefinitions = queryDefinitions;
            InputEntityType = inputEntityType;
            RequiredInputFieldsSets = requiredInputFieldsSets;
            EntitiesFilter = entitiesFilter;
            TemplateName = templateName;
            IsEnabled = isEnabled;
            CreatedOn = createdOn;
            LastModifiedOn = lastModifiedOn;
            Kind = kind;
        }

        /// <summary> The entity query title. </summary>
        [WirePath("properties.title")]
        public string Title { get; set; }
        /// <summary> The entity query content to display in timeline. </summary>
        [WirePath("properties.content")]
        public string Content { get; set; }
        /// <summary> The entity query description. </summary>
        [WirePath("properties.description")]
        public string Description { get; set; }
        /// <summary> The Activity query definitions. </summary>
        internal ActivityEntityQueriesPropertiesQueryDefinitions QueryDefinitions { get; set; }
        /// <summary> The Activity query to run on a given entity. </summary>
        [WirePath("properties.queryDefinitions.query")]
        public string Query
        {
            get => QueryDefinitions is null ? default : QueryDefinitions.Query;
            set
            {
                if (QueryDefinitions is null)
                    QueryDefinitions = new ActivityEntityQueriesPropertiesQueryDefinitions();
                QueryDefinitions.Query = value;
            }
        }

        /// <summary> The type of the query's source entity. </summary>
        [WirePath("properties.inputEntityType")]
        public EntityType? InputEntityType { get; set; }
        /// <summary> List of the fields of the source entity that are required to run the query. </summary>
        [WirePath("properties.requiredInputFieldsSets")]
        public IList<IList<string>> RequiredInputFieldsSets { get; }
        /// <summary> The query applied only to entities matching to all filters. </summary>
        [WirePath("properties.entitiesFilter")]
        public IDictionary<string, IList<string>> EntitiesFilter { get; }
        /// <summary> The template id this activity was created from. </summary>
        [WirePath("properties.templateName")]
        public string TemplateName { get; set; }
        /// <summary> Determines whether this activity is enabled or disabled. </summary>
        [WirePath("properties.enabled")]
        public bool? IsEnabled { get; set; }
        /// <summary> The time the activity was created. </summary>
        [WirePath("properties.createdTimeUtc")]
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The last time the activity was updated. </summary>
        [WirePath("properties.lastModifiedTimeUtc")]
        public DateTimeOffset? LastModifiedOn { get; }
    }
}
