// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Connectivity group item.
    /// </summary>
    public partial class ConnectivityGroupItem
    {
        /// <summary>
        /// Initializes a new instance of the ConnectivityGroupItem class.
        /// </summary>
        public ConnectivityGroupItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectivityGroupItem class.
        /// </summary>
        /// <param name="networkGroupId">Network group Id.</param>
        /// <param name="groupConnectivity">Group connectivity type. Possible
        /// values include: 'None', 'DirectlyConnected'</param>
        /// <param name="useHubGateway">Flag if need to use hub gateway.
        /// Possible values include: 'False', 'True'</param>
        /// <param name="isGlobal">Flag if global is supported. Possible values
        /// include: 'False', 'True'</param>
        public ConnectivityGroupItem(string networkGroupId, string groupConnectivity, string useHubGateway = default(string), string isGlobal = default(string))
        {
            NetworkGroupId = networkGroupId;
            UseHubGateway = useHubGateway;
            IsGlobal = isGlobal;
            GroupConnectivity = groupConnectivity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets network group Id.
        /// </summary>
        [JsonProperty(PropertyName = "networkGroupId")]
        public string NetworkGroupId { get; set; }

        /// <summary>
        /// Gets or sets flag if need to use hub gateway. Possible values
        /// include: 'False', 'True'
        /// </summary>
        [JsonProperty(PropertyName = "useHubGateway")]
        public string UseHubGateway { get; set; }

        /// <summary>
        /// Gets or sets flag if global is supported. Possible values include:
        /// 'False', 'True'
        /// </summary>
        [JsonProperty(PropertyName = "isGlobal")]
        public string IsGlobal { get; set; }

        /// <summary>
        /// Gets or sets group connectivity type. Possible values include:
        /// 'None', 'DirectlyConnected'
        /// </summary>
        [JsonProperty(PropertyName = "groupConnectivity")]
        public string GroupConnectivity { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (NetworkGroupId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "NetworkGroupId");
            }
            if (GroupConnectivity == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "GroupConnectivity");
            }
        }
    }
}
