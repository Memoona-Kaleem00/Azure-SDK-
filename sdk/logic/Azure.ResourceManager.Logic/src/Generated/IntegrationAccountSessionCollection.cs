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

namespace Azure.ResourceManager.Logic
{
    /// <summary>
    /// A class representing a collection of <see cref="IntegrationAccountSessionResource"/> and their operations.
    /// Each <see cref="IntegrationAccountSessionResource"/> in the collection will belong to the same instance of <see cref="IntegrationAccountResource"/>.
    /// To get an <see cref="IntegrationAccountSessionCollection"/> instance call the GetIntegrationAccountSessions method from an instance of <see cref="IntegrationAccountResource"/>.
    /// </summary>
    public partial class IntegrationAccountSessionCollection : ArmCollection, IEnumerable<IntegrationAccountSessionResource>, IAsyncEnumerable<IntegrationAccountSessionResource>
    {
        private readonly ClientDiagnostics _integrationAccountSessionClientDiagnostics;
        private readonly IntegrationAccountSessionsRestOperations _integrationAccountSessionRestClient;

        /// <summary> Initializes a new instance of the <see cref="IntegrationAccountSessionCollection"/> class for mocking. </summary>
        protected IntegrationAccountSessionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="IntegrationAccountSessionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal IntegrationAccountSessionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _integrationAccountSessionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Logic", IntegrationAccountSessionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(IntegrationAccountSessionResource.ResourceType, out string integrationAccountSessionApiVersion);
            _integrationAccountSessionRestClient = new IntegrationAccountSessionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, integrationAccountSessionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != IntegrationAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, IntegrationAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an integration account session.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/sessions/{sessionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountSessions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IntegrationAccountSessionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sessionName"> The integration account session name. </param>
        /// <param name="data"> The integration account session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sessionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sessionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<IntegrationAccountSessionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string sessionName, IntegrationAccountSessionData data, CancellationToken cancellationToken = default)
        {
            if (sessionName == null)
            {
                throw new ArgumentNullException(nameof(sessionName));
            }
            if (sessionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sessionName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _integrationAccountSessionClientDiagnostics.CreateScope("IntegrationAccountSessionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _integrationAccountSessionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sessionName, data, cancellationToken).ConfigureAwait(false);
                var uri = _integrationAccountSessionRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sessionName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new LogicArmOperation<IntegrationAccountSessionResource>(Response.FromValue(new IntegrationAccountSessionResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Creates or updates an integration account session.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/sessions/{sessionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountSessions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IntegrationAccountSessionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sessionName"> The integration account session name. </param>
        /// <param name="data"> The integration account session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sessionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sessionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<IntegrationAccountSessionResource> CreateOrUpdate(WaitUntil waitUntil, string sessionName, IntegrationAccountSessionData data, CancellationToken cancellationToken = default)
        {
            if (sessionName == null)
            {
                throw new ArgumentNullException(nameof(sessionName));
            }
            if (sessionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sessionName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _integrationAccountSessionClientDiagnostics.CreateScope("IntegrationAccountSessionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _integrationAccountSessionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sessionName, data, cancellationToken);
                var uri = _integrationAccountSessionRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sessionName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new LogicArmOperation<IntegrationAccountSessionResource>(Response.FromValue(new IntegrationAccountSessionResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Gets an integration account session.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/sessions/{sessionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountSessions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IntegrationAccountSessionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sessionName"> The integration account session name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sessionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sessionName"/> is null. </exception>
        public virtual async Task<Response<IntegrationAccountSessionResource>> GetAsync(string sessionName, CancellationToken cancellationToken = default)
        {
            if (sessionName == null)
            {
                throw new ArgumentNullException(nameof(sessionName));
            }
            if (sessionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sessionName));
            }

            using var scope = _integrationAccountSessionClientDiagnostics.CreateScope("IntegrationAccountSessionCollection.Get");
            scope.Start();
            try
            {
                var response = await _integrationAccountSessionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sessionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IntegrationAccountSessionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an integration account session.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/sessions/{sessionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountSessions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IntegrationAccountSessionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sessionName"> The integration account session name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sessionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sessionName"/> is null. </exception>
        public virtual Response<IntegrationAccountSessionResource> Get(string sessionName, CancellationToken cancellationToken = default)
        {
            if (sessionName == null)
            {
                throw new ArgumentNullException(nameof(sessionName));
            }
            if (sessionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sessionName));
            }

            using var scope = _integrationAccountSessionClientDiagnostics.CreateScope("IntegrationAccountSessionCollection.Get");
            scope.Start();
            try
            {
                var response = _integrationAccountSessionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sessionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IntegrationAccountSessionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of integration account sessions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/sessions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountSessions_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IntegrationAccountSessionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="filter"> The filter to apply on the operation. Options for filters include: ChangedTime. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IntegrationAccountSessionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IntegrationAccountSessionResource> GetAllAsync(int? top = null, string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _integrationAccountSessionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _integrationAccountSessionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new IntegrationAccountSessionResource(Client, IntegrationAccountSessionData.DeserializeIntegrationAccountSessionData(e)), _integrationAccountSessionClientDiagnostics, Pipeline, "IntegrationAccountSessionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of integration account sessions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/sessions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountSessions_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IntegrationAccountSessionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="filter"> The filter to apply on the operation. Options for filters include: ChangedTime. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IntegrationAccountSessionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IntegrationAccountSessionResource> GetAll(int? top = null, string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _integrationAccountSessionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _integrationAccountSessionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new IntegrationAccountSessionResource(Client, IntegrationAccountSessionData.DeserializeIntegrationAccountSessionData(e)), _integrationAccountSessionClientDiagnostics, Pipeline, "IntegrationAccountSessionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/sessions/{sessionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountSessions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IntegrationAccountSessionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sessionName"> The integration account session name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sessionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sessionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string sessionName, CancellationToken cancellationToken = default)
        {
            if (sessionName == null)
            {
                throw new ArgumentNullException(nameof(sessionName));
            }
            if (sessionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sessionName));
            }

            using var scope = _integrationAccountSessionClientDiagnostics.CreateScope("IntegrationAccountSessionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _integrationAccountSessionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sessionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/sessions/{sessionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountSessions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IntegrationAccountSessionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sessionName"> The integration account session name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sessionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sessionName"/> is null. </exception>
        public virtual Response<bool> Exists(string sessionName, CancellationToken cancellationToken = default)
        {
            if (sessionName == null)
            {
                throw new ArgumentNullException(nameof(sessionName));
            }
            if (sessionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sessionName));
            }

            using var scope = _integrationAccountSessionClientDiagnostics.CreateScope("IntegrationAccountSessionCollection.Exists");
            scope.Start();
            try
            {
                var response = _integrationAccountSessionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sessionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/sessions/{sessionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountSessions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IntegrationAccountSessionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sessionName"> The integration account session name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sessionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sessionName"/> is null. </exception>
        public virtual async Task<NullableResponse<IntegrationAccountSessionResource>> GetIfExistsAsync(string sessionName, CancellationToken cancellationToken = default)
        {
            if (sessionName == null)
            {
                throw new ArgumentNullException(nameof(sessionName));
            }
            if (sessionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sessionName));
            }

            using var scope = _integrationAccountSessionClientDiagnostics.CreateScope("IntegrationAccountSessionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _integrationAccountSessionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sessionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<IntegrationAccountSessionResource>(response.GetRawResponse());
                return Response.FromValue(new IntegrationAccountSessionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/sessions/{sessionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountSessions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IntegrationAccountSessionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sessionName"> The integration account session name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sessionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sessionName"/> is null. </exception>
        public virtual NullableResponse<IntegrationAccountSessionResource> GetIfExists(string sessionName, CancellationToken cancellationToken = default)
        {
            if (sessionName == null)
            {
                throw new ArgumentNullException(nameof(sessionName));
            }
            if (sessionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(sessionName));
            }

            using var scope = _integrationAccountSessionClientDiagnostics.CreateScope("IntegrationAccountSessionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _integrationAccountSessionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sessionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<IntegrationAccountSessionResource>(response.GetRawResponse());
                return Response.FromValue(new IntegrationAccountSessionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<IntegrationAccountSessionResource> IEnumerable<IntegrationAccountSessionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<IntegrationAccountSessionResource> IAsyncEnumerable<IntegrationAccountSessionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
