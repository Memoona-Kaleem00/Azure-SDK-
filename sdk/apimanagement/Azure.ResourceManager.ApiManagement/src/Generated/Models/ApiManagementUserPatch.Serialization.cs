// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiManagementUserPatch : IUtf8JsonSerializable, IJsonModel<ApiManagementUserPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApiManagementUserPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApiManagementUserPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementUserPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiManagementUserPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (State.HasValue)
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Note != null)
            {
                writer.WritePropertyName("note"u8);
                writer.WriteStringValue(Note);
            }
            if (!(Identities is ChangeTrackingList<UserIdentityContract> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("identities"u8);
                writer.WriteStartArray();
                foreach (var item in Identities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Email != null)
            {
                writer.WritePropertyName("email"u8);
                writer.WriteStringValue(Email);
            }
            if (Password != null)
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            if (FirstName != null)
            {
                writer.WritePropertyName("firstName"u8);
                writer.WriteStringValue(FirstName);
            }
            if (LastName != null)
            {
                writer.WritePropertyName("lastName"u8);
                writer.WriteStringValue(LastName);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ApiManagementUserPatch IJsonModel<ApiManagementUserPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementUserPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiManagementUserPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApiManagementUserPatch(document.RootElement, options);
        }

        internal static ApiManagementUserPatch DeserializeApiManagementUserPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ApiManagementUserState> state = default;
            Optional<string> note = default;
            IList<UserIdentityContract> identities = default;
            Optional<string> email = default;
            Optional<string> password = default;
            Optional<string> firstName = default;
            Optional<string> lastName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = new ApiManagementUserState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("note"u8))
                        {
                            note = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("identities"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<UserIdentityContract> array = new List<UserIdentityContract>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(UserIdentityContract.DeserializeUserIdentityContract(item, options));
                            }
                            identities = array;
                            continue;
                        }
                        if (property0.NameEquals("email"u8))
                        {
                            email = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("password"u8))
                        {
                            password = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("firstName"u8))
                        {
                            firstName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastName"u8))
                        {
                            lastName = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApiManagementUserPatch(Optional.ToNullable(state), note.Value, identities ?? new ChangeTrackingList<UserIdentityContract>(), email.Value, password.Value, firstName.Value, lastName.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApiManagementUserPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementUserPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApiManagementUserPatch)} does not support '{options.Format}' format.");
            }
        }

        ApiManagementUserPatch IPersistableModel<ApiManagementUserPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementUserPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApiManagementUserPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApiManagementUserPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApiManagementUserPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
