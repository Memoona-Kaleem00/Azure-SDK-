// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Integration runtime debug resource. </summary>
    public partial class IntegrationRuntimeDebugResource : SubResourceDebugResource
    {
        /// <summary> Initializes a new instance of <see cref="IntegrationRuntimeDebugResource"/>. </summary>
        /// <param name="properties">
        /// Integration runtime properties.
        /// Please note <see cref="IntegrationRuntime"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ManagedIntegrationRuntime"/> and <see cref="SelfHostedIntegrationRuntime"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public IntegrationRuntimeDebugResource(IntegrationRuntime properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationRuntimeDebugResource"/>. </summary>
        /// <param name="name"> The resource name. </param>
        /// <param name="properties">
        /// Integration runtime properties.
        /// Please note <see cref="IntegrationRuntime"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ManagedIntegrationRuntime"/> and <see cref="SelfHostedIntegrationRuntime"/>.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal IntegrationRuntimeDebugResource(string name, IntegrationRuntime properties, Dictionary<string, BinaryData> rawData) : base(name, rawData)
        {
            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationRuntimeDebugResource"/> for deserialization. </summary>
        internal IntegrationRuntimeDebugResource()
        {
        }

        /// <summary>
        /// Integration runtime properties.
        /// Please note <see cref="IntegrationRuntime"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ManagedIntegrationRuntime"/> and <see cref="SelfHostedIntegrationRuntime"/>.
        /// </summary>
        public IntegrationRuntime Properties { get; set; }
    }
}
