// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Monitory.Query.Models
{
    /// <summary> Tables are part of the workspace schema, and contain a list of columns and a reference to other relevant metadata items. </summary>
    public partial class MetadataTable
    {
        /// <summary> Initializes a new instance of MetadataTable. </summary>
        /// <param name="id"> The ID of the table. </param>
        /// <param name="name"> The name of the table. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="name"/> is null. </exception>
        internal MetadataTable(string id, string name)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Id = id;
            Name = name;
            Labels = new ChangeTrackingList<string>();
            Columns = new ChangeTrackingList<MetadataTableColumnsItem>();
        }

        /// <summary> Initializes a new instance of MetadataTable. </summary>
        /// <param name="id"> The ID of the table. </param>
        /// <param name="name"> The name of the table. </param>
        /// <param name="description"> The description of the table. </param>
        /// <param name="timespanColumn"> The column associated with the timespan query parameter for the table. </param>
        /// <param name="labels"> The user defined labels of the table. </param>
        /// <param name="tags"> The tags associated with the table. </param>
        /// <param name="properties"> The properties of the table. </param>
        /// <param name="columns"> The list of columns defined on the table. </param>
        /// <param name="related"> The related metadata items for the table. </param>
        internal MetadataTable(string id, string name, string description, string timespanColumn, IReadOnlyList<string> labels, object tags, object properties, IReadOnlyList<MetadataTableColumnsItem> columns, MetadataTableRelated related)
        {
            Id = id;
            Name = name;
            Description = description;
            TimespanColumn = timespanColumn;
            Labels = labels;
            Tags = tags;
            Properties = properties;
            Columns = columns;
            Related = related;
        }

        /// <summary> The ID of the table. </summary>
        public string Id { get; }
        /// <summary> The name of the table. </summary>
        public string Name { get; }
        /// <summary> The description of the table. </summary>
        public string Description { get; }
        /// <summary> The column associated with the timespan query parameter for the table. </summary>
        public string TimespanColumn { get; }
        /// <summary> The user defined labels of the table. </summary>
        public IReadOnlyList<string> Labels { get; }
        /// <summary> The tags associated with the table. </summary>
        public object Tags { get; }
        /// <summary> The properties of the table. </summary>
        public object Properties { get; }
        /// <summary> The list of columns defined on the table. </summary>
        public IReadOnlyList<MetadataTableColumnsItem> Columns { get; }
        /// <summary> The related metadata items for the table. </summary>
        public MetadataTableRelated Related { get; }
    }
}
