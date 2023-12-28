// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Billing
{
    /// <summary>
    /// A class representing a collection of <see cref="BillingSubscriptionResource"/> and their operations.
    /// Each <see cref="BillingSubscriptionResource"/> in the collection will belong to the same instance of <see cref="TenantResource"/>.
    /// To get a <see cref="BillingSubscriptionCollection"/> instance call the GetBillingSubscriptions method from an instance of <see cref="TenantResource"/>.
    /// </summary>
    public partial class BillingSubscriptionCollection : ArmCollection, IEnumerable<BillingSubscriptionResource>, IAsyncEnumerable<BillingSubscriptionResource>
    {
        private readonly ClientDiagnostics _billingSubscriptionClientDiagnostics;
        private readonly BillingSubscriptionsRestOperations _billingSubscriptionRestClient;
        private readonly string _billingAccountName;

        /// <summary> Initializes a new instance of the <see cref="BillingSubscriptionCollection"/> class for mocking. </summary>
        protected BillingSubscriptionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BillingSubscriptionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        internal BillingSubscriptionCollection(ArmClient client, ResourceIdentifier id, string billingAccountName) : base(client, id)
        {
            _billingAccountName = billingAccountName;
            _billingSubscriptionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Billing", BillingSubscriptionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BillingSubscriptionResource.ResourceType, out string billingSubscriptionApiVersion);
            _billingSubscriptionRestClient = new BillingSubscriptionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, billingSubscriptionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TenantResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TenantResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a subscription by its ID. The operation is currently supported for billing accounts with agreement type Microsoft Customer Agreement, Microsoft Partner Agreement and Microsoft Online Services Program.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingSubscriptions/{billingSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingSubscriptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Billing/billingAccounts/billingSubscriptions</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="billingSubscriptionName"> The ID that uniquely identifies a subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="billingSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="billingSubscriptionName"/> is null. </exception>
        public virtual async Task<Response<BillingSubscriptionResource>> GetAsync(string billingSubscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingSubscriptionName, nameof(billingSubscriptionName));

            using var scope = _billingSubscriptionClientDiagnostics.CreateScope("BillingSubscriptionCollection.Get");
            scope.Start();
            try
            {
                var response = await _billingSubscriptionRestClient.GetAsync(_billingAccountName, billingSubscriptionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a subscription by its ID. The operation is currently supported for billing accounts with agreement type Microsoft Customer Agreement, Microsoft Partner Agreement and Microsoft Online Services Program.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingSubscriptions/{billingSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingSubscriptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Billing/billingAccounts/billingSubscriptions</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="billingSubscriptionName"> The ID that uniquely identifies a subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="billingSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="billingSubscriptionName"/> is null. </exception>
        public virtual Response<BillingSubscriptionResource> Get(string billingSubscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingSubscriptionName, nameof(billingSubscriptionName));

            using var scope = _billingSubscriptionClientDiagnostics.CreateScope("BillingSubscriptionCollection.Get");
            scope.Start();
            try
            {
                var response = _billingSubscriptionRestClient.Get(_billingAccountName, billingSubscriptionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the subscriptions for a billing account. The operation is currently supported for billing accounts with agreement type Microsoft Customer Agreement, Microsoft Partner Agreement and Microsoft Online Services Program.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingSubscriptions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingSubscriptions_ListByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Billing/billingAccounts/billingSubscriptions</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BillingSubscriptionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BillingSubscriptionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _billingSubscriptionRestClient.CreateListByBillingAccountRequest(_billingAccountName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _billingSubscriptionRestClient.CreateListByBillingAccountNextPageRequest(nextLink, _billingAccountName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new BillingSubscriptionResource(Client, BillingSubscriptionData.DeserializeBillingSubscriptionData(e)), _billingSubscriptionClientDiagnostics, Pipeline, "BillingSubscriptionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the subscriptions for a billing account. The operation is currently supported for billing accounts with agreement type Microsoft Customer Agreement, Microsoft Partner Agreement and Microsoft Online Services Program.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingSubscriptions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingSubscriptions_ListByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Billing/billingAccounts/billingSubscriptions</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BillingSubscriptionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BillingSubscriptionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _billingSubscriptionRestClient.CreateListByBillingAccountRequest(_billingAccountName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _billingSubscriptionRestClient.CreateListByBillingAccountNextPageRequest(nextLink, _billingAccountName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new BillingSubscriptionResource(Client, BillingSubscriptionData.DeserializeBillingSubscriptionData(e)), _billingSubscriptionClientDiagnostics, Pipeline, "BillingSubscriptionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingSubscriptions/{billingSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingSubscriptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Billing/billingAccounts/billingSubscriptions</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="billingSubscriptionName"> The ID that uniquely identifies a subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="billingSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="billingSubscriptionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string billingSubscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingSubscriptionName, nameof(billingSubscriptionName));

            using var scope = _billingSubscriptionClientDiagnostics.CreateScope("BillingSubscriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _billingSubscriptionRestClient.GetAsync(_billingAccountName, billingSubscriptionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingSubscriptions/{billingSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingSubscriptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Billing/billingAccounts/billingSubscriptions</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="billingSubscriptionName"> The ID that uniquely identifies a subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="billingSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="billingSubscriptionName"/> is null. </exception>
        public virtual Response<bool> Exists(string billingSubscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingSubscriptionName, nameof(billingSubscriptionName));

            using var scope = _billingSubscriptionClientDiagnostics.CreateScope("BillingSubscriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = _billingSubscriptionRestClient.Get(_billingAccountName, billingSubscriptionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingSubscriptions/{billingSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingSubscriptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Billing/billingAccounts/billingSubscriptions</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="billingSubscriptionName"> The ID that uniquely identifies a subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="billingSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="billingSubscriptionName"/> is null. </exception>
        public virtual async Task<NullableResponse<BillingSubscriptionResource>> GetIfExistsAsync(string billingSubscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingSubscriptionName, nameof(billingSubscriptionName));

            using var scope = _billingSubscriptionClientDiagnostics.CreateScope("BillingSubscriptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _billingSubscriptionRestClient.GetAsync(_billingAccountName, billingSubscriptionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<BillingSubscriptionResource>(response.GetRawResponse());
                return Response.FromValue(new BillingSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/billingSubscriptions/{billingSubscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BillingSubscriptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Billing/billingAccounts/billingSubscriptions</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="billingSubscriptionName"> The ID that uniquely identifies a subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="billingSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="billingSubscriptionName"/> is null. </exception>
        public virtual NullableResponse<BillingSubscriptionResource> GetIfExists(string billingSubscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingSubscriptionName, nameof(billingSubscriptionName));

            using var scope = _billingSubscriptionClientDiagnostics.CreateScope("BillingSubscriptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _billingSubscriptionRestClient.Get(_billingAccountName, billingSubscriptionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<BillingSubscriptionResource>(response.GetRawResponse());
                return Response.FromValue(new BillingSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BillingSubscriptionResource> IEnumerable<BillingSubscriptionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BillingSubscriptionResource> IAsyncEnumerable<BillingSubscriptionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
