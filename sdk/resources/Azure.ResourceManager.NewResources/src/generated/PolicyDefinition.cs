// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.NewResources
{
    /// <summary> A Class representing a PolicyDefinition along with the instance operations that can be performed on it. </summary>
    public class PolicyDefinition : PolicyDefinitionOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "PolicyDefinition"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal PolicyDefinition(ResourceOperationsBase options, PolicyDefinitionData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the PolicyDefinitionData. </summary>
        public PolicyDefinitionData Data { get; private set; }

        /// <inheritdoc />
        protected override PolicyDefinition GetResource(CancellationToken cancellation = default)
        {
            return this;
        }

        /// <inheritdoc />
        protected override Task<PolicyDefinition> GetResourceAsync(CancellationToken cancellation = default)
        {
            return Task.FromResult(this);
        }
    }
}
