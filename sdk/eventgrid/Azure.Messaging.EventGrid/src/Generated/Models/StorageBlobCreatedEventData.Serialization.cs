// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class StorageBlobCreatedEventData
    {
        internal static StorageBlobCreatedEventData DeserializeStorageBlobCreatedEventData(JsonElement element)
        {
            Optional<string> api = default;
            Optional<string> clientRequestId = default;
            Optional<string> requestId = default;
            Optional<string> eTag = default;
            Optional<string> contentType = default;
            Optional<long> contentLength = default;
            Optional<long> contentOffset = default;
            Optional<string> blobType = default;
            Optional<string> url = default;
            Optional<string> sequencer = default;
            Optional<string> identity = default;
            Optional<object> storageDiagnostics = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("api"))
                {
                    api = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientRequestId"))
                {
                    clientRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestId"))
                {
                    requestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eTag"))
                {
                    eTag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentType"))
                {
                    contentType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentLength"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    contentLength = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("contentOffset"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    contentOffset = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("blobType"))
                {
                    blobType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"))
                {
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sequencer"))
                {
                    sequencer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    identity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageDiagnostics"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    storageDiagnostics = property.Value.GetObject();
                    continue;
                }
            }
            return new StorageBlobCreatedEventData(api.Value, clientRequestId.Value, requestId.Value, eTag.Value, contentType.Value, Optional.ToNullable(contentLength), Optional.ToNullable(contentOffset), blobType.Value, url.Value, sequencer.Value, identity.Value, storageDiagnostics.Value);
        }
    }
}
