// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Kusto;

namespace Azure.ResourceManager.Kusto.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class KustoArmClientMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="KustoArmClientMockingExtension"/> class for mocking. </summary>
        protected KustoArmClientMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="KustoArmClientMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal KustoArmClientMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal KustoArmClientMockingExtension(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="KustoClusterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="KustoClusterResource.CreateResourceIdentifier" /> to create a <see cref="KustoClusterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="KustoClusterResource" /> object. </returns>
        public virtual KustoClusterResource GetKustoClusterResource(ResourceIdentifier id)
        {
            KustoClusterResource.ValidateResourceId(id);
            return new KustoClusterResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="KustoClusterPrincipalAssignmentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="KustoClusterPrincipalAssignmentResource.CreateResourceIdentifier" /> to create a <see cref="KustoClusterPrincipalAssignmentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="KustoClusterPrincipalAssignmentResource" /> object. </returns>
        public virtual KustoClusterPrincipalAssignmentResource GetKustoClusterPrincipalAssignmentResource(ResourceIdentifier id)
        {
            KustoClusterPrincipalAssignmentResource.ValidateResourceId(id);
            return new KustoClusterPrincipalAssignmentResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="KustoDatabaseResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="KustoDatabaseResource.CreateResourceIdentifier" /> to create a <see cref="KustoDatabaseResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="KustoDatabaseResource" /> object. </returns>
        public virtual KustoDatabaseResource GetKustoDatabaseResource(ResourceIdentifier id)
        {
            KustoDatabaseResource.ValidateResourceId(id);
            return new KustoDatabaseResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="KustoAttachedDatabaseConfigurationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="KustoAttachedDatabaseConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="KustoAttachedDatabaseConfigurationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="KustoAttachedDatabaseConfigurationResource" /> object. </returns>
        public virtual KustoAttachedDatabaseConfigurationResource GetKustoAttachedDatabaseConfigurationResource(ResourceIdentifier id)
        {
            KustoAttachedDatabaseConfigurationResource.ValidateResourceId(id);
            return new KustoAttachedDatabaseConfigurationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="KustoManagedPrivateEndpointResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="KustoManagedPrivateEndpointResource.CreateResourceIdentifier" /> to create a <see cref="KustoManagedPrivateEndpointResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="KustoManagedPrivateEndpointResource" /> object. </returns>
        public virtual KustoManagedPrivateEndpointResource GetKustoManagedPrivateEndpointResource(ResourceIdentifier id)
        {
            KustoManagedPrivateEndpointResource.ValidateResourceId(id);
            return new KustoManagedPrivateEndpointResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="KustoDatabasePrincipalAssignmentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="KustoDatabasePrincipalAssignmentResource.CreateResourceIdentifier" /> to create a <see cref="KustoDatabasePrincipalAssignmentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="KustoDatabasePrincipalAssignmentResource" /> object. </returns>
        public virtual KustoDatabasePrincipalAssignmentResource GetKustoDatabasePrincipalAssignmentResource(ResourceIdentifier id)
        {
            KustoDatabasePrincipalAssignmentResource.ValidateResourceId(id);
            return new KustoDatabasePrincipalAssignmentResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="KustoScriptResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="KustoScriptResource.CreateResourceIdentifier" /> to create a <see cref="KustoScriptResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="KustoScriptResource" /> object. </returns>
        public virtual KustoScriptResource GetKustoScriptResource(ResourceIdentifier id)
        {
            KustoScriptResource.ValidateResourceId(id);
            return new KustoScriptResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="KustoPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="KustoPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="KustoPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="KustoPrivateEndpointConnectionResource" /> object. </returns>
        public virtual KustoPrivateEndpointConnectionResource GetKustoPrivateEndpointConnectionResource(ResourceIdentifier id)
        {
            KustoPrivateEndpointConnectionResource.ValidateResourceId(id);
            return new KustoPrivateEndpointConnectionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="KustoPrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="KustoPrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="KustoPrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="KustoPrivateLinkResource" /> object. </returns>
        public virtual KustoPrivateLinkResource GetKustoPrivateLinkResource(ResourceIdentifier id)
        {
            KustoPrivateLinkResource.ValidateResourceId(id);
            return new KustoPrivateLinkResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="KustoDataConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="KustoDataConnectionResource.CreateResourceIdentifier" /> to create a <see cref="KustoDataConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="KustoDataConnectionResource" /> object. </returns>
        public virtual KustoDataConnectionResource GetKustoDataConnectionResource(ResourceIdentifier id)
        {
            KustoDataConnectionResource.ValidateResourceId(id);
            return new KustoDataConnectionResource(Client, id);
        }
    }
}
