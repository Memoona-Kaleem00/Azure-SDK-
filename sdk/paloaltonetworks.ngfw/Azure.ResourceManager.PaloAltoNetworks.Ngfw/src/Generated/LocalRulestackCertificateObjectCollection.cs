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
    /// A class representing a collection of <see cref="LocalRulestackCertificateObjectResource" /> and their operations.
    /// Each <see cref="LocalRulestackCertificateObjectResource" /> in the collection will belong to the same instance of <see cref="LocalRulestackResource" />.
    /// To get a <see cref="LocalRulestackCertificateObjectCollection" /> instance call the GetLocalRulestackCertificateObjects method from an instance of <see cref="LocalRulestackResource" />.
    /// </summary>
    public partial class LocalRulestackCertificateObjectCollection : ArmCollection, IEnumerable<LocalRulestackCertificateObjectResource>, IAsyncEnumerable<LocalRulestackCertificateObjectResource>
    {
        private readonly ClientDiagnostics _localRulestackCertificateObjectCertificateObjectLocalRulestackClientDiagnostics;
        private readonly CertificateObjectLocalRulestackRestOperations _localRulestackCertificateObjectCertificateObjectLocalRulestackRestClient;

        /// <summary> Initializes a new instance of the <see cref="LocalRulestackCertificateObjectCollection"/> class for mocking. </summary>
        protected LocalRulestackCertificateObjectCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LocalRulestackCertificateObjectCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal LocalRulestackCertificateObjectCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _localRulestackCertificateObjectCertificateObjectLocalRulestackClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PaloAltoNetworks.Ngfw", LocalRulestackCertificateObjectResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(LocalRulestackCertificateObjectResource.ResourceType, out string localRulestackCertificateObjectCertificateObjectLocalRulestackApiVersion);
            _localRulestackCertificateObjectCertificateObjectLocalRulestackRestClient = new CertificateObjectLocalRulestackRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, localRulestackCertificateObjectCertificateObjectLocalRulestackApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != LocalRulestackResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, LocalRulestackResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a CertificateObjectLocalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateObjectLocalRulestack_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> certificate name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<LocalRulestackCertificateObjectResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, LocalRulestackCertificateObjectData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _localRulestackCertificateObjectCertificateObjectLocalRulestackClientDiagnostics.CreateScope("LocalRulestackCertificateObjectCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _localRulestackCertificateObjectCertificateObjectLocalRulestackRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new NgfwArmOperation<LocalRulestackCertificateObjectResource>(new LocalRulestackCertificateObjectOperationSource(Client), _localRulestackCertificateObjectCertificateObjectLocalRulestackClientDiagnostics, Pipeline, _localRulestackCertificateObjectCertificateObjectLocalRulestackRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a CertificateObjectLocalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateObjectLocalRulestack_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> certificate name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<LocalRulestackCertificateObjectResource> CreateOrUpdate(WaitUntil waitUntil, string name, LocalRulestackCertificateObjectData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _localRulestackCertificateObjectCertificateObjectLocalRulestackClientDiagnostics.CreateScope("LocalRulestackCertificateObjectCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _localRulestackCertificateObjectCertificateObjectLocalRulestackRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data, cancellationToken);
                var operation = new NgfwArmOperation<LocalRulestackCertificateObjectResource>(new LocalRulestackCertificateObjectOperationSource(Client), _localRulestackCertificateObjectCertificateObjectLocalRulestackClientDiagnostics, Pipeline, _localRulestackCertificateObjectCertificateObjectLocalRulestackRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, data).Request, response, Core.OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a CertificateObjectLocalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateObjectLocalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<LocalRulestackCertificateObjectResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _localRulestackCertificateObjectCertificateObjectLocalRulestackClientDiagnostics.CreateScope("LocalRulestackCertificateObjectCollection.Get");
            scope.Start();
            try
            {
                var response = await _localRulestackCertificateObjectCertificateObjectLocalRulestackRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LocalRulestackCertificateObjectResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a CertificateObjectLocalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateObjectLocalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<LocalRulestackCertificateObjectResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _localRulestackCertificateObjectCertificateObjectLocalRulestackClientDiagnostics.CreateScope("LocalRulestackCertificateObjectCollection.Get");
            scope.Start();
            try
            {
                var response = _localRulestackCertificateObjectCertificateObjectLocalRulestackRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LocalRulestackCertificateObjectResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List CertificateObjectLocalRulestackResource resources by LocalRulestacks
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/certificates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateObjectLocalRulestack_ListByLocalRulestacks</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LocalRulestackCertificateObjectResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LocalRulestackCertificateObjectResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _localRulestackCertificateObjectCertificateObjectLocalRulestackRestClient.CreateListByLocalRulestacksRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _localRulestackCertificateObjectCertificateObjectLocalRulestackRestClient.CreateListByLocalRulestacksNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new LocalRulestackCertificateObjectResource(Client, LocalRulestackCertificateObjectData.DeserializeLocalRulestackCertificateObjectData(e)), _localRulestackCertificateObjectCertificateObjectLocalRulestackClientDiagnostics, Pipeline, "LocalRulestackCertificateObjectCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List CertificateObjectLocalRulestackResource resources by LocalRulestacks
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/certificates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateObjectLocalRulestack_ListByLocalRulestacks</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LocalRulestackCertificateObjectResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LocalRulestackCertificateObjectResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _localRulestackCertificateObjectCertificateObjectLocalRulestackRestClient.CreateListByLocalRulestacksRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _localRulestackCertificateObjectCertificateObjectLocalRulestackRestClient.CreateListByLocalRulestacksNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new LocalRulestackCertificateObjectResource(Client, LocalRulestackCertificateObjectData.DeserializeLocalRulestackCertificateObjectData(e)), _localRulestackCertificateObjectCertificateObjectLocalRulestackClientDiagnostics, Pipeline, "LocalRulestackCertificateObjectCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateObjectLocalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _localRulestackCertificateObjectCertificateObjectLocalRulestackClientDiagnostics.CreateScope("LocalRulestackCertificateObjectCollection.Exists");
            scope.Start();
            try
            {
                var response = await _localRulestackCertificateObjectCertificateObjectLocalRulestackRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PaloAltoNetworks.Cloudngfw/localRulestacks/{localRulestackName}/certificates/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CertificateObjectLocalRulestack_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _localRulestackCertificateObjectCertificateObjectLocalRulestackClientDiagnostics.CreateScope("LocalRulestackCertificateObjectCollection.Exists");
            scope.Start();
            try
            {
                var response = _localRulestackCertificateObjectCertificateObjectLocalRulestackRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<LocalRulestackCertificateObjectResource> IEnumerable<LocalRulestackCertificateObjectResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LocalRulestackCertificateObjectResource> IAsyncEnumerable<LocalRulestackCertificateObjectResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
