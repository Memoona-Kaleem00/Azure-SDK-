// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Represents a datasource definition, which can be used to configure an indexer. </summary>
    public partial class SearchIndexerDataSourceConnection
    {

        /// <summary> Initializes a new instance of SearchIndexerDataSourceConnection. </summary>
        /// <param name="name"> The name of the datasource. </param>
        /// <param name="description"> The description of the datasource. </param>
        /// <param name="type"> The type of the datasource. </param>
        /// <param name="credentialsInternal"> Credentials for the datasource. </param>
        /// <param name="container"> The data container for the datasource. </param>
        /// <param name="identity"> An explicit managed identity to use for this datasource. If not specified and the connection string is a managed identity, the system-assigned managed identity is used. If not specified, the value remains unchanged. If &quot;none&quot; is specified, the value of this property is cleared. </param>
        /// <param name="dataChangeDetectionPolicy"> The data change detection policy for the datasource. </param>
        /// <param name="dataDeletionDetectionPolicy"> The data deletion detection policy for the datasource. </param>
        /// <param name="Etag"> The ETag of the data source. </param>
        /// <param name="encryptionKey"> A description of an encryption key that you create in Azure Key Vault. This key is used to provide an additional level of encryption-at-rest for your datasource definition when you want full assurance that no one, not even Microsoft, can decrypt your data source definition in Azure Cognitive Search. Once you have encrypted your data source definition, it will always remain encrypted. Azure Cognitive Search will ignore attempts to set this property to null. You can change this property as needed if you want to rotate your encryption key; Your datasource definition will be unaffected. Encryption with customer-managed keys is not available for free search services, and is only available for paid services created on or after January 1, 2019. </param>
        internal SearchIndexerDataSourceConnection(string name, string description, SearchIndexerDataSourceType type, DataSourceCredentials credentialsInternal, SearchIndexerDataContainer container, SearchIndexerDataIdentity identity, DataChangeDetectionPolicy dataChangeDetectionPolicy, DataDeletionDetectionPolicy dataDeletionDetectionPolicy, string Etag, SearchResourceEncryptionKey encryptionKey)
        {
            Name = name;
            Description = description;
            Type = type;
            CredentialsInternal = credentialsInternal;
            Container = container;
            Identity = identity;
            DataChangeDetectionPolicy = dataChangeDetectionPolicy;
            DataDeletionDetectionPolicy = dataDeletionDetectionPolicy;
            _etag = Etag;
            EncryptionKey = encryptionKey;
        }

        /// <summary> The name of the datasource. </summary>
        public string Name { get; set; }
        /// <summary> The description of the datasource. </summary>
        public string Description { get; set; }
        /// <summary> The type of the datasource. </summary>
        public SearchIndexerDataSourceType Type { get; set; }
        /// <summary> The data container for the datasource. </summary>
        public SearchIndexerDataContainer Container { get; set; }
        /// <summary> An explicit managed identity to use for this datasource. If not specified and the connection string is a managed identity, the system-assigned managed identity is used. If not specified, the value remains unchanged. If &quot;none&quot; is specified, the value of this property is cleared. </summary>
        public SearchIndexerDataIdentity Identity { get; set; }
        /// <summary> The data change detection policy for the datasource. </summary>
        public DataChangeDetectionPolicy DataChangeDetectionPolicy { get; set; }
        /// <summary> The data deletion detection policy for the datasource. </summary>
        public DataDeletionDetectionPolicy DataDeletionDetectionPolicy { get; set; }
        /// <summary> A description of an encryption key that you create in Azure Key Vault. This key is used to provide an additional level of encryption-at-rest for your datasource definition when you want full assurance that no one, not even Microsoft, can decrypt your data source definition in Azure Cognitive Search. Once you have encrypted your data source definition, it will always remain encrypted. Azure Cognitive Search will ignore attempts to set this property to null. You can change this property as needed if you want to rotate your encryption key; Your datasource definition will be unaffected. Encryption with customer-managed keys is not available for free search services, and is only available for paid services created on or after January 1, 2019. </summary>
        public SearchResourceEncryptionKey EncryptionKey { get; set; }
    }
}
