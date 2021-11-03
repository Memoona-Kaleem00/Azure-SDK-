// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DeviceUpdate.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Private link service connection details.
    /// </summary>
    public partial class PrivateLinkServiceConnection
    {
        /// <summary>
        /// Initializes a new instance of the PrivateLinkServiceConnection
        /// class.
        /// </summary>
        public PrivateLinkServiceConnection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateLinkServiceConnection
        /// class.
        /// </summary>
        /// <param name="name">Private link service connection name.</param>
        /// <param name="groupIds">List of group IDs.</param>
        /// <param name="requestMessage">Request message.</param>
        public PrivateLinkServiceConnection(string name = default(string), IList<string> groupIds = default(IList<string>), string requestMessage = default(string))
        {
            Name = name;
            GroupIds = groupIds;
            RequestMessage = requestMessage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets private link service connection name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets list of group IDs.
        /// </summary>
        [JsonProperty(PropertyName = "groupIds")]
        public IList<string> GroupIds { get; set; }

        /// <summary>
        /// Gets or sets request message.
        /// </summary>
        [JsonProperty(PropertyName = "requestMessage")]
        public string RequestMessage { get; set; }

    }
}
