// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.IotHub.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The description of the IoT hub.
    /// </summary>
    public partial class IotHubDescription : Resource
    {
        /// <summary>
        /// Initializes a new instance of the IotHubDescription class.
        /// </summary>
        public IotHubDescription()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IotHubDescription class.
        /// </summary>
        /// <param name="location">The resource location.</param>
        /// <param name="sku">IotHub SKU info</param>
        /// <param name="id">The resource identifier.</param>
        /// <param name="name">The resource name.</param>
        /// <param name="type">The resource type.</param>
        /// <param name="tags">The resource tags.</param>
        /// <param name="etag">The Etag field is *not* required. If it is
        /// provided in the response body, it must also be provided as a header
        /// per the normal ETag convention.</param>
        /// <param name="properties">IotHub properties</param>
        /// <param name="identity">The managed identities for the
        /// IotHub.</param>
        /// <param name="systemData">The system meta data relating to this
        /// resource.</param>
        public IotHubDescription(string location, IotHubSkuInfo sku, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string etag = default(string), IotHubProperties properties = default(IotHubProperties), ArmIdentity identity = default(ArmIdentity), SystemData systemData = default(SystemData))
            : base(location, id, name, type, tags)
        {
            Etag = etag;
            Properties = properties;
            Sku = sku;
            Identity = identity;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Etag field is *not* required. If it is provided in
        /// the response body, it must also be provided as a header per the
        /// normal ETag convention.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets iotHub properties
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IotHubProperties Properties { get; set; }

        /// <summary>
        /// Gets or sets iotHub SKU info
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public IotHubSkuInfo Sku { get; set; }

        /// <summary>
        /// Gets or sets the managed identities for the IotHub.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public ArmIdentity Identity { get; set; }

        /// <summary>
        /// Gets the system meta data relating to this resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Sku == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sku");
            }
            if (Properties != null)
            {
                Properties.Validate();
            }
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}
