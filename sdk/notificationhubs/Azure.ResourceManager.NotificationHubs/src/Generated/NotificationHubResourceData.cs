// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NotificationHubs.Models;

namespace Azure.ResourceManager.NotificationHubs
{
    /// <summary> A class representing the NotificationHubResource data model. </summary>
    public partial class NotificationHubResourceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of NotificationHubResourceData. </summary>
        /// <param name="location"> The location. </param>
        public NotificationHubResourceData(AzureLocation location) : base(location)
        {
            AuthorizationRules = new ChangeTrackingList<SharedAccessAuthorizationRuleProperties>();
        }

        /// <summary> Initializes a new instance of NotificationHubResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="namePropertiesName"> The NotificationHub name. </param>
        /// <param name="registrationTtl"> The RegistrationTtl of the created NotificationHub. </param>
        /// <param name="authorizationRules"> The AuthorizationRules of the created NotificationHub. </param>
        /// <param name="apnsCredential"> The ApnsCredential of the created NotificationHub. </param>
        /// <param name="wnsCredential"> The WnsCredential of the created NotificationHub. </param>
        /// <param name="gcmCredential"> The GcmCredential of the created NotificationHub. </param>
        /// <param name="mpnsCredential"> The MpnsCredential of the created NotificationHub. </param>
        /// <param name="admCredential"> The AdmCredential of the created NotificationHub. </param>
        /// <param name="baiduCredential"> The BaiduCredential of the created NotificationHub. </param>
        /// <param name="sku"> The sku of the created namespace. </param>
        internal NotificationHubResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string namePropertiesName, string registrationTtl, IList<SharedAccessAuthorizationRuleProperties> authorizationRules, ApnsCredential apnsCredential, WnsCredential wnsCredential, GcmCredential gcmCredential, MpnsCredential mpnsCredential, AdmCredential admCredential, BaiduCredential baiduCredential, NotificationHubsSku sku) : base(id, name, resourceType, systemData, tags, location)
        {
            NamePropertiesName = namePropertiesName;
            RegistrationTtl = registrationTtl;
            AuthorizationRules = authorizationRules;
            ApnsCredential = apnsCredential;
            WnsCredential = wnsCredential;
            GcmCredential = gcmCredential;
            MpnsCredential = mpnsCredential;
            AdmCredential = admCredential;
            BaiduCredential = baiduCredential;
            Sku = sku;
        }

        /// <summary> The NotificationHub name. </summary>
        public string NamePropertiesName { get; set; }
        /// <summary> The RegistrationTtl of the created NotificationHub. </summary>
        public string RegistrationTtl { get; set; }
        /// <summary> The AuthorizationRules of the created NotificationHub. </summary>
        public IList<SharedAccessAuthorizationRuleProperties> AuthorizationRules { get; }
        /// <summary> The ApnsCredential of the created NotificationHub. </summary>
        public ApnsCredential ApnsCredential { get; set; }
        /// <summary> The WnsCredential of the created NotificationHub. </summary>
        public WnsCredential WnsCredential { get; set; }
        /// <summary> The GcmCredential of the created NotificationHub. </summary>
        public GcmCredential GcmCredential { get; set; }
        /// <summary> The MpnsCredential of the created NotificationHub. </summary>
        public MpnsCredential MpnsCredential { get; set; }
        /// <summary> The AdmCredential of the created NotificationHub. </summary>
        public AdmCredential AdmCredential { get; set; }
        /// <summary> The BaiduCredential of the created NotificationHub. </summary>
        public BaiduCredential BaiduCredential { get; set; }
        /// <summary> The sku of the created namespace. </summary>
        public NotificationHubsSku Sku { get; set; }
    }
}
