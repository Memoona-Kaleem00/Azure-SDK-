// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Subscription
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SubscriptionFactoryOperations.
    /// </summary>
    public static partial class SubscriptionFactoryOperationsExtensions
    {
            /// <summary>
            /// Creates an Azure subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The name of the commerce root billing account.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// The name of the invoice section.
            /// </param>
            /// <param name='body'>
            /// The subscription creation parameters.
            /// </param>
            public static SubscriptionCreationResult CreateSubscription(this ISubscriptionFactoryOperations operations, string billingAccountName, string invoiceSectionName, SubscriptionCreationParameters body)
            {
                return operations.CreateSubscriptionAsync(billingAccountName, invoiceSectionName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates an Azure subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The name of the commerce root billing account.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// The name of the invoice section.
            /// </param>
            /// <param name='body'>
            /// The subscription creation parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SubscriptionCreationResult> CreateSubscriptionAsync(this ISubscriptionFactoryOperations operations, string billingAccountName, string invoiceSectionName, SubscriptionCreationParameters body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateSubscriptionWithHttpMessagesAsync(billingAccountName, invoiceSectionName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates an Azure subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The name of the commerce root billing account.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// The name of the invoice section.
            /// </param>
            /// <param name='body'>
            /// The subscription creation parameters.
            /// </param>
            public static SubscriptionCreationResult BeginCreateSubscription(this ISubscriptionFactoryOperations operations, string billingAccountName, string invoiceSectionName, SubscriptionCreationParameters body)
            {
                return operations.BeginCreateSubscriptionAsync(billingAccountName, invoiceSectionName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates an Azure subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The name of the commerce root billing account.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// The name of the invoice section.
            /// </param>
            /// <param name='body'>
            /// The subscription creation parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SubscriptionCreationResult> BeginCreateSubscriptionAsync(this ISubscriptionFactoryOperations operations, string billingAccountName, string invoiceSectionName, SubscriptionCreationParameters body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateSubscriptionWithHttpMessagesAsync(billingAccountName, invoiceSectionName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
