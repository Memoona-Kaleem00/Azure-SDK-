// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.SiteRecovery;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// This class represents the script action task details.
    /// </summary>
    public partial class ScriptActionTaskDetails : TaskTypeDetails
    {
        /// <summary>
        /// Initializes a new instance of the ScriptActionTaskDetails class.
        /// </summary>
        public ScriptActionTaskDetails()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScriptActionTaskDetails class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="path">The path.</param>
        /// <param name="output">The output.</param>
        /// <param name="isPrimarySideScript">A value indicating whether it is
        /// a primary side script or not.</param>
        public ScriptActionTaskDetails(string name = default(string), string path = default(string), string output = default(string), bool? isPrimarySideScript = default(bool?))
        {
            Name = name;
            Path = path;
            Output = output;
            IsPrimarySideScript = isPrimarySideScript;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the output.
        /// </summary>
        [JsonProperty(PropertyName = "output")]
        public string Output { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether it is a primary side script
        /// or not.
        /// </summary>
        [JsonProperty(PropertyName = "isPrimarySideScript")]
        public bool? IsPrimarySideScript { get; set; }

    }
}
