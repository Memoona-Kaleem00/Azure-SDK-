// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MySql;

namespace Azure.ResourceManager.MySql.Models
{
    /// <summary> A list of wait statistics. </summary>
    internal partial class MySqlWaitStatisticsListResult
    {
        /// <summary> Initializes a new instance of MySqlWaitStatisticsListResult. </summary>
        internal MySqlWaitStatisticsListResult()
        {
            Value = new Core.ChangeTrackingList<MySqlWaitStatisticData>();
        }

        /// <summary> Initializes a new instance of MySqlWaitStatisticsListResult. </summary>
        /// <param name="value"> The list of wait statistics. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal MySqlWaitStatisticsListResult(IReadOnlyList<MySqlWaitStatisticData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of wait statistics. </summary>
        public IReadOnlyList<MySqlWaitStatisticData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
