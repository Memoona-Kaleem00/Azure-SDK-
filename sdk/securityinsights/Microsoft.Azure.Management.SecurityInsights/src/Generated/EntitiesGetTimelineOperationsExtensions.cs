// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for EntitiesGetTimelineOperations.
    /// </summary>
    public static partial class EntitiesGetTimelineOperationsExtensions
    {
            /// <summary>
            /// Timeline for an entity.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='entityId'>
            /// entity ID
            /// </param>
            /// <param name='parameters'>
            /// The parameters required to execute an timeline operation on the given
            /// entity.
            /// </param>
            public static EntityTimelineResponse List(this IEntitiesGetTimelineOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string entityId, EntityTimelineParameters parameters)
            {
                return operations.ListAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, entityId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Timeline for an entity.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='operationalInsightsResourceProvider'>
            /// The namespace of workspaces resource provider-
            /// Microsoft.OperationalInsights.
            /// </param>
            /// <param name='workspaceName'>
            /// The name of the workspace.
            /// </param>
            /// <param name='entityId'>
            /// entity ID
            /// </param>
            /// <param name='parameters'>
            /// The parameters required to execute an timeline operation on the given
            /// entity.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EntityTimelineResponse> ListAsync(this IEntitiesGetTimelineOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string entityId, EntityTimelineParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, entityId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
