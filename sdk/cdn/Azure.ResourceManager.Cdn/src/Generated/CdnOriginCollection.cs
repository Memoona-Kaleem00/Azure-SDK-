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

namespace Azure.ResourceManager.Cdn
{
    /// <summary>
    /// A class representing a collection of <see cref="CdnOriginResource" /> and their operations.
    /// Each <see cref="CdnOriginResource" /> in the collection will belong to the same instance of <see cref="CdnEndpointResource" />.
    /// To get a <see cref="CdnOriginCollection" /> instance call the GetCdnOrigins method from an instance of <see cref="CdnEndpointResource" />.
    /// </summary>
    public partial class CdnOriginCollection : ArmCollection, IEnumerable<CdnOriginResource>, IAsyncEnumerable<CdnOriginResource>
    {
        private readonly ClientDiagnostics _cdnOriginClientDiagnostics;
        private readonly CdnOriginsRestOperations _cdnOriginRestClient;

        /// <summary> Initializes a new instance of the <see cref="CdnOriginCollection"/> class for mocking. </summary>
        protected CdnOriginCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CdnOriginCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CdnOriginCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cdnOriginClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Cdn", CdnOriginResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CdnOriginResource.ResourceType, out string cdnOriginApiVersion);
            _cdnOriginRestClient = new CdnOriginsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cdnOriginApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CdnEndpointResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CdnEndpointResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new origin within the specified endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/endpoints/{endpointName}/origins/{originName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CdnOrigins_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="originName"> Name of the origin that is unique within the endpoint. </param>
        /// <param name="data"> Origin properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CdnOriginResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string originName, CdnOriginData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originName, nameof(originName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cdnOriginClientDiagnostics.CreateScope("CdnOriginCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _cdnOriginRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CdnArmOperation<CdnOriginResource>(new CdnOriginOperationSource(Client), _cdnOriginClientDiagnostics, Pipeline, _cdnOriginRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a new origin within the specified endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/endpoints/{endpointName}/origins/{originName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CdnOrigins_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="originName"> Name of the origin that is unique within the endpoint. </param>
        /// <param name="data"> Origin properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CdnOriginResource> CreateOrUpdate(WaitUntil waitUntil, string originName, CdnOriginData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originName, nameof(originName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cdnOriginClientDiagnostics.CreateScope("CdnOriginCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _cdnOriginRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originName, data, cancellationToken);
                var operation = new CdnArmOperation<CdnOriginResource>(new CdnOriginOperationSource(Client), _cdnOriginClientDiagnostics, Pipeline, _cdnOriginRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets an existing origin within an endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/endpoints/{endpointName}/origins/{originName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CdnOrigins_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="originName"> Name of the origin which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originName"/> is null. </exception>
        public virtual async Task<Response<CdnOriginResource>> GetAsync(string originName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originName, nameof(originName));

            using var scope = _cdnOriginClientDiagnostics.CreateScope("CdnOriginCollection.Get");
            scope.Start();
            try
            {
                var response = await _cdnOriginRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CdnOriginResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an existing origin within an endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/endpoints/{endpointName}/origins/{originName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CdnOrigins_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="originName"> Name of the origin which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originName"/> is null. </exception>
        public virtual Response<CdnOriginResource> Get(string originName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originName, nameof(originName));

            using var scope = _cdnOriginClientDiagnostics.CreateScope("CdnOriginCollection.Get");
            scope.Start();
            try
            {
                var response = _cdnOriginRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CdnOriginResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the existing origins within an endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/endpoints/{endpointName}/origins</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CdnOrigins_ListByEndpoint</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CdnOriginResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CdnOriginResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cdnOriginRestClient.CreateListByEndpointRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _cdnOriginRestClient.CreateListByEndpointNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new CdnOriginResource(Client, CdnOriginData.DeserializeCdnOriginData(e)), _cdnOriginClientDiagnostics, Pipeline, "CdnOriginCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the existing origins within an endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/endpoints/{endpointName}/origins</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CdnOrigins_ListByEndpoint</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CdnOriginResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CdnOriginResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cdnOriginRestClient.CreateListByEndpointRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _cdnOriginRestClient.CreateListByEndpointNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new CdnOriginResource(Client, CdnOriginData.DeserializeCdnOriginData(e)), _cdnOriginClientDiagnostics, Pipeline, "CdnOriginCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/endpoints/{endpointName}/origins/{originName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CdnOrigins_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="originName"> Name of the origin which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string originName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originName, nameof(originName));

            using var scope = _cdnOriginClientDiagnostics.CreateScope("CdnOriginCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cdnOriginRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/endpoints/{endpointName}/origins/{originName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CdnOrigins_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="originName"> Name of the origin which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originName"/> is null. </exception>
        public virtual Response<bool> Exists(string originName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originName, nameof(originName));

            using var scope = _cdnOriginClientDiagnostics.CreateScope("CdnOriginCollection.Exists");
            scope.Start();
            try
            {
                var response = _cdnOriginRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/endpoints/{endpointName}/origins/{originName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CdnOrigins_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="originName"> Name of the origin which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originName"/> is null. </exception>
        public virtual async Task<NullableResponse<CdnOriginResource>> GetIfExistsAsync(string originName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originName, nameof(originName));

            using var scope = _cdnOriginClientDiagnostics.CreateScope("CdnOriginCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cdnOriginRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CdnOriginResource>(response.GetRawResponse());
                return Response.FromValue(new CdnOriginResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/endpoints/{endpointName}/origins/{originName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CdnOrigins_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="originName"> Name of the origin which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originName"/> is null. </exception>
        public virtual NullableResponse<CdnOriginResource> GetIfExists(string originName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originName, nameof(originName));

            using var scope = _cdnOriginClientDiagnostics.CreateScope("CdnOriginCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cdnOriginRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CdnOriginResource>(response.GetRawResponse());
                return Response.FromValue(new CdnOriginResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CdnOriginResource> IEnumerable<CdnOriginResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CdnOriginResource> IAsyncEnumerable<CdnOriginResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
