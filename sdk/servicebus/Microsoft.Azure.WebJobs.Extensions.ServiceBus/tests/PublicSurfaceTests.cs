﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.WebJobs.Host.TestCommon;
using NUnit.Framework;

namespace Microsoft.Azure.WebJobs.Host.UnitTests
{
    public class PublicSurfaceTests
    {
        [Test]
        [Ignore("new major version")]
        public void WebJobs_Extensions_ServiceBus_VerifyPublicSurfaceArea()
        {
            var assembly = typeof(ServiceBusAttribute).Assembly;

            var expected = new[]
            {
                "Constants",
                "EntityType",
                "MessageProcessor",
                "MessagingProvider",
                "ServiceBusAccountAttribute",
                "ServiceBusAttribute",
                "ServiceBusTriggerAttribute",
                "ServiceBusHostBuilderExtensions",
                "ServiceBusOptions",
                "ServiceBusWebJobsStartup",
                "SessionMessageProcessor",
                "BatchOptions"
            };

            TestHelpers.AssertPublicTypes(expected, assembly);
        }
    }
}
