// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.IotFirmwareDefense;

namespace Azure.ResourceManager.IotFirmwareDefense.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class IotFirmwareDefenseArmClientMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="IotFirmwareDefenseArmClientMockingExtension"/> class for mocking. </summary>
        protected IotFirmwareDefenseArmClientMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="IotFirmwareDefenseArmClientMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal IotFirmwareDefenseArmClientMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal IotFirmwareDefenseArmClientMockingExtension(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="FirmwareResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FirmwareResource.CreateResourceIdentifier" /> to create a <see cref="FirmwareResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FirmwareResource" /> object. </returns>
        public virtual FirmwareResource GetFirmwareResource(ResourceIdentifier id)
        {
            FirmwareResource.ValidateResourceId(id);
            return new FirmwareResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="FirmwareWorkspaceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FirmwareWorkspaceResource.CreateResourceIdentifier" /> to create a <see cref="FirmwareWorkspaceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FirmwareWorkspaceResource" /> object. </returns>
        public virtual FirmwareWorkspaceResource GetFirmwareWorkspaceResource(ResourceIdentifier id)
        {
            FirmwareWorkspaceResource.ValidateResourceId(id);
            return new FirmwareWorkspaceResource(Client, id);
        }
    }
}
