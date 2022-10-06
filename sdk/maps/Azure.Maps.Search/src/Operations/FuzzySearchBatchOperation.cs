// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Maps.Search.Models;

namespace Azure.Maps.Search
{
    /// <summary>
    /// **Search Fuzzy Batch API**
    /// 
    /// 
    /// **Applies to**: S1 pricing tier.
    /// 
    /// 
    /// 
    /// The Search Address Batch API sends batches of queries to [Search Fuzzy API](https://docs.microsoft.com/rest/api/maps/search/getsearchfuzzy) using just a single API call. You can call Search Address Fuzzy Batch API to run either asynchronously (async) or synchronously (sync). The async API allows caller to batch up to **10,000** queries and sync API up to **100** queries.
    /// ### Submit Synchronous Batch Request
    /// The Synchronous API is recommended for lightweight batch requests. When the service receives a request, it will respond as soon as the batch items are calculated and there will be no possibility to retrieve the results later. The Synchronous API will return a timeout error (a 408 response) if the request takes longer than 60 seconds. The number of batch items is limited to **100** for this API.
    /// ```
    /// POST https://atlas.microsoft.com/search/fuzzy/batch/sync/json?api-version=1.0&amp;subscription-key={subscription-key}
    /// ```
    /// ### Submit Asynchronous Batch Request
    /// The Asynchronous API is appropriate for processing big volumes of relatively complex search requests
    /// - It allows the retrieval of results in a separate call (multiple downloads are possible).
    /// - The asynchronous API is optimized for reliability and is not expected to run into a timeout.
    /// - The number of batch items is limited to **10,000** for this API.
    /// 
    /// When you make a request by using async request, by default the service returns a 202 response code along a redirect URL in the Location field of the response header. This URL should be checked periodically until the response data or error information is available.
    /// The asynchronous responses are stored for **14** days. The redirect URL returns a 404 response if used after the expiration period.
    /// 
    /// Please note that asynchronous batch request is a long-running request. Here&apos;s a typical sequence of operations:
    /// 1. Client sends a Search Address Batch `POST` request to Azure Maps
    /// 2. The server will respond with one of the following:
    /// 
    ///     &gt; HTTP `202 Accepted` - Batch request has been accepted.
    /// 
    ///     &gt; HTTP `Error` - There was an error processing your Batch request. This could either be a `400 Bad Request` or any other `Error` status code.
    /// 
    /// 3. If the batch request was accepted successfully, the `Location` header in the response contains the URL to download the results of the batch request.
    ///     This status URI looks like following:
    /// 
    /// ```
    ///     GET https://atlas.microsoft.com/search/fuzzy/batch/{batch-id}?api-version=1.0&amp;subscription-key={subscription-key}
    /// ```
    /// 4. Client issues a `GET` request on the _download URL_ obtained in Step 3 to download the batch results.
    /// 
    /// ### POST Body for Batch Request
    /// To send the _search fuzzy_ queries you will use a `POST` request where the request body will contain the `batchItems` array in `json` format and the `Content-Type` header will be set to `application/json`. Here&apos;s a sample request body containing 5 _search fuzzy_ queries:
    /// 
    /// 
    /// ```json
    /// {
    ///     &quot;batchItems&quot;: [
    ///         {&quot;query&quot;: &quot;?query=atm&amp;lat=47.639769&amp;lon=-122.128362&amp;radius=5000&amp;limit=5&quot;},
    ///         {&quot;query&quot;: &quot;?query=Statue Of Liberty&amp;limit=2&quot;},
    ///         {&quot;query&quot;: &quot;?query=Starbucks&amp;lat=47.639769&amp;lon=-122.128362&amp;radius=5000&quot;},
    ///         {&quot;query&quot;: &quot;?query=Space Needle&quot;},
    ///         {&quot;query&quot;: &quot;?query=pizza&amp;limit=10&quot;}
    ///     ]
    /// }
    /// ```
    /// 
    /// A _search fuzzy_ query in a batch is just a partial URL _without_ the protocol, base URL, path, api-version and subscription-key. It can accept any of the supported _search fuzzy_ [URI parameters](https://docs.microsoft.com/rest/api/maps/search/getsearchfuzzy#uri-parameters). The string values in the _search fuzzy_ query must be properly escaped (e.g. &quot; character should be escaped with \\ ) and it should also be properly URL-encoded.
    /// 
    /// 
    /// The async API allows caller to batch up to **10,000** queries and sync API up to **100** queries, and the batch should contain at least **1** query.
    /// 
    /// 
    /// ### Download Asynchronous Batch Results
    /// To download the async batch results you will issue a `GET` request to the batch download endpoint. This _download URL_ can be obtained from the `Location` header of a successful `POST` batch request and looks like the following:
    /// 
    /// ```
    /// https://atlas.microsoft.com/search/fuzzy/batch/{batch-id}?api-version=1.0&amp;subscription-key={subscription-key}
    /// ```
    /// Here&apos;s the typical sequence of operations for downloading the batch results:
    /// 1. Client sends a `GET` request using the _download URL_.
    /// 2. The server will respond with one of the following:
    /// 
    ///     &gt; HTTP `202 Accepted` - Batch request was accepted but is still being processed. Please try again in some time.
    /// 
    ///     &gt; HTTP `200 OK` - Batch request successfully processed. The response body contains all the batch results.
    /// 
    /// 
    /// 
    /// ### Batch Response Model
    /// The returned data content is similar for async and sync requests. When downloading the results of an async batch request, if the batch has finished processing, the response body contains the batch response. This batch response contains a `summary` component that indicates the `totalRequests` that were part of the original batch request and `successfulRequests`i.e. queries which were executed successfully. The batch response also includes a `batchItems` array which contains a response for each and every query in the batch request. The `batchItems` will contain the results in the exact same order the original queries were sent in the batch request. Each item in `batchItems` contains `statusCode` and `response` fields. Each `response` in `batchItems` is of one of the following types:
    /// 
    ///   - [`SearchAddressResponse`](https://docs.microsoft.com/rest/api/maps/search/getsearchfuzzy#SearchAddressResponse) - If the query completed successfully.
    /// 
    ///   - `Error` - If the query failed. The response will contain a `code` and a `message` in this case.
    /// 
    /// 
    /// Here&apos;s a sample Batch Response with 2 _successful_ and 1 _failed_ result:
    /// 
    /// 
    /// ```json
    /// {
    ///     &quot;summary&quot;: {
    ///         &quot;successfulRequests&quot;: 2,
    ///         &quot;totalRequests&quot;: 3
    ///     },
    ///     &quot;batchItems&quot;: [
    ///         {
    ///             &quot;statusCode&quot;: 200,
    ///             &quot;response&quot;:
    ///             {
    ///                 &quot;summary&quot;: {
    ///                     &quot;query&quot;: &quot;atm&quot;
    ///                 },
    ///                 &quot;results&quot;: [
    ///                     {
    ///                         &quot;type&quot;: &quot;POI&quot;,
    ///                         &quot;poi&quot;: {
    ///                             &quot;name&quot;: &quot;ATM at Wells Fargo&quot;
    ///                         },
    ///                         &quot;address&quot;: {
    ///                             &quot;country&quot;: &quot;United States Of America&quot;,
    ///                             &quot;freeformAddress&quot;: &quot;3240 157th Ave NE, Redmond, WA 98052&quot;
    ///                         }
    ///                     }
    ///                 ]
    ///             }
    ///         },
    ///         {
    ///             &quot;statusCode&quot;: 200,
    ///             &quot;response&quot;:
    ///             {
    ///                 &quot;summary&quot;: {
    ///                     &quot;query&quot;: &quot;statue of liberty&quot;
    ///                 },
    ///                 &quot;results&quot;: [
    ///                     {
    ///                         &quot;type&quot;: &quot;POI&quot;,
    ///                         &quot;poi&quot;: {
    ///                             &quot;name&quot;: &quot;Statue of Liberty&quot;
    ///                         },
    ///                         &quot;address&quot;: {
    ///                             &quot;country&quot;: &quot;United States Of America&quot;,
    ///                             &quot;freeformAddress&quot;: &quot;New York, NY 10004&quot;
    ///                         }
    ///                     }
    ///                 ]
    ///             }
    ///         },
    ///         {
    ///             &quot;statusCode&quot;: 400,
    ///             &quot;response&quot;:
    ///             {
    ///                 &quot;error&quot;:
    ///                 {
    ///                     &quot;code&quot;: &quot;400 BadRequest&quot;,
    ///                     &quot;message&quot;: &quot;Bad request: one or more parameters were incorrectly specified or are mutually exclusive.&quot;
    ///                 }
    ///             }
    ///         }
    ///     ]
    /// }
    /// ```
    /// </summary>
    public partial class FuzzySearchBatchOperation : Operation<SearchAddressBatchResult>
    {
        /// <summary> Initializes a new instance of SearchGetFuzzySearchBatchOperation for mocking. </summary>
        protected FuzzySearchBatchOperation()
        {
        }

