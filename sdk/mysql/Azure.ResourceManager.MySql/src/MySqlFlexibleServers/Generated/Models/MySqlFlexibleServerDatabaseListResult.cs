// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MySql.FlexibleServers;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> A List of databases. </summary>
    internal partial class MySqlFlexibleServerDatabaseListResult
    {
        /// <summary> Initializes a new instance of MySqlFlexibleServerDatabaseListResult. </summary>
        internal MySqlFlexibleServerDatabaseListResult()
        {
            Value = new Core.ChangeTrackingList<MySqlFlexibleServerDatabaseData>();
        }

        /// <summary> Initializes a new instance of MySqlFlexibleServerDatabaseListResult. </summary>
        /// <param name="value"> The list of databases housed in a server. </param>
        /// <param name="nextLink"> The link used to get the next page of operations. </param>
        internal MySqlFlexibleServerDatabaseListResult(IReadOnlyList<MySqlFlexibleServerDatabaseData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of databases housed in a server. </summary>
        public IReadOnlyList<MySqlFlexibleServerDatabaseData> Value { get; }
        /// <summary> The link used to get the next page of operations. </summary>
        public string NextLink { get; }
    }
}
