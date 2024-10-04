// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.InformaticaDataManagement.Models
{
    /// <summary> The ServerlessRuntimeUserContextProperties. </summary>
    internal partial class ServerlessRuntimeUserContextProperties
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

        /// <summary> Initializes a new instance of <see cref="ServerlessRuntimeUserContextProperties"/>. </summary>
        /// <param name="userContextToken"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="userContextToken"/> is null. </exception>
        public ServerlessRuntimeUserContextProperties(string userContextToken)
        {
            Argument.AssertNotNull(userContextToken, nameof(userContextToken));

            UserContextToken = userContextToken;
        }

        /// <summary> Initializes a new instance of <see cref="ServerlessRuntimeUserContextProperties"/>. </summary>
        /// <param name="userContextToken"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServerlessRuntimeUserContextProperties(string userContextToken, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            UserContextToken = userContextToken;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ServerlessRuntimeUserContextProperties"/> for deserialization. </summary>
        internal ServerlessRuntimeUserContextProperties()
        {
        }

        /// <summary> Gets or sets the user context token. </summary>
        public string UserContextToken { get; set; }
    }
}
