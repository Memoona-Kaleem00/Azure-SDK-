// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary> A private container registry. </summary>
    public partial class ContainerRegistryReference
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

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryReference"/>. </summary>
        public ContainerRegistryReference()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryReference"/>. </summary>
        /// <param name="username"> The user name to log into the registry server. </param>
        /// <param name="password"> The password to log into the registry server. </param>
        /// <param name="registryServer"> The registry URL. If omitted, the default is "docker.io". </param>
        /// <param name="identityReference"> The reference to the user assigned identity to use to access an Azure Container Registry instead of username and password. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryReference(string username, string password, string registryServer, BatchNodeIdentityReference identityReference, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Username = username;
            Password = password;
            RegistryServer = registryServer;
            IdentityReference = identityReference;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The user name to log into the registry server. </summary>
        public string Username { get; set; }
        /// <summary> The password to log into the registry server. </summary>
        public string Password { get; set; }
        /// <summary> The registry URL. If omitted, the default is "docker.io". </summary>
        public string RegistryServer { get; set; }
        /// <summary> The reference to the user assigned identity to use to access an Azure Container Registry instead of username and password. </summary>
        public BatchNodeIdentityReference IdentityReference { get; set; }
    }
}
