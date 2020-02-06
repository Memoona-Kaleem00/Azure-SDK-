// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The type of the paths for alias.
    /// </summary>
    public partial class AliasPathType
    {
        /// <summary>
        /// Initializes a new instance of the AliasPathType class.
        /// </summary>
        public AliasPathType()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AliasPathType class.
        /// </summary>
        /// <param name="path">The path of an alias.</param>
        /// <param name="apiVersions">The API versions.</param>
        public AliasPathType(string path = default(string), IList<string> apiVersions = default(IList<string>))
        {
            Path = path;
            ApiVersions = apiVersions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the path of an alias.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the API versions.
        /// </summary>
        [JsonProperty(PropertyName = "apiVersions")]
        public IList<string> ApiVersions { get; set; }

    }
}
