// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes an automation rule action to modify an object's properties
    /// </summary>
    [Newtonsoft.Json.JsonObject("ModifyProperties")]
    public partial class AutomationRuleModifyPropertiesAction : AutomationRuleAction
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AutomationRuleModifyPropertiesAction class.
        /// </summary>
        public AutomationRuleModifyPropertiesAction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AutomationRuleModifyPropertiesAction class.
        /// </summary>
        public AutomationRuleModifyPropertiesAction(int order, IncidentPropertiesAction actionConfiguration = default(IncidentPropertiesAction))
            : base(order)
        {
            ActionConfiguration = actionConfiguration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "actionConfiguration")]
        public IncidentPropertiesAction ActionConfiguration { get; set; }

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
