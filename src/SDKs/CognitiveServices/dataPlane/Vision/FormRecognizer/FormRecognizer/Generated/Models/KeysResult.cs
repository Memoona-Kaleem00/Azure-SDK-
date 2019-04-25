// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.FormRecognizer.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Response of the Keys API call.
    /// </summary>
    public partial class KeysResult
    {
        /// <summary>
        /// Initializes a new instance of the KeysResult class.
        /// </summary>
        public KeysResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KeysResult class.
        /// </summary>
        /// <param name="clusters">Cluster of keys</param>
        public KeysResult(object clusters = default(object))
        {
            Clusters = clusters;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets cluster of keys
        /// </summary>
        [JsonProperty(PropertyName = "clusters")]
        public object Clusters { get; set; }

    }
}
