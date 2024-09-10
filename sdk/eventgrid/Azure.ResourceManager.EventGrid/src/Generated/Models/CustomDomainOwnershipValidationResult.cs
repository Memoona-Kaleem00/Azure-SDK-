// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Namespace custom domain ownership validation result. </summary>
    public partial class CustomDomainOwnershipValidationResult
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

        /// <summary> Initializes a new instance of <see cref="CustomDomainOwnershipValidationResult"/>. </summary>
        internal CustomDomainOwnershipValidationResult()
        {
            CustomDomainsForTopicsConfiguration = new ChangeTrackingList<CustomDomainConfiguration>();
            CustomDomainsForTopicSpacesConfiguration = new ChangeTrackingList<CustomDomainConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="CustomDomainOwnershipValidationResult"/>. </summary>
        /// <param name="customDomainsForTopicsConfiguration"> List of custom domain configurations for the namespace under topics configuration. </param>
        /// <param name="customDomainsForTopicSpacesConfiguration"> List of custom domain configurations for the namespace under topic spaces configuration. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomDomainOwnershipValidationResult(IReadOnlyList<CustomDomainConfiguration> customDomainsForTopicsConfiguration, IReadOnlyList<CustomDomainConfiguration> customDomainsForTopicSpacesConfiguration, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CustomDomainsForTopicsConfiguration = customDomainsForTopicsConfiguration;
            CustomDomainsForTopicSpacesConfiguration = customDomainsForTopicSpacesConfiguration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of custom domain configurations for the namespace under topics configuration. </summary>
        [WirePath("customDomainsForTopicsConfiguration")]
        public IReadOnlyList<CustomDomainConfiguration> CustomDomainsForTopicsConfiguration { get; }
        /// <summary> List of custom domain configurations for the namespace under topic spaces configuration. </summary>
        [WirePath("customDomainsForTopicSpacesConfiguration")]
        public IReadOnlyList<CustomDomainConfiguration> CustomDomainsForTopicSpacesConfiguration { get; }
    }
}
