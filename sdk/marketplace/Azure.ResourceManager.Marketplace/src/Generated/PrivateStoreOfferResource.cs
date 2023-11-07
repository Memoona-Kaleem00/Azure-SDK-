// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Marketplace.Models;

namespace Azure.ResourceManager.Marketplace
{
    /// <summary>
    /// A Class representing a PrivateStoreOffer along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="PrivateStoreOfferResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetPrivateStoreOfferResource method.
    /// Otherwise you can get one from its parent resource <see cref="PrivateStoreCollectionInfoResource" /> using the GetPrivateStoreOffer method.
    /// </summary>
    public partial class PrivateStoreOfferResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="PrivateStoreOfferResource"/> instance. </summary>
        /// <param name="privateStoreId"> The privateStoreId. </param>
        /// <param name="collectionId"> The collectionId. </param>
        /// <param name="offerId"> The offerId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(Guid privateStoreId, Guid collectionId, string offerId)
        {
            var resourceId = $"/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/offers/{offerId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _privateStoreOfferPrivateStoreCollectionOfferClientDiagnostics;
        private readonly PrivateStoreCollectionOfferRestOperations _privateStoreOfferPrivateStoreCollectionOfferRestClient;
        private readonly PrivateStoreOfferData _data;

        /// <summary> Initializes a new instance of the <see cref="PrivateStoreOfferResource"/> class for mocking. </summary>
        protected PrivateStoreOfferResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "PrivateStoreOfferResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal PrivateStoreOfferResource(ArmClient client, PrivateStoreOfferData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="PrivateStoreOfferResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PrivateStoreOfferResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _privateStoreOfferPrivateStoreCollectionOfferClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Marketplace", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string privateStoreOfferPrivateStoreCollectionOfferApiVersion);
            _privateStoreOfferPrivateStoreCollectionOfferRestClient = new PrivateStoreCollectionOfferRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, privateStoreOfferPrivateStoreCollectionOfferApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Marketplace/privateStores/collections/offers";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PrivateStoreOfferData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets information about a specific offer.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/offers/{offerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStoreCollectionOffer_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PrivateStoreOfferResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _privateStoreOfferPrivateStoreCollectionOfferClientDiagnostics.CreateScope("PrivateStoreOfferResource.Get");
            scope.Start();
            try
            {
                var response = await _privateStoreOfferPrivateStoreCollectionOfferRestClient.GetAsync(Guid.Parse(Id.Parent.Parent.Name), Guid.Parse(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateStoreOfferResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a specific offer.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/offers/{offerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStoreCollectionOffer_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PrivateStoreOfferResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _privateStoreOfferPrivateStoreCollectionOfferClientDiagnostics.CreateScope("PrivateStoreOfferResource.Get");
            scope.Start();
            try
            {
                var response = _privateStoreOfferPrivateStoreCollectionOfferRestClient.Get(Guid.Parse(Id.Parent.Parent.Name), Guid.Parse(Id.Parent.Name), Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateStoreOfferResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an offer from the given collection of private store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/offers/{offerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStoreCollectionOffer_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _privateStoreOfferPrivateStoreCollectionOfferClientDiagnostics.CreateScope("PrivateStoreOfferResource.Delete");
            scope.Start();
            try
            {
                var response = await _privateStoreOfferPrivateStoreCollectionOfferRestClient.DeleteAsync(Guid.Parse(Id.Parent.Parent.Name), Guid.Parse(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new MarketplaceArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an offer from the given collection of private store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/offers/{offerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStoreCollectionOffer_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _privateStoreOfferPrivateStoreCollectionOfferClientDiagnostics.CreateScope("PrivateStoreOfferResource.Delete");
            scope.Start();
            try
            {
                var response = _privateStoreOfferPrivateStoreCollectionOfferRestClient.Delete(Guid.Parse(Id.Parent.Parent.Name), Guid.Parse(Id.Parent.Name), Id.Name, cancellationToken);
                var operation = new MarketplaceArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update or add an offer to a specific collection of the private store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/offers/{offerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStoreCollectionOffer_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The PrivateStoreOfferData to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PrivateStoreOfferResource>> UpdateAsync(WaitUntil waitUntil, PrivateStoreOfferData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _privateStoreOfferPrivateStoreCollectionOfferClientDiagnostics.CreateScope("PrivateStoreOfferResource.Update");
            scope.Start();
            try
            {
                var response = await _privateStoreOfferPrivateStoreCollectionOfferRestClient.CreateOrUpdateAsync(Guid.Parse(Id.Parent.Parent.Name), Guid.Parse(Id.Parent.Name), Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MarketplaceArmOperation<PrivateStoreOfferResource>(Response.FromValue(new PrivateStoreOfferResource(Client, response), response.GetRawResponse()));
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
        /// Update or add an offer to a specific collection of the private store.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/offers/{offerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStoreCollectionOffer_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The PrivateStoreOfferData to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PrivateStoreOfferResource> Update(WaitUntil waitUntil, PrivateStoreOfferData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _privateStoreOfferPrivateStoreCollectionOfferClientDiagnostics.CreateScope("PrivateStoreOfferResource.Update");
            scope.Start();
            try
            {
                var response = _privateStoreOfferPrivateStoreCollectionOfferRestClient.CreateOrUpdate(Guid.Parse(Id.Parent.Parent.Name), Guid.Parse(Id.Parent.Name), Id.Name, data, cancellationToken);
                var operation = new MarketplaceArmOperation<PrivateStoreOfferResource>(Response.FromValue(new PrivateStoreOfferResource(Client, response), response.GetRawResponse()));
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
        /// Upsert an offer with multiple context details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/offers/{offerId}/upsertOfferWithMultiContext</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStoreCollectionOffer_UpsertOfferWithMultiContext</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The MultiContextAndPlansContent to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PrivateStoreOfferResource>> UpsertOfferWithMultiContextAsync(MultiContextAndPlansContent content = null, CancellationToken cancellationToken = default)
        {
            using var scope = _privateStoreOfferPrivateStoreCollectionOfferClientDiagnostics.CreateScope("PrivateStoreOfferResource.UpsertOfferWithMultiContext");
            scope.Start();
            try
            {
                var response = await _privateStoreOfferPrivateStoreCollectionOfferRestClient.UpsertOfferWithMultiContextAsync(Guid.Parse(Id.Parent.Parent.Name), Guid.Parse(Id.Parent.Name), Id.Name, content, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new PrivateStoreOfferResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Upsert an offer with multiple context details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/offers/{offerId}/upsertOfferWithMultiContext</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStoreCollectionOffer_UpsertOfferWithMultiContext</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The MultiContextAndPlansContent to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PrivateStoreOfferResource> UpsertOfferWithMultiContext(MultiContextAndPlansContent content = null, CancellationToken cancellationToken = default)
        {
            using var scope = _privateStoreOfferPrivateStoreCollectionOfferClientDiagnostics.CreateScope("PrivateStoreOfferResource.UpsertOfferWithMultiContext");
            scope.Start();
            try
            {
                var response = _privateStoreOfferPrivateStoreCollectionOfferRestClient.UpsertOfferWithMultiContext(Guid.Parse(Id.Parent.Parent.Name), Guid.Parse(Id.Parent.Name), Id.Name, content, cancellationToken);
                return Response.FromValue(new PrivateStoreOfferResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete Private store offer. This is a workaround.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/offers/{offerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStoreCollectionOffer_Post</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="payload"> The PrivateStoreOperation? to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(PrivateStoreOperation? payload = null, CancellationToken cancellationToken = default)
        {
            using var scope = _privateStoreOfferPrivateStoreCollectionOfferClientDiagnostics.CreateScope("PrivateStoreOfferResource.Delete");
            scope.Start();
            try
            {
                var response = await _privateStoreOfferPrivateStoreCollectionOfferRestClient.PostAsync(Guid.Parse(Id.Parent.Parent.Name), Guid.Parse(Id.Parent.Name), Id.Name, payload, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete Private store offer. This is a workaround.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Marketplace/privateStores/{privateStoreId}/collections/{collectionId}/offers/{offerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateStoreCollectionOffer_Post</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="payload"> The PrivateStoreOperation? to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(PrivateStoreOperation? payload = null, CancellationToken cancellationToken = default)
        {
            using var scope = _privateStoreOfferPrivateStoreCollectionOfferClientDiagnostics.CreateScope("PrivateStoreOfferResource.Delete");
            scope.Start();
            try
            {
                var response = _privateStoreOfferPrivateStoreCollectionOfferRestClient.Post(Guid.Parse(Id.Parent.Parent.Name), Guid.Parse(Id.Parent.Name), Id.Name, payload, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
