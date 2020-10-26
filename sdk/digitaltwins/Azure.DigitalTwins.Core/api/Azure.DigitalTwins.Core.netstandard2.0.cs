namespace Azure.DigitalTwins.Core
{
    public partial class BasicDigitalTwin
    {
        public BasicDigitalTwin() { }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("$etag")]
        public string ETag { get { throw null; } set { } }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("$dtId")]
        public string Id { get { throw null; } set { } }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("$metadata")]
        public Azure.DigitalTwins.Core.DigitalTwinMetadata Metadata { get { throw null; } set { } }
        [System.Text.Json.Serialization.JsonExtensionDataAttribute]
        public System.Collections.Generic.IDictionary<string, object> Properties { get { throw null; } set { } }
    }
    public partial class BasicRelationship
    {
        public BasicRelationship() { }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("$relationshipId")]
        public string Id { get { throw null; } set { } }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("$relationshipName")]
        public string Name { get { throw null; } set { } }
        [System.Text.Json.Serialization.JsonExtensionDataAttribute]
        public System.Collections.Generic.IDictionary<string, object> Properties { get { throw null; } set { } }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("$sourceId")]
        public string SourceId { get { throw null; } set { } }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("$targetId")]
        public string TargetId { get { throw null; } set { } }
    }
    public partial class CreateModelsOptions
    {
        public CreateModelsOptions() { }
        public string TraceParent { get { throw null; } set { } }
        public string TraceState { get { throw null; } set { } }
    }
    public partial class CreateOrReplaceDigitalTwinOptions
    {
        public CreateOrReplaceDigitalTwinOptions() { }
        public string IfNoneMatch { get { throw null; } set { } }
        public string TraceParent { get { throw null; } set { } }
        public string TraceState { get { throw null; } set { } }
    }
    public partial class CreateOrReplaceEventRouteOptions
    {
        public CreateOrReplaceEventRouteOptions() { }
        public string TraceParent { get { throw null; } set { } }
        public string TraceState { get { throw null; } set { } }
    }
    public partial class CreateOrReplaceRelationshipOptions
    {
        public CreateOrReplaceRelationshipOptions() { }
        public string IfNoneMatch { get { throw null; } set { } }
        public string TraceParent { get { throw null; } set { } }
        public string TraceState { get { throw null; } set { } }
    }
    public partial class DecomissionModelOptions
    {
        public DecomissionModelOptions() { }
        public string TraceParent { get { throw null; } set { } }
        public string TraceState { get { throw null; } set { } }
    }
    public partial class DeleteDigitalTwinOptions
    {
        public DeleteDigitalTwinOptions() { }
        public string IfMatch { get { throw null; } set { } }
        public string TraceParent { get { throw null; } set { } }
        public string TraceState { get { throw null; } set { } }
    }
    public partial class DeleteEventRouteOptions
    {
        public DeleteEventRouteOptions() { }
        public string TraceParent { get { throw null; } set { } }
        public string TraceState { get { throw null; } set { } }
    }
    public partial class DeleteModelOptions
    {
        public DeleteModelOptions() { }
        public string TraceParent { get { throw null; } set { } }
        public string TraceState { get { throw null; } set { } }
    }
    public partial class DeleteRelationshipOptions
    {
        public DeleteRelationshipOptions() { }
        public string IfMatch { get { throw null; } set { } }
        public string TraceParent { get { throw null; } set { } }
        public string TraceState { get { throw null; } set { } }
    }
    public partial class DigitalTwinComponent
    {
        public DigitalTwinComponent() { }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("$metadata")]
        public object Metadata { get { throw null; } set { } }
        [System.Text.Json.Serialization.JsonExtensionDataAttribute]
        public System.Collections.Generic.IDictionary<string, object> Properties { get { throw null; } }
    }
    public partial class DigitalTwinMetadata
    {
        public DigitalTwinMetadata() { }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("$model")]
        public string ModelId { get { throw null; } set { } }
    }
    public partial class DigitalTwinsClient
    {
        protected DigitalTwinsClient() { }
        public DigitalTwinsClient(System.Uri endpoint, Azure.Core.TokenCredential credential) { }
        public DigitalTwinsClient(System.Uri endpoint, Azure.Core.TokenCredential credential, Azure.DigitalTwins.Core.DigitalTwinsClientOptions options) { }
        public virtual Azure.Response<Azure.DigitalTwins.Core.DigitalTwinsModelData[]> CreateModels(System.Collections.Generic.IEnumerable<string> dtdlModels, Azure.DigitalTwins.Core.CreateModelsOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.DigitalTwins.Core.DigitalTwinsModelData[]>> CreateModelsAsync(System.Collections.Generic.IEnumerable<string> dtdlModels, Azure.DigitalTwins.Core.CreateModelsOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<T>> CreateOrReplaceDigitalTwinAsync<T>(string digitalTwinId, T digitalTwin, Azure.DigitalTwins.Core.CreateOrReplaceDigitalTwinOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<T> CreateOrReplaceDigitalTwin<T>(string digitalTwinId, T digitalTwin, Azure.DigitalTwins.Core.CreateOrReplaceDigitalTwinOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response CreateOrReplaceEventRoute(string eventRouteId, Azure.DigitalTwins.Core.DigitalTwinsEventRoute eventRoute, Azure.DigitalTwins.Core.CreateOrReplaceEventRouteOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CreateOrReplaceEventRouteAsync(string eventRouteId, Azure.DigitalTwins.Core.DigitalTwinsEventRoute eventRoute, Azure.DigitalTwins.Core.CreateOrReplaceEventRouteOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<T>> CreateOrReplaceRelationshipAsync<T>(string digitalTwinId, string relationshipId, T relationship, Azure.DigitalTwins.Core.CreateOrReplaceRelationshipOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<T> CreateOrReplaceRelationship<T>(string digitalTwinId, string relationshipId, T relationship, Azure.DigitalTwins.Core.CreateOrReplaceRelationshipOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DecommissionModel(string modelId, Azure.DigitalTwins.Core.DecomissionModelOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DecommissionModelAsync(string modelId, Azure.DigitalTwins.Core.DecomissionModelOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteDigitalTwin(string digitalTwinId, Azure.DigitalTwins.Core.DeleteDigitalTwinOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteDigitalTwinAsync(string digitalTwinId, Azure.DigitalTwins.Core.DeleteDigitalTwinOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteEventRoute(string eventRouteId, Azure.DigitalTwins.Core.DeleteEventRouteOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteEventRouteAsync(string eventRouteId, Azure.DigitalTwins.Core.DeleteEventRouteOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteModel(string modelId, Azure.DigitalTwins.Core.DeleteModelOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteModelAsync(string modelId, Azure.DigitalTwins.Core.DeleteModelOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteRelationship(string digitalTwinId, string relationshipId, Azure.DigitalTwins.Core.DeleteRelationshipOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteRelationshipAsync(string digitalTwinId, string relationshipId, Azure.DigitalTwins.Core.DeleteRelationshipOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<T>> GetComponentAsync<T>(string digitalTwinId, string componentName, Azure.DigitalTwins.Core.GetComponentOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<T> GetComponent<T>(string digitalTwinId, string componentName, Azure.DigitalTwins.Core.GetComponentOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<T>> GetDigitalTwinAsync<T>(string digitalTwinId, Azure.DigitalTwins.Core.GetDigitalTwinOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<T> GetDigitalTwin<T>(string digitalTwinId, Azure.DigitalTwins.Core.GetDigitalTwinOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.DigitalTwins.Core.DigitalTwinsEventRoute> GetEventRoute(string eventRouteId, Azure.DigitalTwins.Core.GetDigitalTwinsEventRouteOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.DigitalTwins.Core.DigitalTwinsEventRoute>> GetEventRouteAsync(string eventRouteId, Azure.DigitalTwins.Core.GetDigitalTwinsEventRouteOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.DigitalTwins.Core.DigitalTwinsEventRoute> GetEventRoutes(Azure.DigitalTwins.Core.GetDigitalTwinsEventRoutesOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.DigitalTwins.Core.DigitalTwinsEventRoute> GetEventRoutesAsync(Azure.DigitalTwins.Core.GetDigitalTwinsEventRoutesOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.DigitalTwins.Core.IncomingRelationship> GetIncomingRelationships(string digitalTwinId, Azure.DigitalTwins.Core.GetIncomingRelationshipsOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.DigitalTwins.Core.IncomingRelationship> GetIncomingRelationshipsAsync(string digitalTwinId, Azure.DigitalTwins.Core.GetIncomingRelationshipsOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.DigitalTwins.Core.DigitalTwinsModelData> GetModel(string modelId, Azure.DigitalTwins.Core.GetModelOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.DigitalTwins.Core.DigitalTwinsModelData>> GetModelAsync(string modelId, Azure.DigitalTwins.Core.GetModelOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.DigitalTwins.Core.DigitalTwinsModelData> GetModels(Azure.DigitalTwins.Core.GetModelsOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.DigitalTwins.Core.DigitalTwinsModelData> GetModelsAsync(Azure.DigitalTwins.Core.GetModelsOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<T>> GetRelationshipAsync<T>(string digitalTwinId, string relationshipId, Azure.DigitalTwins.Core.GetRelationshipOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<string> GetRelationships(string digitalTwinId, string relationshipName = null, Azure.DigitalTwins.Core.GetRelationshipsOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<string> GetRelationshipsAsync(string digitalTwinId, string relationshipName = null, Azure.DigitalTwins.Core.GetRelationshipsOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<T> GetRelationship<T>(string digitalTwinId, string relationshipId, Azure.DigitalTwins.Core.GetRelationshipOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response PublishComponentTelemetry(string digitalTwinId, string componentName, string messageId, string payload, Azure.DigitalTwins.Core.PublishComponentTelemetryOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> PublishComponentTelemetryAsync(string digitalTwinId, string componentName, string messageId, string payload, Azure.DigitalTwins.Core.PublishComponentTelemetryOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response PublishTelemetry(string digitalTwinId, string messageId, string payload, Azure.DigitalTwins.Core.PublishTelemetryOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> PublishTelemetryAsync(string digitalTwinId, string messageId, string payload, Azure.DigitalTwins.Core.PublishTelemetryOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<string> Query(string query, Azure.DigitalTwins.Core.QueryOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<string> QueryAsync(string query, Azure.DigitalTwins.Core.QueryOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response UpdateComponent(string digitalTwinId, string componentName, Azure.JsonPatchDocument jsonPatchDocument, Azure.DigitalTwins.Core.UpdateComponentOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateComponentAsync(string digitalTwinId, string componentName, Azure.JsonPatchDocument jsonPatchDocument, Azure.DigitalTwins.Core.UpdateComponentOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response UpdateDigitalTwin(string digitalTwinId, Azure.JsonPatchDocument jsonPatchDocument, Azure.DigitalTwins.Core.UpdateDigitalTwinOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateDigitalTwinAsync(string digitalTwinId, Azure.JsonPatchDocument jsonPatchDocument, Azure.DigitalTwins.Core.UpdateDigitalTwinOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response UpdateRelationship(string digitalTwinId, string relationshipId, Azure.JsonPatchDocument jsonPatchDocument, Azure.DigitalTwins.Core.UpdateRelationshipOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateRelationshipAsync(string digitalTwinId, string relationshipId, Azure.JsonPatchDocument jsonPatchDocument, Azure.DigitalTwins.Core.UpdateRelationshipOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class DigitalTwinsClientOptions : Azure.Core.ClientOptions
    {
        public DigitalTwinsClientOptions(Azure.DigitalTwins.Core.DigitalTwinsClientOptions.ServiceVersion version = Azure.DigitalTwins.Core.DigitalTwinsClientOptions.ServiceVersion.V2020_10_31) { }
        public Azure.Core.Serialization.ObjectSerializer Serializer { get { throw null; } set { } }
        public Azure.DigitalTwins.Core.DigitalTwinsClientOptions.ServiceVersion Version { get { throw null; } }
        public enum ServiceVersion
        {
            V2020_10_31 = 1,
        }
    }
    public partial class DigitalTwinsEventRoute
    {
        public DigitalTwinsEventRoute(string endpointName, string filter) { }
        public string EndpointName { get { throw null; } set { } }
        public string Filter { get { throw null; } set { } }
        public string Id { get { throw null; } }
    }
    public static partial class DigitalTwinsJsonPropertyNames
    {
        public const string DigitalTwinETag = "$etag";
        public const string DigitalTwinId = "$dtId";
        public const string DigitalTwinMetadata = "$metadata";
        public const string MetadataModel = "$model";
        public const string RelationshipId = "$relationshipId";
        public const string RelationshipName = "$relationshipName";
        public const string RelationshipSourceId = "$sourceId";
        public const string RelationshipTargetId = "$targetId";
    }
    public partial class DigitalTwinsModelData
    {
        internal DigitalTwinsModelData() { }
        public bool? Decommissioned { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, string> Description { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, string> DisplayName { get { throw null; } }
        public string DtdlModel { get { throw null; } }
        public string Id { get { throw null; } }
        public System.DateTimeOffset? UploadedOn { get { throw null; } }
    }
    public partial class GetComponentOptions
    {
        public GetComponentOptions() { }
        public string TraceParent { get { throw null; } set { } }
        public string TraceState { get { throw null; } set { } }
    }
    public partial class GetDigitalTwinOptions
    {
        public GetDigitalTwinOptions() { }
        public string TraceParent { get { throw null; } set { } }
        public string TraceState { get { throw null; } set { } }
    }
    public partial class GetDigitalTwinsEventRouteOptions
    {
        public GetDigitalTwinsEventRouteOptions() { }
        public string TraceParent { get { throw null; } set { } }
        public string TraceState { get { throw null; } set { } }
    }
    public partial class GetDigitalTwinsEventRoutesOptions
    {
        public GetDigitalTwinsEventRoutesOptions() { }
        public int? MaxItemsPerPage { get { throw null; } set { } }
        public string TraceParent { get { throw null; } set { } }
        public string TraceState { get { throw null; } set { } }
    }
    public partial class GetIncomingRelationshipsOptions
    {
        public GetIncomingRelationshipsOptions() { }
        public string TraceParent { get { throw null; } set { } }
        public string TraceState { get { throw null; } set { } }
    }
    public partial class GetModelOptions
    {
        public GetModelOptions() { }
        public string TraceParent { get { throw null; } set { } }
        public string TraceState { get { throw null; } set { } }
    }
    public partial class GetModelsOptions
    {
        public GetModelsOptions() { }
        public System.Collections.Generic.IEnumerable<string> DependenciesFor { get { throw null; } set { } }
        public bool IncludeModelDefinition { get { throw null; } set { } }
        public string TraceParent { get { throw null; } set { } }
        public string TraceState { get { throw null; } set { } }
    }
    public partial class GetRelationshipOptions
    {
        public GetRelationshipOptions() { }
        public string TraceParent { get { throw null; } set { } }
        public string TraceState { get { throw null; } set { } }
    }
    public partial class GetRelationshipsOptions
    {
        public GetRelationshipsOptions() { }
        public string TraceParent { get { throw null; } set { } }
        public string TraceState { get { throw null; } set { } }
    }
    public partial class IncomingRelationship
    {
        internal IncomingRelationship() { }
        public string RelationshipId { get { throw null; } }
        public string RelationshipLink { get { throw null; } }
        public string RelationshipName { get { throw null; } }
        public string SourceId { get { throw null; } }
    }
    public partial class PublishComponentTelemetryOptions
    {
        public PublishComponentTelemetryOptions() { }
        public System.DateTimeOffset TimeStamp { get { throw null; } set { } }
        public string TraceParent { get { throw null; } set { } }
        public string TraceState { get { throw null; } set { } }
    }
    public partial class PublishTelemetryOptions
    {
        public PublishTelemetryOptions() { }
        public System.DateTimeOffset TimeStamp { get { throw null; } set { } }
        public string TraceParent { get { throw null; } set { } }
        public string TraceState { get { throw null; } set { } }
    }
    public static partial class QueryChargeHelper
    {
        public static bool TryGetQueryCharge(Azure.Page<string> page, out float queryCharge) { throw null; }
    }
    public partial class QueryOptions
    {
        public QueryOptions() { }
        public string TraceParent { get { throw null; } set { } }
        public string TraceState { get { throw null; } set { } }
    }
    public partial class UpdateComponentOptions
    {
        public UpdateComponentOptions() { }
        public string IfMatch { get { throw null; } set { } }
        public string TraceParent { get { throw null; } set { } }
        public string TraceState { get { throw null; } set { } }
    }
    public partial class UpdateDigitalTwinOptions
    {
        public UpdateDigitalTwinOptions() { }
        public string IfMatch { get { throw null; } set { } }
        public string TraceParent { get { throw null; } set { } }
        public string TraceState { get { throw null; } set { } }
    }
    public partial class UpdateRelationshipOptions
    {
        public UpdateRelationshipOptions() { }
        public string IfMatch { get { throw null; } set { } }
        public string TraceParent { get { throw null; } set { } }
        public string TraceState { get { throw null; } set { } }
    }
}
