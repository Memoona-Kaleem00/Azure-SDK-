// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The authorization properties for accessing the source code repository. </summary>
    public partial class SourceCodeRepoAuthInfoUpdateContent
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

        /// <summary> Initializes a new instance of <see cref="SourceCodeRepoAuthInfoUpdateContent"/>. </summary>
        public SourceCodeRepoAuthInfoUpdateContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SourceCodeRepoAuthInfoUpdateContent"/>. </summary>
        /// <param name="tokenType"> The type of Auth token. </param>
        /// <param name="token"> The access token used to access the source control provider. </param>
        /// <param name="refreshToken"> The refresh token used to refresh the access token. </param>
        /// <param name="scope"> The scope of the access token. </param>
        /// <param name="expiresIn"> Time in seconds that the token remains valid. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SourceCodeRepoAuthInfoUpdateContent(SourceCodeRepoAuthTokenType? tokenType, string token, string refreshToken, string scope, int? expiresIn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TokenType = tokenType;
            Token = token;
            RefreshToken = refreshToken;
            Scope = scope;
            ExpiresIn = expiresIn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The type of Auth token. </summary>
        [WirePath("tokenType")]
        public SourceCodeRepoAuthTokenType? TokenType { get; set; }
        /// <summary> The access token used to access the source control provider. </summary>
        [WirePath("token")]
        public string Token { get; set; }
        /// <summary> The refresh token used to refresh the access token. </summary>
        [WirePath("refreshToken")]
        public string RefreshToken { get; set; }
        /// <summary> The scope of the access token. </summary>
        [WirePath("scope")]
        public string Scope { get; set; }
        /// <summary> Time in seconds that the token remains valid. </summary>
        [WirePath("expiresIn")]
        public int? ExpiresIn { get; set; }
    }
}
