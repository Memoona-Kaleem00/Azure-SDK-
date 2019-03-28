// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Blueprint
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AssignmentsOperations.
    /// </summary>
    public static partial class AssignmentsOperationsExtensions
    {
            /// <summary>
            /// Create or update a Blueprint assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the resource. Valid scopes are: management group (format:
            /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'),
            /// subscription (format: '/subscriptions/{subscriptionId}').
            /// </param>
            /// <param name='assignmentName'>
            /// name of the assignment.
            /// </param>
            /// <param name='assignment'>
            /// assignment object to save.
            /// </param>
            public static Assignment CreateOrUpdate(this IAssignmentsOperations operations, string scope, string assignmentName, Assignment assignment)
            {
                return operations.CreateOrUpdateAsync(scope, assignmentName, assignment).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a Blueprint assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the resource. Valid scopes are: management group (format:
            /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'),
            /// subscription (format: '/subscriptions/{subscriptionId}').
            /// </param>
            /// <param name='assignmentName'>
            /// name of the assignment.
            /// </param>
            /// <param name='assignment'>
            /// assignment object to save.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Assignment> CreateOrUpdateAsync(this IAssignmentsOperations operations, string scope, string assignmentName, Assignment assignment, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(scope, assignmentName, assignment, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a Blueprint assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the resource. Valid scopes are: management group (format:
            /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'),
            /// subscription (format: '/subscriptions/{subscriptionId}').
            /// </param>
            /// <param name='assignmentName'>
            /// name of the assignment.
            /// </param>
            public static Assignment Get(this IAssignmentsOperations operations, string scope, string assignmentName)
            {
                return operations.GetAsync(scope, assignmentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a Blueprint assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the resource. Valid scopes are: management group (format:
            /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'),
            /// subscription (format: '/subscriptions/{subscriptionId}').
            /// </param>
            /// <param name='assignmentName'>
            /// name of the assignment.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Assignment> GetAsync(this IAssignmentsOperations operations, string scope, string assignmentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(scope, assignmentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a Blueprint assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the resource. Valid scopes are: management group (format:
            /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'),
            /// subscription (format: '/subscriptions/{subscriptionId}').
            /// </param>
            /// <param name='assignmentName'>
            /// name of the assignment.
            /// </param>
            public static Assignment Delete(this IAssignmentsOperations operations, string scope, string assignmentName)
            {
                return operations.DeleteAsync(scope, assignmentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a Blueprint assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the resource. Valid scopes are: management group (format:
            /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'),
            /// subscription (format: '/subscriptions/{subscriptionId}').
            /// </param>
            /// <param name='assignmentName'>
            /// name of the assignment.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Assignment> DeleteAsync(this IAssignmentsOperations operations, string scope, string assignmentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(scope, assignmentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List Blueprint assignments within a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the resource. Valid scopes are: management group (format:
            /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'),
            /// subscription (format: '/subscriptions/{subscriptionId}').
            /// </param>
            public static IPage<Assignment> List(this IAssignmentsOperations operations, string scope)
            {
                return operations.ListAsync(scope).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List Blueprint assignments within a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the resource. Valid scopes are: management group (format:
            /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'),
            /// subscription (format: '/subscriptions/{subscriptionId}').
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Assignment>> ListAsync(this IAssignmentsOperations operations, string scope, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(scope, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List Blueprint assignments within a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Assignment> ListNext(this IAssignmentsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List Blueprint assignments within a subscription.
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
            public static async Task<IPage<Assignment>> ListNextAsync(this IAssignmentsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
