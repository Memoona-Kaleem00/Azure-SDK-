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
    /// Extension methods for SqlPoolWorkloadClassifierOperations.
    /// </summary>
    public static partial class SqlPoolWorkloadClassifierOperationsExtensions
    {
            /// <summary>
            /// Get workload classifier
            /// </summary>
            /// <remarks>
            /// Get a workload classifier of Sql pool's workload group.
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
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='workloadGroupName'>
            /// The name of the workload group.
            /// </param>
            /// <param name='workloadClassifierName'>
            /// The name of the workload classifier.
            /// </param>
            public static WorkloadClassifier Get(this ISqlPoolWorkloadClassifierOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string workloadGroupName, string workloadClassifierName)
            {
                return operations.GetAsync(resourceGroupName, workspaceName, sqlPoolName, workloadGroupName, workloadClassifierName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get workload classifier
            /// </summary>
            /// <remarks>
            /// Get a workload classifier of Sql pool's workload group.
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
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='workloadGroupName'>
            /// The name of the workload group.
            /// </param>
            /// <param name='workloadClassifierName'>
            /// The name of the workload classifier.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkloadClassifier> GetAsync(this ISqlPoolWorkloadClassifierOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string workloadGroupName, string workloadClassifierName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, workloadGroupName, workloadClassifierName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create Or Update workload classifier
            /// </summary>
            /// <remarks>
            /// Create Or Update workload classifier for a Sql pool's workload group.
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
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='workloadGroupName'>
            /// The name of the workload group.
            /// </param>
            /// <param name='workloadClassifierName'>
            /// The name of the workload classifier.
            /// </param>
            /// <param name='parameters'>
            /// The properties of the workload classifier.
            /// </param>
            public static WorkloadClassifier CreateOrUpdate(this ISqlPoolWorkloadClassifierOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string workloadGroupName, string workloadClassifierName, WorkloadClassifier parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, workspaceName, sqlPoolName, workloadGroupName, workloadClassifierName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create Or Update workload classifier
            /// </summary>
            /// <remarks>
            /// Create Or Update workload classifier for a Sql pool's workload group.
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
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='workloadGroupName'>
            /// The name of the workload group.
            /// </param>
            /// <param name='workloadClassifierName'>
            /// The name of the workload classifier.
            /// </param>
            /// <param name='parameters'>
            /// The properties of the workload classifier.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkloadClassifier> CreateOrUpdateAsync(this ISqlPoolWorkloadClassifierOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string workloadGroupName, string workloadClassifierName, WorkloadClassifier parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, workloadGroupName, workloadClassifierName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Remove workload classifier
            /// </summary>
            /// <remarks>
            /// Remove workload classifier of a Sql pool's workload group.
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
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='workloadGroupName'>
            /// The name of the workload group.
            /// </param>
            /// <param name='workloadClassifierName'>
            /// The name of the workload classifier.
            /// </param>
            public static void Delete(this ISqlPoolWorkloadClassifierOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string workloadGroupName, string workloadClassifierName)
            {
                operations.DeleteAsync(resourceGroupName, workspaceName, sqlPoolName, workloadGroupName, workloadClassifierName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Remove workload classifier
            /// </summary>
            /// <remarks>
            /// Remove workload classifier of a Sql pool's workload group.
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
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='workloadGroupName'>
            /// The name of the workload group.
            /// </param>
            /// <param name='workloadClassifierName'>
            /// The name of the workload classifier.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ISqlPoolWorkloadClassifierOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string workloadGroupName, string workloadClassifierName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, workloadGroupName, workloadClassifierName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Sql pool's workload classifier
            /// </summary>
            /// <remarks>
            /// Get list of  Sql pool's workload classifier for workload groups.
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
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='workloadGroupName'>
            /// The name of the workload group.
            /// </param>
            public static IPage<WorkloadClassifier> List(this ISqlPoolWorkloadClassifierOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string workloadGroupName)
            {
                return operations.ListAsync(resourceGroupName, workspaceName, sqlPoolName, workloadGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sql pool's workload classifier
            /// </summary>
            /// <remarks>
            /// Get list of  Sql pool's workload classifier for workload groups.
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
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='workloadGroupName'>
            /// The name of the workload group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<WorkloadClassifier>> ListAsync(this ISqlPoolWorkloadClassifierOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string workloadGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, workloadGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create Or Update workload classifier
            /// </summary>
            /// <remarks>
            /// Create Or Update workload classifier for a Sql pool's workload group.
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
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='workloadGroupName'>
            /// The name of the workload group.
            /// </param>
            /// <param name='workloadClassifierName'>
            /// The name of the workload classifier.
            /// </param>
            /// <param name='parameters'>
            /// The properties of the workload classifier.
            /// </param>
            public static WorkloadClassifier BeginCreateOrUpdate(this ISqlPoolWorkloadClassifierOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string workloadGroupName, string workloadClassifierName, WorkloadClassifier parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, workspaceName, sqlPoolName, workloadGroupName, workloadClassifierName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create Or Update workload classifier
            /// </summary>
            /// <remarks>
            /// Create Or Update workload classifier for a Sql pool's workload group.
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
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='workloadGroupName'>
            /// The name of the workload group.
            /// </param>
            /// <param name='workloadClassifierName'>
            /// The name of the workload classifier.
            /// </param>
            /// <param name='parameters'>
            /// The properties of the workload classifier.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkloadClassifier> BeginCreateOrUpdateAsync(this ISqlPoolWorkloadClassifierOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string workloadGroupName, string workloadClassifierName, WorkloadClassifier parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, workloadGroupName, workloadClassifierName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Remove workload classifier
            /// </summary>
            /// <remarks>
            /// Remove workload classifier of a Sql pool's workload group.
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
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='workloadGroupName'>
            /// The name of the workload group.
            /// </param>
            /// <param name='workloadClassifierName'>
            /// The name of the workload classifier.
            /// </param>
            public static void BeginDelete(this ISqlPoolWorkloadClassifierOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string workloadGroupName, string workloadClassifierName)
            {
                operations.BeginDeleteAsync(resourceGroupName, workspaceName, sqlPoolName, workloadGroupName, workloadClassifierName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Remove workload classifier
            /// </summary>
            /// <remarks>
            /// Remove workload classifier of a Sql pool's workload group.
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
            /// <param name='sqlPoolName'>
            /// SQL pool name
            /// </param>
            /// <param name='workloadGroupName'>
            /// The name of the workload group.
            /// </param>
            /// <param name='workloadClassifierName'>
            /// The name of the workload classifier.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this ISqlPoolWorkloadClassifierOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string workloadGroupName, string workloadClassifierName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, workloadGroupName, workloadClassifierName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Sql pool's workload classifier
            /// </summary>
            /// <remarks>
            /// Get list of  Sql pool's workload classifier for workload groups.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<WorkloadClassifier> ListNext(this ISqlPoolWorkloadClassifierOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sql pool's workload classifier
            /// </summary>
            /// <remarks>
            /// Get list of  Sql pool's workload classifier for workload groups.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<WorkloadClassifier>> ListNextAsync(this ISqlPoolWorkloadClassifierOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
