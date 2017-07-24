// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.SiteRecovery;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// VMware provider specific settings
    /// </summary>
    [Newtonsoft.Json.JsonObject("VMwareVirtualMachine")]
    public partial class VMwareVirtualMachineDetails : ConfigurationSettings
    {
        /// <summary>
        /// Initializes a new instance of the VMwareVirtualMachineDetails
        /// class.
        /// </summary>
        public VMwareVirtualMachineDetails()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VMwareVirtualMachineDetails
        /// class.
        /// </summary>
        /// <param name="agentGeneratedId">The ID generated by the InMage agent
        /// after it gets installed on guest. This is the ID
        /// to be used during InMage CreateProtection.</param>
        /// <param name="agentInstalled">The value indicating if InMage scout
        /// agent is installed on guest.</param>
        /// <param name="osType">The OsType installed on VM.</param>
        /// <param name="agentVersion">The agent version.</param>
        /// <param name="ipAddress">The IP address.</param>
        /// <param name="poweredOn">The value indicating whether VM is powered
        /// on.</param>
        /// <param name="vCenterInfrastructureId">The VCenter infrastructure
        /// Id.</param>
        /// <param name="discoveryType">A value inidicating the discovery type
        /// of the machine.
        /// Value can be vCenter or physical.</param>
        /// <param name="diskDetails">The disk details.</param>
        /// <param name="validationErrors">The validation errors.</param>
        public VMwareVirtualMachineDetails(string agentGeneratedId = default(string), string agentInstalled = default(string), string osType = default(string), string agentVersion = default(string), string ipAddress = default(string), string poweredOn = default(string), string vCenterInfrastructureId = default(string), string discoveryType = default(string), IList<InMageDiskDetails> diskDetails = default(IList<InMageDiskDetails>), IList<HealthError> validationErrors = default(IList<HealthError>))
        {
            AgentGeneratedId = agentGeneratedId;
            AgentInstalled = agentInstalled;
            OsType = osType;
            AgentVersion = agentVersion;
            IpAddress = ipAddress;
            PoweredOn = poweredOn;
            VCenterInfrastructureId = vCenterInfrastructureId;
            DiscoveryType = discoveryType;
            DiskDetails = diskDetails;
            ValidationErrors = validationErrors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID generated by the InMage agent after it gets
        /// installed on guest. This is the ID
        /// to be used during InMage CreateProtection.
        /// </summary>
        [JsonProperty(PropertyName = "agentGeneratedId")]
        public string AgentGeneratedId { get; set; }

        /// <summary>
        /// Gets or sets the value indicating if InMage scout agent is
        /// installed on guest.
        /// </summary>
        [JsonProperty(PropertyName = "agentInstalled")]
        public string AgentInstalled { get; set; }

        /// <summary>
        /// Gets or sets the OsType installed on VM.
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public string OsType { get; set; }

        /// <summary>
        /// Gets or sets the agent version.
        /// </summary>
        [JsonProperty(PropertyName = "agentVersion")]
        public string AgentVersion { get; set; }

        /// <summary>
        /// Gets or sets the IP address.
        /// </summary>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether VM is powered on.
        /// </summary>
        [JsonProperty(PropertyName = "poweredOn")]
        public string PoweredOn { get; set; }

        /// <summary>
        /// Gets or sets the VCenter infrastructure Id.
        /// </summary>
        [JsonProperty(PropertyName = "vCenterInfrastructureId")]
        public string VCenterInfrastructureId { get; set; }

        /// <summary>
        /// Gets or sets a value inidicating the discovery type of the machine.
        /// Value can be vCenter or physical.
        /// </summary>
        [JsonProperty(PropertyName = "discoveryType")]
        public string DiscoveryType { get; set; }

        /// <summary>
        /// Gets or sets the disk details.
        /// </summary>
        [JsonProperty(PropertyName = "diskDetails")]
        public IList<InMageDiskDetails> DiskDetails { get; set; }

        /// <summary>
        /// Gets or sets the validation errors.
        /// </summary>
        [JsonProperty(PropertyName = "validationErrors")]
        public IList<HealthError> ValidationErrors { get; set; }

    }
}
