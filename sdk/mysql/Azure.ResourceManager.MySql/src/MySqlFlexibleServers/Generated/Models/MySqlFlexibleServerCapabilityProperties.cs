// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> Location capabilities. </summary>
    public partial class MySqlFlexibleServerCapabilityProperties
    {
        /// <summary> Initializes a new instance of MySqlFlexibleServerCapabilityProperties. </summary>
        internal MySqlFlexibleServerCapabilityProperties()
        {
            SupportedHAMode = new Core.ChangeTrackingList<string>();
            SupportedGeoBackupRegions = new Core.ChangeTrackingList<string>();
            SupportedFlexibleServerEditions = new Core.ChangeTrackingList<MySqlFlexibleServerEditionCapability>();
        }

        /// <summary> Initializes a new instance of MySqlFlexibleServerCapabilityProperties. </summary>
        /// <param name="zone"> zone name. </param>
        /// <param name="supportedHAMode"> Supported high availability mode. </param>
        /// <param name="supportedGeoBackupRegions"> supported geo backup regions. </param>
        /// <param name="supportedFlexibleServerEditions"> A list of supported flexible server editions. </param>
        internal MySqlFlexibleServerCapabilityProperties(string zone, IReadOnlyList<string> supportedHAMode, IReadOnlyList<string> supportedGeoBackupRegions, IReadOnlyList<MySqlFlexibleServerEditionCapability> supportedFlexibleServerEditions)
        {
            Zone = zone;
            SupportedHAMode = supportedHAMode;
            SupportedGeoBackupRegions = supportedGeoBackupRegions;
            SupportedFlexibleServerEditions = supportedFlexibleServerEditions;
        }

        /// <summary> zone name. </summary>
        public string Zone { get; }
        /// <summary> Supported high availability mode. </summary>
        public IReadOnlyList<string> SupportedHAMode { get; }
        /// <summary> supported geo backup regions. </summary>
        public IReadOnlyList<string> SupportedGeoBackupRegions { get; }
        /// <summary> A list of supported flexible server editions. </summary>
        public IReadOnlyList<MySqlFlexibleServerEditionCapability> SupportedFlexibleServerEditions { get; }
    }
}
