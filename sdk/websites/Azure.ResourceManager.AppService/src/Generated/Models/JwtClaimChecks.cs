// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the checks that should be made while validating the JWT Claims. </summary>
    public partial class JwtClaimChecks
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

        /// <summary> Initializes a new instance of <see cref="JwtClaimChecks"/>. </summary>
        public JwtClaimChecks()
        {
            AllowedGroups = new ChangeTrackingList<string>();
            AllowedClientApplications = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="JwtClaimChecks"/>. </summary>
        /// <param name="allowedGroups"> The list of the allowed groups. </param>
        /// <param name="allowedClientApplications"> The list of the allowed client applications. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal JwtClaimChecks(IList<string> allowedGroups, IList<string> allowedClientApplications, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AllowedGroups = allowedGroups;
            AllowedClientApplications = allowedClientApplications;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of the allowed groups. </summary>
        public IList<string> AllowedGroups { get; }
        /// <summary> The list of the allowed client applications. </summary>
        public IList<string> AllowedClientApplications { get; }
    }
}
