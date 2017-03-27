// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Fluent.ServiceBus.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Fluent;
    using Microsoft.Azure.Management.Fluent.ServiceBus;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Description of a namespace authorization rule.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SharedAccessAuthorizationRuleInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SharedAccessAuthorizationRuleInner class.
        /// </summary>
        public SharedAccessAuthorizationRuleInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SharedAccessAuthorizationRuleInner class.
        /// </summary>
        /// <param name="rights">The rights associated with the rule.</param>
        public SharedAccessAuthorizationRuleInner(IList<AccessRights?> rights, string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>))
            : base(location, id, name, type, tags)
        {
            Rights = rights;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the rights associated with the rule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.rights")]
        public IList<AccessRights?> Rights { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Rights == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Rights");
            }
        }
    }
}
