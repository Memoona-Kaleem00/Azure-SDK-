// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An alert action.
    /// </summary>
    public partial class MetricAlertAction
    {
        /// <summary>
        /// Initializes a new instance of the MetricAlertAction class.
        /// </summary>
        public MetricAlertAction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricAlertAction class.
        /// </summary>
        /// <param name="actionGroupId">the id of the action group to
        /// use.</param>
        public MetricAlertAction(string actionGroupId = default(string), IDictionary<string, string> webhookProperties = default(IDictionary<string, string>))
        {
            ActionGroupId = actionGroupId;
            WebhookProperties = webhookProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the id of the action group to use.
        /// </summary>
        [JsonProperty(PropertyName = "actionGroupId")]
        public string ActionGroupId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "webhookProperties")]
        public IDictionary<string, string> WebhookProperties { get; set; }

    }
}
