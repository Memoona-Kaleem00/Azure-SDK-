// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MachineLearningServices
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for QuotasOperations.
    /// </summary>
    public static partial class QuotasOperationsExtensions
    {
            /// <summary>
            /// Update quota for each VM family in workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The location for update quota is queried.
            /// </param>
            /// <param name='parameters'>
            /// Quota update parameters.
            /// </param>
            public static UpdateWorkspaceQuotasResult Update(this IQuotasOperations operations, string location, QuotaUpdateParameters parameters)
            {
                return operations.UpdateAsync(location, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update quota for each VM family in workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The location for update quota is queried.
            /// </param>
            /// <param name='parameters'>
            /// Quota update parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UpdateWorkspaceQuotasResult> UpdateAsync(this IQuotasOperations operations, string location, QuotaUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(location, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the currently assigned Workspace Quotas based on VMFamily.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The location for which resource usage is queried.
            /// </param>
            public static IPage<ResourceQuota> List(this IQuotasOperations operations, string location)
            {
                return operations.ListAsync(location).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the currently assigned Workspace Quotas based on VMFamily.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The location for which resource usage is queried.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ResourceQuota>> ListAsync(this IQuotasOperations operations, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(location, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the currently assigned Workspace Quotas based on VMFamily.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ResourceQuota> ListNext(this IQuotasOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the currently assigned Workspace Quotas based on VMFamily.
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
            public static async Task<IPage<ResourceQuota>> ListNextAsync(this IQuotasOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
