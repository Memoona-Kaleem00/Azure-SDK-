// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary>
    /// The cluster monitor parameters.
    /// Serialized Name: ClusterMonitoringRequest
    /// </summary>
    public partial class HDInsightClusterEnableClusterMonitoringContent
    {
        /// <summary> Initializes a new instance of HDInsightClusterEnableClusterMonitoringContent. </summary>
        public HDInsightClusterEnableClusterMonitoringContent()
        {
        }

        /// <summary>
        /// The cluster monitor workspace ID.
        /// Serialized Name: ClusterMonitoringRequest.workspaceId
        /// </summary>
        public string WorkspaceId { get; set; }
        /// <summary>
        /// The cluster monitor workspace key.
        /// Serialized Name: ClusterMonitoringRequest.primaryKey
        /// </summary>
        public string PrimaryKey { get; set; }
    }
}
