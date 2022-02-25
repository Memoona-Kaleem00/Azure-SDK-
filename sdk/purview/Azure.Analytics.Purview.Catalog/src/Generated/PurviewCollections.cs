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
    /// <summary> The PurviewCollections service client. </summary>
    public partial class PurviewCollections
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://purview.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of PurviewCollections for mocking. </summary>
        protected PurviewCollections()
        {
        }

        /// <summary>
        /// Creates or updates an entity to a collection.
        /// Existing entity is matched using its unique guid if supplied or by its unique attributes eg: qualifiedName.
        /// Map and array of collections are not well supported. E.g., array&lt;array&lt;int&gt;&gt;, array&lt;map&lt;string, int&gt;&gt;.
        /// </summary>
        /// <param name="collection"> the collection unique name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="collection"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="collection"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   referredEntities: Dictionary&lt;string, AtlasEntity&gt;,
        ///   entity: {
        ///     attributes: Dictionary&lt;string, AnyObject&gt;,
        ///     typeName: string,
        ///     lastModifiedTS: string,
        ///     classifications: [
        ///       {
        ///         attributes: Dictionary&lt;string, AnyObject&gt;,
        ///         typeName: string,
        ///         lastModifiedTS: string,
        ///         entityGuid: string,
        ///         entityStatus: &quot;ACTIVE&quot; | &quot;DELETED&quot;,
        ///         removePropagationsOnEntityDelete: boolean,
        ///         validityPeriods: [
        ///           {
        ///             endTime: string,
        ///             startTime: string,
        ///             timeZone: string
        ///           }
        ///         ],
        ///         source: string,
        ///         sourceDetails: Dictionary&lt;string, AnyObject&gt;
        ///       }
        ///     ],
        ///     createTime: number,
        ///     createdBy: string,
        ///     guid: string,
        ///     homeId: string,
        ///     meanings: [
        ///       {
        ///         confidence: number,
        ///         createdBy: string,
        ///         description: string,
        ///         displayText: string,
        ///         expression: string,
        ///         relationGuid: string,
        ///         source: string,
        ///         status: &quot;DISCOVERED&quot; | &quot;PROPOSED&quot; | &quot;IMPORTED&quot; | &quot;VALIDATED&quot; | &quot;DEPRECATED&quot; | &quot;OBSOLETE&quot; | &quot;OTHER&quot;,
        ///         steward: string,
        ///         termGuid: string
        ///       }
        ///     ],
        ///     provenanceType: number,
        ///     proxy: boolean,
        ///     relationshipAttributes: Dictionary&lt;string, AnyObject&gt;,
        ///     status: &quot;ACTIVE&quot; | &quot;DELETED&quot;,
        ///     updateTime: number,
        ///     updatedBy: string,
        ///     version: number,
        ///     source: string,
        ///     sourceDetails: Dictionary&lt;string, AnyObject&gt;,
        ///     contacts: Dictionary&lt;string, ContactBasic[]&gt;
        ///   }
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   guidAssignments: Dictionary&lt;string, string&gt;,
        ///   mutatedEntities: Dictionary&lt;string, AtlasEntityHeader[]&gt;,
        ///   partialUpdatedEntities: [
        ///     {
        ///       attributes: Dictionary&lt;string, AnyObject&gt;,
        ///       typeName: string,
        ///       lastModifiedTS: string,
        ///       classificationNames: [string],
        ///       classifications: [
        ///         {
        ///           attributes: Dictionary&lt;string, AnyObject&gt;,
        ///           typeName: string,
        ///           lastModifiedTS: string,
        ///           entityGuid: string,
        ///           entityStatus: &quot;ACTIVE&quot; | &quot;DELETED&quot;,
        ///           removePropagationsOnEntityDelete: boolean,
        ///           validityPeriods: [
        ///             {
        ///               endTime: string,
        ///               startTime: string,
        ///               timeZone: string
        ///             }
        ///           ],
        ///           source: string,
        ///           sourceDetails: Dictionary&lt;string, AnyObject&gt;
        ///         }
        ///       ],
        ///       displayText: string,
        ///       guid: string,
        ///       meaningNames: [string],
        ///       meanings: [
        ///         {
        ///           confidence: number,
        ///           createdBy: string,
        ///           description: string,
        ///           displayText: string,
        ///           expression: string,
        ///           relationGuid: string,
        ///           source: string,
        ///           status: &quot;DISCOVERED&quot; | &quot;PROPOSED&quot; | &quot;IMPORTED&quot; | &quot;VALIDATED&quot; | &quot;DEPRECATED&quot; | &quot;OBSOLETE&quot; | &quot;OTHER&quot;,
        ///           steward: string,
        ///           termGuid: string
        ///         }
        ///       ],
        ///       status: &quot;ACTIVE&quot; | &quot;DELETED&quot;
        ///     }
        ///   ]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   requestId: string,
        ///   errorCode: string,
        ///   errorMessage: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> CreateOrUpdateEntityAsync(string collection, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(collection, nameof(collection));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PurviewCollections.CreateOrUpdateEntity");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateEntityRequest(collection, content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates an entity to a collection.
        /// Existing entity is matched using its unique guid if supplied or by its unique attributes eg: qualifiedName.
        /// Map and array of collections are not well supported. E.g., array&lt;array&lt;int&gt;&gt;, array&lt;map&lt;string, int&gt;&gt;.
        /// </summary>
        /// <param name="collection"> the collection unique name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="collection"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="collection"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   referredEntities: Dictionary&lt;string, AtlasEntity&gt;,
        ///   entity: {
        ///     attributes: Dictionary&lt;string, AnyObject&gt;,
        ///     typeName: string,
        ///     lastModifiedTS: string,
        ///     classifications: [
        ///       {
        ///         attributes: Dictionary&lt;string, AnyObject&gt;,
        ///         typeName: string,
        ///         lastModifiedTS: string,
        ///         entityGuid: string,
        ///         entityStatus: &quot;ACTIVE&quot; | &quot;DELETED&quot;,
        ///         removePropagationsOnEntityDelete: boolean,
        ///         validityPeriods: [
        ///           {
        ///             endTime: string,
        ///             startTime: string,
        ///             timeZone: string
        ///           }
        ///         ],
        ///         source: string,
        ///         sourceDetails: Dictionary&lt;string, AnyObject&gt;
        ///       }
        ///     ],
        ///     createTime: number,
        ///     createdBy: string,
        ///     guid: string,
        ///     homeId: string,
        ///     meanings: [
        ///       {
        ///         confidence: number,
        ///         createdBy: string,
        ///         description: string,
        ///         displayText: string,
        ///         expression: string,
        ///         relationGuid: string,
        ///         source: string,
        ///         status: &quot;DISCOVERED&quot; | &quot;PROPOSED&quot; | &quot;IMPORTED&quot; | &quot;VALIDATED&quot; | &quot;DEPRECATED&quot; | &quot;OBSOLETE&quot; | &quot;OTHER&quot;,
        ///         steward: string,
        ///         termGuid: string
        ///       }
        ///     ],
        ///     provenanceType: number,
        ///     proxy: boolean,
        ///     relationshipAttributes: Dictionary&lt;string, AnyObject&gt;,
        ///     status: &quot;ACTIVE&quot; | &quot;DELETED&quot;,
        ///     updateTime: number,
        ///     updatedBy: string,
        ///     version: number,
        ///     source: string,
        ///     sourceDetails: Dictionary&lt;string, AnyObject&gt;,
        ///     contacts: Dictionary&lt;string, ContactBasic[]&gt;
        ///   }
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   guidAssignments: Dictionary&lt;string, string&gt;,
        ///   mutatedEntities: Dictionary&lt;string, AtlasEntityHeader[]&gt;,
        ///   partialUpdatedEntities: [
        ///     {
        ///       attributes: Dictionary&lt;string, AnyObject&gt;,
        ///       typeName: string,
        ///       lastModifiedTS: string,
        ///       classificationNames: [string],
        ///       classifications: [
        ///         {
        ///           attributes: Dictionary&lt;string, AnyObject&gt;,
        ///           typeName: string,
        ///           lastModifiedTS: string,
        ///           entityGuid: string,
        ///           entityStatus: &quot;ACTIVE&quot; | &quot;DELETED&quot;,
        ///           removePropagationsOnEntityDelete: boolean,
        ///           validityPeriods: [
        ///             {
        ///               endTime: string,
        ///               startTime: string,
        ///               timeZone: string
        ///             }
        ///           ],
        ///           source: string,
        ///           sourceDetails: Dictionary&lt;string, AnyObject&gt;
        ///         }
        ///       ],
        ///       displayText: string,
        ///       guid: string,
        ///       meaningNames: [string],
        ///       meanings: [
        ///         {
        ///           confidence: number,
        ///           createdBy: string,
        ///           description: string,
        ///           displayText: string,
        ///           expression: string,
        ///           relationGuid: string,
        ///           source: string,
        ///           status: &quot;DISCOVERED&quot; | &quot;PROPOSED&quot; | &quot;IMPORTED&quot; | &quot;VALIDATED&quot; | &quot;DEPRECATED&quot; | &quot;OBSOLETE&quot; | &quot;OTHER&quot;,
        ///           steward: string,
        ///           termGuid: string
        ///         }
        ///       ],
        ///       status: &quot;ACTIVE&quot; | &quot;DELETED&quot;
        ///     }
        ///   ]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   requestId: string,
        ///   errorCode: string,
        ///   errorMessage: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response CreateOrUpdateEntity(string collection, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(collection, nameof(collection));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PurviewCollections.CreateOrUpdateEntity");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateEntityRequest(collection, content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates entities in bulk to a collection.
        /// Existing entity is matched using its unique guid if supplied or by its unique attributes eg: qualifiedName.
        /// Map and array of collections are not well supported. E.g., array&lt;array&lt;int&gt;&gt;, array&lt;map&lt;string, int&gt;&gt;.
        /// </summary>
        /// <param name="collection"> the collection unique name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="collection"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="collection"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   referredEntities: Dictionary&lt;string, AtlasEntity&gt;,
        ///   entities: [
        ///     {
        ///       attributes: Dictionary&lt;string, AnyObject&gt;,
        ///       typeName: string,
        ///       lastModifiedTS: string,
        ///       classifications: [
        ///         {
        ///           attributes: Dictionary&lt;string, AnyObject&gt;,
        ///           typeName: string,
        ///           lastModifiedTS: string,
        ///           entityGuid: string,
        ///           entityStatus: &quot;ACTIVE&quot; | &quot;DELETED&quot;,
        ///           removePropagationsOnEntityDelete: boolean,
        ///           validityPeriods: [
        ///             {
        ///               endTime: string,
        ///               startTime: string,
        ///               timeZone: string
        ///             }
        ///           ],
        ///           source: string,
        ///           sourceDetails: Dictionary&lt;string, AnyObject&gt;
        ///         }
        ///       ],
        ///       createTime: number,
        ///       createdBy: string,
        ///       guid: string,
        ///       homeId: string,
        ///       meanings: [
        ///         {
        ///           confidence: number,
        ///           createdBy: string,
        ///           description: string,
        ///           displayText: string,
        ///           expression: string,
        ///           relationGuid: string,
        ///           source: string,
        ///           status: &quot;DISCOVERED&quot; | &quot;PROPOSED&quot; | &quot;IMPORTED&quot; | &quot;VALIDATED&quot; | &quot;DEPRECATED&quot; | &quot;OBSOLETE&quot; | &quot;OTHER&quot;,
        ///           steward: string,
        ///           termGuid: string
        ///         }
        ///       ],
        ///       provenanceType: number,
        ///       proxy: boolean,
        ///       relationshipAttributes: Dictionary&lt;string, AnyObject&gt;,
        ///       status: &quot;ACTIVE&quot; | &quot;DELETED&quot;,
        ///       updateTime: number,
        ///       updatedBy: string,
        ///       version: number,
        ///       source: string,
        ///       sourceDetails: Dictionary&lt;string, AnyObject&gt;,
        ///       contacts: Dictionary&lt;string, ContactBasic[]&gt;
        ///     }
        ///   ]
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   guidAssignments: Dictionary&lt;string, string&gt;,
        ///   mutatedEntities: Dictionary&lt;string, AtlasEntityHeader[]&gt;,
        ///   partialUpdatedEntities: [
        ///     {
        ///       attributes: Dictionary&lt;string, AnyObject&gt;,
        ///       typeName: string,
        ///       lastModifiedTS: string,
        ///       classificationNames: [string],
        ///       classifications: [
        ///         {
        ///           attributes: Dictionary&lt;string, AnyObject&gt;,
        ///           typeName: string,
        ///           lastModifiedTS: string,
        ///           entityGuid: string,
        ///           entityStatus: &quot;ACTIVE&quot; | &quot;DELETED&quot;,
        ///           removePropagationsOnEntityDelete: boolean,
        ///           validityPeriods: [
        ///             {
        ///               endTime: string,
        ///               startTime: string,
        ///               timeZone: string
        ///             }
        ///           ],
        ///           source: string,
        ///           sourceDetails: Dictionary&lt;string, AnyObject&gt;
        ///         }
        ///       ],
        ///       displayText: string,
        ///       guid: string,
        ///       meaningNames: [string],
        ///       meanings: [
        ///         {
        ///           confidence: number,
        ///           createdBy: string,
        ///           description: string,
        ///           displayText: string,
        ///           expression: string,
        ///           relationGuid: string,
        ///           source: string,
        ///           status: &quot;DISCOVERED&quot; | &quot;PROPOSED&quot; | &quot;IMPORTED&quot; | &quot;VALIDATED&quot; | &quot;DEPRECATED&quot; | &quot;OBSOLETE&quot; | &quot;OTHER&quot;,
        ///           steward: string,
        ///           termGuid: string
        ///         }
        ///       ],
        ///       status: &quot;ACTIVE&quot; | &quot;DELETED&quot;
        ///     }
        ///   ]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   requestId: string,
        ///   errorCode: string,
        ///   errorMessage: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> CreateOrUpdateEntityInBulkAsync(string collection, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(collection, nameof(collection));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PurviewCollections.CreateOrUpdateEntityInBulk");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateEntityInBulkRequest(collection, content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates entities in bulk to a collection.
        /// Existing entity is matched using its unique guid if supplied or by its unique attributes eg: qualifiedName.
        /// Map and array of collections are not well supported. E.g., array&lt;array&lt;int&gt;&gt;, array&lt;map&lt;string, int&gt;&gt;.
        /// </summary>
        /// <param name="collection"> the collection unique name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="collection"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="collection"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   referredEntities: Dictionary&lt;string, AtlasEntity&gt;,
        ///   entities: [
        ///     {
        ///       attributes: Dictionary&lt;string, AnyObject&gt;,
        ///       typeName: string,
        ///       lastModifiedTS: string,
        ///       classifications: [
        ///         {
        ///           attributes: Dictionary&lt;string, AnyObject&gt;,
        ///           typeName: string,
        ///           lastModifiedTS: string,
        ///           entityGuid: string,
        ///           entityStatus: &quot;ACTIVE&quot; | &quot;DELETED&quot;,
        ///           removePropagationsOnEntityDelete: boolean,
        ///           validityPeriods: [
        ///             {
        ///               endTime: string,
        ///               startTime: string,
        ///               timeZone: string
        ///             }
        ///           ],
        ///           source: string,
        ///           sourceDetails: Dictionary&lt;string, AnyObject&gt;
        ///         }
        ///       ],
        ///       createTime: number,
        ///       createdBy: string,
        ///       guid: string,
        ///       homeId: string,
        ///       meanings: [
        ///         {
        ///           confidence: number,
        ///           createdBy: string,
        ///           description: string,
        ///           displayText: string,
        ///           expression: string,
        ///           relationGuid: string,
        ///           source: string,
        ///           status: &quot;DISCOVERED&quot; | &quot;PROPOSED&quot; | &quot;IMPORTED&quot; | &quot;VALIDATED&quot; | &quot;DEPRECATED&quot; | &quot;OBSOLETE&quot; | &quot;OTHER&quot;,
        ///           steward: string,
        ///           termGuid: string
        ///         }
        ///       ],
        ///       provenanceType: number,
        ///       proxy: boolean,
        ///       relationshipAttributes: Dictionary&lt;string, AnyObject&gt;,
        ///       status: &quot;ACTIVE&quot; | &quot;DELETED&quot;,
        ///       updateTime: number,
        ///       updatedBy: string,
        ///       version: number,
        ///       source: string,
        ///       sourceDetails: Dictionary&lt;string, AnyObject&gt;,
        ///       contacts: Dictionary&lt;string, ContactBasic[]&gt;
        ///     }
        ///   ]
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   guidAssignments: Dictionary&lt;string, string&gt;,
        ///   mutatedEntities: Dictionary&lt;string, AtlasEntityHeader[]&gt;,
        ///   partialUpdatedEntities: [
        ///     {
        ///       attributes: Dictionary&lt;string, AnyObject&gt;,
        ///       typeName: string,
        ///       lastModifiedTS: string,
        ///       classificationNames: [string],
        ///       classifications: [
        ///         {
        ///           attributes: Dictionary&lt;string, AnyObject&gt;,
        ///           typeName: string,
        ///           lastModifiedTS: string,
        ///           entityGuid: string,
        ///           entityStatus: &quot;ACTIVE&quot; | &quot;DELETED&quot;,
        ///           removePropagationsOnEntityDelete: boolean,
        ///           validityPeriods: [
        ///             {
        ///               endTime: string,
        ///               startTime: string,
        ///               timeZone: string
        ///             }
        ///           ],
        ///           source: string,
        ///           sourceDetails: Dictionary&lt;string, AnyObject&gt;
        ///         }
        ///       ],
        ///       displayText: string,
        ///       guid: string,
        ///       meaningNames: [string],
        ///       meanings: [
        ///         {
        ///           confidence: number,
        ///           createdBy: string,
        ///           description: string,
        ///           displayText: string,
        ///           expression: string,
        ///           relationGuid: string,
        ///           source: string,
        ///           status: &quot;DISCOVERED&quot; | &quot;PROPOSED&quot; | &quot;IMPORTED&quot; | &quot;VALIDATED&quot; | &quot;DEPRECATED&quot; | &quot;OBSOLETE&quot; | &quot;OTHER&quot;,
        ///           steward: string,
        ///           termGuid: string
        ///         }
        ///       ],
        ///       status: &quot;ACTIVE&quot; | &quot;DELETED&quot;
        ///     }
        ///   ]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   requestId: string,
        ///   errorCode: string,
        ///   errorMessage: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response CreateOrUpdateEntityInBulk(string collection, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(collection, nameof(collection));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PurviewCollections.CreateOrUpdateEntityInBulk");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateEntityInBulkRequest(collection, content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Move existing entities to the target collection. </summary>
        /// <param name="collection"> the collection unique name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="collection"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="collection"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   entityGuids: [string]
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   guidAssignments: Dictionary&lt;string, string&gt;,
        ///   mutatedEntities: Dictionary&lt;string, AtlasEntityHeader[]&gt;,
        ///   partialUpdatedEntities: [
        ///     {
        ///       attributes: Dictionary&lt;string, AnyObject&gt;,
        ///       typeName: string,
        ///       lastModifiedTS: string,
        ///       classificationNames: [string],
        ///       classifications: [
        ///         {
        ///           attributes: Dictionary&lt;string, AnyObject&gt;,
        ///           typeName: string,
        ///           lastModifiedTS: string,
        ///           entityGuid: string,
        ///           entityStatus: &quot;ACTIVE&quot; | &quot;DELETED&quot;,
        ///           removePropagationsOnEntityDelete: boolean,
        ///           validityPeriods: [
        ///             {
        ///               endTime: string,
        ///               startTime: string,
        ///               timeZone: string
        ///             }
        ///           ],
        ///           source: string,
        ///           sourceDetails: Dictionary&lt;string, AnyObject&gt;
        ///         }
        ///       ],
        ///       displayText: string,
        ///       guid: string,
        ///       meaningNames: [string],
        ///       meanings: [
        ///         {
        ///           confidence: number,
        ///           createdBy: string,
        ///           description: string,
        ///           displayText: string,
        ///           expression: string,
        ///           relationGuid: string,
        ///           source: string,
        ///           status: &quot;DISCOVERED&quot; | &quot;PROPOSED&quot; | &quot;IMPORTED&quot; | &quot;VALIDATED&quot; | &quot;DEPRECATED&quot; | &quot;OBSOLETE&quot; | &quot;OTHER&quot;,
        ///           steward: string,
        ///           termGuid: string
        ///         }
        ///       ],
        ///       status: &quot;ACTIVE&quot; | &quot;DELETED&quot;
        ///     }
        ///   ]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   requestId: string,
        ///   errorCode: string,
        ///   errorMessage: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> MoveEntitiesToCollectionAsync(string collection, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(collection, nameof(collection));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PurviewCollections.MoveEntitiesToCollection");
            scope.Start();
            try
            {
                using HttpMessage message = CreateMoveEntitiesToCollectionRequest(collection, content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Move existing entities to the target collection. </summary>
        /// <param name="collection"> the collection unique name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="collection"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="collection"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   entityGuids: [string]
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   guidAssignments: Dictionary&lt;string, string&gt;,
        ///   mutatedEntities: Dictionary&lt;string, AtlasEntityHeader[]&gt;,
        ///   partialUpdatedEntities: [
        ///     {
        ///       attributes: Dictionary&lt;string, AnyObject&gt;,
        ///       typeName: string,
        ///       lastModifiedTS: string,
        ///       classificationNames: [string],
        ///       classifications: [
        ///         {
        ///           attributes: Dictionary&lt;string, AnyObject&gt;,
        ///           typeName: string,
        ///           lastModifiedTS: string,
        ///           entityGuid: string,
        ///           entityStatus: &quot;ACTIVE&quot; | &quot;DELETED&quot;,
        ///           removePropagationsOnEntityDelete: boolean,
        ///           validityPeriods: [
        ///             {
        ///               endTime: string,
        ///               startTime: string,
        ///               timeZone: string
        ///             }
        ///           ],
        ///           source: string,
        ///           sourceDetails: Dictionary&lt;string, AnyObject&gt;
        ///         }
        ///       ],
        ///       displayText: string,
        ///       guid: string,
        ///       meaningNames: [string],
        ///       meanings: [
        ///         {
        ///           confidence: number,
        ///           createdBy: string,
        ///           description: string,
        ///           displayText: string,
        ///           expression: string,
        ///           relationGuid: string,
        ///           source: string,
        ///           status: &quot;DISCOVERED&quot; | &quot;PROPOSED&quot; | &quot;IMPORTED&quot; | &quot;VALIDATED&quot; | &quot;DEPRECATED&quot; | &quot;OBSOLETE&quot; | &quot;OTHER&quot;,
        ///           steward: string,
        ///           termGuid: string
        ///         }
        ///       ],
        ///       status: &quot;ACTIVE&quot; | &quot;DELETED&quot;
        ///     }
        ///   ]
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   requestId: string,
        ///   errorCode: string,
        ///   errorMessage: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response MoveEntitiesToCollection(string collection, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(collection, nameof(collection));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("PurviewCollections.MoveEntitiesToCollection");
            scope.Start();
            try
            {
                using HttpMessage message = CreateMoveEntitiesToCollectionRequest(collection, content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateCreateOrUpdateEntityRequest(string collection, RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/catalog/api", false);
            uri.AppendPath("/collections/", false);
            uri.AppendPath(collection, true);
            uri.AppendPath("/entity", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateCreateOrUpdateEntityInBulkRequest(string collection, RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/catalog/api", false);
            uri.AppendPath("/collections/", false);
            uri.AppendPath(collection, true);
            uri.AppendPath("/entity/bulk", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateMoveEntitiesToCollectionRequest(string collection, RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/catalog/api", false);
            uri.AppendPath("/collections/", false);
            uri.AppendPath(collection, true);
            uri.AppendPath("/entity/moveHere", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        private sealed class ResponseClassifier200 : ResponseClassifier
        {
            private static ResponseClassifier _instance;
            public static ResponseClassifier Instance => _instance ??= new ResponseClassifier200();
            public override bool IsErrorResponse(HttpMessage message)
            {
                return message.Response.Status switch
                {
                    200 => false,
                    _ => true
                };
            }
        }
    }
}
