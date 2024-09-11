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
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A class representing a collection of <see cref="AvsPrivateCloudResource"/> and their operations.
    /// Each <see cref="AvsPrivateCloudResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get an <see cref="AvsPrivateCloudCollection"/> instance call the GetAvsPrivateClouds method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class AvsPrivateCloudCollection : ArmCollection, IEnumerable<AvsPrivateCloudResource>, IAsyncEnumerable<AvsPrivateCloudResource>
    {
        private readonly ClientDiagnostics _avsPrivateCloudPrivateCloudsClientDiagnostics;
        private readonly PrivateCloudsRestOperations _avsPrivateCloudPrivateCloudsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AvsPrivateCloudCollection"/> class for mocking. </summary>
        protected AvsPrivateCloudCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AvsPrivateCloudCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AvsPrivateCloudCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _avsPrivateCloudPrivateCloudsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Avs", AvsPrivateCloudResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AvsPrivateCloudResource.ResourceType, out string avsPrivateCloudPrivateCloudsApiVersion);
            _avsPrivateCloudPrivateCloudsRestClient = new PrivateCloudsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, avsPrivateCloudPrivateCloudsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a PrivateCloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateClouds_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AvsPrivateCloudResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateCloudName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateCloudName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AvsPrivateCloudResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string privateCloudName, AvsPrivateCloudData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateCloudName, nameof(privateCloudName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _avsPrivateCloudPrivateCloudsClientDiagnostics.CreateScope("AvsPrivateCloudCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _avsPrivateCloudPrivateCloudsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, privateCloudName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AvsArmOperation<AvsPrivateCloudResource>(new AvsPrivateCloudOperationSource(Client), _avsPrivateCloudPrivateCloudsClientDiagnostics, Pipeline, _avsPrivateCloudPrivateCloudsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, privateCloudName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a PrivateCloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateClouds_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AvsPrivateCloudResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateCloudName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateCloudName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AvsPrivateCloudResource> CreateOrUpdate(WaitUntil waitUntil, string privateCloudName, AvsPrivateCloudData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateCloudName, nameof(privateCloudName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _avsPrivateCloudPrivateCloudsClientDiagnostics.CreateScope("AvsPrivateCloudCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _avsPrivateCloudPrivateCloudsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, privateCloudName, data, cancellationToken);
                var operation = new AvsArmOperation<AvsPrivateCloudResource>(new AvsPrivateCloudOperationSource(Client), _avsPrivateCloudPrivateCloudsClientDiagnostics, Pipeline, _avsPrivateCloudPrivateCloudsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, privateCloudName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a PrivateCloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateClouds_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AvsPrivateCloudResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateCloudName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateCloudName"/> is null. </exception>
        public virtual async Task<Response<AvsPrivateCloudResource>> GetAsync(string privateCloudName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateCloudName, nameof(privateCloudName));

            using var scope = _avsPrivateCloudPrivateCloudsClientDiagnostics.CreateScope("AvsPrivateCloudCollection.Get");
            scope.Start();
            try
            {
                var response = await _avsPrivateCloudPrivateCloudsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, privateCloudName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AvsPrivateCloudResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a PrivateCloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateClouds_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AvsPrivateCloudResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateCloudName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateCloudName"/> is null. </exception>
        public virtual Response<AvsPrivateCloudResource> Get(string privateCloudName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateCloudName, nameof(privateCloudName));

            using var scope = _avsPrivateCloudPrivateCloudsClientDiagnostics.CreateScope("AvsPrivateCloudCollection.Get");
            scope.Start();
            try
            {
                var response = _avsPrivateCloudPrivateCloudsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, privateCloudName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AvsPrivateCloudResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List PrivateCloud resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateCloud_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AvsPrivateCloudResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AvsPrivateCloudResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AvsPrivateCloudResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _avsPrivateCloudPrivateCloudsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _avsPrivateCloudPrivateCloudsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AvsPrivateCloudResource(Client, AvsPrivateCloudData.DeserializeAvsPrivateCloudData(e)), _avsPrivateCloudPrivateCloudsClientDiagnostics, Pipeline, "AvsPrivateCloudCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List PrivateCloud resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateCloud_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AvsPrivateCloudResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AvsPrivateCloudResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AvsPrivateCloudResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _avsPrivateCloudPrivateCloudsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _avsPrivateCloudPrivateCloudsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AvsPrivateCloudResource(Client, AvsPrivateCloudData.DeserializeAvsPrivateCloudData(e)), _avsPrivateCloudPrivateCloudsClientDiagnostics, Pipeline, "AvsPrivateCloudCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateClouds_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AvsPrivateCloudResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateCloudName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateCloudName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string privateCloudName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateCloudName, nameof(privateCloudName));

            using var scope = _avsPrivateCloudPrivateCloudsClientDiagnostics.CreateScope("AvsPrivateCloudCollection.Exists");
            scope.Start();
            try
            {
                var response = await _avsPrivateCloudPrivateCloudsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, privateCloudName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateClouds_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AvsPrivateCloudResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateCloudName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateCloudName"/> is null. </exception>
        public virtual Response<bool> Exists(string privateCloudName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateCloudName, nameof(privateCloudName));

            using var scope = _avsPrivateCloudPrivateCloudsClientDiagnostics.CreateScope("AvsPrivateCloudCollection.Exists");
            scope.Start();
            try
            {
                var response = _avsPrivateCloudPrivateCloudsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, privateCloudName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateClouds_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AvsPrivateCloudResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateCloudName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateCloudName"/> is null. </exception>
        public virtual async Task<NullableResponse<AvsPrivateCloudResource>> GetIfExistsAsync(string privateCloudName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateCloudName, nameof(privateCloudName));

            using var scope = _avsPrivateCloudPrivateCloudsClientDiagnostics.CreateScope("AvsPrivateCloudCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _avsPrivateCloudPrivateCloudsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, privateCloudName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AvsPrivateCloudResource>(response.GetRawResponse());
                return Response.FromValue(new AvsPrivateCloudResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateClouds_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AvsPrivateCloudResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateCloudName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateCloudName"/> is null. </exception>
        public virtual NullableResponse<AvsPrivateCloudResource> GetIfExists(string privateCloudName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateCloudName, nameof(privateCloudName));

            using var scope = _avsPrivateCloudPrivateCloudsClientDiagnostics.CreateScope("AvsPrivateCloudCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _avsPrivateCloudPrivateCloudsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, privateCloudName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AvsPrivateCloudResource>(response.GetRawResponse());
                return Response.FromValue(new AvsPrivateCloudResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AvsPrivateCloudResource> IEnumerable<AvsPrivateCloudResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AvsPrivateCloudResource> IAsyncEnumerable<AvsPrivateCloudResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
