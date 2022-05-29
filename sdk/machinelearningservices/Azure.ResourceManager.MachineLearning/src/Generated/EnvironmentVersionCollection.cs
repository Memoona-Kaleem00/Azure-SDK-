// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing a collection of <see cref="EnvironmentVersionResource" /> and their operations.
    /// Each <see cref="EnvironmentVersionResource" /> in the collection will belong to the same instance of <see cref="EnvironmentContainerResource" />.
    /// To get an <see cref="EnvironmentVersionCollection" /> instance call the GetEnvironmentVersions method from an instance of <see cref="EnvironmentContainerResource" />.
    /// </summary>
    public partial class EnvironmentVersionCollection : ArmCollection, IEnumerable<EnvironmentVersionResource>, IAsyncEnumerable<EnvironmentVersionResource>
    {
        private readonly ClientDiagnostics _environmentVersionClientDiagnostics;
        private readonly EnvironmentVersionsRestOperations _environmentVersionRestClient;

        /// <summary> Initializes a new instance of the <see cref="EnvironmentVersionCollection"/> class for mocking. </summary>
        protected EnvironmentVersionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EnvironmentVersionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal EnvironmentVersionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _environmentVersionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", EnvironmentVersionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(EnvironmentVersionResource.ResourceType, out string environmentVersionApiVersion);
            _environmentVersionRestClient = new EnvironmentVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, environmentVersionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != EnvironmentContainerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, EnvironmentContainerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an EnvironmentVersion.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}/versions/{version}
        /// Operation Id: EnvironmentVersions_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="version"> Version of EnvironmentVersion. </param>
        /// <param name="data"> Definition of EnvironmentVersion. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<EnvironmentVersionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string version, EnvironmentVersionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _environmentVersionClientDiagnostics.CreateScope("EnvironmentVersionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _environmentVersionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<EnvironmentVersionResource>(Response.FromValue(new EnvironmentVersionResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates an EnvironmentVersion.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}/versions/{version}
        /// Operation Id: EnvironmentVersions_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="version"> Version of EnvironmentVersion. </param>
        /// <param name="data"> Definition of EnvironmentVersion. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<EnvironmentVersionResource> CreateOrUpdate(WaitUntil waitUntil, string version, EnvironmentVersionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _environmentVersionClientDiagnostics.CreateScope("EnvironmentVersionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _environmentVersionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, data, cancellationToken);
                var operation = new MachineLearningArmOperation<EnvironmentVersionResource>(Response.FromValue(new EnvironmentVersionResource(Client, response), response.GetRawResponse()));
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
        /// Get version.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}/versions/{version}
        /// Operation Id: EnvironmentVersions_Get
        /// </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual async Task<Response<EnvironmentVersionResource>> GetAsync(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _environmentVersionClientDiagnostics.CreateScope("EnvironmentVersionCollection.Get");
            scope.Start();
            try
            {
                var response = await _environmentVersionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EnvironmentVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get version.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}/versions/{version}
        /// Operation Id: EnvironmentVersions_Get
        /// </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual Response<EnvironmentVersionResource> Get(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _environmentVersionClientDiagnostics.CreateScope("EnvironmentVersionCollection.Get");
            scope.Start();
            try
            {
                var response = _environmentVersionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EnvironmentVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List versions.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}/versions
        /// Operation Id: EnvironmentVersions_List
        /// </summary>
        /// <param name="options"> A class representing the optional parameters in GetAll method. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EnvironmentVersionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EnvironmentVersionResource> GetAllAsync(EnvironmentVersionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new EnvironmentVersionGetAllOptions();

            async Task<Page<EnvironmentVersionResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _environmentVersionClientDiagnostics.CreateScope("EnvironmentVersionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _environmentVersionRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, options.OrderBy, options.Top, options.Skip, options.ListViewType, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new EnvironmentVersionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<EnvironmentVersionResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _environmentVersionClientDiagnostics.CreateScope("EnvironmentVersionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _environmentVersionRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, options.OrderBy, options.Top, options.Skip, options.ListViewType, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new EnvironmentVersionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// List versions.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}/versions
        /// Operation Id: EnvironmentVersions_List
        /// </summary>
        /// <param name="options"> A class representing the optional parameters in GetAll method. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EnvironmentVersionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EnvironmentVersionResource> GetAll(EnvironmentVersionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new EnvironmentVersionGetAllOptions();

            Page<EnvironmentVersionResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _environmentVersionClientDiagnostics.CreateScope("EnvironmentVersionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _environmentVersionRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, options.OrderBy, options.Top, options.Skip, options.ListViewType, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new EnvironmentVersionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<EnvironmentVersionResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _environmentVersionClientDiagnostics.CreateScope("EnvironmentVersionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _environmentVersionRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, options.OrderBy, options.Top, options.Skip, options.ListViewType, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new EnvironmentVersionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}/versions/{version}
        /// Operation Id: EnvironmentVersions_Get
        /// </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _environmentVersionClientDiagnostics.CreateScope("EnvironmentVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _environmentVersionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/environments/{name}/versions/{version}
        /// Operation Id: EnvironmentVersions_Get
        /// </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual Response<bool> Exists(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _environmentVersionClientDiagnostics.CreateScope("EnvironmentVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = _environmentVersionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<EnvironmentVersionResource> IEnumerable<EnvironmentVersionResource>.GetEnumerator()
        {
            return GetAll(null).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll(null).GetEnumerator();
        }

        IAsyncEnumerator<EnvironmentVersionResource> IAsyncEnumerable<EnvironmentVersionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(null, cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
