// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class ReservationPurchaseContent : IUtf8JsonSerializable, IJsonModel<ReservationPurchaseContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReservationPurchaseContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ReservationPurchaseContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationPurchaseContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReservationPurchaseContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ReservedResourceType))
            {
                writer.WritePropertyName("reservedResourceType"u8);
                writer.WriteStringValue(ReservedResourceType.Value.ToString());
            }
            if (Optional.IsDefined(BillingScopeId))
            {
                writer.WritePropertyName("billingScopeId"u8);
                writer.WriteStringValue(BillingScopeId);
            }
            if (Optional.IsDefined(Term))
            {
                writer.WritePropertyName("term"u8);
                writer.WriteStringValue(Term.Value.ToString());
            }
            if (Optional.IsDefined(BillingPlan))
            {
                writer.WritePropertyName("billingPlan"u8);
                writer.WriteStringValue(BillingPlan.Value.ToString());
            }
            if (Optional.IsDefined(Quantity))
            {
                writer.WritePropertyName("quantity"u8);
                writer.WriteNumberValue(Quantity.Value);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(AppliedScopeType))
            {
                writer.WritePropertyName("appliedScopeType"u8);
                writer.WriteStringValue(AppliedScopeType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(AppliedScopes))
            {
                if (AppliedScopes != null)
                {
                    writer.WritePropertyName("appliedScopes"u8);
                    writer.WriteStartArray();
                    foreach (var item in AppliedScopes)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("appliedScopes");
                }
            }
            if (Optional.IsDefined(AppliedScopeProperties))
            {
                writer.WritePropertyName("appliedScopeProperties"u8);
                writer.WriteObjectValue(AppliedScopeProperties);
            }
            if (Optional.IsDefined(IsRenewEnabled))
            {
                writer.WritePropertyName("renew"u8);
                writer.WriteBooleanValue(IsRenewEnabled.Value);
            }
            if (Optional.IsDefined(ReservedResourceProperties))
            {
                writer.WritePropertyName("reservedResourceProperties"u8);
                writer.WriteObjectValue(ReservedResourceProperties);
            }
            if (Optional.IsDefined(ReviewOn))
            {
                writer.WritePropertyName("reviewDateTime"u8);
                writer.WriteStringValue(ReviewOn.Value, "O");
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

        ReservationPurchaseContent IJsonModel<ReservationPurchaseContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationPurchaseContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReservationPurchaseContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReservationPurchaseContent(document.RootElement, options);
        }

        internal static ReservationPurchaseContent DeserializeReservationPurchaseContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ReservationsSkuName> sku = default;
            Optional<AzureLocation> location = default;
            Optional<ReservedResourceType> reservedResourceType = default;
            Optional<ResourceIdentifier> billingScopeId = default;
            Optional<ReservationTerm> term = default;
            Optional<ReservationBillingPlan> billingPlan = default;
            Optional<int> quantity = default;
            Optional<string> displayName = default;
            Optional<AppliedScopeType> appliedScopeType = default;
            Optional<IList<string>> appliedScopes = default;
            Optional<AppliedScopeProperties> appliedScopeProperties = default;
            Optional<bool> renew = default;
            Optional<PurchaseRequestPropertiesReservedResourceProperties> reservedResourceProperties = default;
            Optional<DateTimeOffset> reviewDateTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = ReservationsSkuName.DeserializeReservationsSkuName(property.Value);
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("reservedResourceType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reservedResourceType = new ReservedResourceType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("billingScopeId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            billingScopeId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("term"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            term = new ReservationTerm(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("billingPlan"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            billingPlan = new ReservationBillingPlan(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("quantity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            quantity = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("appliedScopeType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            appliedScopeType = new AppliedScopeType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("appliedScopes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                appliedScopes = null;
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            appliedScopes = array;
                            continue;
                        }
                        if (property0.NameEquals("appliedScopeProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            appliedScopeProperties = AppliedScopeProperties.DeserializeAppliedScopeProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("renew"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            renew = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("reservedResourceProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reservedResourceProperties = PurchaseRequestPropertiesReservedResourceProperties.DeserializePurchaseRequestPropertiesReservedResourceProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("reviewDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reviewDateTime = property0.Value.GetDateTimeOffset("O");
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
            return new ReservationPurchaseContent(sku.Value, Optional.ToNullable(location), Optional.ToNullable(reservedResourceType), billingScopeId.Value, Optional.ToNullable(term), Optional.ToNullable(billingPlan), Optional.ToNullable(quantity), displayName.Value, Optional.ToNullable(appliedScopeType), Optional.ToList(appliedScopes), appliedScopeProperties.Value, Optional.ToNullable(renew), reservedResourceProperties.Value, Optional.ToNullable(reviewDateTime), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Location))
            {
                builder.Append("  location:");
                builder.AppendLine($" '{Location.Value.ToString()}'");
            }

            if (Optional.IsDefined(Sku))
            {
                builder.Append("  sku:");
                AppendChildObject(builder, Sku, options, 2, false);
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            if (Optional.IsDefined(ReservedResourceType))
            {
                builder.Append("    reservedResourceType:");
                builder.AppendLine($" '{ReservedResourceType.Value.ToString()}'");
            }

            if (Optional.IsDefined(BillingScopeId))
            {
                builder.Append("    billingScopeId:");
                builder.AppendLine($" '{BillingScopeId.ToString()}'");
            }

            if (Optional.IsDefined(Term))
            {
                builder.Append("    term:");
                builder.AppendLine($" '{Term.Value.ToString()}'");
            }

            if (Optional.IsDefined(BillingPlan))
            {
                builder.Append("    billingPlan:");
                builder.AppendLine($" '{BillingPlan.Value.ToString()}'");
            }

            if (Optional.IsDefined(Quantity))
            {
                builder.Append("    quantity:");
                builder.AppendLine($" {Quantity.Value}");
            }

            if (Optional.IsDefined(DisplayName))
            {
                builder.Append("    displayName:");
                if (DisplayName.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{DisplayName}'''");
                }
                else
                {
                    builder.AppendLine($" '{DisplayName}'");
                }
            }

            if (Optional.IsDefined(AppliedScopeType))
            {
                builder.Append("    appliedScopeType:");
                builder.AppendLine($" '{AppliedScopeType.Value.ToString()}'");
            }

            if (Optional.IsCollectionDefined(AppliedScopes))
            {
                if (AppliedScopes.Any())
                {
                    builder.Append("    appliedScopes:");
                    builder.AppendLine(" [");
                    foreach (var item in AppliedScopes)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        if (item.Contains(Environment.NewLine))
                        {
                            builder.AppendLine("      '''");
                            builder.AppendLine($"{item}'''");
                        }
                        else
                        {
                            builder.AppendLine($"      '{item}'");
                        }
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (Optional.IsDefined(AppliedScopeProperties))
            {
                builder.Append("    appliedScopeProperties:");
                AppendChildObject(builder, AppliedScopeProperties, options, 4, false);
            }

            if (Optional.IsDefined(IsRenewEnabled))
            {
                builder.Append("    renew:");
                var boolValue = IsRenewEnabled.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(ReservedResourceProperties))
            {
                builder.Append("    reservedResourceProperties:");
                AppendChildObject(builder, ReservedResourceProperties, options, 4, false);
            }

            if (Optional.IsDefined(ReviewOn))
            {
                builder.Append("    reviewDateTime:");
                var formattedDateTimeString = TypeFormatters.ToString(ReviewOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            bool inMultilineString = false;
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (inMultilineString)
                {
                    if (line.Contains("'''"))
                    {
                        inMultilineString = false;
                    }
                    stringBuilder.AppendLine(line);
                    continue;
                }
                if (line.Contains("'''"))
                {
                    inMultilineString = true;
                    stringBuilder.AppendLine($"{indent}{line}");
                    continue;
                }
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<ReservationPurchaseContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationPurchaseContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ReservationPurchaseContent)} does not support '{options.Format}' format.");
            }
        }

        ReservationPurchaseContent IPersistableModel<ReservationPurchaseContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationPurchaseContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReservationPurchaseContent(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ReservationPurchaseContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReservationPurchaseContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
