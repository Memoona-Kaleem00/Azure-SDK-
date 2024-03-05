// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Monitor.Query;

namespace Azure.Monitor.Query.Models
{
    /// <summary> The related metadata items for the Log Analytics workspace. </summary>
    internal partial class MetadataWorkspaceRelated
    {
        /// <summary> Initializes a new instance of <see cref="MetadataWorkspaceRelated"/>. </summary>
        internal MetadataWorkspaceRelated()
        {
            Tables = new ChangeTrackingList<string>();
            Solutions = new ChangeTrackingList<string>();
            ResourceTypes = new ChangeTrackingList<string>();
            Functions = new ChangeTrackingList<string>();
            Resources = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="MetadataWorkspaceRelated"/>. </summary>
        /// <param name="tables"> The related tables for the Log Analytics workspace. </param>
        /// <param name="solutions"> The related Log Analytics solutions for the Log Analytics workspace. </param>
        /// <param name="resourceTypes"> The related resource types for the Log Analytics workspace. </param>
        /// <param name="functions"> The related functions for the Log Analytics workspace. </param>
        /// <param name="resources"> The related Azure resources for the Log Analytics workspace. </param>
        internal MetadataWorkspaceRelated(IReadOnlyList<string> tables, IReadOnlyList<string> solutions, IReadOnlyList<string> resourceTypes, IReadOnlyList<string> functions, IReadOnlyList<string> resources)
        {
            Tables = tables;
            Solutions = solutions;
            ResourceTypes = resourceTypes;
            Functions = functions;
            Resources = resources;
        }

        /// <summary> The related tables for the Log Analytics workspace. </summary>
        public IReadOnlyList<string> Tables { get; }
        /// <summary> The related Log Analytics solutions for the Log Analytics workspace. </summary>
        public IReadOnlyList<string> Solutions { get; }
        /// <summary> The related resource types for the Log Analytics workspace. </summary>
        public IReadOnlyList<string> ResourceTypes { get; }
        /// <summary> The related functions for the Log Analytics workspace. </summary>
        public IReadOnlyList<string> Functions { get; }
        /// <summary> The related Azure resources for the Log Analytics workspace. </summary>
        public IReadOnlyList<string> Resources { get; }
    }
}
