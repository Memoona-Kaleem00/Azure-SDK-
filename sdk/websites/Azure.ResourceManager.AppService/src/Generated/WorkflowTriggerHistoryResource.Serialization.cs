// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AppService
{
    public partial class WorkflowTriggerHistoryResource : IJsonModel<WorkflowTriggerHistoryData>
    {
        void IJsonModel<WorkflowTriggerHistoryData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<WorkflowTriggerHistoryData>)Data).Write(writer, options);

        WorkflowTriggerHistoryData IJsonModel<WorkflowTriggerHistoryData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<WorkflowTriggerHistoryData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<WorkflowTriggerHistoryData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        WorkflowTriggerHistoryData IPersistableModel<WorkflowTriggerHistoryData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<WorkflowTriggerHistoryData>(data, options);

        string IPersistableModel<WorkflowTriggerHistoryData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<WorkflowTriggerHistoryData>)Data).GetFormatFromOptions(options);
    }
}
