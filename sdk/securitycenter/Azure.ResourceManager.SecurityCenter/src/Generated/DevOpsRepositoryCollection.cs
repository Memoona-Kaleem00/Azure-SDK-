// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="DevOpsRepositoryResource"/> and their operations.
    /// Each <see cref="DevOpsRepositoryResource"/> in the collection will belong to the same instance of <see cref="DevOpsProjectResource"/>.
    /// To get a <see cref="DevOpsRepositoryCollection"/> instance call the GetDevOpsRepositories method from an instance of <see cref="DevOpsProjectResource"/>.
    /// </summary>
    public partial class DevOpsRepositoryCollection : ArmCollection, IEnumerable<DevOpsRepositoryResource>, IAsyncEnumerable<DevOpsRepositoryResource>
    {
        private readonly ClientDiagnostics _devOpsRepositoryAzureDevOpsReposClientDiagnostics;
        private readonly AzureDevOpsReposRestOperations _devOpsRepositoryAzureDevOpsReposRestClient;

        /// <summary> Initializes a new instance of the <see cref="DevOpsRepositoryCollection"/> class for mocking. </summary>
        protected DevOpsRepositoryCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DevOpsRepositoryCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DevOpsRepositoryCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _devOpsRepositoryAzureDevOpsReposClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", DevOpsRepositoryResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DevOpsRepositoryResource.ResourceType, out string devOpsRepositoryAzureDevOpsReposApiVersion);
            _devOpsRepositoryAzureDevOpsReposRestClient = new AzureDevOpsReposRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, devOpsRepositoryAzureDevOpsReposApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DevOpsProjectResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DevOpsProjectResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a monitored Azure DevOps repository resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/azureDevOpsOrgs/{orgName}/projects/{projectName}/repos/{repoName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsRepos_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsRepositoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="repoName"> The repository name. </param>
        /// <param name="data"> The Azure DevOps repository resource payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="repoName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="repoName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DevOpsRepositoryResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string repoName, DevOpsRepositoryData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(repoName, nameof(repoName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _devOpsRepositoryAzureDevOpsReposClientDiagnostics.CreateScope("DevOpsRepositoryCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _devOpsRepositoryAzureDevOpsReposRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Name, Id.Name, repoName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation<DevOpsRepositoryResource>(new DevOpsRepositoryOperationSource(Client), _devOpsRepositoryAzureDevOpsReposClientDiagnostics, Pipeline, _devOpsRepositoryAzureDevOpsReposRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Name, Id.Name, repoName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a monitored Azure DevOps repository resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/azureDevOpsOrgs/{orgName}/projects/{projectName}/repos/{repoName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsRepos_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsRepositoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="repoName"> The repository name. </param>
        /// <param name="data"> The Azure DevOps repository resource payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="repoName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="repoName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DevOpsRepositoryResource> CreateOrUpdate(WaitUntil waitUntil, string repoName, DevOpsRepositoryData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(repoName, nameof(repoName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _devOpsRepositoryAzureDevOpsReposClientDiagnostics.CreateScope("DevOpsRepositoryCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _devOpsRepositoryAzureDevOpsReposRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Name, Id.Name, repoName, data, cancellationToken);
                var operation = new SecurityCenterArmOperation<DevOpsRepositoryResource>(new DevOpsRepositoryOperationSource(Client), _devOpsRepositoryAzureDevOpsReposClientDiagnostics, Pipeline, _devOpsRepositoryAzureDevOpsReposRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Name, Id.Name, repoName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a monitored Azure DevOps repository resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/azureDevOpsOrgs/{orgName}/projects/{projectName}/repos/{repoName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsRepos_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsRepositoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="repoName"> The repository name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="repoName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="repoName"/> is null. </exception>
        public virtual async Task<Response<DevOpsRepositoryResource>> GetAsync(string repoName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(repoName, nameof(repoName));

            using var scope = _devOpsRepositoryAzureDevOpsReposClientDiagnostics.CreateScope("DevOpsRepositoryCollection.Get");
            scope.Start();
            try
            {
                var response = await _devOpsRepositoryAzureDevOpsReposRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Name, Id.Name, repoName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevOpsRepositoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a monitored Azure DevOps repository resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/azureDevOpsOrgs/{orgName}/projects/{projectName}/repos/{repoName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsRepos_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsRepositoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="repoName"> The repository name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="repoName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="repoName"/> is null. </exception>
        public virtual Response<DevOpsRepositoryResource> Get(string repoName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(repoName, nameof(repoName));

            using var scope = _devOpsRepositoryAzureDevOpsReposClientDiagnostics.CreateScope("DevOpsRepositoryCollection.Get");
            scope.Start();
            try
            {
                var response = _devOpsRepositoryAzureDevOpsReposRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Name, Id.Name, repoName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevOpsRepositoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a list of Azure DevOps repositories onboarded to the connector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/azureDevOpsOrgs/{orgName}/projects/{projectName}/repos</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsRepos_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsRepositoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DevOpsRepositoryResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DevOpsRepositoryResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _devOpsRepositoryAzureDevOpsReposRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devOpsRepositoryAzureDevOpsReposRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DevOpsRepositoryResource(Client, DevOpsRepositoryData.DeserializeDevOpsRepositoryData(e)), _devOpsRepositoryAzureDevOpsReposClientDiagnostics, Pipeline, "DevOpsRepositoryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns a list of Azure DevOps repositories onboarded to the connector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/azureDevOpsOrgs/{orgName}/projects/{projectName}/repos</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsRepos_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsRepositoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DevOpsRepositoryResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DevOpsRepositoryResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _devOpsRepositoryAzureDevOpsReposRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devOpsRepositoryAzureDevOpsReposRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DevOpsRepositoryResource(Client, DevOpsRepositoryData.DeserializeDevOpsRepositoryData(e)), _devOpsRepositoryAzureDevOpsReposClientDiagnostics, Pipeline, "DevOpsRepositoryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/azureDevOpsOrgs/{orgName}/projects/{projectName}/repos/{repoName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsRepos_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsRepositoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="repoName"> The repository name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="repoName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="repoName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string repoName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(repoName, nameof(repoName));

            using var scope = _devOpsRepositoryAzureDevOpsReposClientDiagnostics.CreateScope("DevOpsRepositoryCollection.Exists");
            scope.Start();
            try
            {
                var response = await _devOpsRepositoryAzureDevOpsReposRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Name, Id.Name, repoName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/azureDevOpsOrgs/{orgName}/projects/{projectName}/repos/{repoName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsRepos_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsRepositoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="repoName"> The repository name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="repoName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="repoName"/> is null. </exception>
        public virtual Response<bool> Exists(string repoName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(repoName, nameof(repoName));

            using var scope = _devOpsRepositoryAzureDevOpsReposClientDiagnostics.CreateScope("DevOpsRepositoryCollection.Exists");
            scope.Start();
            try
            {
                var response = _devOpsRepositoryAzureDevOpsReposRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Name, Id.Name, repoName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/azureDevOpsOrgs/{orgName}/projects/{projectName}/repos/{repoName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsRepos_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsRepositoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="repoName"> The repository name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="repoName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="repoName"/> is null. </exception>
        public virtual async Task<NullableResponse<DevOpsRepositoryResource>> GetIfExistsAsync(string repoName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(repoName, nameof(repoName));

            using var scope = _devOpsRepositoryAzureDevOpsReposClientDiagnostics.CreateScope("DevOpsRepositoryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _devOpsRepositoryAzureDevOpsReposRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Name, Id.Name, repoName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DevOpsRepositoryResource>(response.GetRawResponse());
                return Response.FromValue(new DevOpsRepositoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/devops/default/azureDevOpsOrgs/{orgName}/projects/{projectName}/repos/{repoName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsRepos_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsRepositoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="repoName"> The repository name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="repoName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="repoName"/> is null. </exception>
        public virtual NullableResponse<DevOpsRepositoryResource> GetIfExists(string repoName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(repoName, nameof(repoName));

            using var scope = _devOpsRepositoryAzureDevOpsReposClientDiagnostics.CreateScope("DevOpsRepositoryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _devOpsRepositoryAzureDevOpsReposRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Name, Id.Name, repoName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DevOpsRepositoryResource>(response.GetRawResponse());
                return Response.FromValue(new DevOpsRepositoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DevOpsRepositoryResource> IEnumerable<DevOpsRepositoryResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DevOpsRepositoryResource> IAsyncEnumerable<DevOpsRepositoryResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
