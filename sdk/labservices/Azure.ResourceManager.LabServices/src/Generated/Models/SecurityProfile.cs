// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary>
    /// The lab security profile.
    /// Serialized Name: SecurityProfile
    /// </summary>
    public partial class SecurityProfile
    {
        /// <summary> Initializes a new instance of SecurityProfile. </summary>
        public SecurityProfile()
        {
        }

        /// <summary> Initializes a new instance of SecurityProfile. </summary>
        /// <param name="registrationCode">
        /// The registration code for the lab.
        /// Serialized Name: SecurityProfile.registrationCode
        /// </param>
        /// <param name="openAccess">
        /// Whether any user or only specified users can register to a lab.
        /// Serialized Name: SecurityProfile.openAccess
        /// </param>
        internal SecurityProfile(string registrationCode, EnableState? openAccess)
        {
            RegistrationCode = registrationCode;
            OpenAccess = openAccess;
        }

        /// <summary>
        /// The registration code for the lab.
        /// Serialized Name: SecurityProfile.registrationCode
        /// </summary>
        public string RegistrationCode { get; }
        /// <summary>
        /// Whether any user or only specified users can register to a lab.
        /// Serialized Name: SecurityProfile.openAccess
        /// </summary>
        public EnableState? OpenAccess { get; set; }
    }
}
