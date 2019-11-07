// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataShare
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SynchronizationSettingsOperations.
    /// </summary>
    public static partial class SynchronizationSettingsOperationsExtensions
    {
            /// <summary>
            /// Get synchronizationSetting in a share.
            /// </summary>
            /// <remarks>
            /// Get a synchronizationSetting in a share
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareName'>
            /// The name of the share.
            /// </param>
            /// <param name='synchronizationSettingName'>
            /// The name of the synchronizationSetting.
            /// </param>
            public static SynchronizationSetting Get(this ISynchronizationSettingsOperations operations, string resourceGroupName, string accountName, string shareName, string synchronizationSettingName)
            {
                return operations.GetAsync(resourceGroupName, accountName, shareName, synchronizationSettingName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get synchronizationSetting in a share.
            /// </summary>
            /// <remarks>
            /// Get a synchronizationSetting in a share
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareName'>
            /// The name of the share.
            /// </param>
            /// <param name='synchronizationSettingName'>
            /// The name of the synchronizationSetting.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SynchronizationSetting> GetAsync(this ISynchronizationSettingsOperations operations, string resourceGroupName, string accountName, string shareName, string synchronizationSettingName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, shareName, synchronizationSettingName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get synchronizationSetting in a share.
            /// </summary>
            /// <remarks>
            /// Get a synchronizationSetting in a share
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareName'>
            /// The name of the share.
            /// </param>
            /// <param name='synchronizationSettingName'>
            /// The name of the synchronizationSetting.
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static AzureOperationResponse<SynchronizationSetting> GetWithHttpMessages(this ISynchronizationSettingsOperations operations, string resourceGroupName, string accountName, string shareName, string synchronizationSettingName, Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, shareName, synchronizationSettingName, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Adds a new synchronization setting to an existing share or updates it if
            /// existing.
            /// </summary>
            /// <remarks>
            /// Create or update a synchronizationSetting
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareName'>
            /// The name of the share to add the synchronization setting to.
            /// </param>
            /// <param name='synchronizationSettingName'>
            /// The name of the synchronizationSetting.
            /// </param>
            /// <param name='synchronizationSetting'>
            /// The new synchronization setting information.
            /// </param>
            public static SynchronizationSetting Create(this ISynchronizationSettingsOperations operations, string resourceGroupName, string accountName, string shareName, string synchronizationSettingName, SynchronizationSetting synchronizationSetting)
            {
                return operations.CreateAsync(resourceGroupName, accountName, shareName, synchronizationSettingName, synchronizationSetting).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Adds a new synchronization setting to an existing share or updates it if
            /// existing.
            /// </summary>
            /// <remarks>
            /// Create or update a synchronizationSetting
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareName'>
            /// The name of the share to add the synchronization setting to.
            /// </param>
            /// <param name='synchronizationSettingName'>
            /// The name of the synchronizationSetting.
            /// </param>
            /// <param name='synchronizationSetting'>
            /// The new synchronization setting information.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SynchronizationSetting> CreateAsync(this ISynchronizationSettingsOperations operations, string resourceGroupName, string accountName, string shareName, string synchronizationSettingName, SynchronizationSetting synchronizationSetting, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, accountName, shareName, synchronizationSettingName, synchronizationSetting, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Adds a new synchronization setting to an existing share or updates it if
            /// existing.
            /// </summary>
            /// <remarks>
            /// Create or update a synchronizationSetting
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareName'>
            /// The name of the share to add the synchronization setting to.
            /// </param>
            /// <param name='synchronizationSettingName'>
            /// The name of the synchronizationSetting.
            /// </param>
            /// <param name='synchronizationSetting'>
            /// The new synchronization setting information.
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static AzureOperationResponse<SynchronizationSetting> CreateWithHttpMessages(this ISynchronizationSettingsOperations operations, string resourceGroupName, string accountName, string shareName, string synchronizationSettingName, SynchronizationSetting synchronizationSetting, Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.CreateWithHttpMessagesAsync(resourceGroupName, accountName, shareName, synchronizationSettingName, synchronizationSetting, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete synchronizationSetting in a share.
            /// </summary>
            /// <remarks>
            /// Delete a synchronizationSetting in a share
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareName'>
            /// The name of the share.
            /// </param>
            /// <param name='synchronizationSettingName'>
            /// The name of the synchronizationSetting .
            /// </param>
            public static OperationResponse Delete(this ISynchronizationSettingsOperations operations, string resourceGroupName, string accountName, string shareName, string synchronizationSettingName)
            {
                return operations.DeleteAsync(resourceGroupName, accountName, shareName, synchronizationSettingName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete synchronizationSetting in a share.
            /// </summary>
            /// <remarks>
            /// Delete a synchronizationSetting in a share
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareName'>
            /// The name of the share.
            /// </param>
            /// <param name='synchronizationSettingName'>
            /// The name of the synchronizationSetting .
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationResponse> DeleteAsync(this ISynchronizationSettingsOperations operations, string resourceGroupName, string accountName, string shareName, string synchronizationSettingName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, shareName, synchronizationSettingName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete synchronizationSetting in a share.
            /// </summary>
            /// <remarks>
            /// Delete a synchronizationSetting in a share
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareName'>
            /// The name of the share.
            /// </param>
            /// <param name='synchronizationSettingName'>
            /// The name of the synchronizationSetting .
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static AzureOperationResponse<OperationResponse> DeleteWithHttpMessages(this ISynchronizationSettingsOperations operations, string resourceGroupName, string accountName, string shareName, string synchronizationSettingName, Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, shareName, synchronizationSettingName, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List synchronizationSettings in a share.
            /// </summary>
            /// <remarks>
            /// List synchronizationSettings in a share
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareName'>
            /// The name of the share.
            /// </param>
            /// <param name='skipToken'>
            /// continuation token
            /// </param>
            public static IPage<SynchronizationSetting> ListByShare(this ISynchronizationSettingsOperations operations, string resourceGroupName, string accountName, string shareName, string skipToken = default(string))
            {
                return operations.ListByShareAsync(resourceGroupName, accountName, shareName, skipToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List synchronizationSettings in a share.
            /// </summary>
            /// <remarks>
            /// List synchronizationSettings in a share
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareName'>
            /// The name of the share.
            /// </param>
            /// <param name='skipToken'>
            /// continuation token
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SynchronizationSetting>> ListByShareAsync(this ISynchronizationSettingsOperations operations, string resourceGroupName, string accountName, string shareName, string skipToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByShareWithHttpMessagesAsync(resourceGroupName, accountName, shareName, skipToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List synchronizationSettings in a share.
            /// </summary>
            /// <remarks>
            /// List synchronizationSettings in a share
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareName'>
            /// The name of the share.
            /// </param>
            /// <param name='skipToken'>
            /// continuation token
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static AzureOperationResponse<IPage<SynchronizationSetting>> ListByShareWithHttpMessages(this ISynchronizationSettingsOperations operations, string resourceGroupName, string accountName, string shareName, string skipToken = default(string), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.ListByShareWithHttpMessagesAsync(resourceGroupName, accountName, shareName, skipToken, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete synchronizationSetting in a share.
            /// </summary>
            /// <remarks>
            /// Delete a synchronizationSetting in a share
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareName'>
            /// The name of the share.
            /// </param>
            /// <param name='synchronizationSettingName'>
            /// The name of the synchronizationSetting .
            /// </param>
            public static OperationResponse BeginDelete(this ISynchronizationSettingsOperations operations, string resourceGroupName, string accountName, string shareName, string synchronizationSettingName)
            {
                return operations.BeginDeleteAsync(resourceGroupName, accountName, shareName, synchronizationSettingName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete synchronizationSetting in a share.
            /// </summary>
            /// <remarks>
            /// Delete a synchronizationSetting in a share
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareName'>
            /// The name of the share.
            /// </param>
            /// <param name='synchronizationSettingName'>
            /// The name of the synchronizationSetting .
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationResponse> BeginDeleteAsync(this ISynchronizationSettingsOperations operations, string resourceGroupName, string accountName, string shareName, string synchronizationSettingName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, accountName, shareName, synchronizationSettingName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete synchronizationSetting in a share.
            /// </summary>
            /// <remarks>
            /// Delete a synchronizationSetting in a share
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareName'>
            /// The name of the share.
            /// </param>
            /// <param name='synchronizationSettingName'>
            /// The name of the synchronizationSetting .
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static AzureOperationResponse<OperationResponse> BeginDeleteWithHttpMessages(this ISynchronizationSettingsOperations operations, string resourceGroupName, string accountName, string shareName, string synchronizationSettingName, Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, accountName, shareName, synchronizationSettingName, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List synchronizationSettings in a share.
            /// </summary>
            /// <remarks>
            /// List synchronizationSettings in a share
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SynchronizationSetting> ListByShareNext(this ISynchronizationSettingsOperations operations, string nextPageLink)
            {
                return operations.ListByShareNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List synchronizationSettings in a share.
            /// </summary>
            /// <remarks>
            /// List synchronizationSettings in a share
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
            public static async Task<IPage<SynchronizationSetting>> ListByShareNextAsync(this ISynchronizationSettingsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByShareNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List synchronizationSettings in a share.
            /// </summary>
            /// <remarks>
            /// List synchronizationSettings in a share
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static AzureOperationResponse<IPage<SynchronizationSetting>> ListByShareNextWithHttpMessages(this ISynchronizationSettingsOperations operations, string nextPageLink, Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.ListByShareNextWithHttpMessagesAsync(nextPageLink, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
