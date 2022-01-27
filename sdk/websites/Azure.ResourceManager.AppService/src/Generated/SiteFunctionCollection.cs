// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of FunctionEnvelope and their operations over its parent. </summary>
    public partial class SiteFunctionCollection : ArmCollection, IEnumerable<SiteFunction>, IAsyncEnumerable<SiteFunction>
    {
        private readonly ClientDiagnostics _siteFunctionWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteFunctionWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteFunctionCollection"/> class for mocking. </summary>
        protected SiteFunctionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteFunctionCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SiteFunctionCollection(ArmResource parent) : base(parent)
        {
            _siteFunctionWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteFunction.ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(SiteFunction.ResourceType, out string siteFunctionWebAppsApiVersion);
            _siteFunctionWebAppsRestClient = new WebAppsRestOperations(_siteFunctionWebAppsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteFunctionWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSite.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSite.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/functions/{functionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_CreateFunction
        /// <summary> Description for Create function for web site, or a deployment slot. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="functionName"> Function name. </param>
        /// <param name="functionEnvelope"> Function details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionName"/> or <paramref name="functionEnvelope"/> is null. </exception>
        public virtual SiteFunctionCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string functionName, FunctionEnvelopeData functionEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionName, nameof(functionName));
            if (functionEnvelope == null)
            {
                throw new ArgumentNullException(nameof(functionEnvelope));
            }

            using var scope = _siteFunctionWebAppsClientDiagnostics.CreateScope("SiteFunctionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteFunctionWebAppsRestClient.CreateFunction(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionName, functionEnvelope, cancellationToken);
                var operation = new SiteFunctionCreateOrUpdateOperation(ArmClient, _siteFunctionWebAppsClientDiagnostics, Pipeline, _siteFunctionWebAppsRestClient.CreateCreateFunctionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionName, functionEnvelope).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/functions/{functionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_CreateFunction
        /// <summary> Description for Create function for web site, or a deployment slot. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="functionName"> Function name. </param>
        /// <param name="functionEnvelope"> Function details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionName"/> or <paramref name="functionEnvelope"/> is null. </exception>
        public async virtual Task<SiteFunctionCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string functionName, FunctionEnvelopeData functionEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionName, nameof(functionName));
            if (functionEnvelope == null)
            {
                throw new ArgumentNullException(nameof(functionEnvelope));
            }

            using var scope = _siteFunctionWebAppsClientDiagnostics.CreateScope("SiteFunctionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteFunctionWebAppsRestClient.CreateFunctionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionName, functionEnvelope, cancellationToken).ConfigureAwait(false);
                var operation = new SiteFunctionCreateOrUpdateOperation(ArmClient, _siteFunctionWebAppsClientDiagnostics, Pipeline, _siteFunctionWebAppsRestClient.CreateCreateFunctionRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionName, functionEnvelope).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/functions/{functionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetFunction
        /// <summary> Description for Get function information by its ID for web site, or a deployment slot. </summary>
        /// <param name="functionName"> Function name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionName"/> is null. </exception>
        public virtual Response<SiteFunction> Get(string functionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionName, nameof(functionName));

            using var scope = _siteFunctionWebAppsClientDiagnostics.CreateScope("SiteFunctionCollection.Get");
            scope.Start();
            try
            {
                var response = _siteFunctionWebAppsRestClient.GetFunction(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionName, cancellationToken);
                if (response.Value == null)
                    throw _siteFunctionWebAppsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteFunction(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/functions/{functionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetFunction
        /// <summary> Description for Get function information by its ID for web site, or a deployment slot. </summary>
        /// <param name="functionName"> Function name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionName"/> is null. </exception>
        public async virtual Task<Response<SiteFunction>> GetAsync(string functionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionName, nameof(functionName));

            using var scope = _siteFunctionWebAppsClientDiagnostics.CreateScope("SiteFunctionCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteFunctionWebAppsRestClient.GetFunctionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _siteFunctionWebAppsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteFunction(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="functionName"> Function name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionName"/> is null. </exception>
        public virtual Response<SiteFunction> GetIfExists(string functionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionName, nameof(functionName));

            using var scope = _siteFunctionWebAppsClientDiagnostics.CreateScope("SiteFunctionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteFunctionWebAppsRestClient.GetFunction(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteFunction>(null, response.GetRawResponse());
                return Response.FromValue(new SiteFunction(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="functionName"> Function name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionName"/> is null. </exception>
        public async virtual Task<Response<SiteFunction>> GetIfExistsAsync(string functionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionName, nameof(functionName));

            using var scope = _siteFunctionWebAppsClientDiagnostics.CreateScope("SiteFunctionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteFunctionWebAppsRestClient.GetFunctionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteFunction>(null, response.GetRawResponse());
                return Response.FromValue(new SiteFunction(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="functionName"> Function name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionName"/> is null. </exception>
        public virtual Response<bool> Exists(string functionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionName, nameof(functionName));

            using var scope = _siteFunctionWebAppsClientDiagnostics.CreateScope("SiteFunctionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(functionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="functionName"> Function name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string functionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionName, nameof(functionName));

            using var scope = _siteFunctionWebAppsClientDiagnostics.CreateScope("SiteFunctionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(functionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/functions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_ListFunctions
        /// <summary> Description for List the functions for a web site, or a deployment slot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteFunction" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteFunction> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteFunction> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteFunctionWebAppsClientDiagnostics.CreateScope("SiteFunctionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteFunctionWebAppsRestClient.ListFunctions(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteFunction(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteFunction> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteFunctionWebAppsClientDiagnostics.CreateScope("SiteFunctionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteFunctionWebAppsRestClient.ListFunctionsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteFunction(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/functions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_ListFunctions
        /// <summary> Description for List the functions for a web site, or a deployment slot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteFunction" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteFunction> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteFunction>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteFunctionWebAppsClientDiagnostics.CreateScope("SiteFunctionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteFunctionWebAppsRestClient.ListFunctionsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteFunction(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteFunction>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteFunctionWebAppsClientDiagnostics.CreateScope("SiteFunctionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteFunctionWebAppsRestClient.ListFunctionsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteFunction(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<SiteFunction> IEnumerable<SiteFunction>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteFunction> IAsyncEnumerable<SiteFunction>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
