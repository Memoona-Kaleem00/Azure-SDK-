// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.CognitiveServices.Vision.Face
{
    using Microsoft.CognitiveServices;
    using Microsoft.CognitiveServices.Vision;
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Person operations.
    /// </summary>
    public partial interface IPerson
    {
        /// <summary>
        /// Create a new person in a specified person group.
        /// </summary>
        /// <param name='personGroupId'>
        /// Specifying the target person group to create the person.
        /// </param>
        /// <param name='name'>
        /// Display name of the target person. The maximum length is 128.
        /// </param>
        /// <param name='userData'>
        /// Optional fields for user-provided data attached to a person. Size
        /// limit is 16KB.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<CreatePersonResult>> CreateWithHttpMessagesAsync(string personGroupId, string name = default(string), string userData = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List all persons in a person group, and retrieve person information
        /// (including personId, name, userData and persistedFaceIds of
        /// registered faces of the person).
        /// </summary>
        /// <param name='personGroupId'>
        /// personGroupId of the target person group.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<PersonResult>>> ListWithHttpMessagesAsync(string personGroupId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete an existing person from a person group. Persisted face
        /// images of the person will also be deleted.
        /// </summary>
        /// <param name='personGroupId'>
        /// Specifying the person group containing the person.
        /// </param>
        /// <param name='personId'>
        /// The target personId to delete.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> DeleteWithHttpMessagesAsync(string personGroupId, string personId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieve a person's information, including registered persisted
        /// faces, name and userData.
        /// </summary>
        /// <param name='personGroupId'>
        /// Specifying the person group containing the target person.
        /// </param>
        /// <param name='personId'>
        /// Specifying the target person.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<PersonResult>> GetWithHttpMessagesAsync(string personGroupId, string personId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update name or userData of a person.
        /// </summary>
        /// <param name='personGroupId'>
        /// Specifying the person group containing the target person.
        /// </param>
        /// <param name='personId'>
        /// personId of the target person.
        /// </param>
        /// <param name='name'>
        /// Display name of the target person. The maximum length is 128.
        /// </param>
        /// <param name='userData'>
        /// Optional fields for user-provided data attached to a person. Size
        /// limit is 16KB.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> UpdateWithHttpMessagesAsync(string personGroupId, string personId, string name = default(string), string userData = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete a face from a person. Relative image for the persisted face
        /// will also be deleted.
        /// </summary>
        /// <param name='personGroupId'>
        /// Specifying the person group containing the target person.
        /// </param>
        /// <param name='personId'>
        /// Specifying the person that the target persisted face belong to.
        /// </param>
        /// <param name='persistedFaceId'>
        /// The persisted face to remove.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> DeleteFaceWithHttpMessagesAsync(string personGroupId, string personId, string persistedFaceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieve information about a persisted face (specified by
        /// persistedFaceId, personId and its belonging personGroupId).
        /// </summary>
        /// <param name='personGroupId'>
        /// Specifying the person group containing the target person.
        /// </param>
        /// <param name='personId'>
        /// Specifying the target person that the face belongs to.
        /// </param>
        /// <param name='persistedFaceId'>
        /// The persistedFaceId of the target persisted face of the person.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<PersonFaceResult>> GetFaceWithHttpMessagesAsync(string personGroupId, string personId, string persistedFaceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update a person persisted face's userData field.
        /// </summary>
        /// <param name='personGroupId'>
        /// Specifying the person group containing the target person.
        /// </param>
        /// <param name='personId'>
        /// personId of the target person.
        /// </param>
        /// <param name='persistedFaceId'>
        /// persistedFaceId of target face, which is persisted and will not
        /// expire.
        /// </param>
        /// <param name='userData'>
        /// User-provided data attached to the face. The size limit is 1KB
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> UpdateFaceWithHttpMessagesAsync(string personGroupId, string personId, string persistedFaceId, string userData = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Add a representative face to a person for identification. The input
        /// face is specified as an image with a targetFace rectangle.
        /// </summary>
        /// <param name='personGroupId'>
        /// Specifying the person group containing the target person.
        /// </param>
        /// <param name='personId'>
        /// Target person that the face is added to.
        /// </param>
        /// <param name='userData'>
        /// User-specified data about the target face to add for any purpose.
        /// The maximum length is 1KB.
        /// </param>
        /// <param name='targetFace'>
        /// A face rectangle to specify the target face to be added to a person
        /// in the format of "targetFace=left,top,width,height". E.g.
        /// "targetFace=10,10,100,100". If there is more than one face in the
        /// image, targetFace is required to specify which face to add. No
        /// targetFace means there is only one face detected in the entire
        /// image.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> AddFaceWithHttpMessagesAsync(string personGroupId, string personId, string userData = default(string), string targetFace = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Add a representative face to a person for identification. The input
        /// face is specified as an image with a targetFace rectangle.
        /// </summary>
        /// <param name='personGroupId'>
        /// Specifying the person group containing the target person.
        /// </param>
        /// <param name='personId'>
        /// Target person that the face is added to.
        /// </param>
        /// <param name='userData'>
        /// User-specified data about the target face to add for any purpose.
        /// The maximum length is 1KB.
        /// </param>
        /// <param name='targetFace'>
        /// A face rectangle to specify the target face to be added to a
        /// person, in the format of "targetFace=left,top,width,height". E.g.
        /// "targetFace=10,10,100,100". If there is more than one face in the
        /// image, targetFace is required to specify which face to add. No
        /// targetFace means there is only one face detected in the entire
        /// image.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="APIErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> AddFaceFromStreamWithHttpMessagesAsync(string personGroupId, string personId, string userData = default(string), string targetFace = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
