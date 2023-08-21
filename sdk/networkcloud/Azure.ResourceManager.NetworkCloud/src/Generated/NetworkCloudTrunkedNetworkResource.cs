// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.NetworkCloud.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.NetworkCloud
{
    /// <summary>
    /// A Class representing a NetworkCloudTrunkedNetwork along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="NetworkCloudTrunkedNetworkResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetNetworkCloudTrunkedNetworkResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource" /> using the GetNetworkCloudTrunkedNetwork method.
    /// </summary>
    public partial class NetworkCloudTrunkedNetworkResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="NetworkCloudTrunkedNetworkResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string trunkedNetworkName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/trunkedNetworks/{trunkedNetworkName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _networkCloudTrunkedNetworkTrunkedNetworksClientDiagnostics;
        private readonly TrunkedNetworksRestOperations _networkCloudTrunkedNetworkTrunkedNetworksRestClient;
        private readonly NetworkCloudTrunkedNetworkData _data;

        /// <summary> Initializes a new instance of the <see cref="NetworkCloudTrunkedNetworkResource"/> class for mocking. </summary>
        protected NetworkCloudTrunkedNetworkResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "NetworkCloudTrunkedNetworkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal NetworkCloudTrunkedNetworkResource(ArmClient client, NetworkCloudTrunkedNetworkData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkCloudTrunkedNetworkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal NetworkCloudTrunkedNetworkResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkCloudTrunkedNetworkTrunkedNetworksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetworkCloud", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string networkCloudTrunkedNetworkTrunkedNetworksApiVersion);
            _networkCloudTrunkedNetworkTrunkedNetworksRestClient = new TrunkedNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkCloudTrunkedNetworkTrunkedNetworksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.NetworkCloud/trunkedNetworks";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual NetworkCloudTrunkedNetworkData Data
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
        /// Get properties of the provided trunked network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/trunkedNetworks/{trunkedNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrunkedNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NetworkCloudTrunkedNetworkResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _networkCloudTrunkedNetworkTrunkedNetworksClientDiagnostics.CreateScope("NetworkCloudTrunkedNetworkResource.Get");
            scope.Start();
            try
            {
                var response = await _networkCloudTrunkedNetworkTrunkedNetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudTrunkedNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of the provided trunked network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/trunkedNetworks/{trunkedNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrunkedNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NetworkCloudTrunkedNetworkResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _networkCloudTrunkedNetworkTrunkedNetworksClientDiagnostics.CreateScope("NetworkCloudTrunkedNetworkResource.Get");
            scope.Start();
            try
            {
                var response = _networkCloudTrunkedNetworkTrunkedNetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudTrunkedNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete the provided trunked network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/trunkedNetworks/{trunkedNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrunkedNetworks_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _networkCloudTrunkedNetworkTrunkedNetworksClientDiagnostics.CreateScope("NetworkCloudTrunkedNetworkResource.Delete");
            scope.Start();
            try
            {
                var response = await _networkCloudTrunkedNetworkTrunkedNetworksRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkCloudArmOperation(_networkCloudTrunkedNetworkTrunkedNetworksClientDiagnostics, Pipeline, _networkCloudTrunkedNetworkTrunkedNetworksRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Delete the provided trunked network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/trunkedNetworks/{trunkedNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrunkedNetworks_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _networkCloudTrunkedNetworkTrunkedNetworksClientDiagnostics.CreateScope("NetworkCloudTrunkedNetworkResource.Delete");
            scope.Start();
            try
            {
                var response = _networkCloudTrunkedNetworkTrunkedNetworksRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new NetworkCloudArmOperation(_networkCloudTrunkedNetworkTrunkedNetworksClientDiagnostics, Pipeline, _networkCloudTrunkedNetworkTrunkedNetworksRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, Core.OperationFinalStateVia.Location);
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
        /// Update tags associated with the provided trunked network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/trunkedNetworks/{trunkedNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrunkedNetworks_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="patch"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<Response<NetworkCloudTrunkedNetworkResource>> UpdateAsync(NetworkCloudTrunkedNetworkPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _networkCloudTrunkedNetworkTrunkedNetworksClientDiagnostics.CreateScope("NetworkCloudTrunkedNetworkResource.Update");
            scope.Start();
            try
            {
                var response = await _networkCloudTrunkedNetworkTrunkedNetworksRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new NetworkCloudTrunkedNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update tags associated with the provided trunked network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/trunkedNetworks/{trunkedNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrunkedNetworks_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="patch"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual Response<NetworkCloudTrunkedNetworkResource> Update(NetworkCloudTrunkedNetworkPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _networkCloudTrunkedNetworkTrunkedNetworksClientDiagnostics.CreateScope("NetworkCloudTrunkedNetworkResource.Update");
            scope.Start();
            try
            {
                var response = _networkCloudTrunkedNetworkTrunkedNetworksRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, patch, cancellationToken);
                return Response.FromValue(new NetworkCloudTrunkedNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/trunkedNetworks/{trunkedNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrunkedNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual async Task<Response<NetworkCloudTrunkedNetworkResource>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _networkCloudTrunkedNetworkTrunkedNetworksClientDiagnostics.CreateScope("NetworkCloudTrunkedNetworkResource.AddTag");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues[key] = value;
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _networkCloudTrunkedNetworkTrunkedNetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new NetworkCloudTrunkedNetworkResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new NetworkCloudTrunkedNetworkPatch();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags[key] = value;
                    var result = await UpdateAsync(patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/trunkedNetworks/{trunkedNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrunkedNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<NetworkCloudTrunkedNetworkResource> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _networkCloudTrunkedNetworkTrunkedNetworksClientDiagnostics.CreateScope("NetworkCloudTrunkedNetworkResource.AddTag");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues[key] = value;
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _networkCloudTrunkedNetworkTrunkedNetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                    return Response.FromValue(new NetworkCloudTrunkedNetworkResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new NetworkCloudTrunkedNetworkPatch();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags[key] = value;
                    var result = Update(patch, cancellationToken: cancellationToken);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/trunkedNetworks/{trunkedNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrunkedNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual async Task<Response<NetworkCloudTrunkedNetworkResource>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _networkCloudTrunkedNetworkTrunkedNetworksClientDiagnostics.CreateScope("NetworkCloudTrunkedNetworkResource.SetTags");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    await GetTagResource().DeleteAsync(WaitUntil.Completed, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues.ReplaceWith(tags);
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _networkCloudTrunkedNetworkTrunkedNetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new NetworkCloudTrunkedNetworkResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new NetworkCloudTrunkedNetworkPatch();
                    patch.Tags.ReplaceWith(tags);
                    var result = await UpdateAsync(patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/trunkedNetworks/{trunkedNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrunkedNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<NetworkCloudTrunkedNetworkResource> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _networkCloudTrunkedNetworkTrunkedNetworksClientDiagnostics.CreateScope("NetworkCloudTrunkedNetworkResource.SetTags");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    GetTagResource().Delete(WaitUntil.Completed, cancellationToken: cancellationToken);
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues.ReplaceWith(tags);
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _networkCloudTrunkedNetworkTrunkedNetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                    return Response.FromValue(new NetworkCloudTrunkedNetworkResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new NetworkCloudTrunkedNetworkPatch();
                    patch.Tags.ReplaceWith(tags);
                    var result = Update(patch, cancellationToken: cancellationToken);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/trunkedNetworks/{trunkedNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrunkedNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual async Task<Response<NetworkCloudTrunkedNetworkResource>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _networkCloudTrunkedNetworkTrunkedNetworksClientDiagnostics.CreateScope("NetworkCloudTrunkedNetworkResource.RemoveTag");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues.Remove(key);
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _networkCloudTrunkedNetworkTrunkedNetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new NetworkCloudTrunkedNetworkResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new NetworkCloudTrunkedNetworkPatch();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags.Remove(key);
                    var result = await UpdateAsync(patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/trunkedNetworks/{trunkedNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrunkedNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<NetworkCloudTrunkedNetworkResource> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _networkCloudTrunkedNetworkTrunkedNetworksClientDiagnostics.CreateScope("NetworkCloudTrunkedNetworkResource.RemoveTag");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues.Remove(key);
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _networkCloudTrunkedNetworkTrunkedNetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                    return Response.FromValue(new NetworkCloudTrunkedNetworkResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new NetworkCloudTrunkedNetworkPatch();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags.Remove(key);
                    var result = Update(patch, cancellationToken: cancellationToken);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
