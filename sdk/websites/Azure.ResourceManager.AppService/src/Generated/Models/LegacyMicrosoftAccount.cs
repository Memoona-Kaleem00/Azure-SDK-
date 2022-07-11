// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// The configuration settings of the legacy Microsoft Account provider.
    /// Serialized Name: LegacyMicrosoftAccount
    /// </summary>
    public partial class LegacyMicrosoftAccount
    {
        /// <summary> Initializes a new instance of LegacyMicrosoftAccount. </summary>
        public LegacyMicrosoftAccount()
        {
        }

        /// <summary> Initializes a new instance of LegacyMicrosoftAccount. </summary>
        /// <param name="isEnabled">
        /// &lt;code&gt;false&lt;/code&gt; if the legacy Microsoft Account provider should not be enabled despite the set registration; otherwise, &lt;code&gt;true&lt;/code&gt;.
        /// Serialized Name: LegacyMicrosoftAccount.enabled
        /// </param>
        /// <param name="registration">
        /// The configuration settings of the app registration for the legacy Microsoft Account provider.
        /// Serialized Name: LegacyMicrosoftAccount.registration
        /// </param>
        /// <param name="login">
        /// The configuration settings of the login flow.
        /// Serialized Name: LegacyMicrosoftAccount.login
        /// </param>
        /// <param name="validation">
        /// The configuration settings of the legacy Microsoft Account provider token validation flow.
        /// Serialized Name: LegacyMicrosoftAccount.validation
        /// </param>
        internal LegacyMicrosoftAccount(bool? isEnabled, ClientRegistration registration, LoginScopes login, AllowedAudiencesValidation validation)
        {
            IsEnabled = isEnabled;
            Registration = registration;
            Login = login;
            Validation = validation;
        }

        /// <summary>
        /// &lt;code&gt;false&lt;/code&gt; if the legacy Microsoft Account provider should not be enabled despite the set registration; otherwise, &lt;code&gt;true&lt;/code&gt;.
        /// Serialized Name: LegacyMicrosoftAccount.enabled
        /// </summary>
        public bool? IsEnabled { get; set; }
        /// <summary>
        /// The configuration settings of the app registration for the legacy Microsoft Account provider.
        /// Serialized Name: LegacyMicrosoftAccount.registration
        /// </summary>
        public ClientRegistration Registration { get; set; }
        /// <summary>
        /// The configuration settings of the login flow.
        /// Serialized Name: LegacyMicrosoftAccount.login
        /// </summary>
        internal LoginScopes Login { get; set; }
        /// <summary>
        /// A list of the scopes that should be requested while authenticating.
        /// Serialized Name: LoginScopes.scopes
        /// </summary>
        public IList<string> LoginScopes
        {
            get
            {
                if (Login is null)
                    Login = new LoginScopes();
                return Login.Scopes;
            }
        }

        /// <summary>
        /// The configuration settings of the legacy Microsoft Account provider token validation flow.
        /// Serialized Name: LegacyMicrosoftAccount.validation
        /// </summary>
        internal AllowedAudiencesValidation Validation { get; set; }
        /// <summary>
        /// The configuration settings of the allowed list of audiences from which to validate the JWT token.
        /// Serialized Name: AllowedAudiencesValidation.allowedAudiences
        /// </summary>
        public IList<string> ValidationAllowedAudiences
        {
            get
            {
                if (Validation is null)
                    Validation = new AllowedAudiencesValidation();
                return Validation.AllowedAudiences;
            }
        }
    }
}
