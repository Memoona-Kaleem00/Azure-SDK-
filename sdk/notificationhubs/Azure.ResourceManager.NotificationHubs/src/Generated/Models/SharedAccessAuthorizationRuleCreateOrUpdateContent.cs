// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    /// <summary> Parameters supplied to the CreateOrUpdate Namespace AuthorizationRules. </summary>
    public partial class SharedAccessAuthorizationRuleCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of <see cref="SharedAccessAuthorizationRuleCreateOrUpdateContent"/>. </summary>
        /// <param name="properties"> Properties of the Namespace AuthorizationRules. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public SharedAccessAuthorizationRuleCreateOrUpdateContent(SharedAccessAuthorizationRuleProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Properties of the Namespace AuthorizationRules. </summary>
        public SharedAccessAuthorizationRuleProperties Properties { get; }
    }
}
