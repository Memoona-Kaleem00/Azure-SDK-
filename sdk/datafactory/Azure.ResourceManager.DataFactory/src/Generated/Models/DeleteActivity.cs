// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary>
    /// Delete activity.
    /// Serialized Name: DeleteActivity
    /// </summary>
    public partial class DeleteActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of DeleteActivity. </summary>
        /// <param name="name">
        /// Activity name.
        /// Serialized Name: Activity.name
        /// </param>
        /// <param name="dataset">
        /// Delete activity dataset reference.
        /// Serialized Name: DeleteActivity.typeProperties.dataset
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="dataset"/> is null. </exception>
        public DeleteActivity(string name, DatasetReference dataset) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (dataset == null)
            {
                throw new ArgumentNullException(nameof(dataset));
            }

            Dataset = dataset;
            ActivityType = "Delete";
        }

        /// <summary> Initializes a new instance of DeleteActivity. </summary>
        /// <param name="name">
        /// Activity name.
        /// Serialized Name: Activity.name
        /// </param>
        /// <param name="activityType">
        /// Type of activity.
        /// Serialized Name: Activity.type
        /// </param>
        /// <param name="description">
        /// Activity description.
        /// Serialized Name: Activity.description
        /// </param>
        /// <param name="dependsOn">
        /// Activity depends on condition.
        /// Serialized Name: Activity.dependsOn
        /// </param>
        /// <param name="userProperties">
        /// Activity user properties.
        /// Serialized Name: Activity.userProperties
        /// </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName">
        /// Linked service reference.
        /// Serialized Name: ExecutionActivity.linkedServiceName
        /// </param>
        /// <param name="policy">
        /// Activity policy.
        /// Serialized Name: ExecutionActivity.policy
        /// </param>
        /// <param name="recursive">
        /// If true, files or sub-folders under current folder path will be deleted recursively. Default is false. Type: boolean (or Expression with resultType boolean).
        /// Serialized Name: DeleteActivity.typeProperties.recursive
        /// </param>
        /// <param name="maxConcurrentConnections">
        /// The max concurrent connections to connect data source at the same time.
        /// Serialized Name: DeleteActivity.typeProperties.maxConcurrentConnections
        /// </param>
        /// <param name="enableLogging">
        /// Whether to record detailed logs of delete-activity execution. Default value is false. Type: boolean (or Expression with resultType boolean).
        /// Serialized Name: DeleteActivity.typeProperties.enableLogging
        /// </param>
        /// <param name="logStorageSettings">
        /// Log storage settings customer need to provide when enableLogging is true.
        /// Serialized Name: DeleteActivity.typeProperties.logStorageSettings
        /// </param>
        /// <param name="dataset">
        /// Delete activity dataset reference.
        /// Serialized Name: DeleteActivity.typeProperties.dataset
        /// </param>
        /// <param name="storeSettings">
        /// Delete activity store settings.
        /// Serialized Name: DeleteActivity.typeProperties.storeSettings
        /// Please note <see cref="StoreReadSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonS3CompatibleReadSettings"/>, <see cref="AmazonS3ReadSettings"/>, <see cref="AzureBlobFSReadSettings"/>, <see cref="AzureBlobStorageReadSettings"/>, <see cref="AzureDataLakeStoreReadSettings"/>, <see cref="AzureFileStorageReadSettings"/>, <see cref="FileServerReadSettings"/>, <see cref="FtpReadSettings"/>, <see cref="GoogleCloudStorageReadSettings"/>, <see cref="HdfsReadSettings"/>, <see cref="HttpReadSettings"/>, <see cref="OracleCloudStorageReadSettings"/> and <see cref="SftpReadSettings"/>.
        /// </param>
        internal DeleteActivity(string name, string activityType, string description, IList<ActivityDependency> dependsOn, IList<ActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, FactoryLinkedServiceReference linkedServiceName, ActivityPolicy policy, BinaryData recursive, int? maxConcurrentConnections, BinaryData enableLogging, LogStorageSettings logStorageSettings, DatasetReference dataset, StoreReadSettings storeSettings) : base(name, activityType, description, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            Recursive = recursive;
            MaxConcurrentConnections = maxConcurrentConnections;
            EnableLogging = enableLogging;
            LogStorageSettings = logStorageSettings;
            Dataset = dataset;
            StoreSettings = storeSettings;
            ActivityType = activityType ?? "Delete";
        }

        /// <summary>
        /// If true, files or sub-folders under current folder path will be deleted recursively. Default is false. Type: boolean (or Expression with resultType boolean).
        /// Serialized Name: DeleteActivity.typeProperties.recursive
        /// </summary>
        public BinaryData Recursive { get; set; }
        /// <summary>
        /// The max concurrent connections to connect data source at the same time.
        /// Serialized Name: DeleteActivity.typeProperties.maxConcurrentConnections
        /// </summary>
        public int? MaxConcurrentConnections { get; set; }
        /// <summary>
        /// Whether to record detailed logs of delete-activity execution. Default value is false. Type: boolean (or Expression with resultType boolean).
        /// Serialized Name: DeleteActivity.typeProperties.enableLogging
        /// </summary>
        public BinaryData EnableLogging { get; set; }
        /// <summary>
        /// Log storage settings customer need to provide when enableLogging is true.
        /// Serialized Name: DeleteActivity.typeProperties.logStorageSettings
        /// </summary>
        public LogStorageSettings LogStorageSettings { get; set; }
        /// <summary>
        /// Delete activity dataset reference.
        /// Serialized Name: DeleteActivity.typeProperties.dataset
        /// </summary>
        public DatasetReference Dataset { get; set; }
        /// <summary>
        /// Delete activity store settings.
        /// Serialized Name: DeleteActivity.typeProperties.storeSettings
        /// Please note <see cref="StoreReadSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonS3CompatibleReadSettings"/>, <see cref="AmazonS3ReadSettings"/>, <see cref="AzureBlobFSReadSettings"/>, <see cref="AzureBlobStorageReadSettings"/>, <see cref="AzureDataLakeStoreReadSettings"/>, <see cref="AzureFileStorageReadSettings"/>, <see cref="FileServerReadSettings"/>, <see cref="FtpReadSettings"/>, <see cref="GoogleCloudStorageReadSettings"/>, <see cref="HdfsReadSettings"/>, <see cref="HttpReadSettings"/>, <see cref="OracleCloudStorageReadSettings"/> and <see cref="SftpReadSettings"/>.
        /// </summary>
        public StoreReadSettings StoreSettings { get; set; }
    }
}
