// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Number of device queue purges is not in allowed range. </summary>
    public partial class QueuePurgesNotInAllowedRange : TimeWindowCustomAlertRule
    {
        /// <summary> Initializes a new instance of QueuePurgesNotInAllowedRange. </summary>
        /// <param name="isEnabled"> Status of the custom alert. </param>
        /// <param name="minThreshold"> The minimum threshold. </param>
        /// <param name="maxThreshold"> The maximum threshold. </param>
        /// <param name="timeWindowSize"> The time window size in iso8601 format. </param>
        public QueuePurgesNotInAllowedRange(bool isEnabled, int minThreshold, int maxThreshold, TimeSpan timeWindowSize) : base(isEnabled, minThreshold, maxThreshold, timeWindowSize)
        {
            RuleType = "QueuePurgesNotInAllowedRange";
        }

        /// <summary> Initializes a new instance of QueuePurgesNotInAllowedRange. </summary>
        /// <param name="displayName"> The display name of the custom alert. </param>
        /// <param name="description"> The description of the custom alert. </param>
        /// <param name="isEnabled"> Status of the custom alert. </param>
        /// <param name="ruleType"> The type of the custom alert rule. </param>
        /// <param name="minThreshold"> The minimum threshold. </param>
        /// <param name="maxThreshold"> The maximum threshold. </param>
        /// <param name="timeWindowSize"> The time window size in iso8601 format. </param>
        internal QueuePurgesNotInAllowedRange(string displayName, string description, bool isEnabled, string ruleType, int minThreshold, int maxThreshold, TimeSpan timeWindowSize) : base(displayName, description, isEnabled, ruleType, minThreshold, maxThreshold, timeWindowSize)
        {
            RuleType = ruleType ?? "QueuePurgesNotInAllowedRange";
        }
    }
}
