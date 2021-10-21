// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ActionGroupsOperations.
    /// </summary>
    public static partial class ActionGroupsOperationsExtensions
    {
            /// <summary>
            /// Create a new action group or update an existing one.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='actionGroupName'>
            /// The name of the action group.
            /// </param>
            /// <param name='actionGroup'>
            /// The action group to create or use for the update.
            /// </param>
            public static ActionGroupResource CreateOrUpdate(this IActionGroupsOperations operations, string resourceGroupName, string actionGroupName, ActionGroupResource actionGroup)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, actionGroupName, actionGroup).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a new action group or update an existing one.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='actionGroupName'>
            /// The name of the action group.
            /// </param>
            /// <param name='actionGroup'>
            /// The action group to create or use for the update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ActionGroupResource> CreateOrUpdateAsync(this IActionGroupsOperations operations, string resourceGroupName, string actionGroupName, ActionGroupResource actionGroup, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, actionGroupName, actionGroup, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get an action group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='actionGroupName'>
            /// The name of the action group.
            /// </param>
            public static ActionGroupResource Get(this IActionGroupsOperations operations, string resourceGroupName, string actionGroupName)
            {
                return operations.GetAsync(resourceGroupName, actionGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get an action group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='actionGroupName'>
            /// The name of the action group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ActionGroupResource> GetAsync(this IActionGroupsOperations operations, string resourceGroupName, string actionGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, actionGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete an action group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='actionGroupName'>
            /// The name of the action group.
            /// </param>
            public static void Delete(this IActionGroupsOperations operations, string resourceGroupName, string actionGroupName)
            {
                operations.DeleteAsync(resourceGroupName, actionGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete an action group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='actionGroupName'>
            /// The name of the action group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IActionGroupsOperations operations, string resourceGroupName, string actionGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, actionGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates an existing action group's tags. To update other fields use the
            /// CreateOrUpdate method.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='actionGroupName'>
            /// The name of the action group.
            /// </param>
            /// <param name='actionGroupPatch'>
            /// Parameters supplied to the operation.
            /// </param>
            public static ActionGroupResource Update(this IActionGroupsOperations operations, string resourceGroupName, string actionGroupName, ActionGroupPatchBody actionGroupPatch)
            {
                return operations.UpdateAsync(resourceGroupName, actionGroupName, actionGroupPatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an existing action group's tags. To update other fields use the
            /// CreateOrUpdate method.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='actionGroupName'>
            /// The name of the action group.
            /// </param>
            /// <param name='actionGroupPatch'>
            /// Parameters supplied to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ActionGroupResource> UpdateAsync(this IActionGroupsOperations operations, string resourceGroupName, string actionGroupName, ActionGroupPatchBody actionGroupPatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, actionGroupName, actionGroupPatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Send test notifications to a set of provided receivers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='notificationRequest'>
            /// The notification request body which includes the contact details
            /// </param>
            public static TestNotificationResponse PostTestNotifications(this IActionGroupsOperations operations, NotificationRequestBody notificationRequest)
            {
                return operations.PostTestNotificationsAsync(notificationRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Send test notifications to a set of provided receivers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='notificationRequest'>
            /// The notification request body which includes the contact details
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TestNotificationResponse> PostTestNotificationsAsync(this IActionGroupsOperations operations, NotificationRequestBody notificationRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostTestNotificationsWithHttpMessagesAsync(notificationRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the test notifications by the notification id
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='notificationId'>
            /// The notification id
            /// </param>
            public static TestNotificationDetailsResponse GetTestNotifications(this IActionGroupsOperations operations, string notificationId)
            {
                return operations.GetTestNotificationsAsync(notificationId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the test notifications by the notification id
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='notificationId'>
            /// The notification id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TestNotificationDetailsResponse> GetTestNotificationsAsync(this IActionGroupsOperations operations, string notificationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetTestNotificationsWithHttpMessagesAsync(notificationId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a list of all action groups in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IEnumerable<ActionGroupResource> ListBySubscriptionId(this IActionGroupsOperations operations)
            {
                return operations.ListBySubscriptionIdAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of all action groups in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<ActionGroupResource>> ListBySubscriptionIdAsync(this IActionGroupsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionIdWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a list of all action groups in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            public static IEnumerable<ActionGroupResource> ListByResourceGroup(this IActionGroupsOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of all action groups in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<ActionGroupResource>> ListByResourceGroupAsync(this IActionGroupsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Enable a receiver in an action group. This changes the receiver's status
            /// from Disabled to Enabled. This operation is only supported for Email or SMS
            /// receivers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='actionGroupName'>
            /// The name of the action group.
            /// </param>
            /// <param name='enableRequest'>
            /// The receiver to re-enable.
            /// </param>
            public static void EnableReceiver(this IActionGroupsOperations operations, string resourceGroupName, string actionGroupName, EnableRequest enableRequest)
            {
                operations.EnableReceiverAsync(resourceGroupName, actionGroupName, enableRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Enable a receiver in an action group. This changes the receiver's status
            /// from Disabled to Enabled. This operation is only supported for Email or SMS
            /// receivers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='actionGroupName'>
            /// The name of the action group.
            /// </param>
            /// <param name='enableRequest'>
            /// The receiver to re-enable.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task EnableReceiverAsync(this IActionGroupsOperations operations, string resourceGroupName, string actionGroupName, EnableRequest enableRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.EnableReceiverWithHttpMessagesAsync(resourceGroupName, actionGroupName, enableRequest, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Send test notifications to a set of provided receivers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='notificationRequest'>
            /// The notification request body which includes the contact details
            /// </param>
            public static TestNotificationResponse BeginPostTestNotifications(this IActionGroupsOperations operations, NotificationRequestBody notificationRequest)
            {
                return operations.BeginPostTestNotificationsAsync(notificationRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Send test notifications to a set of provided receivers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='notificationRequest'>
            /// The notification request body which includes the contact details
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TestNotificationResponse> BeginPostTestNotificationsAsync(this IActionGroupsOperations operations, NotificationRequestBody notificationRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginPostTestNotificationsWithHttpMessagesAsync(notificationRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
