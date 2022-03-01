// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.EventHubs
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    internal partial class ResourceGroupExtensionClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="ResourceGroupExtensionClient"/> class for mocking. </summary>
        protected ResourceGroupExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of EventHubClusters in the EventHubCluster. </summary>
        /// <returns> An object representing collection of EventHubClusters and their operations over a EventHubCluster. </returns>
        public virtual EventHubClusterCollection GetEventHubClusters()
        {
            return new EventHubClusterCollection(Client, Id);
        }

        /// <summary> Gets a collection of EventHubNamespaces in the EventHubNamespace. </summary>
        /// <returns> An object representing collection of EventHubNamespaces and their operations over a EventHubNamespace. </returns>
        public virtual EventHubNamespaceCollection GetEventHubNamespaces()
        {
            return new EventHubNamespaceCollection(Client, Id);
        }
    }
}
