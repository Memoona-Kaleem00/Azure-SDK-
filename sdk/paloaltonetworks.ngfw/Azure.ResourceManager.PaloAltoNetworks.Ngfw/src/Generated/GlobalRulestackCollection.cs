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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    /// <summary>
    /// A class representing a collection of <see cref="GlobalRulestackResource" /> and their operations.
    /// Each <see cref="GlobalRulestackResource" /> in the collection will belong to the same instance of <see cref="TenantResource" />.
    /// To get a <see cref="GlobalRulestackCollection" /> instance call the GetGlobalRulestacks method from an instance of <see cref="TenantResource" />.
    /// </summary>
    public partial class GlobalRulestackCollection : ArmCollection, IEnumerable<GlobalRulestackResource>, IAsyncEnumerable<GlobalRulestackResource>
    {
        private readonly ClientDiagnostics _globalRulestackClientDiagnostics;
        private readonly GlobalRulestackRestOperations _globalRulestackRestClient;

        /// <summary> Initializes a new instance of the <see cref="GlobalRulestackCollection"/> class for mocking. </summary>
        protected GlobalRulestackCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GlobalRulestackCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal GlobalRulestackCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _globalRulestackClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PaloAltoNetworks.Ngfw", GlobalRulestackResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(GlobalRulestackResource.ResourceType, out string globalRulestackApiVersion);
            _globalRulestackRestClient = new GlobalRulestackRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, globalRulestackApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TenantResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TenantResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a GlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalRulestack_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="globalRulestackName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<GlobalRulestackResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string globalRulestackName, GlobalRulestackData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(globalRulestackName, nameof(globalRulestackName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _globalRulestackClientDiagnostics.CreateScope("GlobalRulestackCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _globalRulestackRestClient.CreateOrUpdateAsync(globalRulestackName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NgfwArmOperation<GlobalRulestackResource>(new GlobalRulestackOperationSource(Client), _globalRulestackClientDiagnostics, Pipeline, _globalRulestackRestClient.CreateCreateOrUpdateRequest(globalRulestackName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a GlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalRulestack_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="globalRulestackName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<GlobalRulestackResource> CreateOrUpdate(WaitUntil waitUntil, string globalRulestackName, GlobalRulestackData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(globalRulestackName, nameof(globalRulestackName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _globalRulestackClientDiagnostics.CreateScope("GlobalRulestackCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _globalRulestackRestClient.CreateOrUpdate(globalRulestackName, data, cancellationToken);
                var operation = new NgfwArmOperation<GlobalRulestackResource>(new GlobalRulestackOperationSource(Client), _globalRulestackClientDiagnostics, Pipeline, _globalRulestackRestClient.CreateCreateOrUpdateRequest(globalRulestackName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a GlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="globalRulestackName"/> is null. </exception>
        public virtual async Task<Response<GlobalRulestackResource>> GetAsync(string globalRulestackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(globalRulestackName, nameof(globalRulestackName));

            using var scope = _globalRulestackClientDiagnostics.CreateScope("GlobalRulestackCollection.Get");
            scope.Start();
            try
            {
                var response = await _globalRulestackRestClient.GetAsync(globalRulestackName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GlobalRulestackResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a GlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="globalRulestackName"/> is null. </exception>
        public virtual Response<GlobalRulestackResource> Get(string globalRulestackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(globalRulestackName, nameof(globalRulestackName));

            using var scope = _globalRulestackClientDiagnostics.CreateScope("GlobalRulestackCollection.Get");
            scope.Start();
            try
            {
                var response = _globalRulestackRestClient.Get(globalRulestackName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GlobalRulestackResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List GlobalRulestackResource resources by Tenant
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalRulestack_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GlobalRulestackResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GlobalRulestackResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _globalRulestackRestClient.CreateListRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _globalRulestackRestClient.CreateListNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new GlobalRulestackResource(Client, GlobalRulestackData.DeserializeGlobalRulestackData(e)), _globalRulestackClientDiagnostics, Pipeline, "GlobalRulestackCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List GlobalRulestackResource resources by Tenant
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalRulestack_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GlobalRulestackResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GlobalRulestackResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _globalRulestackRestClient.CreateListRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _globalRulestackRestClient.CreateListNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new GlobalRulestackResource(Client, GlobalRulestackData.DeserializeGlobalRulestackData(e)), _globalRulestackClientDiagnostics, Pipeline, "GlobalRulestackCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="globalRulestackName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string globalRulestackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(globalRulestackName, nameof(globalRulestackName));

            using var scope = _globalRulestackClientDiagnostics.CreateScope("GlobalRulestackCollection.Exists");
            scope.Start();
            try
            {
                var response = await _globalRulestackRestClient.GetAsync(globalRulestackName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="globalRulestackName"/> is null. </exception>
        public virtual Response<bool> Exists(string globalRulestackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(globalRulestackName, nameof(globalRulestackName));

            using var scope = _globalRulestackClientDiagnostics.CreateScope("GlobalRulestackCollection.Exists");
            scope.Start();
            try
            {
                var response = _globalRulestackRestClient.Get(globalRulestackName, cancellationToken: cancellationToken);
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
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="globalRulestackName"/> is null. </exception>
        public virtual async Task<NullableResponse<GlobalRulestackResource>> GetIfExistsAsync(string globalRulestackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(globalRulestackName, nameof(globalRulestackName));

            using var scope = _globalRulestackClientDiagnostics.CreateScope("GlobalRulestackCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _globalRulestackRestClient.GetAsync(globalRulestackName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<GlobalRulestackResource>(response.GetRawResponse());
                return Response.FromValue(new GlobalRulestackResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="globalRulestackName"/> is null. </exception>
        public virtual NullableResponse<GlobalRulestackResource> GetIfExists(string globalRulestackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(globalRulestackName, nameof(globalRulestackName));

            using var scope = _globalRulestackClientDiagnostics.CreateScope("GlobalRulestackCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _globalRulestackRestClient.Get(globalRulestackName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<GlobalRulestackResource>(response.GetRawResponse());
                return Response.FromValue(new GlobalRulestackResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<GlobalRulestackResource> IEnumerable<GlobalRulestackResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<GlobalRulestackResource> IAsyncEnumerable<GlobalRulestackResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
