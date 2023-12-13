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

namespace Azure.ResourceManager.Authorization
{
    /// <summary>
    /// A Class representing a RoleAssignmentSchedule along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="RoleAssignmentScheduleResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetRoleAssignmentScheduleResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource"/> using the GetRoleAssignmentSchedule method.
    /// </summary>
    public partial class RoleAssignmentScheduleResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="RoleAssignmentScheduleResource"/> instance. </summary>
        /// <param name="scope"> The scope. </param>
        /// <param name="roleAssignmentScheduleName"> The roleAssignmentScheduleName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string scope, string roleAssignmentScheduleName)
        {
            var resourceId = $"{scope}/providers/Microsoft.Authorization/roleAssignmentSchedules/{roleAssignmentScheduleName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _roleAssignmentScheduleClientDiagnostics;
        private readonly RoleAssignmentSchedulesRestOperations _roleAssignmentScheduleRestClient;
        private readonly RoleAssignmentScheduleData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Authorization/roleAssignmentSchedules";

        /// <summary> Initializes a new instance of the <see cref="RoleAssignmentScheduleResource"/> class for mocking. </summary>
        protected RoleAssignmentScheduleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RoleAssignmentScheduleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal RoleAssignmentScheduleResource(ArmClient client, RoleAssignmentScheduleData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="RoleAssignmentScheduleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal RoleAssignmentScheduleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _roleAssignmentScheduleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Authorization", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string roleAssignmentScheduleApiVersion);
            _roleAssignmentScheduleRestClient = new RoleAssignmentSchedulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, roleAssignmentScheduleApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual RoleAssignmentScheduleData Data
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
        /// Get the specified role assignment schedule for a resource scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignmentSchedules/{roleAssignmentScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignmentSchedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RoleAssignmentScheduleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _roleAssignmentScheduleClientDiagnostics.CreateScope("RoleAssignmentScheduleResource.Get");
            scope.Start();
            try
            {
                var response = await _roleAssignmentScheduleRestClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleAssignmentScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified role assignment schedule for a resource scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignmentSchedules/{roleAssignmentScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignmentSchedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RoleAssignmentScheduleResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _roleAssignmentScheduleClientDiagnostics.CreateScope("RoleAssignmentScheduleResource.Get");
            scope.Start();
            try
            {
                var response = _roleAssignmentScheduleRestClient.Get(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleAssignmentScheduleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
