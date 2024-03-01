// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.HybridCompute
{
    public partial class HybridComputeMachineExtensionResource : IJsonModel<HybridComputeMachineExtensionData>
    {
        void IJsonModel<HybridComputeMachineExtensionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<HybridComputeMachineExtensionData>)Data).Write(writer, options);

        HybridComputeMachineExtensionData IJsonModel<HybridComputeMachineExtensionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<HybridComputeMachineExtensionData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<HybridComputeMachineExtensionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        HybridComputeMachineExtensionData IPersistableModel<HybridComputeMachineExtensionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<HybridComputeMachineExtensionData>(data, options);

        string IPersistableModel<HybridComputeMachineExtensionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<HybridComputeMachineExtensionData>)Data).GetFormatFromOptions(options);
    }
}
