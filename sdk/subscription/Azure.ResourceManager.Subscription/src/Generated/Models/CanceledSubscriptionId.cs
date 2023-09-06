// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Subscription.Models
{
    /// <summary> The ID of the canceled subscription. </summary>
    public partial class CanceledSubscriptionId
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CanceledSubscriptionId"/>. </summary>
        internal CanceledSubscriptionId()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CanceledSubscriptionId"/>. </summary>
        /// <param name="subscriptionId"> The ID of the canceled subscription. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CanceledSubscriptionId(string subscriptionId, Dictionary<string, BinaryData> rawData)
        {
            SubscriptionId = subscriptionId;
            _rawData = rawData;
        }

        /// <summary> The ID of the canceled subscription. </summary>
        public string SubscriptionId { get; }
    }
}
