// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DataMigration.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataMigration
{
    /// <summary>
    /// A class representing the Project data model.
    /// A project resource
    /// </summary>
    public partial class ProjectData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ProjectData"/>. </summary>
        /// <param name="location"> The location. </param>
        public ProjectData(AzureLocation location) : base(location)
        {
            DatabasesInfo = new ChangeTrackingList<DatabaseInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="ProjectData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> HTTP strong entity tag value. This is ignored if submitted. </param>
        /// <param name="sourcePlatform"> Source platform for the project. </param>
        /// <param name="azureAuthenticationInfo"> Field that defines the Azure active directory application info, used to connect to the target Azure resource. </param>
        /// <param name="targetPlatform"> Target platform for the project. </param>
        /// <param name="createdOn"> UTC Date and time when project was created. </param>
        /// <param name="sourceConnectionInfo">
        /// Information for connecting to source
        /// Please note <see cref="ConnectionInfo"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MISqlConnectionInfo"/>, <see cref="MongoDBConnectionInfo"/>, <see cref="MySqlConnectionInfo"/>, <see cref="OracleConnectionInfo"/>, <see cref="PostgreSqlConnectionInfo"/> and <see cref="SqlConnectionInfo"/>.
        /// </param>
        /// <param name="targetConnectionInfo">
        /// Information for connecting to target
        /// Please note <see cref="ConnectionInfo"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MISqlConnectionInfo"/>, <see cref="MongoDBConnectionInfo"/>, <see cref="MySqlConnectionInfo"/>, <see cref="OracleConnectionInfo"/>, <see cref="PostgreSqlConnectionInfo"/> and <see cref="SqlConnectionInfo"/>.
        /// </param>
        /// <param name="databasesInfo"> List of DatabaseInfo. </param>
        /// <param name="provisioningState"> The project's provisioning state. </param>
        internal ProjectData(ResourceIdentifier id, string name, Core.ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ETag? etag, ProjectSourcePlatform? sourcePlatform, AzureActiveDirectoryApp azureAuthenticationInfo, ProjectTargetPlatform? targetPlatform, DateTimeOffset? createdOn, ConnectionInfo sourceConnectionInfo, ConnectionInfo targetConnectionInfo, IList<DatabaseInfo> databasesInfo, ProjectProvisioningState? provisioningState) : base(id, name, resourceType, systemData, tags, location)
        {
            ETag = etag;
            SourcePlatform = sourcePlatform;
            AzureAuthenticationInfo = azureAuthenticationInfo;
            TargetPlatform = targetPlatform;
            CreatedOn = createdOn;
            SourceConnectionInfo = sourceConnectionInfo;
            TargetConnectionInfo = targetConnectionInfo;
            DatabasesInfo = databasesInfo;
            ProvisioningState = provisioningState;
        }

        /// <summary> HTTP strong entity tag value. This is ignored if submitted. </summary>
        public ETag? ETag { get; set; }
        /// <summary> Source platform for the project. </summary>
        public ProjectSourcePlatform? SourcePlatform { get; set; }
        /// <summary> Field that defines the Azure active directory application info, used to connect to the target Azure resource. </summary>
        public AzureActiveDirectoryApp AzureAuthenticationInfo { get; set; }
        /// <summary> Target platform for the project. </summary>
        public ProjectTargetPlatform? TargetPlatform { get; set; }
        /// <summary> UTC Date and time when project was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary>
        /// Information for connecting to source
        /// Please note <see cref="ConnectionInfo"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MISqlConnectionInfo"/>, <see cref="MongoDBConnectionInfo"/>, <see cref="MySqlConnectionInfo"/>, <see cref="OracleConnectionInfo"/>, <see cref="PostgreSqlConnectionInfo"/> and <see cref="SqlConnectionInfo"/>.
        /// </summary>
        public ConnectionInfo SourceConnectionInfo { get; set; }
        /// <summary>
        /// Information for connecting to target
        /// Please note <see cref="ConnectionInfo"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MISqlConnectionInfo"/>, <see cref="MongoDBConnectionInfo"/>, <see cref="MySqlConnectionInfo"/>, <see cref="OracleConnectionInfo"/>, <see cref="PostgreSqlConnectionInfo"/> and <see cref="SqlConnectionInfo"/>.
        /// </summary>
        public ConnectionInfo TargetConnectionInfo { get; set; }
        /// <summary> List of DatabaseInfo. </summary>
        public IList<DatabaseInfo> DatabasesInfo { get; }
        /// <summary> The project's provisioning state. </summary>
        public ProjectProvisioningState? ProvisioningState { get; }
    }
}
