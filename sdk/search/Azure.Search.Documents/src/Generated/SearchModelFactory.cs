// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Search.Documents.Indexes.Models;

namespace Azure.Search.Documents.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class SearchModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Models.QueryAnswerResult"/>. </summary>
        /// <param name="score"> The score value represents how relevant the answer is to the query relative to other answers returned for the query. </param>
        /// <param name="key"> The key of the document the answer was extracted from. </param>
        /// <param name="text"> The text passage extracted from the document contents as the answer. </param>
        /// <param name="highlights"> Same text passage as in the Text property with highlighted text phrases most relevant to the query. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <returns> A new <see cref="Models.QueryAnswerResult"/> instance for mocking. </returns>
        public static QueryAnswerResult QueryAnswerResult(double? score = null, string key = null, string text = null, string highlights = null, IReadOnlyDictionary<string, object> additionalProperties = null)
        {
            additionalProperties ??= new Dictionary<string, object>();

            return new QueryAnswerResult(score, key, text, highlights, additionalProperties);
        }

        /// <summary> Initializes a new instance of <see cref="Models.QueryCaptionResult"/>. </summary>
        /// <param name="text"> A representative text passage extracted from the document most relevant to the search query. </param>
        /// <param name="highlights"> Same text passage as in the Text property with highlighted phrases most relevant to the query. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <returns> A new <see cref="Models.QueryCaptionResult"/> instance for mocking. </returns>
        public static QueryCaptionResult QueryCaptionResult(string text = null, string highlights = null, IReadOnlyDictionary<string, object> additionalProperties = null)
        {
            additionalProperties ??= new Dictionary<string, object>();

            return new QueryCaptionResult(text, highlights, additionalProperties);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DocumentDebugInfo"/>. </summary>
        /// <param name="semantic"> Contains debugging information specific to semantic ranking requests. </param>
        /// <returns> A new <see cref="Models.DocumentDebugInfo"/> instance for mocking. </returns>
        public static DocumentDebugInfo DocumentDebugInfo(SemanticDebugInfo semantic = null)
        {
            return new DocumentDebugInfo(semantic);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SemanticDebugInfo"/>. </summary>
        /// <param name="titleField"> The title field that was sent to the semantic enrichment process, as well as how it was used. </param>
        /// <param name="contentFields"> The content fields that were sent to the semantic enrichment process, as well as how they were used. </param>
        /// <param name="keywordFields"> The keyword fields that were sent to the semantic enrichment process, as well as how they were used. </param>
        /// <param name="rerankerInput"> The raw concatenated strings that were sent to the semantic enrichment process. </param>
        /// <returns> A new <see cref="Models.SemanticDebugInfo"/> instance for mocking. </returns>
        public static SemanticDebugInfo SemanticDebugInfo(QueryResultDocumentSemanticField titleField = null, IEnumerable<QueryResultDocumentSemanticField> contentFields = null, IEnumerable<QueryResultDocumentSemanticField> keywordFields = null, QueryResultDocumentRerankerInput rerankerInput = null)
        {
            contentFields ??= new List<QueryResultDocumentSemanticField>();
            keywordFields ??= new List<QueryResultDocumentSemanticField>();

            return new SemanticDebugInfo(titleField, contentFields?.ToList(), keywordFields?.ToList(), rerankerInput);
        }

        /// <summary> Initializes a new instance of <see cref="Models.QueryResultDocumentSemanticField"/>. </summary>
        /// <param name="name"> The name of the field that was sent to the semantic enrichment process. </param>
        /// <param name="state"> The way the field was used for the semantic enrichment process (fully used, partially used, or unused). </param>
        /// <returns> A new <see cref="Models.QueryResultDocumentSemanticField"/> instance for mocking. </returns>
        public static QueryResultDocumentSemanticField QueryResultDocumentSemanticField(string name = null, SemanticFieldState? state = null)
        {
            return new QueryResultDocumentSemanticField(name, state);
        }

        /// <summary> Initializes a new instance of <see cref="Models.QueryResultDocumentRerankerInput"/>. </summary>
        /// <param name="title"> The raw string for the title field that was used for semantic enrichment. </param>
        /// <param name="content"> The raw concatenated strings for the content fields that were used for semantic enrichment. </param>
        /// <param name="keywords"> The raw concatenated strings for the keyword fields that were used for semantic enrichment. </param>
        /// <returns> A new <see cref="Models.QueryResultDocumentRerankerInput"/> instance for mocking. </returns>
        public static QueryResultDocumentRerankerInput QueryResultDocumentRerankerInput(string title = null, string content = null, string keywords = null)
        {
            return new QueryResultDocumentRerankerInput(title, content, keywords);
        }

        /// <summary> Initializes a new instance of <see cref="Models.AutocompleteResults"/>. </summary>
        /// <param name="coverage"> A value indicating the percentage of the index that was considered by the autocomplete request, or null if minimumCoverage was not specified in the request. </param>
        /// <param name="results"> The list of returned Autocompleted items. </param>
        /// <returns> A new <see cref="Models.AutocompleteResults"/> instance for mocking. </returns>
        public static AutocompleteResults AutocompleteResults(double? coverage = null, IEnumerable<AutocompleteItem> results = null)
        {
            results ??= new List<AutocompleteItem>();

            return new AutocompleteResults(coverage, results?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="Indexes.Models.SearchIndexerStatus"/>. </summary>
        /// <param name="status"> Overall indexer status. </param>
        /// <param name="lastResult"> The result of the most recent or an in-progress indexer execution. </param>
        /// <param name="executionHistory"> History of the recent indexer executions, sorted in reverse chronological order. </param>
        /// <param name="limits"> The execution limits for the indexer. </param>
        /// <returns> A new <see cref="Indexes.Models.SearchIndexerStatus"/> instance for mocking. </returns>
        public static SearchIndexerStatus SearchIndexerStatus(IndexerStatus status = default, IndexerExecutionResult lastResult = null, IEnumerable<IndexerExecutionResult> executionHistory = null, SearchIndexerLimits limits = null)
        {
            executionHistory ??= new List<IndexerExecutionResult>();

            return new SearchIndexerStatus(status, lastResult, executionHistory?.ToList(), limits);
        }

        /// <summary> Initializes a new instance of <see cref="Indexes.Models.IndexerExecutionResult"/>. </summary>
        /// <param name="status"> The outcome of this indexer execution. </param>
        /// <param name="statusDetail"> The outcome of this indexer execution. </param>
        /// <param name="currentState"> All of the state that defines and dictates the indexer's current execution. </param>
        /// <param name="errorMessage"> The error message indicating the top-level error, if any. </param>
        /// <param name="startTime"> The start time of this indexer execution. </param>
        /// <param name="endTime"> The end time of this indexer execution, if the execution has already completed. </param>
        /// <param name="errors"> The item-level indexing errors. </param>
        /// <param name="warnings"> The item-level indexing warnings. </param>
        /// <param name="itemCount"> The number of items that were processed during this indexer execution. This includes both successfully processed items and items where indexing was attempted but failed. </param>
        /// <param name="failedItemCount"> The number of items that failed to be indexed during this indexer execution. </param>
        /// <param name="initialTrackingState"> Change tracking state with which an indexer execution started. </param>
        /// <param name="finalTrackingState"> Change tracking state with which an indexer execution finished. </param>
        /// <returns> A new <see cref="Indexes.Models.IndexerExecutionResult"/> instance for mocking. </returns>
        public static IndexerExecutionResult IndexerExecutionResult(IndexerExecutionStatus status = default, IndexerExecutionStatusDetail? statusDetail = null, IndexerState currentState = null, string errorMessage = null, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, IEnumerable<SearchIndexerError> errors = null, IEnumerable<SearchIndexerWarning> warnings = null, int itemCount = default, int failedItemCount = default, string initialTrackingState = null, string finalTrackingState = null)
        {
            errors ??= new List<SearchIndexerError>();
            warnings ??= new List<SearchIndexerWarning>();

            return new IndexerExecutionResult(
                status,
                statusDetail,
                currentState,
                errorMessage,
                startTime,
                endTime,
                errors?.ToList(),
                warnings?.ToList(),
                itemCount,
                failedItemCount,
                initialTrackingState,
                finalTrackingState);
        }

        /// <summary> Initializes a new instance of <see cref="Indexes.Models.SearchIndexStatistics"/>. </summary>
        /// <param name="documentCount"> The number of documents in the index. </param>
        /// <param name="storageSize"> The amount of storage in bytes consumed by the index. </param>
        /// <param name="vectorIndexSize"> The amount of memory in bytes consumed by vectors in the index. </param>
        /// <returns> A new <see cref="Indexes.Models.SearchIndexStatistics"/> instance for mocking. </returns>
        public static SearchIndexStatistics SearchIndexStatistics(long documentCount = default, long storageSize = default, long vectorIndexSize = default)
        {
            return new SearchIndexStatistics(documentCount, storageSize, vectorIndexSize);
        }

        /// <summary> Initializes a new instance of <see cref="Indexes.Models.SearchServiceCounters"/>. </summary>
        /// <param name="aliasCounter"> Total number of aliases. </param>
        /// <param name="documentCounter"> Total number of documents across all indexes in the service. </param>
        /// <param name="indexCounter"> Total number of indexes. </param>
        /// <param name="indexerCounter"> Total number of indexers. </param>
        /// <param name="dataSourceCounter"> Total number of data sources. </param>
        /// <param name="storageSizeCounter"> Total size of used storage in bytes. </param>
        /// <param name="synonymMapCounter"> Total number of synonym maps. </param>
        /// <param name="skillsetCounter"> Total number of skillsets. </param>
        /// <param name="vectorIndexSizeCounter"> Total memory consumption of all vector indexes within the service, in bytes. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="aliasCounter"/>, <paramref name="documentCounter"/>, <paramref name="indexCounter"/>, <paramref name="indexerCounter"/>, <paramref name="dataSourceCounter"/>, <paramref name="storageSizeCounter"/>, <paramref name="synonymMapCounter"/>, <paramref name="skillsetCounter"/> or <paramref name="vectorIndexSizeCounter"/> is null. </exception>
        /// <returns> A new <see cref="Indexes.Models.SearchServiceCounters"/> instance for mocking. </returns>
        public static SearchServiceCounters SearchServiceCounters(SearchResourceCounter aliasCounter = null, SearchResourceCounter documentCounter = null, SearchResourceCounter indexCounter = null, SearchResourceCounter indexerCounter = null, SearchResourceCounter dataSourceCounter = null, SearchResourceCounter storageSizeCounter = null, SearchResourceCounter synonymMapCounter = null, SearchResourceCounter skillsetCounter = null, SearchResourceCounter vectorIndexSizeCounter = null)
        {
            if (aliasCounter == null)
            {
                throw new ArgumentNullException(nameof(aliasCounter));
            }
            if (documentCounter == null)
            {
                throw new ArgumentNullException(nameof(documentCounter));
            }
            if (indexCounter == null)
            {
                throw new ArgumentNullException(nameof(indexCounter));
            }
            if (indexerCounter == null)
            {
                throw new ArgumentNullException(nameof(indexerCounter));
            }
            if (dataSourceCounter == null)
            {
                throw new ArgumentNullException(nameof(dataSourceCounter));
            }
            if (storageSizeCounter == null)
            {
                throw new ArgumentNullException(nameof(storageSizeCounter));
            }
            if (synonymMapCounter == null)
            {
                throw new ArgumentNullException(nameof(synonymMapCounter));
            }
            if (skillsetCounter == null)
            {
                throw new ArgumentNullException(nameof(skillsetCounter));
            }
            if (vectorIndexSizeCounter == null)
            {
                throw new ArgumentNullException(nameof(vectorIndexSizeCounter));
            }

            return new SearchServiceCounters(
                aliasCounter,
                documentCounter,
                indexCounter,
                indexerCounter,
                dataSourceCounter,
                storageSizeCounter,
                synonymMapCounter,
                skillsetCounter,
                vectorIndexSizeCounter);
        }
    }
}
