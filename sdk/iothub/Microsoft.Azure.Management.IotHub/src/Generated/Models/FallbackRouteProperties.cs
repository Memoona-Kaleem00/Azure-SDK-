// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.IotHub.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The properties of the fallback route. IoT Hub uses these properties
    /// when it routes messages to the fallback endpoint.
    /// </summary>
    public partial class FallbackRouteProperties
    {
        /// <summary>
        /// Initializes a new instance of the FallbackRouteProperties class.
        /// </summary>
        public FallbackRouteProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FallbackRouteProperties class.
        /// </summary>
        /// <param name="endpointNames">The list of endpoints to which the
        /// messages that satisfy the condition are routed to. Currently only 1
        /// endpoint is allowed.</param>
        /// <param name="isEnabled">Used to specify whether the fallback route
        /// is enabled.</param>
        /// <param name="name">The name of the route. The name can only include
        /// alphanumeric characters, periods, underscores, hyphens, has a
        /// maximum length of 64 characters, and must be unique.</param>
        /// <param name="condition">The condition which is evaluated in order
        /// to apply the fallback route. If the condition is not provided it
        /// will evaluate to true by default. For grammar, See:
        /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-query-language</param>
        public FallbackRouteProperties(IList<string> endpointNames, bool isEnabled, string name = default(string), string condition = default(string))
        {
            Name = name;
            Condition = condition;
            EndpointNames = endpointNames;
            IsEnabled = isEnabled;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for FallbackRouteProperties class.
        /// </summary>
        static FallbackRouteProperties()
        {
            Source = "DeviceMessages";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the route. The name can only include
        /// alphanumeric characters, periods, underscores, hyphens, has a
        /// maximum length of 64 characters, and must be unique.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the condition which is evaluated in order to apply the
        /// fallback route. If the condition is not provided it will evaluate
        /// to true by default. For grammar, See:
        /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-query-language
        /// </summary>
        [JsonProperty(PropertyName = "condition")]
        public string Condition { get; set; }

        /// <summary>
        /// Gets or sets the list of endpoints to which the messages that
        /// satisfy the condition are routed to. Currently only 1 endpoint is
        /// allowed.
        /// </summary>
        [JsonProperty(PropertyName = "endpointNames")]
        public IList<string> EndpointNames { get; set; }

        /// <summary>
        /// Gets or sets used to specify whether the fallback route is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "isEnabled")]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// The source to which the routing rule is to be applied to. For
        /// example, DeviceMessages
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public static string Source { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (EndpointNames == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "EndpointNames");
            }
            if (EndpointNames != null)
            {
                if (EndpointNames.Count > 1)
                {
                    throw new ValidationException(ValidationRules.MaxItems, "EndpointNames", 1);
                }
                if (EndpointNames.Count < 1)
                {
                    throw new ValidationException(ValidationRules.MinItems, "EndpointNames", 1);
                }
            }
        }
    }
}
