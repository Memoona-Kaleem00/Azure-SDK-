// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Subscription.Models
{
    /// <summary> The parameters required to create a new subscription. </summary>
    public partial class SubscriptionAliasCreateOrUpdateContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SubscriptionAliasCreateOrUpdateContent"/>. </summary>
        public SubscriptionAliasCreateOrUpdateContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SubscriptionAliasCreateOrUpdateContent"/>. </summary>
        /// <param name="displayName"> The friendly name of the subscription. </param>
        /// <param name="workload"> The workload type of the subscription. It can be either Production or DevTest. </param>
        /// <param name="billingScope">
        /// Billing scope of the subscription.
        /// For CustomerLed and FieldLed - /billingAccounts/{billingAccountName}/billingProfiles/{billingProfileName}/invoiceSections/{invoiceSectionName}
        /// For PartnerLed - /billingAccounts/{billingAccountName}/customers/{customerName}
        /// For Legacy EA - /billingAccounts/{billingAccountName}/enrollmentAccounts/{enrollmentAccountName}
        /// </param>
        /// <param name="subscriptionId"> This parameter can be used to create alias for existing subscription Id. </param>
        /// <param name="resellerId"> Reseller Id. </param>
        /// <param name="additionalProperties"> Put alias request additional properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SubscriptionAliasCreateOrUpdateContent(string displayName, SubscriptionWorkload? workload, string billingScope, string subscriptionId, string resellerId, SubscriptionAliasAdditionalProperties additionalProperties, Dictionary<string, BinaryData> rawData)
        {
            DisplayName = displayName;
            Workload = workload;
            BillingScope = billingScope;
            SubscriptionId = subscriptionId;
            ResellerId = resellerId;
            AdditionalProperties = additionalProperties;
            _rawData = rawData;
        }

        /// <summary> The friendly name of the subscription. </summary>
        public string DisplayName { get; set; }
        /// <summary> The workload type of the subscription. It can be either Production or DevTest. </summary>
        public SubscriptionWorkload? Workload { get; set; }
        /// <summary>
        /// Billing scope of the subscription.
        /// For CustomerLed and FieldLed - /billingAccounts/{billingAccountName}/billingProfiles/{billingProfileName}/invoiceSections/{invoiceSectionName}
        /// For PartnerLed - /billingAccounts/{billingAccountName}/customers/{customerName}
        /// For Legacy EA - /billingAccounts/{billingAccountName}/enrollmentAccounts/{enrollmentAccountName}
        /// </summary>
        public string BillingScope { get; set; }
        /// <summary> This parameter can be used to create alias for existing subscription Id. </summary>
        public string SubscriptionId { get; set; }
        /// <summary> Reseller Id. </summary>
        public string ResellerId { get; set; }
        /// <summary> Put alias request additional properties. </summary>
        public SubscriptionAliasAdditionalProperties AdditionalProperties { get; set; }
    }
}
