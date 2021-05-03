﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core.TestFramework;

namespace Azure.Communication.Tests
{
    public class CommunicationTestEnvironment : TestEnvironment
    {
        public const string ConnectionStringEnvironmentVariableName = "COMMUNICATION_CONNECTION_STRING";
        public const string LiveTestConnectionStringEnvironmentVariableName = "AZURE_COMMUNICATION_LIVETEST_CONNECTION_STRING";
        public const string AzurePhoneNumber = "AZURE_PHONE_NUMBER";
        protected const string TestPackagesEnabledDefaultValue = "all";
        private const string TestPackagesEnabledEnvironmentVariableName = "TEST_PACKAGES_ENABLED";
        private const string SkipSmsTestEnvironmentVariableName = "SKIP_SMS_TEST";

        public string ConnectionString => GetRecordedVariable(ConnectionStringEnvironmentVariableName);

        public Uri Endpoint => new Uri(Core.ConnectionString.Parse(ConnectionString).GetRequired("endpoint"));

        public string AccessKey => Core.ConnectionString.Parse(ConnectionString).GetRequired("accesskey");

        public string LiveTestConnectionString => GetRecordedVariable(LiveTestConnectionStringEnvironmentVariableName);

        public Uri LiveTestEndpoint => new Uri(Core.ConnectionString.Parse(LiveTestConnectionString).GetRequired("endpoint"));

        public string LiveTestAccessKey => Core.ConnectionString.Parse(LiveTestConnectionString).GetRequired("accesskey");

        public string CommunicationTestPhoneNumber => GetVariable(AzurePhoneNumber);

        public string SkipSmsTest => GetVariable(SkipSmsTestEnvironmentVariableName);

        public virtual string ExpectedTestPackagesEnabled { get { return TestPackagesEnabledDefaultValue; } }

        public bool ShouldIgnoreTests => TestPackagesEnabled != TestPackagesEnabledDefaultValue
            && TestPackagesEnabled != ExpectedTestPackagesEnabled
            || bool.Parse(SkipSmsTest);

        public string TestPackagesEnabled => GetTestPackageEnabled();

        private string GetTestPackageEnabled()
        {
            string? package = Environment.GetEnvironmentVariable(TestPackagesEnabledEnvironmentVariableName);
            return package ?? TestPackagesEnabledDefaultValue;
        }
    }
}
