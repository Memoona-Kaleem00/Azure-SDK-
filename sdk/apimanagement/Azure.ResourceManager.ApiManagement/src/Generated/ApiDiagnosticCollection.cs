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

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ApiDiagnosticResource"/> and their operations.
    /// Each <see cref="ApiDiagnosticResource"/> in the collection will belong to the same instance of <see cref="ApiResource"/>.
    /// To get an <see cref="ApiDiagnosticCollection"/> instance call the GetApiDiagnostics method from an instance of <see cref="ApiResource"/>.
    /// </summary>
    public partial class ApiDiagnosticCollection : ArmCollection, IEnumerable<ApiDiagnosticResource>, IAsyncEnumerable<ApiDiagnosticResource>
    {
        private readonly ClientDiagnostics _apiDiagnosticClientDiagnostics;
        private readonly ApiDiagnosticRestOperations _apiDiagnosticRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiDiagnosticCollection"/> class for mocking. </summary>
        protected ApiDiagnosticCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiDiagnosticCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiDiagnosticCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiDiagnosticClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiDiagnosticResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiDiagnosticResource.ResourceType, out string apiDiagnosticApiVersion);
            _apiDiagnosticRestClient = new ApiDiagnosticRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiDiagnosticApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new Diagnostic for an API or updates an existing one.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics/{diagnosticId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiDiagnostic_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.ApiManagement/service/apis/diagnostics</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="diagnosticId"> Diagnostic identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiDiagnosticResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string diagnosticId, DiagnosticContractData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticId, nameof(diagnosticId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiDiagnosticClientDiagnostics.CreateScope("ApiDiagnosticCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiDiagnosticRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, diagnosticId, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ApiDiagnosticResource>(Response.FromValue(new ApiDiagnosticResource(Client, response), response.GetRawResponse()));
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
        /// Creates a new Diagnostic for an API or updates an existing one.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics/{diagnosticId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiDiagnostic_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.ApiManagement/service/apis/diagnostics</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="diagnosticId"> Diagnostic identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ApiDiagnosticResource> CreateOrUpdate(WaitUntil waitUntil, string diagnosticId, DiagnosticContractData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticId, nameof(diagnosticId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiDiagnosticClientDiagnostics.CreateScope("ApiDiagnosticCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiDiagnosticRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, diagnosticId, data, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ApiDiagnosticResource>(Response.FromValue(new ApiDiagnosticResource(Client, response), response.GetRawResponse()));
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
        /// Gets the details of the Diagnostic for an API specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics/{diagnosticId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiDiagnostic_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.ApiManagement/service/apis/diagnostics</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diagnosticId"> Diagnostic identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticId"/> is null. </exception>
        public virtual async Task<Response<ApiDiagnosticResource>> GetAsync(string diagnosticId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticId, nameof(diagnosticId));

            using var scope = _apiDiagnosticClientDiagnostics.CreateScope("ApiDiagnosticCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiDiagnosticRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, diagnosticId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiDiagnosticResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the Diagnostic for an API specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics/{diagnosticId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiDiagnostic_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.ApiManagement/service/apis/diagnostics</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diagnosticId"> Diagnostic identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticId"/> is null. </exception>
        public virtual Response<ApiDiagnosticResource> Get(string diagnosticId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticId, nameof(diagnosticId));

            using var scope = _apiDiagnosticClientDiagnostics.CreateScope("ApiDiagnosticCollection.Get");
            scope.Start();
            try
            {
                var response = _apiDiagnosticRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, diagnosticId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiDiagnosticResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all diagnostics of an API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiDiagnostic_ListByService</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.ApiManagement/service/apis/diagnostics</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiDiagnosticResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiDiagnosticResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiDiagnosticRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiDiagnosticRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ApiDiagnosticResource(Client, DiagnosticContractData.DeserializeDiagnosticContractData(e)), _apiDiagnosticClientDiagnostics, Pipeline, "ApiDiagnosticCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all diagnostics of an API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiDiagnostic_ListByService</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.ApiManagement/service/apis/diagnostics</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiDiagnosticResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiDiagnosticResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiDiagnosticRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiDiagnosticRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ApiDiagnosticResource(Client, DiagnosticContractData.DeserializeDiagnosticContractData(e)), _apiDiagnosticClientDiagnostics, Pipeline, "ApiDiagnosticCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics/{diagnosticId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiDiagnostic_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.ApiManagement/service/apis/diagnostics</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diagnosticId"> Diagnostic identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string diagnosticId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticId, nameof(diagnosticId));

            using var scope = _apiDiagnosticClientDiagnostics.CreateScope("ApiDiagnosticCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiDiagnosticRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, diagnosticId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics/{diagnosticId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiDiagnostic_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.ApiManagement/service/apis/diagnostics</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diagnosticId"> Diagnostic identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticId"/> is null. </exception>
        public virtual Response<bool> Exists(string diagnosticId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticId, nameof(diagnosticId));

            using var scope = _apiDiagnosticClientDiagnostics.CreateScope("ApiDiagnosticCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiDiagnosticRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, diagnosticId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics/{diagnosticId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiDiagnostic_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.ApiManagement/service/apis/diagnostics</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diagnosticId"> Diagnostic identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticId"/> is null. </exception>
        public virtual async Task<NullableResponse<ApiDiagnosticResource>> GetIfExistsAsync(string diagnosticId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticId, nameof(diagnosticId));

            using var scope = _apiDiagnosticClientDiagnostics.CreateScope("ApiDiagnosticCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _apiDiagnosticRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, diagnosticId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ApiDiagnosticResource>(response.GetRawResponse());
                return Response.FromValue(new ApiDiagnosticResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/diagnostics/{diagnosticId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiDiagnostic_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.ApiManagement/service/apis/diagnostics</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="diagnosticId"> Diagnostic identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diagnosticId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticId"/> is null. </exception>
        public virtual NullableResponse<ApiDiagnosticResource> GetIfExists(string diagnosticId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diagnosticId, nameof(diagnosticId));

            using var scope = _apiDiagnosticClientDiagnostics.CreateScope("ApiDiagnosticCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _apiDiagnosticRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, diagnosticId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ApiDiagnosticResource>(response.GetRawResponse());
                return Response.FromValue(new ApiDiagnosticResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiDiagnosticResource> IEnumerable<ApiDiagnosticResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiDiagnosticResource> IAsyncEnumerable<ApiDiagnosticResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
