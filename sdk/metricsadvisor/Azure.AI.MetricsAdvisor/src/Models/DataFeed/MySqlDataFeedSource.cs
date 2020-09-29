﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary>
    /// A Data feed source.
    /// </summary>
    public class MySqlDataFeedSource : DataFeedSource
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MySqlDataFeedSource"/> class.
        /// </summary>
        /// <param name="connectionString"> Database connection string. </param>
        /// <param name="query"> Query script. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionString"/> or <paramref name="query"/> is null. </exception>
        public MySqlDataFeedSource(string connectionString, string query)
            : base(DataFeedSourceType.MySql)
        {
            Argument.AssertNotNullOrEmpty(connectionString, nameof(connectionString));
            Argument.AssertNotNullOrEmpty(query, nameof(query));

            Parameter = new SqlSourceParameter(connectionString, query);
        }
    }
}
