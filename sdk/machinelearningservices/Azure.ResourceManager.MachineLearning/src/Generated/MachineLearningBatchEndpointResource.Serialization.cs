// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.MachineLearning
{
    public partial class MachineLearningBatchEndpointResource : IJsonModel<MachineLearningBatchEndpointData>
    {
        void IJsonModel<MachineLearningBatchEndpointData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        MachineLearningBatchEndpointData IJsonModel<MachineLearningBatchEndpointData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MachineLearningBatchEndpointData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<MachineLearningBatchEndpointData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        MachineLearningBatchEndpointData IPersistableModel<MachineLearningBatchEndpointData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MachineLearningBatchEndpointData>(data, options);
        }

        string IPersistableModel<MachineLearningBatchEndpointData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
