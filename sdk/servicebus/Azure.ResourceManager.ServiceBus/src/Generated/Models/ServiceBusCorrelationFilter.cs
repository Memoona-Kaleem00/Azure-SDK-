// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.ServiceBus;

namespace Azure.ResourceManager.ServiceBus.Models
{
    /// <summary> Represents the correlation filter expression. </summary>
    public partial class ServiceBusCorrelationFilter
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

        /// <summary> Initializes a new instance of <see cref="ServiceBusCorrelationFilter"/>. </summary>
        public ServiceBusCorrelationFilter()
        {
            ApplicationProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of <see cref="ServiceBusCorrelationFilter"/>. </summary>
        /// <param name="applicationProperties"> dictionary object for custom filters. </param>
        /// <param name="correlationId"> Identifier of the correlation. </param>
        /// <param name="messageId"> Identifier of the message. </param>
        /// <param name="sendTo"> Address to send to. </param>
        /// <param name="replyTo"> Address of the queue to reply to. </param>
        /// <param name="subject"> Application specific label. </param>
        /// <param name="sessionId"> Session identifier. </param>
        /// <param name="replyToSessionId"> Session identifier to reply to. </param>
        /// <param name="contentType"> Content type of the message. </param>
        /// <param name="requiresPreprocessing"> Value that indicates whether the rule action requires preprocessing. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceBusCorrelationFilter(IDictionary<string, object> applicationProperties, string correlationId, string messageId, string sendTo, string replyTo, string subject, string sessionId, string replyToSessionId, string contentType, bool? requiresPreprocessing, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ApplicationProperties = applicationProperties;
            CorrelationId = correlationId;
            MessageId = messageId;
            SendTo = sendTo;
            ReplyTo = replyTo;
            Subject = subject;
            SessionId = sessionId;
            ReplyToSessionId = replyToSessionId;
            ContentType = contentType;
            RequiresPreprocessing = requiresPreprocessing;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> dictionary object for custom filters. </summary>
        public IDictionary<string, object> ApplicationProperties { get; }
        /// <summary> Identifier of the correlation. </summary>
        public string CorrelationId { get; set; }
        /// <summary> Identifier of the message. </summary>
        public string MessageId { get; set; }
        /// <summary> Address to send to. </summary>
        public string SendTo { get; set; }
        /// <summary> Address of the queue to reply to. </summary>
        public string ReplyTo { get; set; }
        /// <summary> Application specific label. </summary>
        public string Subject { get; set; }
        /// <summary> Session identifier. </summary>
        public string SessionId { get; set; }
        /// <summary> Session identifier to reply to. </summary>
        public string ReplyToSessionId { get; set; }
        /// <summary> Content type of the message. </summary>
        public string ContentType { get; set; }
        /// <summary> Value that indicates whether the rule action requires preprocessing. </summary>
        public bool? RequiresPreprocessing { get; set; }
    }
}
