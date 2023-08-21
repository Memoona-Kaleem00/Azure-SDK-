// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> Table's schema. </summary>
    public partial class OperationalInsightsSchema
    {
        /// <summary> Initializes a new instance of OperationalInsightsSchema. </summary>
        public OperationalInsightsSchema()
        {
            Columns = new Core.ChangeTrackingList<OperationalInsightsColumn>();
            StandardColumns = new Core.ChangeTrackingList<OperationalInsightsColumn>();
            Categories = new Core.ChangeTrackingList<string>();
            Labels = new Core.ChangeTrackingList<string>();
            Solutions = new Core.ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of OperationalInsightsSchema. </summary>
        /// <param name="name"> Table name. </param>
        /// <param name="displayName"> Table display name. </param>
        /// <param name="description"> Table description. </param>
        /// <param name="columns"> A list of table custom columns. </param>
        /// <param name="standardColumns"> A list of table standard columns. </param>
        /// <param name="categories"> Table category. </param>
        /// <param name="labels"> Table labels. </param>
        /// <param name="source"> Table's creator. </param>
        /// <param name="tableType"> Table's creator. </param>
        /// <param name="tableSubType"> The subtype describes what APIs can be used to interact with the table, and what features are available against it. </param>
        /// <param name="solutions"> List of solutions the table is affiliated with. </param>
        internal OperationalInsightsSchema(string name, string displayName, string description, IList<OperationalInsightsColumn> columns, IReadOnlyList<OperationalInsightsColumn> standardColumns, IReadOnlyList<string> categories, IReadOnlyList<string> labels, OperationalInsightsTableCreator? source, OperationalInsightsTableType? tableType, OperationalInsightsTableSubType? tableSubType, IReadOnlyList<string> solutions)
        {
            Name = name;
            DisplayName = displayName;
            Description = description;
            Columns = columns;
            StandardColumns = standardColumns;
            Categories = categories;
            Labels = labels;
            Source = source;
            TableType = tableType;
            TableSubType = tableSubType;
            Solutions = solutions;
        }

        /// <summary> Table name. </summary>
        public string Name { get; set; }
        /// <summary> Table display name. </summary>
        public string DisplayName { get; set; }
        /// <summary> Table description. </summary>
        public string Description { get; set; }
        /// <summary> A list of table custom columns. </summary>
        public IList<OperationalInsightsColumn> Columns { get; }
        /// <summary> A list of table standard columns. </summary>
        public IReadOnlyList<OperationalInsightsColumn> StandardColumns { get; }
        /// <summary> Table category. </summary>
        public IReadOnlyList<string> Categories { get; }
        /// <summary> Table labels. </summary>
        public IReadOnlyList<string> Labels { get; }
        /// <summary> Table's creator. </summary>
        public OperationalInsightsTableCreator? Source { get; }
        /// <summary> Table's creator. </summary>
        public OperationalInsightsTableType? TableType { get; }
        /// <summary> The subtype describes what APIs can be used to interact with the table, and what features are available against it. </summary>
        public OperationalInsightsTableSubType? TableSubType { get; }
        /// <summary> List of solutions the table is affiliated with. </summary>
        public IReadOnlyList<string> Solutions { get; }
    }
}
