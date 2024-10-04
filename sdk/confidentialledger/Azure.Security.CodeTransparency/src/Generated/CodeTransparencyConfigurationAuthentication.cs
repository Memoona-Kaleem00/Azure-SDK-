// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Security.CodeTransparency
{
    /// <summary> The CodeTransparencyConfigurationAuthentication. </summary>
    public partial class CodeTransparencyConfigurationAuthentication
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

        /// <summary> Initializes a new instance of <see cref="CodeTransparencyConfigurationAuthentication"/>. </summary>
        /// <param name="allowUnauthenticated"></param>
        internal CodeTransparencyConfigurationAuthentication(bool allowUnauthenticated)
        {
            AllowUnauthenticated = allowUnauthenticated;
        }

        /// <summary> Initializes a new instance of <see cref="CodeTransparencyConfigurationAuthentication"/>. </summary>
        /// <param name="allowUnauthenticated"></param>
        /// <param name="jwt"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CodeTransparencyConfigurationAuthentication(bool allowUnauthenticated, CodeTransparencyConfigurationAuthenticationJwt jwt, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AllowUnauthenticated = allowUnauthenticated;
            Jwt = jwt;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CodeTransparencyConfigurationAuthentication"/> for deserialization. </summary>
        internal CodeTransparencyConfigurationAuthentication()
        {
        }

        /// <summary> Gets the allow unauthenticated. </summary>
        public bool AllowUnauthenticated { get; }
        /// <summary> Gets the jwt. </summary>
        public CodeTransparencyConfigurationAuthenticationJwt Jwt { get; }
    }
}
