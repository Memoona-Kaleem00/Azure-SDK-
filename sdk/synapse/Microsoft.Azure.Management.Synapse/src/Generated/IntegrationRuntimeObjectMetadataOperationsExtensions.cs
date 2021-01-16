// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for IntegrationRuntimeObjectMetadataOperations.
    /// </summary>
    public static partial class IntegrationRuntimeObjectMetadataOperationsExtensions
    {
            /// <summary>
            /// Get integration runtime object metadata
            /// </summary>
            /// <remarks>
            /// Get object metadata from an integration runtime
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='integrationRuntimeName'>
            /// Integration runtime name
            /// </param>
            /// <param name='getMetadataRequest'>
            /// The parameters for getting a SSIS object metadata.
            /// </param>
            public static SsisObjectMetadataListResponse List(this IIntegrationRuntimeObjectMetadataOperations operations, string resourceGroupName, string workspaceName, string integrationRuntimeName, GetSsisObjectMetadataRequest getMetadataRequest = default(GetSsisObjectMetadataRequest))
            {
                return operations.ListAsync(resourceGroupName, workspaceName, integrationRuntimeName, getMetadataRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get integration runtime object metadata
            /// </summary>
            /// <remarks>
            /// Get object metadata from an integration runtime
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='integrationRuntimeName'>
            /// Integration runtime name
            /// </param>
            /// <param name='getMetadataRequest'>
            /// The parameters for getting a SSIS object metadata.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SsisObjectMetadataListResponse> ListAsync(this IIntegrationRuntimeObjectMetadataOperations operations, string resourceGroupName, string workspaceName, string integrationRuntimeName, GetSsisObjectMetadataRequest getMetadataRequest = default(GetSsisObjectMetadataRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, workspaceName, integrationRuntimeName, getMetadataRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Refresh integration runtime object metadata
            /// </summary>
            /// <remarks>
            /// Refresh the object metadata in an integration runtime
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='integrationRuntimeName'>
            /// Integration runtime name
            /// </param>
            public static SsisObjectMetadataStatusResponse Refresh(this IIntegrationRuntimeObjectMetadataOperations operations, string resourceGroupName, string workspaceName, string integrationRuntimeName)
            {
                return operations.RefreshAsync(resourceGroupName, workspaceName, integrationRuntimeName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Refresh integration runtime object metadata
            /// </summary>
            /// <remarks>
            /// Refresh the object metadata in an integration runtime
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='integrationRuntimeName'>
            /// Integration runtime name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SsisObjectMetadataStatusResponse> RefreshAsync(this IIntegrationRuntimeObjectMetadataOperations operations, string resourceGroupName, string workspaceName, string integrationRuntimeName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RefreshWithHttpMessagesAsync(resourceGroupName, workspaceName, integrationRuntimeName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Refresh integration runtime object metadata
            /// </summary>
            /// <remarks>
            /// Refresh the object metadata in an integration runtime
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='integrationRuntimeName'>
            /// Integration runtime name
            /// </param>
            public static SsisObjectMetadataStatusResponse BeginRefresh(this IIntegrationRuntimeObjectMetadataOperations operations, string resourceGroupName, string workspaceName, string integrationRuntimeName)
            {
                return operations.BeginRefreshAsync(resourceGroupName, workspaceName, integrationRuntimeName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Refresh integration runtime object metadata
            /// </summary>
            /// <remarks>
            /// Refresh the object metadata in an integration runtime
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='integrationRuntimeName'>
            /// Integration runtime name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SsisObjectMetadataStatusResponse> BeginRefreshAsync(this IIntegrationRuntimeObjectMetadataOperations operations, string resourceGroupName, string workspaceName, string integrationRuntimeName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginRefreshWithHttpMessagesAsync(resourceGroupName, workspaceName, integrationRuntimeName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
