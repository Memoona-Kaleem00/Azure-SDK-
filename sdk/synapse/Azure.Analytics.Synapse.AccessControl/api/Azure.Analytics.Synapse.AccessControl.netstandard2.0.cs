namespace Azure.Analytics.Synapse.AccessControl
{
    public partial class AccessControlClientOptions : Azure.Core.ClientOptions
    {
        public AccessControlClientOptions(Azure.Analytics.Synapse.AccessControl.AccessControlClientOptions.ServiceVersion version = Azure.Analytics.Synapse.AccessControl.AccessControlClientOptions.ServiceVersion.V2020_12_01) { }
        public enum ServiceVersion
        {
            V2020_12_01 = 1,
        }
    }
    public partial class RoleAssignmentsClient
    {
        protected RoleAssignmentsClient() { }
        public RoleAssignmentsClient(System.Uri endpoint, Azure.Core.TokenCredential credential) { }
        public RoleAssignmentsClient(System.Uri endpoint, Azure.Core.TokenCredential credential, Azure.Analytics.Synapse.AccessControl.AccessControlClientOptions options) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response CheckPrincipalAccess(Azure.Core.RequestContent content, Azure.Core.ContentType contentType, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CheckPrincipalAccessAsync(Azure.Core.RequestContent content, Azure.Core.ContentType contentType, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response CreateRoleAssignment(string roleAssignmentId, Azure.Core.RequestContent content, Azure.Core.ContentType contentType, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateRoleAssignmentAsync(string roleAssignmentId, Azure.Core.RequestContent content, Azure.Core.ContentType contentType, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response DeleteRoleAssignmentById(string roleAssignmentId, string scope = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteRoleAssignmentByIdAsync(string roleAssignmentId, string scope = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetRoleAssignmentById(string roleAssignmentId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetRoleAssignmentByIdAsync(string roleAssignmentId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetRoleAssignments(string roleId = null, string principalId = null, string scope = null, string continuationToken = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetRoleAssignmentsAsync(string roleId = null, string principalId = null, string scope = null, string continuationToken = null, Azure.RequestContext context = null) { throw null; }
    }
    public partial class RoleDefinitionsClient
    {
        protected RoleDefinitionsClient() { }
        public RoleDefinitionsClient(System.Uri endpoint, Azure.Core.TokenCredential credential) { }
        public RoleDefinitionsClient(System.Uri endpoint, Azure.Core.TokenCredential credential, Azure.Analytics.Synapse.AccessControl.AccessControlClientOptions options) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response GetRoleDefinitionById(string roleDefinitionId, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetRoleDefinitionByIdAsync(string roleDefinitionId, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetRoleDefinitions(bool? isBuiltIn = default(bool?), string scope = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetRoleDefinitionsAsync(bool? isBuiltIn = default(bool?), string scope = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response GetScopes(Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetScopesAsync(Azure.RequestContext context = null) { throw null; }
    }
}
