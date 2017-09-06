// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.SiteRecovery;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Hyper V VM network details.
    /// </summary>
    public partial class VMNicDetails
    {
        /// <summary>
        /// Initializes a new instance of the VMNicDetails class.
        /// </summary>
        public VMNicDetails()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VMNicDetails class.
        /// </summary>
        /// <param name="nicId">The nic Id.</param>
        /// <param name="replicaNicId">The replica nic Id.</param>
        /// <param name="sourceNicArmId">The source nic ARM Id.</param>
        /// <param name="vMSubnetName">VM subnet name.</param>
        /// <param name="vMNetworkName">VM network name.</param>
        /// <param name="recoveryVMNetworkId">Recovery VM network Id.</param>
        /// <param name="recoveryVMSubnetName">Recovery VM subnet name.</param>
        /// <param name="ipAddressType">Ip address type.</param>
        /// <param name="primaryNicStaticIPAddress">Primary nic static IP
        /// address.</param>
        /// <param name="replicaNicStaticIPAddress">Replica nic static IP
        /// address.</param>
        /// <param name="selectionType">Selection type for failover.</param>
        /// <param name="recoveryNicIpAddressType">IP allocation type for
        /// recovery VM.</param>
        public VMNicDetails(string nicId = default(string), string replicaNicId = default(string), string sourceNicArmId = default(string), string vMSubnetName = default(string), string vMNetworkName = default(string), string recoveryVMNetworkId = default(string), string recoveryVMSubnetName = default(string), string ipAddressType = default(string), string primaryNicStaticIPAddress = default(string), string replicaNicStaticIPAddress = default(string), string selectionType = default(string), string recoveryNicIpAddressType = default(string))
        {
            NicId = nicId;
            ReplicaNicId = replicaNicId;
            SourceNicArmId = sourceNicArmId;
            VMSubnetName = vMSubnetName;
            VMNetworkName = vMNetworkName;
            RecoveryVMNetworkId = recoveryVMNetworkId;
            RecoveryVMSubnetName = recoveryVMSubnetName;
            IpAddressType = ipAddressType;
            PrimaryNicStaticIPAddress = primaryNicStaticIPAddress;
            ReplicaNicStaticIPAddress = replicaNicStaticIPAddress;
            SelectionType = selectionType;
            RecoveryNicIpAddressType = recoveryNicIpAddressType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the nic Id.
        /// </summary>
        [JsonProperty(PropertyName = "nicId")]
        public string NicId { get; set; }

        /// <summary>
        /// Gets or sets the replica nic Id.
        /// </summary>
        [JsonProperty(PropertyName = "replicaNicId")]
        public string ReplicaNicId { get; set; }

        /// <summary>
        /// Gets or sets the source nic ARM Id.
        /// </summary>
        [JsonProperty(PropertyName = "sourceNicArmId")]
        public string SourceNicArmId { get; set; }

        /// <summary>
        /// Gets or sets VM subnet name.
        /// </summary>
        [JsonProperty(PropertyName = "vMSubnetName")]
        public string VMSubnetName { get; set; }

        /// <summary>
        /// Gets or sets VM network name.
        /// </summary>
        [JsonProperty(PropertyName = "vMNetworkName")]
        public string VMNetworkName { get; set; }

        /// <summary>
        /// Gets or sets recovery VM network Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryVMNetworkId")]
        public string RecoveryVMNetworkId { get; set; }

        /// <summary>
        /// Gets or sets recovery VM subnet name.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryVMSubnetName")]
        public string RecoveryVMSubnetName { get; set; }

        /// <summary>
        /// Gets or sets ip address type.
        /// </summary>
        [JsonProperty(PropertyName = "ipAddressType")]
        public string IpAddressType { get; set; }

        /// <summary>
        /// Gets or sets primary nic static IP address.
        /// </summary>
        [JsonProperty(PropertyName = "primaryNicStaticIPAddress")]
        public string PrimaryNicStaticIPAddress { get; set; }

        /// <summary>
        /// Gets or sets replica nic static IP address.
        /// </summary>
        [JsonProperty(PropertyName = "replicaNicStaticIPAddress")]
        public string ReplicaNicStaticIPAddress { get; set; }

        /// <summary>
        /// Gets or sets selection type for failover.
        /// </summary>
        [JsonProperty(PropertyName = "selectionType")]
        public string SelectionType { get; set; }

        /// <summary>
        /// Gets or sets IP allocation type for recovery VM.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryNicIpAddressType")]
        public string RecoveryNicIpAddressType { get; set; }

    }
}
