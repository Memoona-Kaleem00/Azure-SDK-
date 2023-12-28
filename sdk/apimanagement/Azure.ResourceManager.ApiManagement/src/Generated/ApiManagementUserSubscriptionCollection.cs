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

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ApiManagementUserSubscriptionResource"/> and their operations.
    /// Each <see cref="ApiManagementUserSubscriptionResource"/> in the collection will belong to the same instance of <see cref="ApiManagementUserResource"/>.
    /// To get an <see cref="ApiManagementUserSubscriptionCollection"/> instance call the GetApiManagementUserSubscriptions method from an instance of <see cref="ApiManagementUserResource"/>.
    /// </summary>
    public partial class ApiManagementUserSubscriptionCollection : ArmCollection, IEnumerable<ApiManagementUserSubscriptionResource>, IAsyncEnumerable<ApiManagementUserSubscriptionResource>
    {
        private readonly ClientDiagnostics _apiManagementUserSubscriptionUserSubscriptionClientDiagnostics;
        private readonly UserSubscriptionRestOperations _apiManagementUserSubscriptionUserSubscriptionRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementUserSubscriptionCollection"/> class for mocking. </summary>
        protected ApiManagementUserSubscriptionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementUserSubscriptionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiManagementUserSubscriptionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementUserSubscriptionUserSubscriptionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiManagementUserSubscriptionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiManagementUserSubscriptionResource.ResourceType, out string apiManagementUserSubscriptionUserSubscriptionApiVersion);
            _apiManagementUserSubscriptionUserSubscriptionRestClient = new UserSubscriptionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementUserSubscriptionUserSubscriptionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiManagementUserResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiManagementUserResource.ResourceType), nameof(id));
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
        /// <param name="sid"> Subscription entity Identifier. The entity represents the association between a user and a product in API Management. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sid"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sid"/> is null. </exception>
        public virtual async Task<Response<ApiManagementUserSubscriptionResource>> GetAsync(string sid, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sid, nameof(sid));

            using var scope = _apiManagementUserSubscriptionUserSubscriptionClientDiagnostics.CreateScope("ApiManagementUserSubscriptionCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementUserSubscriptionUserSubscriptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, sid, cancellationToken).ConfigureAwait(false);
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
        /// <param name="sid"> Subscription entity Identifier. The entity represents the association between a user and a product in API Management. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sid"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sid"/> is null. </exception>
        public virtual Response<ApiManagementUserSubscriptionResource> Get(string sid, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sid, nameof(sid));

            using var scope = _apiManagementUserSubscriptionUserSubscriptionClientDiagnostics.CreateScope("ApiManagementUserSubscriptionCollection.Get");
            scope.Start();
            try
            {
                var response = _apiManagementUserSubscriptionUserSubscriptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, sid, cancellationToken);
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
        /// Lists the collection of subscriptions of the specified user.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/users/{userId}/subscriptions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UserSubscription_List</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.ApiManagement/service/users/subscriptions</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> | Field     |     Usage     |     Supported operators    | Supported functions               |&lt;/br&gt;|-------------|------------------------|-----------------------------------|&lt;/br&gt;|name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;|displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;|stateComment | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;|ownerId | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;|scope | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;|userId | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;|productId | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiManagementUserSubscriptionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementUserSubscriptionResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementUserSubscriptionUserSubscriptionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementUserSubscriptionUserSubscriptionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ApiManagementUserSubscriptionResource(Client, SubscriptionContractData.DeserializeSubscriptionContractData(e)), _apiManagementUserSubscriptionUserSubscriptionClientDiagnostics, Pipeline, "ApiManagementUserSubscriptionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the collection of subscriptions of the specified user.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/users/{userId}/subscriptions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UserSubscription_List</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.ApiManagement/service/users/subscriptions</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> | Field     |     Usage     |     Supported operators    | Supported functions               |&lt;/br&gt;|-------------|------------------------|-----------------------------------|&lt;/br&gt;|name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;|displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;|stateComment | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;|ownerId | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;|scope | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;|userId | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;|productId | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiManagementUserSubscriptionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementUserSubscriptionResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementUserSubscriptionUserSubscriptionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementUserSubscriptionUserSubscriptionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ApiManagementUserSubscriptionResource(Client, SubscriptionContractData.DeserializeSubscriptionContractData(e)), _apiManagementUserSubscriptionUserSubscriptionClientDiagnostics, Pipeline, "ApiManagementUserSubscriptionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
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
        /// <param name="sid"> Subscription entity Identifier. The entity represents the association between a user and a product in API Management. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sid"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sid"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string sid, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sid, nameof(sid));

            using var scope = _apiManagementUserSubscriptionUserSubscriptionClientDiagnostics.CreateScope("ApiManagementUserSubscriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiManagementUserSubscriptionUserSubscriptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, sid, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <param name="sid"> Subscription entity Identifier. The entity represents the association between a user and a product in API Management. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sid"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sid"/> is null. </exception>
        public virtual Response<bool> Exists(string sid, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sid, nameof(sid));

            using var scope = _apiManagementUserSubscriptionUserSubscriptionClientDiagnostics.CreateScope("ApiManagementUserSubscriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiManagementUserSubscriptionUserSubscriptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, sid, cancellationToken: cancellationToken);
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
        /// <param name="sid"> Subscription entity Identifier. The entity represents the association between a user and a product in API Management. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sid"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sid"/> is null. </exception>
        public virtual async Task<NullableResponse<ApiManagementUserSubscriptionResource>> GetIfExistsAsync(string sid, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sid, nameof(sid));

            using var scope = _apiManagementUserSubscriptionUserSubscriptionClientDiagnostics.CreateScope("ApiManagementUserSubscriptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _apiManagementUserSubscriptionUserSubscriptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, sid, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ApiManagementUserSubscriptionResource>(response.GetRawResponse());
                return Response.FromValue(new ApiManagementUserSubscriptionResource(Client, response.Value), response.GetRawResponse());
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
        /// <param name="sid"> Subscription entity Identifier. The entity represents the association between a user and a product in API Management. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sid"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sid"/> is null. </exception>
        public virtual NullableResponse<ApiManagementUserSubscriptionResource> GetIfExists(string sid, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sid, nameof(sid));

            using var scope = _apiManagementUserSubscriptionUserSubscriptionClientDiagnostics.CreateScope("ApiManagementUserSubscriptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _apiManagementUserSubscriptionUserSubscriptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, sid, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ApiManagementUserSubscriptionResource>(response.GetRawResponse());
                return Response.FromValue(new ApiManagementUserSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiManagementUserSubscriptionResource> IEnumerable<ApiManagementUserSubscriptionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiManagementUserSubscriptionResource> IAsyncEnumerable<ApiManagementUserSubscriptionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
