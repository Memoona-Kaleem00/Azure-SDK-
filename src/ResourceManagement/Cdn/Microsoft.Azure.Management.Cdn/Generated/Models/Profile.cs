// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn.Models
{
    using System.Linq;

    /// <summary>
    /// CDN profile represents the top level resource and the entry point into
    /// the CDN API. This allows users to set up a logical grouping of
    /// endpoints in addition to creating shared configuration settings and
    /// selecting pricing tiers and providers.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class Profile : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Profile class.
        /// </summary>
        public Profile() { }

        /// <summary>
        /// Initializes a new instance of the Profile class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource ID</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="sku">The SKU (pricing tier) of the CDN
        /// profile.</param>
        /// <param name="resourceState">Resource status of the profile.
        /// Possible values include: 'Creating', 'Active', 'Deleting',
        /// 'Disabled'</param>
        /// <param name="provisioningState">Provisioning status of the
        /// profile.</param>
        public Profile(string location, string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), Sku sku = default(Sku), string resourceState = default(string), string provisioningState = default(string))
            : base(location, id, name, type, tags)
        {
            Sku = sku;
            ResourceState = resourceState;
            ProvisioningState = provisioningState;
        }

        /// <summary>
        /// Gets or sets the SKU (pricing tier) of the CDN profile.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets resource status of the profile. Possible values include:
        /// 'Creating', 'Active', 'Deleting', 'Disabled'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.resourceState")]
        public string ResourceState { get; private set; }

        /// <summary>
        /// Gets provisioning status of the profile.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
