// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.DigitalTwins.Core.Serialization;

namespace Azure.DigitalTwins.Core
{
    internal partial class DigitalTwinModelsRestClient
    {
        // The modelUpdates parameter needs to be changed from IEnumerable<object> to IEnumerable<string>
        // and not parsed like a json object.
        public async Task<Response<IReadOnlyList<ModelData>>> AddAsync(IEnumerable<string> models = null, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope("DigitalTwinModelsClient.Add");
            scope.Start();
            try
            {
                using HttpMessage message = CreateAddRequest(models);
                await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                    case 201:
                        {
                            IReadOnlyList<ModelData> value = default;
                            using JsonDocument document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            List<ModelData> array = new List<ModelData>(document.RootElement.GetArrayLength());
                            foreach (JsonElement item in document.RootElement.EnumerateArray())
                            {
                                array.Add(ModelData.DeserializeModelData(item));
                            }
                            value = array;
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        // The modelUpdates parameter needs to be changed from IEnumerable<object> to IEnumerable<string>
        // and not parsed like a json object.
        internal Response<IReadOnlyList<ModelData>> Add(IEnumerable<string> models = null, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope("DigitalTwinModelsClient.Add");
            scope.Start();
            try
            {
                using HttpMessage message = CreateAddRequest(models);
                _pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                    case 201:
                        {
                            IReadOnlyList<ModelData> value = default;
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            List<ModelData> array = new List<ModelData>(document.RootElement.GetArrayLength());
                            foreach (JsonElement item in document.RootElement.EnumerateArray())
                            {
                                array.Add(ModelData.DeserializeModelData(item));
                            }
                            value = array;
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        // The modelUpdates parameter needs to be changed from IEnumerable<object> to IEnumerable<string>
        // and not parsed like a json object.
        internal async Task<Response> UpdateAsync(string id, IEnumerable<string> modelUpdates, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (modelUpdates == null)
            {
                throw new ArgumentNullException(nameof(modelUpdates));
            }

            using DiagnosticScope scope = _clientDiagnostics.CreateScope("DigitalTwinModelsClient.Update");
            scope.Start();
            try
            {
                using HttpMessage message = CreateUpdateRequest(id, modelUpdates);
                await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                return message.Response.Status switch
                {
                    204 => message.Response,
                    _ => throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false),
                };
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // The modelUpdates parameter needs to be changed from IEnumerable<object> to IEnumerable<string>
        // and not parsed like a json object.
        internal Response Update(string id, IEnumerable<string> modelUpdates, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (modelUpdates == null)
            {
                throw new ArgumentNullException(nameof(modelUpdates));
            }

            using DiagnosticScope scope = _clientDiagnostics.CreateScope("DigitalTwinModelsClient.Update");
            scope.Start();
            try
            {
                using HttpMessage message = CreateUpdateRequest(id, modelUpdates);
                _pipeline.Send(message, cancellationToken);
                return message.Response.Status switch
                {
                    204 => message.Response,
                    _ => throw _clientDiagnostics.CreateRequestFailedException(message.Response),
                };
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // The strings are already json, so we do not want them to be serialized.
        // Instead, the payloads need to be concatenated into a json array.
        private HttpMessage CreateAddRequest(IEnumerable<string> models)
        {
            HttpMessage message = _pipeline.CreateMessage();
            Request request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/models", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json; charset=utf-8");
            if (models != null)
            {
                string modelsJsonArray = PayloadHelper.BuildArrayPayload(models);
                request.Content = new StringRequestContent(modelsJsonArray);
            }
            return message;
        }

        // The strings are already json, so we do not want them to be serialized.
        // Instead, the payloads need to be concatenated into a json array.
        internal HttpMessage CreateUpdateRequest(string id, IEnumerable<string> modelUpdates)
        {
            HttpMessage message = _pipeline.CreateMessage();
            Request request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/models/", false);
            uri.AppendPath(id, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json; charset=utf-8");
            if (modelUpdates != null)
            {
                string modelUpdatesArray = PayloadHelper.BuildArrayPayload(modelUpdates);
                request.Content = new StringRequestContent(modelUpdatesArray);
            }
            return message;
        }

        #region null overrides

        // The following methods are only declared so that autorest does not create these functions in the generated code.
        // For methods that we need to override, when the parameter list is the same, autorest knows not to generate them again.
        // When the parameter list changes, autorest generates the methods again.
        // As such, these methods are declared here and made private, while the public method is declared above, too.
        // These methods should never be called.

#pragma warning disable CA1801, IDE0051, IDE0060 // Remove unused parameter

        // Original return type is Task<Response<IReadOnlyList<ModelData>>>. Changing to object to allow returning null.
        private object AddAsync(IEnumerable<object> models = null, CancellationToken cancellationToken = default) => null;

        private Response<IReadOnlyList<ModelData>> Add(IEnumerable<object> models = null, CancellationToken cancellationToken = default) => null;

        // Original return type is ValueTask<Response>. Changing to object to allow returing null.
        private object UpdateAsync(string id, IEnumerable<object> updateModel, CancellationToken cancellationToken = default) => null;

        private Response Update(string id, IEnumerable<object> updateModel, CancellationToken cancellationToken = default) => null;

        private HttpMessage CreateAddRequest(IEnumerable<object> models) => null;

#pragma warning restore CA1801, IDE0051, IDE0060 // Remove unused parameter

        #endregion null overrides
    }
}
