// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.FormRecognizer
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extracts information from forms and images into structured data based
    /// on a model created by a set of representative training forms.
    /// </summary>
    public partial interface IFormRecognizerClient : System.IDisposable
    {
        string Endpoint { get; set; }

        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Gets the IFormRecognizerOperations.
        /// </summary>
        IFormRecognizerOperations FormRecognizer { get; }

        /// <summary>
        /// Train a model to analyze using a set of documents of supported
        /// types.
        /// </summary>
        /// <remarks>
        /// The train request must include a 'Source' parameter that is
        /// either a Azure Storage Blob Container SAS Uri or a path to a
        /// locally mounted
        /// drive. When local paths are specified, they must always follow the
        /// Linux/Unix style
        /// absolute path convention and be rooted to the {Mounts:Input}
        /// configuration setting value.
        /// </remarks>
        /// <param name='trainRequest'>
        /// Request object for training.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<TrainResponse>> FormrecognizerV10CustomTrainPostWithHttpMessagesAsync(TrainRequest trainRequest = default(TrainRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get keys of a model.
        /// </summary>
        /// <remarks>
        /// &lt;para&gt;Use the API to retrieve the keys that were
        /// extracted by the specified model.&lt;/para&gt;
        /// </remarks>
        /// <param name='id'>
        /// Model identifier.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> FormrecognizerV10CustomModelByIdKeysGetWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get information about a model.
        /// </summary>
        /// <param name='id'>
        /// Model identifier.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> FormrecognizerV10CustomModelByIdGetWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete a model and all associated pre-processing data.
        /// </summary>
        /// <param name='id'>
        /// The identifier of the model to delete.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> FormrecognizerV10CustomModelByIdDeleteWithHttpMessagesAsync(string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Analyze a document to extract key-value pairs and table
        /// information.
        /// </summary>
        /// <remarks>
        /// &lt;para&gt;The document to analyze must be must be of expected
        /// media type - currently supported types are application/pdf,
        /// image/jpg or image/png.&lt;/para&gt;
        /// </remarks>
        /// <param name='id'>
        /// Identifier of the model to analyze the document with.
        /// </param>
        /// <param name='keys'>
        /// An optional list of known keys to extract the values for.
        /// </param>
        /// <param name='form'>
        /// Upload image or pdf content for processing.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<AnalyzeResponse>> FormrecognizerV10CustomModelByIdAnalyzePostWithHttpMessagesAsync(string id, IList<string> keys = default(IList<string>), Stream form = default(Stream), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ContainerStatus>> StatusGetWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
