// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.FormRecognizer.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Result of query operation to fetch multiple models.
    /// </summary>
    public partial class ModelsResult
    {
        /// <summary>
        /// Initializes a new instance of the ModelsResult class.
        /// </summary>
        public ModelsResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ModelsResult class.
        /// </summary>
        /// <param name="modelsProperty">Collection of models.</param>
        public ModelsResult(IList<ModelResult> modelsProperty = default(IList<ModelResult>))
        {
            ModelsProperty = modelsProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets collection of models.
        /// </summary>
        [JsonProperty(PropertyName = "models")]
        public IList<ModelResult> ModelsProperty { get; set; }

    }
}
