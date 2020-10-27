﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.Management.Security;
using Microsoft.Azure.Management.Security.Models;
using Microsoft.Azure.Test.HttpRecorder;
using Microsoft.Rest.Azure;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using SecurityCenter.Tests.Helpers;
using System.Net;
using Xunit;

namespace SecurityCenter.Tests
{
    public class SubAssessmentTests : TestBase
    {
        #region Test setup
        private static readonly string AssessmentName = "dbd0cb49-b563-45e7-9724-889e799fa648";
        private static readonly string SubAssessmentName = "06965065-49c1-4b8c-8f9d-6676e0ecf173";
        private static readonly string AscLocation = "centralus";
        private static TestEnvironment TestEnvironment { get; set; }
        #endregion

        private static SecurityCenterClient GetSecurityCenterClient(MockContext context)
        {
            if (TestEnvironment == null && HttpMockServer.Mode == HttpRecorderMode.Record)
            {
                TestEnvironment = TestEnvironmentFactory.GetTestEnvironment();
            }

            var handler = new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK, IsPassThrough = true };

            var securityCenterClient = HttpMockServer.Mode == HttpRecorderMode.Record
                ? context.GetServiceClient<SecurityCenterClient>(TestEnvironment, handlers: handler)
                : context.GetServiceClient<SecurityCenterClient>(handlers: handler);

            securityCenterClient.AscLocation = AscLocation;

            return securityCenterClient;
        }

        #region Tests
        [Fact]
        public void SubAssessments_ListAll()
        {
            string scope = "subscriptions/487bb485-b5b0-471e-9c0d-10717612f869";

            using (var context = MockContext.Start(this.GetType()))
            {
                var securityCenterClient = GetSecurityCenterClient(context);
                var ret = securityCenterClient.SubAssessments.ListAll(scope);
                Validate(ret);
            }
        }

        [Fact]
        public void SubAssessments_List()
        {
            string scope = "subscriptions/487bb485-b5b0-471e-9c0d-10717612f869/resourceGroups/subAssessments_sdk_tests/providers/Microsoft.ContainerRegistry/registries/sdkRef";
            using (var context = MockContext.Start(this.GetType()))
            {
                var securityCenterClient = GetSecurityCenterClient(context);
                var ret = securityCenterClient.SubAssessments.List(scope, AssessmentName);
                Validate(ret);
            }
        }

        [Fact]
        public void SubAssessments_Get()
        {
            string scope = "subscriptions/487bb485-b5b0-471e-9c0d-10717612f869/resourceGroups/subAssessments_sdk_tests/providers/Microsoft.ContainerRegistry/registries/sdkRef";

            using (var context = MockContext.Start(this.GetType()))
            {
                var securityCenterClient = GetSecurityCenterClient(context);
                var ret = securityCenterClient.SubAssessments.Get(scope, AssessmentName, SubAssessmentName);
                Assert.NotNull(ret);
            }
        }
        #endregion

        #region Validations
        private static void Validate(IPage<SecuritySubAssessment> ret)
        {
            Assert.True(ret.IsAny(), "Got empty list");
            foreach (var item in ret)
            {
                Assert.NotNull(item);
            }
        }
        #endregion
    }
}
