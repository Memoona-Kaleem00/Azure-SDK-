// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.GuestConfiguration
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for GuestConfigurationAssignmentsOperations.
    /// </summary>
    public static partial class GuestConfigurationAssignmentsOperationsExtensions
    {
            /// <summary>
            /// Creates an association between a VM and guest configuration
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='guestConfigurationAssignmentName'>
            /// Name of the guest configuration assignment.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update guest configuration assignment.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            public static GuestConfigurationAssignment CreateOrUpdate(this IGuestConfigurationAssignmentsOperations operations, string guestConfigurationAssignmentName, GuestConfigurationAssignment parameters, string resourceGroupName, string vmName)
            {
                return operations.CreateOrUpdateAsync(guestConfigurationAssignmentName, parameters, resourceGroupName, vmName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates an association between a VM and guest configuration
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='guestConfigurationAssignmentName'>
            /// Name of the guest configuration assignment.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update guest configuration assignment.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GuestConfigurationAssignment> CreateOrUpdateAsync(this IGuestConfigurationAssignmentsOperations operations, string guestConfigurationAssignmentName, GuestConfigurationAssignment parameters, string resourceGroupName, string vmName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(guestConfigurationAssignmentName, parameters, resourceGroupName, vmName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get information about a guest configuration assignment
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='guestConfigurationAssignmentName'>
            /// The guest configuration assignment name.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            public static GuestConfigurationAssignment Get(this IGuestConfigurationAssignmentsOperations operations, string resourceGroupName, string guestConfigurationAssignmentName, string vmName)
            {
                return operations.GetAsync(resourceGroupName, guestConfigurationAssignmentName, vmName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get information about a guest configuration assignment
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='guestConfigurationAssignmentName'>
            /// The guest configuration assignment name.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GuestConfigurationAssignment> GetAsync(this IGuestConfigurationAssignmentsOperations operations, string resourceGroupName, string guestConfigurationAssignmentName, string vmName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, guestConfigurationAssignmentName, vmName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a guest configuration assignment
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='guestConfigurationAssignmentName'>
            /// Name of the guest configuration assignment
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            public static void Delete(this IGuestConfigurationAssignmentsOperations operations, string resourceGroupName, string guestConfigurationAssignmentName, string vmName)
            {
                operations.DeleteAsync(resourceGroupName, guestConfigurationAssignmentName, vmName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a guest configuration assignment
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='guestConfigurationAssignmentName'>
            /// Name of the guest configuration assignment
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IGuestConfigurationAssignmentsOperations operations, string resourceGroupName, string guestConfigurationAssignmentName, string vmName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, guestConfigurationAssignmentName, vmName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List all guest configuration assignments for a virtual machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            public static IEnumerable<GuestConfigurationAssignment> List(this IGuestConfigurationAssignmentsOperations operations, string resourceGroupName, string vmName)
            {
                return operations.ListAsync(resourceGroupName, vmName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all guest configuration assignments for a virtual machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<GuestConfigurationAssignment>> ListAsync(this IGuestConfigurationAssignmentsOperations operations, string resourceGroupName, string vmName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, vmName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates an association between a VM and guest configuration
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='guestConfigurationAssignmentName'>
            /// Name of the guest configuration assignment.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update guest configuration assignment.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            public static GuestConfigurationAssignment BeginCreateOrUpdate(this IGuestConfigurationAssignmentsOperations operations, string guestConfigurationAssignmentName, GuestConfigurationAssignment parameters, string resourceGroupName, string vmName)
            {
                return operations.BeginCreateOrUpdateAsync(guestConfigurationAssignmentName, parameters, resourceGroupName, vmName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates an association between a VM and guest configuration
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='guestConfigurationAssignmentName'>
            /// Name of the guest configuration assignment.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update guest configuration assignment.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GuestConfigurationAssignment> BeginCreateOrUpdateAsync(this IGuestConfigurationAssignmentsOperations operations, string guestConfigurationAssignmentName, GuestConfigurationAssignment parameters, string resourceGroupName, string vmName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(guestConfigurationAssignmentName, parameters, resourceGroupName, vmName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a guest configuration assignment
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='guestConfigurationAssignmentName'>
            /// Name of the guest configuration assignment
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            public static void BeginDelete(this IGuestConfigurationAssignmentsOperations operations, string resourceGroupName, string guestConfigurationAssignmentName, string vmName)
            {
                operations.BeginDeleteAsync(resourceGroupName, guestConfigurationAssignmentName, vmName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a guest configuration assignment
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='guestConfigurationAssignmentName'>
            /// Name of the guest configuration assignment
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IGuestConfigurationAssignmentsOperations operations, string resourceGroupName, string guestConfigurationAssignmentName, string vmName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, guestConfigurationAssignmentName, vmName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
