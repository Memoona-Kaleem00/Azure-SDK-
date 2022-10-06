// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Managed integration runtime, including managed elastic and managed dedicated integration runtimes. </summary>
    public partial class ManagedIntegrationRuntime : IntegrationRuntime
    {
        /// <summary> Initializes a new instance of ManagedIntegrationRuntime. </summary>
        public ManagedIntegrationRuntime()
        {
            RuntimeType = IntegrationRuntimeType.Managed;
        }

        /// <summary> Initializes a new instance of ManagedIntegrationRuntime. </summary>
        /// <param name="runtimeType"> Type of integration runtime. </param>
        /// <param name="description"> Integration runtime description. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="state"> Integration runtime state, only valid for managed dedicated integration runtime. </param>
        /// <param name="referenceName"> The reference name of the managed virtual network. </param>
        /// <param name="typeManagedVirtualNetworkType"> The type of the managed virtual network. </param>
        /// <param name="id"> The id of the managed virtual network. </param>
        /// <param name="computeProperties"> The compute resource for managed integration runtime. </param>
        /// <param name="ssisProperties"> SSIS properties for managed integration runtime. </param>
        internal ManagedIntegrationRuntime(IntegrationRuntimeType runtimeType, string description, IDictionary<string, BinaryData> additionalProperties, IntegrationRuntimeState? state, string referenceName, string typeManagedVirtualNetworkType, string id, IntegrationRuntimeComputeProperties computeProperties, IntegrationRuntimeSsisProperties ssisProperties) : base(runtimeType, description, additionalProperties)
        {
            State = state;
            ReferenceName = referenceName;
            TypeManagedVirtualNetworkType = typeManagedVirtualNetworkType;
            Id = id;
            ComputeProperties = computeProperties;
            SsisProperties = ssisProperties;
            RuntimeType = runtimeType;
        }

        /// <summary> Integration runtime state, only valid for managed dedicated integration runtime. </summary>
        public IntegrationRuntimeState? State { get; }
        /// <summary> The reference name of the managed virtual network. </summary>
        public string ReferenceName { get; set; }
        /// <summary> The type of the managed virtual network. </summary>
        public string TypeManagedVirtualNetworkType { get; set; }
        /// <summary> The id of the managed virtual network. </summary>
        public string Id { get; set; }
        /// <summary> The compute resource for managed integration runtime. </summary>
        public IntegrationRuntimeComputeProperties ComputeProperties { get; set; }
        /// <summary> SSIS properties for managed integration runtime. </summary>
        public IntegrationRuntimeSsisProperties SsisProperties { get; set; }
    }
}
