// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Authoring.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A Hierarchical Child Entity.
    /// </summary>
    public partial class HierarchicalChildEntity : ChildEntity
    {
        /// <summary>
        /// Initializes a new instance of the HierarchicalChildEntity class.
        /// </summary>
        public HierarchicalChildEntity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HierarchicalChildEntity class.
        /// </summary>
        /// <param name="id">The ID (GUID) belonging to a child entity.</param>
        /// <param name="name">The name of a child entity.</param>
        /// <param name="typeId">The type ID of the Entity Model.</param>
        /// <param name="readableType">Possible values include: 'Entity
        /// Extractor', 'Hierarchical Entity Extractor', 'Hierarchical Child
        /// Entity Extractor', 'Composite Entity Extractor', 'Closed List
        /// Entity Extractor', 'Prebuilt Entity Extractor', 'Intent
        /// Classifier', 'Pattern.Any Entity Extractor', 'Regex Entity
        /// Extractor'</param>
        public HierarchicalChildEntity(System.Guid id, string name = default(string), int? typeId = default(int?), string readableType = default(string))
            : base(id, name)
        {
            TypeId = typeId;
            ReadableType = readableType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type ID of the Entity Model.
        /// </summary>
        [JsonProperty(PropertyName = "typeId")]
        public int? TypeId { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Entity Extractor',
        /// 'Hierarchical Entity Extractor', 'Hierarchical Child Entity
        /// Extractor', 'Composite Entity Extractor', 'Closed List Entity
        /// Extractor', 'Prebuilt Entity Extractor', 'Intent Classifier',
        /// 'Pattern.Any Entity Extractor', 'Regex Entity Extractor'
        /// </summary>
        [JsonProperty(PropertyName = "readableType")]
        public string ReadableType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
