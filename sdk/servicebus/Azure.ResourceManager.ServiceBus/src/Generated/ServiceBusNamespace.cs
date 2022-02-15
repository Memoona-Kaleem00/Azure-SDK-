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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary> A Class representing a ServiceBusNamespace along with the instance operations that can be performed on it. </summary>
    public partial class ServiceBusNamespace : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ServiceBusNamespace"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _serviceBusNamespaceNamespacesClientDiagnostics;
        private readonly NamespacesRestOperations _serviceBusNamespaceNamespacesRestClient;
        private readonly ClientDiagnostics _privateLinkResourcesClientDiagnostics;
        private readonly PrivateLinkResourcesRestOperations _privateLinkResourcesRestClient;
        private readonly ClientDiagnostics _disasterRecoveryDisasterRecoveryConfigsClientDiagnostics;
        private readonly DisasterRecoveryConfigsRestOperations _disasterRecoveryDisasterRecoveryConfigsRestClient;
        private readonly ServiceBusNamespaceData _data;

        /// <summary> Initializes a new instance of the <see cref="ServiceBusNamespace"/> class for mocking. </summary>
        protected ServiceBusNamespace()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ServiceBusNamespace"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ServiceBusNamespace(ArmClient client, ServiceBusNamespaceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceBusNamespace"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ServiceBusNamespace(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceBusNamespaceNamespacesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceBus", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string serviceBusNamespaceNamespacesApiVersion);
            _serviceBusNamespaceNamespacesRestClient = new NamespacesRestOperations(_serviceBusNamespaceNamespacesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, serviceBusNamespaceNamespacesApiVersion);
            _privateLinkResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceBus", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
            _privateLinkResourcesRestClient = new PrivateLinkResourcesRestOperations(_privateLinkResourcesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
            _disasterRecoveryDisasterRecoveryConfigsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceBus", DisasterRecovery.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(DisasterRecovery.ResourceType, out string disasterRecoveryDisasterRecoveryConfigsApiVersion);
            _disasterRecoveryDisasterRecoveryConfigsRestClient = new DisasterRecoveryConfigsRestOperations(_disasterRecoveryDisasterRecoveryConfigsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, disasterRecoveryDisasterRecoveryConfigsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ServiceBus/namespaces";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ServiceBusNamespaceData Data
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

        /// <summary> Gets an object representing a NetworkRuleSet along with the instance operations that can be performed on it in the ServiceBusNamespace. </summary>
        /// <returns> Returns a <see cref="NetworkRuleSet" /> object. </returns>
        public virtual NetworkRuleSet GetNetworkRuleSet()
        {
            return new NetworkRuleSet(Client, new ResourceIdentifier(Id.ToString() + "/networkRuleSets/default"));
        }

        /// <summary> Gets a collection of PrivateEndpointConnections in the PrivateEndpointConnection. </summary>
        /// <returns> An object representing collection of PrivateEndpointConnections and their operations over a PrivateEndpointConnection. </returns>
        public virtual PrivateEndpointConnectionCollection GetPrivateEndpointConnections()
        {
            return new PrivateEndpointConnectionCollection(Client, Id);
        }

        /// <summary> Gets a collection of DisasterRecoveries in the DisasterRecovery. </summary>
        /// <returns> An object representing collection of DisasterRecoveries and their operations over a DisasterRecovery. </returns>
        public virtual DisasterRecoveryCollection GetDisasterRecoveries()
        {
            return new DisasterRecoveryCollection(Client, Id);
        }

        /// <summary> Gets a collection of NamespaceAuthorizationRules in the NamespaceAuthorizationRule. </summary>
        /// <returns> An object representing collection of NamespaceAuthorizationRules and their operations over a NamespaceAuthorizationRule. </returns>
        public virtual NamespaceAuthorizationRuleCollection GetNamespaceAuthorizationRules()
        {
            return new NamespaceAuthorizationRuleCollection(Client, Id);
        }

        /// <summary> Gets a collection of MigrationConfigProperties in the MigrationConfigProperties. </summary>
        /// <returns> An object representing collection of MigrationConfigProperties and their operations over a MigrationConfigProperties. </returns>
        public virtual MigrationConfigPropertiesCollection GetMigrationConfigProperties()
        {
            return new MigrationConfigPropertiesCollection(Client, Id);
        }

        /// <summary> Gets a collection of ServiceBusQueues in the ServiceBusQueue. </summary>
        /// <returns> An object representing collection of ServiceBusQueues and their operations over a ServiceBusQueue. </returns>
        public virtual ServiceBusQueueCollection GetServiceBusQueues()
        {
            return new ServiceBusQueueCollection(Client, Id);
        }

        /// <summary> Gets a collection of ServiceBusTopics in the ServiceBusTopic. </summary>
        /// <returns> An object representing collection of ServiceBusTopics and their operations over a ServiceBusTopic. </returns>
        public virtual ServiceBusTopicCollection GetServiceBusTopics()
        {
            return new ServiceBusTopicCollection(Client, Id);
        }

        /// <summary>
        /// Gets a description for the specified namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// Operation Id: Namespaces_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ServiceBusNamespace>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceBusNamespaceNamespacesClientDiagnostics.CreateScope("ServiceBusNamespace.Get");
            scope.Start();
            try
            {
                var response = await _serviceBusNamespaceNamespacesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _serviceBusNamespaceNamespacesClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ServiceBusNamespace(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a description for the specified namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// Operation Id: Namespaces_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServiceBusNamespace> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceBusNamespaceNamespacesClientDiagnostics.CreateScope("ServiceBusNamespace.Get");
            scope.Start();
            try
            {
                var response = _serviceBusNamespaceNamespacesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _serviceBusNamespaceNamespacesClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceBusNamespace(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an existing namespace. This operation also removes all associated resources under the namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// Operation Id: Namespaces_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceBusNamespaceNamespacesClientDiagnostics.CreateScope("ServiceBusNamespace.Delete");
            scope.Start();
            try
            {
                var response = await _serviceBusNamespaceNamespacesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceBusArmOperation(_serviceBusNamespaceNamespacesClientDiagnostics, Pipeline, _serviceBusNamespaceNamespacesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Deletes an existing namespace. This operation also removes all associated resources under the namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// Operation Id: Namespaces_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _serviceBusNamespaceNamespacesClientDiagnostics.CreateScope("ServiceBusNamespace.Delete");
            scope.Start();
            try
            {
                var response = _serviceBusNamespaceNamespacesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new ServiceBusArmOperation(_serviceBusNamespaceNamespacesClientDiagnostics, Pipeline, _serviceBusNamespaceNamespacesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Updates a service namespace. Once created, this namespace&apos;s resource manifest is immutable. This operation is idempotent.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// Operation Id: Namespaces_Update
        /// </summary>
        /// <param name="options"> Parameters supplied to update a namespace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="options"/> is null. </exception>
        public async virtual Task<Response<ServiceBusNamespace>> UpdateAsync(ServiceBusNamespaceUpdateOptions options, CancellationToken cancellationToken = default)
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            using var scope = _serviceBusNamespaceNamespacesClientDiagnostics.CreateScope("ServiceBusNamespace.Update");
            scope.Start();
            try
            {
                var response = await _serviceBusNamespaceNamespacesRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ServiceBusNamespace(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates a service namespace. Once created, this namespace&apos;s resource manifest is immutable. This operation is idempotent.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// Operation Id: Namespaces_Update
        /// </summary>
        /// <param name="options"> Parameters supplied to update a namespace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="options"/> is null. </exception>
        public virtual Response<ServiceBusNamespace> Update(ServiceBusNamespaceUpdateOptions options, CancellationToken cancellationToken = default)
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            using var scope = _serviceBusNamespaceNamespacesClientDiagnostics.CreateScope("ServiceBusNamespace.Update");
            scope.Start();
            try
            {
                var response = _serviceBusNamespaceNamespacesRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options, cancellationToken);
                return Response.FromValue(new ServiceBusNamespace(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets lists of resources that supports Privatelinks.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/privateLinkResources
        /// Operation Id: PrivateLinkResources_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PrivateLinkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PrivateLinkResource> GetPrivateLinkResourcesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<PrivateLinkResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _privateLinkResourcesClientDiagnostics.CreateScope("ServiceBusNamespace.GetPrivateLinkResources");
                scope.Start();
                try
                {
                    var response = await _privateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Gets lists of resources that supports Privatelinks.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/privateLinkResources
        /// Operation Id: PrivateLinkResources_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PrivateLinkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PrivateLinkResource> GetPrivateLinkResources(CancellationToken cancellationToken = default)
        {
            Page<PrivateLinkResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _privateLinkResourcesClientDiagnostics.CreateScope("ServiceBusNamespace.GetPrivateLinkResources");
                scope.Start();
                try
                {
                    var response = _privateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Check the give namespace name availability.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/CheckNameAvailability
        /// Operation Id: DisasterRecoveryConfigs_CheckNameAvailability
        /// </summary>
        /// <param name="parameters"> Parameters to check availability of the given namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<CheckNameAvailabilityResult>> CheckDisasterRecoveryNameAvailabilityAsync(CheckNameAvailability parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _disasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("ServiceBusNamespace.CheckDisasterRecoveryNameAvailability");
            scope.Start();
            try
            {
                var response = await _disasterRecoveryDisasterRecoveryConfigsRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the give namespace name availability.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/disasterRecoveryConfigs/CheckNameAvailability
        /// Operation Id: DisasterRecoveryConfigs_CheckNameAvailability
        /// </summary>
        /// <param name="parameters"> Parameters to check availability of the given namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual Response<CheckNameAvailabilityResult> CheckDisasterRecoveryNameAvailability(CheckNameAvailability parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _disasterRecoveryDisasterRecoveryConfigsClientDiagnostics.CreateScope("ServiceBusNamespace.CheckDisasterRecoveryNameAvailability");
            scope.Start();
            try
            {
                var response = _disasterRecoveryDisasterRecoveryConfigsRestClient.CheckNameAvailability(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, parameters, cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// Operation Id: Namespaces_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public async virtual Task<Response<ServiceBusNamespace>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            using var scope = _serviceBusNamespaceNamespacesClientDiagnostics.CreateScope("ServiceBusNamespace.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _serviceBusNamespaceNamespacesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ServiceBusNamespace(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// Operation Id: Namespaces_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<ServiceBusNamespace> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            using var scope = _serviceBusNamespaceNamespacesClientDiagnostics.CreateScope("ServiceBusNamespace.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _serviceBusNamespaceNamespacesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new ServiceBusNamespace(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// Operation Id: Namespaces_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public async virtual Task<Response<ServiceBusNamespace>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }

            using var scope = _serviceBusNamespaceNamespacesClientDiagnostics.CreateScope("ServiceBusNamespace.SetTags");
            scope.Start();
            try
            {
                await TagResource.DeleteAsync(true, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _serviceBusNamespaceNamespacesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ServiceBusNamespace(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// Operation Id: Namespaces_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<ServiceBusNamespace> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }

            using var scope = _serviceBusNamespaceNamespacesClientDiagnostics.CreateScope("ServiceBusNamespace.SetTags");
            scope.Start();
            try
            {
                TagResource.Delete(true, cancellationToken: cancellationToken);
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _serviceBusNamespaceNamespacesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new ServiceBusNamespace(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// Operation Id: Namespaces_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public async virtual Task<Response<ServiceBusNamespace>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _serviceBusNamespaceNamespacesClientDiagnostics.CreateScope("ServiceBusNamespace.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _serviceBusNamespaceNamespacesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ServiceBusNamespace(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// Operation Id: Namespaces_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<ServiceBusNamespace> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _serviceBusNamespaceNamespacesClientDiagnostics.CreateScope("ServiceBusNamespace.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _serviceBusNamespaceNamespacesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new ServiceBusNamespace(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
