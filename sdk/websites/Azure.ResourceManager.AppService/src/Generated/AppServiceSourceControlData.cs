// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing the AppServiceSourceControl data model.
    /// The source control OAuth token.
    /// </summary>
    public partial class AppServiceSourceControlData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AppServiceSourceControlData"/>. </summary>
        public AppServiceSourceControlData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceSourceControlData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="token"> OAuth access token. </param>
        /// <param name="tokenSecret"> OAuth access token secret. </param>
        /// <param name="refreshToken"> OAuth refresh token. </param>
        /// <param name="expireOn"> OAuth token expiration. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceSourceControlData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string token, string tokenSecret, string refreshToken, DateTimeOffset? expireOn, string kind, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Token = token;
            TokenSecret = tokenSecret;
            RefreshToken = refreshToken;
            ExpireOn = expireOn;
            Kind = kind;
            _rawData = rawData;
        }

        /// <summary> OAuth access token. </summary>
        public string Token { get; set; }
        /// <summary> OAuth access token secret. </summary>
        public string TokenSecret { get; set; }
        /// <summary> OAuth refresh token. </summary>
        public string RefreshToken { get; set; }
        /// <summary> OAuth token expiration. </summary>
        public DateTimeOffset? ExpireOn { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
