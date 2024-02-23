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
    /// A class representing a collection of <see cref="IntegrationAccountCertificateResource"/> and their operations.
    /// Each <see cref="IntegrationAccountCertificateResource"/> in the collection will belong to the same instance of <see cref="IntegrationAccountResource"/>.
    /// To get an <see cref="IntegrationAccountCertificateCollection"/> instance call the GetIntegrationAccountCertificates method from an instance of <see cref="IntegrationAccountResource"/>.
    /// </summary>
    public partial class IntegrationAccountCertificateCollection : ArmCollection, IEnumerable<IntegrationAccountCertificateResource>, IAsyncEnumerable<IntegrationAccountCertificateResource>
    {
        private readonly ClientDiagnostics _integrationAccountCertificateClientDiagnostics;
        private readonly IntegrationAccountCertificatesRestOperations _integrationAccountCertificateRestClient;

        /// <summary> Initializes a new instance of the <see cref="IntegrationAccountCertificateCollection"/> class for mocking. </summary>
        protected IntegrationAccountCertificateCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="IntegrationAccountCertificateCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal IntegrationAccountCertificateCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _integrationAccountCertificateClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Logic", IntegrationAccountCertificateResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(IntegrationAccountCertificateResource.ResourceType, out string integrationAccountCertificateApiVersion);
            _integrationAccountCertificateRestClient = new IntegrationAccountCertificatesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, integrationAccountCertificateApiVersion);
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
        /// Creates or updates an integration account certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountCertificates_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IntegrationAccountCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="certificateName"> The integration account certificate name. </param>
        /// <param name="data"> The integration account certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<IntegrationAccountCertificateResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string certificateName, IntegrationAccountCertificateData data, CancellationToken cancellationToken = default)
        {
            if (certificateName == null)
            {
                throw new ArgumentNullException(nameof(certificateName));
            }
            if (certificateName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(certificateName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _integrationAccountCertificateClientDiagnostics.CreateScope("IntegrationAccountCertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _integrationAccountCertificateRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, data, cancellationToken).ConfigureAwait(false);
                var uri = _integrationAccountCertificateRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new LogicArmOperation<IntegrationAccountCertificateResource>(Response.FromValue(new IntegrationAccountCertificateResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Creates or updates an integration account certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountCertificates_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IntegrationAccountCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="certificateName"> The integration account certificate name. </param>
        /// <param name="data"> The integration account certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<IntegrationAccountCertificateResource> CreateOrUpdate(WaitUntil waitUntil, string certificateName, IntegrationAccountCertificateData data, CancellationToken cancellationToken = default)
        {
            if (certificateName == null)
            {
                throw new ArgumentNullException(nameof(certificateName));
            }
            if (certificateName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(certificateName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _integrationAccountCertificateClientDiagnostics.CreateScope("IntegrationAccountCertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _integrationAccountCertificateRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, data, cancellationToken);
                var uri = _integrationAccountCertificateRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new LogicArmOperation<IntegrationAccountCertificateResource>(Response.FromValue(new IntegrationAccountCertificateResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Gets an integration account certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountCertificates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IntegrationAccountCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> The integration account certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual async Task<Response<IntegrationAccountCertificateResource>> GetAsync(string certificateName, CancellationToken cancellationToken = default)
        {
            if (certificateName == null)
            {
                throw new ArgumentNullException(nameof(certificateName));
            }
            if (certificateName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(certificateName));
            }

            using var scope = _integrationAccountCertificateClientDiagnostics.CreateScope("IntegrationAccountCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = await _integrationAccountCertificateRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IntegrationAccountCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an integration account certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountCertificates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IntegrationAccountCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> The integration account certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual Response<IntegrationAccountCertificateResource> Get(string certificateName, CancellationToken cancellationToken = default)
        {
            if (certificateName == null)
            {
                throw new ArgumentNullException(nameof(certificateName));
            }
            if (certificateName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(certificateName));
            }

            using var scope = _integrationAccountCertificateClientDiagnostics.CreateScope("IntegrationAccountCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = _integrationAccountCertificateRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IntegrationAccountCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of integration account certificates.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/certificates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountCertificates_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IntegrationAccountCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IntegrationAccountCertificateResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IntegrationAccountCertificateResource> GetAllAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _integrationAccountCertificateRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _integrationAccountCertificateRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new IntegrationAccountCertificateResource(Client, IntegrationAccountCertificateData.DeserializeIntegrationAccountCertificateData(e)), _integrationAccountCertificateClientDiagnostics, Pipeline, "IntegrationAccountCertificateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of integration account certificates.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/certificates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountCertificates_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IntegrationAccountCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IntegrationAccountCertificateResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IntegrationAccountCertificateResource> GetAll(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _integrationAccountCertificateRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _integrationAccountCertificateRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new IntegrationAccountCertificateResource(Client, IntegrationAccountCertificateData.DeserializeIntegrationAccountCertificateData(e)), _integrationAccountCertificateClientDiagnostics, Pipeline, "IntegrationAccountCertificateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountCertificates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IntegrationAccountCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> The integration account certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string certificateName, CancellationToken cancellationToken = default)
        {
            if (certificateName == null)
            {
                throw new ArgumentNullException(nameof(certificateName));
            }
            if (certificateName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(certificateName));
            }

            using var scope = _integrationAccountCertificateClientDiagnostics.CreateScope("IntegrationAccountCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = await _integrationAccountCertificateRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountCertificates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IntegrationAccountCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> The integration account certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual Response<bool> Exists(string certificateName, CancellationToken cancellationToken = default)
        {
            if (certificateName == null)
            {
                throw new ArgumentNullException(nameof(certificateName));
            }
            if (certificateName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(certificateName));
            }

            using var scope = _integrationAccountCertificateClientDiagnostics.CreateScope("IntegrationAccountCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = _integrationAccountCertificateRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountCertificates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IntegrationAccountCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> The integration account certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual async Task<NullableResponse<IntegrationAccountCertificateResource>> GetIfExistsAsync(string certificateName, CancellationToken cancellationToken = default)
        {
            if (certificateName == null)
            {
                throw new ArgumentNullException(nameof(certificateName));
            }
            if (certificateName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(certificateName));
            }

            using var scope = _integrationAccountCertificateClientDiagnostics.CreateScope("IntegrationAccountCertificateCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _integrationAccountCertificateRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<IntegrationAccountCertificateResource>(response.GetRawResponse());
                return Response.FromValue(new IntegrationAccountCertificateResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Logic/integrationAccounts/{integrationAccountName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationAccountCertificates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2019-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IntegrationAccountCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> The integration account certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual NullableResponse<IntegrationAccountCertificateResource> GetIfExists(string certificateName, CancellationToken cancellationToken = default)
        {
            if (certificateName == null)
            {
                throw new ArgumentNullException(nameof(certificateName));
            }
            if (certificateName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(certificateName));
            }

            using var scope = _integrationAccountCertificateClientDiagnostics.CreateScope("IntegrationAccountCertificateCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _integrationAccountCertificateRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<IntegrationAccountCertificateResource>(response.GetRawResponse());
                return Response.FromValue(new IntegrationAccountCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<IntegrationAccountCertificateResource> IEnumerable<IntegrationAccountCertificateResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<IntegrationAccountCertificateResource> IAsyncEnumerable<IntegrationAccountCertificateResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
