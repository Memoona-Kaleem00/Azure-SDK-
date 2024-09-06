// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> ControlPlaneNodePatchConfiguration represents the properties of the control plane that can be patched for this Kubernetes cluster. </summary>
    public partial class ControlPlaneNodePatchConfiguration
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

        /// <summary> Initializes a new instance of <see cref="ControlPlaneNodePatchConfiguration"/>. </summary>
        public ControlPlaneNodePatchConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ControlPlaneNodePatchConfiguration"/>. </summary>
        /// <param name="administratorConfiguration"> The configuration of administrator credentials for the control plane nodes. </param>
        /// <param name="count"> The number of virtual machines that use this configuration. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ControlPlaneNodePatchConfiguration(AdministratorConfigurationPatch administratorConfiguration, long? count, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AdministratorConfiguration = administratorConfiguration;
            Count = count;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The configuration of administrator credentials for the control plane nodes. </summary>
        internal AdministratorConfigurationPatch AdministratorConfiguration { get; set; }
        /// <summary> SshPublicKey represents the public key used to authenticate with a resource through SSH. </summary>
        public IList<NetworkCloudSshPublicKey> AdministratorSshPublicKeys
        {
            get
            {
                if (AdministratorConfiguration is null)
                    AdministratorConfiguration = new AdministratorConfigurationPatch();
                return AdministratorConfiguration.SshPublicKeys;
            }
        }

        /// <summary> The number of virtual machines that use this configuration. </summary>
        public long? Count { get; set; }
    }
}
