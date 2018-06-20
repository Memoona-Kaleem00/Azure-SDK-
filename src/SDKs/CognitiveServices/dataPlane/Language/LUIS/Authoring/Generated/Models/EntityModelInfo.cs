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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An Entity Extractor model info.
    /// </summary>
    public partial class EntityModelInfo : ModelInfo
    {
        /// <summary>
        /// Initializes a new instance of the EntityModelInfo class.
        /// </summary>
        public EntityModelInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EntityModelInfo class.
        /// </summary>
        /// <param name="id">The ID of the Entity Model.</param>
        /// <param name="readableType">Possible values include: 'Entity
        /// Extractor', 'Hierarchical Entity Extractor', 'Hierarchical Child
        /// Entity Extractor', 'Composite Entity Extractor', 'Closed List
        /// Entity Extractor', 'Prebuilt Entity Extractor', 'Intent
        /// Classifier', 'Pattern.Any Entity Extractor', 'Regex Entity
        /// Extractor'</param>
        /// <param name="name">Name of the Entity Model.</param>
        /// <param name="typeId">The type ID of the Entity Model.</param>
        public EntityModelInfo(System.Guid id, string readableType, string name = default(string), int? typeId = default(int?), IList<EntityRole> roles = default(IList<EntityRole>))
            : base(id, readableType, name, typeId)
        {
            Roles = roles;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "roles")]
        public IList<EntityRole> Roles { get; set; }

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
