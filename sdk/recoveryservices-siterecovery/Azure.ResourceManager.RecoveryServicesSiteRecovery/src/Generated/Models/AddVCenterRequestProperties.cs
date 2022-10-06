// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The properties of an add vCenter request. </summary>
    public partial class AddVCenterRequestProperties
    {
        /// <summary> Initializes a new instance of AddVCenterRequestProperties. </summary>
        public AddVCenterRequestProperties()
        {
        }

        /// <summary> The friendly name of the vCenter. </summary>
        public string FriendlyName { get; set; }
        /// <summary> The IP address of the vCenter to be discovered. </summary>
        public string IPAddress { get; set; }
        /// <summary> The process server Id from where the discovery is orchestrated. </summary>
        public string ProcessServerId { get; set; }
        /// <summary> The port number for discovery. </summary>
        public string Port { get; set; }
        /// <summary> The account Id which has privileges to discover the vCenter. </summary>
        public string RunAsAccountId { get; set; }
    }
}
