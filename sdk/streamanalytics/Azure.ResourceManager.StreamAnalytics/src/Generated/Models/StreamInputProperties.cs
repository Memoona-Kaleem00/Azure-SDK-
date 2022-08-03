// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary>
    /// The properties that are associated with an input containing stream data.
    /// Serialized Name: StreamInputProperties
    /// </summary>
    public partial class StreamInputProperties : InputProperties
    {
        /// <summary> Initializes a new instance of StreamInputProperties. </summary>
        public StreamInputProperties()
        {
            InputPropertiesType = "Stream";
        }

        /// <summary> Initializes a new instance of StreamInputProperties. </summary>
        /// <param name="inputPropertiesType">
        /// Indicates whether the input is a source of reference data or stream data. Required on PUT (CreateOrReplace) requests.
        /// Serialized Name: InputProperties.type
        /// </param>
        /// <param name="serialization">
        /// Describes how data from an input is serialized or how data is serialized when written to an output. Required on PUT (CreateOrReplace) requests.
        /// Serialized Name: InputProperties.serialization
        /// Please note <see cref="Serialization"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AvroSerialization"/>, <see cref="CsvSerialization"/>, <see cref="CustomClrSerialization"/>, <see cref="JsonSerialization"/> and <see cref="ParquetSerialization"/>.
        /// </param>
        /// <param name="diagnostics">
        /// Describes conditions applicable to the Input, Output, or the job overall, that warrant customer attention.
        /// Serialized Name: InputProperties.diagnostics
        /// </param>
        /// <param name="etag">
        /// The current entity tag for the input. This is an opaque string. You can use it to detect whether the resource has changed between requests. You can also use it in the If-Match or If-None-Match headers for write operations for optimistic concurrency.
        /// Serialized Name: InputProperties.etag
        /// </param>
        /// <param name="compression">
        /// Describes how input data is compressed
        /// Serialized Name: InputProperties.compression
        /// </param>
        /// <param name="partitionKey">
        /// partitionKey Describes a key in the input data which is used for partitioning the input data
        /// Serialized Name: InputProperties.partitionKey
        /// </param>
        /// <param name="watermarkSettings">
        /// Settings which determine whether to read watermark events.
        /// Serialized Name: InputProperties.watermarkSettings
        /// </param>
        /// <param name="datasource">
        /// Describes an input data source that contains stream data. Required on PUT (CreateOrReplace) requests.
        /// Serialized Name: StreamInputProperties.datasource
        /// Please note <see cref="StreamInputDataSource"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="GatewayMessageBusStreamInputDataSource"/>, <see cref="IoTHubStreamInputDataSource"/>, <see cref="EventGridStreamInputDataSource"/>, <see cref="EventHubV2StreamInputDataSource"/>, <see cref="EventHubStreamInputDataSource"/>, <see cref="BlobStreamInputDataSource"/> and <see cref="RawStreamInputDataSource"/>.
        /// </param>
        internal StreamInputProperties(string inputPropertiesType, Serialization serialization, Diagnostics diagnostics, ETag? etag, Compression compression, string partitionKey, InputWatermarkProperties watermarkSettings, StreamInputDataSource datasource) : base(inputPropertiesType, serialization, diagnostics, etag, compression, partitionKey, watermarkSettings)
        {
            Datasource = datasource;
            InputPropertiesType = inputPropertiesType ?? "Stream";
        }

        /// <summary>
        /// Describes an input data source that contains stream data. Required on PUT (CreateOrReplace) requests.
        /// Serialized Name: StreamInputProperties.datasource
        /// Please note <see cref="StreamInputDataSource"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="GatewayMessageBusStreamInputDataSource"/>, <see cref="IoTHubStreamInputDataSource"/>, <see cref="EventGridStreamInputDataSource"/>, <see cref="EventHubV2StreamInputDataSource"/>, <see cref="EventHubStreamInputDataSource"/>, <see cref="BlobStreamInputDataSource"/> and <see cref="RawStreamInputDataSource"/>.
        /// </summary>
        public StreamInputDataSource Datasource { get; set; }
    }
}
