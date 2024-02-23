// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.MachineLearning
{
    public partial class MachineLearningEnvironmentVersionResource : IJsonModel<MachineLearningEnvironmentVersionData>
    {
        void IJsonModel<MachineLearningEnvironmentVersionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        MachineLearningEnvironmentVersionData IJsonModel<MachineLearningEnvironmentVersionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MachineLearningEnvironmentVersionData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<MachineLearningEnvironmentVersionData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        MachineLearningEnvironmentVersionData IPersistableModel<MachineLearningEnvironmentVersionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MachineLearningEnvironmentVersionData>(data, options);
        }

        string IPersistableModel<MachineLearningEnvironmentVersionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
