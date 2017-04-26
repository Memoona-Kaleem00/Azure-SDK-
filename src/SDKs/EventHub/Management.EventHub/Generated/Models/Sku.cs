// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.EventHub.Models
{
    using Azure;
    using Management;
    using EventHub;
    using Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// SKU parameters supplied to the create Namespace operation
    /// </summary>
    public partial class Sku
    {
        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        public Sku() { }

        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        /// <param name="tier">The billing tier of this particular SKU.
        /// Possible values include: 'Basic', 'Standard', 'Premium'</param>
        /// <param name="name">Name of this SKU. Possible values include:
        /// 'Basic', 'Standard'</param>
        /// <param name="capacity">The Event Hubs throughput units.</param>
        public Sku(string tier, string name = default(string), int? capacity = default(int?))
        {
            Name = name;
            Tier = tier;
            Capacity = capacity;
        }

        /// <summary>
        /// Gets or sets name of this SKU. Possible values include: 'Basic',
        /// 'Standard'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the billing tier of this particular SKU. Possible
        /// values include: 'Basic', 'Standard', 'Premium'
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public string Tier { get; set; }

        /// <summary>
        /// Gets or sets the Event Hubs throughput units.
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public int? Capacity { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Tier == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Tier");
            }
        }
    }
}

