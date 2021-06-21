// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A server key.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ServerKey : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the ServerKey class.
        /// </summary>
        public ServerKey()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServerKey class.
        /// </summary>
        /// <param name="serverKeyType">The server key type like
        /// 'ServiceManaged', 'AzureKeyVault'. Possible values include:
        /// 'ServiceManaged', 'AzureKeyVault'</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="kind">Kind of encryption protector. This is metadata
        /// used for the Azure portal experience.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="subregion">Subregion of the server key.</param>
        /// <param name="uri">The URI of the server key. If the ServerKeyType
        /// is AzureKeyVault, then the URI is required.</param>
        /// <param name="thumbprint">Thumbprint of the server key.</param>
        /// <param name="creationDate">The server key creation date.</param>
        /// <param name="autoRotationEnabled">Key auto rotation opt-in flag.
        /// Either true or false.</param>
        public ServerKey(ServerKeyType serverKeyType, string id = default(string), string name = default(string), string type = default(string), string kind = default(string), string location = default(string), string subregion = default(string), string uri = default(string), string thumbprint = default(string), System.DateTime? creationDate = default(System.DateTime?), bool? autoRotationEnabled = default(bool?))
            : base(id, name, type)
        {
            Kind = kind;
            Location = location;
            Subregion = subregion;
            ServerKeyType = serverKeyType;
            Uri = uri;
            Thumbprint = thumbprint;
            CreationDate = creationDate;
            AutoRotationEnabled = autoRotationEnabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets kind of encryption protector. This is metadata used for the
        /// Azure portal experience.
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; private set; }

        /// <summary>
        /// Gets resource location.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; private set; }

        /// <summary>
        /// Gets subregion of the server key.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subregion")]
        public string Subregion { get; private set; }

        /// <summary>
        /// Gets or sets the server key type like 'ServiceManaged',
        /// 'AzureKeyVault'. Possible values include: 'ServiceManaged',
        /// 'AzureKeyVault'
        /// </summary>
        [JsonProperty(PropertyName = "properties.serverKeyType")]
        public ServerKeyType ServerKeyType { get; set; }

        /// <summary>
        /// Gets or sets the URI of the server key. If the ServerKeyType is
        /// AzureKeyVault, then the URI is required.
        /// </summary>
        [JsonProperty(PropertyName = "properties.uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Gets thumbprint of the server key.
        /// </summary>
        [JsonProperty(PropertyName = "properties.thumbprint")]
        public string Thumbprint { get; private set; }

        /// <summary>
        /// Gets the server key creation date.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationDate")]
        public System.DateTime? CreationDate { get; private set; }

        /// <summary>
        /// Gets key auto rotation opt-in flag. Either true or false.
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoRotationEnabled")]
        public bool? AutoRotationEnabled { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
