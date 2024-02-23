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

namespace Azure.ResourceManager.Media
{
    /// <summary>
    /// A Class representing a MediaAssetFilter along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="MediaAssetFilterResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetMediaAssetFilterResource method.
    /// Otherwise you can get one from its parent resource <see cref="MediaAssetResource"/> using the GetMediaAssetFilter method.
    /// </summary>
    public partial class MediaAssetFilterResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MediaAssetFilterResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="accountName"> The accountName. </param>
        /// <param name="assetName"> The assetName. </param>
        /// <param name="filterName"> The filterName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string assetName, string filterName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/assetFilters/{filterName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _mediaAssetFilterAssetFiltersClientDiagnostics;
        private readonly AssetFiltersRestOperations _mediaAssetFilterAssetFiltersRestClient;
        private readonly MediaAssetFilterData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Media/mediaServices/assets/assetFilters";

        /// <summary> Initializes a new instance of the <see cref="MediaAssetFilterResource"/> class for mocking. </summary>
        protected MediaAssetFilterResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MediaAssetFilterResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MediaAssetFilterResource(ArmClient client, MediaAssetFilterData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MediaAssetFilterResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MediaAssetFilterResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mediaAssetFilterAssetFiltersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Media", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string mediaAssetFilterAssetFiltersApiVersion);
            _mediaAssetFilterAssetFiltersRestClient = new AssetFiltersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mediaAssetFilterAssetFiltersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MediaAssetFilterData Data
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
        /// Get the details of an Asset Filter associated with the specified Asset.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/assetFilters/{filterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssetFilters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MediaAssetFilterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MediaAssetFilterResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _mediaAssetFilterAssetFiltersClientDiagnostics.CreateScope("MediaAssetFilterResource.Get");
            scope.Start();
            try
            {
                var response = await _mediaAssetFilterAssetFiltersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MediaAssetFilterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the details of an Asset Filter associated with the specified Asset.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/assetFilters/{filterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssetFilters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MediaAssetFilterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MediaAssetFilterResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _mediaAssetFilterAssetFiltersClientDiagnostics.CreateScope("MediaAssetFilterResource.Get");
            scope.Start();
            try
            {
                var response = _mediaAssetFilterAssetFiltersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MediaAssetFilterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an Asset Filter associated with the specified Asset.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/assetFilters/{filterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssetFilters_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MediaAssetFilterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _mediaAssetFilterAssetFiltersClientDiagnostics.CreateScope("MediaAssetFilterResource.Delete");
            scope.Start();
            try
            {
                var response = await _mediaAssetFilterAssetFiltersRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var uri = _mediaAssetFilterAssetFiltersRestClient.CreateDeleteRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new MediaArmOperation(response, rehydrationToken);
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
        /// Deletes an Asset Filter associated with the specified Asset.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/assetFilters/{filterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssetFilters_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MediaAssetFilterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _mediaAssetFilterAssetFiltersClientDiagnostics.CreateScope("MediaAssetFilterResource.Delete");
            scope.Start();
            try
            {
                var response = _mediaAssetFilterAssetFiltersRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var uri = _mediaAssetFilterAssetFiltersRestClient.CreateDeleteRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new MediaArmOperation(response, rehydrationToken);
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
        /// Updates an existing Asset Filter associated with the specified Asset.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/assetFilters/{filterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssetFilters_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MediaAssetFilterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<Response<MediaAssetFilterResource>> UpdateAsync(MediaAssetFilterData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _mediaAssetFilterAssetFiltersClientDiagnostics.CreateScope("MediaAssetFilterResource.Update");
            scope.Start();
            try
            {
                var response = await _mediaAssetFilterAssetFiltersRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new MediaAssetFilterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates an existing Asset Filter associated with the specified Asset.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/assetFilters/{filterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AssetFilters_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MediaAssetFilterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response<MediaAssetFilterResource> Update(MediaAssetFilterData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _mediaAssetFilterAssetFiltersClientDiagnostics.CreateScope("MediaAssetFilterResource.Update");
            scope.Start();
            try
            {
                var response = _mediaAssetFilterAssetFiltersRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                return Response.FromValue(new MediaAssetFilterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
