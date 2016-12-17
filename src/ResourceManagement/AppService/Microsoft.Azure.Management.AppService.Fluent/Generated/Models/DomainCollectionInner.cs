// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Collection of domains.
    /// </summary>
    public partial class DomainCollectionInner
    {
        /// <summary>
        /// Initializes a new instance of the DomainCollectionInner class.
        /// </summary>
        public DomainCollectionInner() { }

        /// <summary>
        /// Initializes a new instance of the DomainCollectionInner class.
        /// </summary>
        /// <param name="value">Collection of resources.</param>
        /// <param name="nextLink">Link to next page of resources.</param>
        public DomainCollectionInner(System.Collections.Generic.IList<DomainInner> value, string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Gets or sets collection of resources.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.IList<DomainInner> Value { get; set; }

        /// <summary>
        /// Gets or sets link to next page of resources.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Value == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Value");
            }
            if (this.Value != null)
            {
                foreach (var element in this.Value)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
