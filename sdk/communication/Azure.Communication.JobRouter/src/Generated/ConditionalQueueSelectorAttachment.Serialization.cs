// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;

namespace Azure.Communication.JobRouter
{
    public partial class ConditionalQueueSelectorAttachment
    {
        internal static ConditionalQueueSelectorAttachment DeserializeConditionalQueueSelectorAttachment(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RouterRule condition = default;
            IList<RouterQueueSelector> queueSelectors = default;
            string kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("condition"u8))
                {
                    condition = RouterRule.DeserializeRouterRule(property.Value);
                    continue;
                }
                if (property.NameEquals("queueSelectors"u8))
                {
                    List<RouterQueueSelector> array = new List<RouterQueueSelector>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouterQueueSelector.DeserializeRouterQueueSelector(item));
                    }
                    queueSelectors = array;
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
            }
            return new ConditionalQueueSelectorAttachment(kind, condition, queueSelectors);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new ConditionalQueueSelectorAttachment FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeConditionalQueueSelectorAttachment(document.RootElement);
        }
    }
}
