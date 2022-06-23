// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the url signing action for the delivery rule. </summary>
    public partial class UriSigningAction : DeliveryRuleAction
    {
        /// <summary> Initializes a new instance of UriSigningAction. </summary>
        /// <param name="properties"> Defines the parameters for the action. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public UriSigningAction(UriSigningActionProperties properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
            Name = DeliveryRuleActionType.UriSigning;
        }

        /// <summary> Initializes a new instance of UriSigningAction. </summary>
        /// <param name="name"> The name of the action for the delivery rule. </param>
        /// <param name="properties"> Defines the parameters for the action. </param>
        internal UriSigningAction(DeliveryRuleActionType name, UriSigningActionProperties properties) : base(name)
        {
            Properties = properties;
            Name = name;
        }

        /// <summary> Defines the parameters for the action. </summary>
        public UriSigningActionProperties Properties { get; set; }
    }
}
