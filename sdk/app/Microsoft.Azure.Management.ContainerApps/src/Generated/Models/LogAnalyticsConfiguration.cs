// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerApps.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Log analytics configuration
    /// </summary>
    public partial class LogAnalyticsConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the LogAnalyticsConfiguration class.
        /// </summary>
        public LogAnalyticsConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LogAnalyticsConfiguration class.
        /// </summary>
        /// <param name="customerId">Log analytics customer id</param>
        /// <param name="sharedKey">Log analytics customer key</param>
        public LogAnalyticsConfiguration(string customerId = default(string), string sharedKey = default(string))
        {
            CustomerId = customerId;
            SharedKey = sharedKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets log analytics customer id
        /// </summary>
        [JsonProperty(PropertyName = "customerId")]
        public string CustomerId { get; set; }

        /// <summary>
        /// Gets or sets log analytics customer key
        /// </summary>
        [JsonProperty(PropertyName = "sharedKey")]
        public string SharedKey { get; set; }

    }
}
