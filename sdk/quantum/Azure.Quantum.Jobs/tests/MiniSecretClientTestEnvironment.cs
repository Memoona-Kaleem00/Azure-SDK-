// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;

namespace Azure.Quantum.Jobs.Tests
{
    public class MiniSecretClientTestEnvironment : TestEnvironment
    {
        public string KeyVaultUri => GetRecordedVariable("KEYVAULT_URL");
    }
}
