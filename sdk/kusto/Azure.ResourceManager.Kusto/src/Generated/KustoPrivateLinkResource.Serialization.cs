// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Kusto
{
    public partial class KustoPrivateLinkResource : IJsonModel<KustoPrivateLinkResourceData>
    {
        void IJsonModel<KustoPrivateLinkResourceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<KustoPrivateLinkResourceData>)Data).Write(writer, options);

        KustoPrivateLinkResourceData IJsonModel<KustoPrivateLinkResourceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<KustoPrivateLinkResourceData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<KustoPrivateLinkResourceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        KustoPrivateLinkResourceData IPersistableModel<KustoPrivateLinkResourceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<KustoPrivateLinkResourceData>(data, options);

        string IPersistableModel<KustoPrivateLinkResourceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<KustoPrivateLinkResourceData>)Data).GetFormatFromOptions(options);
    }
}
