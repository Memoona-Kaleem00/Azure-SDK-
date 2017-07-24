// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.NotificationHubs.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.NotificationHubs;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Parameters supplied to the CreateOrUpdate Namespace AuthorizationRules.
    /// </summary>
    public partial class SharedAccessAuthorizationRuleCreateOrUpdateParameters : Resource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SharedAccessAuthorizationRuleCreateOrUpdateParameters class.
        /// </summary>
        public SharedAccessAuthorizationRuleCreateOrUpdateParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SharedAccessAuthorizationRuleCreateOrUpdateParameters class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="properties">Properties of the Namespace
        /// AuthorizationRules.</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="sku">The sku of the created namespace</param>
        public SharedAccessAuthorizationRuleCreateOrUpdateParameters(string location, SharedAccessAuthorizationRuleProperties properties, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Sku sku = default(Sku))
            : base(location, id, name, type, tags, sku)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets properties of the Namespace AuthorizationRules.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public SharedAccessAuthorizationRuleProperties Properties { get; set; }

    }
}
