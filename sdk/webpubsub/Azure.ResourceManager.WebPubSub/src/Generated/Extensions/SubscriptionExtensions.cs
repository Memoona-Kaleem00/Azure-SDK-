// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.WebPubSub.Models;

namespace Azure.ResourceManager.WebPubSub
{
    /// <summary> A class to add extension methods to Subscription. </summary>
    public static partial class SubscriptionExtensions
    {
        private static WebPubSubRestOperations GetWebPubSubRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ArmClientOptions clientOptions, Uri endpoint = null, string apiVersion = default)
        {
            return new WebPubSubRestOperations(clientDiagnostics, pipeline, clientOptions, endpoint, apiVersion);
        }

        private static UsagesRestOperations GetUsagesRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ArmClientOptions clientOptions, Uri endpoint = null, string apiVersion = default)
        {
            return new UsagesRestOperations(clientDiagnostics, pipeline, clientOptions, endpoint, apiVersion);
        }

        /// <summary> Checks that the resource name is valid and is not already in use. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="location"> the region. </param>
        /// <param name="parameters"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="parameters"/> is null. </exception>
        public static async Task<Response<NameAvailability>> CheckWebPubSubNameAvailabilityAsync(this Subscription subscription, string location, NameAvailabilityParameters parameters, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            return await subscription.UseClientContext(async (baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.CheckWebPubSubNameAvailability");
                scope.Start();
                try
                {
                    WebPubSubRestOperations restOperations = GetWebPubSubRestOperations(clientDiagnostics, pipeline, options, baseUri);
                    var response = await restOperations.CheckNameAvailabilityAsync(subscription.Id.SubscriptionId, location, parameters, cancellationToken).ConfigureAwait(false);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            ).ConfigureAwait(false);
        }

        /// <summary> Checks that the resource name is valid and is not already in use. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="location"> the region. </param>
        /// <param name="parameters"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="parameters"/> is null. </exception>
        public static Response<NameAvailability> CheckWebPubSubNameAvailability(this Subscription subscription, string location, NameAvailabilityParameters parameters, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.CheckWebPubSubNameAvailability");
                scope.Start();
                try
                {
                    WebPubSubRestOperations restOperations = GetWebPubSubRestOperations(clientDiagnostics, pipeline, options, baseUri);
                    var response = restOperations.CheckNameAvailability(subscription.Id.SubscriptionId, location, parameters, cancellationToken);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            );
        }

        /// <summary> Lists the WebPubSubs for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<WebPubSub> GetWebPubSubsAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                options.TryGetApiVersion(WebPubSub.ResourceType, out string apiVersion);
                WebPubSubRestOperations restOperations = GetWebPubSubRestOperations(clientDiagnostics, pipeline, options, baseUri, apiVersion);
                async Task<Page<WebPubSub>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetWebPubSubs");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListBySubscriptionAsync(subscription.Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new WebPubSub(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<WebPubSub>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetWebPubSubs");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListBySubscriptionNextPageAsync(nextLink, subscription.Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new WebPubSub(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }

        /// <summary> Lists the WebPubSubs for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<WebPubSub> GetWebPubSubs(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                options.TryGetApiVersion(WebPubSub.ResourceType, out string apiVersion);
                WebPubSubRestOperations restOperations = GetWebPubSubRestOperations(clientDiagnostics, pipeline, options, baseUri, apiVersion);
                Page<WebPubSub> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetWebPubSubs");
                    scope.Start();
                    try
                    {
                        var response = restOperations.ListBySubscription(subscription.Id.SubscriptionId, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new WebPubSub(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<WebPubSub> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetWebPubSubs");
                    scope.Start();
                    try
                    {
                        var response = restOperations.ListBySubscriptionNextPage(nextLink, subscription.Id.SubscriptionId, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new WebPubSub(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }

        /// <summary> Filters the list of WebPubSubs for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<GenericResource> GetWebPubSubsAsGenericResourcesAsync(this Subscription subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(WebPubSub.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.GetAtContextAsync(subscription, filters, expand, top, cancellationToken);
        }

        /// <summary> Filters the list of WebPubSubs for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<GenericResource> GetWebPubSubsAsGenericResources(this Subscription subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(WebPubSub.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.GetAtContext(subscription, filters, expand, top, cancellationToken);
        }

        /// <summary> Lists the SignalRServiceUsages for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="location"> the location like &quot;eastus&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<SignalRServiceUsage> GetUsagesAsync(this Subscription subscription, string location, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                UsagesRestOperations restOperations = GetUsagesRestOperations(clientDiagnostics, pipeline, options, baseUri);
                async Task<Page<SignalRServiceUsage>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetUsages");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListAsync(subscription.Id.SubscriptionId, location, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<SignalRServiceUsage>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetUsages");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListNextPageAsync(nextLink, subscription.Id.SubscriptionId, location, cancellationToken: cancellationToken).ConfigureAwait(false);
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
            );
        }

        /// <summary> Lists the SignalRServiceUsages for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="location"> the location like &quot;eastus&quot;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<SignalRServiceUsage> GetUsages(this Subscription subscription, string location, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                UsagesRestOperations restOperations = GetUsagesRestOperations(clientDiagnostics, pipeline, options, baseUri);
                Page<SignalRServiceUsage> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetUsages");
                    scope.Start();
                    try
                    {
                        var response = restOperations.List(subscription.Id.SubscriptionId, location, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<SignalRServiceUsage> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetUsages");
                    scope.Start();
                    try
                    {
                        var response = restOperations.ListNextPage(nextLink, subscription.Id.SubscriptionId, location, cancellationToken: cancellationToken);
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
            );
        }
    }
}
