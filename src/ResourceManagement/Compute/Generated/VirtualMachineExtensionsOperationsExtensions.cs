// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Compute;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for VirtualMachineExtensionsOperations.
    /// </summary>
    public static partial class VirtualMachineExtensionsOperationsExtensions
    {
            
            /// <summary>
            /// The operation to create or update the extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the extension should be create or
            /// updated.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='extensionParameters'>
            /// Parameters supplied to the Create Virtual Machine Extension operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualMachineExtensionInner> CreateOrUpdateAsync(this IVirtualMachineExtensionsOperations operations, string resourceGroupName, string vmName, string vmExtensionName, VirtualMachineExtensionInner extensionParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, vmName, vmExtensionName, extensionParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            
            /// <summary>
            /// The operation to delete the extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the extension should be deleted.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationStatusResponseInner> DeleteAsync(this IVirtualMachineExtensionsOperations operations, string resourceGroupName, string vmName, string vmExtensionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, vmName, vmExtensionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            
            /// <summary>
            /// The operation to get the extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine containing the extension.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='expand'>
            /// The expand expression to apply on the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualMachineExtensionInner> GetAsync(this IVirtualMachineExtensionsOperations operations, string resourceGroupName, string vmName, string vmExtensionName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, vmName, vmExtensionName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            
            /// <summary>
            /// The operation to create or update the extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the extension should be create or
            /// updated.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='extensionParameters'>
            /// Parameters supplied to the Create Virtual Machine Extension operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualMachineExtensionInner> BeginCreateOrUpdateAsync(this IVirtualMachineExtensionsOperations operations, string resourceGroupName, string vmName, string vmExtensionName, VirtualMachineExtensionInner extensionParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, vmName, vmExtensionName, extensionParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            
            /// <summary>
            /// The operation to delete the extension.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine where the extension should be deleted.
            /// </param>
            /// <param name='vmExtensionName'>
            /// The name of the virtual machine extension.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationStatusResponseInner> BeginDeleteAsync(this IVirtualMachineExtensionsOperations operations, string resourceGroupName, string vmName, string vmExtensionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, vmName, vmExtensionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
