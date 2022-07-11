// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// The configuration settings of the app registration for providers that have client ids and client secrets
    /// Serialized Name: ClientRegistration
    /// </summary>
    public partial class ClientRegistration
    {
        /// <summary> Initializes a new instance of ClientRegistration. </summary>
        public ClientRegistration()
        {
        }

        /// <summary> Initializes a new instance of ClientRegistration. </summary>
        /// <param name="clientId">
        /// The Client ID of the app used for login.
        /// Serialized Name: ClientRegistration.clientId
        /// </param>
        /// <param name="clientSecretSettingName">
        /// The app setting name that contains the client secret.
        /// Serialized Name: ClientRegistration.clientSecretSettingName
        /// </param>
        internal ClientRegistration(string clientId, string clientSecretSettingName)
        {
            ClientId = clientId;
            ClientSecretSettingName = clientSecretSettingName;
        }

        /// <summary>
        /// The Client ID of the app used for login.
        /// Serialized Name: ClientRegistration.clientId
        /// </summary>
        public string ClientId { get; set; }
        /// <summary>
        /// The app setting name that contains the client secret.
        /// Serialized Name: ClientRegistration.clientSecretSettingName
        /// </summary>
        public string ClientSecretSettingName { get; set; }
    }
}
