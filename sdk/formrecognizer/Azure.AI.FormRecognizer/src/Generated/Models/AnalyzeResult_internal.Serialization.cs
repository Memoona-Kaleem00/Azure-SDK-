// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    internal partial class AnalyzeResult_internal
    {
        internal static AnalyzeResult_internal DeserializeAnalyzeResult_internal(JsonElement element)
        {
            string version = default;
            IReadOnlyList<ReadResult_internal> readResults = default;
            IReadOnlyList<PageResult_internal> pageResults = default;
            IReadOnlyList<DocumentResult_internal> documentResults = default;
            IReadOnlyList<FormRecognizerError> errors = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("version"))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("readResults"))
                {
                    List<ReadResult_internal> array = new List<ReadResult_internal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReadResult_internal.DeserializeReadResult_internal(item));
                    }
                    readResults = array;
                    continue;
                }
                if (property.NameEquals("pageResults"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PageResult_internal> array = new List<PageResult_internal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PageResult_internal.DeserializePageResult_internal(item));
                    }
                    pageResults = array;
                    continue;
                }
                if (property.NameEquals("documentResults"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DocumentResult_internal> array = new List<DocumentResult_internal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentResult_internal.DeserializeDocumentResult_internal(item));
                    }
                    documentResults = array;
                    continue;
                }
                if (property.NameEquals("errors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FormRecognizerError> array = new List<FormRecognizerError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FormRecognizerError.DeserializeFormRecognizerError(item));
                    }
                    errors = array;
                    continue;
                }
            }
            return new AnalyzeResult_internal(version, readResults, pageResults, documentResults, errors);
        }
    }
}
