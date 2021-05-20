// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Core
{
    /// <summary> The Providers service client. </summary>
    public partial class ProviderOperations : ResourceOperationsBase<TenantResourceIdentifier, Provider>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceOperationsBase"/> class.
        /// </summary>
        /// <param name="clientContext"></param>
        /// <param name="id"></param>
        internal ProviderOperations(ClientContext clientContext, TenantResourceIdentifier id)
            : base(clientContext, id)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericResourceOperations"/> class.
        /// </summary>
        /// <param name="operations"> The resource operations to copy the options from. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ProviderOperations(OperationsBase operations, TenantResourceIdentifier id)
            : base(operations, id)
        {
        }

        /// <inheritdoc/>
        //protected override ResourceType ValidResourceType => ProviderOperations.ResourceType;

        private ProviderRestOperations RestClient
        {
            get
            {
                string subscription;
                if (!Id.TryGetSubscriptionId(out subscription))
                {
                    subscription = Guid.Empty.ToString();
                }

                return new ProviderRestOperations(
                    new Azure.Core.Pipeline.ClientDiagnostics(ClientOptions),
                    ManagementPipelineBuilder.Build(Credential, BaseUri, ClientOptions),
                    subscription,
                    BaseUri);
            }
        }

        /// <summary> Unregisters a subscription from a resource provider. </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider to unregister. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ProviderData>> UnregisterAsync(string resourceProviderNamespace, CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("ProvidersOperations.Unregister");
            scope.Start();
            try
            {
                return await RestClient.UnregisterAsync(resourceProviderNamespace, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Unregisters a subscription from a resource provider. </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider to unregister. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ProviderData> Unregister(string resourceProviderNamespace, CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("ProvidersOperations.Unregister");
            scope.Start();
            try
            {
                return RestClient.Unregister(resourceProviderNamespace, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Registers a subscription with a resource provider. </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider to register. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ProviderData>> RegisterAsync(string resourceProviderNamespace, CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("ProvidersOperations.Register");
            scope.Start();
            try
            {
                return await RestClient.RegisterAsync(resourceProviderNamespace, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Registers a subscription with a resource provider. </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider to register. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ProviderData> Register(string resourceProviderNamespace, CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("ProvidersOperations.Register");
            scope.Start();
            try
            {
                return RestClient.Register(resourceProviderNamespace, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified resource provider. </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="expand"> The $expand query parameter. For example, to include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ProviderData>> GetAsync(string resourceProviderNamespace, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("ProvidersOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceProviderNamespace, expand, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc/>
        public override Response<Provider> Get(CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("ProviderOperations.Get");
            scope.Start();
            try
            {
                var apiVersion = GetApiVersion(cancellationToken);
                var result = RestClient.GetById(Id, apiVersion, cancellationToken);
                return Response.FromValue(new Provider(this, result), result.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified resource provider at the tenant level. </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="expand"> The $expand query parameter. For example, to include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ProviderData>> GetAtTenantScopeAsync(string resourceProviderNamespace, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("ProvidersOperations.GetAtTenantScope");
            scope.Start();
            try
            {
                return await RestClient.GetAtTenantScopeAsync(resourceProviderNamespace, expand, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified resource provider at the tenant level. </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="expand"> The $expand query parameter. For example, to include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ProviderData> GetAtTenantScope(string resourceProviderNamespace, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("ProvidersOperations.GetAtTenantScope");
            scope.Start();
            try
            {
                return RestClient.GetAtTenantScope(resourceProviderNamespace, expand, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all resource providers for a subscription. </summary>
        /// <param name="top"> The number of results to return. If null is passed returns all deployments. </param>
        /// <param name="expand"> The properties to include in the results. For example, use &amp;$expand=metadata in the query string to retrieve resource provider metadata. To include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<ProviderData> ListAsync(int? top = null, string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ProviderData>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = Diagnostics.CreateScope("ProvidersOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(top, expand, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ProviderData>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = Diagnostics.CreateScope("ProvidersOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, top, expand, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Gets all resource providers for a subscription. </summary>
        /// <param name="top"> The number of results to return. If null is passed returns all deployments. </param>
        /// <param name="expand"> The properties to include in the results. For example, use &amp;$expand=metadata in the query string to retrieve resource provider metadata. To include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<ProviderData> List(int? top = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Page<ProviderData> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = Diagnostics.CreateScope("ProvidersOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(top, expand, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ProviderData> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = Diagnostics.CreateScope("ProvidersOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, top, expand, cancellationToken);
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

        /// <summary> Gets all resource providers for the tenant. </summary>
        /// <param name="top"> The number of results to return. If null is passed returns all providers. </param>
        /// <param name="expand"> The properties to include in the results. For example, use &amp;$expand=metadata in the query string to retrieve resource provider metadata. To include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<ProviderData> ListAtTenantScopeAsync(int? top = null, string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ProviderData>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = Diagnostics.CreateScope("ProvidersOperations.ListAtTenantScope");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAtTenantScopeAsync(top, expand, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ProviderData>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = Diagnostics.CreateScope("ProvidersOperations.ListAtTenantScope");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAtTenantScopeNextPageAsync(nextLink, top, expand, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Gets all resource providers for the tenant. </summary>
        /// <param name="top"> The number of results to return. If null is passed returns all providers. </param>
        /// <param name="expand"> The properties to include in the results. For example, use &amp;$expand=metadata in the query string to retrieve resource provider metadata. To include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<ProviderData> ListAtTenantScope(int? top = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Page<ProviderData> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = Diagnostics.CreateScope("ProvidersOperations.ListAtTenantScope");
                scope.Start();
                try
                {
                    var response = RestClient.ListAtTenantScope(top, expand, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ProviderData> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = Diagnostics.CreateScope("ProvidersOperations.ListAtTenantScope");
                scope.Start();
                try
                {
                    var response = RestClient.ListAtTenantScopeNextPage(nextLink, top, expand, cancellationToken);
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
    }
}
