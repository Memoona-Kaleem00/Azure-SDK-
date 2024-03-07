// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary>
    /// Parameters to use when configuring Azure OpenAI On Your Data chat extensions when using Azure Cosmos DB for
    /// MongoDB vCore. The supported authentication type is ConnectionString.
    /// </summary>
    internal partial class AzureCosmosDBChatExtensionParameters
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AzureCosmosDBChatExtensionParameters"/>. </summary>
        /// <param name="databaseName"> The MongoDB vCore database name to use with Azure Cosmos DB. </param>
        /// <param name="containerName"> The name of the Azure Cosmos DB resource container. </param>
        /// <param name="indexName"> The MongoDB vCore index name to use with Azure Cosmos DB. </param>
        /// <param name="fieldMappingOptions"> Customized field mapping behavior to use when interacting with the search index. </param>
        /// <param name="embeddingDependency"> The embedding dependency for vector search. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/>, <paramref name="containerName"/>, <paramref name="indexName"/>, <paramref name="fieldMappingOptions"/> or <paramref name="embeddingDependency"/> is null. </exception>
        public AzureCosmosDBChatExtensionParameters(string databaseName, string containerName, string indexName, AzureCosmosDBFieldMappingOptions fieldMappingOptions, OnYourDataVectorizationSource embeddingDependency)
        {
            Argument.AssertNotNull(databaseName, nameof(databaseName));
            Argument.AssertNotNull(containerName, nameof(containerName));
            Argument.AssertNotNull(indexName, nameof(indexName));
            Argument.AssertNotNull(fieldMappingOptions, nameof(fieldMappingOptions));
            Argument.AssertNotNull(embeddingDependency, nameof(embeddingDependency));

            DatabaseName = databaseName;
            ContainerName = containerName;
            IndexName = indexName;
            FieldMappingOptions = fieldMappingOptions;
            EmbeddingDependency = embeddingDependency;
        }

        /// <summary> Initializes a new instance of <see cref="AzureCosmosDBChatExtensionParameters"/>. </summary>
        /// <param name="authentication">
        /// The authentication method to use when accessing the defined data source.
        /// Each data source type supports a specific set of available authentication methods; please see the documentation of
        /// the data source for supported mechanisms.
        /// If not otherwise provided, On Your Data will attempt to use System Managed Identity (default credential)
        /// authentication.
        /// </param>
        /// <param name="documentCount"> The configured top number of documents to feature for the configured query. </param>
        /// <param name="shouldRestrictResultScope"> Whether queries should be restricted to use of indexed data. </param>
        /// <param name="strictness"> The configured strictness of the search relevance filtering. The higher of strictness, the higher of the precision but lower recall of the answer. </param>
        /// <param name="roleInformation"> Give the model instructions about how it should behave and any context it should reference when generating a response. You can describe the assistant's personality and tell it how to format responses. There's a 100 token limit for it, and it counts against the overall token limit. </param>
        /// <param name="databaseName"> The MongoDB vCore database name to use with Azure Cosmos DB. </param>
        /// <param name="containerName"> The name of the Azure Cosmos DB resource container. </param>
        /// <param name="indexName"> The MongoDB vCore index name to use with Azure Cosmos DB. </param>
        /// <param name="fieldMappingOptions"> Customized field mapping behavior to use when interacting with the search index. </param>
        /// <param name="embeddingDependency"> The embedding dependency for vector search. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureCosmosDBChatExtensionParameters(OnYourDataAuthenticationOptions authentication, int? documentCount, bool? shouldRestrictResultScope, int? strictness, string roleInformation, string databaseName, string containerName, string indexName, AzureCosmosDBFieldMappingOptions fieldMappingOptions, OnYourDataVectorizationSource embeddingDependency, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Authentication = authentication;
            DocumentCount = documentCount;
            ShouldRestrictResultScope = shouldRestrictResultScope;
            Strictness = strictness;
            RoleInformation = roleInformation;
            DatabaseName = databaseName;
            ContainerName = containerName;
            IndexName = indexName;
            FieldMappingOptions = fieldMappingOptions;
            EmbeddingDependency = embeddingDependency;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The authentication method to use when accessing the defined data source.
        /// Each data source type supports a specific set of available authentication methods; please see the documentation of
        /// the data source for supported mechanisms.
        /// If not otherwise provided, On Your Data will attempt to use System Managed Identity (default credential)
        /// authentication.
        /// Please note <see cref="OnYourDataAuthenticationOptions"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="OnYourDataApiKeyAuthenticationOptions"/>, <see cref="OnYourDataConnectionStringAuthenticationOptions"/>, <see cref="OnYourDataKeyAndKeyIdAuthenticationOptions"/>, <see cref="OnYourDataEncodedApiKeyAuthenticationOptions"/>, <see cref="OnYourDataAccessTokenAuthenticationOptions"/>, <see cref="OnYourDataSystemAssignedManagedIdentityAuthenticationOptions"/> and <see cref="OnYourDataUserAssignedManagedIdentityAuthenticationOptions"/>.
        /// </summary>
        public OnYourDataAuthenticationOptions Authentication { get; set; }
        /// <summary> The configured top number of documents to feature for the configured query. </summary>
        public int? DocumentCount { get; set; }
        /// <summary> Whether queries should be restricted to use of indexed data. </summary>
        public bool? ShouldRestrictResultScope { get; set; }
        /// <summary> The configured strictness of the search relevance filtering. The higher of strictness, the higher of the precision but lower recall of the answer. </summary>
        public int? Strictness { get; set; }
        /// <summary> Give the model instructions about how it should behave and any context it should reference when generating a response. You can describe the assistant's personality and tell it how to format responses. There's a 100 token limit for it, and it counts against the overall token limit. </summary>
        public string RoleInformation { get; set; }
    }
}
