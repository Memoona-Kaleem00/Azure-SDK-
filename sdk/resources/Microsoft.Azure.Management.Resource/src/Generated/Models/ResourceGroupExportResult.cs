// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Resource group export result.
    /// </summary>
    public partial class ResourceGroupExportResult
    {
        /// <summary>
        /// Initializes a new instance of the ResourceGroupExportResult class.
        /// </summary>
        public ResourceGroupExportResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceGroupExportResult class.
        /// </summary>
        /// <param name="template">The template content.</param>
        /// <param name="error">The template export error.</param>
        public ResourceGroupExportResult(object template = default(object), ErrorResponse error = default(ErrorResponse))
        {
            Template = template;
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the template content.
        /// </summary>
        [JsonProperty(PropertyName = "template")]
        public object Template { get; set; }

        /// <summary>
        /// Gets or sets the template export error.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public ErrorResponse Error { get; set; }

    }
}
