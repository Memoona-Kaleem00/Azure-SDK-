// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.BillingBenefits.Models;

namespace Azure.ResourceManager.BillingBenefits
{
    /// <summary>
    /// A Class representing a BillingBenefitsSavingsPlan along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="BillingBenefitsSavingsPlanResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetBillingBenefitsSavingsPlanResource method.
    /// Otherwise you can get one from its parent resource <see cref="BillingBenefitsSavingsPlanOrderResource"/> using the GetBillingBenefitsSavingsPlan method.
    /// </summary>
    public partial class BillingBenefitsSavingsPlanResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="BillingBenefitsSavingsPlanResource"/> instance. </summary>
        /// <param name="savingsPlanOrderId"> The savingsPlanOrderId. </param>
        /// <param name="savingsPlanId"> The savingsPlanId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string savingsPlanOrderId, string savingsPlanId)
        {
            var resourceId = $"/providers/Microsoft.BillingBenefits/savingsPlanOrders/{savingsPlanOrderId}/savingsPlans/{savingsPlanId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _billingBenefitsSavingsPlanSavingsPlanClientDiagnostics;
        private readonly SavingsPlanRestOperations _billingBenefitsSavingsPlanSavingsPlanRestClient;
        private readonly BillingBenefitsSavingsPlanData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.BillingBenefits/savingsPlanOrders/savingsPlans";

        /// <summary> Initializes a new instance of the <see cref="BillingBenefitsSavingsPlanResource"/> class for mocking. </summary>
        protected BillingBenefitsSavingsPlanResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BillingBenefitsSavingsPlanResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal BillingBenefitsSavingsPlanResource(ArmClient client, BillingBenefitsSavingsPlanData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="BillingBenefitsSavingsPlanResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BillingBenefitsSavingsPlanResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _billingBenefitsSavingsPlanSavingsPlanClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.BillingBenefits", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string billingBenefitsSavingsPlanSavingsPlanApiVersion);
            _billingBenefitsSavingsPlanSavingsPlanRestClient = new SavingsPlanRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, billingBenefitsSavingsPlanSavingsPlanApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual BillingBenefitsSavingsPlanData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get savings plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/savingsPlanOrders/{savingsPlanOrderId}/savingsPlans/{savingsPlanId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlan_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.BillingBenefits/savingsPlanOrders/savingsPlans</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> May be used to expand the detail information of some properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BillingBenefitsSavingsPlanResource>> GetAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _billingBenefitsSavingsPlanSavingsPlanClientDiagnostics.CreateScope("BillingBenefitsSavingsPlanResource.Get");
            scope.Start();
            try
            {
                var response = await _billingBenefitsSavingsPlanSavingsPlanRestClient.GetAsync(Id.Parent.Name, Id.Name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingBenefitsSavingsPlanResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get savings plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/savingsPlanOrders/{savingsPlanOrderId}/savingsPlans/{savingsPlanId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlan_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.BillingBenefits/savingsPlanOrders/savingsPlans</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> May be used to expand the detail information of some properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BillingBenefitsSavingsPlanResource> Get(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _billingBenefitsSavingsPlanSavingsPlanClientDiagnostics.CreateScope("BillingBenefitsSavingsPlanResource.Get");
            scope.Start();
            try
            {
                var response = _billingBenefitsSavingsPlanSavingsPlanRestClient.Get(Id.Parent.Name, Id.Name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingBenefitsSavingsPlanResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update savings plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/savingsPlanOrders/{savingsPlanOrderId}/savingsPlans/{savingsPlanId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlan_Update</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.BillingBenefits/savingsPlanOrders/savingsPlans</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="patch"> Request body for patching a savings plan order alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<Response<BillingBenefitsSavingsPlanResource>> UpdateAsync(BillingBenefitsSavingsPlanPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _billingBenefitsSavingsPlanSavingsPlanClientDiagnostics.CreateScope("BillingBenefitsSavingsPlanResource.Update");
            scope.Start();
            try
            {
                var response = await _billingBenefitsSavingsPlanSavingsPlanRestClient.UpdateAsync(Id.Parent.Name, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new BillingBenefitsSavingsPlanResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update savings plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/savingsPlanOrders/{savingsPlanOrderId}/savingsPlans/{savingsPlanId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlan_Update</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.BillingBenefits/savingsPlanOrders/savingsPlans</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="patch"> Request body for patching a savings plan order alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual Response<BillingBenefitsSavingsPlanResource> Update(BillingBenefitsSavingsPlanPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _billingBenefitsSavingsPlanSavingsPlanClientDiagnostics.CreateScope("BillingBenefitsSavingsPlanResource.Update");
            scope.Start();
            try
            {
                var response = _billingBenefitsSavingsPlanSavingsPlanRestClient.Update(Id.Parent.Name, Id.Name, patch, cancellationToken);
                return Response.FromValue(new BillingBenefitsSavingsPlanResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Validate savings plan patch.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/savingsPlanOrders/{savingsPlanOrderId}/savingsPlans/{savingsPlanId}/validate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlan_ValidateUpdate</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.BillingBenefits/savingsPlanOrders/savingsPlans</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Request body for validating a savings plan patch request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <returns> An async collection of <see cref="SavingsPlanValidateResult"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SavingsPlanValidateResult> ValidateUpdateAsync(SavingsPlanUpdateValidateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _billingBenefitsSavingsPlanSavingsPlanRestClient.CreateValidateUpdateRequest(Id.Parent.Name, Id.Name, content);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _billingBenefitsSavingsPlanSavingsPlanRestClient.CreateValidateUpdateNextPageRequest(nextLink, Id.Parent.Name, Id.Name, content);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, SavingsPlanValidateResult.DeserializeSavingsPlanValidateResult, _billingBenefitsSavingsPlanSavingsPlanClientDiagnostics, Pipeline, "BillingBenefitsSavingsPlanResource.ValidateUpdate", "benefits", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Validate savings plan patch.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/savingsPlanOrders/{savingsPlanOrderId}/savingsPlans/{savingsPlanId}/validate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlan_ValidateUpdate</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.BillingBenefits/savingsPlanOrders/savingsPlans</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Request body for validating a savings plan patch request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <returns> A collection of <see cref="SavingsPlanValidateResult"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SavingsPlanValidateResult> ValidateUpdate(SavingsPlanUpdateValidateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _billingBenefitsSavingsPlanSavingsPlanRestClient.CreateValidateUpdateRequest(Id.Parent.Name, Id.Name, content);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _billingBenefitsSavingsPlanSavingsPlanRestClient.CreateValidateUpdateNextPageRequest(nextLink, Id.Parent.Name, Id.Name, content);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, SavingsPlanValidateResult.DeserializeSavingsPlanValidateResult, _billingBenefitsSavingsPlanSavingsPlanClientDiagnostics, Pipeline, "BillingBenefitsSavingsPlanResource.ValidateUpdate", "benefits", "nextLink", cancellationToken);
        }
    }
}
