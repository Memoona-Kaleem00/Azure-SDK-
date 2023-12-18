// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.SpringAppDiscovery.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.SpringAppDiscovery.Tests.Tests
{
    [TestFixture]
    public class ServerCRUDTests : SpringAppDiscoveryManagementTestBase
    {
        public const string serverIp = "10.150.221.94";

        public const string machineId = "test-swagger-marchine-id";

        public const string machineId1 = "test-swagger-marchine-id1";

        public ServerCRUDTests() : base(true)
        {
        }

        [SetUp]
        public async Task ClearAndInitialize()
        {
            if (Mode == RecordedTestMode.Record || Mode == RecordedTestMode.Playback)
            {
                await CreateCommonClient();
            }
        }

        /// <summary>
        /// Test Server CRUD for spring discovery
        /// </summary>
        /// <returns></returns>
        [TestCase]
        public async Task TestServersCRUDAsyncOperations()
        {
            //get a site
            SpringBootSiteResource siteModelResource = await GetSpringsiteModelResource(rgName, siteName);

            //get a server collection
            SpringBootServerCollection serverColletion = siteModelResource.GetSpringBootServers();
            SpringBootServerProperties properties = new SpringBootServerProperties(serverIp);
            properties.MachineArmId=machineId;
            properties.Port=22;
            SpringBootServerData data = new SpringBootServerData();
            data.Properties = properties;

            //create a server
            var createServerOperation = await serverColletion.CreateOrUpdateAsync(WaitUntil.Completed, serverName, data, CancellationToken.None);
            await createServerOperation.WaitForCompletionAsync();
            Assert.IsTrue(createServerOperation.HasCompleted);
            Assert.IsTrue(createServerOperation.HasValue);

             //judge a server exist or not
            Assert.IsTrue(await serverColletion.ExistsAsync(serverName));

            //get a server
            NullableResponse<SpringBootServerResource> getIfExistResponse = await serverColletion.GetIfExistsAsync(serverName);
            Assert.True(getIfExistResponse.HasValue);

            //get all servers
            AsyncPageable<SpringBootServerResource> getServersResponse = serverColletion.GetAllAsync(CancellationToken.None);
            int serverCount = 0;
            await foreach (var item in getServersResponse) {
                serverCount++;
            }
            Assert.True(serverCount > 0);

            //get a server
            Response<SpringBootServerResource> getServerResponse = await serverColletion.GetAsync(serverName);
            SpringBootServerResource serverModelResource = getServerResponse.Value;
            Assert.IsNotNull(serverModelResource);

            SpringBootServerPatch serverPatch = new SpringBootServerPatch(){
                 Tags = {["serverKey"] = "serverValue1",}
            };

            properties.MachineArmId=machineId1;
            serverPatch.Properties= properties;

            //patch a server
            var updateOperataion = await serverModelResource.UpdateAsync(WaitUntil.Completed, serverPatch);
            Assert.IsTrue(updateOperataion.HasCompleted);
            Assert.IsTrue(updateOperataion.HasValue);

            //delete a server
            var deletetServerOperation = await serverModelResource.DeleteAsync(WaitUntil.Completed, CancellationToken.None);
            Assert.IsTrue(deletetServerOperation.HasCompleted);
        }
    }
}
