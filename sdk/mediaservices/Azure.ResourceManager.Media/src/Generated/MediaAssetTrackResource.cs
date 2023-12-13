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
    /// A Class representing a MediaAssetTrack along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="MediaAssetTrackResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetMediaAssetTrackResource method.
    /// Otherwise you can get one from its parent resource <see cref="MediaAssetResource"/> using the GetMediaAssetTrack method.
    /// </summary>
    public partial class MediaAssetTrackResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MediaAssetTrackResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="accountName"> The accountName. </param>
        /// <param name="assetName"> The assetName. </param>
        /// <param name="trackName"> The trackName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string assetName, string trackName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/tracks/{trackName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _mediaAssetTrackTracksClientDiagnostics;
        private readonly TracksRestOperations _mediaAssetTrackTracksRestClient;
        private readonly MediaAssetTrackData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Media/mediaServices/assets/tracks";

        /// <summary> Initializes a new instance of the <see cref="MediaAssetTrackResource"/> class for mocking. </summary>
        protected MediaAssetTrackResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MediaAssetTrackResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MediaAssetTrackResource(ArmClient client, MediaAssetTrackData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MediaAssetTrackResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MediaAssetTrackResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mediaAssetTrackTracksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Media", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string mediaAssetTrackTracksApiVersion);
            _mediaAssetTrackTracksRestClient = new TracksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mediaAssetTrackTracksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MediaAssetTrackData Data
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
        /// Get the details of a Track in the Asset
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/tracks/{trackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tracks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MediaAssetTrackResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _mediaAssetTrackTracksClientDiagnostics.CreateScope("MediaAssetTrackResource.Get");
            scope.Start();
            try
            {
                var response = await _mediaAssetTrackTracksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MediaAssetTrackResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the details of a Track in the Asset
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/tracks/{trackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tracks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MediaAssetTrackResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _mediaAssetTrackTracksClientDiagnostics.CreateScope("MediaAssetTrackResource.Get");
            scope.Start();
            try
            {
                var response = _mediaAssetTrackTracksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MediaAssetTrackResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a Track in the asset
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/tracks/{trackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tracks_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _mediaAssetTrackTracksClientDiagnostics.CreateScope("MediaAssetTrackResource.Delete");
            scope.Start();
            try
            {
                var response = await _mediaAssetTrackTracksRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new MediaArmOperation(_mediaAssetTrackTracksClientDiagnostics, Pipeline, _mediaAssetTrackTracksRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Deletes a Track in the asset
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/tracks/{trackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tracks_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _mediaAssetTrackTracksClientDiagnostics.CreateScope("MediaAssetTrackResource.Delete");
            scope.Start();
            try
            {
                var response = _mediaAssetTrackTracksRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new MediaArmOperation(_mediaAssetTrackTracksClientDiagnostics, Pipeline, _mediaAssetTrackTracksRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Updates an existing Track in the asset
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/tracks/{trackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tracks_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MediaAssetTrackResource>> UpdateAsync(WaitUntil waitUntil, MediaAssetTrackData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mediaAssetTrackTracksClientDiagnostics.CreateScope("MediaAssetTrackResource.Update");
            scope.Start();
            try
            {
                var response = await _mediaAssetTrackTracksRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MediaArmOperation<MediaAssetTrackResource>(new MediaAssetTrackOperationSource(Client), _mediaAssetTrackTracksClientDiagnostics, Pipeline, _mediaAssetTrackTracksRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Updates an existing Track in the asset
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/tracks/{trackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tracks_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MediaAssetTrackResource> Update(WaitUntil waitUntil, MediaAssetTrackData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mediaAssetTrackTracksClientDiagnostics.CreateScope("MediaAssetTrackResource.Update");
            scope.Start();
            try
            {
                var response = _mediaAssetTrackTracksRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new MediaArmOperation<MediaAssetTrackResource>(new MediaAssetTrackOperationSource(Client), _mediaAssetTrackTracksClientDiagnostics, Pipeline, _mediaAssetTrackTracksRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Update the track data. Call this API after any changes are made to the track data stored in the asset container. For example, you have modified the WebVTT captions file in the Azure blob storage container for the asset, viewers will not see the new version of the captions unless this API is called. Note, the changes may not be reflected immediately. CDN cache may also need to be purged if applicable.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/tracks/{trackName}/updateTrackData</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tracks_UpdateTrackData</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> UpdateTrackDataAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _mediaAssetTrackTracksClientDiagnostics.CreateScope("MediaAssetTrackResource.UpdateTrackData");
            scope.Start();
            try
            {
                var response = await _mediaAssetTrackTracksRestClient.UpdateTrackDataAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new MediaArmOperation(_mediaAssetTrackTracksClientDiagnostics, Pipeline, _mediaAssetTrackTracksRestClient.CreateUpdateTrackDataRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Update the track data. Call this API after any changes are made to the track data stored in the asset container. For example, you have modified the WebVTT captions file in the Azure blob storage container for the asset, viewers will not see the new version of the captions unless this API is called. Note, the changes may not be reflected immediately. CDN cache may also need to be purged if applicable.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/assets/{assetName}/tracks/{trackName}/updateTrackData</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Tracks_UpdateTrackData</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation UpdateTrackData(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _mediaAssetTrackTracksClientDiagnostics.CreateScope("MediaAssetTrackResource.UpdateTrackData");
            scope.Start();
            try
            {
                var response = _mediaAssetTrackTracksRestClient.UpdateTrackData(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new MediaArmOperation(_mediaAssetTrackTracksClientDiagnostics, Pipeline, _mediaAssetTrackTracksRestClient.CreateUpdateTrackDataRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
    }
}
