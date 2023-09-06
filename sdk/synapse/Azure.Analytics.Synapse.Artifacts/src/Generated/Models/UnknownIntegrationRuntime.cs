// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The UnknownIntegrationRuntime. </summary>
    internal partial class UnknownIntegrationRuntime : IntegrationRuntime
    {
        /// <summary> Initializes a new instance of <see cref="UnknownIntegrationRuntime"/>. </summary>
        /// <param name="type"> Type of integration runtime. </param>
        /// <param name="description"> Integration runtime description. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal UnknownIntegrationRuntime(IntegrationRuntimeType type, string description, IDictionary<string, object> additionalProperties) : base(type, description, additionalProperties)
        {
            Type = type;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownIntegrationRuntime"/> for deserialization. </summary>
        internal UnknownIntegrationRuntime()
        {
        }
    }
}
