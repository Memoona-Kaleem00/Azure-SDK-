// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Storagetasks.Models;

namespace Azure.ResourceManager.Storagetasks
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Storagetasks. </summary>
    public static partial class StoragetasksExtensions
    {
        private static ResourceGroupResourceExtensionClient GetResourceGroupResourceExtensionClient(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new ResourceGroupResourceExtensionClient(client, resource.Id);
            });
        }

        private static ResourceGroupResourceExtensionClient GetResourceGroupResourceExtensionClient(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new ResourceGroupResourceExtensionClient(client, scope);
            });
        }

        private static SubscriptionResourceExtensionClient GetSubscriptionResourceExtensionClient(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new SubscriptionResourceExtensionClient(client, resource.Id);
            });
        }

        private static SubscriptionResourceExtensionClient GetSubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new SubscriptionResourceExtensionClient(client, scope);
            });
        }
        #region StorageTaskResource
        /// <summary>
        /// Gets an object representing a <see cref="StorageTaskResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageTaskResource.CreateResourceIdentifier" /> to create a <see cref="StorageTaskResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageTaskResource" /> object. </returns>
        public static StorageTaskResource GetStorageTaskResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                StorageTaskResource.ValidateResourceId(id);
                return new StorageTaskResource(client, id);
            }
            );
        }
        #endregion

        /// <summary> Gets a collection of StorageTaskResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of StorageTaskResources and their operations over a StorageTaskResource. </returns>
        public static StorageTaskCollection GetStorageTasks(this ResourceGroupResource resourceGroupResource)
        {
            return GetResourceGroupResourceExtensionClient(resourceGroupResource).GetStorageTasks();
        }

        /// <summary>
        /// Get the storage task properties
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageTasks/storageTasks/{storageTaskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageTasks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="storageTaskName"> The name of the storage task within the specified resource group. Storage task names must be between 3 and 18 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageTaskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageTaskName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<StorageTaskResource>> GetStorageTaskAsync(this ResourceGroupResource resourceGroupResource, string storageTaskName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetStorageTasks().GetAsync(storageTaskName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the storage task properties
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageTasks/storageTasks/{storageTaskName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageTasks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="storageTaskName"> The name of the storage task within the specified resource group. Storage task names must be between 3 and 18 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageTaskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageTaskName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<StorageTaskResource> GetStorageTask(this ResourceGroupResource resourceGroupResource, string storageTaskName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetStorageTasks().Get(storageTaskName, cancellationToken);
        }

        /// <summary>
        /// Lists all the storage tasks available under the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageTasks/storageTasks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageTasks_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageTaskResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<StorageTaskResource> GetStorageTasksAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetStorageTasksAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all the storage tasks available under the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageTasks/storageTasks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageTasks_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageTaskResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<StorageTaskResource> GetStorageTasks(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetStorageTasks(cancellationToken);
        }

        /// <summary>
        /// Runs the input conditions against input object metadata properties and designates matched objects in response.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageTasks/previewActions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageTasks_PreviewActions</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="storageTaskPreviewAction"> The parameters to preview action condition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageTaskPreviewAction"/> is null. </exception>
        public static async Task<Response<StorageTaskPreviewAction>> PreviewActionsStorageTaskAsync(this SubscriptionResource subscriptionResource, StorageTaskPreviewAction storageTaskPreviewAction, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(storageTaskPreviewAction, nameof(storageTaskPreviewAction));

            return await GetSubscriptionResourceExtensionClient(subscriptionResource).PreviewActionsStorageTaskAsync(storageTaskPreviewAction, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Runs the input conditions against input object metadata properties and designates matched objects in response.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageTasks/previewActions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageTasks_PreviewActions</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="storageTaskPreviewAction"> The parameters to preview action condition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageTaskPreviewAction"/> is null. </exception>
        public static Response<StorageTaskPreviewAction> PreviewActionsStorageTask(this SubscriptionResource subscriptionResource, StorageTaskPreviewAction storageTaskPreviewAction, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(storageTaskPreviewAction, nameof(storageTaskPreviewAction));

            return GetSubscriptionResourceExtensionClient(subscriptionResource).PreviewActionsStorageTask(storageTaskPreviewAction, cancellationToken);
        }
    }
}
