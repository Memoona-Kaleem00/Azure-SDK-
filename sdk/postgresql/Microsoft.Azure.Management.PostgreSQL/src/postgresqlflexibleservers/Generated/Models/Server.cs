// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PostgreSQL.FlexibleServers.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a server.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Server : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the Server class.
        /// </summary>
        public Server()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Server class.
        /// </summary>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="identity">The Azure Active Directory identity of the
        /// server.</param>
        /// <param name="sku">The SKU (pricing tier) of the server.</param>
        /// <param name="administratorLogin">The administrator's login name of
        /// a server. Can only be specified when the server is being created
        /// (and is required for creation).</param>
        /// <param name="administratorLoginPassword">The administrator login
        /// password (required for server creation).</param>
        /// <param name="version">PostgreSQL Server version. Possible values
        /// include: '12'</param>
        /// <param name="state">A state of a server that is visible to user.
        /// Possible values include: 'Ready', 'Dropping', 'Disabled',
        /// 'Starting', 'Stopping', 'Stopped', 'Updating'</param>
        /// <param name="haState">A state of a HA server that is visible to
        /// user. Possible values include: 'NotEnabled', 'CreatingStandby',
        /// 'ReplicatingData', 'FailingOver', 'Healthy',
        /// 'RemovingStandby'</param>
        /// <param name="fullyQualifiedDomainName">The fully qualified domain
        /// name of a server.</param>
        /// <param name="displayName">The display name of a server.</param>
        /// <param name="storageProfile">Storage profile of a server.</param>
        /// <param name="publicNetworkAccess">public network access is enabled
        /// or not. Possible values include: 'Enabled', 'Disabled'</param>
        /// <param name="standbyCount">stand by count value can be either 0 or
        /// 1</param>
        /// <param name="sourceServerName">The source PostgreSQL server name to
        /// restore from.</param>
        /// <param name="pointInTimeUTC">Restore point creation time (ISO8601
        /// format), specifying the time to restore from.</param>
        /// <param name="availabilityZone">availability Zone information of the
        /// server.</param>
        /// <param name="createMode">The mode to create a new PostgreSQL
        /// server. Possible values include: 'Default',
        /// 'PointInTimeRestore'</param>
        /// <param name="serverTags">Application-specific metadata in the form
        /// of key-value pairs.</param>
        public Server(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Identity identity = default(Identity), Sku sku = default(Sku), string administratorLogin = default(string), string administratorLoginPassword = default(string), string version = default(string), string state = default(string), string haState = default(string), string fullyQualifiedDomainName = default(string), string displayName = default(string), StorageProfile storageProfile = default(StorageProfile), string publicNetworkAccess = default(string), int? standbyCount = default(int?), string sourceServerName = default(string), System.DateTime? pointInTimeUTC = default(System.DateTime?), string availabilityZone = default(string), ServerPropertiesVnetInjArgs vnetInjArgs = default(ServerPropertiesVnetInjArgs), string createMode = default(string), IDictionary<string, string> serverTags = default(IDictionary<string, string>))
            : base(location, id, name, type, tags)
        {
            Identity = identity;
            Sku = sku;
            AdministratorLogin = administratorLogin;
            AdministratorLoginPassword = administratorLoginPassword;
            Version = version;
            State = state;
            HaState = haState;
            FullyQualifiedDomainName = fullyQualifiedDomainName;
            DisplayName = displayName;
            StorageProfile = storageProfile;
            PublicNetworkAccess = publicNetworkAccess;
            StandbyCount = standbyCount;
            SourceServerName = sourceServerName;
            PointInTimeUTC = pointInTimeUTC;
            AvailabilityZone = availabilityZone;
            VnetInjArgs = vnetInjArgs;
            CreateMode = createMode;
            ServerTags = serverTags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Azure Active Directory identity of the server.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public Identity Identity { get; set; }

        /// <summary>
        /// Gets or sets the SKU (pricing tier) of the server.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets the administrator's login name of a server. Can only
        /// be specified when the server is being created (and is required for
        /// creation).
        /// </summary>
        [JsonProperty(PropertyName = "properties.administratorLogin")]
        public string AdministratorLogin { get; set; }

        /// <summary>
        /// Gets or sets the administrator login password (required for server
        /// creation).
        /// </summary>
        [JsonProperty(PropertyName = "properties.administratorLoginPassword")]
        public string AdministratorLoginPassword { get; set; }

        /// <summary>
        /// Gets or sets postgreSQL Server version. Possible values include:
        /// '12'
        /// </summary>
        [JsonProperty(PropertyName = "properties.version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets a state of a server that is visible to user. Possible values
        /// include: 'Ready', 'Dropping', 'Disabled', 'Starting', 'Stopping',
        /// 'Stopped', 'Updating'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; private set; }

        /// <summary>
        /// Gets a state of a HA server that is visible to user. Possible
        /// values include: 'NotEnabled', 'CreatingStandby', 'ReplicatingData',
        /// 'FailingOver', 'Healthy', 'RemovingStandby'
        /// </summary>
        [JsonProperty(PropertyName = "properties.haState")]
        public string HaState { get; private set; }

        /// <summary>
        /// Gets the fully qualified domain name of a server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.fullyQualifiedDomainName")]
        public string FullyQualifiedDomainName { get; private set; }

        /// <summary>
        /// Gets or sets the display name of a server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets storage profile of a server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageProfile")]
        public StorageProfile StorageProfile { get; set; }

        /// <summary>
        /// Gets or sets public network access is enabled or not. Possible
        /// values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicNetworkAccess")]
        public string PublicNetworkAccess { get; set; }

        /// <summary>
        /// Gets or sets stand by count value can be either 0 or 1
        /// </summary>
        [JsonProperty(PropertyName = "properties.standbyCount")]
        public int? StandbyCount { get; set; }

        /// <summary>
        /// Gets or sets the source PostgreSQL server name to restore from.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourceServerName")]
        public string SourceServerName { get; set; }

        /// <summary>
        /// Gets or sets restore point creation time (ISO8601 format),
        /// specifying the time to restore from.
        /// </summary>
        [JsonProperty(PropertyName = "properties.pointInTimeUTC")]
        public System.DateTime? PointInTimeUTC { get; set; }

        /// <summary>
        /// Gets or sets availability Zone information of the server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.availabilityZone")]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.vnetInjArgs")]
        public ServerPropertiesVnetInjArgs VnetInjArgs { get; set; }

        /// <summary>
        /// Gets or sets the mode to create a new PostgreSQL server. Possible
        /// values include: 'Default', 'PointInTimeRestore'
        /// </summary>
        [JsonProperty(PropertyName = "properties.createMode")]
        public string CreateMode { get; set; }

        /// <summary>
        /// Gets or sets application-specific metadata in the form of key-value
        /// pairs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tags")]
        public IDictionary<string, string> ServerTags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}