        /// <summary>
        /// Initializes a new <see cref="FuzzySearchBatchOperation"/> instance
        /// </summary>
        /// <param name="client">
        /// <param name="followUpUrl">Follow up URL of the request.</param>
        /// The client used to check for completion.
        /// </param>
        internal FuzzySearchBatchOperation(MapsSearchClient client, Uri followUpUrl)
        {
            Argument.AssertNotNull(client, nameof(client));
            Argument.AssertNotNull(followUpUrl, nameof(followUpUrl));

            try
            {
                var paths = followUpUrl.AbsolutePath.Split('/');
                _id = paths[paths.Length - 1];
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is UriFormatException)
                {
                    throw new FormatException("Invalid ID", ex);
                }
            }

            _value = null;
            _rawResponse = null;
            _client = client;
            _cancellationToken = default;
        }

        private readonly MapsSearchClient _client;

        private readonly CancellationToken _cancellationToken;

        private bool _hasCompleted;

        private SearchAddressBatchResult _value;

        private Response _rawResponse;

        private string _id;

        /// <inheritdoc />
        public override SearchAddressBatchResult Value => _value;

        /// <inheritdoc />
        public override bool HasCompleted => _hasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _value != null;

        /// <inheritdoc />
        public override string Id => _id;

        /// <inheritdoc />
        public override Response GetRawResponse() => _rawResponse;

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) =>
            UpdateStatusAsync(false, cancellationToken).EnsureCompleted();

        /// <inheritdoc />
        public override async ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) =>
            await UpdateStatusAsync(true, cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Check for the latest status of the route matrix calculation operation.
        /// </summary>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <param name="async" />
        /// <returns>The <see cref="Response"/> with the status update.</returns>
        private async Task<Response> UpdateStatusAsync(bool async, CancellationToken cancellationToken)
        {
            // Short-circuit when already completed (which improves mocking
            // scenarios that won't have a client).
            if (HasCompleted)
            {
                return GetRawResponse();
            }

            // Use our original CancellationToken if the user didn't provide one
            if (cancellationToken == default)
            {
                cancellationToken = _cancellationToken;
            }

            // Get the latest status
            ResponseWithHeaders<SearchGetFuzzySearchBatchHeaders> update = async
                ? await _client.RestClient.GetFuzzySearchBatchAsync(_id, cancellationToken).ConfigureAwait(false)
                : _client.RestClient.GetFuzzySearchBatch(_id, cancellationToken);

            // Check if the operation is no longer running
            if (update.Headers.Location == null)
            {
                _hasCompleted = true;
            }
            else
            {
                var uri = new Uri(update.Headers.Location);
                var paths = uri.AbsolutePath.Split('/');
                _id = paths[paths.Length - 1];
            }

            // Save this update as the latest raw response indicating the state
            // of the route matrix calculation operation
            Response response = update.GetRawResponse();
            _rawResponse = response;
            return response;
        }

        /// <inheritdoc />
        public override async ValueTask<Response<SearchAddressBatchResult>> WaitForCompletionAsync(CancellationToken cancellationToken = default) =>
            await WaitForCompletionAsync(true, cancellationToken).ConfigureAwait(false);

        /// <inheritdoc />
        public override async ValueTask<Response<SearchAddressBatchResult>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) =>
            await this.WaitForCompletionAsync(true, cancellationToken).ConfigureAwait(false);

        /// <inheritdoc />
        public override Response<SearchAddressBatchResult> WaitForCompletion(CancellationToken cancellationToken = default) =>
            this.WaitForCompletionAsync(false, cancellationToken).EnsureCompleted();

        /// <inheritdoc />
        public override Response<SearchAddressBatchResult> WaitForCompletion(TimeSpan pollingInterval, CancellationToken cancellationToken) =>
            this.WaitForCompletionAsync(false, cancellationToken).EnsureCompleted();

        private async ValueTask<Response<SearchAddressBatchResult>> WaitForCompletionAsync(bool async, CancellationToken cancellationToken)
        {
            ResponseWithHeaders<SearchGetFuzzySearchBatchHeaders> update = async
                ? await _client.RestClient.GetFuzzySearchBatchAsync(_id, cancellationToken).ConfigureAwait(false)
                : _client.RestClient.GetFuzzySearchBatch(_id, cancellationToken);

            Response response = update.GetRawResponse();

            // Check if the operation is no longer running
            if (update.Headers.Location == null)
            {
                _hasCompleted = true;

                using var document = JsonDocument.Parse(response.ContentStream);
                _value = SearchAddressBatchResult.DeserializeSearchAddressBatchResult(document.RootElement);
                return Response.FromValue(_value, response);
            }
            else
            {
                var uri = new Uri(update.Headers.Location);
                var paths = uri.AbsolutePath.Split('/');
                _id = paths[paths.Length - 1];
            } 

            SearchAddressBatchResult result = null;
            return Response.FromValue(result, response);
        }
    }
}
