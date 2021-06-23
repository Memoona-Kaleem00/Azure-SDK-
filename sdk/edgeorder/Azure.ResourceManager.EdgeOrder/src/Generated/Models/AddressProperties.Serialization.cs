// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class AddressProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ShippingAddress))
            {
                writer.WritePropertyName("shippingAddress");
                writer.WriteObjectValue(ShippingAddress);
            }
            writer.WritePropertyName("contactDetails");
            writer.WriteObjectValue(ContactDetails);
            writer.WriteEndObject();
        }

        internal static AddressProperties DeserializeAddressProperties(JsonElement element)
        {
            Optional<ShippingAddress> shippingAddress = default;
            ContactDetails contactDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("shippingAddress"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    shippingAddress = ShippingAddress.DeserializeShippingAddress(property.Value);
                    continue;
                }
                if (property.NameEquals("contactDetails"))
                {
                    contactDetails = ContactDetails.DeserializeContactDetails(property.Value);
                    continue;
                }
            }
            return new AddressProperties(shippingAddress.Value, contactDetails);
        }
    }
}
