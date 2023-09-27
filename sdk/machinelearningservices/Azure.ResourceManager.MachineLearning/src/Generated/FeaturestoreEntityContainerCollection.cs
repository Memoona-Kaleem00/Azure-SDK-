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
    /// A class representing a collection of <see cref="FeaturestoreEntityContainerResource" /> and their operations.
    /// Each <see cref="FeaturestoreEntityContainerResource" /> in the collection will belong to the same instance of <see cref="MachineLearningWorkspaceResource" />.
    /// To get a <see cref="FeaturestoreEntityContainerCollection" /> instance call the GetFeaturestoreEntityContainers method from an instance of <see cref="MachineLearningWorkspaceResource" />.
    /// </summary>
    public partial class FeaturestoreEntityContainerCollection : ArmCollection, IEnumerable<FeaturestoreEntityContainerResource>, IAsyncEnumerable<FeaturestoreEntityContainerResource>
    {
        private readonly ClientDiagnostics _featurestoreEntityContainerClientDiagnostics;
        private readonly FeaturestoreEntityContainersRestOperations _featurestoreEntityContainerRestClient;

        /// <summary> Initializes a new instance of the <see cref="FeaturestoreEntityContainerCollection"/> class for mocking. </summary>
        protected FeaturestoreEntityContainerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FeaturestoreEntityContainerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FeaturestoreEntityContainerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _featurestoreEntityContainerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", FeaturestoreEntityContainerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(FeaturestoreEntityContainerResource.ResourceType, out string featurestoreEntityContainerApiVersion);
            _featurestoreEntityContainerRestClient = new FeaturestoreEntityContainersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, featurestoreEntityContainerApiVersion);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featurestoreEntities/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturestoreEntityContainers_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Container name. This is case-sensitive. </param>
        /// <param name="data"> Container entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<FeaturestoreEntityContainerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, FeaturestoreEntityContainerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _featurestoreEntityContainerClientDiagnostics.CreateScope("FeaturestoreEntityContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _featurestoreEntityContainerRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<FeaturestoreEntityContainerResource>(new FeaturestoreEntityContainerOperationSource(Client), _featurestoreEntityContainerClientDiagnostics, Pipeline, _featurestoreEntityContainerRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featurestoreEntities/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturestoreEntityContainers_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Container name. This is case-sensitive. </param>
        /// <param name="data"> Container entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<FeaturestoreEntityContainerResource> CreateOrUpdate(WaitUntil waitUntil, string name, FeaturestoreEntityContainerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _featurestoreEntityContainerClientDiagnostics.CreateScope("FeaturestoreEntityContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _featurestoreEntityContainerRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken);
                var operation = new MachineLearningArmOperation<FeaturestoreEntityContainerResource>(new FeaturestoreEntityContainerOperationSource(Client), _featurestoreEntityContainerClientDiagnostics, Pipeline, _featurestoreEntityContainerRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featurestoreEntities/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturestoreEntityContainers_GetEntity</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Container name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<FeaturestoreEntityContainerResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _featurestoreEntityContainerClientDiagnostics.CreateScope("FeaturestoreEntityContainerCollection.Get");
            scope.Start();
            try
            {
                var response = await _featurestoreEntityContainerRestClient.GetEntityAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FeaturestoreEntityContainerResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featurestoreEntities/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturestoreEntityContainers_GetEntity</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Container name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<FeaturestoreEntityContainerResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _featurestoreEntityContainerClientDiagnostics.CreateScope("FeaturestoreEntityContainerCollection.Get");
            scope.Start();
            try
            {
                var response = _featurestoreEntityContainerRestClient.GetEntity(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FeaturestoreEntityContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List featurestore entity containers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featurestoreEntities</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturestoreEntityContainers_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FeaturestoreEntityContainerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FeaturestoreEntityContainerResource> GetAllAsync(FeaturestoreEntityContainerCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new FeaturestoreEntityContainerCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _featurestoreEntityContainerRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options.Skip, options.Tags, options.ListViewType, pageSizeHint, options.Name, options.Description, options.CreatedBy);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _featurestoreEntityContainerRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options.Skip, options.Tags, options.ListViewType, pageSizeHint, options.Name, options.Description, options.CreatedBy);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new FeaturestoreEntityContainerResource(Client, FeaturestoreEntityContainerData.DeserializeFeaturestoreEntityContainerData(e)), _featurestoreEntityContainerClientDiagnostics, Pipeline, "FeaturestoreEntityContainerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List featurestore entity containers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featurestoreEntities</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturestoreEntityContainers_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FeaturestoreEntityContainerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FeaturestoreEntityContainerResource> GetAll(FeaturestoreEntityContainerCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new FeaturestoreEntityContainerCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _featurestoreEntityContainerRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options.Skip, options.Tags, options.ListViewType, pageSizeHint, options.Name, options.Description, options.CreatedBy);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _featurestoreEntityContainerRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options.Skip, options.Tags, options.ListViewType, pageSizeHint, options.Name, options.Description, options.CreatedBy);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new FeaturestoreEntityContainerResource(Client, FeaturestoreEntityContainerData.DeserializeFeaturestoreEntityContainerData(e)), _featurestoreEntityContainerClientDiagnostics, Pipeline, "FeaturestoreEntityContainerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featurestoreEntities/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturestoreEntityContainers_GetEntity</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Container name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _featurestoreEntityContainerClientDiagnostics.CreateScope("FeaturestoreEntityContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _featurestoreEntityContainerRestClient.GetEntityAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featurestoreEntities/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturestoreEntityContainers_GetEntity</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Container name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _featurestoreEntityContainerClientDiagnostics.CreateScope("FeaturestoreEntityContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = _featurestoreEntityContainerRestClient.GetEntity(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featurestoreEntities/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturestoreEntityContainers_GetEntity</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Container name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<NullableResponse<FeaturestoreEntityContainerResource>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _featurestoreEntityContainerClientDiagnostics.CreateScope("FeaturestoreEntityContainerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _featurestoreEntityContainerRestClient.GetEntityAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<FeaturestoreEntityContainerResource>(response.GetRawResponse());
                return Response.FromValue(new FeaturestoreEntityContainerResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featurestoreEntities/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturestoreEntityContainers_GetEntity</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Container name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual NullableResponse<FeaturestoreEntityContainerResource> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _featurestoreEntityContainerClientDiagnostics.CreateScope("FeaturestoreEntityContainerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _featurestoreEntityContainerRestClient.GetEntity(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<FeaturestoreEntityContainerResource>(response.GetRawResponse());
                return Response.FromValue(new FeaturestoreEntityContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FeaturestoreEntityContainerResource> IEnumerable<FeaturestoreEntityContainerResource>.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IAsyncEnumerator<FeaturestoreEntityContainerResource> IAsyncEnumerable<FeaturestoreEntityContainerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(options: null, cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
