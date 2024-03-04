// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Redis.Models
{
    /// <summary> Parameters for Redis export operation. </summary>
    public partial class ExportRdbContent
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

        /// <summary> Initializes a new instance of <see cref="ExportRdbContent"/>. </summary>
        /// <param name="prefix"> Prefix to use for exported files. </param>
        /// <param name="container"> Container name to export to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="prefix"/> or <paramref name="container"/> is null. </exception>
        public ExportRdbContent(string prefix, string container)
        {
            if (prefix == null)
            {
                throw new ArgumentNullException(nameof(prefix));
            }
            if (container == null)
            {
                throw new ArgumentNullException(nameof(container));
            }

            Prefix = prefix;
            Container = container;
        }

        /// <summary> Initializes a new instance of <see cref="ExportRdbContent"/>. </summary>
        /// <param name="format"> File format. </param>
        /// <param name="prefix"> Prefix to use for exported files. </param>
        /// <param name="container"> Container name to export to. </param>
        /// <param name="preferredDataArchiveAuthMethod"> Preferred auth method to communicate to storage account used for data archive, specify SAS or ManagedIdentity, default value is SAS. </param>
        /// <param name="storageSubscriptionId"> Subscription id of the storage container for data to be exported using ManagedIdentity. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExportRdbContent(string format, string prefix, string container, string preferredDataArchiveAuthMethod, string storageSubscriptionId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Format = format;
            Prefix = prefix;
            Container = container;
            PreferredDataArchiveAuthMethod = preferredDataArchiveAuthMethod;
            StorageSubscriptionId = storageSubscriptionId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ExportRdbContent"/> for deserialization. </summary>
        internal ExportRdbContent()
        {
        }

        /// <summary> File format. </summary>
        [WirePath("format")]
        public string Format { get; set; }
        /// <summary> Prefix to use for exported files. </summary>
        [WirePath("prefix")]
        public string Prefix { get; }
        /// <summary> Container name to export to. </summary>
        [WirePath("container")]
        public string Container { get; }
        /// <summary> Preferred auth method to communicate to storage account used for data archive, specify SAS or ManagedIdentity, default value is SAS. </summary>
        [WirePath("preferred-data-archive-auth-method")]
        public string PreferredDataArchiveAuthMethod { get; set; }
        /// <summary> Subscription id of the storage container for data to be exported using ManagedIdentity. </summary>
        [WirePath("storage-subscription-id")]
        public string StorageSubscriptionId { get; set; }
    }
}
