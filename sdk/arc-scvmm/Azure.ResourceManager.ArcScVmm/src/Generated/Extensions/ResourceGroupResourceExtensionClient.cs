// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ArcScVmm
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    internal partial class ResourceGroupResourceExtensionClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class for mocking. </summary>
        protected ResourceGroupResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ScVmmServerResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ScVmmServerResources and their operations over a ScVmmServerResource. </returns>
        public virtual ScVmmServerCollection GetScVmmServers()
        {
            return GetCachedClient(Client => new ScVmmServerCollection(Client, Id));
        }

        /// <summary> Gets a collection of ScVmmCloudResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ScVmmCloudResources and their operations over a ScVmmCloudResource. </returns>
        public virtual ScVmmCloudCollection GetScVmmClouds()
        {
            return GetCachedClient(Client => new ScVmmCloudCollection(Client, Id));
        }

        /// <summary> Gets a collection of ScVmmVirtualNetworkResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ScVmmVirtualNetworkResources and their operations over a ScVmmVirtualNetworkResource. </returns>
        public virtual ScVmmVirtualNetworkCollection GetScVmmVirtualNetworks()
        {
            return GetCachedClient(Client => new ScVmmVirtualNetworkCollection(Client, Id));
        }

        /// <summary> Gets a collection of ScVmmVirtualMachineResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ScVmmVirtualMachineResources and their operations over a ScVmmVirtualMachineResource. </returns>
        public virtual ScVmmVirtualMachineCollection GetScVmmVirtualMachines()
        {
            return GetCachedClient(Client => new ScVmmVirtualMachineCollection(Client, Id));
        }

        /// <summary> Gets a collection of ScVmmVirtualMachineTemplateResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ScVmmVirtualMachineTemplateResources and their operations over a ScVmmVirtualMachineTemplateResource. </returns>
        public virtual ScVmmVirtualMachineTemplateCollection GetScVmmVirtualMachineTemplates()
        {
            return GetCachedClient(Client => new ScVmmVirtualMachineTemplateCollection(Client, Id));
        }

        /// <summary> Gets a collection of ScVmmAvailabilitySetResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ScVmmAvailabilitySetResources and their operations over a ScVmmAvailabilitySetResource. </returns>
        public virtual ScVmmAvailabilitySetCollection GetScVmmAvailabilitySets()
        {
            return GetCachedClient(Client => new ScVmmAvailabilitySetCollection(Client, Id));
        }
    }
}
