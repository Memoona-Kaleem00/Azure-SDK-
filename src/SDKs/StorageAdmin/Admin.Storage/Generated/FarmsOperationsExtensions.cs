// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.AzureStack.Storage.Admin
{
    using Microsoft.AzureStack;
    using Microsoft.AzureStack.Storage;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for FarmsOperations.
    /// </summary>
    public static partial class FarmsOperationsExtensions
    {
            /// <summary>
            /// Create a new farm
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='farmId'>
            /// Th name of the farm.
            /// </param>
            /// <param name='parameters'>
            /// Parameters used to create a farm
            /// </param>
            public static FarmModel Create(this IFarmsOperations operations, string resourceGroupName, string farmId, FarmCreateParameters parameters)
            {
                return operations.CreateAsync(resourceGroupName, farmId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a new farm
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='farmId'>
            /// Th name of the farm.
            /// </param>
            /// <param name='parameters'>
            /// Parameters used to create a farm
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FarmModel> CreateAsync(this IFarmsOperations operations, string resourceGroupName, string farmId, FarmCreateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, farmId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get an existing farm
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='farmId'>
            /// Th name of the farm.
            /// </param>
            public static FarmModel Get(this IFarmsOperations operations, string resourceGroupName, string farmId)
            {
                return operations.GetAsync(resourceGroupName, farmId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get an existing farm
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='farmId'>
            /// Th name of the farm.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FarmModel> GetAsync(this IFarmsOperations operations, string resourceGroupName, string farmId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, farmId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update an existing farm.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='farmId'>
            /// Th name of the farm.
            /// </param>
            /// <param name='parameters'>
            /// New values for farm
            /// </param>
            public static FarmModel Update(this IFarmsOperations operations, string resourceGroupName, string farmId, FarmUpdateParameters parameters)
            {
                return operations.UpdateAsync(resourceGroupName, farmId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update an existing farm.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='farmId'>
            /// Th name of the farm.
            /// </param>
            /// <param name='parameters'>
            /// New values for farm
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FarmModel> UpdateAsync(this IFarmsOperations operations, string resourceGroupName, string farmId, FarmUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, farmId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the list of metric definitions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='farmId'>
            /// Th name of the farm.
            /// </param>
            /// <param name='filter'>
            /// TODO
            /// </param>
            public static IList<MetricDefinition> ListMetricDefinitions(this IFarmsOperations operations, string resourceGroupName, string farmId, string filter)
            {
                return operations.ListMetricDefinitionsAsync(resourceGroupName, farmId, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the list of metric definitions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='farmId'>
            /// Th name of the farm.
            /// </param>
            /// <param name='filter'>
            /// TODO
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<MetricDefinition>> ListMetricDefinitionsAsync(this IFarmsOperations operations, string resourceGroupName, string farmId, string filter, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListMetricDefinitionsWithHttpMessagesAsync(resourceGroupName, farmId, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the list of metrics.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='farmId'>
            /// Th name of the farm.
            /// </param>
            /// <param name='filter'>
            /// TODO
            /// </param>
            public static Metrics ListMetrics(this IFarmsOperations operations, string resourceGroupName, string farmId, string filter)
            {
                return operations.ListMetricsAsync(resourceGroupName, farmId, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the list of metrics.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='farmId'>
            /// Th name of the farm.
            /// </param>
            /// <param name='filter'>
            /// TODO
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Metrics> ListMetricsAsync(this IFarmsOperations operations, string resourceGroupName, string farmId, string filter, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListMetricsWithHttpMessagesAsync(resourceGroupName, farmId, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a list of all farms.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            public static FarmModels List(this IFarmsOperations operations, string resourceGroupName)
            {
                return operations.ListAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of all farms.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FarmModels> ListAsync(this IFarmsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// TODO
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='farmId'>
            /// Th name of the farm.
            /// </param>
            public static string GarbageCollect(this IFarmsOperations operations, string resourceGroupName, string farmId)
            {
                return operations.GarbageCollectAsync(resourceGroupName, farmId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// TODO
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='farmId'>
            /// Th name of the farm.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> GarbageCollectAsync(this IFarmsOperations operations, string resourceGroupName, string farmId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GarbageCollectWithHttpMessagesAsync(resourceGroupName, farmId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// TODO
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='farmId'>
            /// Th name of the farm.
            /// </param>
            /// <param name='operationId'>
            /// </param>
            public static string GargbageCollectStatus(this IFarmsOperations operations, string resourceGroupName, string farmId, string operationId)
            {
                return operations.GargbageCollectStatusAsync(resourceGroupName, farmId, operationId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// TODO
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='farmId'>
            /// Th name of the farm.
            /// </param>
            /// <param name='operationId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> GargbageCollectStatusAsync(this IFarmsOperations operations, string resourceGroupName, string farmId, string operationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GargbageCollectStatusWithHttpMessagesAsync(resourceGroupName, farmId, operationId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
