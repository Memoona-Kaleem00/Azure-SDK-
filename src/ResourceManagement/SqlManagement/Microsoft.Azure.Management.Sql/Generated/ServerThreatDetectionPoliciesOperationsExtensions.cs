// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ServerThreatDetectionPoliciesOperations.
    /// </summary>
    public static partial class ServerThreatDetectionPoliciesOperationsExtensions
    {
            /// <summary>
            /// Get the active server Threat Detection operation result.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='operationId'>
            /// The server Threat Detection operation id to retrieve.
            /// </param>
            public static SecurityAlertOperationResult GetOperationResult(this IServerThreatDetectionPoliciesOperations operations, string resourceGroupName, string serverName, string operationId)
            {
                return operations.GetOperationResultAsync(resourceGroupName, serverName, operationId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the active server Threat Detection operation result.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='operationId'>
            /// The server Threat Detection operation id to retrieve.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SecurityAlertOperationResult> GetOperationResultAsync(this IServerThreatDetectionPoliciesOperations operations, string resourceGroupName, string serverName, string operationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetOperationResultWithHttpMessagesAsync(resourceGroupName, serverName, operationId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a list of server Threat Detection operation results.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            public static SecurityAlertOperationListResult ListOperationResults(this IServerThreatDetectionPoliciesOperations operations, string resourceGroupName, string serverName)
            {
                return operations.ListOperationResultsAsync(resourceGroupName, serverName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of server Threat Detection operation results.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SecurityAlertOperationListResult> ListOperationResultsAsync(this IServerThreatDetectionPoliciesOperations operations, string resourceGroupName, string serverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListOperationResultsWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a Threat Detection policy associated with a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            public static ServerSecurityAlertPolicy Get(this IServerThreatDetectionPoliciesOperations operations, string resourceGroupName, string serverName)
            {
                return operations.GetAsync(resourceGroupName, serverName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a Threat Detection policy associated with a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServerSecurityAlertPolicy> GetAsync(this IServerThreatDetectionPoliciesOperations operations, string resourceGroupName, string serverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a Threat Detection policy for a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='serverSecurityAlertPolicy'>
            /// The name of the server security alert policy.
            /// </param>
            public static ServerSecurityAlertPolicy CreateOrUpdate(this IServerThreatDetectionPoliciesOperations operations, string resourceGroupName, string serverName, ServerSecurityAlertPolicy serverSecurityAlertPolicy)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serverName, serverSecurityAlertPolicy).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a Threat Detection policy for a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='serverSecurityAlertPolicy'>
            /// The name of the server security alert policy.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServerSecurityAlertPolicy> CreateOrUpdateAsync(this IServerThreatDetectionPoliciesOperations operations, string resourceGroupName, string serverName, ServerSecurityAlertPolicy serverSecurityAlertPolicy, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, serverSecurityAlertPolicy, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a Threat Detection policy for a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='serverSecurityAlertPolicy'>
            /// The name of the server security alert policy.
            /// </param>
            public static ServerSecurityAlertPolicy BeginCreateOrUpdate(this IServerThreatDetectionPoliciesOperations operations, string resourceGroupName, string serverName, ServerSecurityAlertPolicy serverSecurityAlertPolicy)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, serverName, serverSecurityAlertPolicy).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a Threat Detection policy for a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='serverSecurityAlertPolicy'>
            /// The name of the server security alert policy.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServerSecurityAlertPolicy> BeginCreateOrUpdateAsync(this IServerThreatDetectionPoliciesOperations operations, string resourceGroupName, string serverName, ServerSecurityAlertPolicy serverSecurityAlertPolicy, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, serverSecurityAlertPolicy, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
