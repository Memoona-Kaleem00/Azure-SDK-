// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MySql.FlexibleServers;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> A list of servers. </summary>
    internal partial class MySqlFlexibleServerListResult
    {
        /// <summary> Initializes a new instance of MySqlFlexibleServerListResult. </summary>
        internal MySqlFlexibleServerListResult()
        {
            Value = new Core.ChangeTrackingList<MySqlFlexibleServerData>();
        }

        /// <summary> Initializes a new instance of MySqlFlexibleServerListResult. </summary>
        /// <param name="value"> The list of servers. </param>
        /// <param name="nextLink"> The link used to get the next page of operations. </param>
        internal MySqlFlexibleServerListResult(IReadOnlyList<MySqlFlexibleServerData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of servers. </summary>
        public IReadOnlyList<MySqlFlexibleServerData> Value { get; }
        /// <summary> The link used to get the next page of operations. </summary>
        public string NextLink { get; }
    }
}
