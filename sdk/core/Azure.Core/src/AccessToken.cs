﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.Core
{
    /// <summary>
    /// Represent an Azure service OAuth access token with expiry information.
    /// </summary>
    public struct AccessToken
    {
        /// <summary>
        /// Creates a new instance of <see cref="AccessToken"/> using the provided <paramref name="accessToken"/> and <paramref name="expiresOn"/>.
        /// </summary>
        /// <param name="accessToken">The access token value.</param>
        /// <param name="expiresOn">The access token expiry date.</param>
        public AccessToken(string accessToken, DateTimeOffset expiresOn)
        {
            Token = accessToken;
            ExpiresOn = expiresOn;
        }

        /// <summary>
        /// Get the access token value
        /// </summary>
        public string Token { get; }

        /// <summary>
        /// Gets the time when the provided token expires.
        /// </summary>
        public DateTimeOffset ExpiresOn { get; }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            if (obj is AccessToken accessToken)
            {
                return accessToken.ExpiresOn == ExpiresOn && accessToken.Token == Token;
            }

            return false;
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return Token.GetHashCode() ^ ExpiresOn.GetHashCode();
        }
    }
}
