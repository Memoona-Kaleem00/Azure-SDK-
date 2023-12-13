// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    /// <summary> The related metadata items for the query. </summary>
    internal partial class MetadataQueryRelated
    {
        /// <summary> Initializes a new instance of <see cref="MetadataQueryRelated"/>. </summary>
        internal MetadataQueryRelated()
        {
            Categories = new ChangeTrackingList<string>();
            Solutions = new ChangeTrackingList<string>();
            ResourceTypes = new ChangeTrackingList<string>();
            Tables = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="MetadataQueryRelated"/>. </summary>
        /// <param name="categories"> The related categories for the query. </param>
        /// <param name="solutions"> The related Log Analytics solutions for the query. </param>
        /// <param name="resourceTypes"> The related resource types for the query. </param>
        /// <param name="tables"> The related tables for the query. </param>
        internal MetadataQueryRelated(IReadOnlyList<string> categories, IReadOnlyList<string> solutions, IReadOnlyList<string> resourceTypes, IReadOnlyList<string> tables)
        {
            Categories = categories;
            Solutions = solutions;
            ResourceTypes = resourceTypes;
            Tables = tables;
        }

        /// <summary> The related categories for the query. </summary>
        public IReadOnlyList<string> Categories { get; }
        /// <summary> The related Log Analytics solutions for the query. </summary>
        public IReadOnlyList<string> Solutions { get; }
        /// <summary> The related resource types for the query. </summary>
        public IReadOnlyList<string> ResourceTypes { get; }
        /// <summary> The related tables for the query. </summary>
        public IReadOnlyList<string> Tables { get; }
    }
}
