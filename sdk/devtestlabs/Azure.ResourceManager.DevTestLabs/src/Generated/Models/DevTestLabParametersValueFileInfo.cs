// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> A file containing a set of parameter values for an ARM template. </summary>
    public partial class DevTestLabParametersValueFileInfo
    {
        /// <summary> Initializes a new instance of DevTestLabParametersValueFileInfo. </summary>
        internal DevTestLabParametersValueFileInfo()
        {
        }

        /// <summary> Initializes a new instance of DevTestLabParametersValueFileInfo. </summary>
        /// <param name="fileName"> File name. </param>
        /// <param name="parametersValueInfo"> Contents of the file. </param>
        internal DevTestLabParametersValueFileInfo(string fileName, BinaryData parametersValueInfo)
        {
            FileName = fileName;
            ParametersValueInfo = parametersValueInfo;
        }

        /// <summary> File name. </summary>
        public string FileName { get; }
        /// <summary>
        /// Contents of the file.
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
        public BinaryData ParametersValueInfo { get; }
    }
}
