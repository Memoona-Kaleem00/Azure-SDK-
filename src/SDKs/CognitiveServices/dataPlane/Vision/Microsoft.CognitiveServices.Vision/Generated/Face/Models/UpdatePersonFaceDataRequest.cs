// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.CognitiveServices.Vision.Face.Models
{
    using Microsoft.CognitiveServices;
    using Microsoft.CognitiveServices.Vision;
    using Microsoft.CognitiveServices.Vision.Face;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Request to update person face data.
    /// </summary>
    public partial class UpdatePersonFaceDataRequest
    {
        /// <summary>
        /// Initializes a new instance of the UpdatePersonFaceDataRequest
        /// class.
        /// </summary>
        public UpdatePersonFaceDataRequest()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdatePersonFaceDataRequest
        /// class.
        /// </summary>
        /// <param name="userData">User-provided data attached to the face. The
        /// size limit is 1KB</param>
        public UpdatePersonFaceDataRequest(string userData = default(string))
        {
            UserData = userData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets user-provided data attached to the face. The size
        /// limit is 1KB
        /// </summary>
        [JsonProperty(PropertyName = "userData")]
        public string UserData { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (UserData != null)
            {
                if (UserData.Length > 1024)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "UserData", 1024);
                }
            }
        }
    }
}
