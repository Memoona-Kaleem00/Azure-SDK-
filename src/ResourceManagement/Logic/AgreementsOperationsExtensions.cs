// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Logic;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AgreementsOperations.
    /// </summary>
    public static partial class AgreementsOperationsExtensions
    {
            /// <summary>
            /// Gets a list of integration account agreements.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<IntegrationAccountAgreementInner>> ListByIntegrationAccountsAsync(this IAgreementsOperations operations, string resourceGroupName, string integrationAccountName, ODataQuery<IntegrationAccountAgreementFilterInner> odataQuery = default(ODataQuery<IntegrationAccountAgreementFilterInner>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByIntegrationAccountsWithHttpMessagesAsync(resourceGroupName, integrationAccountName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets an integration account agreement.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='agreementName'>
            /// The integration account agreement name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IntegrationAccountAgreementInner> GetAsync(this IAgreementsOperations operations, string resourceGroupName, string integrationAccountName, string agreementName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, integrationAccountName, agreementName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates an integration account agreement.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='agreementName'>
            /// The integration account agreement name.
            /// </param>
            /// <param name='agreement'>
            /// The integration account agreement.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IntegrationAccountAgreementInner> CreateOrUpdateAsync(this IAgreementsOperations operations, string resourceGroupName, string integrationAccountName, string agreementName, IntegrationAccountAgreementInner agreement, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, integrationAccountName, agreementName, agreement, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an integration account agreement.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='agreementName'>
            /// The integration account agreement name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IAgreementsOperations operations, string resourceGroupName, string integrationAccountName, string agreementName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, integrationAccountName, agreementName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a list of integration account agreements.
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
            public static async Task<IPage<IntegrationAccountAgreementInner>> ListByIntegrationAccountsNextAsync(this IAgreementsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByIntegrationAccountsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
