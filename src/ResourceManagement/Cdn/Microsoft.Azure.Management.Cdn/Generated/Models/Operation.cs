
namespace Microsoft.Azure.Management.Cdn.Models
{
    using System.Linq;

    /// <summary>
    /// CDN REST API operation
    /// </summary>
    public partial class Operation
    {
        /// <summary>
        /// Initializes a new instance of the Operation class.
        /// </summary>
        public Operation() { }

        /// <summary>
        /// Initializes a new instance of the Operation class.
        /// </summary>
        /// <param name="name">Operation name:
        /// {provider}/{resource}/{operation}</param>
        /// <param name="display">The object that represents the
        /// operation.</param>
        public Operation(string name = default(string), OperationDisplay display = default(OperationDisplay))
        {
            Name = name;
            Display = display;
        }

        /// <summary>
        /// Gets or sets operation name: {provider}/{resource}/{operation}
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the object that represents the operation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "display")]
        public OperationDisplay Display { get; set; }

    }
}
