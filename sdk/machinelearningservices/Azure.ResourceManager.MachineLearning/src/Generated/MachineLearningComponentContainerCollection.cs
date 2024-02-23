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
    /// A class representing a collection of <see cref="MachineLearningComponentContainerResource"/> and their operations.
    /// Each <see cref="MachineLearningComponentContainerResource"/> in the collection will belong to the same instance of <see cref="MachineLearningWorkspaceResource"/>.
    /// To get a <see cref="MachineLearningComponentContainerCollection"/> instance call the GetMachineLearningComponentContainers method from an instance of <see cref="MachineLearningWorkspaceResource"/>.
    /// </summary>
    public partial class MachineLearningComponentContainerCollection : ArmCollection, IEnumerable<MachineLearningComponentContainerResource>, IAsyncEnumerable<MachineLearningComponentContainerResource>
    {
        private readonly ClientDiagnostics _machineLearningComponentContainerComponentContainersClientDiagnostics;
        private readonly ComponentContainersRestOperations _machineLearningComponentContainerComponentContainersRestClient;

        /// <summary> Initializes a new instance of the <see cref="MachineLearningComponentContainerCollection"/> class for mocking. </summary>
        protected MachineLearningComponentContainerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MachineLearningComponentContainerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MachineLearningComponentContainerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _machineLearningComponentContainerComponentContainersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", MachineLearningComponentContainerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MachineLearningComponentContainerResource.ResourceType, out string machineLearningComponentContainerComponentContainersApiVersion);
            _machineLearningComponentContainerComponentContainersRestClient = new ComponentContainersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, machineLearningComponentContainerComponentContainersApiVersion);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/components/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ComponentContainers_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningComponentContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Container name. </param>
        /// <param name="data"> Container entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MachineLearningComponentContainerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, MachineLearningComponentContainerData data, CancellationToken cancellationToken = default)
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

            using var scope = _machineLearningComponentContainerComponentContainersClientDiagnostics.CreateScope("MachineLearningComponentContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _machineLearningComponentContainerComponentContainersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken).ConfigureAwait(false);
                var uri = _machineLearningComponentContainerComponentContainersRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new MachineLearningArmOperation<MachineLearningComponentContainerResource>(Response.FromValue(new MachineLearningComponentContainerResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/components/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ComponentContainers_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningComponentContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Container name. </param>
        /// <param name="data"> Container entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MachineLearningComponentContainerResource> CreateOrUpdate(WaitUntil waitUntil, string name, MachineLearningComponentContainerData data, CancellationToken cancellationToken = default)
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

            using var scope = _machineLearningComponentContainerComponentContainersClientDiagnostics.CreateScope("MachineLearningComponentContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _machineLearningComponentContainerComponentContainersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken);
                var uri = _machineLearningComponentContainerComponentContainersRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new MachineLearningArmOperation<MachineLearningComponentContainerResource>(Response.FromValue(new MachineLearningComponentContainerResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/components/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ComponentContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningComponentContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<MachineLearningComponentContainerResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(name));
            }

            using var scope = _machineLearningComponentContainerComponentContainersClientDiagnostics.CreateScope("MachineLearningComponentContainerCollection.Get");
            scope.Start();
            try
            {
                var response = await _machineLearningComponentContainerComponentContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningComponentContainerResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/components/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ComponentContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningComponentContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<MachineLearningComponentContainerResource> Get(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(name));
            }

            using var scope = _machineLearningComponentContainerComponentContainersClientDiagnostics.CreateScope("MachineLearningComponentContainerCollection.Get");
            scope.Start();
            try
            {
                var response = _machineLearningComponentContainerComponentContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningComponentContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List component containers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/components</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ComponentContainers_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningComponentContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="listViewType"> View type for including/excluding (for example) archived entities. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MachineLearningComponentContainerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MachineLearningComponentContainerResource> GetAllAsync(string skip = null, MachineLearningListViewType? listViewType = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningComponentContainerComponentContainersRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, listViewType);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningComponentContainerComponentContainersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, listViewType);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MachineLearningComponentContainerResource(Client, MachineLearningComponentContainerData.DeserializeMachineLearningComponentContainerData(e)), _machineLearningComponentContainerComponentContainersClientDiagnostics, Pipeline, "MachineLearningComponentContainerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List component containers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/components</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ComponentContainers_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningComponentContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="listViewType"> View type for including/excluding (for example) archived entities. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MachineLearningComponentContainerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MachineLearningComponentContainerResource> GetAll(string skip = null, MachineLearningListViewType? listViewType = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningComponentContainerComponentContainersRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, listViewType);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningComponentContainerComponentContainersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, listViewType);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MachineLearningComponentContainerResource(Client, MachineLearningComponentContainerData.DeserializeMachineLearningComponentContainerData(e)), _machineLearningComponentContainerComponentContainersClientDiagnostics, Pipeline, "MachineLearningComponentContainerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/components/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ComponentContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningComponentContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Container name. </param>
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

            using var scope = _machineLearningComponentContainerComponentContainersClientDiagnostics.CreateScope("MachineLearningComponentContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _machineLearningComponentContainerComponentContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/components/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ComponentContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningComponentContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Container name. </param>
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

            using var scope = _machineLearningComponentContainerComponentContainersClientDiagnostics.CreateScope("MachineLearningComponentContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = _machineLearningComponentContainerComponentContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/components/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ComponentContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningComponentContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<NullableResponse<MachineLearningComponentContainerResource>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(name));
            }

            using var scope = _machineLearningComponentContainerComponentContainersClientDiagnostics.CreateScope("MachineLearningComponentContainerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _machineLearningComponentContainerComponentContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearningComponentContainerResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearningComponentContainerResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/components/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ComponentContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningComponentContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual NullableResponse<MachineLearningComponentContainerResource> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (name.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(name));
            }

            using var scope = _machineLearningComponentContainerComponentContainersClientDiagnostics.CreateScope("MachineLearningComponentContainerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _machineLearningComponentContainerComponentContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearningComponentContainerResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearningComponentContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MachineLearningComponentContainerResource> IEnumerable<MachineLearningComponentContainerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MachineLearningComponentContainerResource> IAsyncEnumerable<MachineLearningComponentContainerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
