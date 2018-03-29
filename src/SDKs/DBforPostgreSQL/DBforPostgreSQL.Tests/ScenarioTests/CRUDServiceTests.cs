﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Net;
using DBforPostgreSQL.Tests.Helpers;
using Microsoft.Azure.Management.DBforPostgreSQL;
using Microsoft.Azure.Management.DBforPostgreSQL.Models;
using Microsoft.Azure.Management.Resources;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using Xunit;

namespace DBforPostgreSQL.Tests.ScenarioTests
{
    public class CRUDServiceTests : CRUDDBForPostgreSQLTestsBase
    {
        [Fact]
        public void CreateResourceSucceeds()
        {
            var clientHandler = new RecordedDelegatingHandler() { StatusCodeToReturn = HttpStatusCode.OK };
            var resourcesHandler = new RecordedDelegatingHandler() { StatusCodeToReturn = HttpStatusCode.OK };

            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                var resourceGroup = CreateResourceGroup(context, resourcesHandler, ResourceGroupName, TestConfiguration.Location);
                var client = Utilities.GetPostgreSQLManagementClient(context, clientHandler);
                var createResult = CreateDBForPostgreSQLInstance(context, client, resourceGroup, ServerName);
            }
            // Wait for resource group deletion to complete.
            Utilities.WaitIfNotInPlaybackMode();
        }

        [Fact]
        public void GetResourceSucceeds()
        {
            var clientHandler = new RecordedDelegatingHandler() { StatusCodeToReturn = HttpStatusCode.OK };
            var resourcesHandler = new RecordedDelegatingHandler() { StatusCodeToReturn = HttpStatusCode.OK };

            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                var resourceGroup = CreateResourceGroup(context, resourcesHandler, ResourceGroupName, TestConfiguration.Location);
                var client = Utilities.GetPostgreSQLManagementClient(context, clientHandler);
                var createResult = CreateDBForPostgreSQLInstance(context, client, resourceGroup, ServerName);
                var getResult = client.Servers.Get(resourceGroup.Name, ServerName);
            }
            // Wait for resource group deletion to complete.
            Utilities.WaitIfNotInPlaybackMode();
        }

        [Fact]
        public void DeleteResourceSucceeds()
        {
            var clientHandler = new RecordedDelegatingHandler() { StatusCodeToReturn = HttpStatusCode.OK };
            var resourcesHandler = new RecordedDelegatingHandler() { StatusCodeToReturn = HttpStatusCode.OK };

            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                var resourceGroup = CreateResourceGroup(context, resourcesHandler, ResourceGroupName, TestConfiguration.Location);
                var client = Utilities.GetPostgreSQLManagementClient(context, clientHandler);
                var createResult = CreateDBForPostgreSQLInstance(context, client, resourceGroup, ServerName);
                var getResult = client.Servers.Get(resourceGroup.Name, ServerName);
                client.Servers.Delete(resourceGroup.Name, ServerName);

                var x = Assert.Throws<Exception>(() => client.Servers.Get(ResourceGroupName, ServerName));
            }
            // Wait for resource group deletion to complete.
            Utilities.WaitIfNotInPlaybackMode();
        }
    }
}
