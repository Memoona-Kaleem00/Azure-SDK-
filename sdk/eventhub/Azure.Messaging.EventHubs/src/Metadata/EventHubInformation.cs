﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.Messaging.EventHubs.Metadata
{
    /// <summary>
    ///   A set of information for an Event Hub.
    /// </summary>
    ///
    public sealed class EventHubInformation
    {
        /// <summary>
        ///   The path of the Event Hub, relative to the namespace
        ///   that contains it.
        /// </summary>
        ///
        public string Path { get; }

        /// <summary>
        ///   The date and time, in UTC, at which the Event Hub was created.
        /// </summary>
        ///
        public DateTime CreatedDateUtc { get; }

        /// <summary>
        ///   The number of partitions in the Event Hub.
        /// </summary>
        ///
        public int PartitionCount { get; }

        /// <summary>
        ///   The set of unique identifiers for each partition in the Event Hub.
        /// </summary>
        ///
        public string[] PartitionIds { get; }

        /// <summary>
        ///   The date and time, in UTC, that the information was retrieved from the
        ///   Event Hub.
        /// </summary>
        ///
        public DateTime InformationRetrievalTimeUtc { get; }

        /// <summary>
        ///   Initializes a new instance of the <see cref="EventHubInformation"/> class.
        /// </summary>
        ///
        /// <param name="path">The path of the Event Hub.</param>
        /// <param name="createdUtc">The date and time at which the Event Hub was created.</param>
        /// <param name="partitionCount">The number of paritions in the Event Hub.</param>
        /// <param name="partitionIds">The set of unique identifiers for each partition.</param>
        /// <param name="retrievalTimeUtc">the date and time, in UTC, that the information was retrieved from the serivce; if not provided, the current date/time will be used.</param>
        ///
        internal EventHubInformation(string    path,
                                     DateTime  createdUtc,
                                     int       partitionCount,
                                     string[]  partitionIds,
                                     DateTime? retrievalTimeUtc = null)
        {
            Path = path;
            CreatedDateUtc = createdUtc;
            PartitionCount = partitionCount;
            PartitionIds = partitionIds;
            InformationRetrievalTimeUtc = retrievalTimeUtc ?? DateTime.UtcNow;
        }
    }
}
