// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Spring Cloud Gateway properties payload
    /// </summary>
    public partial class GatewayProperties
    {
        /// <summary>
        /// Initializes a new instance of the GatewayProperties class.
        /// </summary>
        public GatewayProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GatewayProperties class.
        /// </summary>
        /// <param name="provisioningState">State of the Spring Cloud Gateway.
        /// Possible values include: 'Creating', 'Updating', 'Succeeded',
        /// 'Failed', 'Deleting'</param>
        /// <param name="publicProperty">Indicates whether the Spring Cloud
        /// Gateway exposes endpoint.</param>
        /// <param name="url">URL of the Spring Cloud Gateway, exposed when
        /// 'public' is true.</param>
        /// <param name="httpsOnly">Indicate if only https is allowed.</param>
        /// <param name="resourceRequests">The requested resource quantity for
        /// required CPU and Memory.</param>
        /// <param name="instances">Collection of instances belong to Spring
        /// Cloud Gateway.</param>
        public GatewayProperties(string provisioningState = default(string), bool? publicProperty = default(bool?), string url = default(string), bool? httpsOnly = default(bool?), SsoProperties ssoProperties = default(SsoProperties), GatewayApiMetadataProperties apiMetadataProperties = default(GatewayApiMetadataProperties), GatewayCorsProperties corsProperties = default(GatewayCorsProperties), GatewayResourceRequests resourceRequests = default(GatewayResourceRequests), IList<GatewayInstance> instances = default(IList<GatewayInstance>), GatewayOperatorProperties operatorProperties = default(GatewayOperatorProperties))
        {
            ProvisioningState = provisioningState;
            PublicProperty = publicProperty;
            Url = url;
            HttpsOnly = httpsOnly;
            SsoProperties = ssoProperties;
            ApiMetadataProperties = apiMetadataProperties;
            CorsProperties = corsProperties;
            ResourceRequests = resourceRequests;
            Instances = instances;
            OperatorProperties = operatorProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets state of the Spring Cloud Gateway. Possible values include:
        /// 'Creating', 'Updating', 'Succeeded', 'Failed', 'Deleting'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets indicates whether the Spring Cloud Gateway exposes
        /// endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "public")]
        public bool? PublicProperty { get; set; }

        /// <summary>
        /// Gets URL of the Spring Cloud Gateway, exposed when 'public' is
        /// true.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; private set; }

        /// <summary>
        /// Gets or sets indicate if only https is allowed.
        /// </summary>
        [JsonProperty(PropertyName = "httpsOnly")]
        public bool? HttpsOnly { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssoProperties")]
        public SsoProperties SsoProperties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "apiMetadataProperties")]
        public GatewayApiMetadataProperties ApiMetadataProperties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "corsProperties")]
        public GatewayCorsProperties CorsProperties { get; set; }

        /// <summary>
        /// Gets or sets the requested resource quantity for required CPU and
        /// Memory.
        /// </summary>
        [JsonProperty(PropertyName = "resourceRequests")]
        public GatewayResourceRequests ResourceRequests { get; set; }

        /// <summary>
        /// Gets collection of instances belong to Spring Cloud Gateway.
        /// </summary>
        [JsonProperty(PropertyName = "instances")]
        public IList<GatewayInstance> Instances { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "operatorProperties")]
        public GatewayOperatorProperties OperatorProperties { get; private set; }

    }
}
