// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServerManagement
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for SessionOperations.
    /// </summary>
    public static partial class SessionOperationsExtensions
    {
            /// <summary>
            /// Creates a session for a node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='nodeName'>
            /// The node name (256 characters maximum).
            /// </param>
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            /// <param name='userName'>
            /// User name to be used to connect to node
            /// </param>
            /// <param name='password'>
            /// Password associated with user name
            /// </param>
            public static SessionResource Create(this ISessionOperations operations, string resourceGroupName, string nodeName, string session, string userName = default(string), string password = default(string))
            {
                return Task.Factory.StartNew(s => ((ISessionOperations)s).CreateAsync(resourceGroupName, nodeName, session, userName, password), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a session for a node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='nodeName'>
            /// The node name (256 characters maximum).
            /// </param>
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            /// <param name='userName'>
            /// User name to be used to connect to node
            /// </param>
            /// <param name='password'>
            /// Password associated with user name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SessionResource> CreateAsync(this ISessionOperations operations, string resourceGroupName, string nodeName, string session, string userName = default(string), string password = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, nodeName, session, userName, password, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a session for a node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='nodeName'>
            /// The node name (256 characters maximum).
            /// </param>
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            /// <param name='userName'>
            /// User name to be used to connect to node
            /// </param>
            /// <param name='password'>
            /// Password associated with user name
            /// </param>
            public static SessionResource BeginCreate(this ISessionOperations operations, string resourceGroupName, string nodeName, string session, string userName = default(string), string password = default(string))
            {
                return Task.Factory.StartNew(s => ((ISessionOperations)s).BeginCreateAsync(resourceGroupName, nodeName, session, userName, password), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a session for a node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='nodeName'>
            /// The node name (256 characters maximum).
            /// </param>
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            /// <param name='userName'>
            /// User name to be used to connect to node
            /// </param>
            /// <param name='password'>
            /// Password associated with user name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SessionResource> BeginCreateAsync(this ISessionOperations operations, string resourceGroupName, string nodeName, string session, string userName = default(string), string password = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, nodeName, session, userName, password, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a session for a node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='nodeName'>
            /// The node name (256 characters maximum).
            /// </param>
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            public static void Delete(this ISessionOperations operations, string resourceGroupName, string nodeName, string session)
            {
                Task.Factory.StartNew(s => ((ISessionOperations)s).DeleteAsync(resourceGroupName, nodeName, session), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a session for a node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='nodeName'>
            /// The node name (256 characters maximum).
            /// </param>
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ISessionOperations operations, string resourceGroupName, string nodeName, string session, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, nodeName, session, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets a session for a node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='nodeName'>
            /// The node name (256 characters maximum).
            /// </param>
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            public static SessionResource Get(this ISessionOperations operations, string resourceGroupName, string nodeName, string session)
            {
                return Task.Factory.StartNew(s => ((ISessionOperations)s).GetAsync(resourceGroupName, nodeName, session), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a session for a node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='nodeName'>
            /// The node name (256 characters maximum).
            /// </param>
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SessionResource> GetAsync(this ISessionOperations operations, string resourceGroupName, string nodeName, string session, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, nodeName, session, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
