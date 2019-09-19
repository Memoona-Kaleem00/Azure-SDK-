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
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// ExpressRouteCrossConnection resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ExpressRouteCrossConnection : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ExpressRouteCrossConnection
        /// class.
        /// </summary>
        public ExpressRouteCrossConnection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExpressRouteCrossConnection
        /// class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="primaryAzurePort">The name of the primary
        /// port.</param>
        /// <param name="secondaryAzurePort">The name of the secondary
        /// port.</param>
        /// <param name="sTag">The identifier of the circuit traffic.</param>
        /// <param name="peeringLocation">The peering location of the
        /// ExpressRoute circuit.</param>
        /// <param name="bandwidthInMbps">The circuit bandwidth In
        /// Mbps.</param>
        /// <param name="expressRouteCircuit">The ExpressRouteCircuit.</param>
        /// <param name="serviceProviderProvisioningState">The provisioning
        /// state of the circuit in the connectivity provider system. Possible
        /// values include: 'NotProvisioned', 'Provisioning', 'Provisioned',
        /// 'Deprovisioning'</param>
        /// <param name="serviceProviderNotes">Additional read only notes set
        /// by the connectivity provider.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// express route cross connection resource. Possible values include:
        /// 'Succeeded', 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="peerings">The list of peerings.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public ExpressRouteCrossConnection(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string primaryAzurePort = default(string), string secondaryAzurePort = default(string), int? sTag = default(int?), string peeringLocation = default(string), int? bandwidthInMbps = default(int?), ExpressRouteCircuitReference expressRouteCircuit = default(ExpressRouteCircuitReference), string serviceProviderProvisioningState = default(string), string serviceProviderNotes = default(string), string provisioningState = default(string), IList<ExpressRouteCrossConnectionPeering> peerings = default(IList<ExpressRouteCrossConnectionPeering>), string etag = default(string))
            : base(id, name, type, location, tags)
        {
            PrimaryAzurePort = primaryAzurePort;
            SecondaryAzurePort = secondaryAzurePort;
            STag = sTag;
            PeeringLocation = peeringLocation;
            BandwidthInMbps = bandwidthInMbps;
            ExpressRouteCircuit = expressRouteCircuit;
            ServiceProviderProvisioningState = serviceProviderProvisioningState;
            ServiceProviderNotes = serviceProviderNotes;
            ProvisioningState = provisioningState;
            Peerings = peerings;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the name of the primary port.
        /// </summary>
        [JsonProperty(PropertyName = "properties.primaryAzurePort")]
        public string PrimaryAzurePort { get; private set; }

        /// <summary>
        /// Gets the name of the secondary port.
        /// </summary>
        [JsonProperty(PropertyName = "properties.secondaryAzurePort")]
        public string SecondaryAzurePort { get; private set; }

        /// <summary>
        /// Gets the identifier of the circuit traffic.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sTag")]
        public int? STag { get; private set; }

        /// <summary>
        /// Gets or sets the peering location of the ExpressRoute circuit.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peeringLocation")]
        public string PeeringLocation { get; set; }

        /// <summary>
        /// Gets or sets the circuit bandwidth In Mbps.
        /// </summary>
        [JsonProperty(PropertyName = "properties.bandwidthInMbps")]
        public int? BandwidthInMbps { get; set; }

        /// <summary>
        /// Gets or sets the ExpressRouteCircuit.
        /// </summary>
        [JsonProperty(PropertyName = "properties.expressRouteCircuit")]
        public ExpressRouteCircuitReference ExpressRouteCircuit { get; set; }

        /// <summary>
        /// Gets or sets the provisioning state of the circuit in the
        /// connectivity provider system. Possible values include:
        /// 'NotProvisioned', 'Provisioning', 'Provisioned', 'Deprovisioning'
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceProviderProvisioningState")]
        public string ServiceProviderProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets additional read only notes set by the connectivity
        /// provider.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceProviderNotes")]
        public string ServiceProviderNotes { get; set; }

        /// <summary>
        /// Gets the provisioning state of the express route cross connection
        /// resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the list of peerings.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peerings")]
        public IList<ExpressRouteCrossConnectionPeering> Peerings { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

    }
}
