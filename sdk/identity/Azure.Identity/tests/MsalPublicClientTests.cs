﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Identity.Tests.Mock;
using Microsoft.Identity.Client;
using NUnit.Framework;
using Azure.Core.TestFramework;

namespace Azure.Identity.Tests
{
    public class MsalPublicClientTests
    {
        private string cp1 = "CP1";

        // [Test]
        public void CreateClientRespectsCaeConfig(
            [Values(true, false)] bool setDisableSwitch,
            [Values(true, false)] bool setDisableEnvVar)
        {
            AppContext.SetSwitch(IdentityCompatSwitches.DisableCP1ExecutionSwitchName, setDisableSwitch);
            using (var _ = new  TestEnvVar(IdentityCompatSwitches.DisableCP1ExecutionEnvVar, setDisableEnvVar.ToString()))
            {
                var mock = new MockMsalPublicClient();
                mock.PubClientAppFactory = (capabilities) =>
                {
                    bool IsCp1Set = cp1 == string.Join("", capabilities);
                    Assert.AreEqual(setDisableSwitch || setDisableEnvVar, !IsCp1Set);
                    return Moq.Mock.Of<IPublicClientApplication>();
                };

                mock.CallCreateClientAsync(false, default);
            }
        }

        [Test]
        [NonParallelizable]
        public void GetConfigValue(
            [Values(true, false, null)] bool? setDisableSwitch,
            [Values(true, false, null)] bool? setDisableEnvVar)
        {
            TestAppContext ctx = null;
            TestEnvVar env = null;
            try
            {
                if (setDisableSwitch != null)
                {
                    ctx = new TestAppContext(IdentityCompatSwitches.DisableCP1ExecutionSwitchName, setDisableSwitch.Value.ToString());
                }
                if (setDisableEnvVar != null)
                {
                    env = new TestEnvVar(IdentityCompatSwitches.DisableCP1ExecutionEnvVar, setDisableEnvVar.Value.ToString());
                }

                var mock = new MockMsalPublicClient();
                mock.PubClientAppFactory = (capabilities) =>
                {
                    bool IsCp1Set = cp1 == string.Join("", capabilities);
                    if (setDisableSwitch.HasValue)
                    {
                        Assert.AreEqual(setDisableSwitch.Value, !IsCp1Set);
                    }
                    else
                    {
                        Assert.AreEqual(setDisableEnvVar.HasValue && setDisableEnvVar.Value, !IsCp1Set);
                    }
                    return Moq.Mock.Of<IPublicClientApplication>();
                };

                mock.CallCreateClientAsync(false, default);
            }
            finally
            {
                ctx?.Dispose();
                env?.Dispose();
            }
        }
    }
}
