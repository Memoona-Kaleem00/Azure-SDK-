// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.KeyVault.Models;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary> A class representing collection of Key and their operations over its parent. </summary>
    public partial class VaultKeyVersionCollection : ArmCollection, IEnumerable<VaultKeyVersion>, IAsyncEnumerable<VaultKeyVersion>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly KeysRestOperations _keysRestClient;

        /// <summary> Initializes a new instance of the <see cref="VaultKeyVersionCollection"/> class for mocking. </summary>
        protected VaultKeyVersionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VaultKeyVersionCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VaultKeyVersionCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(VaultKeyVersion.ResourceType, out string apiVersion);
            _keysRestClient = new KeysRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VaultKey.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VaultKey.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/keys/{keyName}/versions/{keyVersion}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/keys/{keyName}
        /// OperationId: Keys_GetVersion
        /// <summary> Gets the specified version of the specified key in the specified key vault. </summary>
        /// <param name="keyVersion"> The version of the key to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyVersion"/> is null. </exception>
        public virtual Response<VaultKeyVersion> Get(string keyVersion, CancellationToken cancellationToken = default)
        {
            if (keyVersion == null)
            {
                throw new ArgumentNullException(nameof(keyVersion));
            }

            using var scope = _clientDiagnostics.CreateScope("VaultKeyVersionCollection.Get");
            scope.Start();
            try
            {
                var response = _keysRestClient.GetVersion(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, keyVersion, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VaultKeyVersion(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/keys/{keyName}/versions/{keyVersion}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/keys/{keyName}
        /// OperationId: Keys_GetVersion
        /// <summary> Gets the specified version of the specified key in the specified key vault. </summary>
        /// <param name="keyVersion"> The version of the key to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyVersion"/> is null. </exception>
        public async virtual Task<Response<VaultKeyVersion>> GetAsync(string keyVersion, CancellationToken cancellationToken = default)
        {
            if (keyVersion == null)
            {
                throw new ArgumentNullException(nameof(keyVersion));
            }

            using var scope = _clientDiagnostics.CreateScope("VaultKeyVersionCollection.Get");
            scope.Start();
            try
            {
                var response = await _keysRestClient.GetVersionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, keyVersion, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VaultKeyVersion(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="keyVersion"> The version of the key to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyVersion"/> is null. </exception>
        public virtual Response<VaultKeyVersion> GetIfExists(string keyVersion, CancellationToken cancellationToken = default)
        {
            if (keyVersion == null)
            {
                throw new ArgumentNullException(nameof(keyVersion));
            }

            using var scope = _clientDiagnostics.CreateScope("VaultKeyVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _keysRestClient.GetVersion(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, keyVersion, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VaultKeyVersion>(null, response.GetRawResponse());
                return Response.FromValue(new VaultKeyVersion(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="keyVersion"> The version of the key to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyVersion"/> is null. </exception>
        public async virtual Task<Response<VaultKeyVersion>> GetIfExistsAsync(string keyVersion, CancellationToken cancellationToken = default)
        {
            if (keyVersion == null)
            {
                throw new ArgumentNullException(nameof(keyVersion));
            }

            using var scope = _clientDiagnostics.CreateScope("VaultKeyVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _keysRestClient.GetVersionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, keyVersion, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VaultKeyVersion>(null, response.GetRawResponse());
                return Response.FromValue(new VaultKeyVersion(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="keyVersion"> The version of the key to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyVersion"/> is null. </exception>
        public virtual Response<bool> Exists(string keyVersion, CancellationToken cancellationToken = default)
        {
            if (keyVersion == null)
            {
                throw new ArgumentNullException(nameof(keyVersion));
            }

            using var scope = _clientDiagnostics.CreateScope("VaultKeyVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(keyVersion, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="keyVersion"> The version of the key to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyVersion"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string keyVersion, CancellationToken cancellationToken = default)
        {
            if (keyVersion == null)
            {
                throw new ArgumentNullException(nameof(keyVersion));
            }

            using var scope = _clientDiagnostics.CreateScope("VaultKeyVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(keyVersion, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/keys/{keyName}/versions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/keys/{keyName}
        /// OperationId: Keys_ListVersions
        /// <summary> Lists the versions of the specified key in the specified key vault. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VaultKeyVersion" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VaultKeyVersion> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VaultKeyVersion> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VaultKeyVersionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _keysRestClient.ListVersions(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VaultKeyVersion(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VaultKeyVersion> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VaultKeyVersionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _keysRestClient.ListVersionsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VaultKeyVersion(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/keys/{keyName}/versions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/keys/{keyName}
        /// OperationId: Keys_ListVersions
        /// <summary> Lists the versions of the specified key in the specified key vault. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VaultKeyVersion" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VaultKeyVersion> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VaultKeyVersion>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VaultKeyVersionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _keysRestClient.ListVersionsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VaultKeyVersion(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VaultKeyVersion>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VaultKeyVersionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _keysRestClient.ListVersionsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VaultKeyVersion(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<VaultKeyVersion> IEnumerable<VaultKeyVersion>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VaultKeyVersion> IAsyncEnumerable<VaultKeyVersion>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, VaultKeyVersion, KeyData> Construct() { }
    }
}
