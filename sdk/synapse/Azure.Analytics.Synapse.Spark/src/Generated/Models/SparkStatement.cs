// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Spark.Models
{
    /// <summary> The SparkStatement. </summary>
    public partial class SparkStatement
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SparkStatement"/>. </summary>
        /// <param name="id"></param>
        internal SparkStatement(int id)
        {
            Id = id;
        }

        /// <summary> Initializes a new instance of <see cref="SparkStatement"/>. </summary>
        /// <param name="id"></param>
        /// <param name="code"></param>
        /// <param name="state"></param>
        /// <param name="output"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SparkStatement(int id, string code, LivyStatementStates? state, SparkStatementOutput output, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            Code = code;
            State = state;
            Output = output;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="SparkStatement"/> for deserialization. </summary>
        internal SparkStatement()
        {
        }

        /// <summary> Gets the id. </summary>
        public int Id { get; }
        /// <summary> Gets the code. </summary>
        public string Code { get; }
        /// <summary> Gets the state. </summary>
        public LivyStatementStates? State { get; }
        /// <summary> Gets the output. </summary>
        public SparkStatementOutput Output { get; }
    }
}
