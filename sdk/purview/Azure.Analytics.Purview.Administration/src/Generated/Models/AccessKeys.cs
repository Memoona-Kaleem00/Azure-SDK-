// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Purview.Administration.Models
{
    /// <summary> The Account access keys. </summary>
    public partial class AccessKeys
    {
        /// <summary> Initializes a new instance of AccessKeys. </summary>
        internal AccessKeys()
        {
        }

        /// <summary> Initializes a new instance of AccessKeys. </summary>
        /// <param name="atlasKafkaPrimaryEndpoint"> Gets or sets the primary connection string. </param>
        /// <param name="atlasKafkaSecondaryEndpoint"> Gets or sets the secondary connection string. </param>
        internal AccessKeys(string atlasKafkaPrimaryEndpoint, string atlasKafkaSecondaryEndpoint)
        {
            AtlasKafkaPrimaryEndpoint = atlasKafkaPrimaryEndpoint;
            AtlasKafkaSecondaryEndpoint = atlasKafkaSecondaryEndpoint;
        }

        /// <summary> Gets or sets the primary connection string. </summary>
        public string AtlasKafkaPrimaryEndpoint { get; }
        /// <summary> Gets or sets the secondary connection string. </summary>
        public string AtlasKafkaSecondaryEndpoint { get; }
    }
}
