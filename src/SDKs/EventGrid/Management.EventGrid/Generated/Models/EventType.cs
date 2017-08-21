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
    /// Event Type for a subject under a topic
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class EventType : Resource
    {
        /// <summary>
        /// Initializes a new instance of the EventType class.
        /// </summary>
        public EventType()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventType class.
        /// </summary>
        /// <param name="id">Fully qualified identifier of the resource</param>
        /// <param name="name">Name of the resource</param>
        /// <param name="type">Type of the resource</param>
        /// <param name="displayName">Display name of the event type.</param>
        /// <param name="description">Description of the event type.</param>
        /// <param name="schemaUrl">Url of the schema for this event
        /// type.</param>
        public EventType(string id = default(string), string name = default(string), string type = default(string), string displayName = default(string), string description = default(string), string schemaUrl = default(string))
            : base(id, name, type)
        {
            DisplayName = displayName;
            Description = description;
            SchemaUrl = schemaUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets display name of the event type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets description of the event type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets url of the schema for this event type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.schemaUrl")]
        public string SchemaUrl { get; set; }

    }
}
