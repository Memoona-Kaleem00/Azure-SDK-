// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.CognitiveServices.Vision.Face.Models
{
    using Microsoft.CognitiveServices;
    using Microsoft.CognitiveServices.Vision;
    using Microsoft.CognitiveServices.Vision.Face;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Request body for group request.
    /// </summary>
    public partial class GroupRequest
    {
        /// <summary>
        /// Initializes a new instance of the GroupRequest class.
        /// </summary>
        public GroupRequest()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GroupRequest class.
        /// </summary>
        /// <param name="faceIds">Array of candidate faceId created by Face -
        /// Detect. The maximum is 1000 faces</param>
        public GroupRequest(IList<string> faceIds)
        {
            FaceIds = faceIds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets array of candidate faceId created by Face - Detect.
        /// The maximum is 1000 faces
        /// </summary>
        [JsonProperty(PropertyName = "faceIds")]
        public IList<string> FaceIds { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FaceIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FaceIds");
            }
            if (FaceIds != null)
            {
                if (FaceIds.Count > 1000)
                {
                    throw new ValidationException(ValidationRules.MaxItems, "FaceIds", 1000);
                }
            }
        }
    }
}
