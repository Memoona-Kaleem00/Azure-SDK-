// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLab.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DevTestLab;
    using Microsoft.Azure.Management.DevTestLab.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A gallery image.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class GalleryImageInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the GalleryImageInner class.
        /// </summary>
        public GalleryImageInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GalleryImageInner class.
        /// </summary>
        /// <param name="author">The author of the gallery image.</param>
        /// <param name="createdDate">The creation date of the gallery
        /// image.</param>
        /// <param name="description">The description of the gallery
        /// image.</param>
        /// <param name="imageReference">The image reference of the gallery
        /// image.</param>
        /// <param name="icon">The icon of the gallery image.</param>
        /// <param name="enabled">Indicates whether this gallery image is
        /// enabled.</param>
        public GalleryImageInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string author = default(string), System.DateTime? createdDate = default(System.DateTime?), string description = default(string), GalleryImageReference imageReference = default(GalleryImageReference), string icon = default(string), bool? enabled = default(bool?))
            : base(location, id, name, type, tags)
        {
            Author = author;
            CreatedDate = createdDate;
            Description = description;
            ImageReference = imageReference;
            Icon = icon;
            Enabled = enabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the author of the gallery image.
        /// </summary>
        [JsonProperty(PropertyName = "properties.author")]
        public string Author { get; set; }

        /// <summary>
        /// Gets the creation date of the gallery image.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdDate")]
        public System.DateTime? CreatedDate { get; private set; }

        /// <summary>
        /// Gets or sets the description of the gallery image.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the image reference of the gallery image.
        /// </summary>
        [JsonProperty(PropertyName = "properties.imageReference")]
        public GalleryImageReference ImageReference { get; set; }

        /// <summary>
        /// Gets or sets the icon of the gallery image.
        /// </summary>
        [JsonProperty(PropertyName = "properties.icon")]
        public string Icon { get; set; }

        /// <summary>
        /// Gets or sets indicates whether this gallery image is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabled")]
        public bool? Enabled { get; set; }

    }
}
