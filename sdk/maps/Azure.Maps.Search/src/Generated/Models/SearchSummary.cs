// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Search.Models
{
    /// <summary> Summary object for a Search API response. </summary>
    public partial class SearchSummary
    {
        /// <summary> Initializes a new instance of SearchSummary. </summary>
        internal SearchSummary()
        {
        }

        /// <summary> Initializes a new instance of SearchSummary. </summary>
        /// <param name="query"> The query parameter that was used to produce these search results. </param>
        /// <param name="queryType"> The type of query being returned: NEARBY or NON_NEAR. </param>
        /// <param name="queryTime"> Time spent resolving the query, in milliseconds. </param>
        /// <param name="numResults"> Number of results in the response. </param>
        /// <param name="top"> Maximum number of responses that will be returned. </param>
        /// <param name="skip"> The starting offset of the returned Results within the full Result set. </param>
        /// <param name="totalResults"> The total number of Results found. </param>
        /// <param name="fuzzyLevel"> The maximum fuzzy level required to provide Results. </param>
        /// <param name="geoBias"> Indication when the internal search engine has applied a geospatial bias to improve the ranking of results.  In  some methods, this can be affected by setting the lat and lon parameters where available.  In other cases it is  purely internal. </param>
        internal SearchSummary(string query, QueryType? queryType, int? queryTime, int? numResults, int? top, int? skip, int? totalResults, int? fuzzyLevel, LatLon geoBias)
        {
            Query = query;
            QueryType = queryType;
            QueryTime = queryTime;
            NumResults = numResults;
            Top = top;
            Skip = skip;
            TotalResults = totalResults;
            FuzzyLevel = fuzzyLevel;
            GeoBias = geoBias;
        }

        /// <summary> The query parameter that was used to produce these search results. </summary>
        public string Query { get; }
        /// <summary> The type of query being returned: NEARBY or NON_NEAR. </summary>
        public QueryType? QueryType { get; }
        /// <summary> Time spent resolving the query, in milliseconds. </summary>
        public int? QueryTime { get; }
        /// <summary> Number of results in the response. </summary>
        public int? NumResults { get; }
        /// <summary> Maximum number of responses that will be returned. </summary>
        public int? Top { get; }
        /// <summary> The starting offset of the returned Results within the full Result set. </summary>
        public int? Skip { get; }
        /// <summary> The total number of Results found. </summary>
        public int? TotalResults { get; }
        /// <summary> The maximum fuzzy level required to provide Results. </summary>
        public int? FuzzyLevel { get; }
        /// <summary> Indication when the internal search engine has applied a geospatial bias to improve the ranking of results.  In  some methods, this can be affected by setting the lat and lon parameters where available.  In other cases it is  purely internal. </summary>
        public LatLon GeoBias { get; }
    }
}
