// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> The MediaJobOutputProcessingEventData. </summary>
    public partial class MediaJobOutputProcessingEventData : MediaJobOutputStateChangeEventData
    {
        /// <summary> Initializes a new instance of <see cref="MediaJobOutputProcessingEventData"/>. </summary>
        /// <param name="previousState"></param>
        /// <param name="output">
        /// Please note <see cref="MediaJobOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MediaJobOutputAsset"/>.
        /// </param>
        /// <param name="jobCorrelationData"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="output"/> or <paramref name="jobCorrelationData"/> is null. </exception>
        internal MediaJobOutputProcessingEventData(MediaJobState previousState, MediaJobOutput output, IReadOnlyDictionary<string, string> jobCorrelationData) : base(previousState, output, jobCorrelationData)
        {
            Argument.AssertNotNull(output, nameof(output));
            Argument.AssertNotNull(jobCorrelationData, nameof(jobCorrelationData));
        }

        /// <summary> Initializes a new instance of <see cref="MediaJobOutputProcessingEventData"/>. </summary>
        /// <param name="previousState"></param>
        /// <param name="output">
        /// Please note <see cref="MediaJobOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MediaJobOutputAsset"/>.
        /// </param>
        /// <param name="jobCorrelationData"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MediaJobOutputProcessingEventData(MediaJobState previousState, MediaJobOutput output, IReadOnlyDictionary<string, string> jobCorrelationData, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(previousState, output, jobCorrelationData, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="MediaJobOutputProcessingEventData"/> for deserialization. </summary>
        internal MediaJobOutputProcessingEventData()
        {
        }
    }
}
