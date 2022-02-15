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
using Azure.ResourceManager.AppConfiguration.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppConfiguration
{
    /// <summary> A Class representing a ConfigurationStore along with the instance operations that can be performed on it. </summary>
    public partial class ConfigurationStore : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ConfigurationStore"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string configStoreName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _configurationStoreClientDiagnostics;
        private readonly ConfigurationStoresRestOperations _configurationStoreRestClient;
        private readonly ConfigurationStoreData _data;

        /// <summary> Initializes a new instance of the <see cref="ConfigurationStore"/> class for mocking. </summary>
        protected ConfigurationStore()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ConfigurationStore"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ConfigurationStore(ArmClient client, ConfigurationStoreData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ConfigurationStore"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ConfigurationStore(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _configurationStoreClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppConfiguration", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string configurationStoreApiVersion);
            _configurationStoreRestClient = new ConfigurationStoresRestOperations(_configurationStoreClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, configurationStoreApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AppConfiguration/configurationStores";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ConfigurationStoreData Data
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

        /// <summary> Gets a collection of PrivateEndpointConnections in the PrivateEndpointConnection. </summary>
        /// <returns> An object representing collection of PrivateEndpointConnections and their operations over a PrivateEndpointConnection. </returns>
        public virtual PrivateEndpointConnectionCollection GetPrivateEndpointConnections()
        {
            return new PrivateEndpointConnectionCollection(Client, Id);
        }

        /// <summary> Gets a collection of PrivateLinkResources in the PrivateLinkResource. </summary>
        /// <returns> An object representing collection of PrivateLinkResources and their operations over a PrivateLinkResource. </returns>
        public virtual PrivateLinkResourceCollection GetPrivateLinkResources()
        {
            return new PrivateLinkResourceCollection(Client, Id);
        }

        /// <summary>
        /// Gets the properties of the specified configuration store.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ConfigurationStore>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStore.Get");
            scope.Start();
            try
            {
                var response = await _configurationStoreRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _configurationStoreClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ConfigurationStore(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the properties of the specified configuration store.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ConfigurationStore> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStore.Get");
            scope.Start();
            try
            {
                var response = _configurationStoreRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _configurationStoreClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ConfigurationStore(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a configuration store.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStore.Delete");
            scope.Start();
            try
            {
                var response = await _configurationStoreRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppConfigurationArmOperation(_configurationStoreClientDiagnostics, Pipeline, _configurationStoreRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
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
        /// Deletes a configuration store.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStore.Delete");
            scope.Start();
            try
            {
                var response = _configurationStoreRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new AppConfigurationArmOperation(_configurationStoreClientDiagnostics, Pipeline, _configurationStoreRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
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
        /// Updates a configuration store with the specified parameters.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_Update
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="options"> The options for updating a configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="options"/> is null. </exception>
        public async virtual Task<ArmOperation<ConfigurationStore>> UpdateAsync(bool waitForCompletion, ConfigurationStoreUpdateOptions options, CancellationToken cancellationToken = default)
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStore.Update");
            scope.Start();
            try
            {
                var response = await _configurationStoreRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options, cancellationToken).ConfigureAwait(false);
                var operation = new AppConfigurationArmOperation<ConfigurationStore>(new ConfigurationStoreOperationSource(Client), _configurationStoreClientDiagnostics, Pipeline, _configurationStoreRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
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
        /// Updates a configuration store with the specified parameters.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_Update
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="options"> The options for updating a configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="options"/> is null. </exception>
        public virtual ArmOperation<ConfigurationStore> Update(bool waitForCompletion, ConfigurationStoreUpdateOptions options, CancellationToken cancellationToken = default)
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStore.Update");
            scope.Start();
            try
            {
                var response = _configurationStoreRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options, cancellationToken);
                var operation = new AppConfigurationArmOperation<ConfigurationStore>(new ConfigurationStoreOperationSource(Client), _configurationStoreClientDiagnostics, Pipeline, _configurationStoreRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
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
        /// Lists the access key for the specified configuration store.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/ListKeys
        /// Operation Id: ConfigurationStores_ListKeys
        /// </summary>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiKey" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiKey> GetKeysAsync(string skipToken = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ApiKey>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStore.GetKeys");
                scope.Start();
                try
                {
                    var response = await _configurationStoreRestClient.ListKeysAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ApiKey>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStore.GetKeys");
                scope.Start();
                try
                {
                    var response = await _configurationStoreRestClient.ListKeysNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists the access key for the specified configuration store.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/ListKeys
        /// Operation Id: ConfigurationStores_ListKeys
        /// </summary>
        /// <param name="skipToken"> A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiKey" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiKey> GetKeys(string skipToken = null, CancellationToken cancellationToken = default)
        {
            Page<ApiKey> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStore.GetKeys");
                scope.Start();
                try
                {
                    var response = _configurationStoreRestClient.ListKeys(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ApiKey> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStore.GetKeys");
                scope.Start();
                try
                {
                    var response = _configurationStoreRestClient.ListKeysNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Regenerates an access key for the specified configuration store.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/RegenerateKey
        /// Operation Id: ConfigurationStores_RegenerateKey
        /// </summary>
        /// <param name="regenerateKeyOptions"> The options for regenerating an access key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="regenerateKeyOptions"/> is null. </exception>
        public async virtual Task<Response<ApiKey>> RegenerateKeyAsync(RegenerateKeyOptions regenerateKeyOptions, CancellationToken cancellationToken = default)
        {
            if (regenerateKeyOptions == null)
            {
                throw new ArgumentNullException(nameof(regenerateKeyOptions));
            }

            using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStore.RegenerateKey");
            scope.Start();
            try
            {
                var response = await _configurationStoreRestClient.RegenerateKeyAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, regenerateKeyOptions, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Regenerates an access key for the specified configuration store.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/RegenerateKey
        /// Operation Id: ConfigurationStores_RegenerateKey
        /// </summary>
        /// <param name="regenerateKeyOptions"> The options for regenerating an access key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="regenerateKeyOptions"/> is null. </exception>
        public virtual Response<ApiKey> RegenerateKey(RegenerateKeyOptions regenerateKeyOptions, CancellationToken cancellationToken = default)
        {
            if (regenerateKeyOptions == null)
            {
                throw new ArgumentNullException(nameof(regenerateKeyOptions));
            }

            using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStore.RegenerateKey");
            scope.Start();
            try
            {
                var response = _configurationStoreRestClient.RegenerateKey(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, regenerateKeyOptions, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a configuration store key-value.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/listKeyValue
        /// Operation Id: ConfigurationStores_ListKeyValue
        /// </summary>
        /// <param name="listKeyValueOptions"> The options for retrieving a key-value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="listKeyValueOptions"/> is null. </exception>
        public async virtual Task<Response<KeyValue>> GetKeyValueAsync(ListKeyValueOptions listKeyValueOptions, CancellationToken cancellationToken = default)
        {
            if (listKeyValueOptions == null)
            {
                throw new ArgumentNullException(nameof(listKeyValueOptions));
            }

            using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStore.GetKeyValue");
            scope.Start();
            try
            {
                var response = await _configurationStoreRestClient.ListKeyValueAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, listKeyValueOptions, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a configuration store key-value.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/listKeyValue
        /// Operation Id: ConfigurationStores_ListKeyValue
        /// </summary>
        /// <param name="listKeyValueOptions"> The options for retrieving a key-value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="listKeyValueOptions"/> is null. </exception>
        public virtual Response<KeyValue> GetKeyValue(ListKeyValueOptions listKeyValueOptions, CancellationToken cancellationToken = default)
        {
            if (listKeyValueOptions == null)
            {
                throw new ArgumentNullException(nameof(listKeyValueOptions));
            }

            using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStore.GetKeyValue");
            scope.Start();
            try
            {
                var response = _configurationStoreRestClient.ListKeyValue(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, listKeyValueOptions, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public async virtual Task<Response<ConfigurationStore>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStore.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _configurationStoreRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ConfigurationStore(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<ConfigurationStore> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStore.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _configurationStoreRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new ConfigurationStore(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public async virtual Task<Response<ConfigurationStore>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }

            using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStore.SetTags");
            scope.Start();
            try
            {
                await TagResource.DeleteAsync(true, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _configurationStoreRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ConfigurationStore(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<ConfigurationStore> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }

            using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStore.SetTags");
            scope.Start();
            try
            {
                TagResource.Delete(true, cancellationToken: cancellationToken);
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _configurationStoreRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new ConfigurationStore(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public async virtual Task<Response<ConfigurationStore>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStore.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _configurationStoreRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ConfigurationStore(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<ConfigurationStore> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _configurationStoreClientDiagnostics.CreateScope("ConfigurationStore.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _configurationStoreRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new ConfigurationStore(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
