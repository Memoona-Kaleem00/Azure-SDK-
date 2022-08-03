// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary>
    /// Describes how data from an input is serialized or how data is serialized when written to an output.
    /// Serialized Name: Serialization
    /// Please note <see cref="Serialization"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AvroSerialization"/>, <see cref="CsvSerialization"/>, <see cref="CustomClrSerialization"/>, <see cref="JsonSerialization"/> and <see cref="ParquetSerialization"/>.
    /// </summary>
    public partial class Serialization
    {
        /// <summary> Initializes a new instance of Serialization. </summary>
        public Serialization()
        {
        }

        /// <summary> Initializes a new instance of Serialization. </summary>
        /// <param name="eventSerializationType">
        /// Indicates the type of serialization that the input or output uses. Required on PUT (CreateOrReplace) requests.
        /// Serialized Name: Serialization.type
        /// </param>
        internal Serialization(EventSerializationType eventSerializationType)
        {
            EventSerializationType = eventSerializationType;
        }

        /// <summary>
        /// Indicates the type of serialization that the input or output uses. Required on PUT (CreateOrReplace) requests.
        /// Serialized Name: Serialization.type
        /// </summary>
        internal EventSerializationType EventSerializationType { get; set; }
    }
}
