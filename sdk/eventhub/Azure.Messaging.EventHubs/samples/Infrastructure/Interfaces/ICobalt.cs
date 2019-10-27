﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;

namespace Azure.Messaging.EventHubs.Samples.Infrastructure.Interfaces
{
    /// <summary>
    ///   Provides a well-known means of executing an EventHubs sample.
    /// </summary>
    ///
    public interface ICobalt
    {
        /// <summary>
        ///   Allows for executing the sample.
        /// </summary>
        ///
        /// <param name="connectionString">The connection string for the Event Hubs namespace that the sample should target.</param>
        /// <param name="eventHubName">The name of the Event Hub, sometimes known as its path, that the sample should run against.</param>
        ///
        public Task RunAsync(string connectionString,
                             string eventHubName);
    }
}
