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
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    /// <summary>
    /// A class representing a collection of <see cref="StorageAccountLocalUserResource"/> and their operations.
    /// Each <see cref="StorageAccountLocalUserResource"/> in the collection will belong to the same instance of <see cref="StorageAccountResource"/>.
    /// To get a <see cref="StorageAccountLocalUserCollection"/> instance call the GetStorageAccountLocalUsers method from an instance of <see cref="StorageAccountResource"/>.
    /// </summary>
    public partial class StorageAccountLocalUserCollection : ArmCollection, IEnumerable<StorageAccountLocalUserResource>, IAsyncEnumerable<StorageAccountLocalUserResource>
    {
        private readonly ClientDiagnostics _storageAccountLocalUserLocalUsersClientDiagnostics;
        private readonly LocalUsersRestOperations _storageAccountLocalUserLocalUsersRestClient;

        /// <summary> Initializes a new instance of the <see cref="StorageAccountLocalUserCollection"/> class for mocking. </summary>
        protected StorageAccountLocalUserCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StorageAccountLocalUserCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StorageAccountLocalUserCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _storageAccountLocalUserLocalUsersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Storage", StorageAccountLocalUserResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StorageAccountLocalUserResource.ResourceType, out string storageAccountLocalUserLocalUsersApiVersion);
            _storageAccountLocalUserLocalUsersRestClient = new LocalUsersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, storageAccountLocalUserLocalUsersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != StorageAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, StorageAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update the properties of a local user associated with the storage account. Properties for NFSv3 enablement and extended groups cannot be set with other properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/localUsers/{username}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalUsers_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageAccountLocalUserResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="username"> The name of local user. The username must contain lowercase letters and numbers only. It must be unique only within the storage account. </param>
        /// <param name="data"> The local user associated with a storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="username"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="username"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<StorageAccountLocalUserResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string username, StorageAccountLocalUserData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(username, nameof(username));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _storageAccountLocalUserLocalUsersClientDiagnostics.CreateScope("StorageAccountLocalUserCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _storageAccountLocalUserLocalUsersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, username, data, cancellationToken).ConfigureAwait(false);
                var uri = _storageAccountLocalUserLocalUsersRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, username, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new StorageArmOperation<StorageAccountLocalUserResource>(Response.FromValue(new StorageAccountLocalUserResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Create or update the properties of a local user associated with the storage account. Properties for NFSv3 enablement and extended groups cannot be set with other properties.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/localUsers/{username}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalUsers_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageAccountLocalUserResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="username"> The name of local user. The username must contain lowercase letters and numbers only. It must be unique only within the storage account. </param>
        /// <param name="data"> The local user associated with a storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="username"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="username"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<StorageAccountLocalUserResource> CreateOrUpdate(WaitUntil waitUntil, string username, StorageAccountLocalUserData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(username, nameof(username));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _storageAccountLocalUserLocalUsersClientDiagnostics.CreateScope("StorageAccountLocalUserCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _storageAccountLocalUserLocalUsersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, username, data, cancellationToken);
                var uri = _storageAccountLocalUserLocalUsersRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, username, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new StorageArmOperation<StorageAccountLocalUserResource>(Response.FromValue(new StorageAccountLocalUserResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Get the local user of the storage account by username.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/localUsers/{username}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalUsers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageAccountLocalUserResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="username"> The name of local user. The username must contain lowercase letters and numbers only. It must be unique only within the storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="username"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="username"/> is null. </exception>
        public virtual async Task<Response<StorageAccountLocalUserResource>> GetAsync(string username, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(username, nameof(username));

            using var scope = _storageAccountLocalUserLocalUsersClientDiagnostics.CreateScope("StorageAccountLocalUserCollection.Get");
            scope.Start();
            try
            {
                var response = await _storageAccountLocalUserLocalUsersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, username, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageAccountLocalUserResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the local user of the storage account by username.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/localUsers/{username}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalUsers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageAccountLocalUserResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="username"> The name of local user. The username must contain lowercase letters and numbers only. It must be unique only within the storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="username"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="username"/> is null. </exception>
        public virtual Response<StorageAccountLocalUserResource> Get(string username, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(username, nameof(username));

            using var scope = _storageAccountLocalUserLocalUsersClientDiagnostics.CreateScope("StorageAccountLocalUserCollection.Get");
            scope.Start();
            try
            {
                var response = _storageAccountLocalUserLocalUsersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, username, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageAccountLocalUserResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List the local users associated with the storage account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/localUsers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalUsers_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageAccountLocalUserResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="maxpagesize"> Optional, specifies the maximum number of local users that will be included in the list response. </param>
        /// <param name="filter"> Optional. When specified, only local user names starting with the filter will be listed. </param>
        /// <param name="include"> Optional, when specified, will list local users enabled for the specific protocol. Lists all users by default. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageAccountLocalUserResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageAccountLocalUserResource> GetAllAsync(int? maxpagesize = null, string filter = null, ListLocalUserIncludeParam? include = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _storageAccountLocalUserLocalUsersRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, pageSizeHint, filter, include);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new StorageAccountLocalUserResource(Client, StorageAccountLocalUserData.DeserializeStorageAccountLocalUserData(e)), _storageAccountLocalUserLocalUsersClientDiagnostics, Pipeline, "StorageAccountLocalUserCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// List the local users associated with the storage account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/localUsers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalUsers_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageAccountLocalUserResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="maxpagesize"> Optional, specifies the maximum number of local users that will be included in the list response. </param>
        /// <param name="filter"> Optional. When specified, only local user names starting with the filter will be listed. </param>
        /// <param name="include"> Optional, when specified, will list local users enabled for the specific protocol. Lists all users by default. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageAccountLocalUserResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageAccountLocalUserResource> GetAll(int? maxpagesize = null, string filter = null, ListLocalUserIncludeParam? include = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _storageAccountLocalUserLocalUsersRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, pageSizeHint, filter, include);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new StorageAccountLocalUserResource(Client, StorageAccountLocalUserData.DeserializeStorageAccountLocalUserData(e)), _storageAccountLocalUserLocalUsersClientDiagnostics, Pipeline, "StorageAccountLocalUserCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/localUsers/{username}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalUsers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageAccountLocalUserResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="username"> The name of local user. The username must contain lowercase letters and numbers only. It must be unique only within the storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="username"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="username"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string username, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(username, nameof(username));

            using var scope = _storageAccountLocalUserLocalUsersClientDiagnostics.CreateScope("StorageAccountLocalUserCollection.Exists");
            scope.Start();
            try
            {
                var response = await _storageAccountLocalUserLocalUsersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, username, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/localUsers/{username}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalUsers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageAccountLocalUserResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="username"> The name of local user. The username must contain lowercase letters and numbers only. It must be unique only within the storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="username"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="username"/> is null. </exception>
        public virtual Response<bool> Exists(string username, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(username, nameof(username));

            using var scope = _storageAccountLocalUserLocalUsersClientDiagnostics.CreateScope("StorageAccountLocalUserCollection.Exists");
            scope.Start();
            try
            {
                var response = _storageAccountLocalUserLocalUsersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, username, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/localUsers/{username}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalUsers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageAccountLocalUserResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="username"> The name of local user. The username must contain lowercase letters and numbers only. It must be unique only within the storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="username"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="username"/> is null. </exception>
        public virtual async Task<NullableResponse<StorageAccountLocalUserResource>> GetIfExistsAsync(string username, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(username, nameof(username));

            using var scope = _storageAccountLocalUserLocalUsersClientDiagnostics.CreateScope("StorageAccountLocalUserCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _storageAccountLocalUserLocalUsersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, username, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<StorageAccountLocalUserResource>(response.GetRawResponse());
                return Response.FromValue(new StorageAccountLocalUserResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/localUsers/{username}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocalUsers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageAccountLocalUserResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="username"> The name of local user. The username must contain lowercase letters and numbers only. It must be unique only within the storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="username"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="username"/> is null. </exception>
        public virtual NullableResponse<StorageAccountLocalUserResource> GetIfExists(string username, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(username, nameof(username));

            using var scope = _storageAccountLocalUserLocalUsersClientDiagnostics.CreateScope("StorageAccountLocalUserCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _storageAccountLocalUserLocalUsersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, username, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<StorageAccountLocalUserResource>(response.GetRawResponse());
                return Response.FromValue(new StorageAccountLocalUserResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StorageAccountLocalUserResource> IEnumerable<StorageAccountLocalUserResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StorageAccountLocalUserResource> IAsyncEnumerable<StorageAccountLocalUserResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
