﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Reservations.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.Reservations.Tests
{
    public class PurchaseReservationOrderTests : ReservationsManagementClientBase
    {
        private TenantResource Tenant { get; set; }
        private ReservationOrderResponseCollection collection { get; set; }
        private PurchaseRequestContent purchaseRequestContent { get; set; }

        public PurchaseReservationOrderTests(bool isAsync) : base(isAsync)
        {
        }

        [SetUp]
        public async Task ClearAndInitialize()
        {
            if (Mode == RecordedTestMode.Record || Mode == RecordedTestMode.Playback)
            {
                await InitializeClients();

                AsyncPageable<TenantResource> tenantResourcesResponse = ArmClient.GetTenants().GetAllAsync();
                List<TenantResource> tenantResources = await tenantResourcesResponse.ToEnumerableAsync();
                Tenant = tenantResources.ToArray()[0];
                collection = Tenant.GetReservationOrderResponses();
            }

            purchaseRequestContent = new PurchaseRequestContent(
                sku: new ReservationsSkuName("Standard_B1ls"),
                location: new Core.AzureLocation("westus"),
                reservedResourceType: new ReservedResourceType("VirtualMachines"),
                billingScopeId: "/subscriptions/6d5e2387-bdf5-4ca1-83db-795fd2398b93",
                term: new ReservationTerm("P1Y"),
                billingPlan: new ReservationBillingPlan("Monthly"),
                quantity: 1,
                displayName: "testVM",
                appliedScopeType: new AppliedScopeType("Shared"),
                renew: false,
                reservedResourceProperties: new PurchaseRequestPropertiesReservedResourceProperties(new InstanceFlexibility("On")),
                appliedScopes: null);
        }

        [TestCase]
        [RecordedTest]
        public async Task TestPurchaseReservationOrderSharedScopeMonthly()
        {
            var response = await Tenant.CalculateReservationOrderAsync(purchaseRequestContent);
            var purchaseResponse = await collection.CreateOrUpdateAsync(WaitUntil.Completed, response.Value.Properties.ReservationOrderId, purchaseRequestContent);

            await purchaseResponse.WaitForCompletionAsync();
            validateTestResult(purchaseResponse, purchaseRequestContent, response.Value.Properties.ReservationOrderId);
        }

        [TestCase]
        [RecordedTest]
        public async Task TestPurchaseReservationOrderSharedScopeUpfront()
        {
            purchaseRequestContent.BillingPlan = new ReservationBillingPlan("Upfront");
            var response = await Tenant.CalculateReservationOrderAsync(purchaseRequestContent);
            var purchaseResponse = await collection.CreateOrUpdateAsync(WaitUntil.Completed, response.Value.Properties.ReservationOrderId, purchaseRequestContent);

            await purchaseResponse.WaitForCompletionAsync();
            validateTestResult(purchaseResponse, purchaseRequestContent, response.Value.Properties.ReservationOrderId);
        }

        [TestCase]
        [RecordedTest]
        public async Task TestPurchaseReservationOrderSingleScopeMonthly()
        {
            var appliedScopes = new List<string>();
            appliedScopes.Add("/subscriptions/6d5e2387-bdf5-4ca1-83db-795fd2398b93");
            purchaseRequestContent.BillingPlan = new ReservationBillingPlan("Monthly");
            purchaseRequestContent.AppliedScopeType = new AppliedScopeType("Single");
            purchaseRequestContent.AppliedScopes = appliedScopes;

            var response = await Tenant.CalculateReservationOrderAsync(purchaseRequestContent);
            var purchaseResponse = await collection.CreateOrUpdateAsync(WaitUntil.Completed, response.Value.Properties.ReservationOrderId, purchaseRequestContent);
            await purchaseResponse.WaitForCompletionAsync();
            validateTestResult(purchaseResponse, purchaseRequestContent, response.Value.Properties.ReservationOrderId);
        }

        [TestCase]
        [RecordedTest]
        public async Task TestPurchaseReservationOrderSingleScopeUpfront()
        {
            var appliedScopes = new List<string>();
            appliedScopes.Add("/subscriptions/6d5e2387-bdf5-4ca1-83db-795fd2398b93");
            purchaseRequestContent.BillingPlan = new ReservationBillingPlan("Upfront");
            purchaseRequestContent.AppliedScopeType = new AppliedScopeType("Single");
            purchaseRequestContent.AppliedScopes = appliedScopes;

            var response = await Tenant.CalculateReservationOrderAsync(purchaseRequestContent);
            var purchaseResponse = await collection.CreateOrUpdateAsync(WaitUntil.Completed, response.Value.Properties.ReservationOrderId, purchaseRequestContent);
            await purchaseResponse.WaitForCompletionAsync();
            validateTestResult(purchaseResponse, purchaseRequestContent, response.Value.Properties.ReservationOrderId);
        }

        private void validateTestResult(ArmOperation<ReservationOrderResponseResource> purchaseResponse, PurchaseRequestContent purchaseRequest, string reservationOrderId)
        {
            Assert.IsTrue(purchaseResponse.HasCompleted);
            Assert.IsTrue(purchaseResponse.HasValue);
            Assert.AreEqual(purchaseRequest.BillingPlan.ToString(), purchaseResponse.Value.Data.BillingPlan.ToString());
            Assert.AreEqual(string.Format("/providers/microsoft.capacity/reservationOrders/{0}", reservationOrderId), purchaseResponse.Value.Data.Id.ToString());
            Assert.AreEqual("Microsoft.Capacity", purchaseResponse.Value.Data.ResourceType.Namespace);
            Assert.AreEqual("reservationOrders", purchaseResponse.Value.Data.ResourceType.Type);
            Assert.AreEqual(purchaseRequest.DisplayName, purchaseResponse.Value.Data.DisplayName);
            Assert.AreEqual(reservationOrderId, purchaseResponse.Value.Data.Name);
            Assert.AreEqual(1, purchaseResponse.Value.Data.OriginalQuantity);
            Assert.AreEqual(purchaseRequest.Term.ToString(), purchaseResponse.Value.Data.Term.ToString());
            Assert.IsNotNull(purchaseResponse.Value.Data.Reservations);
            Assert.AreEqual(1, purchaseResponse.Value.Data.Reservations.Count);
        }
    }
}
