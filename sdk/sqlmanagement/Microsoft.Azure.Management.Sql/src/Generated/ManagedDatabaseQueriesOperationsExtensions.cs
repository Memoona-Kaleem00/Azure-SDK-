// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ManagedDatabaseQueriesOperations.
    /// </summary>
    public static partial class ManagedDatabaseQueriesOperationsExtensions
    {
            /// <summary>
            /// Get query by query id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='queryId'>
            /// </param>
            public static ManagedInstanceQuery Get(this IManagedDatabaseQueriesOperations operations, string resourceGroupName, string managedInstanceName, string databaseName, string queryId)
            {
                return operations.GetAsync(resourceGroupName, managedInstanceName, databaseName, queryId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get query by query id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='queryId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedInstanceQuery> GetAsync(this IManagedDatabaseQueriesOperations operations, string resourceGroupName, string managedInstanceName, string databaseName, string queryId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, managedInstanceName, databaseName, queryId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get query execution statistics by query id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='queryId'>
            /// </param>
            /// <param name='startTime'>
            /// Start time for observed period.
            /// </param>
            /// <param name='endTime'>
            /// End time for observed period.
            /// </param>
            /// <param name='interval'>
            /// The time step to be used to summarize the metric values. Possible values
            /// include: 'PT1H', 'P1D'
            /// </param>
            public static IPage<QueryStatistics> ListByQuery(this IManagedDatabaseQueriesOperations operations, string resourceGroupName, string managedInstanceName, string databaseName, string queryId, string startTime = default(string), string endTime = default(string), QueryTimeGrainType? interval = default(QueryTimeGrainType?))
            {
                return operations.ListByQueryAsync(resourceGroupName, managedInstanceName, databaseName, queryId, startTime, endTime, interval).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get query execution statistics by query id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='managedInstanceName'>
            /// The name of the managed instance.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='queryId'>
            /// </param>
            /// <param name='startTime'>
            /// Start time for observed period.
            /// </param>
            /// <param name='endTime'>
            /// End time for observed period.
            /// </param>
            /// <param name='interval'>
            /// The time step to be used to summarize the metric values. Possible values
            /// include: 'PT1H', 'P1D'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<QueryStatistics>> ListByQueryAsync(this IManagedDatabaseQueriesOperations operations, string resourceGroupName, string managedInstanceName, string databaseName, string queryId, string startTime = default(string), string endTime = default(string), QueryTimeGrainType? interval = default(QueryTimeGrainType?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByQueryWithHttpMessagesAsync(resourceGroupName, managedInstanceName, databaseName, queryId, startTime, endTime, interval, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get query execution statistics by query id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<QueryStatistics> ListByQueryNext(this IManagedDatabaseQueriesOperations operations, string nextPageLink)
            {
                return operations.ListByQueryNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get query execution statistics by query id.
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
            public static async Task<IPage<QueryStatistics>> ListByQueryNextAsync(this IManagedDatabaseQueriesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByQueryNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
