// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.NewResources
{
    /// <summary> Resource information. </summary>
    public partial class Resource : Resource<ResourceGroupResourceIdentifier>
    {
        /// <summary> Initializes a new instance of Resource. </summary>
        public Resource()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of Resource. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        internal Resource(ResourceGroupResourceIdentifier id, string name, ResourceType type, string location, IDictionary<string, string> tags) : base(id, name, type)
        {
            Location = location;
            Tags = tags;
        }

        /// <summary> Resource location. </summary>
        public string Location { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
