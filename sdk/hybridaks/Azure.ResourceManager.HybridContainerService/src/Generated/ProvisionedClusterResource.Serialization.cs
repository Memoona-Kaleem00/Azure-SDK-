// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.HybridContainerService
{
    public partial class ProvisionedClusterResource : IJsonModel<ProvisionedClusterData>
    {
        void IJsonModel<ProvisionedClusterData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        ProvisionedClusterData IJsonModel<ProvisionedClusterData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ProvisionedClusterData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<ProvisionedClusterData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        ProvisionedClusterData IPersistableModel<ProvisionedClusterData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ProvisionedClusterData>(data, options);
        }

        string IPersistableModel<ProvisionedClusterData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
