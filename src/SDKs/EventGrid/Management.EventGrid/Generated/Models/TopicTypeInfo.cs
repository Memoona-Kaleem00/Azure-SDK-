// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.EventGrid.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.EventGrid;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties of a topic type info.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class TopicTypeInfo : Resource
    {
        /// <summary>
        /// Initializes a new instance of the TopicTypeInfo class.
        /// </summary>
        public TopicTypeInfo()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TopicTypeInfo class.
        /// </summary>
        /// <param name="id">Fully qualified identifier of the resource</param>
        /// <param name="name">Name of the resource</param>
        /// <param name="type">Type of the resource</param>
        /// <param name="provider">Namespace of the provider of the topic
        /// type.</param>
        /// <param name="displayName">Display Name for the topic type.</param>
        /// <param name="description">Description of the topic type.</param>
        /// <param name="resourceRegionType">Region type of the resource.
        /// Possible values include: 'RegionalResource',
        /// 'GlobalResource'</param>
        /// <param name="provisioningState">Provisioning state of the topic
        /// type. Possible values include: 'Creating', 'Updating', 'Deleting',
        /// 'Succeeded', 'Canceled', 'Failed'</param>
        public TopicTypeInfo(string id = default(string), string name = default(string), string type = default(string), string provider = default(string), string displayName = default(string), string description = default(string), string resourceRegionType = default(string), string provisioningState = default(string))
            : base(id, name, type)
        {
            Provider = provider;
            DisplayName = displayName;
            Description = description;
            ResourceRegionType = resourceRegionType;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets namespace of the provider of the topic type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or sets display Name for the topic type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets description of the topic type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets region type of the resource. Possible values include:
        /// 'RegionalResource', 'GlobalResource'
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceRegionType")]
        public string ResourceRegionType { get; set; }

        /// <summary>
        /// Gets or sets provisioning state of the topic type. Possible values
        /// include: 'Creating', 'Updating', 'Deleting', 'Succeeded',
        /// 'Canceled', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

    }
}
