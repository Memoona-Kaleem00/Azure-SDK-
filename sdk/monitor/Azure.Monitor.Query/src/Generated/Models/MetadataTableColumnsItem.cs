// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Monitor.Query;

namespace Azure.Monitor.Query.Models
{
    /// <summary> The MetadataTableColumnsItem. </summary>
    internal partial class MetadataTableColumnsItem
    {
        /// <summary> Initializes a new instance of <see cref="MetadataTableColumnsItem"/>. </summary>
        /// <param name="name"> The name of the column. </param>
        /// <param name="type"> The data type of the column. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal MetadataTableColumnsItem(string name, MetadataColumnDataType type)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            Type = type;
        }

        /// <summary> Initializes a new instance of <see cref="MetadataTableColumnsItem"/>. </summary>
        /// <param name="name"> The name of the column. </param>
        /// <param name="description"> The description of the column. </param>
        /// <param name="type"> The data type of the column. </param>
        /// <param name="isPreferredFacet"> A flag indicating this column is a preferred facet. </param>
        /// <param name="source"> an indication of the source of the column, used only when multiple workspaces have conflicting definition for the column. </param>
        internal MetadataTableColumnsItem(string name, string description, MetadataColumnDataType type, bool? isPreferredFacet, object source)
        {
            Name = name;
            Description = description;
            Type = type;
            IsPreferredFacet = isPreferredFacet;
            Source = source;
        }

        /// <summary> The name of the column. </summary>
        public string Name { get; }
        /// <summary> The description of the column. </summary>
        public string Description { get; }
        /// <summary> The data type of the column. </summary>
        public MetadataColumnDataType Type { get; }
        /// <summary> A flag indicating this column is a preferred facet. </summary>
        public bool? IsPreferredFacet { get; }
        /// <summary> an indication of the source of the column, used only when multiple workspaces have conflicting definition for the column. </summary>
        public object Source { get; }
    }
}
