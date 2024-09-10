// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// This connection type covers the generic ApiKey auth connection categories, for examples:
    /// AzureOpenAI:
    ///     Category:= AzureOpenAI
    ///     AuthType:= ApiKey (as type discriminator)
    ///     Credentials:= {ApiKey} as Microsoft.MachineLearning.AccountRP.Contracts.WorkspaceConnection.ApiKey
    ///     Target:= {ApiBase}
    ///
    /// CognitiveService:
    ///     Category:= CognitiveService
    ///     AuthType:= ApiKey (as type discriminator)
    ///     Credentials:= {SubscriptionKey} as Microsoft.MachineLearning.AccountRP.Contracts.WorkspaceConnection.ApiKey
    ///     Target:= ServiceRegion={serviceRegion}
    ///
    /// CognitiveSearch:
    ///     Category:= CognitiveSearch
    ///     AuthType:= ApiKey (as type discriminator)
    ///     Credentials:= {Key} as Microsoft.MachineLearning.AccountRP.Contracts.WorkspaceConnection.ApiKey
    ///     Target:= {Endpoint}
    ///
    /// Use Metadata property bag for ApiType, ApiVersion, Kind and other metadata fields
    /// </summary>
    public partial class ApiKeyAuthWorkspaceConnectionProperties : MachineLearningWorkspaceConnectionProperties
    {
        /// <summary> Initializes a new instance of <see cref="ApiKeyAuthWorkspaceConnectionProperties"/>. </summary>
        public ApiKeyAuthWorkspaceConnectionProperties()
        {
            AuthType = MachineLearningConnectionAuthType.ApiKey;
        }

        /// <summary> Initializes a new instance of <see cref="ApiKeyAuthWorkspaceConnectionProperties"/>. </summary>
        /// <param name="authType"> Authentication type of the connection target. </param>
        /// <param name="category"> Category of the connection. </param>
        /// <param name="createdByWorkspaceArmId"></param>
        /// <param name="expiryOn"></param>
        /// <param name="group"> Group based on connection category. </param>
        /// <param name="isSharedToAll"></param>
        /// <param name="target"></param>
        /// <param name="metadata"> Store user metadata for this connection. </param>
        /// <param name="sharedUserList"></param>
        /// <param name="value"> Value details of the workspace connection. </param>
        /// <param name="valueFormat"> format for the workspace connection value. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="credentials"> Api key object for workspace connection credential. </param>
        internal ApiKeyAuthWorkspaceConnectionProperties(MachineLearningConnectionAuthType authType, MachineLearningConnectionCategory? category, ResourceIdentifier createdByWorkspaceArmId, DateTimeOffset? expiryOn, WorkspaceConnectionGroup? group, bool? isSharedToAll, string target, IDictionary<string, string> metadata, IList<string> sharedUserList, string value, MachineLearningValueFormat? valueFormat, IDictionary<string, BinaryData> serializedAdditionalRawData, WorkspaceConnectionApiKey credentials) : base(authType, category, createdByWorkspaceArmId, expiryOn, group, isSharedToAll, target, metadata, sharedUserList, value, valueFormat, serializedAdditionalRawData)
        {
            Credentials = credentials;
            AuthType = authType;
        }

        /// <summary> Api key object for workspace connection credential. </summary>
        internal WorkspaceConnectionApiKey Credentials { get; set; }
        /// <summary> Gets or sets the credentials key. </summary>
        [WirePath("credentials.key")]
        public string CredentialsKey
        {
            get => Credentials is null ? default : Credentials.Key;
            set
            {
                if (Credentials is null)
                    Credentials = new WorkspaceConnectionApiKey();
                Credentials.Key = value;
            }
        }
    }
}
