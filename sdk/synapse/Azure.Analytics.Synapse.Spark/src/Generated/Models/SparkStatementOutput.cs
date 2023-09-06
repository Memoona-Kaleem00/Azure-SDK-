// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Spark.Models
{
    /// <summary> The SparkStatementOutput. </summary>
    public partial class SparkStatementOutput
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SparkStatementOutput"/>. </summary>
        /// <param name="executionCount"></param>
        internal SparkStatementOutput(int executionCount)
        {
            ExecutionCount = executionCount;
            Traceback = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SparkStatementOutput"/>. </summary>
        /// <param name="status"></param>
        /// <param name="executionCount"></param>
        /// <param name="data"> Any object. </param>
        /// <param name="errorName"></param>
        /// <param name="errorValue"></param>
        /// <param name="traceback"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SparkStatementOutput(string status, int executionCount, object data, string errorName, string errorValue, IReadOnlyList<string> traceback, Dictionary<string, BinaryData> rawData)
        {
            Status = status;
            ExecutionCount = executionCount;
            Data = data;
            ErrorName = errorName;
            ErrorValue = errorValue;
            Traceback = traceback;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="SparkStatementOutput"/> for deserialization. </summary>
        internal SparkStatementOutput()
        {
        }

        /// <summary> Gets the status. </summary>
        public string Status { get; }
        /// <summary> Gets the execution count. </summary>
        public int ExecutionCount { get; }
        /// <summary> Any object. </summary>
        public object Data { get; }
        /// <summary> Gets the error name. </summary>
        public string ErrorName { get; }
        /// <summary> Gets the error value. </summary>
        public string ErrorValue { get; }
        /// <summary> Gets the traceback. </summary>
        public IReadOnlyList<string> Traceback { get; }
    }
}
