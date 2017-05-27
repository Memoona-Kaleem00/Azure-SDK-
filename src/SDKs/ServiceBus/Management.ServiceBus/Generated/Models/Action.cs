// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServiceBus.Models
{
    using Azure;
    using Management;
    using ServiceBus;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents the filter actions which are allowed for the transformation
    /// of a message that have been matched by a filter expression.
    /// </summary>
    public partial class Action
    {
        /// <summary>
        /// Initializes a new instance of the Action class.
        /// </summary>
        public Action() { }

        /// <summary>
        /// Initializes a new instance of the Action class.
        /// </summary>
        /// <param name="requiresPreprocessing">Value that indicates whether
        /// the rule action requires preprocessing.</param>
        public Action(bool? requiresPreprocessing = default(bool?))
        {
            RequiresPreprocessing = requiresPreprocessing;
        }

        /// <summary>
        /// Gets or sets value that indicates whether the rule action requires
        /// preprocessing.
        /// </summary>
        [JsonProperty(PropertyName = "requiresPreprocessing")]
        public bool? RequiresPreprocessing { get; set; }

    }
}

