// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Managed application locking policy. </summary>
    public partial class ArmApplicationPackageLockingPolicy
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

        /// <summary> Initializes a new instance of <see cref="ArmApplicationPackageLockingPolicy"/>. </summary>
        public ArmApplicationPackageLockingPolicy()
        {
            AllowedActions = new ChangeTrackingList<string>();
            AllowedDataActions = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ArmApplicationPackageLockingPolicy"/>. </summary>
        /// <param name="allowedActions"> The deny assignment excluded actions. </param>
        /// <param name="allowedDataActions"> The deny assignment excluded data actions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ArmApplicationPackageLockingPolicy(IList<string> allowedActions, IList<string> allowedDataActions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AllowedActions = allowedActions;
            AllowedDataActions = allowedDataActions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The deny assignment excluded actions. </summary>
        public IList<string> AllowedActions { get; }
        /// <summary> The deny assignment excluded data actions. </summary>
        public IList<string> AllowedDataActions { get; }
    }
}
