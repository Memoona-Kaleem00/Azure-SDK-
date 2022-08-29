// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary>
    /// The security offering details
    /// Please note <see cref="CloudOffering"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="CspmMonitorAwsOffering"/>, <see cref="CspmMonitorAzureDevOpsOffering"/>, <see cref="CspmMonitorGcpOffering"/>, <see cref="CspmMonitorGithubOffering"/>, <see cref="DefenderForContainersAwsOffering"/>, <see cref="DefenderForContainersGcpOffering"/>, <see cref="DefenderFoDatabasesAwsOffering"/>, <see cref="DefenderForDatabasesGcpOffering"/>, <see cref="DefenderForServersAwsOffering"/>, <see cref="DefenderForServersGcpOffering"/> and <see cref="InformationProtectionAwsOffering"/>.
    /// </summary>
    public abstract partial class CloudOffering
    {
        /// <summary> Initializes a new instance of CloudOffering. </summary>
        protected CloudOffering()
        {
        }

        /// <summary> Initializes a new instance of CloudOffering. </summary>
        /// <param name="offeringType"> The type of the security offering. </param>
        /// <param name="description"> The offering description. </param>
        internal CloudOffering(OfferingType offeringType, string description)
        {
            OfferingType = offeringType;
            Description = description;
        }

        /// <summary> The type of the security offering. </summary>
        internal OfferingType OfferingType { get; set; }
        /// <summary> The offering description. </summary>
        public string Description { get; }
    }
}
