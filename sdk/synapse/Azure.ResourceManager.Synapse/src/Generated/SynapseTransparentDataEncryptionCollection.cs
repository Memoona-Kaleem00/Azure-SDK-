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
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing a collection of <see cref="SynapseTransparentDataEncryptionResource" /> and their operations.
    /// Each <see cref="SynapseTransparentDataEncryptionResource" /> in the collection will belong to the same instance of <see cref="SynapseSqlPoolResource" />.
    /// To get a <see cref="SynapseTransparentDataEncryptionCollection" /> instance call the GetSynapseTransparentDataEncryptions method from an instance of <see cref="SynapseSqlPoolResource" />.
    /// </summary>
    public partial class SynapseTransparentDataEncryptionCollection : ArmCollection, IEnumerable<SynapseTransparentDataEncryptionResource>, IAsyncEnumerable<SynapseTransparentDataEncryptionResource>
    {
        private readonly ClientDiagnostics _synapseTransparentDataEncryptionSqlPoolTransparentDataEncryptionsClientDiagnostics;
        private readonly SqlPoolTransparentDataEncryptionsRestOperations _synapseTransparentDataEncryptionSqlPoolTransparentDataEncryptionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SynapseTransparentDataEncryptionCollection"/> class for mocking. </summary>
        protected SynapseTransparentDataEncryptionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseTransparentDataEncryptionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SynapseTransparentDataEncryptionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseTransparentDataEncryptionSqlPoolTransparentDataEncryptionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", SynapseTransparentDataEncryptionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SynapseTransparentDataEncryptionResource.ResourceType, out string synapseTransparentDataEncryptionSqlPoolTransparentDataEncryptionsApiVersion);
            _synapseTransparentDataEncryptionSqlPoolTransparentDataEncryptionsRestClient = new SqlPoolTransparentDataEncryptionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseTransparentDataEncryptionSqlPoolTransparentDataEncryptionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SynapseSqlPoolResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SynapseSqlPoolResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a Sql pool's transparent data encryption configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/transparentDataEncryption/{transparentDataEncryptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolTransparentDataEncryptions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="transparentDataEncryptionName"> The name of the transparent data encryption configuration. </param>
        /// <param name="data"> The required parameters for creating or updating transparent data encryption. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SynapseTransparentDataEncryptionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, SynapseTransparentDataEncryptionName transparentDataEncryptionName, SynapseTransparentDataEncryptionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseTransparentDataEncryptionSqlPoolTransparentDataEncryptionsClientDiagnostics.CreateScope("SynapseTransparentDataEncryptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _synapseTransparentDataEncryptionSqlPoolTransparentDataEncryptionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, transparentDataEncryptionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation<SynapseTransparentDataEncryptionResource>(Response.FromValue(new SynapseTransparentDataEncryptionResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a Sql pool's transparent data encryption configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/transparentDataEncryption/{transparentDataEncryptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolTransparentDataEncryptions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="transparentDataEncryptionName"> The name of the transparent data encryption configuration. </param>
        /// <param name="data"> The required parameters for creating or updating transparent data encryption. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SynapseTransparentDataEncryptionResource> CreateOrUpdate(WaitUntil waitUntil, SynapseTransparentDataEncryptionName transparentDataEncryptionName, SynapseTransparentDataEncryptionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseTransparentDataEncryptionSqlPoolTransparentDataEncryptionsClientDiagnostics.CreateScope("SynapseTransparentDataEncryptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _synapseTransparentDataEncryptionSqlPoolTransparentDataEncryptionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, transparentDataEncryptionName, data, cancellationToken);
                var operation = new SynapseArmOperation<SynapseTransparentDataEncryptionResource>(Response.FromValue(new SynapseTransparentDataEncryptionResource(Client, response), response.GetRawResponse()));
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
        /// Get a SQL pool's transparent data encryption configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/transparentDataEncryption/{transparentDataEncryptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolTransparentDataEncryptions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="transparentDataEncryptionName"> The name of the transparent data encryption configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SynapseTransparentDataEncryptionResource>> GetAsync(SynapseTransparentDataEncryptionName transparentDataEncryptionName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseTransparentDataEncryptionSqlPoolTransparentDataEncryptionsClientDiagnostics.CreateScope("SynapseTransparentDataEncryptionCollection.Get");
            scope.Start();
            try
            {
                var response = await _synapseTransparentDataEncryptionSqlPoolTransparentDataEncryptionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, transparentDataEncryptionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseTransparentDataEncryptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a SQL pool's transparent data encryption configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/transparentDataEncryption/{transparentDataEncryptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolTransparentDataEncryptions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="transparentDataEncryptionName"> The name of the transparent data encryption configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SynapseTransparentDataEncryptionResource> Get(SynapseTransparentDataEncryptionName transparentDataEncryptionName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseTransparentDataEncryptionSqlPoolTransparentDataEncryptionsClientDiagnostics.CreateScope("SynapseTransparentDataEncryptionCollection.Get");
            scope.Start();
            try
            {
                var response = _synapseTransparentDataEncryptionSqlPoolTransparentDataEncryptionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, transparentDataEncryptionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseTransparentDataEncryptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get list of SQL pool's transparent data encryption configurations.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/transparentDataEncryption</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolTransparentDataEncryptions_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SynapseTransparentDataEncryptionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SynapseTransparentDataEncryptionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseTransparentDataEncryptionSqlPoolTransparentDataEncryptionsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _synapseTransparentDataEncryptionSqlPoolTransparentDataEncryptionsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new SynapseTransparentDataEncryptionResource(Client, SynapseTransparentDataEncryptionData.DeserializeSynapseTransparentDataEncryptionData(e)), _synapseTransparentDataEncryptionSqlPoolTransparentDataEncryptionsClientDiagnostics, Pipeline, "SynapseTransparentDataEncryptionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get list of SQL pool's transparent data encryption configurations.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/transparentDataEncryption</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolTransparentDataEncryptions_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SynapseTransparentDataEncryptionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SynapseTransparentDataEncryptionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseTransparentDataEncryptionSqlPoolTransparentDataEncryptionsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _synapseTransparentDataEncryptionSqlPoolTransparentDataEncryptionsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new SynapseTransparentDataEncryptionResource(Client, SynapseTransparentDataEncryptionData.DeserializeSynapseTransparentDataEncryptionData(e)), _synapseTransparentDataEncryptionSqlPoolTransparentDataEncryptionsClientDiagnostics, Pipeline, "SynapseTransparentDataEncryptionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/transparentDataEncryption/{transparentDataEncryptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolTransparentDataEncryptions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="transparentDataEncryptionName"> The name of the transparent data encryption configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(SynapseTransparentDataEncryptionName transparentDataEncryptionName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseTransparentDataEncryptionSqlPoolTransparentDataEncryptionsClientDiagnostics.CreateScope("SynapseTransparentDataEncryptionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _synapseTransparentDataEncryptionSqlPoolTransparentDataEncryptionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, transparentDataEncryptionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/transparentDataEncryption/{transparentDataEncryptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolTransparentDataEncryptions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="transparentDataEncryptionName"> The name of the transparent data encryption configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(SynapseTransparentDataEncryptionName transparentDataEncryptionName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseTransparentDataEncryptionSqlPoolTransparentDataEncryptionsClientDiagnostics.CreateScope("SynapseTransparentDataEncryptionCollection.Exists");
            scope.Start();
            try
            {
                var response = _synapseTransparentDataEncryptionSqlPoolTransparentDataEncryptionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, transparentDataEncryptionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/transparentDataEncryption/{transparentDataEncryptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolTransparentDataEncryptions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="transparentDataEncryptionName"> The name of the transparent data encryption configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<SynapseTransparentDataEncryptionResource>> GetIfExistsAsync(SynapseTransparentDataEncryptionName transparentDataEncryptionName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseTransparentDataEncryptionSqlPoolTransparentDataEncryptionsClientDiagnostics.CreateScope("SynapseTransparentDataEncryptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _synapseTransparentDataEncryptionSqlPoolTransparentDataEncryptionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, transparentDataEncryptionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SynapseTransparentDataEncryptionResource>(response.GetRawResponse());
                return Response.FromValue(new SynapseTransparentDataEncryptionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/transparentDataEncryption/{transparentDataEncryptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolTransparentDataEncryptions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="transparentDataEncryptionName"> The name of the transparent data encryption configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<SynapseTransparentDataEncryptionResource> GetIfExists(SynapseTransparentDataEncryptionName transparentDataEncryptionName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseTransparentDataEncryptionSqlPoolTransparentDataEncryptionsClientDiagnostics.CreateScope("SynapseTransparentDataEncryptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _synapseTransparentDataEncryptionSqlPoolTransparentDataEncryptionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, transparentDataEncryptionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SynapseTransparentDataEncryptionResource>(response.GetRawResponse());
                return Response.FromValue(new SynapseTransparentDataEncryptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SynapseTransparentDataEncryptionResource> IEnumerable<SynapseTransparentDataEncryptionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SynapseTransparentDataEncryptionResource> IAsyncEnumerable<SynapseTransparentDataEncryptionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
