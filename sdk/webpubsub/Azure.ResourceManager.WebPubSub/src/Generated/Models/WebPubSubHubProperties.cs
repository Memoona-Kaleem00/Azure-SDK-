// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> Properties of a hub. </summary>
    public partial class WebPubSubHubProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="WebPubSubHubProperties"/>. </summary>
        public WebPubSubHubProperties()
        {
            EventHandlers = new ChangeTrackingList<WebPubSubEventHandler>();
        }

        /// <summary> Initializes a new instance of <see cref="WebPubSubHubProperties"/>. </summary>
        /// <param name="eventHandlers"> Event handler of a hub. </param>
        /// <param name="anonymousConnectPolicy"> The settings for configuring if anonymous connections are allowed for this hub: "allow" or "deny". Default to "deny". </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal WebPubSubHubProperties(IList<WebPubSubEventHandler> eventHandlers, string anonymousConnectPolicy, Dictionary<string, BinaryData> rawData)
        {
            EventHandlers = eventHandlers;
            AnonymousConnectPolicy = anonymousConnectPolicy;
            _rawData = rawData;
        }

        /// <summary> Event handler of a hub. </summary>
        public IList<WebPubSubEventHandler> EventHandlers { get; }
        /// <summary> The settings for configuring if anonymous connections are allowed for this hub: "allow" or "deny". Default to "deny". </summary>
        public string AnonymousConnectPolicy { get; set; }
    }
}
