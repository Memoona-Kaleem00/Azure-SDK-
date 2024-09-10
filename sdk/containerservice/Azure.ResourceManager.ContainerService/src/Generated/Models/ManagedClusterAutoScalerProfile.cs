// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Parameters to be applied to the cluster-autoscaler when enabled. </summary>
    public partial class ManagedClusterAutoScalerProfile
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

        /// <summary> Initializes a new instance of <see cref="ManagedClusterAutoScalerProfile"/>. </summary>
        public ManagedClusterAutoScalerProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterAutoScalerProfile"/>. </summary>
        /// <param name="balanceSimilarNodeGroups"> Valid values are 'true' and 'false'. </param>
        /// <param name="expander"> If not specified, the default is 'random'. See [expanders](https://github.com/kubernetes/autoscaler/blob/master/cluster-autoscaler/FAQ.md#what-are-expanders) for more information. </param>
        /// <param name="maxEmptyBulkDelete"> The default is 10. </param>
        /// <param name="maxGracefulTerminationSec"> The default is 600. </param>
        /// <param name="maxNodeProvisionTime"> The default is '15m'. Values must be an integer followed by an 'm'. No unit of time other than minutes (m) is supported. </param>
        /// <param name="maxTotalUnreadyPercentage"> The default is 45. The maximum is 100 and the minimum is 0. </param>
        /// <param name="newPodScaleUpDelay"> For scenarios like burst/batch scale where you don't want CA to act before the kubernetes scheduler could schedule all the pods, you can tell CA to ignore unscheduled pods before they're a certain age. The default is '0s'. Values must be an integer followed by a unit ('s' for seconds, 'm' for minutes, 'h' for hours, etc). </param>
        /// <param name="okTotalUnreadyCount"> This must be an integer. The default is 3. </param>
        /// <param name="scanIntervalInSeconds"> The default is '10'. Values must be an integer number of seconds. </param>
        /// <param name="scaleDownDelayAfterAdd"> The default is '10m'. Values must be an integer followed by an 'm'. No unit of time other than minutes (m) is supported. </param>
        /// <param name="scaleDownDelayAfterDelete"> The default is the scan-interval. Values must be an integer followed by an 'm'. No unit of time other than minutes (m) is supported. </param>
        /// <param name="scaleDownDelayAfterFailure"> The default is '3m'. Values must be an integer followed by an 'm'. No unit of time other than minutes (m) is supported. </param>
        /// <param name="scaleDownUnneededTime"> The default is '10m'. Values must be an integer followed by an 'm'. No unit of time other than minutes (m) is supported. </param>
        /// <param name="scaleDownUnreadyTime"> The default is '20m'. Values must be an integer followed by an 'm'. No unit of time other than minutes (m) is supported. </param>
        /// <param name="scaleDownUtilizationThreshold"> The default is '0.5'. </param>
        /// <param name="skipNodesWithLocalStorage"> The default is true. </param>
        /// <param name="skipNodesWithSystemPods"> The default is true. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedClusterAutoScalerProfile(string balanceSimilarNodeGroups, AutoScaleExpander? expander, string maxEmptyBulkDelete, string maxGracefulTerminationSec, string maxNodeProvisionTime, string maxTotalUnreadyPercentage, string newPodScaleUpDelay, string okTotalUnreadyCount, string scanIntervalInSeconds, string scaleDownDelayAfterAdd, string scaleDownDelayAfterDelete, string scaleDownDelayAfterFailure, string scaleDownUnneededTime, string scaleDownUnreadyTime, string scaleDownUtilizationThreshold, string skipNodesWithLocalStorage, string skipNodesWithSystemPods, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            BalanceSimilarNodeGroups = balanceSimilarNodeGroups;
            Expander = expander;
            MaxEmptyBulkDelete = maxEmptyBulkDelete;
            MaxGracefulTerminationSec = maxGracefulTerminationSec;
            MaxNodeProvisionTime = maxNodeProvisionTime;
            MaxTotalUnreadyPercentage = maxTotalUnreadyPercentage;
            NewPodScaleUpDelay = newPodScaleUpDelay;
            OkTotalUnreadyCount = okTotalUnreadyCount;
            ScanIntervalInSeconds = scanIntervalInSeconds;
            ScaleDownDelayAfterAdd = scaleDownDelayAfterAdd;
            ScaleDownDelayAfterDelete = scaleDownDelayAfterDelete;
            ScaleDownDelayAfterFailure = scaleDownDelayAfterFailure;
            ScaleDownUnneededTime = scaleDownUnneededTime;
            ScaleDownUnreadyTime = scaleDownUnreadyTime;
            ScaleDownUtilizationThreshold = scaleDownUtilizationThreshold;
            SkipNodesWithLocalStorage = skipNodesWithLocalStorage;
            SkipNodesWithSystemPods = skipNodesWithSystemPods;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Valid values are 'true' and 'false'. </summary>
        [WirePath("balance-similar-node-groups")]
        public string BalanceSimilarNodeGroups { get; set; }
        /// <summary> If not specified, the default is 'random'. See [expanders](https://github.com/kubernetes/autoscaler/blob/master/cluster-autoscaler/FAQ.md#what-are-expanders) for more information. </summary>
        [WirePath("expander")]
        public AutoScaleExpander? Expander { get; set; }
        /// <summary> The default is 10. </summary>
        [WirePath("max-empty-bulk-delete")]
        public string MaxEmptyBulkDelete { get; set; }
        /// <summary> The default is 600. </summary>
        [WirePath("max-graceful-termination-sec")]
        public string MaxGracefulTerminationSec { get; set; }
        /// <summary> The default is '15m'. Values must be an integer followed by an 'm'. No unit of time other than minutes (m) is supported. </summary>
        [WirePath("max-node-provision-time")]
        public string MaxNodeProvisionTime { get; set; }
        /// <summary> The default is 45. The maximum is 100 and the minimum is 0. </summary>
        [WirePath("max-total-unready-percentage")]
        public string MaxTotalUnreadyPercentage { get; set; }
        /// <summary> For scenarios like burst/batch scale where you don't want CA to act before the kubernetes scheduler could schedule all the pods, you can tell CA to ignore unscheduled pods before they're a certain age. The default is '0s'. Values must be an integer followed by a unit ('s' for seconds, 'm' for minutes, 'h' for hours, etc). </summary>
        [WirePath("new-pod-scale-up-delay")]
        public string NewPodScaleUpDelay { get; set; }
        /// <summary> This must be an integer. The default is 3. </summary>
        [WirePath("ok-total-unready-count")]
        public string OkTotalUnreadyCount { get; set; }
        /// <summary> The default is '10'. Values must be an integer number of seconds. </summary>
        [WirePath("scan-interval")]
        public string ScanIntervalInSeconds { get; set; }
        /// <summary> The default is '10m'. Values must be an integer followed by an 'm'. No unit of time other than minutes (m) is supported. </summary>
        [WirePath("scale-down-delay-after-add")]
        public string ScaleDownDelayAfterAdd { get; set; }
        /// <summary> The default is the scan-interval. Values must be an integer followed by an 'm'. No unit of time other than minutes (m) is supported. </summary>
        [WirePath("scale-down-delay-after-delete")]
        public string ScaleDownDelayAfterDelete { get; set; }
        /// <summary> The default is '3m'. Values must be an integer followed by an 'm'. No unit of time other than minutes (m) is supported. </summary>
        [WirePath("scale-down-delay-after-failure")]
        public string ScaleDownDelayAfterFailure { get; set; }
        /// <summary> The default is '10m'. Values must be an integer followed by an 'm'. No unit of time other than minutes (m) is supported. </summary>
        [WirePath("scale-down-unneeded-time")]
        public string ScaleDownUnneededTime { get; set; }
        /// <summary> The default is '20m'. Values must be an integer followed by an 'm'. No unit of time other than minutes (m) is supported. </summary>
        [WirePath("scale-down-unready-time")]
        public string ScaleDownUnreadyTime { get; set; }
        /// <summary> The default is '0.5'. </summary>
        [WirePath("scale-down-utilization-threshold")]
        public string ScaleDownUtilizationThreshold { get; set; }
        /// <summary> The default is true. </summary>
        [WirePath("skip-nodes-with-local-storage")]
        public string SkipNodesWithLocalStorage { get; set; }
        /// <summary> The default is true. </summary>
        [WirePath("skip-nodes-with-system-pods")]
        public string SkipNodesWithSystemPods { get; set; }
    }
}
