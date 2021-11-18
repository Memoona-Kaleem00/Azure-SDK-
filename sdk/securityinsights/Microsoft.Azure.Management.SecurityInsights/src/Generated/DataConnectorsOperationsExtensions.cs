// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DataConnectorsOperations.
    /// </summary>
    public static partial class DataConnectorsOperationsExtensions
    {
            /// <summary>
            /// Gets all data connectors.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            public static IPage<DataConnector> List(this IDataConnectorsOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName)
            {
                return operations.ListAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all data connectors.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DataConnector>> ListAsync(this IDataConnectorsOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a data connector.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='dataConnectorId'>
            /// Connector ID
            /// </param>
            public static DataConnector Get(this IDataConnectorsOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string dataConnectorId)
            {
                return operations.GetAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, dataConnectorId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a data connector.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='dataConnectorId'>
            /// Connector ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DataConnector> GetAsync(this IDataConnectorsOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string dataConnectorId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, dataConnectorId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates the data connector.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='dataConnectorId'>
            /// Connector ID
            /// </param>
            /// <param name='dataConnector'>
            /// The data connector
            /// </param>
            public static DataConnector CreateOrUpdate(this IDataConnectorsOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string dataConnectorId, DataConnector dataConnector)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, dataConnectorId, dataConnector).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the data connector.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='dataConnectorId'>
            /// Connector ID
            /// </param>
            /// <param name='dataConnector'>
            /// The data connector
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DataConnector> CreateOrUpdateAsync(this IDataConnectorsOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string dataConnectorId, DataConnector dataConnector, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, dataConnectorId, dataConnector, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete the data connector.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='dataConnectorId'>
            /// Connector ID
            /// </param>
            public static void Delete(this IDataConnectorsOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string dataConnectorId)
            {
                operations.DeleteAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, dataConnectorId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete the data connector.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='dataConnectorId'>
            /// Connector ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IDataConnectorsOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string dataConnectorId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, dataConnectorId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets all data connectors.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DataConnector> ListNext(this IDataConnectorsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all data connectors.
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
            public static async Task<IPage<DataConnector>> ListNextAsync(this IDataConnectorsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
