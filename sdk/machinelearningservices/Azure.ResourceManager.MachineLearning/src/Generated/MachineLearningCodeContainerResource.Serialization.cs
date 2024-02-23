// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.MachineLearning
{
    public partial class MachineLearningCodeContainerResource : IJsonModel<MachineLearningCodeContainerData>
    {
        void IJsonModel<MachineLearningCodeContainerData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        MachineLearningCodeContainerData IJsonModel<MachineLearningCodeContainerData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MachineLearningCodeContainerData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<MachineLearningCodeContainerData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        MachineLearningCodeContainerData IPersistableModel<MachineLearningCodeContainerData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MachineLearningCodeContainerData>(data, options);
        }

        string IPersistableModel<MachineLearningCodeContainerData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
