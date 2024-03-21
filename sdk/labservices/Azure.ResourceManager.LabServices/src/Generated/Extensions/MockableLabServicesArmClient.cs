// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.LabServices.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableLabServicesArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableLabServicesArmClient"/> class for mocking. </summary>
        protected MockableLabServicesArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableLabServicesArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableLabServicesArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableLabServicesArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="LabVirtualMachineImageResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="LabVirtualMachineImageResource.CreateResourceIdentifier" /> to create a <see cref="LabVirtualMachineImageResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="LabVirtualMachineImageResource"/> object. </returns>
        public virtual LabVirtualMachineImageResource GetLabVirtualMachineImageResource(ResourceIdentifier id)
        {
            LabVirtualMachineImageResource.ValidateResourceId(id);
            return new LabVirtualMachineImageResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="LabPlanResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="LabPlanResource.CreateResourceIdentifier" /> to create a <see cref="LabPlanResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="LabPlanResource"/> object. </returns>
        public virtual LabPlanResource GetLabPlanResource(ResourceIdentifier id)
        {
            LabPlanResource.ValidateResourceId(id);
            return new LabPlanResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="LabResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="LabResource.CreateResourceIdentifier" /> to create a <see cref="LabResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="LabResource"/> object. </returns>
        public virtual LabResource GetLabResource(ResourceIdentifier id)
        {
            LabResource.ValidateResourceId(id);
            return new LabResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="LabServicesScheduleResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="LabServicesScheduleResource.CreateResourceIdentifier" /> to create a <see cref="LabServicesScheduleResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="LabServicesScheduleResource"/> object. </returns>
        public virtual LabServicesScheduleResource GetLabServicesScheduleResource(ResourceIdentifier id)
        {
            LabServicesScheduleResource.ValidateResourceId(id);
            return new LabServicesScheduleResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="LabUserResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="LabUserResource.CreateResourceIdentifier" /> to create a <see cref="LabUserResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="LabUserResource"/> object. </returns>
        public virtual LabUserResource GetLabUserResource(ResourceIdentifier id)
        {
            LabUserResource.ValidateResourceId(id);
            return new LabUserResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="LabVirtualMachineResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="LabVirtualMachineResource.CreateResourceIdentifier" /> to create a <see cref="LabVirtualMachineResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="LabVirtualMachineResource"/> object. </returns>
        public virtual LabVirtualMachineResource GetLabVirtualMachineResource(ResourceIdentifier id)
        {
            LabVirtualMachineResource.ValidateResourceId(id);
            return new LabVirtualMachineResource(Client, id);
        }
    }
}
