// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> Describes the body of a purge request for an App Insights Workspace. </summary>
    public partial class WorkspacePurgeBody
    {
        /// <summary> Initializes a new instance of WorkspacePurgeBody. </summary>
        /// <param name="table"> Table from which to purge data. </param>
        /// <param name="filters"> The set of columns and filters (queries) to run over them to purge the resulting data. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="table"/> or <paramref name="filters"/> is null. </exception>
        public WorkspacePurgeBody(string table, IEnumerable<WorkspacePurgeBodyFilters> filters)
        {
            if (table == null)
            {
                throw new ArgumentNullException(nameof(table));
            }
            if (filters == null)
            {
                throw new ArgumentNullException(nameof(filters));
            }

            Table = table;
            Filters = filters.ToList();
        }

        /// <summary> Table from which to purge data. </summary>
        public string Table { get; }
        /// <summary> The set of columns and filters (queries) to run over them to purge the resulting data. </summary>
        public IList<WorkspacePurgeBodyFilters> Filters { get; }
    }
}
