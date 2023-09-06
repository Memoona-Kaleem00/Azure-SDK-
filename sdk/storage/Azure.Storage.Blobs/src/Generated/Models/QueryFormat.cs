// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> The QueryFormat. </summary>
    internal partial class QueryFormat
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="QueryFormat"/>. </summary>
        /// <param name="type"> The quick query format type. </param>
        public QueryFormat(QueryFormatType type)
        {
            Type = type;
        }

        /// <summary> Initializes a new instance of <see cref="QueryFormat"/>. </summary>
        /// <param name="type"> The quick query format type. </param>
        /// <param name="delimitedTextConfiguration"> Groups the settings used for interpreting the blob data if the blob is delimited text formatted. </param>
        /// <param name="jsonTextConfiguration"> json text configuration. </param>
        /// <param name="arrowConfiguration"> Groups the settings used for formatting the response if the response should be Arrow formatted. </param>
        /// <param name="parquetTextConfiguration"> parquet configuration. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal QueryFormat(QueryFormatType type, DelimitedTextConfigurationInternal delimitedTextConfiguration, JsonTextConfigurationInternal jsonTextConfiguration, ArrowTextConfigurationInternal arrowConfiguration, object parquetTextConfiguration, Dictionary<string, BinaryData> rawData)
        {
            Type = type;
            DelimitedTextConfiguration = delimitedTextConfiguration;
            JsonTextConfiguration = jsonTextConfiguration;
            ArrowConfiguration = arrowConfiguration;
            ParquetTextConfiguration = parquetTextConfiguration;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="QueryFormat"/> for deserialization. </summary>
        internal QueryFormat()
        {
        }

        /// <summary> The quick query format type. </summary>
        public QueryFormatType Type { get; }
        /// <summary> Groups the settings used for interpreting the blob data if the blob is delimited text formatted. </summary>
        public DelimitedTextConfigurationInternal DelimitedTextConfiguration { get; set; }
        /// <summary> json text configuration. </summary>
        public JsonTextConfigurationInternal JsonTextConfiguration { get; set; }
        /// <summary> Groups the settings used for formatting the response if the response should be Arrow formatted. </summary>
        public ArrowTextConfigurationInternal ArrowConfiguration { get; set; }
        /// <summary> parquet configuration. </summary>
        public object ParquetTextConfiguration { get; set; }
    }
}
