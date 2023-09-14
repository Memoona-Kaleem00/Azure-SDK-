// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class DefaultErrorResponseError
    {
        internal static DefaultErrorResponseError DeserializeDefaultErrorResponseError(XElement element)
        {
            string code = default;
            string message = default;
            string target = default;
            string innererror = default;
            IReadOnlyList<DefaultErrorResponseErrorDetailsItem> details = default;
            if (element.Element("code") is XElement codeElement)
            {
                code = (string)codeElement;
            }
            if (element.Element("message") is XElement messageElement)
            {
                message = (string)messageElement;
            }
            if (element.Element("target") is XElement targetElement)
            {
                target = (string)targetElement;
            }
            if (element.Element("innererror") is XElement innererrorElement)
            {
                innererror = (string)innererrorElement;
            }
            var array = new List<DefaultErrorResponseErrorDetailsItem>();
            foreach (var e in element.Elements("DefaultErrorResponseErrorDetailsItem"))
            {
                array.Add(DefaultErrorResponseErrorDetailsItem.DeserializeDefaultErrorResponseErrorDetailsItem(e));
            }
            details = array;
            return new DefaultErrorResponseError(code, message, target, details, innererror);
        }

        internal static DefaultErrorResponseError DeserializeDefaultErrorResponseError(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> code = default;
            Optional<string> message = default;
            Optional<string> target = default;
            Optional<IReadOnlyList<DefaultErrorResponseErrorDetailsItem>> details = default;
            Optional<string> innererror = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DefaultErrorResponseErrorDetailsItem> array = new List<DefaultErrorResponseErrorDetailsItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DefaultErrorResponseErrorDetailsItem.DeserializeDefaultErrorResponseErrorDetailsItem(item));
                    }
                    details = array;
                    continue;
                }
                if (property.NameEquals("innererror"u8))
                {
                    innererror = property.Value.GetString();
                    continue;
                }
            }
            return new DefaultErrorResponseError(code.Value, message.Value, target.Value, Optional.ToList(details), innererror.Value);
        }
    }
}
