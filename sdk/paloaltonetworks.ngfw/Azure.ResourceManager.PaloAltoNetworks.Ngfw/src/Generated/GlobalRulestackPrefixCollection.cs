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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    /// <summary>
    /// A class representing a collection of <see cref="GlobalRulestackPrefixResource" /> and their operations.
    /// Each <see cref="GlobalRulestackPrefixResource" /> in the collection will belong to the same instance of <see cref="GlobalRulestackResource" />.
    /// To get a <see cref="GlobalRulestackPrefixCollection" /> instance call the GetGlobalRulestackPrefixes method from an instance of <see cref="GlobalRulestackResource" />.
    /// </summary>
    public partial class GlobalRulestackPrefixCollection : ArmCollection, IEnumerable<GlobalRulestackPrefixResource>, IAsyncEnumerable<GlobalRulestackPrefixResource>
    {
        private readonly ClientDiagnostics _globalRulestackPrefixPrefixListGlobalRulestackClientDiagnostics;
        private readonly PrefixListGlobalRulestackRestOperations _globalRulestackPrefixPrefixListGlobalRulestackRestClient;

        /// <summary> Initializes a new instance of the <see cref="GlobalRulestackPrefixCollection"/> class for mocking. </summary>
        protected GlobalRulestackPrefixCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GlobalRulestackPrefixCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal GlobalRulestackPrefixCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _globalRulestackPrefixPrefixListGlobalRulestackClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PaloAltoNetworks.Ngfw", GlobalRulestackPrefixResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(GlobalRulestackPrefixResource.ResourceType, out string globalRulestackPrefixPrefixListGlobalRulestackApiVersion);
            _globalRulestackPrefixPrefixListGlobalRulestackRestClient = new PrefixListGlobalRulestackRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, globalRulestackPrefixPrefixListGlobalRulestackApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != GlobalRulestackResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, GlobalRulestackResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a PrefixListGlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/prefixlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrefixListGlobalRulestack_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Local Rule priority. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<GlobalRulestackPrefixResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, GlobalRulestackPrefixData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _globalRulestackPrefixPrefixListGlobalRulestackClientDiagnostics.CreateScope("GlobalRulestackPrefixCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _globalRulestackPrefixPrefixListGlobalRulestackRestClient.CreateOrUpdateAsync(Id.Name, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new NgfwArmOperation<GlobalRulestackPrefixResource>(new GlobalRulestackPrefixOperationSource(Client), _globalRulestackPrefixPrefixListGlobalRulestackClientDiagnostics, Pipeline, _globalRulestackPrefixPrefixListGlobalRulestackRestClient.CreateCreateOrUpdateRequest(Id.Name, name, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a PrefixListGlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/prefixlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrefixListGlobalRulestack_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Local Rule priority. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<GlobalRulestackPrefixResource> CreateOrUpdate(WaitUntil waitUntil, string name, GlobalRulestackPrefixData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _globalRulestackPrefixPrefixListGlobalRulestackClientDiagnostics.CreateScope("GlobalRulestackPrefixCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _globalRulestackPrefixPrefixListGlobalRulestackRestClient.CreateOrUpdate(Id.Name, name, data, cancellationToken);
                var operation = new NgfwArmOperation<GlobalRulestackPrefixResource>(new GlobalRulestackPrefixOperationSource(Client), _globalRulestackPrefixPrefixListGlobalRulestackClientDiagnostics, Pipeline, _globalRulestackPrefixPrefixListGlobalRulestackRestClient.CreateCreateOrUpdateRequest(Id.Name, name, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a PrefixListGlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/prefixlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrefixListGlobalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Local Rule priority. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<GlobalRulestackPrefixResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _globalRulestackPrefixPrefixListGlobalRulestackClientDiagnostics.CreateScope("GlobalRulestackPrefixCollection.Get");
            scope.Start();
            try
            {
                var response = await _globalRulestackPrefixPrefixListGlobalRulestackRestClient.GetAsync(Id.Name, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GlobalRulestackPrefixResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a PrefixListGlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/prefixlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrefixListGlobalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Local Rule priority. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<GlobalRulestackPrefixResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _globalRulestackPrefixPrefixListGlobalRulestackClientDiagnostics.CreateScope("GlobalRulestackPrefixCollection.Get");
            scope.Start();
            try
            {
                var response = _globalRulestackPrefixPrefixListGlobalRulestackRestClient.Get(Id.Name, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GlobalRulestackPrefixResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List PrefixListGlobalRulestackResource resources by Tenant
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/prefixlists</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrefixListGlobalRulestack_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GlobalRulestackPrefixResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GlobalRulestackPrefixResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _globalRulestackPrefixPrefixListGlobalRulestackRestClient.CreateListRequest(Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _globalRulestackPrefixPrefixListGlobalRulestackRestClient.CreateListNextPageRequest(nextLink, Id.Name);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new GlobalRulestackPrefixResource(Client, GlobalRulestackPrefixData.DeserializeGlobalRulestackPrefixData(e)), _globalRulestackPrefixPrefixListGlobalRulestackClientDiagnostics, Pipeline, "GlobalRulestackPrefixCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List PrefixListGlobalRulestackResource resources by Tenant
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/prefixlists</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrefixListGlobalRulestack_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GlobalRulestackPrefixResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GlobalRulestackPrefixResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _globalRulestackPrefixPrefixListGlobalRulestackRestClient.CreateListRequest(Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _globalRulestackPrefixPrefixListGlobalRulestackRestClient.CreateListNextPageRequest(nextLink, Id.Name);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new GlobalRulestackPrefixResource(Client, GlobalRulestackPrefixData.DeserializeGlobalRulestackPrefixData(e)), _globalRulestackPrefixPrefixListGlobalRulestackClientDiagnostics, Pipeline, "GlobalRulestackPrefixCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/prefixlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrefixListGlobalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Local Rule priority. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _globalRulestackPrefixPrefixListGlobalRulestackClientDiagnostics.CreateScope("GlobalRulestackPrefixCollection.Exists");
            scope.Start();
            try
            {
                var response = await _globalRulestackPrefixPrefixListGlobalRulestackRestClient.GetAsync(Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/prefixlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrefixListGlobalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Local Rule priority. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _globalRulestackPrefixPrefixListGlobalRulestackClientDiagnostics.CreateScope("GlobalRulestackPrefixCollection.Exists");
            scope.Start();
            try
            {
                var response = _globalRulestackPrefixPrefixListGlobalRulestackRestClient.Get(Id.Name, name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<GlobalRulestackPrefixResource> IEnumerable<GlobalRulestackPrefixResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<GlobalRulestackPrefixResource> IAsyncEnumerable<GlobalRulestackPrefixResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
