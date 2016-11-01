
namespace Microsoft.Azure.Management.Cdn.Models
{
    using System.Linq;

    /// <summary>
    /// CDN CustomDomain represents a mapping between a user-specified domain
    /// name and a CDN endpoint. This is to use custom domain names to
    /// represent the URLs for branding purposes.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class CustomDomain : Resource
    {
        /// <summary>
        /// Initializes a new instance of the CustomDomain class.
        /// </summary>
        public CustomDomain() { }

        /// <summary>
        /// Initializes a new instance of the CustomDomain class.
        /// </summary>
        /// <param name="location">Resource location.</param>
        /// <param name="hostName">The host name of the custom domain. Must be
        /// a domain name.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="resourceState">Resource status of the custom domain.
        /// Possible values include: 'Creating', 'Active', 'Deleting'</param>
        /// <param name="provisioningState">Provisioning status of the custom
        /// domain.</param>
        public CustomDomain(string location, string hostName, string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string resourceState = default(string), string provisioningState = default(string))
            : base(location, id, name, type, tags)
        {
            HostName = hostName;
            ResourceState = resourceState;
            ProvisioningState = provisioningState;
        }

        /// <summary>
        /// Gets or sets the host name of the custom domain. Must be a domain
        /// name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.hostName")]
        public string HostName { get; set; }

        /// <summary>
        /// Gets resource status of the custom domain. Possible values
        /// include: 'Creating', 'Active', 'Deleting'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.resourceState")]
        public string ResourceState { get; private set; }

        /// <summary>
        /// Gets provisioning status of the custom domain.
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
            if (HostName == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "HostName");
            }
        }
    }
}
