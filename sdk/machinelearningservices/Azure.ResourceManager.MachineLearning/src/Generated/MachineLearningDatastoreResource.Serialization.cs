// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.MachineLearning
{
    public partial class MachineLearningDatastoreResource : IJsonModel<MachineLearningDatastoreData>
    {
        void IJsonModel<MachineLearningDatastoreData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        MachineLearningDatastoreData IJsonModel<MachineLearningDatastoreData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MachineLearningDatastoreData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<MachineLearningDatastoreData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        MachineLearningDatastoreData IPersistableModel<MachineLearningDatastoreData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MachineLearningDatastoreData>(data, options);
        }

        string IPersistableModel<MachineLearningDatastoreData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
