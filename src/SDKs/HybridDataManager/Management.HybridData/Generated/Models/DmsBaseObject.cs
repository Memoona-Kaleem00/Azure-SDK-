// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HybridData.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Base class for all objects under DataManager Service
    /// </summary>
    public partial class DmsBaseObject
    {
        /// <summary>
        /// Initializes a new instance of the DmsBaseObject class.
        /// </summary>
        public DmsBaseObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DmsBaseObject class.
        /// </summary>
        /// <param name="name">Name of the object.</param>
        /// <param name="id">Id of the object.</param>
        /// <param name="type">Type of the object.</param>
        public DmsBaseObject(string name = default(string), string id = default(string), string type = default(string))
        {
            Name = name;
            Id = id;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets id of the object.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets type of the object.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

    }
}
