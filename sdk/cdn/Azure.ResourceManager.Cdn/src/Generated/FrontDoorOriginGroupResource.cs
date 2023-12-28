// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Cdn.Models;

namespace Azure.ResourceManager.Cdn
{
    /// <summary>
    /// A Class representing a FrontDoorOriginGroup along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="FrontDoorOriginGroupResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetFrontDoorOriginGroupResource method.
    /// Otherwise you can get one from its parent resource <see cref="ProfileResource"/> using the GetFrontDoorOriginGroup method.
    /// </summary>
    public partial class FrontDoorOriginGroupResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="FrontDoorOriginGroupResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="profileName"> The profileName. </param>
        /// <param name="originGroupName"> The originGroupName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string profileName, string originGroupName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _frontDoorOriginGroupClientDiagnostics;
        private readonly FrontDoorOriginGroupsRestOperations _frontDoorOriginGroupRestClient;
        private readonly FrontDoorOriginGroupData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Cdn/profiles/originGroups";

        /// <summary> Initializes a new instance of the <see cref="FrontDoorOriginGroupResource"/> class for mocking. </summary>
        protected FrontDoorOriginGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FrontDoorOriginGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal FrontDoorOriginGroupResource(ArmClient client, FrontDoorOriginGroupData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="FrontDoorOriginGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal FrontDoorOriginGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _frontDoorOriginGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Cdn", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string frontDoorOriginGroupApiVersion);
            _frontDoorOriginGroupRestClient = new FrontDoorOriginGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, frontDoorOriginGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual FrontDoorOriginGroupData Data
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

        /// <summary> Gets a collection of FrontDoorOriginResources in the FrontDoorOriginGroup. </summary>
        /// <returns> An object representing collection of FrontDoorOriginResources and their operations over a FrontDoorOriginResource. </returns>
        public virtual FrontDoorOriginCollection GetFrontDoorOrigins()
        {
            return GetCachedClient(client => new FrontDoorOriginCollection(client, Id));
        }

        /// <summary>
        /// Gets an existing origin within an origin group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}/origins/{originName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorOrigins_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Cdn/profiles/originGroups/origins</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="originName"> Name of the origin which is unique within the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="originName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="originName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<FrontDoorOriginResource>> GetFrontDoorOriginAsync(string originName, CancellationToken cancellationToken = default)
        {
            return await GetFrontDoorOrigins().GetAsync(originName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an existing origin within an origin group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}/origins/{originName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorOrigins_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Cdn/profiles/originGroups/origins</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="originName"> Name of the origin which is unique within the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="originName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="originName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<FrontDoorOriginResource> GetFrontDoorOrigin(string originName, CancellationToken cancellationToken = default)
        {
            return GetFrontDoorOrigins().Get(originName, cancellationToken);
        }

        /// <summary>
        /// Gets an existing origin group within a profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorOriginGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Cdn/profiles/originGroups</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FrontDoorOriginGroupResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _frontDoorOriginGroupClientDiagnostics.CreateScope("FrontDoorOriginGroupResource.Get");
            scope.Start();
            try
            {
                var response = await _frontDoorOriginGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FrontDoorOriginGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an existing origin group within a profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorOriginGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Cdn/profiles/originGroups</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FrontDoorOriginGroupResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _frontDoorOriginGroupClientDiagnostics.CreateScope("FrontDoorOriginGroupResource.Get");
            scope.Start();
            try
            {
                var response = _frontDoorOriginGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FrontDoorOriginGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an existing origin group within a profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorOriginGroups_Delete</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Cdn/profiles/originGroups</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _frontDoorOriginGroupClientDiagnostics.CreateScope("FrontDoorOriginGroupResource.Delete");
            scope.Start();
            try
            {
                var response = await _frontDoorOriginGroupRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CdnArmOperation(_frontDoorOriginGroupClientDiagnostics, Pipeline, _frontDoorOriginGroupRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Deletes an existing origin group within a profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorOriginGroups_Delete</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Cdn/profiles/originGroups</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _frontDoorOriginGroupClientDiagnostics.CreateScope("FrontDoorOriginGroupResource.Delete");
            scope.Start();
            try
            {
                var response = _frontDoorOriginGroupRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new CdnArmOperation(_frontDoorOriginGroupClientDiagnostics, Pipeline, _frontDoorOriginGroupRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Updates an existing origin group within a profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorOriginGroups_Update</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Cdn/profiles/originGroups</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Origin group properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<ArmOperation<FrontDoorOriginGroupResource>> UpdateAsync(WaitUntil waitUntil, FrontDoorOriginGroupPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _frontDoorOriginGroupClientDiagnostics.CreateScope("FrontDoorOriginGroupResource.Update");
            scope.Start();
            try
            {
                var response = await _frontDoorOriginGroupRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                var operation = new CdnArmOperation<FrontDoorOriginGroupResource>(new FrontDoorOriginGroupOperationSource(Client), _frontDoorOriginGroupClientDiagnostics, Pipeline, _frontDoorOriginGroupRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Updates an existing origin group within a profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorOriginGroups_Update</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Cdn/profiles/originGroups</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Origin group properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual ArmOperation<FrontDoorOriginGroupResource> Update(WaitUntil waitUntil, FrontDoorOriginGroupPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _frontDoorOriginGroupClientDiagnostics.CreateScope("FrontDoorOriginGroupResource.Update");
            scope.Start();
            try
            {
                var response = _frontDoorOriginGroupRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken);
                var operation = new CdnArmOperation<FrontDoorOriginGroupResource>(new FrontDoorOriginGroupOperationSource(Client), _frontDoorOriginGroupClientDiagnostics, Pipeline, _frontDoorOriginGroupRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Checks the quota and actual usage of the given AzureFrontDoor origin group under the given CDN profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorOriginGroups_ListResourceUsage</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Cdn/profiles/originGroups</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FrontDoorUsage"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FrontDoorUsage> GetResourceUsagesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _frontDoorOriginGroupRestClient.CreateListResourceUsageRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _frontDoorOriginGroupRestClient.CreateListResourceUsageNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, FrontDoorUsage.DeserializeFrontDoorUsage, _frontDoorOriginGroupClientDiagnostics, Pipeline, "FrontDoorOriginGroupResource.GetResourceUsages", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks the quota and actual usage of the given AzureFrontDoor origin group under the given CDN profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorOriginGroups_ListResourceUsage</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Cdn/profiles/originGroups</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FrontDoorUsage"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FrontDoorUsage> GetResourceUsages(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _frontDoorOriginGroupRestClient.CreateListResourceUsageRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _frontDoorOriginGroupRestClient.CreateListResourceUsageNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, FrontDoorUsage.DeserializeFrontDoorUsage, _frontDoorOriginGroupClientDiagnostics, Pipeline, "FrontDoorOriginGroupResource.GetResourceUsages", "value", "nextLink", cancellationToken);
        }
    }
}
