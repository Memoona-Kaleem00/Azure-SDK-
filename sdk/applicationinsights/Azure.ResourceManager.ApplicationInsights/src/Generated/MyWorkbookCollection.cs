// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ApplicationInsights.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ApplicationInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="MyWorkbookResource"/> and their operations.
    /// Each <see cref="MyWorkbookResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="MyWorkbookCollection"/> instance call the GetMyWorkbooks method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class MyWorkbookCollection : ArmCollection
    {
        private readonly ClientDiagnostics _myWorkbookClientDiagnostics;
        private readonly MyWorkbooksRestOperations _myWorkbookRestClient;

        /// <summary> Initializes a new instance of the <see cref="MyWorkbookCollection"/> class for mocking. </summary>
        protected MyWorkbookCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MyWorkbookCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MyWorkbookCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _myWorkbookClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApplicationInsights", MyWorkbookResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MyWorkbookResource.ResourceType, out string myWorkbookApiVersion);
            _myWorkbookRestClient = new MyWorkbooksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, myWorkbookApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a new private workbook.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/myWorkbooks/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MyWorkbooks_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-03-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MyWorkbookResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="data"> Properties that need to be specified to create a new private workbook. </param>
        /// <param name="sourceId"> Azure Resource Id that will fetch all linked workbooks. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MyWorkbookResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string resourceName, MyWorkbookData data, string sourceId = null, CancellationToken cancellationToken = default)
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _myWorkbookClientDiagnostics.CreateScope("MyWorkbookCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _myWorkbookRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, resourceName, data, sourceId, cancellationToken).ConfigureAwait(false);
                var uri = _myWorkbookRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, resourceName, data, sourceId);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ApplicationInsightsArmOperation<MyWorkbookResource>(Response.FromValue(new MyWorkbookResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Create a new private workbook.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/myWorkbooks/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MyWorkbooks_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-03-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MyWorkbookResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="data"> Properties that need to be specified to create a new private workbook. </param>
        /// <param name="sourceId"> Azure Resource Id that will fetch all linked workbooks. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MyWorkbookResource> CreateOrUpdate(WaitUntil waitUntil, string resourceName, MyWorkbookData data, string sourceId = null, CancellationToken cancellationToken = default)
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _myWorkbookClientDiagnostics.CreateScope("MyWorkbookCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _myWorkbookRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, resourceName, data, sourceId, cancellationToken);
                var uri = _myWorkbookRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, resourceName, data, sourceId);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ApplicationInsightsArmOperation<MyWorkbookResource>(Response.FromValue(new MyWorkbookResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Get a single private workbook by its resourceName.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/myWorkbooks/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MyWorkbooks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-03-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MyWorkbookResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<Response<MyWorkbookResource>> GetAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }

            using var scope = _myWorkbookClientDiagnostics.CreateScope("MyWorkbookCollection.Get");
            scope.Start();
            try
            {
                var response = await _myWorkbookRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MyWorkbookResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a single private workbook by its resourceName.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/myWorkbooks/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MyWorkbooks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-03-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MyWorkbookResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<MyWorkbookResource> Get(string resourceName, CancellationToken cancellationToken = default)
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }

            using var scope = _myWorkbookClientDiagnostics.CreateScope("MyWorkbookCollection.Get");
            scope.Start();
            try
            {
                var response = _myWorkbookRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MyWorkbookResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all private workbooks defined within a specified resource group and category.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/myWorkbooks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MyWorkbooks_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-03-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MyWorkbookResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="category"> Category of workbook to return. </param>
        /// <param name="tags"> Tags presents on each workbook returned. </param>
        /// <param name="sourceId"> Azure Resource Id that will fetch all linked workbooks. </param>
        /// <param name="canFetchContent"> Flag indicating whether or not to return the full content for each applicable workbook. If false, only return summary content for workbooks. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MyWorkbookResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MyWorkbookResource> GetAllAsync(CategoryType category, IEnumerable<string> tags = null, string sourceId = null, bool? canFetchContent = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _myWorkbookRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, category, tags, sourceId, canFetchContent);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _myWorkbookRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, category, tags, sourceId, canFetchContent);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MyWorkbookResource(Client, MyWorkbookData.DeserializeMyWorkbookData(e)), _myWorkbookClientDiagnostics, Pipeline, "MyWorkbookCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get all private workbooks defined within a specified resource group and category.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/myWorkbooks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MyWorkbooks_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-03-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MyWorkbookResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="category"> Category of workbook to return. </param>
        /// <param name="tags"> Tags presents on each workbook returned. </param>
        /// <param name="sourceId"> Azure Resource Id that will fetch all linked workbooks. </param>
        /// <param name="canFetchContent"> Flag indicating whether or not to return the full content for each applicable workbook. If false, only return summary content for workbooks. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MyWorkbookResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MyWorkbookResource> GetAll(CategoryType category, IEnumerable<string> tags = null, string sourceId = null, bool? canFetchContent = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _myWorkbookRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, category, tags, sourceId, canFetchContent);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _myWorkbookRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, category, tags, sourceId, canFetchContent);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MyWorkbookResource(Client, MyWorkbookData.DeserializeMyWorkbookData(e)), _myWorkbookClientDiagnostics, Pipeline, "MyWorkbookCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/myWorkbooks/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MyWorkbooks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-03-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MyWorkbookResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }

            using var scope = _myWorkbookClientDiagnostics.CreateScope("MyWorkbookCollection.Exists");
            scope.Start();
            try
            {
                var response = await _myWorkbookRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/myWorkbooks/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MyWorkbooks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-03-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MyWorkbookResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string resourceName, CancellationToken cancellationToken = default)
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }

            using var scope = _myWorkbookClientDiagnostics.CreateScope("MyWorkbookCollection.Exists");
            scope.Start();
            try
            {
                var response = _myWorkbookRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/myWorkbooks/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MyWorkbooks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-03-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MyWorkbookResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<NullableResponse<MyWorkbookResource>> GetIfExistsAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }

            using var scope = _myWorkbookClientDiagnostics.CreateScope("MyWorkbookCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _myWorkbookRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MyWorkbookResource>(response.GetRawResponse());
                return Response.FromValue(new MyWorkbookResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/myWorkbooks/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MyWorkbooks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-03-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MyWorkbookResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual NullableResponse<MyWorkbookResource> GetIfExists(string resourceName, CancellationToken cancellationToken = default)
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }

            using var scope = _myWorkbookClientDiagnostics.CreateScope("MyWorkbookCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _myWorkbookRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MyWorkbookResource>(response.GetRawResponse());
                return Response.FromValue(new MyWorkbookResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
