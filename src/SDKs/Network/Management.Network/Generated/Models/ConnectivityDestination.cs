// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Network;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Parameters that define destination of connection.
    /// </summary>
    public partial class ConnectivityDestination
    {
        /// <summary>
        /// Initializes a new instance of the ConnectivityDestination class.
        /// </summary>
        public ConnectivityDestination()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectivityDestination class.
        /// </summary>
        /// <param name="resourceId">The ID of the resource to which a
        /// connection attempt will be made.</param>
        /// <param name="address">The IP address or URI the resource to which a
        /// connection attempt will be made.</param>
        /// <param name="port">Port on which check connectivity will be
        /// performed.</param>
        public ConnectivityDestination(string resourceId = default(string), string address = default(string), int? port = default(int?))
        {
            ResourceId = resourceId;
            Address = address;
            Port = port;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of the resource to which a connection attempt
        /// will be made.
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the IP address or URI the resource to which a
        /// connection attempt will be made.
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets port on which check connectivity will be performed.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }

    }
}
