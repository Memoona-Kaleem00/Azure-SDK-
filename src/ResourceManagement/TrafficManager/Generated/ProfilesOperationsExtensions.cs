// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.TrafficManager.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.TrafficManager;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ProfilesOperations.
    /// </summary>
    public static partial class ProfilesOperationsExtensions
    {
            /// <summary>
            /// Checks the availability of a Traffic Manager Relative DNS name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// The name of the resource.
            /// </param>
            /// <param name='type'>
            /// The type of the resource.
            /// </param>
            public static TrafficManagerNameAvailabilityInner CheckTrafficManagerRelativeDnsNameAvailability(this IProfilesOperations operations, string name = default(string), string type = default(string))
            {
                return operations.CheckTrafficManagerRelativeDnsNameAvailabilityAsync(name, type).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks the availability of a Traffic Manager Relative DNS name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// The name of the resource.
            /// </param>
            /// <param name='type'>
            /// The type of the resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TrafficManagerNameAvailabilityInner> CheckTrafficManagerRelativeDnsNameAvailabilityAsync(this IProfilesOperations operations, string name = default(string), string type = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckTrafficManagerRelativeDnsNameAvailabilityWithHttpMessagesAsync(name, type, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all Traffic Manager profiles within a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager profiles to
            /// be listed.
            /// </param>
            public static IEnumerable<ProfileInner> ListByResourceGroup(this IProfilesOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all Traffic Manager profiles within a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager profiles to
            /// be listed.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<ProfileInner>> ListByResourceGroupAsync(this IProfilesOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all Traffic Manager profiles within a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IEnumerable<ProfileInner> ListBySubscription(this IProfilesOperations operations)
            {
                return operations.ListBySubscriptionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all Traffic Manager profiles within a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<ProfileInner>> ListBySubscriptionAsync(this IProfilesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a Traffic Manager profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager profile.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile.
            /// </param>
            public static ProfileInner Get(this IProfilesOperations operations, string resourceGroupName, string profileName)
            {
                return operations.GetAsync(resourceGroupName, profileName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a Traffic Manager profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager profile.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProfileInner> GetAsync(this IProfilesOperations operations, string resourceGroupName, string profileName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, profileName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a Traffic Manager profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager profile.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile.
            /// </param>
            /// <param name='parameters'>
            /// The Traffic Manager profile parameters supplied to the CreateOrUpdate
            /// operation.
            /// </param>
            public static ProfileInner CreateOrUpdate(this IProfilesOperations operations, string resourceGroupName, string profileName, ProfileInner parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, profileName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a Traffic Manager profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager profile.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile.
            /// </param>
            /// <param name='parameters'>
            /// The Traffic Manager profile parameters supplied to the CreateOrUpdate
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProfileInner> CreateOrUpdateAsync(this IProfilesOperations operations, string resourceGroupName, string profileName, ProfileInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, profileName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a Traffic Manager profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager profile to be
            /// deleted.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile to be deleted.
            /// </param>
            public static DeleteOperationResultInner Delete(this IProfilesOperations operations, string resourceGroupName, string profileName)
            {
                return operations.DeleteAsync(resourceGroupName, profileName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a Traffic Manager profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager profile to be
            /// deleted.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeleteOperationResultInner> DeleteAsync(this IProfilesOperations operations, string resourceGroupName, string profileName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, profileName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a Traffic Manager profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager profile.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile.
            /// </param>
            /// <param name='parameters'>
            /// The Traffic Manager profile parameters supplied to the Update operation.
            /// </param>
            public static ProfileInner Update(this IProfilesOperations operations, string resourceGroupName, string profileName, ProfileInner parameters)
            {
                return operations.UpdateAsync(resourceGroupName, profileName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a Traffic Manager profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager profile.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile.
            /// </param>
            /// <param name='parameters'>
            /// The Traffic Manager profile parameters supplied to the Update operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProfileInner> UpdateAsync(this IProfilesOperations operations, string resourceGroupName, string profileName, ProfileInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, profileName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
