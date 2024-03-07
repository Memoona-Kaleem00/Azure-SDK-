// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary> The detailed information associated with a run step calling tools. </summary>
    public partial class RunStepToolCallDetails : RunStepDetails
    {
        /// <summary> Initializes a new instance of <see cref="RunStepToolCallDetails"/>. </summary>
        /// <param name="toolCalls"> A list of tool call details for this run step. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="toolCalls"/> is null. </exception>
        internal RunStepToolCallDetails(IEnumerable<RunStepToolCall> toolCalls)
        {
            Argument.AssertNotNull(toolCalls, nameof(toolCalls));

            Type = RunStepType.ToolCalls;
            ToolCalls = toolCalls.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="RunStepToolCallDetails"/>. </summary>
        /// <param name="type"> The object type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="toolCalls"> A list of tool call details for this run step. </param>
        internal RunStepToolCallDetails(RunStepType type, IDictionary<string, BinaryData> serializedAdditionalRawData, IReadOnlyList<RunStepToolCall> toolCalls) : base(type, serializedAdditionalRawData)
        {
            ToolCalls = toolCalls;
        }

        /// <summary> Initializes a new instance of <see cref="RunStepToolCallDetails"/> for deserialization. </summary>
        internal RunStepToolCallDetails()
        {
        }

        /// <summary>
        /// A list of tool call details for this run step.
        /// Please note <see cref="RunStepToolCall"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="RunStepCodeInterpreterToolCall"/>, <see cref="RunStepRetrievalToolCall"/> and <see cref="RunStepFunctionToolCall"/>.
        /// </summary>
        public IReadOnlyList<RunStepToolCall> ToolCalls { get; }
    }
}
