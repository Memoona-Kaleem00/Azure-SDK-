// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Support.Models;

namespace Azure.ResourceManager.Support
{
    /// <summary>
    /// A Class representing a SupportTicketNoSubFile along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SupportTicketNoSubFileResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSupportTicketNoSubFileResource method.
    /// Otherwise you can get one from its parent resource <see cref="TenantFileWorkspaceResource" /> using the GetSupportTicketNoSubFile method.
    /// </summary>
    public partial class SupportTicketNoSubFileResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SupportTicketNoSubFileResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string fileWorkspaceName, string fileName)
        {
            var resourceId = $"/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}/files/{fileName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _supportTicketNoSubFileFilesNoSubscriptionClientDiagnostics;
        private readonly FilesNoSubscriptionRestOperations _supportTicketNoSubFileFilesNoSubscriptionRestClient;
        private readonly FileDetailData _data;

        /// <summary> Initializes a new instance of the <see cref="SupportTicketNoSubFileResource"/> class for mocking. </summary>
        protected SupportTicketNoSubFileResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SupportTicketNoSubFileResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SupportTicketNoSubFileResource(ArmClient client, FileDetailData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SupportTicketNoSubFileResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SupportTicketNoSubFileResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _supportTicketNoSubFileFilesNoSubscriptionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Support", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string supportTicketNoSubFileFilesNoSubscriptionApiVersion);
            _supportTicketNoSubFileFilesNoSubscriptionRestClient = new FilesNoSubscriptionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, supportTicketNoSubFileFilesNoSubscriptionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Support/fileWorkspaces/files";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual FileDetailData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Returns details of a specific file in a work space.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}/files/{fileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FilesNoSubscription_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SupportTicketNoSubFileResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _supportTicketNoSubFileFilesNoSubscriptionClientDiagnostics.CreateScope("SupportTicketNoSubFileResource.Get");
            scope.Start();
            try
            {
                var response = await _supportTicketNoSubFileFilesNoSubscriptionRestClient.GetAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SupportTicketNoSubFileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns details of a specific file in a work space.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}/files/{fileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FilesNoSubscription_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SupportTicketNoSubFileResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _supportTicketNoSubFileFilesNoSubscriptionClientDiagnostics.CreateScope("SupportTicketNoSubFileResource.Get");
            scope.Start();
            try
            {
                var response = _supportTicketNoSubFileFilesNoSubscriptionRestClient.Get(Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SupportTicketNoSubFileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a new file under a workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}/files/{fileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FilesNoSubscription_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Create file object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SupportTicketNoSubFileResource>> UpdateAsync(WaitUntil waitUntil, FileDetailData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _supportTicketNoSubFileFilesNoSubscriptionClientDiagnostics.CreateScope("SupportTicketNoSubFileResource.Update");
            scope.Start();
            try
            {
                var response = await _supportTicketNoSubFileFilesNoSubscriptionRestClient.CreateAsync(Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SupportArmOperation<SupportTicketNoSubFileResource>(Response.FromValue(new SupportTicketNoSubFileResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a new file under a workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}/files/{fileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FilesNoSubscription_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Create file object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SupportTicketNoSubFileResource> Update(WaitUntil waitUntil, FileDetailData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _supportTicketNoSubFileFilesNoSubscriptionClientDiagnostics.CreateScope("SupportTicketNoSubFileResource.Update");
            scope.Start();
            try
            {
                var response = _supportTicketNoSubFileFilesNoSubscriptionRestClient.Create(Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new SupportArmOperation<SupportTicketNoSubFileResource>(Response.FromValue(new SupportTicketNoSubFileResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This API allows you to upload content to a file
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}/files/{fileName}/upload</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FilesNoSubscription_Upload</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="uploadFile"> UploadFile object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uploadFile"/> is null. </exception>
        public virtual async Task<Response> UploadAsync(UploadFile uploadFile, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(uploadFile, nameof(uploadFile));

            using var scope = _supportTicketNoSubFileFilesNoSubscriptionClientDiagnostics.CreateScope("SupportTicketNoSubFileResource.Upload");
            scope.Start();
            try
            {
                var response = await _supportTicketNoSubFileFilesNoSubscriptionRestClient.UploadAsync(Id.Parent.Name, Id.Name, uploadFile, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This API allows you to upload content to a file
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}/files/{fileName}/upload</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FilesNoSubscription_Upload</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="uploadFile"> UploadFile object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uploadFile"/> is null. </exception>
        public virtual Response Upload(UploadFile uploadFile, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(uploadFile, nameof(uploadFile));

            using var scope = _supportTicketNoSubFileFilesNoSubscriptionClientDiagnostics.CreateScope("SupportTicketNoSubFileResource.Upload");
            scope.Start();
            try
            {
                var response = _supportTicketNoSubFileFilesNoSubscriptionRestClient.Upload(Id.Parent.Name, Id.Name, uploadFile, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
