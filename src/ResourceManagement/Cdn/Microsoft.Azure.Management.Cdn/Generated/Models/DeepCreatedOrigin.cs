
namespace Microsoft.Azure.Management.Cdn.Models
{
    using System.Linq;

    /// <summary>
    /// Origins to be added when creating a CDN endpoint.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class DeepCreatedOrigin : Microsoft.Rest.Azure.IResource
    {
        /// <summary>
        /// Initializes a new instance of the DeepCreatedOrigin class.
        /// </summary>
        public DeepCreatedOrigin() { }

        /// <summary>
        /// Initializes a new instance of the DeepCreatedOrigin class.
        /// </summary>
        /// <param name="name">Origin name</param>
        /// <param name="hostName">The address of the origin. Domain names,
        /// IPv4 addresses, and IPv6 addresses are supported.</param>
        /// <param name="httpPort">The value of the HTTP port. Must be between
        /// 1 and 65535</param>
        /// <param name="httpsPort">The value of the HTTPS port. Must be
        /// between 1 and 65535</param>
        public DeepCreatedOrigin(string name, string hostName, int? httpPort = default(int?), int? httpsPort = default(int?))
        {
            Name = name;
            HostName = hostName;
            HttpPort = httpPort;
            HttpsPort = httpsPort;
        }

        /// <summary>
        /// Gets or sets origin name
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the address of the origin. Domain names, IPv4
        /// addresses, and IPv6 addresses are supported.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.hostName")]
        public string HostName { get; set; }

        /// <summary>
        /// Gets or sets the value of the HTTP port. Must be between 1 and
        /// 65535
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.httpPort")]
        public int? HttpPort { get; set; }

        /// <summary>
        /// Gets or sets the value of the HTTPS port. Must be between 1 and
        /// 65535
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.httpsPort")]
        public int? HttpsPort { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Name");
            }
            if (HostName == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "HostName");
            }
            if (this.HttpPort > 65535)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMaximum, "HttpPort", 65535);
            }
            if (this.HttpPort < 1)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMinimum, "HttpPort", 1);
            }
            if (this.HttpsPort > 65535)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMaximum, "HttpsPort", 65535);
            }
            if (this.HttpsPort < 1)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMinimum, "HttpsPort", 1);
            }
        }
    }
}
