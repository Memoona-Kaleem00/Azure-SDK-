// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Linked service for MongoDB Atlas data source. </summary>
    public partial class MongoDbAtlasLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of <see cref="MongoDbAtlasLinkedService"/>. </summary>
        /// <param name="connectionString"> The MongoDB Atlas connection string. Type: string, SecureString or AzureKeyVaultSecretReference. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        /// <param name="database"> The name of the MongoDB Atlas database that you want to access. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionString"/> or <paramref name="database"/> is null. </exception>
        public MongoDbAtlasLinkedService(object connectionString, object database)
        {
            Argument.AssertNotNull(connectionString, nameof(connectionString));
            Argument.AssertNotNull(database, nameof(database));

            ConnectionString = connectionString;
            Database = database;
            Type = "MongoDbAtlas";
        }

        /// <summary> Initializes a new instance of <see cref="MongoDbAtlasLinkedService"/>. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="connectionString"> The MongoDB Atlas connection string. Type: string, SecureString or AzureKeyVaultSecretReference. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        /// <param name="database"> The name of the MongoDB Atlas database that you want to access. Type: string (or Expression with resultType string). </param>
        /// <param name="driverVersion"> The driver version that you want to choose. Allowed value are v1 and v2. Type: string (or Expression with resultType string). </param>
        internal MongoDbAtlasLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object connectionString, object database, object driverVersion) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            ConnectionString = connectionString;
            Database = database;
            DriverVersion = driverVersion;
            Type = type ?? "MongoDbAtlas";
        }

        /// <summary> The MongoDB Atlas connection string. Type: string, SecureString or AzureKeyVaultSecretReference. Type: string, SecureString or AzureKeyVaultSecretReference. </summary>
        public object ConnectionString { get; set; }
        /// <summary> The name of the MongoDB Atlas database that you want to access. Type: string (or Expression with resultType string). </summary>
        public object Database { get; set; }
        /// <summary> The driver version that you want to choose. Allowed value are v1 and v2. Type: string (or Expression with resultType string). </summary>
        public object DriverVersion { get; set; }
    }
}
