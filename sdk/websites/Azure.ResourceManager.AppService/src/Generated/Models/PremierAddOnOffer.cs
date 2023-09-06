// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Premier add-on offer. </summary>
    public partial class PremierAddOnOffer : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PremierAddOnOffer"/>. </summary>
        public PremierAddOnOffer()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PremierAddOnOffer"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="sku"> Premier add on SKU. </param>
        /// <param name="product"> Premier add on offer Product. </param>
        /// <param name="vendor"> Premier add on offer Vendor. </param>
        /// <param name="isPromoCodeRequired"> &lt;code&gt;true&lt;/code&gt; if promotion code is required; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="quota"> Premier add on offer Quota. </param>
        /// <param name="webHostingPlanRestrictions"> App Service plans this offer is restricted to. </param>
        /// <param name="privacyPolicyUri"> Privacy policy URL. </param>
        /// <param name="legalTermsUri"> Legal terms URL. </param>
        /// <param name="marketplacePublisher"> Marketplace publisher. </param>
        /// <param name="marketplaceOffer"> Marketplace offer. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PremierAddOnOffer(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string sku, string product, string vendor, bool? isPromoCodeRequired, int? quota, AppServicePlanRestriction? webHostingPlanRestrictions, Uri privacyPolicyUri, Uri legalTermsUri, string marketplacePublisher, string marketplaceOffer, string kind, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Sku = sku;
            Product = product;
            Vendor = vendor;
            IsPromoCodeRequired = isPromoCodeRequired;
            Quota = quota;
            WebHostingPlanRestrictions = webHostingPlanRestrictions;
            PrivacyPolicyUri = privacyPolicyUri;
            LegalTermsUri = legalTermsUri;
            MarketplacePublisher = marketplacePublisher;
            MarketplaceOffer = marketplaceOffer;
            Kind = kind;
            _rawData = rawData;
        }

        /// <summary> Premier add on SKU. </summary>
        public string Sku { get; set; }
        /// <summary> Premier add on offer Product. </summary>
        public string Product { get; set; }
        /// <summary> Premier add on offer Vendor. </summary>
        public string Vendor { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if promotion code is required; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsPromoCodeRequired { get; set; }
        /// <summary> Premier add on offer Quota. </summary>
        public int? Quota { get; set; }
        /// <summary> App Service plans this offer is restricted to. </summary>
        public AppServicePlanRestriction? WebHostingPlanRestrictions { get; set; }
        /// <summary> Privacy policy URL. </summary>
        public Uri PrivacyPolicyUri { get; set; }
        /// <summary> Legal terms URL. </summary>
        public Uri LegalTermsUri { get; set; }
        /// <summary> Marketplace publisher. </summary>
        public string MarketplacePublisher { get; set; }
        /// <summary> Marketplace offer. </summary>
        public string MarketplaceOffer { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
