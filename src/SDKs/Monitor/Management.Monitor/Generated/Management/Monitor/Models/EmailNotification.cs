// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Monitor.Management.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Monitor;
    using Microsoft.Azure.Monitor.Management;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Email notification of an autoscale event.
    /// </summary>
    public partial class EmailNotification
    {
        /// <summary>
        /// Initializes a new instance of the EmailNotification class.
        /// </summary>
        public EmailNotification() { }

        /// <summary>
        /// Initializes a new instance of the EmailNotification class.
        /// </summary>
        /// <param name="sendToSubscriptionAdministrator">a value indicating
        /// whether to send email to subscription administrator.</param>
        /// <param name="sendToSubscriptionCoAdministrators">a value indicating
        /// whether to send email to subscription co-administrators.</param>
        /// <param name="customEmails">the custom e-mails list. This value can
        /// be null or empty, in which case this attribute will be
        /// ignored.</param>
        public EmailNotification(bool? sendToSubscriptionAdministrator = default(bool?), bool? sendToSubscriptionCoAdministrators = default(bool?), IList<string> customEmails = default(IList<string>))
        {
            SendToSubscriptionAdministrator = sendToSubscriptionAdministrator;
            SendToSubscriptionCoAdministrators = sendToSubscriptionCoAdministrators;
            CustomEmails = customEmails;
        }

        /// <summary>
        /// Gets or sets a value indicating whether to send email to
        /// subscription administrator.
        /// </summary>
        [JsonProperty(PropertyName = "sendToSubscriptionAdministrator")]
        public bool? SendToSubscriptionAdministrator { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to send email to
        /// subscription co-administrators.
        /// </summary>
        [JsonProperty(PropertyName = "sendToSubscriptionCoAdministrators")]
        public bool? SendToSubscriptionCoAdministrators { get; set; }

        /// <summary>
        /// Gets or sets the custom e-mails list. This value can be null or
        /// empty, in which case this attribute will be ignored.
        /// </summary>
        [JsonProperty(PropertyName = "customEmails")]
        public IList<string> CustomEmails { get; set; }

    }
}
