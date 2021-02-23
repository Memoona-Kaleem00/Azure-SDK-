// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Filter and return results from input array based on the conditions. </summary>
    public partial class FilterActivity : ControlActivity
    {
        /// <summary> Initializes a new instance of FilterActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="items"> Input array on which filter should be applied. </param>
        /// <param name="condition"> Condition to be used for filtering the input. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="items"/>, or <paramref name="condition"/> is null. </exception>
        public FilterActivity(string name, Expression items, Expression condition) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (items == null)
            {
                throw new ArgumentNullException(nameof(items));
            }
            if (condition == null)
            {
                throw new ArgumentNullException(nameof(condition));
            }

            Items = items;
            Condition = condition;
            Type = "Filter";
        }

        /// <summary> Initializes a new instance of FilterActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="type"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="items"> Input array on which filter should be applied. </param>
        /// <param name="condition"> Condition to be used for filtering the input. </param>
        internal FilterActivity(string name, string type, string description, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, object> additionalProperties, Expression items, Expression condition) : base(name, type, description, dependsOn, userProperties, additionalProperties)
        {
            Items = items;
            Condition = condition;
            Type = type ?? "Filter";
        }

        /// <summary> Input array on which filter should be applied. </summary>
        public Expression Items { get; set; }
        /// <summary> Condition to be used for filtering the input. </summary>
        public Expression Condition { get; set; }
    }
}
