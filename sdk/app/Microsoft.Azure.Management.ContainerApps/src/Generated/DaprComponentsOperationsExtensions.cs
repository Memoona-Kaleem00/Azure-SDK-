// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerApps
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DaprComponentsOperations.
    /// </summary>
    public static partial class DaprComponentsOperationsExtensions
    {
            /// <summary>
            /// Get the Dapr Components for a managed environment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='environmentName'>
            /// Name of the Managed Environment.
            /// </param>
            public static IPage<DaprComponent> List(this IDaprComponentsOperations operations, string resourceGroupName, string environmentName)
            {
                return operations.ListAsync(resourceGroupName, environmentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the Dapr Components for a managed environment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='environmentName'>
            /// Name of the Managed Environment.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DaprComponent>> ListAsync(this IDaprComponentsOperations operations, string resourceGroupName, string environmentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, environmentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a dapr component.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='environmentName'>
            /// Name of the Managed Environment.
            /// </param>
            /// <param name='componentName'>
            /// Name of the Dapr Component.
            /// </param>
            public static DaprComponent Get(this IDaprComponentsOperations operations, string resourceGroupName, string environmentName, string componentName)
            {
                return operations.GetAsync(resourceGroupName, environmentName, componentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a dapr component.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='environmentName'>
            /// Name of the Managed Environment.
            /// </param>
            /// <param name='componentName'>
            /// Name of the Dapr Component.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DaprComponent> GetAsync(this IDaprComponentsOperations operations, string resourceGroupName, string environmentName, string componentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, environmentName, componentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a Dapr Component.
            /// </summary>
            /// <remarks>
            /// Creates or updates a Dapr Component in a Managed Environment.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='environmentName'>
            /// Name of the Managed Environment.
            /// </param>
            /// <param name='componentName'>
            /// Name of the Dapr Component.
            /// </param>
            /// <param name='daprComponentEnvelope'>
            /// Configuration details of the Dapr Component.
            /// </param>
            public static DaprComponent CreateOrUpdate(this IDaprComponentsOperations operations, string resourceGroupName, string environmentName, string componentName, DaprComponent daprComponentEnvelope)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, environmentName, componentName, daprComponentEnvelope).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a Dapr Component.
            /// </summary>
            /// <remarks>
            /// Creates or updates a Dapr Component in a Managed Environment.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='environmentName'>
            /// Name of the Managed Environment.
            /// </param>
            /// <param name='componentName'>
            /// Name of the Dapr Component.
            /// </param>
            /// <param name='daprComponentEnvelope'>
            /// Configuration details of the Dapr Component.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DaprComponent> CreateOrUpdateAsync(this IDaprComponentsOperations operations, string resourceGroupName, string environmentName, string componentName, DaprComponent daprComponentEnvelope, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, environmentName, componentName, daprComponentEnvelope, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a Dapr Component.
            /// </summary>
            /// <remarks>
            /// Delete a Dapr Component from a Managed Environment.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='environmentName'>
            /// Name of the Managed Environment.
            /// </param>
            /// <param name='componentName'>
            /// Name of the Dapr Component.
            /// </param>
            public static void Delete(this IDaprComponentsOperations operations, string resourceGroupName, string environmentName, string componentName)
            {
                operations.DeleteAsync(resourceGroupName, environmentName, componentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a Dapr Component.
            /// </summary>
            /// <remarks>
            /// Delete a Dapr Component from a Managed Environment.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='environmentName'>
            /// Name of the Managed Environment.
            /// </param>
            /// <param name='componentName'>
            /// Name of the Dapr Component.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IDaprComponentsOperations operations, string resourceGroupName, string environmentName, string componentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, environmentName, componentName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List secrets for a dapr component
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='environmentName'>
            /// Name of the Managed Environment.
            /// </param>
            /// <param name='componentName'>
            /// Name of the Dapr Component.
            /// </param>
            public static DaprSecretsCollection ListSecrets(this IDaprComponentsOperations operations, string resourceGroupName, string environmentName, string componentName)
            {
                return operations.ListSecretsAsync(resourceGroupName, environmentName, componentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List secrets for a dapr component
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='environmentName'>
            /// Name of the Managed Environment.
            /// </param>
            /// <param name='componentName'>
            /// Name of the Dapr Component.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DaprSecretsCollection> ListSecretsAsync(this IDaprComponentsOperations operations, string resourceGroupName, string environmentName, string componentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListSecretsWithHttpMessagesAsync(resourceGroupName, environmentName, componentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the Dapr Components for a managed environment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DaprComponent> ListNext(this IDaprComponentsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the Dapr Components for a managed environment.
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
            public static async Task<IPage<DaprComponent>> ListNextAsync(this IDaprComponentsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
