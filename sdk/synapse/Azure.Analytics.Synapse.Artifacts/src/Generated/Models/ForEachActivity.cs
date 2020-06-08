// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> This activity is used for iterating over a collection and execute given activities. </summary>
    public partial class ForEachActivity : Activity
    {
        /// <summary> Initializes a new instance of ForEachActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="items"> Collection to iterate. </param>
        /// <param name="activities"> List of activities to execute . </param>
        public ForEachActivity(string name, Expression items, IEnumerable<Activity> activities) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (items == null)
            {
                throw new ArgumentNullException(nameof(items));
            }
            if (activities == null)
            {
                throw new ArgumentNullException(nameof(activities));
            }

            Items = items;
            Activities = activities.ToArray();
            Type = "ForEach";
        }

        /// <summary> Initializes a new instance of ForEachActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="type"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="isSequential"> Should the loop be executed in sequence or in parallel (max 50). </param>
        /// <param name="batchCount"> Batch count to be used for controlling the number of parallel execution (when isSequential is set to false). </param>
        /// <param name="items"> Collection to iterate. </param>
        /// <param name="activities"> List of activities to execute . </param>
        internal ForEachActivity(string name, string type, string description, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, object> additionalProperties, bool? isSequential, int? batchCount, Expression items, IList<Activity> activities) : base(name, type, description, dependsOn, userProperties, additionalProperties)
        {
            IsSequential = isSequential;
            BatchCount = batchCount;
            Items = items;
            Activities = activities;
            Type = type ?? "ForEach";
        }

        /// <summary> Should the loop be executed in sequence or in parallel (max 50). </summary>
        public bool? IsSequential { get; set; }
        /// <summary> Batch count to be used for controlling the number of parallel execution (when isSequential is set to false). </summary>
        public int? BatchCount { get; set; }
        /// <summary> Collection to iterate. </summary>
        public Expression Items { get; set; }
        /// <summary> List of activities to execute . </summary>
        public IList<Activity> Activities { get; set; }
    }
}
