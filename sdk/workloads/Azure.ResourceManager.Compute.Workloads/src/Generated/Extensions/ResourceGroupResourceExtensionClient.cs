// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Compute.Workloads
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

        /// <summary> Gets a collection of PhpWorkloadResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of PhpWorkloadResources and their operations over a PhpWorkloadResource. </returns>
        public virtual PhpWorkloadResourceCollection GetPhpWorkloadResources()
        {
            return GetCachedClient(Client => new PhpWorkloadResourceCollection(Client, Id));
        }

        /// <summary> Gets a collection of SapVirtualInstanceResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of SapVirtualInstanceResources and their operations over a SapVirtualInstanceResource. </returns>
        public virtual SapVirtualInstanceCollection GetSapVirtualInstances()
        {
            return GetCachedClient(Client => new SapVirtualInstanceCollection(Client, Id));
        }

        /// <summary> Gets a collection of SapMonitorResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of SapMonitorResources and their operations over a SapMonitorResource. </returns>
        public virtual SapMonitorCollection GetSapMonitors()
        {
            return GetCachedClient(Client => new SapMonitorCollection(Client, Id));
        }
    }
}
