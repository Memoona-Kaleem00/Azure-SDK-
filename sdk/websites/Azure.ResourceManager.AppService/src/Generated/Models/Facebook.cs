// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// The configuration settings of the Facebook provider.
    /// Serialized Name: Facebook
    /// </summary>
    public partial class Facebook
    {
        /// <summary> Initializes a new instance of Facebook. </summary>
        public Facebook()
        {
        }

        /// <summary> Initializes a new instance of Facebook. </summary>
        /// <param name="isEnabled">
        /// &lt;code&gt;false&lt;/code&gt; if the Facebook provider should not be enabled despite the set registration; otherwise, &lt;code&gt;true&lt;/code&gt;.
        /// Serialized Name: Facebook.enabled
        /// </param>
        /// <param name="registration">
        /// The configuration settings of the app registration for the Facebook provider.
        /// Serialized Name: Facebook.registration
        /// </param>
        /// <param name="graphApiVersion">
        /// The version of the Facebook api to be used while logging in.
        /// Serialized Name: Facebook.graphApiVersion
        /// </param>
        /// <param name="login">
        /// The configuration settings of the login flow.
        /// Serialized Name: Facebook.login
        /// </param>
        internal Facebook(bool? isEnabled, AppRegistration registration, string graphApiVersion, LoginScopes login)
        {
            IsEnabled = isEnabled;
            Registration = registration;
            GraphApiVersion = graphApiVersion;
            Login = login;
        }

        /// <summary>
        /// &lt;code&gt;false&lt;/code&gt; if the Facebook provider should not be enabled despite the set registration; otherwise, &lt;code&gt;true&lt;/code&gt;.
        /// Serialized Name: Facebook.enabled
        /// </summary>
        public bool? IsEnabled { get; set; }
        /// <summary>
        /// The configuration settings of the app registration for the Facebook provider.
        /// Serialized Name: Facebook.registration
        /// </summary>
        public AppRegistration Registration { get; set; }
        /// <summary>
        /// The version of the Facebook api to be used while logging in.
        /// Serialized Name: Facebook.graphApiVersion
        /// </summary>
        public string GraphApiVersion { get; set; }
        /// <summary>
        /// The configuration settings of the login flow.
        /// Serialized Name: Facebook.login
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
    }
}
