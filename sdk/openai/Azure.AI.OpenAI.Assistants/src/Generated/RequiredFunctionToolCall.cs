// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary> A representation of a requested call to a function tool, needed by the model to continue evaluation of a run. </summary>
    public partial class RequiredFunctionToolCall : RequiredToolCall
    {
        /// <summary> Initializes a new instance of <see cref="RequiredFunctionToolCall"/>. </summary>
        /// <param name="id"> The ID of the tool call. This ID must be referenced when submitting tool outputs. </param>
        /// <param name="internalFunctionDefinition"> Detailed information about the function to be executed by the tool that includes name and arguments. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="internalFunctionDefinition"/> is null. </exception>
        internal RequiredFunctionToolCall(string id, InternalFunctionDefinition internalFunctionDefinition) : base(id)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(internalFunctionDefinition, nameof(internalFunctionDefinition));

            Type = "function";
            InternalFunctionDefinition = internalFunctionDefinition;
        }

        /// <summary> Initializes a new instance of <see cref="RequiredFunctionToolCall"/>. </summary>
        /// <param name="type"> The object type for the required tool call. </param>
        /// <param name="id"> The ID of the tool call. This ID must be referenced when submitting tool outputs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="internalFunctionDefinition"> Detailed information about the function to be executed by the tool that includes name and arguments. </param>
        internal RequiredFunctionToolCall(string type, string id, IDictionary<string, BinaryData> serializedAdditionalRawData, InternalFunctionDefinition internalFunctionDefinition) : base(type, id, serializedAdditionalRawData)
        {
            InternalFunctionDefinition = internalFunctionDefinition;
        }

        /// <summary> Initializes a new instance of <see cref="RequiredFunctionToolCall"/> for deserialization. </summary>
        internal RequiredFunctionToolCall()
        {
        }
    }
}
