// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.AppService;
    using Microsoft.Azure.Management.AppService.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Hybrid Connection contract. This is used to configure a Hybrid
    /// Connection.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class HybridConnectionInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the HybridConnectionInner class.
        /// </summary>
        public HybridConnectionInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HybridConnectionInner class.
        /// </summary>
        /// <param name="serviceBusNamespace">The name of the Service Bus
        /// namespace.</param>
        /// <param name="relayName">The name of the Service Bus relay.</param>
        /// <param name="relayArmUri">The ARM URI to the Service Bus
        /// relay.</param>
        /// <param name="hostname">The hostname of the endpoint.</param>
        /// <param name="port">The port of the endpoint.</param>
        /// <param name="sendKeyName">The name of the Service Bus key which has
        /// Send permissions. This is used to authenticate to Service
        /// Bus.</param>
        /// <param name="sendKeyValue">The value of the Service Bus key. This
        /// is used to authenticate to Service Bus. In ARM this key will not be
        /// returned
        /// normally, use the POST /listKeys API instead.</param>
        public HybridConnectionInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string serviceBusNamespace = default(string), string relayName = default(string), string relayArmUri = default(string), string hostname = default(string), int? port = default(int?), string sendKeyName = default(string), string sendKeyValue = default(string))
            : base(location, id, name, type, tags)
        {
            ServiceBusNamespace = serviceBusNamespace;
            RelayName = relayName;
            RelayArmUri = relayArmUri;
            Hostname = hostname;
            Port = port;
            SendKeyName = sendKeyName;
            SendKeyValue = sendKeyValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the Service Bus namespace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceBusNamespace")]
        public string ServiceBusNamespace { get; set; }

        /// <summary>
        /// Gets or sets the name of the Service Bus relay.
        /// </summary>
        [JsonProperty(PropertyName = "properties.relayName")]
        public string RelayName { get; set; }

        /// <summary>
        /// Gets or sets the ARM URI to the Service Bus relay.
        /// </summary>
        [JsonProperty(PropertyName = "properties.relayArmUri")]
        public string RelayArmUri { get; set; }

        /// <summary>
        /// Gets or sets the hostname of the endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostname")]
        public string Hostname { get; set; }

        /// <summary>
        /// Gets or sets the port of the endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "properties.port")]
        public int? Port { get; set; }

        /// <summary>
        /// Gets or sets the name of the Service Bus key which has Send
        /// permissions. This is used to authenticate to Service Bus.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sendKeyName")]
        public string SendKeyName { get; set; }

        /// <summary>
        /// Gets or sets the value of the Service Bus key. This is used to
        /// authenticate to Service Bus. In ARM this key will not be returned
        /// normally, use the POST /listKeys API instead.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sendKeyValue")]
        public string SendKeyValue { get; set; }

    }
}
