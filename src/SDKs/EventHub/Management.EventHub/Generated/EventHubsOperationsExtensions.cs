// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.EventHub
{
    using Azure;
    using Management;
    using Rest;
    using Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for EventHubsOperations.
    /// </summary>
    public static partial class EventHubsOperationsExtensions
    {
            /// <summary>
            /// Gets all the Event Hubs in a Namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            public static IPage<Eventhub> ListByNamespace(this IEventHubsOperations operations, string resourceGroupName, string namespaceName)
            {
                return operations.ListByNamespaceAsync(resourceGroupName, namespaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the Event Hubs in a Namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Eventhub>> ListByNamespaceAsync(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByNamespaceWithHttpMessagesAsync(resourceGroupName, namespaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a new Event Hub as a nested resource within a Namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create an Event Hub resource.
            /// </param>
            public static Eventhub CreateOrUpdate(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, Eventhub parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, namespaceName, eventHubName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a new Event Hub as a nested resource within a Namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create an Event Hub resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Eventhub> CreateOrUpdateAsync(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, Eventhub parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, namespaceName, eventHubName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an Event Hub from the specified Namespace and resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            public static void Delete(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName)
            {
                operations.DeleteAsync(resourceGroupName, namespaceName, eventHubName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an Event Hub from the specified Namespace and resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, namespaceName, eventHubName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets an Event Hubs description for the specified Event Hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            public static Eventhub Get(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName)
            {
                return operations.GetAsync(resourceGroupName, namespaceName, eventHubName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an Event Hubs description for the specified Event Hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Eventhub> GetAsync(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, namespaceName, eventHubName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the authorization rules for an Event Hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            public static IPage<AuthorizationRule> ListAuthorizationRules(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName)
            {
                return operations.ListAuthorizationRulesAsync(resourceGroupName, namespaceName, eventHubName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the authorization rules for an Event Hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<AuthorizationRule>> ListAuthorizationRulesAsync(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAuthorizationRulesWithHttpMessagesAsync(resourceGroupName, namespaceName, eventHubName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates an AuthorizationRule for the specified Event Hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            /// <param name='parameters'>
            /// The shared access AuthorizationRule.
            /// </param>
            public static AuthorizationRule CreateOrUpdateAuthorizationRule(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, string authorizationRuleName, AuthorizationRule parameters)
            {
                return operations.CreateOrUpdateAuthorizationRuleAsync(resourceGroupName, namespaceName, eventHubName, authorizationRuleName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an AuthorizationRule for the specified Event Hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            /// <param name='parameters'>
            /// The shared access AuthorizationRule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AuthorizationRule> CreateOrUpdateAuthorizationRuleAsync(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, string authorizationRuleName, AuthorizationRule parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, eventHubName, authorizationRuleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets an AuthorizationRule for an Event Hub by rule name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            public static AuthorizationRule GetAuthorizationRule(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, string authorizationRuleName)
            {
                return operations.GetAuthorizationRuleAsync(resourceGroupName, namespaceName, eventHubName, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an AuthorizationRule for an Event Hub by rule name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AuthorizationRule> GetAuthorizationRuleAsync(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, eventHubName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an Event Hub AuthorizationRule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            public static void DeleteAuthorizationRule(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, string authorizationRuleName)
            {
                operations.DeleteAuthorizationRuleAsync(resourceGroupName, namespaceName, eventHubName, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an Event Hub AuthorizationRule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAuthorizationRuleAsync(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, eventHubName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets the ACS and SAS connection strings for the Event Hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            public static AccessKeys ListKeys(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, string authorizationRuleName)
            {
                return operations.ListKeysAsync(resourceGroupName, namespaceName, eventHubName, authorizationRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the ACS and SAS connection strings for the Event Hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccessKeys> ListKeysAsync(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, string authorizationRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeysWithHttpMessagesAsync(resourceGroupName, namespaceName, eventHubName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Regenerates the ACS and SAS connection strings for the Event Hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to regenerate the AuthorizationRule Keys
            /// (PrimaryKey/SecondaryKey).
            /// </param>
            public static AccessKeys RegenerateKeys(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, string authorizationRuleName, RegenerateAccessKeyParameters parameters)
            {
                return operations.RegenerateKeysAsync(resourceGroupName, namespaceName, eventHubName, authorizationRuleName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerates the ACS and SAS connection strings for the Event Hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The Namespace name
            /// </param>
            /// <param name='eventHubName'>
            /// The Event Hub name
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The authorization rule name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to regenerate the AuthorizationRule Keys
            /// (PrimaryKey/SecondaryKey).
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccessKeys> RegenerateKeysAsync(this IEventHubsOperations operations, string resourceGroupName, string namespaceName, string eventHubName, string authorizationRuleName, RegenerateAccessKeyParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegenerateKeysWithHttpMessagesAsync(resourceGroupName, namespaceName, eventHubName, authorizationRuleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the Event Hubs in a Namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Eventhub> ListByNamespaceNext(this IEventHubsOperations operations, string nextPageLink)
            {
                return operations.ListByNamespaceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the Event Hubs in a Namespace.
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
            public static async Task<IPage<Eventhub>> ListByNamespaceNextAsync(this IEventHubsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByNamespaceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the authorization rules for an Event Hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<AuthorizationRule> ListAuthorizationRulesNext(this IEventHubsOperations operations, string nextPageLink)
            {
                return operations.ListAuthorizationRulesNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the authorization rules for an Event Hub.
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
            public static async Task<IPage<AuthorizationRule>> ListAuthorizationRulesNextAsync(this IEventHubsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAuthorizationRulesNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

