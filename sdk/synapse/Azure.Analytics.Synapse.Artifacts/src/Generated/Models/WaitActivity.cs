// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> This activity suspends pipeline execution for the specified interval. </summary>
    public partial class WaitActivity : ControlActivity
    {
        /// <summary> Initializes a new instance of <see cref="WaitActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="waitTimeInSeconds"> Duration in seconds. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="waitTimeInSeconds"/> is null. </exception>
        public WaitActivity(string name, object waitTimeInSeconds) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(waitTimeInSeconds, nameof(waitTimeInSeconds));

            WaitTimeInSeconds = waitTimeInSeconds;
            Type = "Wait";
        }

        /// <summary> Initializes a new instance of <see cref="WaitActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="type"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="waitTimeInSeconds"> Duration in seconds. </param>
        internal WaitActivity(string name, string type, string description, ActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, object> additionalProperties, object waitTimeInSeconds) : base(name, type, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties)
        {
            WaitTimeInSeconds = waitTimeInSeconds;
            Type = type ?? "Wait";
        }

        /// <summary> Duration in seconds. </summary>
        public object WaitTimeInSeconds { get; set; }
    }
}
