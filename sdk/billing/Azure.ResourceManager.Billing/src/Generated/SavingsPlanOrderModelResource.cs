// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Billing
{
    /// <summary>
    /// A Class representing a SavingsPlanOrderModel along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SavingsPlanOrderModelResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSavingsPlanOrderModelResource method.
    /// Otherwise you can get one from its parent resource <see cref="BillingAccountResource"/> using the GetSavingsPlanOrderModel method.
    /// </summary>
    public partial class SavingsPlanOrderModelResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SavingsPlanOrderModelResource"/> instance. </summary>
        /// <param name="billingAccountName"> The billingAccountName. </param>
        /// <param name="savingsPlanOrderId"> The savingsPlanOrderId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string savingsPlanOrderId)
        {
            var resourceId = $"/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/savingsPlanOrders/{savingsPlanOrderId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _savingsPlanOrderModelSavingsPlanOrdersClientDiagnostics;
        private readonly SavingsPlanOrdersRestOperations _savingsPlanOrderModelSavingsPlanOrdersRestClient;
        private readonly SavingsPlanOrderModelData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Billing/billingAccounts/savingsPlanOrders";

        /// <summary> Initializes a new instance of the <see cref="SavingsPlanOrderModelResource"/> class for mocking. </summary>
        protected SavingsPlanOrderModelResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SavingsPlanOrderModelResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SavingsPlanOrderModelResource(ArmClient client, SavingsPlanOrderModelData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SavingsPlanOrderModelResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SavingsPlanOrderModelResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _savingsPlanOrderModelSavingsPlanOrdersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Billing", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string savingsPlanOrderModelSavingsPlanOrdersApiVersion);
            _savingsPlanOrderModelSavingsPlanOrdersRestClient = new SavingsPlanOrdersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, savingsPlanOrderModelSavingsPlanOrdersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SavingsPlanOrderModelData Data
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

        /// <summary> Gets a collection of BillingSavingsPlanModelResources in the SavingsPlanOrderModel. </summary>
        /// <returns> An object representing collection of BillingSavingsPlanModelResources and their operations over a BillingSavingsPlanModelResource. </returns>
        public virtual BillingSavingsPlanModelCollection GetBillingSavingsPlanModels()
        {
            return GetCachedClient(client => new BillingSavingsPlanModelCollection(client, Id));
        }

        /// <summary>
        /// Get savings plan by billing account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/savingsPlanOrders/{savingsPlanOrderId}/savingsPlans/{savingsPlanId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlans_GetByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingSavingsPlanModelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="savingsPlanId"> ID of the savings plan. </param>
        /// <param name="expand"> May be used to expand the planInformation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="savingsPlanId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="savingsPlanId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<BillingSavingsPlanModelResource>> GetBillingSavingsPlanModelAsync(string savingsPlanId, string expand = null, CancellationToken cancellationToken = default)
        {
            return await GetBillingSavingsPlanModels().GetAsync(savingsPlanId, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get savings plan by billing account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/savingsPlanOrders/{savingsPlanOrderId}/savingsPlans/{savingsPlanId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlans_GetByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingSavingsPlanModelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="savingsPlanId"> ID of the savings plan. </param>
        /// <param name="expand"> May be used to expand the planInformation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="savingsPlanId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="savingsPlanId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<BillingSavingsPlanModelResource> GetBillingSavingsPlanModel(string savingsPlanId, string expand = null, CancellationToken cancellationToken = default)
        {
            return GetBillingSavingsPlanModels().Get(savingsPlanId, expand, cancellationToken);
        }

        /// <summary>
        /// Get a savings plan order by billing account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/savingsPlanOrders/{savingsPlanOrderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlanOrders_GetByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SavingsPlanOrderModelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> May be used to expand the planInformation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SavingsPlanOrderModelResource>> GetAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _savingsPlanOrderModelSavingsPlanOrdersClientDiagnostics.CreateScope("SavingsPlanOrderModelResource.Get");
            scope.Start();
            try
            {
                var response = await _savingsPlanOrderModelSavingsPlanOrdersRestClient.GetByBillingAccountAsync(Id.Parent.Name, Id.Name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SavingsPlanOrderModelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a savings plan order by billing account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/savingsPlanOrders/{savingsPlanOrderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlanOrders_GetByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SavingsPlanOrderModelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> May be used to expand the planInformation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SavingsPlanOrderModelResource> Get(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _savingsPlanOrderModelSavingsPlanOrdersClientDiagnostics.CreateScope("SavingsPlanOrderModelResource.Get");
            scope.Start();
            try
            {
                var response = _savingsPlanOrderModelSavingsPlanOrdersRestClient.GetByBillingAccount(Id.Parent.Name, Id.Name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SavingsPlanOrderModelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
