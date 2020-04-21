// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Data.Tables.Models
{
    /// <summary> The Metrics. </summary>
    public partial class RequestMetrics
    {
        /// <summary> Initializes a new instance of RequestMetrics. </summary>
        /// <param name="enabled"> Indicates whether metrics are enabled for the Queue service. </param>
        public RequestMetrics(bool enabled)
        {
            Enabled = enabled;
        }

        /// <summary> Initializes a new instance of RequestMetrics. </summary>
        /// <param name="version"> The version of Storage Analytics to configure. </param>
        /// <param name="enabled"> Indicates whether metrics are enabled for the Queue service. </param>
        /// <param name="includeAPIs"> Indicates whether metrics should generate summary statistics for called API operations. </param>
        /// <param name="retentionPolicy"> the retention policy. </param>
        internal RequestMetrics(string version, bool enabled, bool? includeAPIs, RetentionPolicy retentionPolicy)
        {
            Version = version;
            Enabled = enabled;
            IncludeAPIs = includeAPIs;
            RetentionPolicy = retentionPolicy;
        }

        /// <summary> The version of Storage Analytics to configure. </summary>
        public string Version { get; set; }
        /// <summary> Indicates whether metrics are enabled for the Queue service. </summary>
        public bool Enabled { get; }
        /// <summary> Indicates whether metrics should generate summary statistics for called API operations. </summary>
        public bool? IncludeAPIs { get; set; }
        /// <summary> the retention policy. </summary>
        public RetentionPolicy RetentionPolicy { get; set; }
    }
}
