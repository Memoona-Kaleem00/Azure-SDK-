// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Automation
{
    public partial class HybridRunbookWorkerGroupResource : IJsonModel<HybridRunbookWorkerGroupData>
    {
        void IJsonModel<HybridRunbookWorkerGroupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        HybridRunbookWorkerGroupData IJsonModel<HybridRunbookWorkerGroupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<HybridRunbookWorkerGroupData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<HybridRunbookWorkerGroupData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        HybridRunbookWorkerGroupData IPersistableModel<HybridRunbookWorkerGroupData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<HybridRunbookWorkerGroupData>(data, options);
        }

        string IPersistableModel<HybridRunbookWorkerGroupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
