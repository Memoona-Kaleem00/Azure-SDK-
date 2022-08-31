// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> This enables publishing to Event Grid using a custom input schema. This can be used to map properties from a custom input JSON schema to the Event Grid event schema. </summary>
    public partial class JsonInputSchemaMapping : InputSchemaMapping
    {
        /// <summary> Initializes a new instance of JsonInputSchemaMapping. </summary>
        public JsonInputSchemaMapping()
        {
            InputSchemaMappingType = InputSchemaMappingType.Json;
        }

        /// <summary> Initializes a new instance of JsonInputSchemaMapping. </summary>
        /// <param name="inputSchemaMappingType"> Type of the custom mapping. </param>
        /// <param name="id"> The mapping information for the Id property of the Event Grid Event. </param>
        /// <param name="topic"> The mapping information for the Topic property of the Event Grid Event. </param>
        /// <param name="eventTime"> The mapping information for the EventTime property of the Event Grid Event. </param>
        /// <param name="eventType"> The mapping information for the EventType property of the Event Grid Event. </param>
        /// <param name="subject"> The mapping information for the Subject property of the Event Grid Event. </param>
        /// <param name="dataVersion"> The mapping information for the DataVersion property of the Event Grid Event. </param>
        internal JsonInputSchemaMapping(InputSchemaMappingType inputSchemaMappingType, JsonField id, JsonField topic, JsonField eventTime, JsonFieldWithDefault eventType, JsonFieldWithDefault subject, JsonFieldWithDefault dataVersion) : base(inputSchemaMappingType)
        {
            Id = id;
            Topic = topic;
            EventTime = eventTime;
            EventType = eventType;
            Subject = subject;
            DataVersion = dataVersion;
            InputSchemaMappingType = inputSchemaMappingType;
        }

        /// <summary> The mapping information for the Id property of the Event Grid Event. </summary>
        internal JsonField Id { get; set; }
        /// <summary> Name of a field in the input event schema that&apos;s to be used as the source of a mapping. </summary>
        public string IdSourceField
        {
            get => Id is null ? default : Id.SourceField;
            set
            {
                if (Id is null)
                    Id = new JsonField();
                Id.SourceField = value;
            }
        }

        /// <summary> The mapping information for the Topic property of the Event Grid Event. </summary>
        internal JsonField Topic { get; set; }
        /// <summary> Name of a field in the input event schema that&apos;s to be used as the source of a mapping. </summary>
        public string TopicSourceField
        {
            get => Topic is null ? default : Topic.SourceField;
            set
            {
                if (Topic is null)
                    Topic = new JsonField();
                Topic.SourceField = value;
            }
        }

        /// <summary> The mapping information for the EventTime property of the Event Grid Event. </summary>
        internal JsonField EventTime { get; set; }
        /// <summary> Name of a field in the input event schema that&apos;s to be used as the source of a mapping. </summary>
        public string EventTimeSourceField
        {
            get => EventTime is null ? default : EventTime.SourceField;
            set
            {
                if (EventTime is null)
                    EventTime = new JsonField();
                EventTime.SourceField = value;
            }
        }

        /// <summary> The mapping information for the EventType property of the Event Grid Event. </summary>
        public JsonFieldWithDefault EventType { get; set; }
        /// <summary> The mapping information for the Subject property of the Event Grid Event. </summary>
        public JsonFieldWithDefault Subject { get; set; }
        /// <summary> The mapping information for the DataVersion property of the Event Grid Event. </summary>
        public JsonFieldWithDefault DataVersion { get; set; }
    }
}
