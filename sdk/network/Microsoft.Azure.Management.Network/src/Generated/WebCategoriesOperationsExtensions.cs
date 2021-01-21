// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for WebCategoriesOperations.
    /// </summary>
    public static partial class WebCategoriesOperationsExtensions
    {
            /// <summary>
            /// Gets the specified Azure Web Category.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// The name of the azureWebCategory.
            /// </param>
            /// <param name='expand'>
            /// Expands resourceIds back referenced by the azureWebCategory resource.
            /// </param>
            public static AzureWebCategory Get(this IWebCategoriesOperations operations, string name, string expand = default(string))
            {
                return operations.GetAsync(name, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified Azure Web Category.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// The name of the azureWebCategory.
            /// </param>
            /// <param name='expand'>
            /// Expands resourceIds back referenced by the azureWebCategory resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AzureWebCategory> GetAsync(this IWebCategoriesOperations operations, string name, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(name, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the Azure Web Categories in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<AzureWebCategory> ListBySubscription(this IWebCategoriesOperations operations)
            {
                return operations.ListBySubscriptionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the Azure Web Categories in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<AzureWebCategory>> ListBySubscriptionAsync(this IWebCategoriesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the Azure Web Categories in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<AzureWebCategory> ListBySubscriptionNext(this IWebCategoriesOperations operations, string nextPageLink)
            {
                return operations.ListBySubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the Azure Web Categories in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<AzureWebCategory>> ListBySubscriptionNextAsync(this IWebCategoriesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
