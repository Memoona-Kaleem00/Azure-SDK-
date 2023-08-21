// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The DataFeedList. </summary>
    internal partial class DataFeedList
    {
        /// <summary> Initializes a new instance of DataFeedList. </summary>
        internal DataFeedList()
        {
            Value = new Core.ChangeTrackingList<DataFeedDetail>();
        }

        /// <summary> Initializes a new instance of DataFeedList. </summary>
        /// <param name="nextLink"></param>
        /// <param name="value">
        /// Please note <see cref="DataFeedDetail"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureApplicationInsightsDataFeed"/>, <see cref="AzureBlobDataFeed"/>, <see cref="AzureCosmosDBDataFeed"/>, <see cref="AzureDataExplorerDataFeed"/>, <see cref="AzureDataLakeStorageGen2DataFeed"/>, <see cref="AzureEventHubsDataFeed"/>, <see cref="AzureLogAnalyticsDataFeed"/>, <see cref="AzureTableDataFeed"/>, <see cref="InfluxDBDataFeed"/>, <see cref="MongoDBDataFeed"/>, <see cref="MySqlDataFeed"/>, <see cref="PostgreSqlDataFeed"/> and <see cref="SQLServerDataFeed"/>.
        /// </param>
        internal DataFeedList(string nextLink, IReadOnlyList<DataFeedDetail> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
        /// <summary>
        /// Gets the value
        /// Please note <see cref="DataFeedDetail"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureApplicationInsightsDataFeed"/>, <see cref="AzureBlobDataFeed"/>, <see cref="AzureCosmosDBDataFeed"/>, <see cref="AzureDataExplorerDataFeed"/>, <see cref="AzureDataLakeStorageGen2DataFeed"/>, <see cref="AzureEventHubsDataFeed"/>, <see cref="AzureLogAnalyticsDataFeed"/>, <see cref="AzureTableDataFeed"/>, <see cref="InfluxDBDataFeed"/>, <see cref="MongoDBDataFeed"/>, <see cref="MySqlDataFeed"/>, <see cref="PostgreSqlDataFeed"/> and <see cref="SQLServerDataFeed"/>.
        /// </summary>
        public IReadOnlyList<DataFeedDetail> Value { get; }
    }
}
