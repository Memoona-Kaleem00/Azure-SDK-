// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Purview.Catalog
{
    /// <summary> The PurviewRelationships service client. </summary>
    public partial class PurviewRelationships
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://purview.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;

        /// <summary> The catalog endpoint of your Purview account. Example: https://{accountName}.purview.azure.com. </summary>
        public Uri Endpoint { get; }

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of PurviewRelationships for mocking. </summary>
        protected PurviewRelationships()
        {
        }

        /// <summary> Initializes a new instance of PurviewRelationships. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="tokenCredential"> The token credential to copy. </param>
        /// <param name="endpoint"> The catalog endpoint of your Purview account. Example: https://{accountName}.purview.azure.com. </param>
        internal PurviewRelationships(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, TokenCredential tokenCredential, Uri endpoint)
        {
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _tokenCredential = tokenCredential;
            Endpoint = endpoint;
        }

        /// <summary> Create a new relationship between entities. </summary>
        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <remarks>
        /// Below is the JSON schema for the request and response payloads.
        /// 
        /// Request Body:
        /// 
        /// Schema for <c>AtlasRelationship</c>:
        /// <code>{
        ///   attributes: Dictionary&lt;string, AnyObject&gt;, # Optional. The attributes of the struct.
        ///   typeName: string, # Optional. The name of the type.
        ///   lastModifiedTS: string, # Optional. ETag for concurrency control.
        ///   createTime: number, # Optional. The created time of the record.
        ///   createdBy: string, # Optional. The user who created the record.
        ///   end1: {
        ///     guid: string, # Optional. The GUID of the object.
        ///     typeName: string, # Optional. The name of the type.
        ///     uniqueAttributes: Dictionary&lt;string, AnyObject&gt;, # Optional. The unique attributes of the object.
        ///   }, # Optional. Reference to an object-instance of an Atlas type - like entity.
        ///   end2: AtlasObjectId, # Optional. Reference to an object-instance of an Atlas type - like entity.
        ///   guid: string, # Optional. The GUID of the relationship.
        ///   homeId: string, # Optional. The home ID of the relationship.
        ///   label: string, # Optional. The label of the relationship.
        ///   provenanceType: number, # Optional. Used to record the provenance of an instance of an entity or relationship
        ///   status: &quot;ACTIVE&quot; | &quot;DELETED&quot;, # Optional. The enum of relationship status.
        ///   updateTime: number, # Optional. The update time of the record.
        ///   updatedBy: string, # Optional. The user who updated the record.
        ///   version: number, # Optional. The version of the relationship.
        /// }
        /// </code>
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>AtlasRelationship</c>:
        /// <code>{
        ///   attributes: Dictionary&lt;string, AnyObject&gt;, # Optional. The attributes of the struct.
        ///   typeName: string, # Optional. The name of the type.
        ///   lastModifiedTS: string, # Optional. ETag for concurrency control.
        ///   createTime: number, # Optional. The created time of the record.
        ///   createdBy: string, # Optional. The user who created the record.
        ///   end1: {
        ///     guid: string, # Optional. The GUID of the object.
        ///     typeName: string, # Optional. The name of the type.
        ///     uniqueAttributes: Dictionary&lt;string, AnyObject&gt;, # Optional. The unique attributes of the object.
        ///   }, # Optional. Reference to an object-instance of an Atlas type - like entity.
        ///   end2: AtlasObjectId, # Optional. Reference to an object-instance of an Atlas type - like entity.
        ///   guid: string, # Optional. The GUID of the relationship.
        ///   homeId: string, # Optional. The home ID of the relationship.
        ///   label: string, # Optional. The label of the relationship.
        ///   provenanceType: number, # Optional. Used to record the provenance of an instance of an entity or relationship
        ///   status: &quot;ACTIVE&quot; | &quot;DELETED&quot;, # Optional. The enum of relationship status.
        ///   updateTime: number, # Optional. The update time of the record.
        ///   updatedBy: string, # Optional. The user who updated the record.
        ///   version: number, # Optional. The version of the relationship.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> CreateAsync(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PurviewRelationships.Create");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create a new relationship between entities. </summary>
        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <remarks>
        /// Below is the JSON schema for the request and response payloads.
        /// 
        /// Request Body:
        /// 
        /// Schema for <c>AtlasRelationship</c>:
        /// <code>{
        ///   attributes: Dictionary&lt;string, AnyObject&gt;, # Optional. The attributes of the struct.
        ///   typeName: string, # Optional. The name of the type.
        ///   lastModifiedTS: string, # Optional. ETag for concurrency control.
        ///   createTime: number, # Optional. The created time of the record.
        ///   createdBy: string, # Optional. The user who created the record.
        ///   end1: {
        ///     guid: string, # Optional. The GUID of the object.
        ///     typeName: string, # Optional. The name of the type.
        ///     uniqueAttributes: Dictionary&lt;string, AnyObject&gt;, # Optional. The unique attributes of the object.
        ///   }, # Optional. Reference to an object-instance of an Atlas type - like entity.
        ///   end2: AtlasObjectId, # Optional. Reference to an object-instance of an Atlas type - like entity.
        ///   guid: string, # Optional. The GUID of the relationship.
        ///   homeId: string, # Optional. The home ID of the relationship.
        ///   label: string, # Optional. The label of the relationship.
        ///   provenanceType: number, # Optional. Used to record the provenance of an instance of an entity or relationship
        ///   status: &quot;ACTIVE&quot; | &quot;DELETED&quot;, # Optional. The enum of relationship status.
        ///   updateTime: number, # Optional. The update time of the record.
        ///   updatedBy: string, # Optional. The user who updated the record.
        ///   version: number, # Optional. The version of the relationship.
        /// }
        /// </code>
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>AtlasRelationship</c>:
        /// <code>{
        ///   attributes: Dictionary&lt;string, AnyObject&gt;, # Optional. The attributes of the struct.
        ///   typeName: string, # Optional. The name of the type.
        ///   lastModifiedTS: string, # Optional. ETag for concurrency control.
        ///   createTime: number, # Optional. The created time of the record.
        ///   createdBy: string, # Optional. The user who created the record.
        ///   end1: {
        ///     guid: string, # Optional. The GUID of the object.
        ///     typeName: string, # Optional. The name of the type.
        ///     uniqueAttributes: Dictionary&lt;string, AnyObject&gt;, # Optional. The unique attributes of the object.
        ///   }, # Optional. Reference to an object-instance of an Atlas type - like entity.
        ///   end2: AtlasObjectId, # Optional. Reference to an object-instance of an Atlas type - like entity.
        ///   guid: string, # Optional. The GUID of the relationship.
        ///   homeId: string, # Optional. The home ID of the relationship.
        ///   label: string, # Optional. The label of the relationship.
        ///   provenanceType: number, # Optional. Used to record the provenance of an instance of an entity or relationship
        ///   status: &quot;ACTIVE&quot; | &quot;DELETED&quot;, # Optional. The enum of relationship status.
        ///   updateTime: number, # Optional. The update time of the record.
        ///   updatedBy: string, # Optional. The user who updated the record.
        ///   version: number, # Optional. The version of the relationship.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response Create(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PurviewRelationships.Create");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update an existing relationship between entities. </summary>
        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <remarks>
        /// Below is the JSON schema for the request and response payloads.
        /// 
        /// Request Body:
        /// 
        /// Schema for <c>AtlasRelationship</c>:
        /// <code>{
        ///   attributes: Dictionary&lt;string, AnyObject&gt;, # Optional. The attributes of the struct.
        ///   typeName: string, # Optional. The name of the type.
        ///   lastModifiedTS: string, # Optional. ETag for concurrency control.
        ///   createTime: number, # Optional. The created time of the record.
        ///   createdBy: string, # Optional. The user who created the record.
        ///   end1: {
        ///     guid: string, # Optional. The GUID of the object.
        ///     typeName: string, # Optional. The name of the type.
        ///     uniqueAttributes: Dictionary&lt;string, AnyObject&gt;, # Optional. The unique attributes of the object.
        ///   }, # Optional. Reference to an object-instance of an Atlas type - like entity.
        ///   end2: AtlasObjectId, # Optional. Reference to an object-instance of an Atlas type - like entity.
        ///   guid: string, # Optional. The GUID of the relationship.
        ///   homeId: string, # Optional. The home ID of the relationship.
        ///   label: string, # Optional. The label of the relationship.
        ///   provenanceType: number, # Optional. Used to record the provenance of an instance of an entity or relationship
        ///   status: &quot;ACTIVE&quot; | &quot;DELETED&quot;, # Optional. The enum of relationship status.
        ///   updateTime: number, # Optional. The update time of the record.
        ///   updatedBy: string, # Optional. The user who updated the record.
        ///   version: number, # Optional. The version of the relationship.
        /// }
        /// </code>
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>AtlasRelationship</c>:
        /// <code>{
        ///   attributes: Dictionary&lt;string, AnyObject&gt;, # Optional. The attributes of the struct.
        ///   typeName: string, # Optional. The name of the type.
        ///   lastModifiedTS: string, # Optional. ETag for concurrency control.
        ///   createTime: number, # Optional. The created time of the record.
        ///   createdBy: string, # Optional. The user who created the record.
        ///   end1: {
        ///     guid: string, # Optional. The GUID of the object.
        ///     typeName: string, # Optional. The name of the type.
        ///     uniqueAttributes: Dictionary&lt;string, AnyObject&gt;, # Optional. The unique attributes of the object.
        ///   }, # Optional. Reference to an object-instance of an Atlas type - like entity.
        ///   end2: AtlasObjectId, # Optional. Reference to an object-instance of an Atlas type - like entity.
        ///   guid: string, # Optional. The GUID of the relationship.
        ///   homeId: string, # Optional. The home ID of the relationship.
        ///   label: string, # Optional. The label of the relationship.
        ///   provenanceType: number, # Optional. Used to record the provenance of an instance of an entity or relationship
        ///   status: &quot;ACTIVE&quot; | &quot;DELETED&quot;, # Optional. The enum of relationship status.
        ///   updateTime: number, # Optional. The update time of the record.
        ///   updatedBy: string, # Optional. The user who updated the record.
        ///   version: number, # Optional. The version of the relationship.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> UpdateAsync(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PurviewRelationships.Update");
            scope.Start();
            try
            {
                using HttpMessage message = CreateUpdateRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update an existing relationship between entities. </summary>
        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <remarks>
        /// Below is the JSON schema for the request and response payloads.
        /// 
        /// Request Body:
        /// 
        /// Schema for <c>AtlasRelationship</c>:
        /// <code>{
        ///   attributes: Dictionary&lt;string, AnyObject&gt;, # Optional. The attributes of the struct.
        ///   typeName: string, # Optional. The name of the type.
        ///   lastModifiedTS: string, # Optional. ETag for concurrency control.
        ///   createTime: number, # Optional. The created time of the record.
        ///   createdBy: string, # Optional. The user who created the record.
        ///   end1: {
        ///     guid: string, # Optional. The GUID of the object.
        ///     typeName: string, # Optional. The name of the type.
        ///     uniqueAttributes: Dictionary&lt;string, AnyObject&gt;, # Optional. The unique attributes of the object.
        ///   }, # Optional. Reference to an object-instance of an Atlas type - like entity.
        ///   end2: AtlasObjectId, # Optional. Reference to an object-instance of an Atlas type - like entity.
        ///   guid: string, # Optional. The GUID of the relationship.
        ///   homeId: string, # Optional. The home ID of the relationship.
        ///   label: string, # Optional. The label of the relationship.
        ///   provenanceType: number, # Optional. Used to record the provenance of an instance of an entity or relationship
        ///   status: &quot;ACTIVE&quot; | &quot;DELETED&quot;, # Optional. The enum of relationship status.
        ///   updateTime: number, # Optional. The update time of the record.
        ///   updatedBy: string, # Optional. The user who updated the record.
        ///   version: number, # Optional. The version of the relationship.
        /// }
        /// </code>
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>AtlasRelationship</c>:
        /// <code>{
        ///   attributes: Dictionary&lt;string, AnyObject&gt;, # Optional. The attributes of the struct.
        ///   typeName: string, # Optional. The name of the type.
        ///   lastModifiedTS: string, # Optional. ETag for concurrency control.
        ///   createTime: number, # Optional. The created time of the record.
        ///   createdBy: string, # Optional. The user who created the record.
        ///   end1: {
        ///     guid: string, # Optional. The GUID of the object.
        ///     typeName: string, # Optional. The name of the type.
        ///     uniqueAttributes: Dictionary&lt;string, AnyObject&gt;, # Optional. The unique attributes of the object.
        ///   }, # Optional. Reference to an object-instance of an Atlas type - like entity.
        ///   end2: AtlasObjectId, # Optional. Reference to an object-instance of an Atlas type - like entity.
        ///   guid: string, # Optional. The GUID of the relationship.
        ///   homeId: string, # Optional. The home ID of the relationship.
        ///   label: string, # Optional. The label of the relationship.
        ///   provenanceType: number, # Optional. Used to record the provenance of an instance of an entity or relationship
        ///   status: &quot;ACTIVE&quot; | &quot;DELETED&quot;, # Optional. The enum of relationship status.
        ///   updateTime: number, # Optional. The update time of the record.
        ///   updatedBy: string, # Optional. The user who updated the record.
        ///   version: number, # Optional. The version of the relationship.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response Update(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PurviewRelationships.Update");
            scope.Start();
            try
            {
                using HttpMessage message = CreateUpdateRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get relationship information between entities by its GUID. </summary>
        /// <param name="guid"> The globally unique identifier of the relationship. </param>
        /// <param name="extendedInfo"> Limits whether includes extended information. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="guid"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="guid"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <remarks>
        /// Below is the JSON schema for the response payload.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>AtlasRelationshipWithExtInfo</c>:
        /// <code>{
        ///   referredEntities: Dictionary&lt;string, AtlasEntityHeader&gt;, # Optional. The referred entity header.
        ///   relationship: {
        ///     attributes: Dictionary&lt;string, AnyObject&gt;, # Optional. The attributes of the struct.
        ///     typeName: string, # Optional. The name of the type.
        ///     lastModifiedTS: string, # Optional. ETag for concurrency control.
        ///     createTime: number, # Optional. The created time of the record.
        ///     createdBy: string, # Optional. The user who created the record.
        ///     end1: {
        ///       guid: string, # Optional. The GUID of the object.
        ///       typeName: string, # Optional. The name of the type.
        ///       uniqueAttributes: Dictionary&lt;string, AnyObject&gt;, # Optional. The unique attributes of the object.
        ///     }, # Optional. Reference to an object-instance of an Atlas type - like entity.
        ///     end2: AtlasObjectId, # Optional. Reference to an object-instance of an Atlas type - like entity.
        ///     guid: string, # Optional. The GUID of the relationship.
        ///     homeId: string, # Optional. The home ID of the relationship.
        ///     label: string, # Optional. The label of the relationship.
        ///     provenanceType: number, # Optional. Used to record the provenance of an instance of an entity or relationship
        ///     status: &quot;ACTIVE&quot; | &quot;DELETED&quot;, # Optional. The enum of relationship status.
        ///     updateTime: number, # Optional. The update time of the record.
        ///     updatedBy: string, # Optional. The user who updated the record.
        ///     version: number, # Optional. The version of the relationship.
        ///   }, # Optional. Atlas relationship instance.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> GetPurviewRelationshipAsync(string guid, bool? extendedInfo = null, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(guid, nameof(guid));

            using var scope = ClientDiagnostics.CreateScope("PurviewRelationships.GetPurviewRelationship");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetPurviewRelationshipRequest(guid, extendedInfo, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get relationship information between entities by its GUID. </summary>
        /// <param name="guid"> The globally unique identifier of the relationship. </param>
        /// <param name="extendedInfo"> Limits whether includes extended information. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="guid"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="guid"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <remarks>
        /// Below is the JSON schema for the response payload.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>AtlasRelationshipWithExtInfo</c>:
        /// <code>{
        ///   referredEntities: Dictionary&lt;string, AtlasEntityHeader&gt;, # Optional. The referred entity header.
        ///   relationship: {
        ///     attributes: Dictionary&lt;string, AnyObject&gt;, # Optional. The attributes of the struct.
        ///     typeName: string, # Optional. The name of the type.
        ///     lastModifiedTS: string, # Optional. ETag for concurrency control.
        ///     createTime: number, # Optional. The created time of the record.
        ///     createdBy: string, # Optional. The user who created the record.
        ///     end1: {
        ///       guid: string, # Optional. The GUID of the object.
        ///       typeName: string, # Optional. The name of the type.
        ///       uniqueAttributes: Dictionary&lt;string, AnyObject&gt;, # Optional. The unique attributes of the object.
        ///     }, # Optional. Reference to an object-instance of an Atlas type - like entity.
        ///     end2: AtlasObjectId, # Optional. Reference to an object-instance of an Atlas type - like entity.
        ///     guid: string, # Optional. The GUID of the relationship.
        ///     homeId: string, # Optional. The home ID of the relationship.
        ///     label: string, # Optional. The label of the relationship.
        ///     provenanceType: number, # Optional. Used to record the provenance of an instance of an entity or relationship
        ///     status: &quot;ACTIVE&quot; | &quot;DELETED&quot;, # Optional. The enum of relationship status.
        ///     updateTime: number, # Optional. The update time of the record.
        ///     updatedBy: string, # Optional. The user who updated the record.
        ///     version: number, # Optional. The version of the relationship.
        ///   }, # Optional. Atlas relationship instance.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response GetPurviewRelationship(string guid, bool? extendedInfo = null, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(guid, nameof(guid));

            using var scope = ClientDiagnostics.CreateScope("PurviewRelationships.GetPurviewRelationship");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetPurviewRelationshipRequest(guid, extendedInfo, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete a relationship between entities by its GUID. </summary>
        /// <param name="guid"> The globally unique identifier of the relationship. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="guid"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="guid"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<Response> DeleteAsync(string guid, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(guid, nameof(guid));

            using var scope = ClientDiagnostics.CreateScope("PurviewRelationships.Delete");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteRequest(guid, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete a relationship between entities by its GUID. </summary>
        /// <param name="guid"> The globally unique identifier of the relationship. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="guid"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="guid"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual Response Delete(string guid, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(guid, nameof(guid));

            using var scope = ClientDiagnostics.CreateScope("PurviewRelationships.Delete");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteRequest(guid, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateCreateRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(Endpoint);
            uri.AppendRaw("/catalog/api", false);
            uri.AppendPath("/atlas/v2/relationship", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateUpdateRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(Endpoint);
            uri.AppendRaw("/catalog/api", false);
            uri.AppendPath("/atlas/v2/relationship", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateGetPurviewRelationshipRequest(string guid, bool? extendedInfo, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(Endpoint);
            uri.AppendRaw("/catalog/api", false);
            uri.AppendPath("/atlas/v2/relationship/guid/", false);
            uri.AppendPath(guid, true);
            if (extendedInfo != null)
            {
                uri.AppendQuery("extendedInfo", extendedInfo.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateDeleteRequest(string guid, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(Endpoint);
            uri.AppendRaw("/catalog/api", false);
            uri.AppendPath("/atlas/v2/relationship/guid/", false);
            uri.AppendPath(guid, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
        private static ResponseClassifier _responseClassifier204;
        private static ResponseClassifier ResponseClassifier204 => _responseClassifier204 ??= new StatusCodeClassifier(stackalloc ushort[] { 204 });
    }
}
