// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The CustomRolloutPropertiesStatus. </summary>
    public partial class CustomRolloutPropertiesStatus : CustomRolloutStatus
    {
        /// <summary> Initializes a new instance of CustomRolloutPropertiesStatus. </summary>
        public CustomRolloutPropertiesStatus()
        {
        }

        /// <summary> Initializes a new instance of CustomRolloutPropertiesStatus. </summary>
        /// <param name="completedRegions"></param>
        /// <param name="failedOrSkippedRegions"> Dictionary of &lt;ExtendedErrorInfo&gt;. </param>
        internal CustomRolloutPropertiesStatus(IList<string> completedRegions, IDictionary<string, ExtendedErrorInfo> failedOrSkippedRegions) : base(completedRegions, failedOrSkippedRegions)
        {
        }
    }
}
