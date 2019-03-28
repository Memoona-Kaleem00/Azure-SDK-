// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.ContentModerator.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Refresh Index Response.
    /// </summary>
    public partial class RefreshIndex
    {
        /// <summary>
        /// Initializes a new instance of the RefreshIndex class.
        /// </summary>
        public RefreshIndex()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RefreshIndex class.
        /// </summary>
        /// <param name="contentSourceId">Content source Id.</param>
        /// <param name="isUpdateSuccess">Update success status.</param>
        /// <param name="advancedInfo">Advanced info list.</param>
        /// <param name="status">Refresh index status.</param>
        /// <param name="trackingId">Tracking Id.</param>
        public RefreshIndex(string contentSourceId = default(string), bool? isUpdateSuccess = default(bool?), IList<IDictionary<string, string>> advancedInfo = default(IList<IDictionary<string, string>>), Status status = default(Status), string trackingId = default(string))
        {
            ContentSourceId = contentSourceId;
            IsUpdateSuccess = isUpdateSuccess;
            AdvancedInfo = advancedInfo;
            Status = status;
            TrackingId = trackingId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets content source Id.
        /// </summary>
        [JsonProperty(PropertyName = "ContentSourceId")]
        public string ContentSourceId { get; set; }

        /// <summary>
        /// Gets or sets update success status.
        /// </summary>
        [JsonProperty(PropertyName = "IsUpdateSuccess")]
        public bool? IsUpdateSuccess { get; set; }

        /// <summary>
        /// Gets or sets advanced info list.
        /// </summary>
        [JsonProperty(PropertyName = "AdvancedInfo")]
        public IList<IDictionary<string, string>> AdvancedInfo { get; set; }

        /// <summary>
        /// Gets or sets refresh index status.
        /// </summary>
        [JsonProperty(PropertyName = "Status")]
        public Status Status { get; set; }

        /// <summary>
        /// Gets or sets tracking Id.
        /// </summary>
        [JsonProperty(PropertyName = "TrackingId")]
        public string TrackingId { get; set; }

    }
}
