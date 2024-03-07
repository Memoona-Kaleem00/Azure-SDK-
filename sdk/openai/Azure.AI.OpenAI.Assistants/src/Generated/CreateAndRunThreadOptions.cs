// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Internal;
using System.Collections.Generic;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary> The details used when creating and immediately running a new assistant thread. </summary>
    public partial class CreateAndRunThreadOptions
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CreateAndRunThreadOptions"/>. </summary>
        /// <param name="assistantId"> The ID of the assistant for which the thread should be created. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="assistantId"/> is null. </exception>
        public CreateAndRunThreadOptions(string assistantId)
        {
            Argument.AssertNotNull(assistantId, nameof(assistantId));

            AssistantId = assistantId;
            OverrideTools = new ChangeTrackingList<ToolDefinition>();
            Metadata = new OptionalDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="CreateAndRunThreadOptions"/>. </summary>
        /// <param name="assistantId"> The ID of the assistant for which the thread should be created. </param>
        /// <param name="thread"> The details used to create the new thread. </param>
        /// <param name="overrideModelName"> The overridden model that the assistant should use to run the thread. </param>
        /// <param name="overrideInstructions"> The overridden system instructions the assistant should use to run the thread. </param>
        /// <param name="overrideTools"> The overridden list of enabled tools the assistant should use to run the thread. </param>
        /// <param name="metadata"> A set of up to 16 key/value pairs that can be attached to an object, used for storing additional information about that object in a structured format. Keys may be up to 64 characters in length and values may be up to 512 characters in length. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CreateAndRunThreadOptions(string assistantId, AssistantThreadCreationOptions thread, string overrideModelName, string overrideInstructions, IList<ToolDefinition> overrideTools, IDictionary<string, string> metadata, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AssistantId = assistantId;
            Thread = thread;
            OverrideModelName = overrideModelName;
            OverrideInstructions = overrideInstructions;
            OverrideTools = overrideTools;
            Metadata = metadata;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CreateAndRunThreadOptions"/> for deserialization. </summary>
        internal CreateAndRunThreadOptions()
        {
        }

        /// <summary> The ID of the assistant for which the thread should be created. </summary>
        public string AssistantId { get; }
        /// <summary> The details used to create the new thread. </summary>
        public AssistantThreadCreationOptions Thread { get; set; }
        /// <summary> The overridden model that the assistant should use to run the thread. </summary>
        public string OverrideModelName { get; set; }
        /// <summary> The overridden system instructions the assistant should use to run the thread. </summary>
        public string OverrideInstructions { get; set; }
        /// <summary>
        /// The overridden list of enabled tools the assistant should use to run the thread.
        /// Please note <see cref="ToolDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CodeInterpreterToolDefinition"/>, <see cref="RetrievalToolDefinition"/> and <see cref="FunctionToolDefinition"/>.
        /// </summary>
        public IList<ToolDefinition> OverrideTools { get; }
        /// <summary> A set of up to 16 key/value pairs that can be attached to an object, used for storing additional information about that object in a structured format. Keys may be up to 64 characters in length and values may be up to 512 characters in length. </summary>
        public IDictionary<string, string> Metadata { get; set; }
    }
}
