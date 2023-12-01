// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    /// <summary> Categories are used to group other metadata entities. </summary>
    internal partial class MetadataCategory
    {
        /// <summary> Initializes a new instance of <see cref="MetadataCategory"/>. </summary>
        /// <param name="id"> The ID of the category. </param>
        /// <param name="displayName"> The display name of the category. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="displayName"/> is null. </exception>
        internal MetadataCategory(string id, string displayName)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(displayName, nameof(displayName));

            Id = id;
            DisplayName = displayName;
        }

        /// <summary> Initializes a new instance of <see cref="MetadataCategory"/>. </summary>
        /// <param name="id"> The ID of the category. </param>
        /// <param name="displayName"> The display name of the category. </param>
        /// <param name="description"> The description of the category. </param>
        /// <param name="related"> The related metadata items for the category. </param>
        internal MetadataCategory(string id, string displayName, string description, MetadataCategoryRelated related)
        {
            Id = id;
            DisplayName = displayName;
            Description = description;
            Related = related;
        }

        /// <summary> The ID of the category. </summary>
        public string Id { get; }
        /// <summary> The display name of the category. </summary>
        public string DisplayName { get; }
        /// <summary> The description of the category. </summary>
        public string Description { get; }
        /// <summary> The related metadata items for the category. </summary>
        public MetadataCategoryRelated Related { get; }
    }
}
