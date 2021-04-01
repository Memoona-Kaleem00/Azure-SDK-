﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
#region Snippet:ContainerRegistry_Tests_Samples_Namespaces
using Azure.Containers.ContainerRegistry;
#endregion Snippet:ContainerRegistry_Tests_Samples_Namespaces
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Containers.ContainerRegistry.Tests.Samples
{
#pragma warning disable SA1649 // File name should match first type name
    public class HelloWorld : ContainerRegistryRecordedTestBase
#pragma warning restore SA1649
    {
        public HelloWorld(bool isAsync) : base(isAsync)
        {
        }

        [Test]
        [SyncOnly]
        public void CreateClient()
        {
            Environment.SetEnvironmentVariable("REGISTRY_ENDPOINT", TestEnvironment.Endpoint);

            #region Snippet:ContainerRegistry_Tests_Samples_CreateClient
            // Get the service endpoint from the environment
            Uri endpoint = new Uri(Environment.GetEnvironmentVariable("REGISTRY_ENDPOINT"));

            // Create a new ContainerRegistryClient
            ContainerRegistryClient client = new ContainerRegistryClient(endpoint, new DefaultAzureCredential());

            // Perform an operation
            Pageable<string> repositories = client.GetRepositories();
            foreach (string repository in repositories)
            {
                Console.WriteLine(repository);
            }
            #endregion Snippet:ContainerRegistry_Tests_Samples_CreateClient
        }

        [Test]
        [AsyncOnly]
        public async Task CreateClientAsync()
        {
            Environment.SetEnvironmentVariable("REGISTRY_ENDPOINT", TestEnvironment.Endpoint);

            #region Snippet:ContainerRegistry_Tests_Samples_CreateClientAsync
            // Get the service endpoint from the environment
            Uri endpoint = new Uri(Environment.GetEnvironmentVariable("REGISTRY_ENDPOINT"));

            // Create a new ContainerRegistryClient
            ContainerRegistryClient client = new ContainerRegistryClient(endpoint, new DefaultAzureCredential());

            // Perform an operation
            AsyncPageable<string> repositories = client.GetRepositoriesAsync();
            await foreach (string repository in repositories)
            {
                Console.WriteLine(repository);
            }
            #endregion Snippet:ContainerRegistry_Tests_Samples_CreateClientAsync
        }

        [Test]
        [SyncOnly]
        public void HandleErrors()
        {
            Environment.SetEnvironmentVariable("REGISTRY_ENDPOINT", TestEnvironment.Endpoint);

            #region Snippet:ContainerRegistry_Tests_Samples_HandleErrors
            Uri endpoint = new Uri(Environment.GetEnvironmentVariable("REGISTRY_ENDPOINT"));

            // Create an invalid ContainerRepositoryClient
            string fakeRepositoryName = "doesnotexist";
            ContainerRepositoryClient client = new ContainerRepositoryClient(endpoint, fakeRepositoryName, new DefaultAzureCredential());

            try
            {
                client.GetProperties();
            }
            catch (RequestFailedException ex) when (ex.Status == 404)
            {
                Console.WriteLine("Repository wasn't found.");
            }
            #endregion Snippet:ContainerRegistry_Tests_Samples_HandleErrors
        }

        [Test]
        [AsyncOnly]
        public async Task HandleErrorsAsync()
        {
            Environment.SetEnvironmentVariable("REGISTRY_ENDPOINT", TestEnvironment.Endpoint);

            #region Snippet:ContainerRegistry_Tests_Samples_HandleErrorsAsync
            Uri endpoint = new Uri(Environment.GetEnvironmentVariable("REGISTRY_ENDPOINT"));

            // Create an invalid ContainerRepositoryClient
            string fakeRepositoryName = "doesnotexist";
            ContainerRepositoryClient client = new ContainerRepositoryClient(endpoint, fakeRepositoryName, new DefaultAzureCredential());

            try
            {
                await client.GetPropertiesAsync();
            }
            catch (RequestFailedException ex) when (ex.Status == 404)
            {
                Console.WriteLine("Repository wasn't found.");
            }
            #endregion Snippet:ContainerRegistry_Tests_Samples_HandleErrorsAsync
        }
    }
}
