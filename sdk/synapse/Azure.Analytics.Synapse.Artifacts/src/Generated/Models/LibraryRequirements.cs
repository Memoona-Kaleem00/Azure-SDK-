// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Library requirements for a Big Data pool powered by Apache Spark. </summary>
    public partial class LibraryRequirements
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LibraryRequirements"/>. </summary>
        public LibraryRequirements()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LibraryRequirements"/>. </summary>
        /// <param name="time"> The last update time of the library requirements file. </param>
        /// <param name="content"> The library requirements. </param>
        /// <param name="filename"> The filename of the library requirements file. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LibraryRequirements(DateTimeOffset? time, string content, string filename, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Time = time;
            Content = content;
            Filename = filename;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The last update time of the library requirements file. </summary>
        public DateTimeOffset? Time { get; }
        /// <summary> The library requirements. </summary>
        public string Content { get; set; }
        /// <summary> The filename of the library requirements file. </summary>
        public string Filename { get; set; }
    }
}
