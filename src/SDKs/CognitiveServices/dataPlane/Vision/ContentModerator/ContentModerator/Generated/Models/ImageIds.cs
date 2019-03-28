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
    /// Image Id properties.
    /// </summary>
    public partial class ImageIds
    {
        /// <summary>
        /// Initializes a new instance of the ImageIds class.
        /// </summary>
        public ImageIds()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageIds class.
        /// </summary>
        /// <param name="contentSource">Source of the content.</param>
        /// <param name="contentIds">Id of the contents.</param>
        /// <param name="status">Get Image status.</param>
        /// <param name="trackingId">Tracking Id.</param>
        public ImageIds(string contentSource = default(string), IList<int?> contentIds = default(IList<int?>), Status status = default(Status), string trackingId = default(string))
        {
            ContentSource = contentSource;
            ContentIds = contentIds;
            Status = status;
            TrackingId = trackingId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets source of the content.
        /// </summary>
        [JsonProperty(PropertyName = "ContentSource")]
        public string ContentSource { get; set; }

        /// <summary>
        /// Gets or sets id of the contents.
        /// </summary>
        [JsonProperty(PropertyName = "ContentIds")]
        public IList<int?> ContentIds { get; set; }

        /// <summary>
        /// Gets or sets get Image status.
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
