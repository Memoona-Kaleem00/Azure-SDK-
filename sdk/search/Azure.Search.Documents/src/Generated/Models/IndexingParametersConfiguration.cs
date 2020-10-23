// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> A dictionary of indexer-specific configuration properties. Each name is the name of a specific property. Each value must be of a primitive type. </summary>
    public partial class IndexingParametersConfiguration : IDictionary<string, object>
    {
        /// <summary> Initializes a new instance of IndexingParametersConfiguration. </summary>
        public IndexingParametersConfiguration()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of IndexingParametersConfiguration. </summary>
        /// <param name="parsingMode"> Represents the parsing mode for indexing from an Azure blob data source. </param>
        /// <param name="excludedFileNameExtensions"> Comma-delimited list of filename extensions to ignore when processing from Azure blob storage.  For example, you could exclude &quot;.png, .mp4&quot; to skip over those files during indexing. </param>
        /// <param name="indexedFileNameExtensions"> Comma-delimited list of filename extensions to select when processing from Azure blob storage.  For example, you could focus indexing on specific application files &quot;.docx, .pptx, .msg&quot; to specifically include those file types. </param>
        /// <param name="failOnUnsupportedContentType"> For Azure blobs, set to false if you want to continue indexing when an unsupported content type is encountered, and you don&apos;t know all the content types (file extensions) in advance. </param>
        /// <param name="failOnUnprocessableDocument"> For Azure blobs, set to false if you want to continue indexing if a document fails indexing. </param>
        /// <param name="indexStorageMetadataOnlyForOversizedDocuments"> For Azure blobs, set this property to true to still index storage metadata for blob content that is too large to process. Oversized blobs are treated as errors by default. For limits on blob size, see https://docs.microsoft.com/azure/search/search-limits-quotas-capacity. </param>
        /// <param name="delimitedTextHeaders"> For CSV blobs, specifies a comma-delimited list of column headers, useful for mapping source fields to destination fields in an index. </param>
        /// <param name="delimitedTextDelimiter"> For CSV blobs, specifies the end-of-line single-character delimiter for CSV files where each line starts a new document (for example, &quot;|&quot;). </param>
        /// <param name="firstLineContainsHeaders"> For CSV blobs, indicates that the first (non-blank) line of each blob contains headers. </param>
        /// <param name="documentRoot"> For JSON arrays, given a structured or semi-structured document, you can specify a path to the array using this property. </param>
        /// <param name="dataToExtract"> Specifies the data to extract from Azure blob storage and tells the indexer which data to extract from image content when &quot;imageAction&quot; is set to a value other than &quot;none&quot;.  This applies to embedded image content in a .PDF or other application, or image files such as .jpg and .png, in Azure blobs. </param>
        /// <param name="imageAction"> Determines how to process embedded images and image files in Azure blob storage.  Setting the &quot;imageAction&quot; configuration to any value other than &quot;none&quot; requires that a skillset also be attached to that indexer. </param>
        /// <param name="allowSkillsetToReadFileData"> If true, will create a path //document//file_data that is an object representing the original file data downloaded from your blob data source.  This allows you to pass the original file data to a custom skill for processing within the enrichment pipeline, or to the Document Extraction skill. </param>
        /// <param name="pdfTextRotationAlgorithm"> Determines algorithm for text extraction from PDF files in Azure blob storage. </param>
        /// <param name="executionEnvironment"> Specifies the environment in which the indexer should execute. </param>
        /// <param name="QueryTimeout"> Increases the timeout beyond the 5-minute default for Azure SQL database data sources, specified in the format &quot;hh:mm:ss&quot;. </param>
        /// <param name="additionalProperties"> . </param>
        internal IndexingParametersConfiguration(BlobIndexerParsingMode? parsingMode, string excludedFileNameExtensions, string indexedFileNameExtensions, bool? failOnUnsupportedContentType, bool? failOnUnprocessableDocument, bool? indexStorageMetadataOnlyForOversizedDocuments, string delimitedTextHeaders, string delimitedTextDelimiter, bool? firstLineContainsHeaders, string documentRoot, BlobIndexerDataToExtract? dataToExtract, BlobIndexerImageAction? imageAction, bool? allowSkillsetToReadFileData, BlobIndexerPdfTextRotationAlgorithm? pdfTextRotationAlgorithm, IndexerExecutionEnvironment? executionEnvironment, string QueryTimeout, IDictionary<string, object> additionalProperties)
        {
            ParsingMode = parsingMode;
            ExcludedFileNameExtensions = excludedFileNameExtensions;
            IndexedFileNameExtensions = indexedFileNameExtensions;
            FailOnUnsupportedContentType = failOnUnsupportedContentType;
            FailOnUnprocessableDocument = failOnUnprocessableDocument;
            IndexStorageMetadataOnlyForOversizedDocuments = indexStorageMetadataOnlyForOversizedDocuments;
            DelimitedTextHeaders = delimitedTextHeaders;
            DelimitedTextDelimiter = delimitedTextDelimiter;
            FirstLineContainsHeaders = firstLineContainsHeaders;
            DocumentRoot = documentRoot;
            DataToExtract = dataToExtract;
            ImageAction = imageAction;
            AllowSkillsetToReadFileData = allowSkillsetToReadFileData;
            PdfTextRotationAlgorithm = pdfTextRotationAlgorithm;
            ExecutionEnvironment = executionEnvironment;
            _queryTimeout = QueryTimeout;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Represents the parsing mode for indexing from an Azure blob data source. </summary>
        public BlobIndexerParsingMode? ParsingMode { get; set; }
        /// <summary> Comma-delimited list of filename extensions to ignore when processing from Azure blob storage.  For example, you could exclude &quot;.png, .mp4&quot; to skip over those files during indexing. </summary>
        public string ExcludedFileNameExtensions { get; set; }
        /// <summary> Comma-delimited list of filename extensions to select when processing from Azure blob storage.  For example, you could focus indexing on specific application files &quot;.docx, .pptx, .msg&quot; to specifically include those file types. </summary>
        public string IndexedFileNameExtensions { get; set; }
        /// <summary> For Azure blobs, set to false if you want to continue indexing when an unsupported content type is encountered, and you don&apos;t know all the content types (file extensions) in advance. </summary>
        public bool? FailOnUnsupportedContentType { get; set; }
        /// <summary> For Azure blobs, set to false if you want to continue indexing if a document fails indexing. </summary>
        public bool? FailOnUnprocessableDocument { get; set; }
        /// <summary> For Azure blobs, set this property to true to still index storage metadata for blob content that is too large to process. Oversized blobs are treated as errors by default. For limits on blob size, see https://docs.microsoft.com/azure/search/search-limits-quotas-capacity. </summary>
        public bool? IndexStorageMetadataOnlyForOversizedDocuments { get; set; }
        /// <summary> For CSV blobs, specifies a comma-delimited list of column headers, useful for mapping source fields to destination fields in an index. </summary>
        public string DelimitedTextHeaders { get; set; }
        /// <summary> For CSV blobs, specifies the end-of-line single-character delimiter for CSV files where each line starts a new document (for example, &quot;|&quot;). </summary>
        public string DelimitedTextDelimiter { get; set; }
        /// <summary> For CSV blobs, indicates that the first (non-blank) line of each blob contains headers. </summary>
        public bool? FirstLineContainsHeaders { get; set; }
        /// <summary> For JSON arrays, given a structured or semi-structured document, you can specify a path to the array using this property. </summary>
        public string DocumentRoot { get; set; }
        /// <summary> Specifies the data to extract from Azure blob storage and tells the indexer which data to extract from image content when &quot;imageAction&quot; is set to a value other than &quot;none&quot;.  This applies to embedded image content in a .PDF or other application, or image files such as .jpg and .png, in Azure blobs. </summary>
        public BlobIndexerDataToExtract? DataToExtract { get; set; }
        /// <summary> Determines how to process embedded images and image files in Azure blob storage.  Setting the &quot;imageAction&quot; configuration to any value other than &quot;none&quot; requires that a skillset also be attached to that indexer. </summary>
        public BlobIndexerImageAction? ImageAction { get; set; }
        /// <summary> If true, will create a path //document//file_data that is an object representing the original file data downloaded from your blob data source.  This allows you to pass the original file data to a custom skill for processing within the enrichment pipeline, or to the Document Extraction skill. </summary>
        public bool? AllowSkillsetToReadFileData { get; set; }
        /// <summary> Determines algorithm for text extraction from PDF files in Azure blob storage. </summary>
        public BlobIndexerPdfTextRotationAlgorithm? PdfTextRotationAlgorithm { get; set; }
        /// <summary> Specifies the environment in which the indexer should execute. </summary>
        public IndexerExecutionEnvironment? ExecutionEnvironment { get; set; }
        internal IDictionary<string, object> AdditionalProperties { get; }
        /// <inheritdoc />
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        public bool TryGetValue(string key, out object value) => AdditionalProperties.TryGetValue(key, out value);
        /// <inheritdoc />
        public bool ContainsKey(string key) => AdditionalProperties.ContainsKey(key);
        /// <inheritdoc />
        public ICollection<string> Keys => AdditionalProperties.Keys;
        /// <inheritdoc />
        public ICollection<object> Values => AdditionalProperties.Values;
        /// <inheritdoc />
        int ICollection<KeyValuePair<string, object>>.Count => AdditionalProperties.Count;
        /// <inheritdoc />
        public void Add(string key, object value) => AdditionalProperties.Add(key, value);
        /// <inheritdoc />
        public bool Remove(string key) => AdditionalProperties.Remove(key);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.IsReadOnly => AdditionalProperties.IsReadOnly;
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.Add(KeyValuePair<string, object> value) => AdditionalProperties.Add(value);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.Remove(KeyValuePair<string, object> value) => AdditionalProperties.Remove(value);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.Contains(KeyValuePair<string, object> value) => AdditionalProperties.Contains(value);
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.CopyTo(KeyValuePair<string, object>[] destination, int offset) => AdditionalProperties.CopyTo(destination, offset);
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.Clear() => AdditionalProperties.Clear();
        /// <inheritdoc />
        public object this[string key]
        {
            get => AdditionalProperties[key];
            set => AdditionalProperties[key] = value;
        }
    }
}
