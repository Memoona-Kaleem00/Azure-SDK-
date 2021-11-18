// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Metadata patch request body.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class MetadataPatch : ResourceWithEtag
    {
        /// <summary>
        /// Initializes a new instance of the MetadataPatch class.
        /// </summary>
        public MetadataPatch()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetadataPatch class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="systemData">Azure Resource Manager metadata containing
        /// createdBy and modifiedBy information.</param>
        /// <param name="etag">Etag of the azure resource</param>
        /// <param name="contentId">Static ID for the content.  Used to
        /// identify dependencies and content from solutions or community.
        /// Hard-coded/static for out of the box content and solutions. Dynamic
        /// for user-created.  This is the resource name</param>
        /// <param name="parentId">Full parent resource ID of the content item
        /// the metadata is for.  This is the full resource ID including the
        /// scope (subscription and resource group)</param>
        /// <param name="version">Version of the content.  Default and
        /// recommended format is numeric (e.g. 1, 1.0, 1.0.0, 1.0.0.0),
        /// following ARM template best practices.  Can also be any string, but
        /// then we cannot guarantee any version checks</param>
        /// <param name="kind">The kind of content the metadata is for.
        /// Possible values include: 'DataConnector', 'DataType', 'Workbook',
        /// 'WorkbookTemplate', 'Playbook', 'PlaybookTemplate',
        /// 'AnalyticsRuleTemplate', 'AnalyticsRule', 'HuntingQuery',
        /// 'InvestigationQuery', 'Parser', 'Watchlist', 'WatchlistTemplate',
        /// 'Solution'</param>
        /// <param name="source">Source of the content.  This is where/how it
        /// was created.</param>
        /// <param name="author">The creator of the content item.</param>
        /// <param name="support">Support information for the metadata - type,
        /// name, contact information</param>
        /// <param name="dependencies">Dependencies for the content item, what
        /// other content items it requires to work.  Can describe more complex
        /// dependencies using a recursive/nested structure. For a single
        /// dependency an id/kind/version can be supplied or operator/criteria
        /// for complex formats.</param>
        /// <param name="categories">Categories for the solution content
        /// item</param>
        /// <param name="providers">Providers for the solution content
        /// item</param>
        /// <param name="firstPublishDate">first publish date solution content
        /// item</param>
        /// <param name="lastPublishDate">last publish date for the solution
        /// content item</param>
        public MetadataPatch(string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), string etag = default(string), string contentId = default(string), string parentId = default(string), string version = default(string), string kind = default(string), MetadataSource source = default(MetadataSource), MetadataAuthor author = default(MetadataAuthor), MetadataSupport support = default(MetadataSupport), MetadataDependencies dependencies = default(MetadataDependencies), MetadataCategories categories = default(MetadataCategories), IList<string> providers = default(IList<string>), System.DateTime? firstPublishDate = default(System.DateTime?), System.DateTime? lastPublishDate = default(System.DateTime?))
            : base(id, name, type, systemData, etag)
        {
            ContentId = contentId;
            ParentId = parentId;
            Version = version;
            Kind = kind;
            Source = source;
            Author = author;
            Support = support;
            Dependencies = dependencies;
            Categories = categories;
            Providers = providers;
            FirstPublishDate = firstPublishDate;
            LastPublishDate = lastPublishDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets static ID for the content.  Used to identify
        /// dependencies and content from solutions or community.
        /// Hard-coded/static for out of the box content and solutions. Dynamic
        /// for user-created.  This is the resource name
        /// </summary>
        [JsonProperty(PropertyName = "properties.contentId")]
        public string ContentId { get; set; }

        /// <summary>
        /// Gets or sets full parent resource ID of the content item the
        /// metadata is for.  This is the full resource ID including the scope
        /// (subscription and resource group)
        /// </summary>
        [JsonProperty(PropertyName = "properties.parentId")]
        public string ParentId { get; set; }

        /// <summary>
        /// Gets or sets version of the content.  Default and recommended
        /// format is numeric (e.g. 1, 1.0, 1.0.0, 1.0.0.0), following ARM
        /// template best practices.  Can also be any string, but then we
        /// cannot guarantee any version checks
        /// </summary>
        [JsonProperty(PropertyName = "properties.version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the kind of content the metadata is for. Possible
        /// values include: 'DataConnector', 'DataType', 'Workbook',
        /// 'WorkbookTemplate', 'Playbook', 'PlaybookTemplate',
        /// 'AnalyticsRuleTemplate', 'AnalyticsRule', 'HuntingQuery',
        /// 'InvestigationQuery', 'Parser', 'Watchlist', 'WatchlistTemplate',
        /// 'Solution'
        /// </summary>
        [JsonProperty(PropertyName = "properties.kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets source of the content.  This is where/how it was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.source")]
        public MetadataSource Source { get; set; }

        /// <summary>
        /// Gets or sets the creator of the content item.
        /// </summary>
        [JsonProperty(PropertyName = "properties.author")]
        public MetadataAuthor Author { get; set; }

        /// <summary>
        /// Gets or sets support information for the metadata - type, name,
        /// contact information
        /// </summary>
        [JsonProperty(PropertyName = "properties.support")]
        public MetadataSupport Support { get; set; }

        /// <summary>
        /// Gets or sets dependencies for the content item, what other content
        /// items it requires to work.  Can describe more complex dependencies
        /// using a recursive/nested structure. For a single dependency an
        /// id/kind/version can be supplied or operator/criteria for complex
        /// formats.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dependencies")]
        public MetadataDependencies Dependencies { get; set; }

        /// <summary>
        /// Gets or sets categories for the solution content item
        /// </summary>
        [JsonProperty(PropertyName = "properties.categories")]
        public MetadataCategories Categories { get; set; }

        /// <summary>
        /// Gets or sets providers for the solution content item
        /// </summary>
        [JsonProperty(PropertyName = "properties.providers")]
        public IList<string> Providers { get; set; }

        /// <summary>
        /// Gets or sets first publish date solution content item
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "properties.firstPublishDate")]
        public System.DateTime? FirstPublishDate { get; set; }

        /// <summary>
        /// Gets or sets last publish date for the solution content item
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "properties.lastPublishDate")]
        public System.DateTime? LastPublishDate { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Source != null)
            {
                Source.Validate();
            }
            if (Support != null)
            {
                Support.Validate();
            }
        }
    }
}
