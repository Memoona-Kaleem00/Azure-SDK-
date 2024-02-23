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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing a collection of <see cref="MachineLearningEnvironmentContainerResource"/> and their operations.
    /// Each <see cref="MachineLearningEnvironmentContainerResource"/> in the collection will belong to the same instance of <see cref="MachineLearningWorkspaceResource"/>.
    /// To get a <see cref="MachineLearningEnvironmentContainerCollection"/> instance call the GetMachineLearningEnvironmentContainers method from an instance of <see cref="MachineLearningWorkspaceResource"/>.
    /// </summary>
    public partial class MachineLearningEnvironmentContainerCollection : ArmCollection, IEnumerable<MachineLearningEnvironmentContainerResource>, IAsyncEnumerable<MachineLearningEnvironmentContainerResource>
    {
        private readonly ClientDiagnostics _machineLearningEnvironmentContainerEnvironmentContainersClientDiagnostics;
        private readonly EnvironmentContainersRestOperations _machineLearningEnvironmentContainerEnvironmentContainersRestClient;

        /// <summary> Initializes a new instance of the <see cref="MachineLearningEnvironmentContainerCollection"/> class for mocking. </summary>
        protected MachineLearningEnvironmentContainerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MachineLearningEnvironmentContainerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MachineLearningEnvironmentContainerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _machineLearningEnvironmentContainerEnvironmentContainersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", MachineLearningEnvironmentContainerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MachineLearningEnvironmentContainerResource.ResourceType, out string machineLearningEnvironmentContainerEnvironmentContainersApiVersion);
            _machineLearningEnvironmentContainerEnvironmentContainersRestClient = new EnvironmentContainersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, machineLearningEnvironmentContainerEnvironmentContainersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MachineLearningWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MachineLearningWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EnvironmentContainers_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningEnvironmentContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Container name. This is case-sensitive. </param>
        /// <param name="data"> Container entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MachineLearningEnvironmentContainerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, MachineLearningEnvironmentContainerData data, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(name));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _machineLearningEnvironmentContainerEnvironmentContainersClientDiagnostics.CreateScope("MachineLearningEnvironmentContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _machineLearningEnvironmentContainerEnvironmentContainersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken).ConfigureAwait(false);
                var uri = _machineLearningEnvironmentContainerEnvironmentContainersRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new MachineLearningArmOperation<MachineLearningEnvironmentContainerResource>(Response.FromValue(new MachineLearningEnvironmentContainerResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Create or update container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EnvironmentContainers_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningEnvironmentContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Container name. This is case-sensitive. </param>
        /// <param name="data"> Container entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MachineLearningEnvironmentContainerResource> CreateOrUpdate(WaitUntil waitUntil, string name, MachineLearningEnvironmentContainerData data, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(name));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _machineLearningEnvironmentContainerEnvironmentContainersClientDiagnostics.CreateScope("MachineLearningEnvironmentContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _machineLearningEnvironmentContainerEnvironmentContainersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken);
                var uri = _machineLearningEnvironmentContainerEnvironmentContainersRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new MachineLearningArmOperation<MachineLearningEnvironmentContainerResource>(Response.FromValue(new MachineLearningEnvironmentContainerResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Get container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EnvironmentContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningEnvironmentContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Container name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<MachineLearningEnvironmentContainerResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(name));
            }

            using var scope = _machineLearningEnvironmentContainerEnvironmentContainersClientDiagnostics.CreateScope("MachineLearningEnvironmentContainerCollection.Get");
            scope.Start();
            try
            {
                var response = await _machineLearningEnvironmentContainerEnvironmentContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningEnvironmentContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EnvironmentContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningEnvironmentContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Container name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<MachineLearningEnvironmentContainerResource> Get(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(name));
            }

            using var scope = _machineLearningEnvironmentContainerEnvironmentContainersClientDiagnostics.CreateScope("MachineLearningEnvironmentContainerCollection.Get");
            scope.Start();
            try
            {
                var response = _machineLearningEnvironmentContainerEnvironmentContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningEnvironmentContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List environment containers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EnvironmentContainers_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningEnvironmentContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="listViewType"> View type for including/excluding (for example) archived entities. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MachineLearningEnvironmentContainerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MachineLearningEnvironmentContainerResource> GetAllAsync(string skip = null, MachineLearningListViewType? listViewType = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningEnvironmentContainerEnvironmentContainersRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, listViewType);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningEnvironmentContainerEnvironmentContainersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, listViewType);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MachineLearningEnvironmentContainerResource(Client, MachineLearningEnvironmentContainerData.DeserializeMachineLearningEnvironmentContainerData(e)), _machineLearningEnvironmentContainerEnvironmentContainersClientDiagnostics, Pipeline, "MachineLearningEnvironmentContainerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List environment containers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EnvironmentContainers_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningEnvironmentContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="listViewType"> View type for including/excluding (for example) archived entities. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MachineLearningEnvironmentContainerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MachineLearningEnvironmentContainerResource> GetAll(string skip = null, MachineLearningListViewType? listViewType = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningEnvironmentContainerEnvironmentContainersRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, listViewType);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningEnvironmentContainerEnvironmentContainersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, listViewType);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MachineLearningEnvironmentContainerResource(Client, MachineLearningEnvironmentContainerData.DeserializeMachineLearningEnvironmentContainerData(e)), _machineLearningEnvironmentContainerEnvironmentContainersClientDiagnostics, Pipeline, "MachineLearningEnvironmentContainerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EnvironmentContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningEnvironmentContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Container name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(name));
            }

            using var scope = _machineLearningEnvironmentContainerEnvironmentContainersClientDiagnostics.CreateScope("MachineLearningEnvironmentContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _machineLearningEnvironmentContainerEnvironmentContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EnvironmentContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningEnvironmentContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Container name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(name));
            }

            using var scope = _machineLearningEnvironmentContainerEnvironmentContainersClientDiagnostics.CreateScope("MachineLearningEnvironmentContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = _machineLearningEnvironmentContainerEnvironmentContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EnvironmentContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningEnvironmentContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Container name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<NullableResponse<MachineLearningEnvironmentContainerResource>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(name));
            }

            using var scope = _machineLearningEnvironmentContainerEnvironmentContainersClientDiagnostics.CreateScope("MachineLearningEnvironmentContainerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _machineLearningEnvironmentContainerEnvironmentContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearningEnvironmentContainerResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearningEnvironmentContainerResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EnvironmentContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningEnvironmentContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Container name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual NullableResponse<MachineLearningEnvironmentContainerResource> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(name));
            }

            using var scope = _machineLearningEnvironmentContainerEnvironmentContainersClientDiagnostics.CreateScope("MachineLearningEnvironmentContainerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _machineLearningEnvironmentContainerEnvironmentContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearningEnvironmentContainerResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearningEnvironmentContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MachineLearningEnvironmentContainerResource> IEnumerable<MachineLearningEnvironmentContainerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MachineLearningEnvironmentContainerResource> IAsyncEnumerable<MachineLearningEnvironmentContainerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
