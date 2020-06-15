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
    /// Extension methods for SubscriptionOperations.
    /// </summary>
    public static partial class SubscriptionOperationsExtensions
    {
            /// <summary>
            /// Creates an Azure subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='enrollmentAccountName'>
            /// The name of the enrollment account to which the subscription will be
            /// billed.
            /// </param>
            /// <param name='body'>
            /// The subscription creation parameters.
            /// </param>
            public static SubscriptionCreationResult CreateSubscriptionInEnrollmentAccount(this ISubscriptionOperations operations, string enrollmentAccountName, SubscriptionCreationParameters body)
            {
                return operations.CreateSubscriptionInEnrollmentAccountAsync(enrollmentAccountName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates an Azure subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='enrollmentAccountName'>
            /// The name of the enrollment account to which the subscription will be
            /// billed.
            /// </param>
            /// <param name='body'>
            /// The subscription creation parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SubscriptionCreationResult> CreateSubscriptionInEnrollmentAccountAsync(this ISubscriptionOperations operations, string enrollmentAccountName, SubscriptionCreationParameters body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateSubscriptionInEnrollmentAccountWithHttpMessagesAsync(enrollmentAccountName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to cancel a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Subscription Id.
            /// </param>
            public static CanceledSubscriptionId Cancel(this ISubscriptionOperations operations, string subscriptionId)
            {
                return operations.CancelAsync(subscriptionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to cancel a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Subscription Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CanceledSubscriptionId> CancelAsync(this ISubscriptionOperations operations, string subscriptionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CancelWithHttpMessagesAsync(subscriptionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to rename a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Subscription Id.
            /// </param>
            /// <param name='body'>
            /// Subscription Name
            /// </param>
            public static RenamedSubscriptionId Rename(this ISubscriptionOperations operations, string subscriptionId, SubscriptionName body)
            {
                return operations.RenameAsync(subscriptionId, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to rename a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Subscription Id.
            /// </param>
            /// <param name='body'>
            /// Subscription Name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RenamedSubscriptionId> RenameAsync(this ISubscriptionOperations operations, string subscriptionId, SubscriptionName body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RenameWithHttpMessagesAsync(subscriptionId, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to enable a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Subscription Id.
            /// </param>
            public static EnabledSubscriptionId Enable(this ISubscriptionOperations operations, string subscriptionId)
            {
                return operations.EnableAsync(subscriptionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to enable a subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Subscription Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EnabledSubscriptionId> EnableAsync(this ISubscriptionOperations operations, string subscriptionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.EnableWithHttpMessagesAsync(subscriptionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to create a new WebDirect or EA Azure subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The name of the Microsoft Customer Agreement billing account for which you
            /// want to create the subscription.
            /// </param>
            /// <param name='billingProfileName'>
            /// The name of the billing profile in the billing account for which you want
            /// to create the subscription.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// The name of the invoice section in the billing account for which you want
            /// to create the subscription.
            /// </param>
            /// <param name='body'>
            /// The subscription creation parameters.
            /// </param>
            public static SubscriptionCreationResult CreateSubscription(this ISubscriptionOperations operations, string billingAccountName, string billingProfileName, string invoiceSectionName, ModernSubscriptionCreationParameters body)
            {
                return operations.CreateSubscriptionAsync(billingAccountName, billingProfileName, invoiceSectionName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to create a new WebDirect or EA Azure subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The name of the Microsoft Customer Agreement billing account for which you
            /// want to create the subscription.
            /// </param>
            /// <param name='billingProfileName'>
            /// The name of the billing profile in the billing account for which you want
            /// to create the subscription.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// The name of the invoice section in the billing account for which you want
            /// to create the subscription.
            /// </param>
            /// <param name='body'>
            /// The subscription creation parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SubscriptionCreationResult> CreateSubscriptionAsync(this ISubscriptionOperations operations, string billingAccountName, string billingProfileName, string invoiceSectionName, ModernSubscriptionCreationParameters body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateSubscriptionWithHttpMessagesAsync(billingAccountName, billingProfileName, invoiceSectionName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to create a new CSP subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The name of the Microsoft Customer Agreement billing account for which you
            /// want to create the subscription.
            /// </param>
            /// <param name='customerName'>
            /// The name of the customer.
            /// </param>
            /// <param name='body'>
            /// The subscription creation parameters.
            /// </param>
            public static SubscriptionCreationResult CreateCspSubscription(this ISubscriptionOperations operations, string billingAccountName, string customerName, ModernCspSubscriptionCreationParameters body)
            {
                return operations.CreateCspSubscriptionAsync(billingAccountName, customerName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to create a new CSP subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The name of the Microsoft Customer Agreement billing account for which you
            /// want to create the subscription.
            /// </param>
            /// <param name='customerName'>
            /// The name of the customer.
            /// </param>
            /// <param name='body'>
            /// The subscription creation parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SubscriptionCreationResult> CreateCspSubscriptionAsync(this ISubscriptionOperations operations, string billingAccountName, string customerName, ModernCspSubscriptionCreationParameters body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateCspSubscriptionWithHttpMessagesAsync(billingAccountName, customerName, body, null, cancellationToken).ConfigureAwait(false))
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
            /// <param name='enrollmentAccountName'>
            /// The name of the enrollment account to which the subscription will be
            /// billed.
            /// </param>
            /// <param name='body'>
            /// The subscription creation parameters.
            /// </param>
            public static SubscriptionCreationResult BeginCreateSubscriptionInEnrollmentAccount(this ISubscriptionOperations operations, string enrollmentAccountName, SubscriptionCreationParameters body)
            {
                return operations.BeginCreateSubscriptionInEnrollmentAccountAsync(enrollmentAccountName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates an Azure subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='enrollmentAccountName'>
            /// The name of the enrollment account to which the subscription will be
            /// billed.
            /// </param>
            /// <param name='body'>
            /// The subscription creation parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SubscriptionCreationResult> BeginCreateSubscriptionInEnrollmentAccountAsync(this ISubscriptionOperations operations, string enrollmentAccountName, SubscriptionCreationParameters body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateSubscriptionInEnrollmentAccountWithHttpMessagesAsync(enrollmentAccountName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to create a new WebDirect or EA Azure subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The name of the Microsoft Customer Agreement billing account for which you
            /// want to create the subscription.
            /// </param>
            /// <param name='billingProfileName'>
            /// The name of the billing profile in the billing account for which you want
            /// to create the subscription.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// The name of the invoice section in the billing account for which you want
            /// to create the subscription.
            /// </param>
            /// <param name='body'>
            /// The subscription creation parameters.
            /// </param>
            public static SubscriptionCreationResult BeginCreateSubscription(this ISubscriptionOperations operations, string billingAccountName, string billingProfileName, string invoiceSectionName, ModernSubscriptionCreationParameters body)
            {
                return operations.BeginCreateSubscriptionAsync(billingAccountName, billingProfileName, invoiceSectionName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to create a new WebDirect or EA Azure subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The name of the Microsoft Customer Agreement billing account for which you
            /// want to create the subscription.
            /// </param>
            /// <param name='billingProfileName'>
            /// The name of the billing profile in the billing account for which you want
            /// to create the subscription.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// The name of the invoice section in the billing account for which you want
            /// to create the subscription.
            /// </param>
            /// <param name='body'>
            /// The subscription creation parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SubscriptionCreationResult> BeginCreateSubscriptionAsync(this ISubscriptionOperations operations, string billingAccountName, string billingProfileName, string invoiceSectionName, ModernSubscriptionCreationParameters body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateSubscriptionWithHttpMessagesAsync(billingAccountName, billingProfileName, invoiceSectionName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to create a new CSP subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The name of the Microsoft Customer Agreement billing account for which you
            /// want to create the subscription.
            /// </param>
            /// <param name='customerName'>
            /// The name of the customer.
            /// </param>
            /// <param name='body'>
            /// The subscription creation parameters.
            /// </param>
            public static SubscriptionCreationResult BeginCreateCspSubscription(this ISubscriptionOperations operations, string billingAccountName, string customerName, ModernCspSubscriptionCreationParameters body)
            {
                return operations.BeginCreateCspSubscriptionAsync(billingAccountName, customerName, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to create a new CSP subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// The name of the Microsoft Customer Agreement billing account for which you
            /// want to create the subscription.
            /// </param>
            /// <param name='customerName'>
            /// The name of the customer.
            /// </param>
            /// <param name='body'>
            /// The subscription creation parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SubscriptionCreationResult> BeginCreateCspSubscriptionAsync(this ISubscriptionOperations operations, string billingAccountName, string customerName, ModernCspSubscriptionCreationParameters body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateCspSubscriptionWithHttpMessagesAsync(billingAccountName, customerName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
