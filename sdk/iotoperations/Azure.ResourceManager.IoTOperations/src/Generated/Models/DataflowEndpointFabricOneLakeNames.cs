// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.IoTOperations.Models
{
    /// <summary> Microsoft Fabric endpoint Names properties. </summary>
    public partial class DataflowEndpointFabricOneLakeNames
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

        /// <summary> Initializes a new instance of <see cref="DataflowEndpointFabricOneLakeNames"/>. </summary>
        /// <param name="lakehouseName"> Lakehouse name. </param>
        /// <param name="workspaceName"> Workspace name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="lakehouseName"/> or <paramref name="workspaceName"/> is null. </exception>
        public DataflowEndpointFabricOneLakeNames(string lakehouseName, string workspaceName)
        {
            Argument.AssertNotNull(lakehouseName, nameof(lakehouseName));
            Argument.AssertNotNull(workspaceName, nameof(workspaceName));

            LakehouseName = lakehouseName;
            WorkspaceName = workspaceName;
        }

        /// <summary> Initializes a new instance of <see cref="DataflowEndpointFabricOneLakeNames"/>. </summary>
        /// <param name="lakehouseName"> Lakehouse name. </param>
        /// <param name="workspaceName"> Workspace name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataflowEndpointFabricOneLakeNames(string lakehouseName, string workspaceName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LakehouseName = lakehouseName;
            WorkspaceName = workspaceName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataflowEndpointFabricOneLakeNames"/> for deserialization. </summary>
        internal DataflowEndpointFabricOneLakeNames()
        {
        }

        /// <summary> Lakehouse name. </summary>
        public string LakehouseName { get; set; }
        /// <summary> Workspace name. </summary>
        public string WorkspaceName { get; set; }
    }
}
