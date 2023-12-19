// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.Messages
{
    /// <summary> The WhatsApp-specific template response contract. </summary>
    public partial class WhatsAppMessageTemplateResult
    {
        /// <summary> Initializes a new instance of <see cref="WhatsAppMessageTemplateResult"/>. </summary>
        internal WhatsAppMessageTemplateResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WhatsAppMessageTemplateResult"/>. </summary>
        /// <param name="content">
        /// WhatsApp platform's template content
        /// This is the payload returned from WhatsApp
        /// API.
        /// </param>
        internal WhatsAppMessageTemplateResult(BinaryData content)
        {
            Content = content;
        }

        /// <summary>
        /// WhatsApp platform's template content
        /// This is the payload returned from WhatsApp
        /// API.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData Content { get; }
    }
}
