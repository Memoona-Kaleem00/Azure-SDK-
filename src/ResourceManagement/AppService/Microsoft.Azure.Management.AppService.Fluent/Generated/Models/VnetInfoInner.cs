// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Virtual Network information contract.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class VnetInfoInner : Microsoft.Azure.Management.Resource.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the VnetInfoInner class.
        /// </summary>
        public VnetInfoInner() { }

        /// <summary>
        /// Initializes a new instance of the VnetInfoInner class.
        /// </summary>
        /// <param name="vnetResourceId">The Virtual Network's resource
        /// ID.</param>
        /// <param name="certThumbprint">The client certificate
        /// thumbprint.</param>
        /// <param name="certBlob">A certificate file (.cer) blob containing
        /// the public key of the private key used to authenticate a
        /// Point-To-Site VPN connection.</param>
        /// <param name="routes">The routes that this Virtual Network
        /// connection uses.</param>
        /// <param name="resyncRequired"><code>true</code> if a resync is
        /// required; otherwise, <code>false</code>.</param>
        /// <param name="dnsServers">DNS servers to be used by this Virtual
        /// Network. This should be a comma-separated list of IP
        /// addresses.</param>
        public VnetInfoInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string vnetResourceId = default(string), string certThumbprint = default(string), string certBlob = default(string), System.Collections.Generic.IList<VnetRouteInner> routes = default(System.Collections.Generic.IList<VnetRouteInner>), bool? resyncRequired = default(bool?), string dnsServers = default(string))
            : base(location, id, name, type, tags)
        {
            VnetResourceId = vnetResourceId;
            CertThumbprint = certThumbprint;
            CertBlob = certBlob;
            Routes = routes;
            ResyncRequired = resyncRequired;
            DnsServers = dnsServers;
        }

        /// <summary>
        /// Gets or sets the Virtual Network's resource ID.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.vnetResourceId")]
        public string VnetResourceId { get; set; }

        /// <summary>
        /// Gets the client certificate thumbprint.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.certThumbprint")]
        public string CertThumbprint { get; private set; }

        /// <summary>
        /// Gets or sets a certificate file (.cer) blob containing the public
        /// key of the private key used to authenticate a
        /// Point-To-Site VPN connection.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.certBlob")]
        public string CertBlob { get; set; }

        /// <summary>
        /// Gets the routes that this Virtual Network connection uses.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.routes")]
        public System.Collections.Generic.IList<VnetRouteInner> Routes { get; private set; }

        /// <summary>
        /// Gets &lt;code&gt;true&lt;/code&gt; if a resync is required;
        /// otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.resyncRequired")]
        public bool? ResyncRequired { get; private set; }

        /// <summary>
        /// Gets or sets DNS servers to be used by this Virtual Network. This
        /// should be a comma-separated list of IP addresses.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.dnsServers")]
        public string DnsServers { get; set; }

    }
}
