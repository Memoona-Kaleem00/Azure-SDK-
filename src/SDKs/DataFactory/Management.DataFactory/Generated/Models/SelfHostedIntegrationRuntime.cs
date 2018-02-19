// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Self-hosted integration runtime.
    /// </summary>
    [Newtonsoft.Json.JsonObject("SelfHosted")]
    [Rest.Serialization.JsonTransformation]
    public partial class SelfHostedIntegrationRuntime : IntegrationRuntime
    {
        /// <summary>
        /// Initializes a new instance of the SelfHostedIntegrationRuntime
        /// class.
        /// </summary>
        public SelfHostedIntegrationRuntime()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SelfHostedIntegrationRuntime
        /// class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="description">Integration runtime description.</param>
        public SelfHostedIntegrationRuntime(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string description = default(string), LinkedIntegrationRuntimeProperties linkedInfo = default(LinkedIntegrationRuntimeProperties))
            : base(additionalProperties, description)
        {
            LinkedInfo = linkedInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.linkedInfo")]
        public LinkedIntegrationRuntimeProperties LinkedInfo { get; set; }

    }
}
