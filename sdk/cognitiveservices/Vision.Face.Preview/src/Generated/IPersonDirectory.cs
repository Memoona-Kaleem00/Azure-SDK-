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
    /// PersonDirectory operations.
    /// </summary>
    public partial interface IPersonDirectory
    {
        /// <summary>
        /// Retrieve list of person information in person directory.
        /// </summary>
        /// <param name='start'>
        /// </param>
        /// <param name='top'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<EnrollmentResponse>>> GetPersonsWithHttpMessagesAsync(string start = default(string), string top = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a new person in person directory.
        /// </summary>
        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<PersonCreationResponse,PersonDirectoryCreatePersonHeaders>> CreatePersonWithHttpMessagesAsync(EnrolledPerson body, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update name or userData of a person.
        /// </summary>
        /// <param name='personId'>
        /// </param>
        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> UpdatePersonWithHttpMessagesAsync(string personId, EnrollmentRequest body, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete an existing person from person directory.
        /// The persistedFaceId, userData, person name and face feature(s) in
        /// the person entry will all be deleted.
        /// </summary>
        /// <param name='personId'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationHeaderResponse<PersonDirectoryDeletePersonHeaders>> DeletePersonWithHttpMessagesAsync(string personId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieve a person's name and userData, and the persisted faceIds
        /// representing the registered person face feature(s).
        /// </summary>
        /// <param name='personId'>
        /// Person id.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<EnrolledPerson>> GetPersonWithHttpMessagesAsync(string personId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Add a new face to person.
        /// </summary>
        /// <param name='personId'>
        /// Person id.
        /// </param>
        /// <param name='recognitionModel'>
        /// Recognition model string.
        /// </param>
        /// <param name='detectionModel'>
        /// Detection model string.
        /// </param>
        /// <param name='userData'>
        /// User data of person face.
        /// </param>
        /// <param name='targetFace'>
        /// Target face.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<EnrollmentPrintResponse,PersonDirectoryAddPersonFaceHeaders>> AddPersonFaceWithHttpMessagesAsync(string personId, string recognitionModel, string detectionModel = default(string), string userData = default(string), string targetFace = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieve person face information. The persisted person face is
        /// specified by its personId and persistedFaceId.
        /// </summary>
        /// <param name='personId'>
        /// Target person to get persistedFaceIds from.
        /// </param>
        /// <param name='recognitionModel'>
        /// The 'recognitionModel' associated with this persisted face.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<PersonResponse>> GetPersonFacesWithHttpMessagesAsync(string personId, string recognitionModel, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete an existing person face from person directory.
        /// The persistedFaceId, userData, and face feature in the person entry
        /// will all be deleted.
        /// </summary>
        /// <param name='personId'>
        /// Person id.
        /// </param>
        /// <param name='recognitionModel'>
        /// Recognition model string.
        /// </param>
        /// <param name='persistedFaceId'>
        /// Persisted face id to delete.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationHeaderResponse<PersonDirectoryDeletePersonFaceHeaders>> DeletePersonFaceWithHttpMessagesAsync(string personId, string recognitionModel, string persistedFaceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieve person face information. The persisted person face is
        /// specified by its personId and persistedFaceId.
        /// </summary>
        /// <param name='personId'>
        /// Target person to get face from.
        /// </param>
        /// <param name='recognitionModel'>
        /// The 'recognitionModel' associated with this persisted face.
        /// </param>
        /// <param name='persistedFaceId'>
        /// Target person face id to get.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<PersistedFaceResponse>> GetPersonFaceWithHttpMessagesAsync(string personId, string recognitionModel, string persistedFaceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update the data of a person face.
        /// </summary>
        /// <param name='personId'>
        /// Target person to update face from.
        /// </param>
        /// <param name='recognitionModel'>
        /// The 'recognitionModel' associated with this persisted face.
        /// </param>
        /// <param name='persistedFaceId'>
        /// PersistedFaceId created from Person Face Create
        /// </param>
        /// <param name='body'>
        /// Target person face id to update.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> UpdatePersonFaceWithHttpMessagesAsync(string personId, string recognitionModel, string persistedFaceId, PersistedFaceWithType body, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a new dynamic person group with specified
        /// dynamicPersonGroupId, name, and user-provided userData.
        /// A dynamic person group is a container that references persons.
        /// After creation, use "DynamicPersonGroup - Update" to add/remove
        /// persons into the search space.
        /// DynamicPersonGroup and UserData will be stored on server until
        /// DynamicPersonGroup Delete is called.
        /// </summary>
        /// <param name='dynamicPersonGroupId'>
        /// User provided dynamic person group Id. Valid format should be a
        /// string composed by numbers, English letters in lower case, '-',
        /// '_', and no longer than 64 characters.
        /// </param>
        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationHeaderResponse<PersonDirectoryCreateDynamicPersonGroupHeaders>> CreateDynamicPersonGroupWithHttpMessagesAsync(string dynamicPersonGroupId, DynamicPersonGroupCreateRequest body, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates an existing dynamic person group with specified
        /// dynamicPersonGroupId, name, and user-provided userData.
        /// </summary>
        /// <param name='dynamicPersonGroupId'>
        /// User provided dynamic person group Id.
        /// </param>
        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationHeaderResponse<PersonDirectoryUpdateDynamicPersonGroupHeaders>> UpdateDynamicPersonGroupWithHttpMessagesAsync(string dynamicPersonGroupId, DynamicPersonGroupUpdateRequest body, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get metadata on a dynamic person group.
        /// </summary>
        /// <param name='dynamicPersonGroupId'>
        /// User provided dynamic person group id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<DynamicPersonGroupGetResponse>> GetDynamicPersonGroupWithHttpMessagesAsync(string dynamicPersonGroupId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete an existing dynamic person group.
        /// Note that Persons are not deleted with this operation. To delete
        /// person call Person Delete.
        /// </summary>
        /// <param name='dynamicPersonGroupId'>
        /// User provided dynamic person group Id.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationHeaderResponse<PersonDirectoryDeleteDynamicPersonGroupHeaders>> DeleteDynamicPersonGroupWithHttpMessagesAsync(string dynamicPersonGroupId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieve list of persons referenced in a given DynamicPersonGroup
        /// person directory.
        /// </summary>
        /// <param name='dynamicPersonGroupId'>
        /// Dynamic person group Id to list persons from
        /// </param>
        /// <param name='start'>
        /// List persons from the least personId greater than the "start". It
        /// contains no more than 64 characters. Default is empty.
        /// </param>
        /// <param name='top'>
        /// The number of persons to list, ranging in [1, 1000]. Default is
        /// 1000.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<DynamicPersonGroupListPersonsResponse>> ListDynamicPersonGroupPersonsWithHttpMessagesAsync(string dynamicPersonGroupId, string start = default(string), string top = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieve list of dynamic person groups in person directory.
        /// </summary>
        /// <param name='start'>
        /// List dynamicPersonGroupId from the least dynamicPersonGroupId
        /// greater than the "start". It contains no more than 64 characters.
        /// Default is empty.
        /// </param>
        /// <param name='top'>
        /// The number of dynamicPersonGroups to list, ranging in [1, 1000].
        /// Default is 1000.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<DynamicPersonGroupGetResponse>>> ListDynamicPersonGroupsWithHttpMessagesAsync(string start = default(string), string top = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List the dynamic person groups that a person has been referenced
        /// in.
        /// </summary>
        /// <param name='personId'>
        /// Valid PersonId created from Person Create.
        /// </param>
        /// <param name='start'>
        /// List dynamic person group id from the least dynamicPersonGroupId
        /// greater than the "start". It contains no more than 64 characters.
        /// Default is empty.
        /// </param>
        /// <param name='top'>
        /// The number of dynamicPersonGroupId to list, ranging in [1, 1000].
        /// Default is 1000.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<PersonDynamicPersonGroupReferenceResponse>> ListDynamicPersonGroupPersonReferencesWithHttpMessagesAsync(string personId, string start = default(string), string top = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Add a new face to person.
        /// </summary>
        /// <param name='personId'>
        /// Person id.
        /// </param>
        /// <param name='recognitionModel'>
        /// Recognition model string.
        /// </param>
        /// <param name='image'>
        /// An image stream.
        /// </param>
        /// <param name='detectionModel'>
        /// Detection model string.
        /// </param>
        /// <param name='userData'>
        /// User data of person face.
        /// </param>
        /// <param name='targetFace'>
        /// Target face.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<EnrollmentPrintResponse,PersonDirectoryAddPersonFaceFromStreamHeaders>> AddPersonFaceFromStreamWithHttpMessagesAsync(string personId, string recognitionModel, Stream image, string detectionModel = default(string), string userData = default(string), string targetFace = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
