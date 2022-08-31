// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> Request to split a billing subscription. </summary>
    public partial class BillingSubscriptionSplitContent
    {
        /// <summary> Initializes a new instance of BillingSubscriptionSplitContent. </summary>
        public BillingSubscriptionSplitContent()
        {
        }

        /// <summary> The billing frequency of the target subscription in the ISO8601 format. Example: P1M, P3M, P1Y. </summary>
        public string BillingFrequency { get; set; }
        /// <summary> The quantity of the target product to which the subscription needs to be split into. </summary>
        public int? Quantity { get; set; }
        /// <summary> The ID of the target product to which the subscription needs to be split into. This value is not same as the value returned in Get API call and can be retrieved from Catalog API to know the product id to split into. </summary>
        public string TargetProductTypeId { get; set; }
        /// <summary> The ID of the target product to which the subscription needs to be split into. This value is not same as the value returned in Get API call and can be retrieved from Catalog API to know the sku id to split into. </summary>
        public string TargetSkuId { get; set; }
        /// <summary> The term duration of the target in ISO8601 format product to which the subscription needs to be split into. Example: P1M, P1Y. </summary>
        public TimeSpan? TermDuration { get; set; }
    }
}
