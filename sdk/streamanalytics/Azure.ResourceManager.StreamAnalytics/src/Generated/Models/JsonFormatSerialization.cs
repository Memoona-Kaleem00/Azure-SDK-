// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> Describes how data from an input is serialized or how data is serialized when written to an output in JSON format. </summary>
    public partial class JsonFormatSerialization : StreamAnalyticsDataSerialization
    {
        /// <summary> Initializes a new instance of <see cref="JsonFormatSerialization"/>. </summary>
        public JsonFormatSerialization()
        {
            EventSerializationType = EventSerializationType.Json;
        }

        /// <summary> Initializes a new instance of <see cref="JsonFormatSerialization"/>. </summary>
        /// <param name="eventSerializationType"> Indicates the type of serialization that the input or output uses. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="encoding"> Specifies the encoding of the incoming data in the case of input and the encoding of outgoing data in the case of output. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="format"> This property only applies to JSON serialization of outputs only. It is not applicable to inputs. This property specifies the format of the JSON the output will be written in. The currently supported values are 'lineSeparated' indicating the output will be formatted by having each JSON object separated by a new line and 'array' indicating the output will be formatted as an array of JSON objects. Default value is 'lineSeparated' if left null. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal JsonFormatSerialization(EventSerializationType eventSerializationType, StreamAnalyticsDataSerializationEncoding? encoding, JsonOutputSerializationFormat? format, Dictionary<string, BinaryData> rawData) : base(eventSerializationType, rawData)
        {
            Encoding = encoding;
            Format = format;
            EventSerializationType = eventSerializationType;
        }

        /// <summary> Specifies the encoding of the incoming data in the case of input and the encoding of outgoing data in the case of output. Required on PUT (CreateOrReplace) requests. </summary>
        public StreamAnalyticsDataSerializationEncoding? Encoding { get; set; }
        /// <summary> This property only applies to JSON serialization of outputs only. It is not applicable to inputs. This property specifies the format of the JSON the output will be written in. The currently supported values are 'lineSeparated' indicating the output will be formatted by having each JSON object separated by a new line and 'array' indicating the output will be formatted as an array of JSON objects. Default value is 'lineSeparated' if left null. </summary>
        public JsonOutputSerializationFormat? Format { get; set; }
    }
}
