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
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// FaceOperations operations.
    /// </summary>
    public partial interface IFaceOperations
    {
        /// <summary>
        /// Given query face's faceId, find the similar-looking faces from a
        /// faceId array or a faceListId.
        /// </summary>
        /// <param name='faceId'>
        /// FaceId of the query face. User needs to call Face - Detect first to
        /// get a valid faceId. Note that this faceId is not persisted and will
        /// expire 24 hours after the detection call
        /// </param>
        /// <param name='faceListId'>
        /// An existing user-specified unique candidate face list, created in
        /// Face List - Create a Face List. Face list contains a set of
        /// persistedFaceIds which are persisted and will never expire.
        /// Parameter faceListId and faceIds should not be provided at the same
        /// time
        /// </param>
        /// <param name='faceIds'>
        /// An array of candidate faceIds. All of them are created by Face -
        /// Detect and the faceIds will expire 24 hours after the detection
        /// call.
        /// </param>
        /// <param name='maxNumOfCandidatesReturned'>
        /// The number of top similar faces returned. The valid range is [1,
        /// 1000].
        /// </param>
        /// <param name='mode'>
        /// Similar face searching mode. It can be "matchPerson" or
        /// "matchFace". Possible values include: 'matchPerson', 'matchFace'
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
        Task<HttpOperationResponse<IList<SimilarFaceResult>>> FindSimilarWithHttpMessagesAsync(string faceId, string faceListId = default(string), IList<string> faceIds = default(IList<string>), int? maxNumOfCandidatesReturned = 20, string mode = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Divide candidate faces into groups based on face similarity.
        /// </summary>
        /// <param name='faceIds'>
        /// Array of candidate faceId created by Face - Detect. The maximum is
        /// 1000 faces
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
        Task<HttpOperationResponse<GroupResponse>> GroupWithHttpMessagesAsync(IList<string> faceIds, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Identify unknown faces from a person group.
        /// </summary>
        /// <param name='personGroupId'>
        /// personGroupId of the target person group, created by
        /// PersonGroups.Create
        /// </param>
        /// <param name='faceIds'>
        /// Array of candidate faceId created by Face - Detect.
        /// </param>
        /// <param name='maxNumOfCandidatesReturned'>
        /// The number of top similar faces returned.
        /// </param>
        /// <param name='confidenceThreshold'>
        /// Confidence threshold of identification, used to judge whether one
        /// face belong to one person.
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
        Task<HttpOperationResponse<IList<IdentifyResultItem>>> IdentifyWithHttpMessagesAsync(string personGroupId, IList<string> faceIds, int? maxNumOfCandidatesReturned = 1, double? confidenceThreshold = default(double?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Verify whether two faces belong to a same person or whether one
        /// face belongs to a person.
        /// </summary>
        /// <param name='faceId'>
        /// faceId the face, comes from Face - Detect
        /// </param>
        /// <param name='personId'>
        /// Specify a certain person in a person group. personId is created in
        /// Persons.Create.
        /// </param>
        /// <param name='personGroupId'>
        /// Using existing personGroupId and personId for fast loading a
        /// specified person. personGroupId is created in Person Groups.Create.
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
        Task<HttpOperationResponse<VerifyResult>> VerifyWithHttpMessagesAsync(string faceId, string personId, string personGroupId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Detect human faces in an image and returns face locations, and
        /// optionally with faceIds, landmarks, and attributes.
        /// </summary>
        /// <param name='url'>
        /// </param>
        /// <param name='returnFaceId'>
        /// A value indicating whether the operation should return faceIds of
        /// detected faces.
        /// </param>
        /// <param name='returnFaceLandmarks'>
        /// A value indicating whether the operation should return landmarks of
        /// the detected faces.
        /// </param>
        /// <param name='returnFaceAttributes'>
        /// Analyze and return the one or more specified face attributes in the
        /// comma-separated string like "returnFaceAttributes=age,gender".
        /// Supported face attributes include age, gender, headPose, smile,
        /// facialHair, glasses and emotion. Note that each face attribute
        /// analysis has additional computational and time cost.
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
        Task<HttpOperationResponse<IList<DetectedFace>>> DetectWithHttpMessagesAsync(string url, bool? returnFaceId = true, bool? returnFaceLandmarks = false, string returnFaceAttributes = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Detect human faces in an image and returns face locations, and
        /// optionally with faceIds, landmarks, and attributes.
        /// </summary>
        /// <param name='image'>
        /// An image stream.
        /// </param>
        /// <param name='returnFaceId'>
        /// A value indicating whether the operation should return faceIds of
        /// detected faces.
        /// </param>
        /// <param name='returnFaceLandmarks'>
        /// A value indicating whether the operation should return landmarks of
        /// the detected faces.
        /// </param>
        /// <param name='returnFaceAttributes'>
        /// Analyze and return the one or more specified face attributes in the
        /// comma-separated string like "returnFaceAttributes=age,gender".
        /// Supported face attributes include age, gender, headPose, smile,
        /// facialHair, glasses and emotion. Note that each face attribute
        /// analysis has additional computational and time cost.
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
        Task<HttpOperationResponse<IList<DetectedFace>>> DetectInStreamWithHttpMessagesAsync(Stream image, bool? returnFaceId = true, bool? returnFaceLandmarks = false, string returnFaceAttributes = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
