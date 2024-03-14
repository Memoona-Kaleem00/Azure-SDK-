// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;

namespace Azure.Communication.JobRouter
{
    /// <summary> An entity for jobs to be routed to. </summary>
    public partial class RouterWorker
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RouterWorker"/>. </summary>
        internal RouterWorker()
        {
            Queues = new ChangeTrackingList<string>();
            _labels = new ChangeTrackingDictionary<string, BinaryData>();
            _tags = new ChangeTrackingDictionary<string, BinaryData>();
            Channels = new ChangeTrackingList<RouterChannel>();
            Offers = new ChangeTrackingList<RouterJobOffer>();
            AssignedJobs = new ChangeTrackingList<RouterWorkerAssignment>();
        }

        /// <summary> Initializes a new instance of <see cref="RouterWorker"/>. </summary>
        /// <param name="eTag"> The entity tag for this resource. </param>
        /// <param name="id"> Id of a worker. </param>
        /// <param name="state"> Current state of a worker. </param>
        /// <param name="queues"> Collection of queue(s) that this worker can receive work from. </param>
        /// <param name="capacity"> The total capacity score this worker has to manage multiple concurrent jobs. </param>
        /// <param name="labels"> A set of key/value pairs that are identifying attributes used by the rules engines to make decisions. Values must be primitive values - number, string, boolean. </param>
        /// <param name="tags"> A set of non-identifying attributes attached to this worker. Values must be primitive values - number, string, boolean. </param>
        /// <param name="channels"> Collection of channel(s) this worker can handle and their impact on the workers capacity. </param>
        /// <param name="offers"> A list of active offers issued to this worker. </param>
        /// <param name="assignedJobs"> A list of assigned jobs attached to this worker. </param>
        /// <param name="loadRatio"> A value indicating the workers capacity. A value of '1' means all capacity is consumed. A value of '0' means no capacity is currently consumed. </param>
        /// <param name="availableForOffers"> A flag indicating this worker is open to receive offers or not. </param>
        /// <param name="maxConcurrentOffers"> If this is set, the worker will only receive up to this many new offers at a time. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RouterWorker(ETag eTag, string id, RouterWorkerState? state, IList<string> queues, int? capacity, IDictionary<string, BinaryData> labels, IDictionary<string, BinaryData> tags, IList<RouterChannel> channels, IReadOnlyList<RouterJobOffer> offers, IReadOnlyList<RouterWorkerAssignment> assignedJobs, double? loadRatio, bool? availableForOffers, int? maxConcurrentOffers, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ETag = eTag;
            Id = id;
            State = state;
            Queues = queues;
            Capacity = capacity;
            _labels = labels;
            _tags = tags;
            Channels = channels;
            Offers = offers;
            AssignedJobs = assignedJobs;
            LoadRatio = loadRatio;
            AvailableForOffers = availableForOffers;
            MaxConcurrentOffers = maxConcurrentOffers;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }
        /// <summary> Id of a worker. </summary>
        public string Id { get; }
        /// <summary> Current state of a worker. </summary>
        public RouterWorkerState? State { get; }
        /// <summary> A list of active offers issued to this worker. </summary>
        public IReadOnlyList<RouterJobOffer> Offers { get; }
        /// <summary> A list of assigned jobs attached to this worker. </summary>
        public IReadOnlyList<RouterWorkerAssignment> AssignedJobs { get; }
        /// <summary> A value indicating the workers capacity. A value of '1' means all capacity is consumed. A value of '0' means no capacity is currently consumed. </summary>
        public double? LoadRatio { get; }
    }
}
