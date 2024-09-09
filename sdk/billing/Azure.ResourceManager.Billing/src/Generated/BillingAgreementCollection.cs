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
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Billing
{
    /// <summary>
    /// A class representing a collection of <see cref="BillingAgreementResource"/> and their operations.
    /// Each <see cref="BillingAgreementResource"/> in the collection will belong to the same instance of <see cref="BillingAccountResource"/>.
    /// To get a <see cref="BillingAgreementCollection"/> instance call the GetBillingAgreements method from an instance of <see cref="BillingAccountResource"/>.
    /// </summary>
    public partial class BillingAgreementCollection : ArmCollection, IEnumerable<BillingAgreementResource>, IAsyncEnumerable<BillingAgreementResource>
    {
        private readonly ClientDiagnostics _billingAgreementAgreementsClientDiagnostics;
        private readonly AgreementsRestOperations _billingAgreementAgreementsRestClient;

        /// <summary> Initializes a new instance of the <see cref="BillingAgreementCollection"/> class for mocking. </summary>
        protected BillingAgreementCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BillingAgreementCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BillingAgreementCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _billingAgreementAgreementsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Billing", BillingAgreementResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BillingAgreementResource.ResourceType, out string billingAgreementAgreementsApiVersion);
            _billingAgreementAgreementsRestClient = new AgreementsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, billingAgreementAgreementsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != BillingAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, BillingAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets an agreement by ID.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/agreements/{agreementName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Agreements_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAgreementResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agreementName"> The ID that uniquely identifies an agreement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agreementName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agreementName"/> is null. </exception>
        public virtual async Task<Response<BillingAgreementResource>> GetAsync(string agreementName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agreementName, nameof(agreementName));

            using var scope = _billingAgreementAgreementsClientDiagnostics.CreateScope("BillingAgreementCollection.Get");
            scope.Start();
            try
            {
                var response = await _billingAgreementAgreementsRestClient.GetAsync(Id.Name, agreementName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingAgreementResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an agreement by ID.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/agreements/{agreementName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Agreements_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAgreementResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agreementName"> The ID that uniquely identifies an agreement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agreementName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agreementName"/> is null. </exception>
        public virtual Response<BillingAgreementResource> Get(string agreementName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agreementName, nameof(agreementName));

            using var scope = _billingAgreementAgreementsClientDiagnostics.CreateScope("BillingAgreementCollection.Get");
            scope.Start();
            try
            {
                var response = _billingAgreementAgreementsRestClient.Get(Id.Name, agreementName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingAgreementResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the agreements for a billing account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/agreements</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Agreements_ListByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAgreementResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BillingAgreementResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BillingAgreementResource> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _billingAgreementAgreementsRestClient.CreateListByBillingAccountRequest(Id.Name, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _billingAgreementAgreementsRestClient.CreateListByBillingAccountNextPageRequest(nextLink, Id.Name, expand);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new BillingAgreementResource(Client, BillingAgreementData.DeserializeBillingAgreementData(e)), _billingAgreementAgreementsClientDiagnostics, Pipeline, "BillingAgreementCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the agreements for a billing account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/agreements</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Agreements_ListByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAgreementResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BillingAgreementResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BillingAgreementResource> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _billingAgreementAgreementsRestClient.CreateListByBillingAccountRequest(Id.Name, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _billingAgreementAgreementsRestClient.CreateListByBillingAccountNextPageRequest(nextLink, Id.Name, expand);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new BillingAgreementResource(Client, BillingAgreementData.DeserializeBillingAgreementData(e)), _billingAgreementAgreementsClientDiagnostics, Pipeline, "BillingAgreementCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/agreements/{agreementName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Agreements_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAgreementResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agreementName"> The ID that uniquely identifies an agreement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agreementName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agreementName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string agreementName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agreementName, nameof(agreementName));

            using var scope = _billingAgreementAgreementsClientDiagnostics.CreateScope("BillingAgreementCollection.Exists");
            scope.Start();
            try
            {
                var response = await _billingAgreementAgreementsRestClient.GetAsync(Id.Name, agreementName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/agreements/{agreementName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Agreements_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAgreementResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agreementName"> The ID that uniquely identifies an agreement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agreementName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agreementName"/> is null. </exception>
        public virtual Response<bool> Exists(string agreementName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agreementName, nameof(agreementName));

            using var scope = _billingAgreementAgreementsClientDiagnostics.CreateScope("BillingAgreementCollection.Exists");
            scope.Start();
            try
            {
                var response = _billingAgreementAgreementsRestClient.Get(Id.Name, agreementName, cancellationToken: cancellationToken);
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
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/agreements/{agreementName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Agreements_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAgreementResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agreementName"> The ID that uniquely identifies an agreement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agreementName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agreementName"/> is null. </exception>
        public virtual async Task<NullableResponse<BillingAgreementResource>> GetIfExistsAsync(string agreementName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agreementName, nameof(agreementName));

            using var scope = _billingAgreementAgreementsClientDiagnostics.CreateScope("BillingAgreementCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _billingAgreementAgreementsRestClient.GetAsync(Id.Name, agreementName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<BillingAgreementResource>(response.GetRawResponse());
                return Response.FromValue(new BillingAgreementResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/agreements/{agreementName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Agreements_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingAgreementResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agreementName"> The ID that uniquely identifies an agreement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agreementName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agreementName"/> is null. </exception>
        public virtual NullableResponse<BillingAgreementResource> GetIfExists(string agreementName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agreementName, nameof(agreementName));

            using var scope = _billingAgreementAgreementsClientDiagnostics.CreateScope("BillingAgreementCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _billingAgreementAgreementsRestClient.Get(Id.Name, agreementName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<BillingAgreementResource>(response.GetRawResponse());
                return Response.FromValue(new BillingAgreementResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BillingAgreementResource> IEnumerable<BillingAgreementResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BillingAgreementResource> IAsyncEnumerable<BillingAgreementResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
