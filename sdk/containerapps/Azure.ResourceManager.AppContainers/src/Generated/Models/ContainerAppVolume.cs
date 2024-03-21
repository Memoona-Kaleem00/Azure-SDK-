// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Volume definitions for the Container App. </summary>
    public partial class ContainerAppVolume
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

        /// <summary> Initializes a new instance of <see cref="ContainerAppVolume"/>. </summary>
        public ContainerAppVolume()
        {
            Secrets = new ChangeTrackingList<SecretVolumeItem>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppVolume"/>. </summary>
        /// <param name="name"> Volume name. </param>
        /// <param name="storageType"> Storage type for the volume. If not provided, use EmptyDir. </param>
        /// <param name="storageName"> Name of storage resource. No need to provide for EmptyDir and Secret. </param>
        /// <param name="secrets"> List of secrets to be added in volume. If no secrets are provided, all secrets in collection will be added to volume. </param>
        /// <param name="mountOptions"> Mount options used while mounting the AzureFile. Must be a comma-separated string. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppVolume(string name, ContainerAppStorageType? storageType, string storageName, IList<SecretVolumeItem> secrets, string mountOptions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            StorageType = storageType;
            StorageName = storageName;
            Secrets = secrets;
            MountOptions = mountOptions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Volume name. </summary>
        public string Name { get; set; }
        /// <summary> Storage type for the volume. If not provided, use EmptyDir. </summary>
        public ContainerAppStorageType? StorageType { get; set; }
        /// <summary> Name of storage resource. No need to provide for EmptyDir and Secret. </summary>
        public string StorageName { get; set; }
        /// <summary> List of secrets to be added in volume. If no secrets are provided, all secrets in collection will be added to volume. </summary>
        public IList<SecretVolumeItem> Secrets { get; }
        /// <summary> Mount options used while mounting the AzureFile. Must be a comma-separated string. </summary>
        public string MountOptions { get; set; }
    }
}
