// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The SAP Software configuration Input when the software is to be installed by service without OS Configurations. </summary>
    public partial class SapInstallWithoutOSConfigSoftwareConfiguration : SapSoftwareConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="SapInstallWithoutOSConfigSoftwareConfiguration"/>. </summary>
        /// <param name="bomUri"> The URL to the SAP Build of Materials(BOM) file. </param>
        /// <param name="sapBitsStorageAccountId"> The SAP bits storage account id. </param>
        /// <param name="softwareVersion"> The software version to install. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="bomUri"/>, <paramref name="sapBitsStorageAccountId"/> or <paramref name="softwareVersion"/> is null. </exception>
        public SapInstallWithoutOSConfigSoftwareConfiguration(Uri bomUri, string sapBitsStorageAccountId, string softwareVersion)
        {
            Argument.AssertNotNull(bomUri, nameof(bomUri));
            Argument.AssertNotNull(sapBitsStorageAccountId, nameof(sapBitsStorageAccountId));
            Argument.AssertNotNull(softwareVersion, nameof(softwareVersion));

            BomUri = bomUri;
            SapBitsStorageAccountId = sapBitsStorageAccountId;
            SoftwareVersion = softwareVersion;
            SoftwareInstallationType = SapSoftwareInstallationType.SapInstallWithoutOSConfig;
        }

        /// <summary> Initializes a new instance of <see cref="SapInstallWithoutOSConfigSoftwareConfiguration"/>. </summary>
        /// <param name="softwareInstallationType"> The SAP software installation Type. </param>
        /// <param name="bomUri"> The URL to the SAP Build of Materials(BOM) file. </param>
        /// <param name="sapBitsStorageAccountId"> The SAP bits storage account id. </param>
        /// <param name="softwareVersion"> The software version to install. </param>
        /// <param name="highAvailabilitySoftwareConfiguration"> Gets or sets the HA software configuration. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SapInstallWithoutOSConfigSoftwareConfiguration(SapSoftwareInstallationType softwareInstallationType, Uri bomUri, string sapBitsStorageAccountId, string softwareVersion, HighAvailabilitySoftwareConfiguration highAvailabilitySoftwareConfiguration, Dictionary<string, BinaryData> rawData) : base(softwareInstallationType, rawData)
        {
            BomUri = bomUri;
            SapBitsStorageAccountId = sapBitsStorageAccountId;
            SoftwareVersion = softwareVersion;
            HighAvailabilitySoftwareConfiguration = highAvailabilitySoftwareConfiguration;
            SoftwareInstallationType = softwareInstallationType;
        }

        /// <summary> Initializes a new instance of <see cref="SapInstallWithoutOSConfigSoftwareConfiguration"/> for deserialization. </summary>
        internal SapInstallWithoutOSConfigSoftwareConfiguration()
        {
        }

        /// <summary> The URL to the SAP Build of Materials(BOM) file. </summary>
        public Uri BomUri { get; set; }
        /// <summary> The SAP bits storage account id. </summary>
        public string SapBitsStorageAccountId { get; set; }
        /// <summary> The software version to install. </summary>
        public string SoftwareVersion { get; set; }
        /// <summary> Gets or sets the HA software configuration. </summary>
        public HighAvailabilitySoftwareConfiguration HighAvailabilitySoftwareConfiguration { get; set; }
    }
}
