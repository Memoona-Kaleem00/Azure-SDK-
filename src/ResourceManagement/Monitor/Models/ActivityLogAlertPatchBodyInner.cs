// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Fluent.ServiceBus.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Fluent;
    using Microsoft.Azure.Management.Fluent.ServiceBus;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An activity log alert object for the body of patch operations.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ActivityLogAlertPatchBodyInner
    {
        /// <summary>
        /// Initializes a new instance of the ActivityLogAlertPatchBodyInner
        /// class.
        /// </summary>
        public ActivityLogAlertPatchBodyInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActivityLogAlertPatchBodyInner
        /// class.
        /// </summary>
        /// <param name="tags">Resource tags</param>
        /// <param name="enabled">Indicates whether this activity log alert is
        /// enabled. If an activity log alert is not enabled, then none of its
        /// actions will be activated.</param>
        public ActivityLogAlertPatchBodyInner(IDictionary<string, string> tags = default(IDictionary<string, string>), bool? enabled = default(bool?))
        {
            Tags = tags;
            Enabled = enabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets indicates whether this activity log alert is enabled.
        /// If an activity log alert is not enabled, then none of its actions
        /// will be activated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabled")]
        public bool? Enabled { get; set; }

    }
}
