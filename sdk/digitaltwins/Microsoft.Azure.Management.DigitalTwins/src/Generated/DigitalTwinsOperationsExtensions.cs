// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DigitalTwins
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DigitalTwinsOperations.
    /// </summary>
    public static partial class DigitalTwinsOperationsExtensions
    {
            /// <summary>
            /// Get DigitalTwinsInstances resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the DigitalTwinsInstance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the DigitalTwinsInstance.
            /// </param>
            public static DigitalTwinsDescription Get(this IDigitalTwinsOperations operations, string resourceGroupName, string resourceName)
            {
                return operations.GetAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get DigitalTwinsInstances resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the DigitalTwinsInstance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the DigitalTwinsInstance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DigitalTwinsDescription> GetAsync(this IDigitalTwinsOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update the metadata of a DigitalTwinsInstance. The usual pattern
            /// to modify a property is to retrieve the DigitalTwinsInstance and security
            /// metadata, and then combine them with the modified values in a new body to
            /// update the DigitalTwinsInstance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the DigitalTwinsInstance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the DigitalTwinsInstance.
            /// </param>
            /// <param name='digitalTwinsCreate'>
            /// The DigitalTwinsInstance and security metadata.
            /// </param>
            public static DigitalTwinsDescription CreateOrUpdate(this IDigitalTwinsOperations operations, string resourceGroupName, string resourceName, DigitalTwinsDescription digitalTwinsCreate)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, resourceName, digitalTwinsCreate).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update the metadata of a DigitalTwinsInstance. The usual pattern
            /// to modify a property is to retrieve the DigitalTwinsInstance and security
            /// metadata, and then combine them with the modified values in a new body to
            /// update the DigitalTwinsInstance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the DigitalTwinsInstance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the DigitalTwinsInstance.
            /// </param>
            /// <param name='digitalTwinsCreate'>
            /// The DigitalTwinsInstance and security metadata.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DigitalTwinsDescription> CreateOrUpdateAsync(this IDigitalTwinsOperations operations, string resourceGroupName, string resourceName, DigitalTwinsDescription digitalTwinsCreate, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, resourceName, digitalTwinsCreate, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update metadata of DigitalTwinsInstance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the DigitalTwinsInstance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the DigitalTwinsInstance.
            /// </param>
            /// <param name='tags'>
            /// Instance tags
            /// </param>
            public static DigitalTwinsDescription Update(this IDigitalTwinsOperations operations, string resourceGroupName, string resourceName, IDictionary<string, string> tags = default(IDictionary<string, string>))
            {
                return operations.UpdateAsync(resourceGroupName, resourceName, tags).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update metadata of DigitalTwinsInstance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the DigitalTwinsInstance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the DigitalTwinsInstance.
            /// </param>
            /// <param name='tags'>
            /// Instance tags
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DigitalTwinsDescription> UpdateAsync(this IDigitalTwinsOperations operations, string resourceGroupName, string resourceName, IDictionary<string, string> tags = default(IDictionary<string, string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, resourceName, tags, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a DigitalTwinsInstance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the DigitalTwinsInstance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the DigitalTwinsInstance.
            /// </param>
            public static DigitalTwinsDescription Delete(this IDigitalTwinsOperations operations, string resourceGroupName, string resourceName)
            {
                return operations.DeleteAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a DigitalTwinsInstance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the DigitalTwinsInstance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the DigitalTwinsInstance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DigitalTwinsDescription> DeleteAsync(this IDigitalTwinsOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all the DigitalTwinsInstances in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<DigitalTwinsDescription> List(this IDigitalTwinsOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all the DigitalTwinsInstances in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DigitalTwinsDescription>> ListAsync(this IDigitalTwinsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all the DigitalTwinsInstances in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the DigitalTwinsInstance.
            /// </param>
            public static IPage<DigitalTwinsDescription> ListByResourceGroup(this IDigitalTwinsOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all the DigitalTwinsInstances in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the DigitalTwinsInstance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DigitalTwinsDescription>> ListByResourceGroupAsync(this IDigitalTwinsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Check if a DigitalTwinsInstance name is available.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of DigitalTwinsInstance.
            /// </param>
            /// <param name='name'>
            /// Resource name.
            /// </param>
            public static CheckNameResult CheckNameAvailability(this IDigitalTwinsOperations operations, string location, string name)
            {
                return operations.CheckNameAvailabilityAsync(location, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Check if a DigitalTwinsInstance name is available.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of DigitalTwinsInstance.
            /// </param>
            /// <param name='name'>
            /// Resource name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CheckNameResult> CheckNameAvailabilityAsync(this IDigitalTwinsOperations operations, string location, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckNameAvailabilityWithHttpMessagesAsync(location, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update the metadata of a DigitalTwinsInstance. The usual pattern
            /// to modify a property is to retrieve the DigitalTwinsInstance and security
            /// metadata, and then combine them with the modified values in a new body to
            /// update the DigitalTwinsInstance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the DigitalTwinsInstance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the DigitalTwinsInstance.
            /// </param>
            /// <param name='digitalTwinsCreate'>
            /// The DigitalTwinsInstance and security metadata.
            /// </param>
            public static DigitalTwinsDescription BeginCreateOrUpdate(this IDigitalTwinsOperations operations, string resourceGroupName, string resourceName, DigitalTwinsDescription digitalTwinsCreate)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, resourceName, digitalTwinsCreate).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update the metadata of a DigitalTwinsInstance. The usual pattern
            /// to modify a property is to retrieve the DigitalTwinsInstance and security
            /// metadata, and then combine them with the modified values in a new body to
            /// update the DigitalTwinsInstance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the DigitalTwinsInstance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the DigitalTwinsInstance.
            /// </param>
            /// <param name='digitalTwinsCreate'>
            /// The DigitalTwinsInstance and security metadata.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DigitalTwinsDescription> BeginCreateOrUpdateAsync(this IDigitalTwinsOperations operations, string resourceGroupName, string resourceName, DigitalTwinsDescription digitalTwinsCreate, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, resourceName, digitalTwinsCreate, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update metadata of DigitalTwinsInstance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the DigitalTwinsInstance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the DigitalTwinsInstance.
            /// </param>
            /// <param name='tags'>
            /// Instance tags
            /// </param>
            public static DigitalTwinsDescription BeginUpdate(this IDigitalTwinsOperations operations, string resourceGroupName, string resourceName, IDictionary<string, string> tags = default(IDictionary<string, string>))
            {
                return operations.BeginUpdateAsync(resourceGroupName, resourceName, tags).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update metadata of DigitalTwinsInstance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the DigitalTwinsInstance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the DigitalTwinsInstance.
            /// </param>
            /// <param name='tags'>
            /// Instance tags
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DigitalTwinsDescription> BeginUpdateAsync(this IDigitalTwinsOperations operations, string resourceGroupName, string resourceName, IDictionary<string, string> tags = default(IDictionary<string, string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, resourceName, tags, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a DigitalTwinsInstance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the DigitalTwinsInstance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the DigitalTwinsInstance.
            /// </param>
            public static DigitalTwinsDescription BeginDelete(this IDigitalTwinsOperations operations, string resourceGroupName, string resourceName)
            {
                return operations.BeginDeleteAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a DigitalTwinsInstance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the DigitalTwinsInstance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the DigitalTwinsInstance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DigitalTwinsDescription> BeginDeleteAsync(this IDigitalTwinsOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all the DigitalTwinsInstances in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DigitalTwinsDescription> ListNext(this IDigitalTwinsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all the DigitalTwinsInstances in a subscription.
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
            public static async Task<IPage<DigitalTwinsDescription>> ListNextAsync(this IDigitalTwinsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all the DigitalTwinsInstances in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DigitalTwinsDescription> ListByResourceGroupNext(this IDigitalTwinsOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all the DigitalTwinsInstances in a resource group.
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
            public static async Task<IPage<DigitalTwinsDescription>> ListByResourceGroupNextAsync(this IDigitalTwinsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
