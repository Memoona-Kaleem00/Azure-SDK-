// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.Translation.Document
{
    /// <summary> The FileFormat. </summary>
    public partial class DocumentTranslationFileFormat
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DocumentTranslationFileFormat"/>. </summary>
        /// <param name="format"> Name of the format. </param>
        /// <param name="fileExtensions"> Supported file extension for this format. </param>
        /// <param name="contentTypes"> Supported Content-Types for this format. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="format"/>, <paramref name="fileExtensions"/> or <paramref name="contentTypes"/> is null. </exception>
        internal DocumentTranslationFileFormat(string format, IEnumerable<string> fileExtensions, IEnumerable<string> contentTypes)
        {
            Argument.AssertNotNull(format, nameof(format));
            Argument.AssertNotNull(fileExtensions, nameof(fileExtensions));
            Argument.AssertNotNull(contentTypes, nameof(contentTypes));

            Format = format;
            FileExtensions = fileExtensions.ToList();
            ContentTypes = contentTypes.ToList();
            FormatVersions = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="DocumentTranslationFileFormat"/>. </summary>
        /// <param name="format"> Name of the format. </param>
        /// <param name="fileExtensions"> Supported file extension for this format. </param>
        /// <param name="contentTypes"> Supported Content-Types for this format. </param>
        /// <param name="defaultFormatVersion"> Default version if none is specified. </param>
        /// <param name="formatVersions"> Supported Version. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DocumentTranslationFileFormat(string format, IReadOnlyList<string> fileExtensions, IReadOnlyList<string> contentTypes, string defaultFormatVersion, IReadOnlyList<string> formatVersions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Format = format;
            FileExtensions = fileExtensions;
            ContentTypes = contentTypes;
            DefaultFormatVersion = defaultFormatVersion;
            FormatVersions = formatVersions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentTranslationFileFormat"/> for deserialization. </summary>
        internal DocumentTranslationFileFormat()
        {
        }

        /// <summary> Name of the format. </summary>
        public string Format { get; }
        /// <summary> Supported file extension for this format. </summary>
        public IReadOnlyList<string> FileExtensions { get; }
        /// <summary> Supported Content-Types for this format. </summary>
        public IReadOnlyList<string> ContentTypes { get; }
    }
}
