
namespace Microsoft.Azure.Management.Cdn.Models
{
    using System.Linq;

    /// <summary>
    /// The object that represents the operation.
    /// </summary>
    public partial class OperationDisplay
    {
        /// <summary>
        /// Initializes a new instance of the OperationDisplay class.
        /// </summary>
        public OperationDisplay() { }

        /// <summary>
        /// Initializes a new instance of the OperationDisplay class.
        /// </summary>
        /// <param name="provider">Service provider: Microsoft.Cdn</param>
        /// <param name="resource">Resource on which the operation is
        /// performed: Profile, endpoint, etc.</param>
        /// <param name="operation">Operation type: Read, write, delete,
        /// etc.</param>
        public OperationDisplay(string provider = default(string), string resource = default(string), string operation = default(string))
        {
            Provider = provider;
            Resource = resource;
            Operation = operation;
        }

        /// <summary>
        /// Gets or sets service provider: Microsoft.Cdn
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or sets resource on which the operation is performed:
        /// Profile, endpoint, etc.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resource")]
        public string Resource { get; set; }

        /// <summary>
        /// Gets or sets operation type: Read, write, delete, etc.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "operation")]
        public string Operation { get; set; }

    }
}
