﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Communication.JobRouter.Tests.Infrastructure;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.Communication.JobRouter.Tests.RouterClients
{
    public class RouterWorkerLiveTests: RouterLiveTestBase
    {
        /// <inheritdoc />
        public RouterWorkerLiveTests(bool isAsync) : base(isAsync)
        {
        }

        #region Worker Tests
        [Test]
        public async Task CreateWorkerTest()
        {
            RouterClient routerClient = CreateRouterClientWithConnectionString();

            // Setup queue
            var createQueueResponse = await CreateQueueAsync(nameof(CreateWorkerTest));

            // Register worker
            var workerId = GenerateUniqueId($"{IdPrefix}{nameof(CreateWorkerTest)}");
            var totalCapacity = 100;

            var channelConfig1 = new ChannelConfiguration(20);

            var channelConfigList = new Dictionary<string, ChannelConfiguration>()
            {
                ["ACS_Chat_Channel"] = channelConfig1
            };
            var workerLabels = new LabelCollection()
            {
                ["test_label_1"] = "testLabel",
                ["test_label_2"] = 12,
            };

            var queueAssignmentList = new string[] { createQueueResponse.Value.Id };

            var routerWorkerResponse = await routerClient.CreateWorkerAsync(
                id: workerId,
                totalCapacity: totalCapacity,
                new CreateWorkerOptions()
                {
                    QueueIds = queueAssignmentList,
                    Labels = workerLabels,
                    ChannelConfigurations = channelConfigList,
                });

            Assert.NotNull(routerWorkerResponse.Value);
            AssertRegisteredWorkerIsValid(routerWorkerResponse, workerId, queueAssignmentList,
                totalCapacity, workerLabels, channelConfigList);

            AddForCleanup(new Task(async () => await routerClient.DeleteWorkerAsync(routerWorkerResponse.Value.Id)));
        }

        [Test]
        public async Task RegisterWorkerShouldNotThrowArgumentNullExceptionTest()
        {
            RouterClient routerClient = CreateRouterClientWithConnectionString();

            // Register worker with only id and total capacity
            var workerId = $"{IdPrefix}-WorkerIDRegisterWorker";

            var totalCapacity = 100;
            var routerWorkerResponse = await routerClient.CreateWorkerAsync(workerId, totalCapacity, new CreateWorkerOptions(){AvailableForOffers = true});

            Assert.NotNull(routerWorkerResponse.Value);

            AddForCleanup(new Task(async () => await routerClient.DeleteWorkerAsync(routerWorkerResponse.Value.Id)));
        }

        [Test]
        public async Task GetWorkersTest()
        {
            RouterClient routerClient = CreateRouterClientWithConnectionString();

            // Setup queue 1
            var createQueue1Response = await CreateQueueAsync($"Q1{nameof(GetWorkersTest)}");
            var createQueue1 = createQueue1Response.Value;

            // Setup queue 2
            var createQueue2Response = await CreateQueueAsync($"Q2{nameof(GetWorkersTest)}");
            var createQueue2 = createQueue2Response.Value;

            // Setup workers
            var workerId1 = GenerateUniqueId($"{IdPrefix}GetWorkersTest_1");
            var workerId2 = GenerateUniqueId($"{IdPrefix}GetWorkersTest_2");
            var workerId3 = GenerateUniqueId($"{IdPrefix}GetWorkersTest_3");
            var workerId4 = GenerateUniqueId($"{IdPrefix}GetWorkersTest_4");

            var expectedWorkerIds = new List<string>() { workerId1, workerId2, workerId3, workerId4 };

            var registerWorker1Response = await routerClient.CreateWorkerAsync(
                workerId1,
                10,
                new CreateWorkerOptions()
                {
                    QueueIds = new List<string>()
                    {
                        createQueue1.Id
                    },
                    ChannelConfigurations = new Dictionary<string, ChannelConfiguration>()
                    {
                        ["WebChat"] = new ChannelConfiguration(1),
                        ["Voip"] = new ChannelConfiguration(10)
                    },
                    AvailableForOffers = true
                });
            var registerWorker1 = registerWorker1Response.Value;

            var registerWorker2Response = await routerClient.CreateWorkerAsync(
                workerId2,
                10,
                new CreateWorkerOptions()
                {
                    QueueIds = new List<string>()
                    {
                        createQueue2.Id
                    },
                    ChannelConfigurations = new Dictionary<string, ChannelConfiguration>()
                    {
                        ["WebChat"] = new ChannelConfiguration(1),
                        ["Voip"] = new ChannelConfiguration(10)
                    },
                    AvailableForOffers = true,
                });
            var registerWorker2 = registerWorker2Response.Value;

            var registerWorker3Response = await routerClient.CreateWorkerAsync(
                workerId3,
                10,
                new CreateWorkerOptions()
                {
                    QueueIds = new List<string>()
                    {
                        createQueue1.Id, createQueue2.Id
                    },
                    ChannelConfigurations = new Dictionary<string, ChannelConfiguration>()
                    {
                        ["WebChat"] = new ChannelConfiguration(1),
                        ["Voip"] = new ChannelConfiguration(10)
                    },
                    AvailableForOffers = true,
                });
            var registerWorker3 = registerWorker3Response.Value;

            var registerWorker4Response = await routerClient.CreateWorkerAsync(
                workerId4,
                10,
                new CreateWorkerOptions()
                {
                    QueueIds = new List<string>()
                    {
                        createQueue1.Id
                    },
                    ChannelConfigurations = new Dictionary<string, ChannelConfiguration>()
                    {
                        ["WebChat"] = new ChannelConfiguration(1)
                    },
                    AvailableForOffers = true,
                });
            var registerWorker4 = registerWorker4Response.Value;

            // Query all workers with channel filter
            var channel2Workers = new HashSet<string>() { workerId1, workerId2, workerId3 };
            var getWorkersResponse = routerClient.GetWorkersAsync(new GetWorkersOptions() { ChannelId = "Voip" });
            await foreach (var workerPage in getWorkersResponse.AsPages(pageSizeHint: 1))
            {
                Assert.AreEqual(1, workerPage.Values.Count);
                foreach (var worker in workerPage.Values)
                {
                    Assert.IsTrue(channel2Workers.Contains(worker.Id));
                }
            }

            // Query all workers with queue filter
            var queue2Workers = new HashSet<string>() { workerId2, workerId3 };
            getWorkersResponse = routerClient.GetWorkersAsync(new GetWorkersOptions() { QueueId = createQueue2.Id });
            await foreach (var workerPage in getWorkersResponse.AsPages(pageSizeHint: 1))
            {
                Assert.AreEqual(1, workerPage.Values.Count);
                foreach (var worker in workerPage.Values)
                {
                    Assert.IsTrue(queue2Workers.Contains(worker.Id));
                }
            }

            // Query all workers with channel + hasCapacity filter
            var channel1Workers = new HashSet<string>() { workerId1, workerId2, workerId3, workerId4 }; // no worker is expected to get any job
            getWorkersResponse = routerClient.GetWorkersAsync(new GetWorkersOptions() { ChannelId = "WebChat", HasCapacity = true});
            await foreach (var workerPage in getWorkersResponse.AsPages(pageSizeHint: 1))
            {
                Assert.AreEqual(1, workerPage.Values.Count);
                foreach (var worker in workerPage.Values)
                {
                    Assert.IsTrue(channel1Workers.Contains(worker.Id));
                }
            }

            // Deregister worker1
            await routerClient.UpdateWorkerAsync(workerId1, new UpdateWorkerOptions(){ AvailableForOffers = false});

            var checkWorker1Status = await Poll(async () => await routerClient.GetWorkerAsync(workerId1),
                w => w.Value.State == RouterWorkerState.Inactive, TimeSpan.FromSeconds(10));

            Assert.AreEqual(RouterWorkerState.Inactive, checkWorker1Status.Value.State);

            // Query all workers with status: active
            var activeWorkers = new HashSet<string>();
            getWorkersResponse = routerClient.GetWorkersAsync(new GetWorkersOptions() { ChannelId = "WebChat", Status = WorkerStateSelector.Active});
            await foreach (var workerPage in getWorkersResponse.AsPages(pageSizeHint: 1))
            {
                Assert.AreEqual(1, workerPage.Values.Count);
                foreach (var worker in workerPage.Values)
                {
                    activeWorkers.Add(worker.Id);
                }
            }

            Assert.IsTrue(activeWorkers.Contains(workerId2));
            Assert.IsTrue(activeWorkers.Contains(workerId3));
            Assert.IsTrue(activeWorkers.Contains(workerId4));

            // Query all workers with status: inactive
            var inactiveWorkers = new HashSet<string>();
            getWorkersResponse = routerClient.GetWorkersAsync(new GetWorkersOptions() { ChannelId = "WebChat", Status = WorkerStateSelector.Inactive });
            await foreach (var workerPage in getWorkersResponse.AsPages(pageSizeHint: 1))
            {
                Assert.AreEqual(1, workerPage.Values.Count);
                foreach (var worker in workerPage.Values)
                {
                    inactiveWorkers.Add(worker.Id);
                }
            }
            Assert.IsTrue(inactiveWorkers.Contains(workerId1));

            // in-test cleanup workers before deleting queue and channel
            await routerClient.DeleteWorkerAsync(expectedWorkerIds[0]);
            await routerClient.DeleteWorkerAsync(expectedWorkerIds[1]);
            await routerClient.DeleteWorkerAsync(expectedWorkerIds[2]);
            await routerClient.DeleteWorkerAsync(expectedWorkerIds[3]);
        }
        #endregion Worker Tests
    }
}
