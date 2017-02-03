﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Azure.Tests;
using Fluent.Tests.Common;
using Xunit;
using Xunit.Abstractions;

namespace Samples.Tests
{
    public class Batch : Samples.Tests.TestBase
    {
        public Batch(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        [Trait("Samples", "Batch")]
        public void ManageBatchAccountTest()
        {
            using (var context = FluentMockContext.Start(this.GetType().FullName))
            {
                var rollUpClient = TestHelper.CreateRollupClient();
                ManageBatchAccount.Program.RunSample(rollUpClient);
            }
        }
    }
}
