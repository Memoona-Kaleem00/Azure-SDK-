// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Chaos
{
    public partial class ChaosExperimentResource : IJsonModel<ChaosExperimentData>
    {
        void IJsonModel<ChaosExperimentData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        ChaosExperimentData IJsonModel<ChaosExperimentData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ChaosExperimentData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<ChaosExperimentData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        ChaosExperimentData IPersistableModel<ChaosExperimentData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ChaosExperimentData>(data, options);
        }

        string IPersistableModel<ChaosExperimentData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
