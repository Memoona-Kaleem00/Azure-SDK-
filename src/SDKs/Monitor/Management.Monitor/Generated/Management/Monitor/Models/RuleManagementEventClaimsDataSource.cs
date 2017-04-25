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
    using System.Linq;

    /// <summary>
    /// The claims for a rule management event data source.
    /// </summary>
    public partial class RuleManagementEventClaimsDataSource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RuleManagementEventClaimsDataSource class.
        /// </summary>
        public RuleManagementEventClaimsDataSource() { }

        /// <summary>
        /// Initializes a new instance of the
        /// RuleManagementEventClaimsDataSource class.
        /// </summary>
        /// <param name="emailAddress">the email address.</param>
        public RuleManagementEventClaimsDataSource(string emailAddress = default(string))
        {
            EmailAddress = emailAddress;
        }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        [JsonProperty(PropertyName = "emailAddress")]
        public string EmailAddress { get; set; }

    }
}
