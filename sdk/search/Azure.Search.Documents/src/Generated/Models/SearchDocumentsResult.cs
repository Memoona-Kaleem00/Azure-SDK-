// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.Search.Documents;

namespace Azure.Search.Documents.Models
{
    /// <summary> Response containing search results from an index. </summary>
    internal partial class SearchDocumentsResult
    {
        /// <summary> Initializes a new instance of SearchDocumentsResult. </summary>
        /// <param name="results"> The sequence of results returned by the query. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="results"/> is null. </exception>
        internal SearchDocumentsResult(IEnumerable<SearchResult> results)
        {
            Argument.AssertNotNull(results, nameof(results));

            Facets = new ChangeTrackingDictionary<string, IList<FacetResult>>();
            Answers = new ChangeTrackingList<QueryAnswerResult>();
            Results = results.ToList();
        }

        /// <summary> Initializes a new instance of SearchDocumentsResult. </summary>
        /// <param name="count"> The total count of results found by the search operation, or null if the count was not requested. If present, the count may be greater than the number of results in this response. This can happen if you use the $top or $skip parameters, or if Azure Cognitive Search can't return all the requested documents in a single Search response. </param>
        /// <param name="coverage"> A value indicating the percentage of the index that was included in the query, or null if minimumCoverage was not specified in the request. </param>
        /// <param name="facets"> The facet query results for the search operation, organized as a collection of buckets for each faceted field; null if the query did not include any facet expressions. </param>
        /// <param name="answers"> The answers query results for the search operation; null if the answers query parameter was not specified or set to 'none'. </param>
        /// <param name="nextPageParameters"> Continuation JSON payload returned when Azure Cognitive Search can't return all the requested results in a single Search response. You can use this JSON along with @odata.nextLink to formulate another POST Search request to get the next part of the search response. </param>
        /// <param name="results"> The sequence of results returned by the query. </param>
        /// <param name="nextLink"> Continuation URL returned when Azure Cognitive Search can't return all the requested results in a single Search response. You can use this URL to formulate another GET or POST Search request to get the next part of the search response. Make sure to use the same verb (GET or POST) as the request that produced this response. </param>
        /// <param name="semanticPartialResponseReason"> Reason that a partial response was returned for a semantic search request. </param>
        /// <param name="semanticPartialResponseType"> Type of partial response that was returned for a semantic search request. </param>
        internal SearchDocumentsResult(long? count, double? coverage, IReadOnlyDictionary<string, IList<FacetResult>> facets, IReadOnlyList<QueryAnswerResult> answers, SearchOptions nextPageParameters, IReadOnlyList<SearchResult> results, string nextLink, SemanticErrorReason? semanticPartialResponseReason, SemanticSearchResultsType? semanticPartialResponseType)
        {
            Count = count;
            Coverage = coverage;
            Facets = facets;
            Answers = answers;
            NextPageParameters = nextPageParameters;
            Results = results;
            NextLink = nextLink;
            SemanticPartialResponseReason = semanticPartialResponseReason;
            SemanticPartialResponseType = semanticPartialResponseType;
        }

        /// <summary> The total count of results found by the search operation, or null if the count was not requested. If present, the count may be greater than the number of results in this response. This can happen if you use the $top or $skip parameters, or if Azure Cognitive Search can't return all the requested documents in a single Search response. </summary>
        public long? Count { get; }
        /// <summary> A value indicating the percentage of the index that was included in the query, or null if minimumCoverage was not specified in the request. </summary>
        public double? Coverage { get; }
        /// <summary> The facet query results for the search operation, organized as a collection of buckets for each faceted field; null if the query did not include any facet expressions. </summary>
        public IReadOnlyDictionary<string, IList<FacetResult>> Facets { get; }
        /// <summary> The answers query results for the search operation; null if the answers query parameter was not specified or set to 'none'. </summary>
        public IReadOnlyList<QueryAnswerResult> Answers { get; }
        /// <summary> Continuation JSON payload returned when Azure Cognitive Search can't return all the requested results in a single Search response. You can use this JSON along with @odata.nextLink to formulate another POST Search request to get the next part of the search response. </summary>
        public SearchOptions NextPageParameters { get; }
        /// <summary> The sequence of results returned by the query. </summary>
        public IReadOnlyList<SearchResult> Results { get; }
        /// <summary> Continuation URL returned when Azure Cognitive Search can't return all the requested results in a single Search response. You can use this URL to formulate another GET or POST Search request to get the next part of the search response. Make sure to use the same verb (GET or POST) as the request that produced this response. </summary>
        public string NextLink { get; }
        /// <summary> Reason that a partial response was returned for a semantic search request. </summary>
        public SemanticErrorReason? SemanticPartialResponseReason { get; }
        /// <summary> Type of partial response that was returned for a semantic search request. </summary>
        public SemanticSearchResultsType? SemanticPartialResponseType { get; }
    }
}
