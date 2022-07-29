// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Redis.Models
{
    /// <summary> Properties of upgrade notification. </summary>
    public partial class RedisUpgradeNotification
    {
        /// <summary> Initializes a new instance of RedisUpgradeNotification. </summary>
        internal RedisUpgradeNotification()
        {
            UpsellNotification = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of RedisUpgradeNotification. </summary>
        /// <param name="name"> Name of upgrade notification. </param>
        /// <param name="timestamp"> Timestamp when upgrade notification occurred. </param>
        /// <param name="upsellNotification"> Details about this upgrade notification. </param>
        internal RedisUpgradeNotification(string name, DateTimeOffset? timestamp, IReadOnlyDictionary<string, string> upsellNotification)
        {
            Name = name;
            Timestamp = timestamp;
            UpsellNotification = upsellNotification;
        }

        /// <summary> Name of upgrade notification. </summary>
        public string Name { get; }
        /// <summary> Timestamp when upgrade notification occurred. </summary>
        public DateTimeOffset? Timestamp { get; }
        /// <summary> Details about this upgrade notification. </summary>
        public IReadOnlyDictionary<string, string> UpsellNotification { get; }
    }
}
