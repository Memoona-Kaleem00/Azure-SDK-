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

namespace Azure.ResourceManager.OperationalInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="OperationalInsightsSavedSearchResource" /> and their operations.
    /// Each <see cref="OperationalInsightsSavedSearchResource" /> in the collection will belong to the same instance of <see cref="OperationalInsightsWorkspaceResource" />.
    /// To get an <see cref="OperationalInsightsSavedSearchCollection" /> instance call the GetOperationalInsightsSavedSearches method from an instance of <see cref="OperationalInsightsWorkspaceResource" />.
    /// </summary>
    public partial class OperationalInsightsSavedSearchCollection : ArmCollection, IEnumerable<OperationalInsightsSavedSearchResource>, IAsyncEnumerable<OperationalInsightsSavedSearchResource>
    {
        private readonly ClientDiagnostics _operationalInsightsSavedSearchSavedSearchesClientDiagnostics;
        private readonly SavedSearchesRestOperations _operationalInsightsSavedSearchSavedSearchesRestClient;

        /// <summary> Initializes a new instance of the <see cref="OperationalInsightsSavedSearchCollection"/> class for mocking. </summary>
        protected OperationalInsightsSavedSearchCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="OperationalInsightsSavedSearchCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal OperationalInsightsSavedSearchCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _operationalInsightsSavedSearchSavedSearchesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.OperationalInsights", OperationalInsightsSavedSearchResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(OperationalInsightsSavedSearchResource.ResourceType, out string operationalInsightsSavedSearchSavedSearchesApiVersion);
            _operationalInsightsSavedSearchSavedSearchesRestClient = new SavedSearchesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, operationalInsightsSavedSearchSavedSearchesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != OperationalInsightsWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, OperationalInsightsWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a saved search for a given workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/savedSearches/{savedSearchId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavedSearches_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="savedSearchId"> The id of the saved search. </param>
        /// <param name="data"> The parameters required to save a search. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="savedSearchId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="savedSearchId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<OperationalInsightsSavedSearchResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string savedSearchId, OperationalInsightsSavedSearchData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(savedSearchId, nameof(savedSearchId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _operationalInsightsSavedSearchSavedSearchesClientDiagnostics.CreateScope("OperationalInsightsSavedSearchCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _operationalInsightsSavedSearchSavedSearchesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, savedSearchId, data, cancellationToken).ConfigureAwait(false);
                var operation = new OperationalInsightsArmOperation<OperationalInsightsSavedSearchResource>(Response.FromValue(new OperationalInsightsSavedSearchResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a saved search for a given workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/savedSearches/{savedSearchId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavedSearches_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="savedSearchId"> The id of the saved search. </param>
        /// <param name="data"> The parameters required to save a search. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="savedSearchId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="savedSearchId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<OperationalInsightsSavedSearchResource> CreateOrUpdate(WaitUntil waitUntil, string savedSearchId, OperationalInsightsSavedSearchData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(savedSearchId, nameof(savedSearchId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _operationalInsightsSavedSearchSavedSearchesClientDiagnostics.CreateScope("OperationalInsightsSavedSearchCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _operationalInsightsSavedSearchSavedSearchesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, savedSearchId, data, cancellationToken);
                var operation = new OperationalInsightsArmOperation<OperationalInsightsSavedSearchResource>(Response.FromValue(new OperationalInsightsSavedSearchResource(Client, response), response.GetRawResponse()));
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
        /// Gets the specified saved search for a given workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/savedSearches/{savedSearchId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavedSearches_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="savedSearchId"> The id of the saved search. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="savedSearchId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="savedSearchId"/> is null. </exception>
        public virtual async Task<Response<OperationalInsightsSavedSearchResource>> GetAsync(string savedSearchId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(savedSearchId, nameof(savedSearchId));

            using var scope = _operationalInsightsSavedSearchSavedSearchesClientDiagnostics.CreateScope("OperationalInsightsSavedSearchCollection.Get");
            scope.Start();
            try
            {
                var response = await _operationalInsightsSavedSearchSavedSearchesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, savedSearchId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OperationalInsightsSavedSearchResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified saved search for a given workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/savedSearches/{savedSearchId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavedSearches_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="savedSearchId"> The id of the saved search. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="savedSearchId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="savedSearchId"/> is null. </exception>
        public virtual Response<OperationalInsightsSavedSearchResource> Get(string savedSearchId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(savedSearchId, nameof(savedSearchId));

            using var scope = _operationalInsightsSavedSearchSavedSearchesClientDiagnostics.CreateScope("OperationalInsightsSavedSearchCollection.Get");
            scope.Start();
            try
            {
                var response = _operationalInsightsSavedSearchSavedSearchesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, savedSearchId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OperationalInsightsSavedSearchResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the saved searches for a given Log Analytics Workspace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/savedSearches</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavedSearches_ListByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OperationalInsightsSavedSearchResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OperationalInsightsSavedSearchResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _operationalInsightsSavedSearchSavedSearchesRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new OperationalInsightsSavedSearchResource(Client, OperationalInsightsSavedSearchData.DeserializeOperationalInsightsSavedSearchData(e)), _operationalInsightsSavedSearchSavedSearchesClientDiagnostics, Pipeline, "OperationalInsightsSavedSearchCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets the saved searches for a given Log Analytics Workspace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/savedSearches</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavedSearches_ListByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OperationalInsightsSavedSearchResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OperationalInsightsSavedSearchResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _operationalInsightsSavedSearchSavedSearchesRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new OperationalInsightsSavedSearchResource(Client, OperationalInsightsSavedSearchData.DeserializeOperationalInsightsSavedSearchData(e)), _operationalInsightsSavedSearchSavedSearchesClientDiagnostics, Pipeline, "OperationalInsightsSavedSearchCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/savedSearches/{savedSearchId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavedSearches_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="savedSearchId"> The id of the saved search. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="savedSearchId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="savedSearchId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string savedSearchId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(savedSearchId, nameof(savedSearchId));

            using var scope = _operationalInsightsSavedSearchSavedSearchesClientDiagnostics.CreateScope("OperationalInsightsSavedSearchCollection.Exists");
            scope.Start();
            try
            {
                var response = await _operationalInsightsSavedSearchSavedSearchesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, savedSearchId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/savedSearches/{savedSearchId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavedSearches_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="savedSearchId"> The id of the saved search. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="savedSearchId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="savedSearchId"/> is null. </exception>
        public virtual Response<bool> Exists(string savedSearchId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(savedSearchId, nameof(savedSearchId));

            using var scope = _operationalInsightsSavedSearchSavedSearchesClientDiagnostics.CreateScope("OperationalInsightsSavedSearchCollection.Exists");
            scope.Start();
            try
            {
                var response = _operationalInsightsSavedSearchSavedSearchesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, savedSearchId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<OperationalInsightsSavedSearchResource> IEnumerable<OperationalInsightsSavedSearchResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<OperationalInsightsSavedSearchResource> IAsyncEnumerable<OperationalInsightsSavedSearchResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
