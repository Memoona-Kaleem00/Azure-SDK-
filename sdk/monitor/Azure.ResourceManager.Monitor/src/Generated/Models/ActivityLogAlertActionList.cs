// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> A list of activity log alert actions. </summary>
    internal partial class ActivityLogAlertActionList
    {
        /// <summary> Initializes a new instance of ActivityLogAlertActionList. </summary>
        public ActivityLogAlertActionList()
        {
            ActionGroups = new ChangeTrackingList<ActivityLogAlertActionGroup>();
        }

        /// <summary> Initializes a new instance of ActivityLogAlertActionList. </summary>
        /// <param name="actionGroups"> The list of activity log alerts. </param>
        internal ActivityLogAlertActionList(IList<ActivityLogAlertActionGroup> actionGroups)
        {
            ActionGroups = actionGroups;
        }

        /// <summary> The list of activity log alerts. </summary>
        public IList<ActivityLogAlertActionGroup> ActionGroups { get; }
    }
}
