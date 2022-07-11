// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// The configuration settings of the login flow of users using App Service Authentication/Authorization.
    /// Serialized Name: Login
    /// </summary>
    public partial class LoginInformation
    {
        /// <summary> Initializes a new instance of LoginInformation. </summary>
        public LoginInformation()
        {
            AllowedExternalRedirectUrls = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of LoginInformation. </summary>
        /// <param name="routes">
        /// The routes that specify the endpoints used for login and logout requests.
        /// Serialized Name: Login.routes
        /// </param>
        /// <param name="tokenStore">
        /// The configuration settings of the token store.
        /// Serialized Name: Login.tokenStore
        /// </param>
        /// <param name="isPreserveUrlFragmentsForLogins">
        /// &lt;code&gt;true&lt;/code&gt; if the fragments from the request are preserved after the login request is made; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// Serialized Name: Login.preserveUrlFragmentsForLogins
        /// </param>
        /// <param name="allowedExternalRedirectUrls">
        /// External URLs that can be redirected to as part of logging in or logging out of the app. Note that the query string part of the URL is ignored.
        /// This is an advanced setting typically only needed by Windows Store application backends.
        /// Note that URLs within the current domain are always implicitly allowed.
        /// Serialized Name: Login.allowedExternalRedirectUrls
        /// </param>
        /// <param name="cookieExpiration">
        /// The configuration settings of the session cookie&apos;s expiration.
        /// Serialized Name: Login.cookieExpiration
        /// </param>
        /// <param name="nonce">
        /// The configuration settings of the nonce used in the login flow.
        /// Serialized Name: Login.nonce
        /// </param>
        internal LoginInformation(LoginRoutes routes, TokenStore tokenStore, bool? isPreserveUrlFragmentsForLogins, IList<string> allowedExternalRedirectUrls, CookieExpiration cookieExpiration, Nonce nonce)
        {
            Routes = routes;
            TokenStore = tokenStore;
            IsPreserveUrlFragmentsForLogins = isPreserveUrlFragmentsForLogins;
            AllowedExternalRedirectUrls = allowedExternalRedirectUrls;
            CookieExpiration = cookieExpiration;
            Nonce = nonce;
        }

        /// <summary>
        /// The routes that specify the endpoints used for login and logout requests.
        /// Serialized Name: Login.routes
        /// </summary>
        internal LoginRoutes Routes { get; set; }
        /// <summary>
        /// The endpoint at which a logout request should be made.
        /// Serialized Name: LoginRoutes.logoutEndpoint
        /// </summary>
        public string RoutesLogoutEndpoint
        {
            get => Routes is null ? default : Routes.LogoutEndpoint;
            set
            {
                if (Routes is null)
                    Routes = new LoginRoutes();
                Routes.LogoutEndpoint = value;
            }
        }

        /// <summary>
        /// The configuration settings of the token store.
        /// Serialized Name: Login.tokenStore
        /// </summary>
        public TokenStore TokenStore { get; set; }
        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if the fragments from the request are preserved after the login request is made; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// Serialized Name: Login.preserveUrlFragmentsForLogins
        /// </summary>
        public bool? IsPreserveUrlFragmentsForLogins { get; set; }
        /// <summary>
        /// External URLs that can be redirected to as part of logging in or logging out of the app. Note that the query string part of the URL is ignored.
        /// This is an advanced setting typically only needed by Windows Store application backends.
        /// Note that URLs within the current domain are always implicitly allowed.
        /// Serialized Name: Login.allowedExternalRedirectUrls
        /// </summary>
        public IList<string> AllowedExternalRedirectUrls { get; }
        /// <summary>
        /// The configuration settings of the session cookie&apos;s expiration.
        /// Serialized Name: Login.cookieExpiration
        /// </summary>
        public CookieExpiration CookieExpiration { get; set; }
        /// <summary>
        /// The configuration settings of the nonce used in the login flow.
        /// Serialized Name: Login.nonce
        /// </summary>
        public Nonce Nonce { get; set; }
    }
}
