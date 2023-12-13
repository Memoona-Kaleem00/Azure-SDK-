// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> Private plans subscriptions. </summary>
    public partial class StopSellSubscriptions
    {
        /// <summary> Initializes a new instance of <see cref="StopSellSubscriptions"/>. </summary>
        public StopSellSubscriptions()
        {
            Subscriptions = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="StopSellSubscriptions"/>. </summary>
        /// <param name="subscriptions"></param>
        internal StopSellSubscriptions(IList<string> subscriptions)
        {
            Subscriptions = subscriptions;
        }

        /// <summary> Gets the subscriptions. </summary>
        public IList<string> Subscriptions { get; }
    }
}
