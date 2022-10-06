// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> security ml analytics settings data sources. </summary>
    public partial class SecurityMLAnalyticsSettingsDataSource
    {
        /// <summary> Initializes a new instance of SecurityMLAnalyticsSettingsDataSource. </summary>
        public SecurityMLAnalyticsSettingsDataSource()
        {
            DataTypes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of SecurityMLAnalyticsSettingsDataSource. </summary>
        /// <param name="connectorId"> The connector id that provides the following data types. </param>
        /// <param name="dataTypes"> The data types used by the security ml analytics settings. </param>
        internal SecurityMLAnalyticsSettingsDataSource(string connectorId, IList<string> dataTypes)
        {
            ConnectorId = connectorId;
            DataTypes = dataTypes;
        }

        /// <summary> The connector id that provides the following data types. </summary>
        public string ConnectorId { get; set; }
        /// <summary> The data types used by the security ml analytics settings. </summary>
        public IList<string> DataTypes { get; }
    }
}
