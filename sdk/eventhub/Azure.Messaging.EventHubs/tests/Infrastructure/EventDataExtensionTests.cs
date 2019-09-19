﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Azure.Messaging.EventHubs.Tests
{
    /// <summary>
    ///   The suite of tests for the <see cref="EventDataExtensions" />
    ///   class.
    /// </summary>
    ///
    [TestFixture]
    public class EventDataExtensionsTests
    {
        /// <summary>
        ///   Verifies functionality of the <see cref="EventDataExtensions.IsEquivalentTo" /> test
        ///   helper.
        /// </summary>
        ///
        [Test]
        public void IsEquivalentToDetectsDifferentBodies()
        {
            var firstEvent = new EventData(new byte[] { 0x22, 0x44 });
            var secondEvent = new EventData(new byte[] { 0x11, 0x33 });

            Assert.That(firstEvent.IsEquivalentTo(secondEvent), Is.False);
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="EventDataExtensions.IsEquivalentTo" /> test
        ///   helper.
        /// </summary>
        ///
        [Test]
        public void IsEquivalentToDetectsDifferentDifferentOffset()
        {
            var firstEvent = new EventData(
                 eventBody: new byte[] { 0x22, 0x44 },
                 offset: 1,
                 partitionKey: "hello",
                 systemProperties: new Dictionary<string, object> { { "test", new object() } },
                 lastPartitionSequenceNumber: 123,
                 lastPartitionOffset: 456,
                 lastPartitionEnqueuedTime: DateTimeOffset.Parse("2015-10-27T00:00:00Z"));

            var secondEvent = new EventData(
                eventBody: new byte[] { 0x22, 0x44 },
                offset: 111,
                partitionKey: "hello",
                systemProperties: new Dictionary<string, object> { { "test", new object() } },
                lastPartitionSequenceNumber: 123,
                lastPartitionOffset: 456,
                lastPartitionEnqueuedTime: DateTimeOffset.Parse("2015-10-27T00:00:00Z"));

            Assert.That(firstEvent.IsEquivalentTo(secondEvent, true), Is.False);
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="EventDataExtensions.IsEquivalentTo" /> test
        ///   helper.
        /// </summary>
        ///
        [Test]
        public void IsEquivalentToDetectsDifferentDifferentSequenceNumbers()
        {
            var firstEvent = new EventData(
                 eventBody: new byte[] { 0x22, 0x44 },
                 offset: 1,
                 partitionKey: "hello",
                 systemProperties: new Dictionary<string, object> { { "test", new object() } },
                 lastPartitionSequenceNumber: 1,
                 lastPartitionOffset: 456,
                 lastPartitionEnqueuedTime: DateTimeOffset.Parse("2015-10-27T00:00:00Z"));

            var secondEvent = new EventData(
                eventBody: new byte[] { 0x22, 0x44 },
                offset: 1,
                partitionKey: "hello",
                systemProperties: new Dictionary<string, object> { { "test", new object() } },
                lastPartitionSequenceNumber: 123,
                lastPartitionOffset: 456,
                lastPartitionEnqueuedTime: DateTimeOffset.Parse("2015-10-27T00:00:00Z"));

            Assert.That(firstEvent.IsEquivalentTo(secondEvent, true), Is.False);
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="EventDataExtensions.IsEquivalentTo" /> test
        ///   helper.
        /// </summary>
        ///
        [Test]
        public void IsEquivalentToDetectsDifferentDifferentPartitionKey()
        {
            var firstEvent = new EventData(
                 eventBody: new byte[] { 0x22, 0x44 },
                 offset: 1,
                 partitionKey: "hello",
                 systemProperties: new Dictionary<string, object> { { "test", new object() } },
                 lastPartitionSequenceNumber: 123,
                 lastPartitionOffset: 456,
                 lastPartitionEnqueuedTime: DateTimeOffset.Parse("2015-10-27T00:00:00Z"));

            var secondEvent = new EventData(
                eventBody: new byte[] { 0x22, 0x44 },
                offset: 1,
                partitionKey: "goodbye",
                systemProperties: new Dictionary<string, object> { { "test", new object() } },
                lastPartitionSequenceNumber: 123,
                lastPartitionOffset: 456,
                lastPartitionEnqueuedTime: DateTimeOffset.Parse("2015-10-27T00:00:00Z"));

            Assert.That(firstEvent.IsEquivalentTo(secondEvent, true), Is.False);
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="EventDataExtensions.IsEquivalentTo" /> test
        ///   helper.
        /// </summary>
        ///
        [Test]
        public void IsEquivalentToDetectsDifferentDifferentLastSequenceNumbers()
        {
            var firstEvent = new EventData(
                 eventBody: new byte[] { 0x22, 0x44 },
                 offset: 1,
                 partitionKey: "hello",
                 systemProperties: new Dictionary<string, object> { { "test", new object() } },
                 lastPartitionSequenceNumber: 123,
                 lastPartitionOffset: 456,
                 lastPartitionEnqueuedTime: DateTimeOffset.Parse("2015-10-27T00:00:00Z"));

            var secondEvent = new EventData(
                eventBody: new byte[] { 0x22, 0x44 },
                offset: 1,
                partitionKey: "hello",
                systemProperties: new Dictionary<string, object> { { "test", new object() } },
                lastPartitionSequenceNumber: 1,
                lastPartitionOffset: 456,
                lastPartitionEnqueuedTime: DateTimeOffset.Parse("2015-10-27T00:00:00Z"));

            Assert.That(firstEvent.IsEquivalentTo(secondEvent, true), Is.False);
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="EventDataExtensions.IsEquivalentTo" /> test
        ///   helper.
        /// </summary>
        ///
        [Test]
        public void IsEquivalentToDetectsDifferentDifferentLastOffset()
        {
            var firstEvent = new EventData(
                 eventBody: new byte[] { 0x22, 0x44 },
                 offset: 1,
                 partitionKey: "hello",
                 systemProperties: new Dictionary<string, object> { { "test", new object() } },
                 lastPartitionSequenceNumber: 123,
                 lastPartitionOffset: 1,
                 lastPartitionEnqueuedTime: DateTimeOffset.Parse("2015-10-27T00:00:00Z"));

            var secondEvent = new EventData(
                eventBody: new byte[] { 0x22, 0x44 },
                offset: 1,
                partitionKey: "hello",
                systemProperties: new Dictionary<string, object> { { "test", new object() } },
                lastPartitionSequenceNumber: 123,
                lastPartitionOffset: 456,
                lastPartitionEnqueuedTime: DateTimeOffset.Parse("2015-10-27T00:00:00Z"));

            Assert.That(firstEvent.IsEquivalentTo(secondEvent, true), Is.False);
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="EventDataExtensions.IsEquivalentTo" /> test
        ///   helper.
        /// </summary>
        ///
        [Test]
        public void IsEquivalentToDetectsDifferentDifferentLastEnqueuedTime()
        {
            var firstEvent = new EventData(
                 eventBody: new byte[] { 0x22, 0x44 },
                 offset: 1,
                 partitionKey: "hello",
                 systemProperties: new Dictionary<string, object> { { "test", new object() } },
                 lastPartitionSequenceNumber: 123,
                 lastPartitionOffset: 456,
                 lastPartitionEnqueuedTime: DateTimeOffset.Parse("2015-10-27T00:00:00Z"));

            var secondEvent = new EventData(
                eventBody: new byte[] { 0x22, 0x44 },
                offset: 1,
                partitionKey: "hello",
                systemProperties: new Dictionary<string, object> { { "test", new object() } },
                lastPartitionSequenceNumber: 123,
                lastPartitionOffset: 456,
                lastPartitionEnqueuedTime: DateTimeOffset.Parse("2012-03-04T08:42:00Z"));

            Assert.That(firstEvent.IsEquivalentTo(secondEvent, true), Is.False);
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="EventDataExtensions.IsEquivalentTo" /> test
        ///   helper.
        /// </summary>
        ///
        [Test]
        public void IsEquivalentToDetectsDifferentProperties()
        {
            var body = new byte[] { 0x22, 0x44, 0x88 };
            var firstEvent = new EventData((byte[])body.Clone());
            var secondEvent = new EventData((byte[])body.Clone());

            firstEvent.Properties["test"] = "trackOne";
            secondEvent.Properties["test"] = "trackTwo";

            Assert.That(firstEvent.IsEquivalentTo(secondEvent), Is.False);
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="EventDataExtensions.IsEquivalentTo" /> test
        ///   helper.
        /// </summary>
        ///
        [Test]
        public void IsEquivalentToDetectsWhenOnePropertySetIsNull()
        {
            var body = new byte[] { 0x22, 0x44, 0x88 };
            var firstEvent = new EventData((byte[])body.Clone(), properties: null);
            var secondEvent = new EventData((byte[])body.Clone());

            secondEvent.Properties["test"] = "trackTwo";

            Assert.That(firstEvent.IsEquivalentTo(secondEvent), Is.False);
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="EventDataExtensions.IsEquivalentTo" /> test
        ///   helper.
        /// </summary>
        ///
        [Test]
        public void IsEquivalentToIgnoresTypedSystemPropertiesByDefault()
        {
            var body = new byte[] { 0x22, 0x44, 0x88 };
            var firstEvent = new EventData((byte[])body.Clone(), partitionKey: "1");
            var secondEvent = new EventData((byte[])body.Clone(), partitionKey: "2");

            Assert.That(firstEvent.IsEquivalentTo(secondEvent), Is.True);
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="EventDataExtensions.IsEquivalentTo" /> test
        ///   helper.
        /// </summary>
        ///
        [Test]
        public void IsEquivalentToIgnoresMappedSystemPropertiesByDefault()
        {
            var body = new byte[] { 0x22, 0x44, 0x88 };
            var firstSystemProperties = new Dictionary<string, object>();
            var secondSystemProperties = new Dictionary<string, object>();
            var firstEvent = new EventData((byte[])body.Clone(), systemProperties: firstSystemProperties);
            var secondEvent = new EventData((byte[])body.Clone(), systemProperties: secondSystemProperties);

            firstSystemProperties[nameof(IsEquivalentToIgnoresMappedSystemPropertiesByDefault)] = true;
            secondSystemProperties[nameof(IsEquivalentToIgnoresMappedSystemPropertiesByDefault)] = false;

            Assert.That(firstEvent.IsEquivalentTo(secondEvent), Is.True);
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="EventDataExtensions.IsEquivalentTo" /> test
        ///   helper.
        /// </summary>
        ///
        [Test]
        public void IsEquivalentToDetectsDifferentTypedSystemProperties()
        {
            var body = new byte[] { 0x22, 0x44, 0x88 };
            var firstEvent = new EventData((byte[])body.Clone(), offset: 1);
            var secondEvent = new EventData((byte[])body.Clone(), offset: 2);

            Assert.That(firstEvent.IsEquivalentTo(secondEvent, true), Is.False);
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="EventDataExtensions.IsEquivalentTo" /> test
        ///   helper.
        /// </summary>
        ///
        [Test]
        public void IsEquivalentToDetectsDifferentMappedSystemProperties()
        {
            var body = new byte[] { 0x22, 0x44, 0x88 };
            var firstSystemProperties = new Dictionary<string, object>();
            var secondSystemProperties = new Dictionary<string, object>();
            var firstEvent = new EventData((byte[])body.Clone(), systemProperties: firstSystemProperties);
            var secondEvent = new EventData((byte[])body.Clone(), systemProperties: secondSystemProperties);

            firstSystemProperties[nameof(IsEquivalentToDetectsDifferentMappedSystemProperties)] = true;
            secondSystemProperties[nameof(IsEquivalentToDetectsDifferentMappedSystemProperties)] = false;

            Assert.That(firstEvent.IsEquivalentTo(secondEvent, true), Is.False);
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="EventDataExtensions.IsEquivalentTo" /> test
        ///   helper.
        /// </summary>
        ///
        [Test]
        public void IsEquivalentToDetectsMissingMappedSystemPropertyInFirstArgument()
        {
            var body = new byte[] { 0x22, 0x44, 0x88 };
            var firstSystemProperties = new Dictionary<string, object>();
            var secondSystemProperties = new Dictionary<string, object>();
            var firstEvent = new EventData((byte[])body.Clone(), systemProperties: firstSystemProperties);
            var secondEvent = new EventData((byte[])body.Clone(), systemProperties: secondSystemProperties);

            firstSystemProperties["one"] = true;
            firstSystemProperties[nameof(IsEquivalentToDetectsMissingMappedSystemPropertyInFirstArgument)] = true;
            secondSystemProperties[nameof(IsEquivalentToDetectsMissingMappedSystemPropertyInFirstArgument)] = true;

            Assert.That(firstEvent.IsEquivalentTo(secondEvent, true), Is.False);
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="EventDataExtensions.IsEquivalentTo" /> test
        ///   helper.
        /// </summary>
        ///
        [Test]
        public void IsEquivalentToDetectsMissingMappedSystemPropertyInSecondArgument()
        {
            var body = new byte[] { 0x22, 0x44, 0x88 };
            var firstSystemProperties = new Dictionary<string, object>();
            var secondSystemProperties = new Dictionary<string, object>();
            var firstEvent = new EventData((byte[])body.Clone(), systemProperties: firstSystemProperties);
            var secondEvent = new EventData((byte[])body.Clone(), systemProperties: secondSystemProperties);

            firstSystemProperties[nameof(IsEquivalentToDetectsMissingMappedSystemPropertyInSecondArgument)] = true;
            secondSystemProperties[nameof(IsEquivalentToDetectsMissingMappedSystemPropertyInSecondArgument)] = true;
            secondSystemProperties["one"] = true;

            Assert.That(firstEvent.IsEquivalentTo(secondEvent, true), Is.False);
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="EventDataExtensions.IsEquivalentTo" /> test
        ///   helper.
        /// </summary>
        ///
        [Test]
        public void IsEquivalentToDetectsWhenOneTypedSystemPropertyIsNull()
        {
            var body = new byte[] { 0x22, 0x44, 0x88 };
            var firstEvent = new EventData((byte[])body.Clone(), partitionKey: null);
            var secondEvent = new EventData((byte[])body.Clone(), partitionKey: "trackOne");

            Assert.That(firstEvent.IsEquivalentTo(secondEvent, true), Is.False);
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="EventDataExtensions.IsEquivalentTo" /> test
        ///   helper.
        /// </summary>
        ///
        [Test]
        public void IsEquivalentToDetectsEqualEventsWithPartitionMetrics()
        {
            var body = new byte[] { 0x22, 0x44, 0x88 };

            var firstEvent = new EventData(
                eventBody: (byte[])body.Clone(),
                offset: 1,
                partitionKey: "hello",
                systemProperties: new Dictionary<string, object> { { "test", new object() } },
                lastPartitionSequenceNumber: 123,
                lastPartitionOffset: 456,
                lastPartitionEnqueuedTime: DateTimeOffset.Parse("2015-10-27T00:00:00Z"));

            var secondEvent = new EventData(
                eventBody: (byte[])body.Clone(),
                offset: 1,
                partitionKey: "hello",
                systemProperties: new Dictionary<string, object> { { "test", new object() } },
                lastPartitionSequenceNumber: 123,
                lastPartitionOffset: 456,
                lastPartitionEnqueuedTime: DateTimeOffset.Parse("2015-10-27T00:00:00Z"));

            Assert.That(firstEvent.IsEquivalentTo(secondEvent), Is.True);
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="EventDataExtensions.IsEquivalentTo" /> test
        ///   helper.
        /// </summary>
        ///
        [Test]
        public void IsEquivalentToDetectsEqualEventsWithoutPartitionMetrics()
        {
            var body = new byte[] { 0x22, 0x44, 0x88 };

            var firstEvent = new EventData(
                eventBody: (byte[])body.Clone(),
                offset: 1,
                partitionKey: "hello",
                systemProperties: new Dictionary<string, object> { { "test", new object() } });

            var secondEvent = new EventData(
                eventBody: (byte[])body.Clone(),
                offset: 1,
                partitionKey: "hello",
                systemProperties: new Dictionary<string, object> { { "test", new object() } });

            Assert.That(firstEvent.IsEquivalentTo(secondEvent), Is.True);
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="EventDataExtensions.IsEquivalentTo" /> test
        ///   helper.
        /// </summary>
        ///
        [Test]
        public void IsEquivalentToDetectsSameInstance()
        {
            var firstEvent = new EventData(
                eventBody: new byte[] { 0x22, 0x44, 0x88 },
                offset: 1,
                partitionKey: "hello",
                systemProperties: new Dictionary<string, object> { { "test", new object() } });

            Assert.That(firstEvent.IsEquivalentTo(firstEvent), Is.True);
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="EventDataExtensions.IsEquivalentTo" /> test
        ///   helper.
        /// </summary>
        ///
        [Test]
        public void IsEquivalentToDetectsTwoNulls()
        {
            Assert.That(((EventData)null).IsEquivalentTo(null), Is.True);
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="EventDataExtensions.IsEquivalentTo" /> test
        ///   helper.
        /// </summary>
        ///
        [Test]
        public void IsEquivalentToDetectsNullInstance()
        {
            var firstEvent = new EventData(
                eventBody: new byte[] { 0x22, 0x44, 0x88 },
                offset: 1,
                partitionKey: "hello",
                systemProperties: new Dictionary<string, object> { { "test", new object() } });

            Assert.That(((EventData)null).IsEquivalentTo(firstEvent), Is.False);
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="EventDataExtensions.IsEquivalentTo" /> test
        ///   helper.
        /// </summary>
        ///
        [Test]
        public void IsEquivalentToDetectsNullArgument()
        {
            var firstEvent = new EventData(
                eventBody: new byte[] { 0x22, 0x44, 0x88 },
                offset: 1,
                partitionKey: "hello",
                systemProperties: new Dictionary<string, object> { { "test", new object() } });

            Assert.That(firstEvent.IsEquivalentTo((EventData)null), Is.False);
        }
    }
}
