// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Azure;
    using Management;
    using Network;
    using Fluent;
    using Rest;
    using Rest.Azure;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Http listener of an application gateway.
    /// </summary>
    [JsonTransformation]
    public partial class ApplicationGatewayHttpListenerInner : Microsoft.Azure.Management.Resource.Fluent.SubResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayHttpListenerInner class.
        /// </summary>
        public ApplicationGatewayHttpListenerInner() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayHttpListenerInner class.
        /// </summary>
        /// <param name="frontendIPConfiguration">Frontend IP configuration
        /// resource of an application gateway.</param>
        /// <param name="frontendPort">Frontend port resource of an application
        /// gateway.</param>
        /// <param name="protocol">Protocol. Possible values are: 'Http' and
        /// 'Https'. Possible values include: 'Http', 'Https'</param>
        /// <param name="hostName">Host name of HTTP listener.</param>
        /// <param name="sslCertificate">SSL certificate resource of an
        /// application gateway.</param>
        /// <param name="requireServerNameIndication">Applicable only if
        /// protocol is https. Enables SNI for multi-hosting.</param>
        /// <param name="provisioningState">Provisioning state of the HTTP
        /// listener resource. Possible values are: 'Updating', 'Deleting', and
        /// 'Failed'.</param>
        /// <param name="name">Name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public ApplicationGatewayHttpListenerInner(string id = default(string), Resource.Fluent.SubResource frontendIPConfiguration = default(Resource.Fluent.SubResource), Resource.Fluent.SubResource frontendPort = default(Resource.Fluent.SubResource), string protocol = default(string), string hostName = default(string), Resource.Fluent.SubResource sslCertificate = default(Resource.Fluent.SubResource), bool? requireServerNameIndication = default(bool?), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            FrontendIPConfiguration = frontendIPConfiguration;
            FrontendPort = frontendPort;
            Protocol = protocol;
            HostName = hostName;
            SslCertificate = sslCertificate;
            RequireServerNameIndication = requireServerNameIndication;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
        }

        /// <summary>
        /// Gets or sets frontend IP configuration resource of an application
        /// gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.frontendIPConfiguration")]
        public Resource.Fluent.SubResource FrontendIPConfiguration { get; set; }

        /// <summary>
        /// Gets or sets frontend port resource of an application gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.frontendPort")]
        public Resource.Fluent.SubResource FrontendPort { get; set; }

        /// <summary>
        /// Gets or sets protocol. Possible values are: 'Http' and 'Https'.
        /// Possible values include: 'Http', 'Https'
        /// </summary>
        [JsonProperty(PropertyName = "properties.protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets host name of HTTP listener.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostName")]
        public string HostName { get; set; }

        /// <summary>
        /// Gets or sets SSL certificate resource of an application gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sslCertificate")]
        public Resource.Fluent.SubResource SslCertificate { get; set; }

        /// <summary>
        /// Gets or sets applicable only if protocol is https. Enables SNI for
        /// multi-hosting.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requireServerNameIndication")]
        public bool? RequireServerNameIndication { get; set; }

        /// <summary>
        /// Gets or sets provisioning state of the HTTP listener resource.
        /// Possible values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets name of the resource that is unique within a resource
        /// group. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}

