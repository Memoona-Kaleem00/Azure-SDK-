// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> A telephone number for the Telephony channel. </summary>
    public partial class TelephonyPhoneNumbers
    {
        /// <summary> Initializes a new instance of <see cref="TelephonyPhoneNumbers"/>. </summary>
        public TelephonyPhoneNumbers()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TelephonyPhoneNumbers"/>. </summary>
        /// <param name="id"> The element id. </param>
        /// <param name="phoneNumber"> The phone number. </param>
        /// <param name="acsEndpoint"> The endpoint of ACS. </param>
        /// <param name="acsSecret"> The secret of ACS. </param>
        /// <param name="acsResourceId"> The resource id of ACS. </param>
        /// <param name="cognitiveServiceSubscriptionKey"> The subscription key of cognitive service. </param>
        /// <param name="cognitiveServiceRegion"> The service region of cognitive service. </param>
        /// <param name="cognitiveServiceResourceId"> The resource id of cognitive service. </param>
        /// <param name="defaultLocale"> The default locale of the phone number. </param>
        /// <param name="offerType"> Optional Property that will determine the offering type of the phone. </param>
        internal TelephonyPhoneNumbers(string id, string phoneNumber, string acsEndpoint, string acsSecret, ResourceIdentifier acsResourceId, string cognitiveServiceSubscriptionKey, string cognitiveServiceRegion, ResourceIdentifier cognitiveServiceResourceId, string defaultLocale, string offerType)
        {
            Id = id;
            PhoneNumber = phoneNumber;
            AcsEndpoint = acsEndpoint;
            AcsSecret = acsSecret;
            AcsResourceId = acsResourceId;
            CognitiveServiceSubscriptionKey = cognitiveServiceSubscriptionKey;
            CognitiveServiceRegion = cognitiveServiceRegion;
            CognitiveServiceResourceId = cognitiveServiceResourceId;
            DefaultLocale = defaultLocale;
            OfferType = offerType;
        }

        /// <summary> The element id. </summary>
        public string Id { get; set; }
        /// <summary> The phone number. </summary>
        public string PhoneNumber { get; set; }
        /// <summary> The endpoint of ACS. </summary>
        public string AcsEndpoint { get; set; }
        /// <summary> The secret of ACS. </summary>
        public string AcsSecret { get; set; }
        /// <summary> The resource id of ACS. </summary>
        public ResourceIdentifier AcsResourceId { get; set; }
        /// <summary> The subscription key of cognitive service. </summary>
        public string CognitiveServiceSubscriptionKey { get; set; }
        /// <summary> The service region of cognitive service. </summary>
        public string CognitiveServiceRegion { get; set; }
        /// <summary> The resource id of cognitive service. </summary>
        public ResourceIdentifier CognitiveServiceResourceId { get; set; }
        /// <summary> The default locale of the phone number. </summary>
        public string DefaultLocale { get; set; }
        /// <summary> Optional Property that will determine the offering type of the phone. </summary>
        public string OfferType { get; set; }
    }
}
