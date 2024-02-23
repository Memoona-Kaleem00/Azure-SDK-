// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.MachineLearning
{
    public partial class MachineLearningComputeResource : IJsonModel<MachineLearningComputeData>
    {
        void IJsonModel<MachineLearningComputeData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        MachineLearningComputeData IJsonModel<MachineLearningComputeData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MachineLearningComputeData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<MachineLearningComputeData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        MachineLearningComputeData IPersistableModel<MachineLearningComputeData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MachineLearningComputeData>(data, options);
        }

        string IPersistableModel<MachineLearningComputeData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
