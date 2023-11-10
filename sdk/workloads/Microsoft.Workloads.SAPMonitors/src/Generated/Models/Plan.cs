// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Workloads.SAPMonitors.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Plan for the resource.
    /// </summary>
    public partial class Plan
    {
        /// <summary>
        /// Initializes a new instance of the Plan class.
        /// </summary>
        public Plan()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Plan class.
        /// </summary>
        /// <param name="name">A user defined name of the 3rd Party Artifact
        /// that is being procured.</param>
        /// <param name="publisher">The publisher of the 3rd Party Artifact
        /// that is being bought. E.g. NewRelic</param>
        /// <param name="product">The 3rd Party artifact that is being
        /// procured. E.g. NewRelic. Product maps to the OfferID specified for
        /// the artifact at the time of Data Market onboarding. </param>
        /// <param name="promotionCode">A publisher provided promotion code as
        /// provisioned in Data Market for the said product/artifact.</param>
        /// <param name="version">The version of the desired
        /// product/artifact.</param>
        public Plan(string name, string publisher, string product, string promotionCode = default(string), string version = default(string))
        {
            Name = name;
            Publisher = publisher;
            Product = product;
            PromotionCode = promotionCode;
            Version = version;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a user defined name of the 3rd Party Artifact that is
        /// being procured.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the publisher of the 3rd Party Artifact that is being
        /// bought. E.g. NewRelic
        /// </summary>
        [JsonProperty(PropertyName = "publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// Gets or sets the 3rd Party artifact that is being procured. E.g.
        /// NewRelic. Product maps to the OfferID specified for the artifact at
        /// the time of Data Market onboarding.
        /// </summary>
        [JsonProperty(PropertyName = "product")]
        public string Product { get; set; }

        /// <summary>
        /// Gets or sets a publisher provided promotion code as provisioned in
        /// Data Market for the said product/artifact.
        /// </summary>
        [JsonProperty(PropertyName = "promotionCode")]
        public string PromotionCode { get; set; }

        /// <summary>
        /// Gets or sets the version of the desired product/artifact.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Publisher == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Publisher");
            }
            if (Product == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Product");
            }
        }
    }
}
