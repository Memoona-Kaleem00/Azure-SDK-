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
    /// A class representing a collection of <see cref="ApiIssueResource"/> and their operations.
    /// Each <see cref="ApiIssueResource"/> in the collection will belong to the same instance of <see cref="ApiResource"/>.
    /// To get an <see cref="ApiIssueCollection"/> instance call the GetApiIssues method from an instance of <see cref="ApiResource"/>.
    /// </summary>
    public partial class ApiIssueCollection : ArmCollection, IEnumerable<ApiIssueResource>, IAsyncEnumerable<ApiIssueResource>
    {
        private readonly ClientDiagnostics _apiIssueClientDiagnostics;
        private readonly ApiIssueRestOperations _apiIssueRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiIssueCollection"/> class for mocking. </summary>
        protected ApiIssueCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiIssueCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiIssueCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiIssueClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiIssueResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiIssueResource.ResourceType, out string apiIssueApiVersion);
            _apiIssueRestClient = new ApiIssueRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiIssueApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new Issue for an API or updates an existing one.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiIssue_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="issueId"> Issue identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="issueId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="issueId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiIssueResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string issueId, IssueContractData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(issueId, nameof(issueId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiIssueClientDiagnostics.CreateScope("ApiIssueCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiIssueRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, issueId, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ApiIssueResource>(Response.FromValue(new ApiIssueResource(Client, response), response.GetRawResponse()));
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
        /// Creates a new Issue for an API or updates an existing one.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiIssue_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="issueId"> Issue identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="issueId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="issueId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ApiIssueResource> CreateOrUpdate(WaitUntil waitUntil, string issueId, IssueContractData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(issueId, nameof(issueId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiIssueClientDiagnostics.CreateScope("ApiIssueCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiIssueRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, issueId, data, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ApiIssueResource>(Response.FromValue(new ApiIssueResource(Client, response), response.GetRawResponse()));
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
        /// Gets the details of the Issue for an API specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiIssue_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="issueId"> Issue identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="expandCommentsAttachments"> Expand the comment attachments. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="issueId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="issueId"/> is null. </exception>
        public virtual async Task<Response<ApiIssueResource>> GetAsync(string issueId, bool? expandCommentsAttachments = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(issueId, nameof(issueId));

            using var scope = _apiIssueClientDiagnostics.CreateScope("ApiIssueCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiIssueRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, issueId, expandCommentsAttachments, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiIssueResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the Issue for an API specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiIssue_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="issueId"> Issue identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="expandCommentsAttachments"> Expand the comment attachments. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="issueId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="issueId"/> is null. </exception>
        public virtual Response<ApiIssueResource> Get(string issueId, bool? expandCommentsAttachments = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(issueId, nameof(issueId));

            using var scope = _apiIssueClientDiagnostics.CreateScope("ApiIssueCollection.Get");
            scope.Start();
            try
            {
                var response = _apiIssueRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, issueId, expandCommentsAttachments, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiIssueResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all issues associated with the specified API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiIssue_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| userId | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| state | filter | eq |     |&lt;/br&gt;. </param>
        /// <param name="expandCommentsAttachments"> Expand the comment attachments. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiIssueResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiIssueResource> GetAllAsync(string filter = null, bool? expandCommentsAttachments = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiIssueRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, expandCommentsAttachments, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiIssueRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, expandCommentsAttachments, top, skip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ApiIssueResource(Client, IssueContractData.DeserializeIssueContractData(e)), _apiIssueClientDiagnostics, Pipeline, "ApiIssueCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all issues associated with the specified API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiIssue_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| userId | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| state | filter | eq |     |&lt;/br&gt;. </param>
        /// <param name="expandCommentsAttachments"> Expand the comment attachments. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiIssueResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiIssueResource> GetAll(string filter = null, bool? expandCommentsAttachments = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiIssueRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, expandCommentsAttachments, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiIssueRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, expandCommentsAttachments, top, skip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ApiIssueResource(Client, IssueContractData.DeserializeIssueContractData(e)), _apiIssueClientDiagnostics, Pipeline, "ApiIssueCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiIssue_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="issueId"> Issue identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="expandCommentsAttachments"> Expand the comment attachments. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="issueId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="issueId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string issueId, bool? expandCommentsAttachments = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(issueId, nameof(issueId));

            using var scope = _apiIssueClientDiagnostics.CreateScope("ApiIssueCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiIssueRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, issueId, expandCommentsAttachments, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiIssue_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="issueId"> Issue identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="expandCommentsAttachments"> Expand the comment attachments. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="issueId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="issueId"/> is null. </exception>
        public virtual Response<bool> Exists(string issueId, bool? expandCommentsAttachments = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(issueId, nameof(issueId));

            using var scope = _apiIssueClientDiagnostics.CreateScope("ApiIssueCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiIssueRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, issueId, expandCommentsAttachments, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiIssue_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="issueId"> Issue identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="expandCommentsAttachments"> Expand the comment attachments. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="issueId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="issueId"/> is null. </exception>
        public virtual async Task<NullableResponse<ApiIssueResource>> GetIfExistsAsync(string issueId, bool? expandCommentsAttachments = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(issueId, nameof(issueId));

            using var scope = _apiIssueClientDiagnostics.CreateScope("ApiIssueCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _apiIssueRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, issueId, expandCommentsAttachments, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ApiIssueResource>(response.GetRawResponse());
                return Response.FromValue(new ApiIssueResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/apis/{apiId}/issues/{issueId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiIssue_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="issueId"> Issue identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="expandCommentsAttachments"> Expand the comment attachments. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="issueId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="issueId"/> is null. </exception>
        public virtual NullableResponse<ApiIssueResource> GetIfExists(string issueId, bool? expandCommentsAttachments = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(issueId, nameof(issueId));

            using var scope = _apiIssueClientDiagnostics.CreateScope("ApiIssueCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _apiIssueRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, issueId, expandCommentsAttachments, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ApiIssueResource>(response.GetRawResponse());
                return Response.FromValue(new ApiIssueResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiIssueResource> IEnumerable<ApiIssueResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiIssueResource> IAsyncEnumerable<ApiIssueResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
