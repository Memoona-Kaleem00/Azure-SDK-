﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Fluent.Tests.Common;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using System;
using Xunit;

namespace Fluent.Tests.ResourceManager
{
    public class TenantsTests
    {

        [Fact]
        public void CanListTenants()
        {
            using (var context = MockContext.Start(this.GetType().FullName))
            {
                var authenticated = TestHelper.Authenticate(null);
                var tenants = authenticated.Tenants.List();
                Assert.True(tenants.Count > 0);
            }
        }
    }
}
