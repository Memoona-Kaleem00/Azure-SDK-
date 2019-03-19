// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BillingProfilesOperations.
    /// </summary>
    public static partial class BillingProfilesOperationsExtensions
    {
            /// <summary>
            /// Get the billing profile by id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountId'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileId'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='expand'>
            /// May be used to expand the invoiceSections.
            /// </param>
            public static BillingProfile Get(this IBillingProfilesOperations operations, string billingAccountId, string billingProfileId, string expand = default(string))
            {
                return operations.GetAsync(billingAccountId, billingProfileId, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the billing profile by id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountId'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileId'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='expand'>
            /// May be used to expand the invoiceSections.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingProfile> GetAsync(this IBillingProfilesOperations operations, string billingAccountId, string billingProfileId, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(billingAccountId, billingProfileId, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to update a billing profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountId'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileId'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the update billing profile operation.
            /// </param>
            public static BillingProfile Update(this IBillingProfilesOperations operations, string billingAccountId, string billingProfileId, BillingProfile parameters)
            {
                return operations.UpdateAsync(billingAccountId, billingProfileId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to update a billing profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountId'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileId'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the update billing profile operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingProfile> UpdateAsync(this IBillingProfilesOperations operations, string billingAccountId, string billingProfileId, BillingProfile parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(billingAccountId, billingProfileId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to update a billing profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountId'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileId'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the update billing profile operation.
            /// </param>
            public static BillingProfile BeginUpdate(this IBillingProfilesOperations operations, string billingAccountId, string billingProfileId, BillingProfile parameters)
            {
                return operations.BeginUpdateAsync(billingAccountId, billingProfileId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to update a billing profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountId'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileId'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the update billing profile operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingProfile> BeginUpdateAsync(this IBillingProfilesOperations operations, string billingAccountId, string billingProfileId, BillingProfile parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(billingAccountId, billingProfileId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
