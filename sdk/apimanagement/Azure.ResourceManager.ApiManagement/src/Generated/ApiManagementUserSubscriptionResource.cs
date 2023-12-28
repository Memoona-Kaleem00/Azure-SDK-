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

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A Class representing an ApiManagementUserSubscription along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="ApiManagementUserSubscriptionResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetApiManagementUserSubscriptionResource method.
    /// Otherwise you can get one from its parent resource <see cref="ApiManagementUserResource"/> using the GetApiManagementUserSubscription method.
    /// </summary>
    public partial class ApiManagementUserSubscriptionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ApiManagementUserSubscriptionResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="serviceName"> The serviceName. </param>
        /// <param name="userId"> The userId. </param>
        /// <param name="sid"> The sid. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string userId, string sid)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/users/{userId}/subscriptions/{sid}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _apiManagementUserSubscriptionUserSubscriptionClientDiagnostics;
        private readonly UserSubscriptionRestOperations _apiManagementUserSubscriptionUserSubscriptionRestClient;
        private readonly SubscriptionContractData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ApiManagement/service/users/subscriptions";

        /// <summary> Initializes a new instance of the <see cref="ApiManagementUserSubscriptionResource"/> class for mocking. </summary>
        protected ApiManagementUserSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementUserSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ApiManagementUserSubscriptionResource(ArmClient client, SubscriptionContractData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementUserSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ApiManagementUserSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementUserSubscriptionUserSubscriptionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string apiManagementUserSubscriptionUserSubscriptionApiVersion);
            _apiManagementUserSubscriptionUserSubscriptionRestClient = new UserSubscriptionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementUserSubscriptionUserSubscriptionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SubscriptionContractData Data
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
        /// Gets the specified Subscription entity associated with a particular user.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/users/{userId}/subscriptions/{sid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UserSubscription_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.ApiManagement/service/users/subscriptions</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ApiManagementUserSubscriptionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementUserSubscriptionUserSubscriptionClientDiagnostics.CreateScope("ApiManagementUserSubscriptionResource.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementUserSubscriptionUserSubscriptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementUserSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Subscription entity associated with a particular user.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/users/{userId}/subscriptions/{sid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UserSubscription_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.ApiManagement/service/users/subscriptions</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApiManagementUserSubscriptionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementUserSubscriptionUserSubscriptionClientDiagnostics.CreateScope("ApiManagementUserSubscriptionResource.Get");
            scope.Start();
            try
            {
                var response = _apiManagementUserSubscriptionUserSubscriptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementUserSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
