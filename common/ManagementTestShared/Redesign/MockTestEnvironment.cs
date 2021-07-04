﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using Azure.Core.TestFramework;
using System;

namespace Azure.ResourceManager.TestFramework
{
    public class MockTestEnvironment : TestEnvironment
    {
        public MockTestEnvironment() : base()
        {
            Environment.SetEnvironmentVariable("SUBSCRIPTION_ID", "00000000-0000-0000-0000-000000000000");
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", MockEndPoint);
        }

        public virtual string MockEndPoint => $"https://localhost:8441";

        public override TokenCredential Credential
        {
            get
            {
                if (_credential != null)
                {
                    return _credential;
                }

                _credential = new MockCredential();

                return _credential;
            }
        }
    }
}
