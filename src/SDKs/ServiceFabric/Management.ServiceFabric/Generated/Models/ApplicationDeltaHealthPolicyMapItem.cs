// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabric.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines an item in ApplicationDeltaHealthPolicyMap.
    ///
    /// </summary>
    public partial class ApplicationDeltaHealthPolicyMapItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationDeltaHealthPolicyMapItem class.
        /// </summary>
        public ApplicationDeltaHealthPolicyMapItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationDeltaHealthPolicyMapItem class.
        /// </summary>
        /// <param name="key">The key of the application delta health policy
        /// map item. This is the name of the application.</param>
        /// <param name="value">The value of the application delta health
        /// policy map item. This is the ApplicationDeltaHealthPolicy for this
        /// application.</param>
        public ApplicationDeltaHealthPolicyMapItem(string key, ApplicationDeltaHealthPolicy value)
        {
            Key = key;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the key of the application delta health policy map
        /// item. This is the name of the application.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the value of the application delta health policy map
        /// item. This is the ApplicationDeltaHealthPolicy for this
        /// application.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public ApplicationDeltaHealthPolicy Value { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Key == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Key");
            }
            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
            if (Value != null)
            {
                Value.Validate();
            }
        }
    }
}
