// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary>
    /// Describes an event grid input data source that contains stream data.
    /// Serialized Name: EventGridStreamInputDataSource
    /// </summary>
    public partial class EventGridStreamInputDataSource : StreamInputDataSource
    {
        /// <summary> Initializes a new instance of EventGridStreamInputDataSource. </summary>
        public EventGridStreamInputDataSource()
        {
            StorageAccounts = new ChangeTrackingList<StorageAccount>();
            EventTypes = new ChangeTrackingList<string>();
            StreamInputDataSourceType = "Microsoft.EventGrid/EventSubscriptions";
        }

        /// <summary> Initializes a new instance of EventGridStreamInputDataSource. </summary>
        /// <param name="streamInputDataSourceType">
        /// Indicates the type of input data source containing stream data. Required on PUT (CreateOrReplace) requests.
        /// Serialized Name: StreamInputDataSource.type
        /// </param>
        /// <param name="subscriber">
        /// Subscribers for the Event Grid. Currently only EventHub Subscriber is supported.
        /// Serialized Name: EventGridStreamInputDataSource.properties.subscriber
        /// </param>
        /// <param name="schema">
        /// Indicates the Event Grid schema type.
        /// Serialized Name: EventGridStreamInputDataSource.properties.schema
        /// </param>
        /// <param name="storageAccounts">
        /// A list of one or more Azure Storage accounts. Required on PUT (CreateOrReplace) requests.
        /// Serialized Name: EventGridStreamInputDataSource.properties.storageAccounts
        /// </param>
        /// <param name="eventTypes">
        /// List of Event Types that are supported by the Event Grid adapter.
        /// Serialized Name: EventGridStreamInputDataSource.properties.eventTypes
        /// </param>
        internal EventGridStreamInputDataSource(string streamInputDataSourceType, EventHubV2StreamInputDataSource subscriber, EventGridEventSchemaType? schema, IList<StorageAccount> storageAccounts, IList<string> eventTypes) : base(streamInputDataSourceType)
        {
            Subscriber = subscriber;
            Schema = schema;
            StorageAccounts = storageAccounts;
            EventTypes = eventTypes;
            StreamInputDataSourceType = streamInputDataSourceType ?? "Microsoft.EventGrid/EventSubscriptions";
        }

        /// <summary>
        /// Subscribers for the Event Grid. Currently only EventHub Subscriber is supported.
        /// Serialized Name: EventGridStreamInputDataSource.properties.subscriber
        /// </summary>
        public EventHubV2StreamInputDataSource Subscriber { get; set; }
        /// <summary>
        /// Indicates the Event Grid schema type.
        /// Serialized Name: EventGridStreamInputDataSource.properties.schema
        /// </summary>
        public EventGridEventSchemaType? Schema { get; set; }
        /// <summary>
        /// A list of one or more Azure Storage accounts. Required on PUT (CreateOrReplace) requests.
        /// Serialized Name: EventGridStreamInputDataSource.properties.storageAccounts
        /// </summary>
        public IList<StorageAccount> StorageAccounts { get; }
        /// <summary>
        /// List of Event Types that are supported by the Event Grid adapter.
        /// Serialized Name: EventGridStreamInputDataSource.properties.eventTypes
        /// </summary>
        public IList<string> EventTypes { get; }
    }
}
