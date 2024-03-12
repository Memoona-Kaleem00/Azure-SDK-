// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.ServiceFabric;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary>
    /// Defines a health policy used to evaluate the health of the cluster or of a cluster node.
    ///
    /// </summary>
    public partial class ClusterHealthPolicy
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ClusterHealthPolicy"/>. </summary>
        public ClusterHealthPolicy()
        {
            ApplicationHealthPolicies = new ChangeTrackingDictionary<string, ApplicationHealthPolicy>();
        }

        /// <summary> Initializes a new instance of <see cref="ClusterHealthPolicy"/>. </summary>
        /// <param name="maxPercentUnhealthyNodes">
        /// The maximum allowed percentage of unhealthy nodes before reporting an error. For example, to allow 10% of nodes to be unhealthy, this value would be 10.
        ///
        /// The percentage represents the maximum tolerated percentage of nodes that can be unhealthy before the cluster is considered in error.
        /// If the percentage is respected but there is at least one unhealthy node, the health is evaluated as Warning.
        /// The percentage is calculated by dividing the number of unhealthy nodes over the total number of nodes in the cluster.
        /// The computation rounds up to tolerate one failure on small numbers of nodes. Default percentage is zero.
        ///
        /// In large clusters, some nodes will always be down or out for repairs, so this percentage should be configured to tolerate that.
        ///
        /// </param>
        /// <param name="maxPercentUnhealthyApplications">
        /// The maximum allowed percentage of unhealthy applications before reporting an error. For example, to allow 10% of applications to be unhealthy, this value would be 10.
        ///
        /// The percentage represents the maximum tolerated percentage of applications that can be unhealthy before the cluster is considered in error.
        /// If the percentage is respected but there is at least one unhealthy application, the health is evaluated as Warning.
        /// This is calculated by dividing the number of unhealthy applications over the total number of application instances in the cluster, excluding applications of application types that are included in the ApplicationTypeHealthPolicyMap.
        /// The computation rounds up to tolerate one failure on small numbers of applications. Default percentage is zero.
        ///
        /// </param>
        /// <param name="applicationHealthPolicies"> Defines the application health policy map used to evaluate the health of an application or one of its children entities. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ClusterHealthPolicy(int? maxPercentUnhealthyNodes, int? maxPercentUnhealthyApplications, IDictionary<string, ApplicationHealthPolicy> applicationHealthPolicies, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MaxPercentUnhealthyNodes = maxPercentUnhealthyNodes;
            MaxPercentUnhealthyApplications = maxPercentUnhealthyApplications;
            ApplicationHealthPolicies = applicationHealthPolicies;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The maximum allowed percentage of unhealthy nodes before reporting an error. For example, to allow 10% of nodes to be unhealthy, this value would be 10.
        ///
        /// The percentage represents the maximum tolerated percentage of nodes that can be unhealthy before the cluster is considered in error.
        /// If the percentage is respected but there is at least one unhealthy node, the health is evaluated as Warning.
        /// The percentage is calculated by dividing the number of unhealthy nodes over the total number of nodes in the cluster.
        /// The computation rounds up to tolerate one failure on small numbers of nodes. Default percentage is zero.
        ///
        /// In large clusters, some nodes will always be down or out for repairs, so this percentage should be configured to tolerate that.
        ///
        /// </summary>
        public int? MaxPercentUnhealthyNodes { get; set; }
        /// <summary>
        /// The maximum allowed percentage of unhealthy applications before reporting an error. For example, to allow 10% of applications to be unhealthy, this value would be 10.
        ///
        /// The percentage represents the maximum tolerated percentage of applications that can be unhealthy before the cluster is considered in error.
        /// If the percentage is respected but there is at least one unhealthy application, the health is evaluated as Warning.
        /// This is calculated by dividing the number of unhealthy applications over the total number of application instances in the cluster, excluding applications of application types that are included in the ApplicationTypeHealthPolicyMap.
        /// The computation rounds up to tolerate one failure on small numbers of applications. Default percentage is zero.
        ///
        /// </summary>
        public int? MaxPercentUnhealthyApplications { get; set; }
        /// <summary> Defines the application health policy map used to evaluate the health of an application or one of its children entities. </summary>
        public IDictionary<string, ApplicationHealthPolicy> ApplicationHealthPolicies { get; }
    }
}
