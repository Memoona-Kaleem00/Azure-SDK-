// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    internal partial class VirtualMachineImagesEdgeZoneRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of VirtualMachineImagesEdgeZoneRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public VirtualMachineImagesEdgeZoneRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-09-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, AzureLocation location, string edgeZone, string publisherName, string offer, string skus, string version)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Compute/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/edgeZones/", false);
            uri.AppendPath(edgeZone, true);
            uri.AppendPath("/publishers/", false);
            uri.AppendPath(publisherName, true);
            uri.AppendPath("/artifacttypes/vmimage/offers/", false);
            uri.AppendPath(offer, true);
            uri.AppendPath("/skus/", false);
            uri.AppendPath(skus, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(version, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a virtual machine image in an edge zone. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="edgeZone"> The name of the edge zone. </param>
        /// <param name="publisherName"> A valid image publisher. </param>
        /// <param name="offer"> A valid image publisher offer. </param>
        /// <param name="skus"> A valid image SKU. </param>
        /// <param name="version"> A valid image SKU version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="edgeZone"/>, <paramref name="publisherName"/>, <paramref name="offer"/>, <paramref name="skus"/> or <paramref name="version"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="edgeZone"/>, <paramref name="publisherName"/>, <paramref name="offer"/>, <paramref name="skus"/> or <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<VirtualMachineImage>> GetAsync(string subscriptionId, AzureLocation location, string edgeZone, string publisherName, string offer, string skus, string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(edgeZone, nameof(edgeZone));
            Argument.AssertNotNullOrEmpty(publisherName, nameof(publisherName));
            Argument.AssertNotNullOrEmpty(offer, nameof(offer));
            Argument.AssertNotNullOrEmpty(skus, nameof(skus));
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var message = CreateGetRequest(subscriptionId, location, edgeZone, publisherName, offer, skus, version);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualMachineImage value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = VirtualMachineImage.DeserializeVirtualMachineImage(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a virtual machine image in an edge zone. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="edgeZone"> The name of the edge zone. </param>
        /// <param name="publisherName"> A valid image publisher. </param>
        /// <param name="offer"> A valid image publisher offer. </param>
        /// <param name="skus"> A valid image SKU. </param>
        /// <param name="version"> A valid image SKU version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="edgeZone"/>, <paramref name="publisherName"/>, <paramref name="offer"/>, <paramref name="skus"/> or <paramref name="version"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="edgeZone"/>, <paramref name="publisherName"/>, <paramref name="offer"/>, <paramref name="skus"/> or <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<VirtualMachineImage> Get(string subscriptionId, AzureLocation location, string edgeZone, string publisherName, string offer, string skus, string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(edgeZone, nameof(edgeZone));
            Argument.AssertNotNullOrEmpty(publisherName, nameof(publisherName));
            Argument.AssertNotNullOrEmpty(offer, nameof(offer));
            Argument.AssertNotNullOrEmpty(skus, nameof(skus));
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var message = CreateGetRequest(subscriptionId, location, edgeZone, publisherName, offer, skus, version);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualMachineImage value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = VirtualMachineImage.DeserializeVirtualMachineImage(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string subscriptionId, AzureLocation location, string edgeZone, string publisherName, string offer, string skus, string expand, int? top, string orderby)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Compute/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/edgeZones/", false);
            uri.AppendPath(edgeZone, true);
            uri.AppendPath("/publishers/", false);
            uri.AppendPath(publisherName, true);
            uri.AppendPath("/artifacttypes/vmimage/offers/", false);
            uri.AppendPath(offer, true);
            uri.AppendPath("/skus/", false);
            uri.AppendPath(skus, true);
            uri.AppendPath("/versions", false);
            if (expand != null)
            {
                uri.AppendQuery("$expand", expand, true);
            }
            if (top != null)
            {
                uri.AppendQuery("$top", top.Value, true);
            }
            if (orderby != null)
            {
                uri.AppendQuery("$orderby", orderby, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a list of all virtual machine image versions for the specified location, edge zone, publisher, offer, and SKU. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="edgeZone"> The name of the edge zone. </param>
        /// <param name="publisherName"> A valid image publisher. </param>
        /// <param name="offer"> A valid image publisher offer. </param>
        /// <param name="skus"> A valid image SKU. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="top"> An integer value specifying the number of images to return that matches supplied values. </param>
        /// <param name="orderby"> Specifies the order of the results returned. Formatted as an OData query. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="edgeZone"/>, <paramref name="publisherName"/>, <paramref name="offer"/> or <paramref name="skus"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="edgeZone"/>, <paramref name="publisherName"/>, <paramref name="offer"/> or <paramref name="skus"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<IReadOnlyList<VirtualMachineImageBase>>> ListAsync(string subscriptionId, AzureLocation location, string edgeZone, string publisherName, string offer, string skus, string expand = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(edgeZone, nameof(edgeZone));
            Argument.AssertNotNullOrEmpty(publisherName, nameof(publisherName));
            Argument.AssertNotNullOrEmpty(offer, nameof(offer));
            Argument.AssertNotNullOrEmpty(skus, nameof(skus));

            using var message = CreateListRequest(subscriptionId, location, edgeZone, publisherName, offer, skus, expand, top, orderby);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<VirtualMachineImageBase> value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        List<VirtualMachineImageBase> array = new List<VirtualMachineImageBase>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(VirtualMachineImageBase.DeserializeVirtualMachineImageBase(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a list of all virtual machine image versions for the specified location, edge zone, publisher, offer, and SKU. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="edgeZone"> The name of the edge zone. </param>
        /// <param name="publisherName"> A valid image publisher. </param>
        /// <param name="offer"> A valid image publisher offer. </param>
        /// <param name="skus"> A valid image SKU. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="top"> An integer value specifying the number of images to return that matches supplied values. </param>
        /// <param name="orderby"> Specifies the order of the results returned. Formatted as an OData query. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="edgeZone"/>, <paramref name="publisherName"/>, <paramref name="offer"/> or <paramref name="skus"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="edgeZone"/>, <paramref name="publisherName"/>, <paramref name="offer"/> or <paramref name="skus"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<IReadOnlyList<VirtualMachineImageBase>> List(string subscriptionId, AzureLocation location, string edgeZone, string publisherName, string offer, string skus, string expand = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(edgeZone, nameof(edgeZone));
            Argument.AssertNotNullOrEmpty(publisherName, nameof(publisherName));
            Argument.AssertNotNullOrEmpty(offer, nameof(offer));
            Argument.AssertNotNullOrEmpty(skus, nameof(skus));

            using var message = CreateListRequest(subscriptionId, location, edgeZone, publisherName, offer, skus, expand, top, orderby);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<VirtualMachineImageBase> value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        List<VirtualMachineImageBase> array = new List<VirtualMachineImageBase>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(VirtualMachineImageBase.DeserializeVirtualMachineImageBase(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListOffersRequest(string subscriptionId, AzureLocation location, string edgeZone, string publisherName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Compute/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/edgeZones/", false);
            uri.AppendPath(edgeZone, true);
            uri.AppendPath("/publishers/", false);
            uri.AppendPath(publisherName, true);
            uri.AppendPath("/artifacttypes/vmimage/offers", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a list of virtual machine image offers for the specified location, edge zone and publisher. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="edgeZone"> The name of the edge zone. </param>
        /// <param name="publisherName"> A valid image publisher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="edgeZone"/> or <paramref name="publisherName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="edgeZone"/> or <paramref name="publisherName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<IReadOnlyList<VirtualMachineImageBase>>> ListOffersAsync(string subscriptionId, AzureLocation location, string edgeZone, string publisherName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(edgeZone, nameof(edgeZone));
            Argument.AssertNotNullOrEmpty(publisherName, nameof(publisherName));

            using var message = CreateListOffersRequest(subscriptionId, location, edgeZone, publisherName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<VirtualMachineImageBase> value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        List<VirtualMachineImageBase> array = new List<VirtualMachineImageBase>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(VirtualMachineImageBase.DeserializeVirtualMachineImageBase(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a list of virtual machine image offers for the specified location, edge zone and publisher. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="edgeZone"> The name of the edge zone. </param>
        /// <param name="publisherName"> A valid image publisher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="edgeZone"/> or <paramref name="publisherName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="edgeZone"/> or <paramref name="publisherName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<IReadOnlyList<VirtualMachineImageBase>> ListOffers(string subscriptionId, AzureLocation location, string edgeZone, string publisherName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(edgeZone, nameof(edgeZone));
            Argument.AssertNotNullOrEmpty(publisherName, nameof(publisherName));

            using var message = CreateListOffersRequest(subscriptionId, location, edgeZone, publisherName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<VirtualMachineImageBase> value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        List<VirtualMachineImageBase> array = new List<VirtualMachineImageBase>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(VirtualMachineImageBase.DeserializeVirtualMachineImageBase(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListPublishersRequest(string subscriptionId, AzureLocation location, string edgeZone)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Compute/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/edgeZones/", false);
            uri.AppendPath(edgeZone, true);
            uri.AppendPath("/publishers", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a list of virtual machine image publishers for the specified Azure location and edge zone. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="edgeZone"> The name of the edge zone. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="edgeZone"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="edgeZone"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<IReadOnlyList<VirtualMachineImageBase>>> ListPublishersAsync(string subscriptionId, AzureLocation location, string edgeZone, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(edgeZone, nameof(edgeZone));

            using var message = CreateListPublishersRequest(subscriptionId, location, edgeZone);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<VirtualMachineImageBase> value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        List<VirtualMachineImageBase> array = new List<VirtualMachineImageBase>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(VirtualMachineImageBase.DeserializeVirtualMachineImageBase(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a list of virtual machine image publishers for the specified Azure location and edge zone. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="edgeZone"> The name of the edge zone. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="edgeZone"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="edgeZone"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<IReadOnlyList<VirtualMachineImageBase>> ListPublishers(string subscriptionId, AzureLocation location, string edgeZone, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(edgeZone, nameof(edgeZone));

            using var message = CreateListPublishersRequest(subscriptionId, location, edgeZone);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<VirtualMachineImageBase> value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        List<VirtualMachineImageBase> array = new List<VirtualMachineImageBase>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(VirtualMachineImageBase.DeserializeVirtualMachineImageBase(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListSkusRequest(string subscriptionId, AzureLocation location, string edgeZone, string publisherName, string offer)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Compute/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/edgeZones/", false);
            uri.AppendPath(edgeZone, true);
            uri.AppendPath("/publishers/", false);
            uri.AppendPath(publisherName, true);
            uri.AppendPath("/artifacttypes/vmimage/offers/", false);
            uri.AppendPath(offer, true);
            uri.AppendPath("/skus", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a list of virtual machine image SKUs for the specified location, edge zone, publisher, and offer. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="edgeZone"> The name of the edge zone. </param>
        /// <param name="publisherName"> A valid image publisher. </param>
        /// <param name="offer"> A valid image publisher offer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="edgeZone"/>, <paramref name="publisherName"/> or <paramref name="offer"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="edgeZone"/>, <paramref name="publisherName"/> or <paramref name="offer"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<IReadOnlyList<VirtualMachineImageBase>>> ListSkusAsync(string subscriptionId, AzureLocation location, string edgeZone, string publisherName, string offer, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(edgeZone, nameof(edgeZone));
            Argument.AssertNotNullOrEmpty(publisherName, nameof(publisherName));
            Argument.AssertNotNullOrEmpty(offer, nameof(offer));

            using var message = CreateListSkusRequest(subscriptionId, location, edgeZone, publisherName, offer);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<VirtualMachineImageBase> value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        List<VirtualMachineImageBase> array = new List<VirtualMachineImageBase>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(VirtualMachineImageBase.DeserializeVirtualMachineImageBase(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a list of virtual machine image SKUs for the specified location, edge zone, publisher, and offer. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="edgeZone"> The name of the edge zone. </param>
        /// <param name="publisherName"> A valid image publisher. </param>
        /// <param name="offer"> A valid image publisher offer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="edgeZone"/>, <paramref name="publisherName"/> or <paramref name="offer"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="edgeZone"/>, <paramref name="publisherName"/> or <paramref name="offer"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<IReadOnlyList<VirtualMachineImageBase>> ListSkus(string subscriptionId, AzureLocation location, string edgeZone, string publisherName, string offer, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(edgeZone, nameof(edgeZone));
            Argument.AssertNotNullOrEmpty(publisherName, nameof(publisherName));
            Argument.AssertNotNullOrEmpty(offer, nameof(offer));

            using var message = CreateListSkusRequest(subscriptionId, location, edgeZone, publisherName, offer);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<VirtualMachineImageBase> value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        List<VirtualMachineImageBase> array = new List<VirtualMachineImageBase>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(VirtualMachineImageBase.DeserializeVirtualMachineImageBase(item));
                        }
                        value = array;
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
