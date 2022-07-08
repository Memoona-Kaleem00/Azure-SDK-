// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> API Authentication Settings. </summary>
    public partial class AuthenticationSettingsContract
    {
        /// <summary> Initializes a new instance of AuthenticationSettingsContract. </summary>
        public AuthenticationSettingsContract()
        {
        }

        /// <summary> Initializes a new instance of AuthenticationSettingsContract. </summary>
        /// <param name="oAuth2"> OAuth2 Authentication settings. </param>
        /// <param name="openid"> OpenID Connect Authentication Settings. </param>
        internal AuthenticationSettingsContract(OAuth2AuthenticationSettingsContract oAuth2, OpenIdAuthenticationSettingsContract openid)
        {
            OAuth2 = oAuth2;
            Openid = openid;
        }

        /// <summary> OAuth2 Authentication settings. </summary>
        public OAuth2AuthenticationSettingsContract OAuth2 { get; set; }
        /// <summary> OpenID Connect Authentication Settings. </summary>
        public OpenIdAuthenticationSettingsContract Openid { get; set; }
    }
}
