﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure.Messaging.EventHubs.Authorization;
using Azure.Messaging.EventHubs.Core;
using Azure.Messaging.EventHubs.Tests.Infrastructure;
using NUnit.Framework;

namespace Azure.Messaging.EventHubs.Tests
{
    /// <summary>
    ///   The suite of live tests for the <see cref="EventHubClient" />
    ///   class.
    /// </summary>
    ///
    /// <remarks>
    ///   These tests have a depenency on live Azure services and may
    ///   incur costs for the assocaied Azure subscription.
    /// </remarks>
    ///
    [TestFixture]
    [Category(TestCategory.Live)]
    [Category(TestCategory.DisallowVisualStudioLiveUnitTesting)]
    public class EventHubClientLiveTests
    {
        /// <summary>
        ///   Verifies that the <see cref="EventHubClient" /> is able to
        ///   connect to the Event Hubs service.
        /// </summary>
        ///
        [Test]
        public async Task ClientCanConnectToEventHubsUsingConnectionString()
        {
            await using (var scope = await EventHubScope.CreateAsync(1))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var client = new EventHubClient(connectionString))
                {
                    Assert.That(() => client.GetPropertiesAsync(), Throws.Nothing);
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubClient" /> is able to
        ///   connect to the Event Hubs service.
        /// </summary>
        ///
        [Test]
        public async Task ClientCanConnectToEventHubsUsingArguments()
        {
            await using (var scope = await EventHubScope.CreateAsync(1))
            {
                var clientOptions = new EventHubClientOptions();
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);
                var connectionProperties = ConnectionStringParser.Parse(connectionString);

                var credential = new SharedAccessSignatureCredential
                (
                    new SharedAccessSignature
                    (
                        clientOptions.TransportType,
                        connectionProperties.Endpoint.Host,
                        connectionProperties.EventHubPath,
                        connectionProperties.SharedAccessKeyName,
                        connectionProperties.SharedAccessKey,
                        TimeSpan.FromHours(4)
                    )
                );

                await using (var client = new EventHubClient(connectionProperties.Endpoint.Host, connectionProperties.EventHubPath, credential))
                {
                    Assert.That(() => client.GetPropertiesAsync(), Throws.Nothing);
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubClient" /> is able to
        ///   connect to the Event Hubs service.
        /// </summary>
        ///
        [Test]
        public async Task ClientCanRetrieveProperties()
        {
            var partitionCount = 4;

            await using (var scope = await EventHubScope.CreateAsync(partitionCount))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var client = new EventHubClient(connectionString))
                {
                    var properties = await client.GetPropertiesAsync();

                    Assert.That(properties, Is.Not.Null, "A set of properties should have been returned.");
                    Assert.That(properties.Path, Is.EqualTo(scope.EventHubName), "The property Event Hub name should match the scope.");
                    Assert.That(properties.PartitionIds.Length, Is.EqualTo(partitionCount), "The properties should have the requested number of partitions.");
                    Assert.That(properties.CreatedAtUtc, Is.LessThanOrEqualTo(DateTime.UtcNow), "The Event Hub should have been created prior to now.");
                    Assert.That(properties.PropertyRetrievalTimeUtc, Is.EqualTo(DateTime.UtcNow).Within(TimeSpan.FromSeconds(30)), "The property retrieval time should denote the current time.");
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubClient" /> is able to
        ///   connect to the Event Hubs service.
        /// </summary>
        ///
        [Test]
        public async Task ClientCanRetrievePartitionProperties()
        {
            var partitionCount = 4;

            await using (var scope = await EventHubScope.CreateAsync(partitionCount))
            {
                var clientOptions = new EventHubClientOptions();
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);
                var connectionProperties = ConnectionStringParser.Parse(connectionString);

                var credential = new SharedAccessSignatureCredential
                (
                    new SharedAccessSignature
                    (
                        clientOptions.TransportType,
                        connectionProperties.Endpoint.Host,
                        connectionProperties.EventHubPath,
                        connectionProperties.SharedAccessKeyName,
                        connectionProperties.SharedAccessKey,
                        TimeSpan.FromHours(4)
                    )
                );

                await using (var client = new EventHubClient(connectionProperties.Endpoint.Host, connectionProperties.EventHubPath, credential))
                {
                    var cancellation = new CancellationTokenSource(TimeSpan.FromSeconds(20));
                    var properties = await client.GetPropertiesAsync();
                    var partition = properties.PartitionIds.First();
                    var partitionProperties = await client.GetPartitionPropertiesAsync(partition, cancellation.Token);

                    Assert.That(partitionProperties, Is.Not.Null, "A set of partition properties should have been returned.");
                    Assert.That(partitionProperties.Id, Is.EqualTo(partition), "The partition identifier should match.");
                    Assert.That(partitionProperties.EventHubPath, Is.EqualTo(connectionProperties.EventHubPath).Using((IEqualityComparer<string>)StringComparer.InvariantCultureIgnoreCase), "The Event Hub path should match.");
                    Assert.That(partitionProperties.BeginningSequenceNumber, Is.Not.EqualTo(default(Int64)), "The beginning sequence number should have been populated.");
                    Assert.That(partitionProperties.LastEnqueuedSequenceNumber, Is.Not.EqualTo(default(Int64)), "The last sequance number should have been populated.");
                    Assert.That(partitionProperties.LastEnqueuedOffset, Is.Not.Null.Or.Empty, "The last offset should have been populated.");
                    Assert.That(partitionProperties.PropertyRetrievalTimeUtc, Is.EqualTo(DateTime.UtcNow).Within(TimeSpan.FromSeconds(30)), "The property retrieval time should denote the current time.");
                }
            }
        }

        /// <summary>
        ///   Verifies that the <see cref="EventHubClient" /> is able to
        ///   connect to the Event Hubs service.
        /// </summary>
        ///
        [Test]
        public async Task ClientPartitionIdsMatchPartitionProperties()
        {
            var partitionCount = 4;

            await using (var scope = await EventHubScope.CreateAsync(partitionCount))
            {
                var connectionString = TestEnvironment.BuildConnectionStringForEventHub(scope.EventHubName);

                await using (var client = new EventHubClient(connectionString))
                {
                    var properties = await client.GetPropertiesAsync();
                    var partitions = await client.GetPartitionIdsAsync();

                    Assert.That(properties, Is.Not.Null, "A set of properties should have been returned.");
                    Assert.That(properties.PartitionIds, Is.Not.Null, "A set of partition identifiers for the properties should have been returned.");
                    Assert.That(partitions, Is.Not.Null, "A set of partition identifiers should have been returned.");
                    Assert.That(partitions, Is.EquivalentTo(properties.PartitionIds), "The partition identifiers returned directly should match those returned with properties.");
                }
            }
        }
    }
}
