// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Files.Shares.Models
{
    /// <summary> Storage Analytics metrics for file service. </summary>
    public partial class ShareMetrics
    {
        /// <summary> Initializes a new instance of ShareMetrics. </summary>
        /// <param name="version"> The version of Storage Analytics to configure. </param>
        /// <param name="enabled"> Indicates whether metrics are enabled for the File service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public ShareMetrics(string version, bool enabled)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            Version = version;
            Enabled = enabled;
        }

        /// <summary> Initializes a new instance of ShareMetrics. </summary>
        /// <param name="version"> The version of Storage Analytics to configure. </param>
        /// <param name="enabled"> Indicates whether metrics are enabled for the File service. </param>
        /// <param name="includeApis"> Indicates whether metrics should generate summary statistics for called API operations. </param>
        /// <param name="retentionPolicy"> The retention policy. </param>
        internal ShareMetrics(string version, bool enabled, bool? includeApis, ShareRetentionPolicy retentionPolicy)
        {
            Version = version;
            Enabled = enabled;
            IncludeApis = includeApis;
            RetentionPolicy = retentionPolicy;
        }

        /// <summary> The version of Storage Analytics to configure. </summary>
        public string Version { get; set; }
        /// <summary> Indicates whether metrics are enabled for the File service. </summary>
        public bool Enabled { get; set; }
        /// <summary> The retention policy. </summary>
        public ShareRetentionPolicy RetentionPolicy { get; set; }
    }
}
