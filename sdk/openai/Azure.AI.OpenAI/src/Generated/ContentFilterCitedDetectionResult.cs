// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary> Represents the outcome of a detection operation against protected resources as performed by content filtering. </summary>
    public partial class ContentFilterCitedDetectionResult
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContentFilterCitedDetectionResult"/>. </summary>
        /// <param name="filtered"> A value indicating whether or not the content has been filtered. </param>
        /// <param name="detected"> A value indicating whether detection occurred, irrespective of severity or whether the content was filtered. </param>
        /// <param name="license"> The license description associated with the detection. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="license"/> is null. </exception>
        internal ContentFilterCitedDetectionResult(bool filtered, bool detected, string license)
        {
            Argument.AssertNotNull(license, nameof(license));

            Filtered = filtered;
            Detected = detected;
            License = license;
        }

        /// <summary> Initializes a new instance of <see cref="ContentFilterCitedDetectionResult"/>. </summary>
        /// <param name="filtered"> A value indicating whether or not the content has been filtered. </param>
        /// <param name="detected"> A value indicating whether detection occurred, irrespective of severity or whether the content was filtered. </param>
        /// <param name="url"> The internet location associated with the detection. </param>
        /// <param name="license"> The license description associated with the detection. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContentFilterCitedDetectionResult(bool filtered, bool detected, Uri url, string license, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Filtered = filtered;
            Detected = detected;
            Url = url;
            License = license;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContentFilterCitedDetectionResult"/> for deserialization. </summary>
        internal ContentFilterCitedDetectionResult()
        {
        }

        /// <summary> A value indicating whether or not the content has been filtered. </summary>
        public bool Filtered { get; }
        /// <summary> A value indicating whether detection occurred, irrespective of severity or whether the content was filtered. </summary>
        public bool Detected { get; }
        /// <summary> The internet location associated with the detection. </summary>
        public Uri Url { get; }
        /// <summary> The license description associated with the detection. </summary>
        public string License { get; }
    }
}
