// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.Face
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// FaceListOperations operations.
    /// </summary>
    public partial interface IFaceListOperations
    {
        /// <summary>
        /// Create an empty face list with user-specified faceListId, name, an
        /// optional userData and recognitionModel. Up to 64 face lists are
        /// allowed in one subscription.
        /// &lt;br /&gt; Face list is a list of faces, up to 1,000 faces, and
        /// used by [Face - Find
        /// Similar](/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f30395237).
        /// &lt;br /&gt; After creation, user should use [FaceList - Add
        /// Face](/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f30395250)
        /// to import the faces. Faces are stored on server until [FaceList -
        /// Delete](/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f3039524f)
        /// is called.
        /// &lt;br /&gt; Find Similar is used for scenario like finding
        /// celebrity-like faces, similar face filtering, or as a light way
        /// face identification. But if the actual use is to identify person,
        /// please use
        /// [PersonGroup](/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f30395244)
        /// /
        /// [LargePersonGroup](/docs/services/563879b61984550e40cbbe8d/operations/599acdee6ac60f11b48b5a9d)
        /// and [Face -
        /// Identify](/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f30395239).
        /// &lt;br /&gt; Please consider
        /// [LargeFaceList](/docs/services/563879b61984550e40cbbe8d/operations/5a157b68d2de3616c086f2cc)
        /// when the face number is large. It can support up to 1,000,000
        /// faces. 'recognitionModel' should be specified to associate with
        /// this face list. The default value for 'recognitionModel' is
        /// 'recognition_01', if the latest model needed, please explicitly
        /// specify the model you need in this parameter. New faces that are
        /// added to an existing face list will use the recognition model
        /// that's already associated with the collection. Existing face
        /// features in a face list can't be updated to features extracted by
        /// another version of recognition model.
        ///
        /// </summary>
        /// <param name='faceListId'>
        /// Id referencing a particular face list.
        /// </param>
        /// <param name='name'>
        /// User defined name, maximum length is 128.
        /// </param>
        /// <param name='userData'>
        /// User specified data. Length should not exceed 16KB.
        /// </param>
        /// <param name='recognitionModel'>
        /// Possible values include: 'recognition_01', 'recognition_02'
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
        Task<HttpOperationResponse> CreateWithHttpMessagesAsync(string faceListId, string name = default(string), string userData = default(string), string recognitionModel = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieve a face list’s faceListId, name, userData, recognitionModel
        /// and faces in the face list.
        ///
        /// </summary>
        /// <param name='faceListId'>
        /// Id referencing a particular face list.
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
        Task<HttpOperationResponse<FaceList>> GetWithHttpMessagesAsync(string faceListId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update information of a face list.
        /// </summary>
        /// <param name='faceListId'>
        /// Id referencing a particular face list.
        /// </param>
        /// <param name='name'>
        /// User defined name, maximum length is 128.
        /// </param>
        /// <param name='userData'>
        /// User specified data. Length should not exceed 16KB.
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
        Task<HttpOperationResponse> UpdateWithHttpMessagesAsync(string faceListId, string name = default(string), string userData = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete an existing face list according to faceListId. Persisted
        /// face images in the face list will also be deleted.
        /// </summary>
        /// <param name='faceListId'>
        /// Id referencing a particular face list.
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
        Task<HttpOperationResponse> DeleteWithHttpMessagesAsync(string faceListId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List face lists’ faceListId, name, userData and recognitionModel.
        /// &lt;br /&gt;
        /// To get face information inside faceList use [FaceList -
        /// Get](/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f3039524c)
        ///
        /// </summary>
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
        Task<HttpOperationResponse<IList<FaceList>>> ListWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete an existing face from a face list (given by a
        /// persistedFaceId and a faceListId). Persisted image related to the
        /// face will also be deleted.
        /// </summary>
        /// <param name='faceListId'>
        /// Id referencing a particular face list.
        /// </param>
        /// <param name='persistedFaceId'>
        /// Id referencing a particular persistedFaceId of an existing face.
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
        Task<HttpOperationResponse> DeleteFaceWithHttpMessagesAsync(string faceListId, System.Guid persistedFaceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Add a face to a face list. The input face is specified as an image
        /// with a targetFace rectangle. It returns a persistedFaceId
        /// representing the added face, and persistedFaceId will not expire.
        /// </summary>
        /// <param name='faceListId'>
        /// Id referencing a particular face list.
        /// </param>
        /// <param name='url'>
        /// Publicly reachable URL of an image
        /// </param>
        /// <param name='userData'>
        /// User-specified data about the face for any purpose. The maximum
        /// length is 1KB.
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
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<PersistedFace>> AddFaceFromUrlWithHttpMessagesAsync(string faceListId, string url, string userData = default(string), IList<int> targetFace = default(IList<int>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Add a face to a face list. The input face is specified as an image
        /// with a targetFace rectangle. It returns a persistedFaceId
        /// representing the added face, and persistedFaceId will not expire.
        /// </summary>
        /// <param name='faceListId'>
        /// Id referencing a particular face list.
        /// </param>
        /// <param name='image'>
        /// An image stream.
        /// </param>
        /// <param name='userData'>
        /// User-specified data about the face for any purpose. The maximum
        /// length is 1KB.
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
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<PersistedFace>> AddFaceFromStreamWithHttpMessagesAsync(string faceListId, Stream image, string userData = default(string), IList<int> targetFace = default(IList<int>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
