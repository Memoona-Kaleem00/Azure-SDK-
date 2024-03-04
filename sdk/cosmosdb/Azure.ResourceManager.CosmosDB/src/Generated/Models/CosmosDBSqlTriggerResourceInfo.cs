// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB SQL trigger resource object. </summary>
    public partial class CosmosDBSqlTriggerResourceInfo
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CosmosDBSqlTriggerResourceInfo"/>. </summary>
        /// <param name="triggerName"> Name of the Cosmos DB SQL trigger. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public CosmosDBSqlTriggerResourceInfo(string triggerName)
        {
            if (triggerName == null)
            {
                throw new ArgumentNullException(nameof(triggerName));
            }

            TriggerName = triggerName;
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBSqlTriggerResourceInfo"/>. </summary>
        /// <param name="triggerName"> Name of the Cosmos DB SQL trigger. </param>
        /// <param name="body"> Body of the Trigger. </param>
        /// <param name="triggerType"> Type of the Trigger. </param>
        /// <param name="triggerOperation"> The operation the trigger is associated with. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CosmosDBSqlTriggerResourceInfo(string triggerName, string body, CosmosDBSqlTriggerType? triggerType, CosmosDBSqlTriggerOperation? triggerOperation, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TriggerName = triggerName;
            Body = body;
            TriggerType = triggerType;
            TriggerOperation = triggerOperation;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBSqlTriggerResourceInfo"/> for deserialization. </summary>
        internal CosmosDBSqlTriggerResourceInfo()
        {
        }

        /// <summary> Name of the Cosmos DB SQL trigger. </summary>
        [WirePath("id")]
        public string TriggerName { get; set; }
        /// <summary> Body of the Trigger. </summary>
        [WirePath("body")]
        public string Body { get; set; }
        /// <summary> Type of the Trigger. </summary>
        [WirePath("triggerType")]
        public CosmosDBSqlTriggerType? TriggerType { get; set; }
        /// <summary> The operation the trigger is associated with. </summary>
        [WirePath("triggerOperation")]
        public CosmosDBSqlTriggerOperation? TriggerOperation { get; set; }
    }
}
