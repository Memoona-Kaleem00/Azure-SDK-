﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.Identity
{
    /// <summary>
    /// Options used to configure the <see cref="ClientCertificateCredential"/>.
    /// </summary>
    public class ClientCertificateCredentialOptions : TokenCredentialOptions
    {

        /// <summary>
        /// If set to true the credential will store tokens in a persistent cache shared by other credentials.
        /// </summary>
        public bool EnablePersistentCache { get; set; }
    }
}
