// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents a repository. </summary>
    public partial class SourceControlRepo
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

        /// <summary> Initializes a new instance of <see cref="SourceControlRepo"/>. </summary>
        internal SourceControlRepo()
        {
            Branches = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SourceControlRepo"/>. </summary>
        /// <param name="uri"> The url to access the repository. </param>
        /// <param name="fullName"> The name of the repository. </param>
        /// <param name="installationId"> The installation id of the repository. </param>
        /// <param name="branches"> Array of branches. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SourceControlRepo(Uri uri, string fullName, long? installationId, IReadOnlyList<string> branches, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Uri = uri;
            FullName = fullName;
            InstallationId = installationId;
            Branches = branches;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The url to access the repository. </summary>
        [WirePath("url")]
        public Uri Uri { get; }
        /// <summary> The name of the repository. </summary>
        [WirePath("fullName")]
        public string FullName { get; }
        /// <summary> The installation id of the repository. </summary>
        [WirePath("installationId")]
        public long? InstallationId { get; }
        /// <summary> Array of branches. </summary>
        [WirePath("branches")]
        public IReadOnlyList<string> Branches { get; }
    }
}
