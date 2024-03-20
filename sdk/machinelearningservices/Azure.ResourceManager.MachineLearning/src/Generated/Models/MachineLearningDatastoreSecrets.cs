// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Base definition for datastore secrets.
    /// Please note <see cref="MachineLearningDatastoreSecrets"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="MachineLearningAccountKeyDatastoreSecrets"/>, <see cref="MachineLearningCertificateDatastoreSecrets"/>, <see cref="KerberosKeytabSecrets"/>, <see cref="KerberosPasswordSecrets"/>, <see cref="MachineLearningSasDatastoreSecrets"/> and <see cref="MachineLearningServicePrincipalDatastoreSecrets"/>.
    /// </summary>
    public abstract partial class MachineLearningDatastoreSecrets
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

        /// <summary> Initializes a new instance of <see cref="MachineLearningDatastoreSecrets"/>. </summary>
        protected MachineLearningDatastoreSecrets()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningDatastoreSecrets"/>. </summary>
        /// <param name="secretsType"> [Required] Credential type used to authentication with storage. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningDatastoreSecrets(SecretsType secretsType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SecretsType = secretsType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> [Required] Credential type used to authentication with storage. </summary>
        internal SecretsType SecretsType { get; set; }
    }
}
