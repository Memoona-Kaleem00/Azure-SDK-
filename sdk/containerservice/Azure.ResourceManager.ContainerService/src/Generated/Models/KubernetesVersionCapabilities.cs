// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Capabilities on this Kubernetes version. </summary>
    internal partial class KubernetesVersionCapabilities
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

        /// <summary> Initializes a new instance of <see cref="KubernetesVersionCapabilities"/>. </summary>
        internal KubernetesVersionCapabilities()
        {
            SupportPlan = new ChangeTrackingList<KubernetesSupportPlan>();
        }

        /// <summary> Initializes a new instance of <see cref="KubernetesVersionCapabilities"/>. </summary>
        /// <param name="supportPlan"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KubernetesVersionCapabilities(IReadOnlyList<KubernetesSupportPlan> supportPlan, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SupportPlan = supportPlan;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the support plan. </summary>
        public IReadOnlyList<KubernetesSupportPlan> SupportPlan { get; }
    }
}
