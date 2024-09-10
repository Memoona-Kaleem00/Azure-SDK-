// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class ServiceWorkspaceNotificationResource : IJsonModel<ApiManagementNotificationData>
    {
        void IJsonModel<ApiManagementNotificationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ApiManagementNotificationData>)Data).Write(writer, options);

        ApiManagementNotificationData IJsonModel<ApiManagementNotificationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ApiManagementNotificationData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ApiManagementNotificationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ApiManagementNotificationData IPersistableModel<ApiManagementNotificationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ApiManagementNotificationData>(data, options);

        string IPersistableModel<ApiManagementNotificationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ApiManagementNotificationData>)Data).GetFormatFromOptions(options);
    }
}
