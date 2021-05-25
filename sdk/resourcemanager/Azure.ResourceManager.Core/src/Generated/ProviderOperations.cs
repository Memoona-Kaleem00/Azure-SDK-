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
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary>
        /// Gets the resource type definition for a ResourceType.
        /// </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Resources/providers";

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

        /// <inheritdoc/>
        public override Response<Provider> Get(CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("ProviderOperations.Get");
            scope.Start();
            string subscriptionId = "";

            try
            {
                if (Id.TryGetSubscriptionId(out subscriptionId))
                {
                    var originalResponse = RestClient.Get(Id.Name, null, cancellationToken); //set expand to null?
                    return Response.FromValue(new Provider(this, originalResponse), originalResponse.GetRawResponse());
                }
                else
                {
                    var result = RestClient.GetAtTenantScope(Id.Name, null, cancellationToken);
                    return Response.FromValue(new Provider(this, result), result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc/>
        public override async Task<Response<Provider>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = Diagnostics.CreateScope("ProvidersOperations.Get");
            scope.Start();
            string subscriptionId = "";

            try
            {
                if (Id.TryGetSubscriptionId(out subscriptionId))
                {
                    var result = await RestClient.GetAsync(Id.Name, null, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new Provider(this, result), result.GetRawResponse());
                }
                else
                {
                    var result = await RestClient.GetAtTenantScopeAsync(Id.Name, null, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new Provider(this, result), result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
