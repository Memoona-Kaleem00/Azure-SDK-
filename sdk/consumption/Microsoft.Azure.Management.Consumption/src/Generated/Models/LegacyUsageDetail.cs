// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Consumption.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Legacy usage detail.
    /// </summary>
    [Newtonsoft.Json.JsonObject("legacy")]
    [Rest.Serialization.JsonTransformation]
    public partial class LegacyUsageDetail : UsageDetail
    {
        /// <summary>
        /// Initializes a new instance of the LegacyUsageDetail class.
        /// </summary>
        public LegacyUsageDetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LegacyUsageDetail class.
        /// </summary>
        /// <param name="id">The full qualified ARM ID of an event.</param>
        /// <param name="name">The ID that uniquely identifies an event.
        /// </param>
        /// <param name="type">Resource type.</param>
        /// <param name="etag">The etag for the resource.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="billingAccountId">Billing Account identifier.</param>
        /// <param name="billingAccountName">Billing Account Name.</param>
        /// <param name="billingPeriodStartDate">The billing period start
        /// date.</param>
        /// <param name="billingPeriodEndDate">The billing period end
        /// date.</param>
        /// <param name="billingProfileId">Billing Profile identifier.</param>
        /// <param name="billingProfileName">Billing Profile Name.</param>
        /// <param name="accountOwnerId">Account Owner Id.</param>
        /// <param name="accountName">Account Name.</param>
        /// <param name="subscriptionId">Subscription guid.</param>
        /// <param name="subscriptionName">Subscription name.</param>
        /// <param name="date">Date for the usage record.</param>
        /// <param name="product">Product name for the consumed service or
        /// purchase. Not available for Marketplace.</param>
        /// <param name="partNumber">Part Number of the service used. Can be
        /// used to join with the price sheet. Not available for
        /// marketplace.</param>
        /// <param name="meterId">The meter id (GUID). Not available for
        /// marketplace. For reserved instance this represents the primary
        /// meter for which the reservation was purchased. For the actual VM
        /// Size for which the reservation is purchased see
        /// productOrderName.</param>
        /// <param name="meterDetails">The details about the meter. By default
        /// this is not populated, unless it's specified in $expand.</param>
        /// <param name="quantity">The usage quantity.</param>
        /// <param name="effectivePrice">Effective Price that's charged for the
        /// usage.</param>
        /// <param name="cost">The amount of cost before tax.</param>
        /// <param name="unitPrice">Unit Price is the price applicable to you.
        /// (your EA or other contract price).</param>
        /// <param name="billingCurrency">Billing Currency.</param>
        /// <param name="resourceLocation">Resource Location.</param>
        /// <param name="consumedService">Consumed service name. Name of the
        /// azure resource provider that emits the usage or was purchased. This
        /// value is not provided for marketplace usage.</param>
        /// <param name="resourceId">Unique identifier of the Azure Resource
        /// Manager usage detail resource.</param>
        /// <param name="resourceName">Resource Name.</param>
        /// <param name="serviceInfo1">Service-specific metadata.</param>
        /// <param name="serviceInfo2">Legacy field with optional
        /// service-specific metadata.</param>
        /// <param name="additionalInfo">Additional details of this usage item.
        /// By default this is not populated, unless it's specified in $expand.
        /// Use this field to get usage line item specific details such as the
        /// actual VM Size (ServiceType) or the ratio in which the reservation
        /// discount is applied.</param>
        /// <param name="invoiceSection">Invoice Section Name.</param>
        /// <param name="costCenter">The cost center of this department if it
        /// is a department and a cost center is provided.</param>
        /// <param name="resourceGroup">Resource Group Name.</param>
        /// <param name="reservationId">ARM resource id of the reservation.
        /// Only applies to records relevant to reservations.</param>
        /// <param name="reservationName">User provided display name of the
        /// reservation. Last known name for a particular day is populated in
        /// the daily data. Only applies to records relevant to
        /// reservations.</param>
        /// <param name="productOrderId">Product Order Id. For reservations
        /// this is the Reservation Order ID.</param>
        /// <param name="productOrderName">Product Order Name. For reservations
        /// this is the SKU that was purchased.</param>
        /// <param name="offerId">Offer Id. Ex: MS-AZR-0017P,
        /// MS-AZR-0148P.</param>
        /// <param name="isAzureCreditEligible">Is Azure Credit
        /// Eligible.</param>
        /// <param name="term">Term (in months). 1 month for monthly recurring
        /// purchase. 12 months for a 1 year reservation. 36 months for a 3
        /// year reservation.</param>
        /// <param name="publisherName">Publisher Name.</param>
        /// <param name="publisherType">Publisher Type.</param>
        /// <param name="planName">Plan Name.</param>
        /// <param name="chargeType">Indicates a charge represents credits,
        /// usage, a Marketplace purchase, a reservation fee, or a
        /// refund.</param>
        /// <param name="frequency">Indicates how frequently this charge will
        /// occur. OneTime for purchases which only happen once, Monthly for
        /// fees which recur every month, and UsageBased for charges based on
        /// how much a service is used.</param>
        public LegacyUsageDetail(string id = default(string), string name = default(string), string type = default(string), string etag = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string billingAccountId = default(string), string billingAccountName = default(string), System.DateTime? billingPeriodStartDate = default(System.DateTime?), System.DateTime? billingPeriodEndDate = default(System.DateTime?), string billingProfileId = default(string), string billingProfileName = default(string), string accountOwnerId = default(string), string accountName = default(string), string subscriptionId = default(string), string subscriptionName = default(string), System.DateTime? date = default(System.DateTime?), string product = default(string), string partNumber = default(string), System.Guid? meterId = default(System.Guid?), MeterDetailsResponse meterDetails = default(MeterDetailsResponse), decimal? quantity = default(decimal?), decimal? effectivePrice = default(decimal?), decimal? cost = default(decimal?), decimal? unitPrice = default(decimal?), string billingCurrency = default(string), string resourceLocation = default(string), string consumedService = default(string), string resourceId = default(string), string resourceName = default(string), string serviceInfo1 = default(string), string serviceInfo2 = default(string), string additionalInfo = default(string), string invoiceSection = default(string), string costCenter = default(string), string resourceGroup = default(string), string reservationId = default(string), string reservationName = default(string), string productOrderId = default(string), string productOrderName = default(string), string offerId = default(string), bool? isAzureCreditEligible = default(bool?), string term = default(string), string publisherName = default(string), string publisherType = default(string), string planName = default(string), string chargeType = default(string), string frequency = default(string))
            : base(id, name, type, etag, tags)
        {
            BillingAccountId = billingAccountId;
            BillingAccountName = billingAccountName;
            BillingPeriodStartDate = billingPeriodStartDate;
            BillingPeriodEndDate = billingPeriodEndDate;
            BillingProfileId = billingProfileId;
            BillingProfileName = billingProfileName;
            AccountOwnerId = accountOwnerId;
            AccountName = accountName;
            SubscriptionId = subscriptionId;
            SubscriptionName = subscriptionName;
            Date = date;
            Product = product;
            PartNumber = partNumber;
            MeterId = meterId;
            MeterDetails = meterDetails;
            Quantity = quantity;
            EffectivePrice = effectivePrice;
            Cost = cost;
            UnitPrice = unitPrice;
            BillingCurrency = billingCurrency;
            ResourceLocation = resourceLocation;
            ConsumedService = consumedService;
            ResourceId = resourceId;
            ResourceName = resourceName;
            ServiceInfo1 = serviceInfo1;
            ServiceInfo2 = serviceInfo2;
            AdditionalInfo = additionalInfo;
            InvoiceSection = invoiceSection;
            CostCenter = costCenter;
            ResourceGroup = resourceGroup;
            ReservationId = reservationId;
            ReservationName = reservationName;
            ProductOrderId = productOrderId;
            ProductOrderName = productOrderName;
            OfferId = offerId;
            IsAzureCreditEligible = isAzureCreditEligible;
            Term = term;
            PublisherName = publisherName;
            PublisherType = publisherType;
            PlanName = planName;
            ChargeType = chargeType;
            Frequency = frequency;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets billing Account identifier.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingAccountId")]
        public string BillingAccountId { get; private set; }

        /// <summary>
        /// Gets billing Account Name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingAccountName")]
        public string BillingAccountName { get; private set; }

        /// <summary>
        /// Gets the billing period start date.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingPeriodStartDate")]
        public System.DateTime? BillingPeriodStartDate { get; private set; }

        /// <summary>
        /// Gets the billing period end date.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingPeriodEndDate")]
        public System.DateTime? BillingPeriodEndDate { get; private set; }

        /// <summary>
        /// Gets billing Profile identifier.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingProfileId")]
        public string BillingProfileId { get; private set; }

        /// <summary>
        /// Gets billing Profile Name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingProfileName")]
        public string BillingProfileName { get; private set; }

        /// <summary>
        /// Gets account Owner Id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.accountOwnerId")]
        public string AccountOwnerId { get; private set; }

        /// <summary>
        /// Gets account Name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.accountName")]
        public string AccountName { get; private set; }

        /// <summary>
        /// Gets subscription guid.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subscriptionId")]
        public string SubscriptionId { get; private set; }

        /// <summary>
        /// Gets subscription name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subscriptionName")]
        public string SubscriptionName { get; private set; }

        /// <summary>
        /// Gets date for the usage record.
        /// </summary>
        [JsonProperty(PropertyName = "properties.date")]
        public System.DateTime? Date { get; private set; }

        /// <summary>
        /// Gets product name for the consumed service or purchase. Not
        /// available for Marketplace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.product")]
        public string Product { get; private set; }

        /// <summary>
        /// Gets part Number of the service used. Can be used to join with the
        /// price sheet. Not available for marketplace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.partNumber")]
        public string PartNumber { get; private set; }

        /// <summary>
        /// Gets the meter id (GUID). Not available for marketplace. For
        /// reserved instance this represents the primary meter for which the
        /// reservation was purchased. For the actual VM Size for which the
        /// reservation is purchased see productOrderName.
        /// </summary>
        [JsonProperty(PropertyName = "properties.meterId")]
        public System.Guid? MeterId { get; private set; }

        /// <summary>
        /// Gets the details about the meter. By default this is not populated,
        /// unless it's specified in $expand.
        /// </summary>
        [JsonProperty(PropertyName = "properties.meterDetails")]
        public MeterDetailsResponse MeterDetails { get; private set; }

        /// <summary>
        /// Gets the usage quantity.
        /// </summary>
        [JsonProperty(PropertyName = "properties.quantity")]
        public decimal? Quantity { get; private set; }

        /// <summary>
        /// Gets effective Price that's charged for the usage.
        /// </summary>
        [JsonProperty(PropertyName = "properties.effectivePrice")]
        public decimal? EffectivePrice { get; private set; }

        /// <summary>
        /// Gets the amount of cost before tax.
        /// </summary>
        [JsonProperty(PropertyName = "properties.cost")]
        public decimal? Cost { get; private set; }

        /// <summary>
        /// Gets unit Price is the price applicable to you. (your EA or other
        /// contract price).
        /// </summary>
        [JsonProperty(PropertyName = "properties.unitPrice")]
        public decimal? UnitPrice { get; private set; }

        /// <summary>
        /// Gets billing Currency.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingCurrency")]
        public string BillingCurrency { get; private set; }

        /// <summary>
        /// Gets resource Location.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceLocation")]
        public string ResourceLocation { get; private set; }

        /// <summary>
        /// Gets consumed service name. Name of the azure resource provider
        /// that emits the usage or was purchased. This value is not provided
        /// for marketplace usage.
        /// </summary>
        [JsonProperty(PropertyName = "properties.consumedService")]
        public string ConsumedService { get; private set; }

        /// <summary>
        /// Gets unique identifier of the Azure Resource Manager usage detail
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceId")]
        public string ResourceId { get; private set; }

        /// <summary>
        /// Gets resource Name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceName")]
        public string ResourceName { get; private set; }

        /// <summary>
        /// Gets service-specific metadata.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceInfo1")]
        public string ServiceInfo1 { get; private set; }

        /// <summary>
        /// Gets legacy field with optional service-specific metadata.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceInfo2")]
        public string ServiceInfo2 { get; private set; }

        /// <summary>
        /// Gets additional details of this usage item. By default this is not
        /// populated, unless it's specified in $expand. Use this field to get
        /// usage line item specific details such as the actual VM Size
        /// (ServiceType) or the ratio in which the reservation discount is
        /// applied.
        /// </summary>
        [JsonProperty(PropertyName = "properties.additionalInfo")]
        public string AdditionalInfo { get; private set; }

        /// <summary>
        /// Gets invoice Section Name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.invoiceSection")]
        public string InvoiceSection { get; private set; }

        /// <summary>
        /// Gets the cost center of this department if it is a department and a
        /// cost center is provided.
        /// </summary>
        [JsonProperty(PropertyName = "properties.costCenter")]
        public string CostCenter { get; private set; }

        /// <summary>
        /// Gets resource Group Name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGroup")]
        public string ResourceGroup { get; private set; }

        /// <summary>
        /// Gets ARM resource id of the reservation. Only applies to records
        /// relevant to reservations.
        /// </summary>
        [JsonProperty(PropertyName = "properties.reservationId")]
        public string ReservationId { get; private set; }

        /// <summary>
        /// Gets user provided display name of the reservation. Last known name
        /// for a particular day is populated in the daily data. Only applies
        /// to records relevant to reservations.
        /// </summary>
        [JsonProperty(PropertyName = "properties.reservationName")]
        public string ReservationName { get; private set; }

        /// <summary>
        /// Gets product Order Id. For reservations this is the Reservation
        /// Order ID.
        /// </summary>
        [JsonProperty(PropertyName = "properties.productOrderId")]
        public string ProductOrderId { get; private set; }

        /// <summary>
        /// Gets product Order Name. For reservations this is the SKU that was
        /// purchased.
        /// </summary>
        [JsonProperty(PropertyName = "properties.productOrderName")]
        public string ProductOrderName { get; private set; }

        /// <summary>
        /// Gets offer Id. Ex: MS-AZR-0017P, MS-AZR-0148P.
        /// </summary>
        [JsonProperty(PropertyName = "properties.offerId")]
        public string OfferId { get; private set; }

        /// <summary>
        /// Gets is Azure Credit Eligible.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isAzureCreditEligible")]
        public bool? IsAzureCreditEligible { get; private set; }

        /// <summary>
        /// Gets term (in months). 1 month for monthly recurring purchase. 12
        /// months for a 1 year reservation. 36 months for a 3 year
        /// reservation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.term")]
        public string Term { get; private set; }

        /// <summary>
        /// Gets publisher Name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publisherName")]
        public string PublisherName { get; private set; }

        /// <summary>
        /// Gets publisher Type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publisherType")]
        public string PublisherType { get; private set; }

        /// <summary>
        /// Gets plan Name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.planName")]
        public string PlanName { get; private set; }

        /// <summary>
        /// Gets indicates a charge represents credits, usage, a Marketplace
        /// purchase, a reservation fee, or a refund.
        /// </summary>
        [JsonProperty(PropertyName = "properties.chargeType")]
        public string ChargeType { get; private set; }

        /// <summary>
        /// Gets indicates how frequently this charge will occur. OneTime for
        /// purchases which only happen once, Monthly for fees which recur
        /// every month, and UsageBased for charges based on how much a service
        /// is used.
        /// </summary>
        [JsonProperty(PropertyName = "properties.frequency")]
        public string Frequency { get; private set; }

    }
}
