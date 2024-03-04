// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.SignalR.Models;

namespace Azure.ResourceManager.SignalR
{
    /// <summary>
    /// A class representing the SignalRCustomDomain data model.
    /// A custom domain
    /// </summary>
    public partial class SignalRCustomDomainData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SignalRCustomDomainData"/>. </summary>
        /// <param name="domainName"> The custom domain name. </param>
        /// <param name="customCertificate"> Reference to a resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> or <paramref name="customCertificate"/> is null. </exception>
        public SignalRCustomDomainData(string domainName, WritableSubResource customCertificate)
        {
            if (domainName == null)
            {
                throw new ArgumentNullException(nameof(domainName));
            }
            if (customCertificate == null)
            {
                throw new ArgumentNullException(nameof(customCertificate));
            }

            DomainName = domainName;
            CustomCertificate = customCertificate;
        }

        /// <summary> Initializes a new instance of <see cref="SignalRCustomDomainData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="domainName"> The custom domain name. </param>
        /// <param name="customCertificate"> Reference to a resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SignalRCustomDomainData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SignalRProvisioningState? provisioningState, string domainName, WritableSubResource customCertificate, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            DomainName = domainName;
            CustomCertificate = customCertificate;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SignalRCustomDomainData"/> for deserialization. </summary>
        internal SignalRCustomDomainData()
        {
        }

        /// <summary> Provisioning state of the resource. </summary>
        [WirePath("properties.provisioningState")]
        public SignalRProvisioningState? ProvisioningState { get; }
        /// <summary> The custom domain name. </summary>
        [WirePath("properties.domainName")]
        public string DomainName { get; set; }
        /// <summary> Reference to a resource. </summary>
        internal WritableSubResource CustomCertificate { get; set; }
        /// <summary> Gets or sets Id. </summary>
        [WirePath("properties.customCertificate.id")]
        public ResourceIdentifier CustomCertificateId
        {
            get => CustomCertificate is null ? default : CustomCertificate.Id;
            set
            {
                if (CustomCertificate is null)
                    CustomCertificate = new WritableSubResource();
                CustomCertificate.Id = value;
            }
        }
    }
}
