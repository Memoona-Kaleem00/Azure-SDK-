// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> This activity evaluates an expression and executes activities under the cases property that correspond to the expression evaluation expected in the equals property. </summary>
    public partial class SwitchActivity : Activity
    {
        /// <summary> Initializes a new instance of SwitchActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="on"> An expression that would evaluate to a string or integer. This is used to determine the block of activities in cases that will be executed. </param>
        public SwitchActivity(string name, Expression @on) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (@on == null)
            {
                throw new ArgumentNullException(nameof(@on));
            }

            On = @on;
            Type = "Switch";
        }

        /// <summary> Initializes a new instance of SwitchActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="type"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="on"> An expression that would evaluate to a string or integer. This is used to determine the block of activities in cases that will be executed. </param>
        /// <param name="cases"> List of cases that correspond to expected values of the &apos;on&apos; property. This is an optional property and if not provided, the activity will execute activities provided in defaultActivities. </param>
        /// <param name="defaultActivities"> List of activities to execute if no case condition is satisfied. This is an optional property and if not provided, the activity will exit without any action. </param>
        internal SwitchActivity(string name, string type, string description, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, object> additionalProperties, Expression @on, IList<SwitchCase> cases, IList<Activity> defaultActivities) : base(name, type, description, dependsOn, userProperties, additionalProperties)
        {
            On = @on;
            Cases = cases;
            DefaultActivities = defaultActivities;
            Type = type ?? "Switch";
        }

        /// <summary> An expression that would evaluate to a string or integer. This is used to determine the block of activities in cases that will be executed. </summary>
        public Expression On { get; set; }
        /// <summary> List of cases that correspond to expected values of the &apos;on&apos; property. This is an optional property and if not provided, the activity will execute activities provided in defaultActivities. </summary>
        public IList<SwitchCase> Cases { get; set; }
        /// <summary> List of activities to execute if no case condition is satisfied. This is an optional property and if not provided, the activity will exit without any action. </summary>
        public IList<Activity> DefaultActivities { get; set; }
    }
}
