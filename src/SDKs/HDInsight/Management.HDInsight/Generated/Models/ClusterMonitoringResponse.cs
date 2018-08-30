// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HDInsight.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Operations Management Suite (OMS) status response
    /// </summary>
    public partial class ClusterMonitoringResponse
    {
        /// <summary>
        /// Initializes a new instance of the ClusterMonitoringResponse class.
        /// </summary>
        public ClusterMonitoringResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClusterMonitoringResponse class.
        /// </summary>
        /// <param name="clusterMonitoringEnabled">The status of the Operations
        /// Management Suite (OMS) on the HDInsight cluster.</param>
        /// <param name="workspaceId">The workspace ID of the Operations
        /// Management Suite (OMS) on the HDInsight cluster.</param>
        public ClusterMonitoringResponse(bool? clusterMonitoringEnabled = default(bool?), string workspaceId = default(string))
        {
            ClusterMonitoringEnabled = clusterMonitoringEnabled;
            WorkspaceId = workspaceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the status of the Operations Management Suite (OMS) on
        /// the HDInsight cluster.
        /// </summary>
        [JsonProperty(PropertyName = "clusterMonitoringEnabled")]
        public bool? ClusterMonitoringEnabled { get; set; }

        /// <summary>
        /// Gets or sets the workspace ID of the Operations Management Suite
        /// (OMS) on the HDInsight cluster.
        /// </summary>
        [JsonProperty(PropertyName = "workspaceId")]
        public string WorkspaceId { get; set; }

    }
}
