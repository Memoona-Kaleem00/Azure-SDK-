// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ResourceManager;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DeploymentsOperations.
    /// </summary>
    public static partial class DeploymentsOperationsExtensions
    {
            /// <summary>
            /// Delete deployment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment to be deleted.
            /// </param>
            public static void Delete(this IDeploymentsOperations operations, string resourceGroupName, string deploymentName)
            {
                operations.DeleteAsync(resourceGroupName, deploymentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete deployment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IDeploymentsOperations operations, string resourceGroupName, string deploymentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, deploymentName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Checks whether deployment exists.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to check. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment.
            /// </param>
            public static bool CheckExistence(this IDeploymentsOperations operations, string resourceGroupName, string deploymentName)
            {
                return operations.CheckExistenceAsync(resourceGroupName, deploymentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks whether deployment exists.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to check. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<bool> CheckExistenceAsync(this IDeploymentsOperations operations, string resourceGroupName, string deploymentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckExistenceWithHttpMessagesAsync(resourceGroupName, deploymentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a named template deployment using a template.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment.
            /// </param>
            /// <param name='parameters'>
            /// Additional parameters supplied to the operation.
            /// </param>
            public static DeploymentExtendedInner CreateOrUpdate(this IDeploymentsOperations operations, string resourceGroupName, string deploymentName, DeploymentInner parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, deploymentName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a named template deployment using a template.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment.
            /// </param>
            /// <param name='parameters'>
            /// Additional parameters supplied to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeploymentExtendedInner> CreateOrUpdateAsync(this IDeploymentsOperations operations, string resourceGroupName, string deploymentName, DeploymentInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, deploymentName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a deployment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to get. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment.
            /// </param>
            public static DeploymentExtendedInner Get(this IDeploymentsOperations operations, string resourceGroupName, string deploymentName)
            {
                return operations.GetAsync(resourceGroupName, deploymentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a deployment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to get. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeploymentExtendedInner> GetAsync(this IDeploymentsOperations operations, string resourceGroupName, string deploymentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, deploymentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Cancel a currently running template deployment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment.
            /// </param>
            public static void Cancel(this IDeploymentsOperations operations, string resourceGroupName, string deploymentName)
            {
                operations.CancelAsync(resourceGroupName, deploymentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Cancel a currently running template deployment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CancelAsync(this IDeploymentsOperations operations, string resourceGroupName, string deploymentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.CancelWithHttpMessagesAsync(resourceGroupName, deploymentName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Validate a deployment template.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment.
            /// </param>
            /// <param name='parameters'>
            /// Deployment to validate.
            /// </param>
            public static DeploymentValidateResultInner Validate(this IDeploymentsOperations operations, string resourceGroupName, string deploymentName, DeploymentInner parameters)
            {
                return operations.ValidateAsync(resourceGroupName, deploymentName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Validate a deployment template.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment.
            /// </param>
            /// <param name='parameters'>
            /// Deployment to validate.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeploymentValidateResultInner> ValidateAsync(this IDeploymentsOperations operations, string resourceGroupName, string deploymentName, DeploymentInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ValidateWithHttpMessagesAsync(resourceGroupName, deploymentName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Exports a deployment template.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment.
            /// </param>
            public static DeploymentExportResultInner ExportTemplate(this IDeploymentsOperations operations, string resourceGroupName, string deploymentName)
            {
                return operations.ExportTemplateAsync(resourceGroupName, deploymentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Exports a deployment template.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeploymentExportResultInner> ExportTemplateAsync(this IDeploymentsOperations operations, string resourceGroupName, string deploymentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ExportTemplateWithHttpMessagesAsync(resourceGroupName, deploymentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a list of deployments.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to filter by. The name is case insensitive.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<DeploymentExtendedInner> List(this IDeploymentsOperations operations, string resourceGroupName, ODataQuery<DeploymentExtendedFilterInner> odataQuery = default(ODataQuery<DeploymentExtendedFilterInner>))
            {
                return ((IDeploymentsOperations)operations).ListAsync(resourceGroupName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of deployments.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to filter by. The name is case insensitive.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DeploymentExtendedInner>> ListAsync(this IDeploymentsOperations operations, string resourceGroupName, ODataQuery<DeploymentExtendedFilterInner> odataQuery = default(ODataQuery<DeploymentExtendedFilterInner>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete deployment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment to be deleted.
            /// </param>
            public static void BeginDelete(this IDeploymentsOperations operations, string resourceGroupName, string deploymentName)
            {
                operations.BeginDeleteAsync(resourceGroupName, deploymentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete deployment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IDeploymentsOperations operations, string resourceGroupName, string deploymentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, deploymentName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Create a named template deployment using a template.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment.
            /// </param>
            /// <param name='parameters'>
            /// Additional parameters supplied to the operation.
            /// </param>
            public static DeploymentExtendedInner BeginCreateOrUpdate(this IDeploymentsOperations operations, string resourceGroupName, string deploymentName, DeploymentInner parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, deploymentName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a named template deployment using a template.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='deploymentName'>
            /// The name of the deployment.
            /// </param>
            /// <param name='parameters'>
            /// Additional parameters supplied to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeploymentExtendedInner> BeginCreateOrUpdateAsync(this IDeploymentsOperations operations, string resourceGroupName, string deploymentName, DeploymentInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, deploymentName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a list of deployments.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DeploymentExtendedInner> ListNext(this IDeploymentsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of deployments.
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
            public static async Task<IPage<DeploymentExtendedInner>> ListNextAsync(this IDeploymentsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
