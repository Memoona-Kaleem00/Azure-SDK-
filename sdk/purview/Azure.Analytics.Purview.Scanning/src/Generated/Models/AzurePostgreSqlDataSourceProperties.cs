// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The AzurePostgreSqlDataSourceProperties. </summary>
    public partial class AzurePostgreSqlDataSourceProperties : AzurePostgreSqlProperties
    {
        /// <summary> Initializes a new instance of AzurePostgreSqlDataSourceProperties. </summary>
        public AzurePostgreSqlDataSourceProperties()
        {
        }

        /// <summary> Initializes a new instance of AzurePostgreSqlDataSourceProperties. </summary>
        /// <param name="createdAt"></param>
        /// <param name="lastModifiedAt"></param>
        /// <param name="collection"></param>
        /// <param name="resourceGroup"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="location"></param>
        /// <param name="resourceName"></param>
        /// <param name="serverEndpoint"></param>
        /// <param name="port"></param>
        internal AzurePostgreSqlDataSourceProperties(DateTimeOffset? createdAt, DateTimeOffset? lastModifiedAt, DataSourcePropertiesCollection collection, string resourceGroup, string subscriptionId, string location, string resourceName, string serverEndpoint, int? port) : base(createdAt, lastModifiedAt, collection, resourceGroup, subscriptionId, location, resourceName, serverEndpoint, port)
        {
        }
    }
}
