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
    /// Extension methods for EntityQueryTemplatesOperations.
    /// </summary>
    public static partial class EntityQueryTemplatesOperationsExtensions
    {
            /// <summary>
            /// Gets all entity query templates.
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
            /// <param name='kind'>
            /// The entity template query kind we want to fetch. Possible values include:
            /// 'Activity'
            /// </param>
            public static IPage<EntityQueryTemplate> List(this IEntityQueryTemplatesOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string kind = default(string))
            {
                return operations.ListAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, kind).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all entity query templates.
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
            /// <param name='kind'>
            /// The entity template query kind we want to fetch. Possible values include:
            /// 'Activity'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<EntityQueryTemplate>> ListAsync(this IEntityQueryTemplatesOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string kind = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, kind, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets an entity query.
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
            /// <param name='entityQueryTemplateId'>
            /// entity query template ID
            /// </param>
            public static EntityQueryTemplate Get(this IEntityQueryTemplatesOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string entityQueryTemplateId)
            {
                return operations.GetAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, entityQueryTemplateId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an entity query.
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
            /// <param name='entityQueryTemplateId'>
            /// entity query template ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EntityQueryTemplate> GetAsync(this IEntityQueryTemplatesOperations operations, string resourceGroupName, string operationalInsightsResourceProvider, string workspaceName, string entityQueryTemplateId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, operationalInsightsResourceProvider, workspaceName, entityQueryTemplateId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all entity query templates.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<EntityQueryTemplate> ListNext(this IEntityQueryTemplatesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all entity query templates.
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
            public static async Task<IPage<EntityQueryTemplate>> ListNextAsync(this IEntityQueryTemplatesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
