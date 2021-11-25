// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Communication.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A notification hub that has been linked to the communication service
    /// </summary>
    public partial class LinkedNotificationHub
    {
        /// <summary>
        /// Initializes a new instance of the LinkedNotificationHub class.
        /// </summary>
        public LinkedNotificationHub()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LinkedNotificationHub class.
        /// </summary>
        /// <param name="resourceId">The resource ID of the notification
        /// hub</param>
        public LinkedNotificationHub(string resourceId = default(string))
        {
            ResourceId = resourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource ID of the notification hub
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }

    }
}
