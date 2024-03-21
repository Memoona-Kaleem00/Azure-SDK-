// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.HybridConnectivity
{
    /// <summary>
    /// A class representing a collection of <see cref="EndpointResource"/> and their operations.
    /// Each <see cref="EndpointResource"/> in the collection will belong to the same instance of <see cref="ArmResource"/>.
    /// To get an <see cref="EndpointResourceCollection"/> instance call the GetEndpointResources method from an instance of <see cref="ArmResource"/>.
    /// </summary>
    public partial class EndpointResourceCollection : ArmCollection, IEnumerable<EndpointResource>, IAsyncEnumerable<EndpointResource>
    {
        private readonly ClientDiagnostics _endpointResourceEndpointsClientDiagnostics;
        private readonly EndpointsRestOperations _endpointResourceEndpointsRestClient;

        /// <summary> Initializes a new instance of the <see cref="EndpointResourceCollection"/> class for mocking. </summary>
        protected EndpointResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EndpointResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal EndpointResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _endpointResourceEndpointsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HybridConnectivity", EndpointResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(EndpointResource.ResourceType, out string endpointResourceEndpointsApiVersion);
            _endpointResourceEndpointsRestClient = new EndpointsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, endpointResourceEndpointsApiVersion);
        }

        /// <summary>
        /// Create or update the endpoint to the target resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-06-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="data"> Endpoint details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<EndpointResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string endpointName, EndpointResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(endpointName, nameof(endpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _endpointResourceEndpointsClientDiagnostics.CreateScope("EndpointResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _endpointResourceEndpointsRestClient.CreateOrUpdateAsync(Id, endpointName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HybridConnectivityArmOperation<EndpointResource>(Response.FromValue(new EndpointResource(Client, response), response.GetRawResponse()));
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
        /// Create or update the endpoint to the target resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-06-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="data"> Endpoint details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<EndpointResource> CreateOrUpdate(WaitUntil waitUntil, string endpointName, EndpointResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(endpointName, nameof(endpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _endpointResourceEndpointsClientDiagnostics.CreateScope("EndpointResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _endpointResourceEndpointsRestClient.CreateOrUpdate(Id, endpointName, data, cancellationToken);
                var operation = new HybridConnectivityArmOperation<EndpointResource>(Response.FromValue(new EndpointResource(Client, response), response.GetRawResponse()));
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
        /// Gets the endpoint to the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-06-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual async Task<Response<EndpointResource>> GetAsync(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(endpointName, nameof(endpointName));

            using var scope = _endpointResourceEndpointsClientDiagnostics.CreateScope("EndpointResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _endpointResourceEndpointsRestClient.GetAsync(Id, endpointName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the endpoint to the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-06-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual Response<EndpointResource> Get(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(endpointName, nameof(endpointName));

            using var scope = _endpointResourceEndpointsClientDiagnostics.CreateScope("EndpointResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _endpointResourceEndpointsRestClient.Get(Id, endpointName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List of endpoints to the target resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-06-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EndpointResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EndpointResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _endpointResourceEndpointsRestClient.CreateListRequest(Id);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _endpointResourceEndpointsRestClient.CreateListNextPageRequest(nextLink, Id);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new EndpointResource(Client, EndpointResourceData.DeserializeEndpointResourceData(e)), _endpointResourceEndpointsClientDiagnostics, Pipeline, "EndpointResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of endpoints to the target resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-06-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EndpointResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EndpointResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _endpointResourceEndpointsRestClient.CreateListRequest(Id);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _endpointResourceEndpointsRestClient.CreateListNextPageRequest(nextLink, Id);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new EndpointResource(Client, EndpointResourceData.DeserializeEndpointResourceData(e)), _endpointResourceEndpointsClientDiagnostics, Pipeline, "EndpointResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-06-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(endpointName, nameof(endpointName));

            using var scope = _endpointResourceEndpointsClientDiagnostics.CreateScope("EndpointResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _endpointResourceEndpointsRestClient.GetAsync(Id, endpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-06-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual Response<bool> Exists(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(endpointName, nameof(endpointName));

            using var scope = _endpointResourceEndpointsClientDiagnostics.CreateScope("EndpointResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _endpointResourceEndpointsRestClient.Get(Id, endpointName, cancellationToken: cancellationToken);
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
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-06-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual async Task<NullableResponse<EndpointResource>> GetIfExistsAsync(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(endpointName, nameof(endpointName));

            using var scope = _endpointResourceEndpointsClientDiagnostics.CreateScope("EndpointResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _endpointResourceEndpointsRestClient.GetAsync(Id, endpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<EndpointResource>(response.GetRawResponse());
                return Response.FromValue(new EndpointResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-06-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual NullableResponse<EndpointResource> GetIfExists(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(endpointName, nameof(endpointName));

            using var scope = _endpointResourceEndpointsClientDiagnostics.CreateScope("EndpointResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _endpointResourceEndpointsRestClient.Get(Id, endpointName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<EndpointResource>(response.GetRawResponse());
                return Response.FromValue(new EndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<EndpointResource> IEnumerable<EndpointResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<EndpointResource> IAsyncEnumerable<EndpointResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
