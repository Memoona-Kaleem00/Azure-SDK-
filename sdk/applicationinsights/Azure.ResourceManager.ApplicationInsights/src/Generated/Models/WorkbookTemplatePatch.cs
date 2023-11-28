// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> The parameters that can be provided when updating workbook template. </summary>
    public partial class WorkbookTemplatePatch
    {
        /// <summary> Initializes a new instance of <see cref="WorkbookTemplatePatch"/>. </summary>
        public WorkbookTemplatePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            Galleries = new ChangeTrackingList<WorkbookTemplateGallery>();
            Localized = new ChangeTrackingDictionary<string, IList<WorkbookTemplateLocalizedGallery>>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Priority of the template. Determines which template to open when a workbook gallery is opened in viewer mode. </summary>
        public int? Priority { get; set; }
        /// <summary> Information about the author of the workbook template. </summary>
        public string Author { get; set; }
        /// <summary>
        /// Valid JSON object containing workbook template payload.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData TemplateData { get; set; }
        /// <summary> Workbook galleries supported by the template. </summary>
        public IList<WorkbookTemplateGallery> Galleries { get; }
        /// <summary> Key value pair of localized gallery. Each key is the locale code of languages supported by the Azure portal. </summary>
        public IDictionary<string, IList<WorkbookTemplateLocalizedGallery>> Localized { get; }
    }
}
