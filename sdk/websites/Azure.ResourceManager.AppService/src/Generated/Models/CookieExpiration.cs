// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// The configuration settings of the session cookie&apos;s expiration.
    /// Serialized Name: CookieExpiration
    /// </summary>
    public partial class CookieExpiration
    {
        /// <summary> Initializes a new instance of CookieExpiration. </summary>
        public CookieExpiration()
        {
        }

        /// <summary> Initializes a new instance of CookieExpiration. </summary>
        /// <param name="convention">
        /// The convention used when determining the session cookie&apos;s expiration.
        /// Serialized Name: CookieExpiration.convention
        /// </param>
        /// <param name="timeToExpiration">
        /// The time after the request is made when the session cookie should expire.
        /// Serialized Name: CookieExpiration.timeToExpiration
        /// </param>
        internal CookieExpiration(CookieExpirationConvention? convention, string timeToExpiration)
        {
            Convention = convention;
            TimeToExpiration = timeToExpiration;
        }

        /// <summary>
        /// The convention used when determining the session cookie&apos;s expiration.
        /// Serialized Name: CookieExpiration.convention
        /// </summary>
        public CookieExpirationConvention? Convention { get; set; }
        /// <summary>
        /// The time after the request is made when the session cookie should expire.
        /// Serialized Name: CookieExpiration.timeToExpiration
        /// </summary>
        public string TimeToExpiration { get; set; }
    }
}
