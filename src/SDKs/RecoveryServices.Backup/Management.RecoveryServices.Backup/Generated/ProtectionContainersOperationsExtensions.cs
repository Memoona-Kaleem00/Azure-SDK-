// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ProtectionContainersOperations.
    /// </summary>
    public static partial class ProtectionContainersOperationsExtensions
    {
            /// <summary>
            /// Gets details of the specific container registered to your Recovery Services
            /// Vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='fabricName'>
            /// Name of the fabric where the container belongs.
            /// </param>
            /// <param name='containerName'>
            /// Name of the container whose details need to be fetched.
            /// </param>
            public static ProtectionContainerResource Get(this IProtectionContainersOperations operations, string vaultName, string resourceGroupName, string fabricName, string containerName)
            {
                return operations.GetAsync(vaultName, resourceGroupName, fabricName, containerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets details of the specific container registered to your Recovery Services
            /// Vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='fabricName'>
            /// Name of the fabric where the container belongs.
            /// </param>
            /// <param name='containerName'>
            /// Name of the container whose details need to be fetched.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProtectionContainerResource> GetAsync(this IProtectionContainersOperations operations, string vaultName, string resourceGroupName, string fabricName, string containerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(vaultName, resourceGroupName, fabricName, containerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Registers the container with Recovery Services vault.
            /// This is an asynchronous operation. To track the operation status, use
            /// location header to call get latest status of the operation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name associated with the container.
            /// </param>
            /// <param name='containerName'>
            /// Name of the container to be registered.
            /// </param>
            /// <param name='parameters'>
            /// Request body for operation
            /// </param>
            public static ProtectionContainerResource Register(this IProtectionContainersOperations operations, string vaultName, string resourceGroupName, string fabricName, string containerName, ProtectionContainerResource parameters)
            {
                return operations.RegisterAsync(vaultName, resourceGroupName, fabricName, containerName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Registers the container with Recovery Services vault.
            /// This is an asynchronous operation. To track the operation status, use
            /// location header to call get latest status of the operation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name associated with the container.
            /// </param>
            /// <param name='containerName'>
            /// Name of the container to be registered.
            /// </param>
            /// <param name='parameters'>
            /// Request body for operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProtectionContainerResource> RegisterAsync(this IProtectionContainersOperations operations, string vaultName, string resourceGroupName, string fabricName, string containerName, ProtectionContainerResource parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegisterWithHttpMessagesAsync(vaultName, resourceGroupName, fabricName, containerName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Unregisters the given container from your Recovery Services Vault.
            /// This is an asynchronous operation. To determine whether the backend service
            /// has finished processing the request, call Get Container Operation Result
            /// API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='fabricName'>
            /// Name of the fabric where the container belongs.
            /// </param>
            /// <param name='containerName'>
            /// Name of the container which needs to be unregistered from the Recovery
            /// Services Vault.
            /// </param>
            public static void Unregister(this IProtectionContainersOperations operations, string vaultName, string resourceGroupName, string fabricName, string containerName)
            {
                operations.UnregisterAsync(vaultName, resourceGroupName, fabricName, containerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Unregisters the given container from your Recovery Services Vault.
            /// This is an asynchronous operation. To determine whether the backend service
            /// has finished processing the request, call Get Container Operation Result
            /// API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='fabricName'>
            /// Name of the fabric where the container belongs.
            /// </param>
            /// <param name='containerName'>
            /// Name of the container which needs to be unregistered from the Recovery
            /// Services Vault.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UnregisterAsync(this IProtectionContainersOperations operations, string vaultName, string resourceGroupName, string fabricName, string containerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UnregisterWithHttpMessagesAsync(vaultName, resourceGroupName, fabricName, containerName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Inquires all the protectable item in the given container that can be
            /// protected.
            /// </summary>
            /// <remarks>
            /// Inquires all the protectable items that are protectable under the given
            /// container.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric Name associated with the container.
            /// </param>
            /// <param name='containerName'>
            /// Name of the container in which inquiry needs to be triggered.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static void Inquire(this IProtectionContainersOperations operations, string vaultName, string resourceGroupName, string fabricName, string containerName, ODataQuery<BMSContainersInquiryQueryObject> odataQuery = default(ODataQuery<BMSContainersInquiryQueryObject>))
            {
                operations.InquireAsync(vaultName, resourceGroupName, fabricName, containerName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Inquires all the protectable item in the given container that can be
            /// protected.
            /// </summary>
            /// <remarks>
            /// Inquires all the protectable items that are protectable under the given
            /// container.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric Name associated with the container.
            /// </param>
            /// <param name='containerName'>
            /// Name of the container in which inquiry needs to be triggered.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task InquireAsync(this IProtectionContainersOperations operations, string vaultName, string resourceGroupName, string fabricName, string containerName, ODataQuery<BMSContainersInquiryQueryObject> odataQuery = default(ODataQuery<BMSContainersInquiryQueryObject>), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.InquireWithHttpMessagesAsync(vaultName, resourceGroupName, fabricName, containerName, odataQuery, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Discovers all the containers in the subscription that can be backed up to
            /// Recovery Services Vault. This is an asynchronous operation. To know the
            /// status of the operation, call GetRefreshOperationResult API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name associated the container.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static void Refresh(this IProtectionContainersOperations operations, string vaultName, string resourceGroupName, string fabricName, ODataQuery<BMSRefreshContainersQueryObject> odataQuery = default(ODataQuery<BMSRefreshContainersQueryObject>))
            {
                operations.RefreshAsync(vaultName, resourceGroupName, fabricName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Discovers all the containers in the subscription that can be backed up to
            /// Recovery Services Vault. This is an asynchronous operation. To know the
            /// status of the operation, call GetRefreshOperationResult API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name associated the container.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RefreshAsync(this IProtectionContainersOperations operations, string vaultName, string resourceGroupName, string fabricName, ODataQuery<BMSRefreshContainersQueryObject> odataQuery = default(ODataQuery<BMSRefreshContainersQueryObject>), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RefreshWithHttpMessagesAsync(vaultName, resourceGroupName, fabricName, odataQuery, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
