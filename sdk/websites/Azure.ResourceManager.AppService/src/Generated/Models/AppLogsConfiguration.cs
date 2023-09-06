// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The AppLogsConfiguration. </summary>
    public partial class AppLogsConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AppLogsConfiguration"/>. </summary>
        public AppLogsConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppLogsConfiguration"/>. </summary>
        /// <param name="destination"></param>
        /// <param name="logAnalyticsConfiguration"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AppLogsConfiguration(string destination, LogAnalyticsConfiguration logAnalyticsConfiguration, Dictionary<string, BinaryData> rawData)
        {
            Destination = destination;
            LogAnalyticsConfiguration = logAnalyticsConfiguration;
            _rawData = rawData;
        }

        /// <summary> Gets or sets the destination. </summary>
        public string Destination { get; set; }
        /// <summary> Gets or sets the log analytics configuration. </summary>
        public LogAnalyticsConfiguration LogAnalyticsConfiguration { get; set; }
    }
}
