﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.AI.TextAnalytics
{
    public partial class TextAnalyticsClient
    {
        private const string TextAnalyticsRoute = "/text/analytics/";

        private const string ShowStats = "showStats";
        private const string ModelVersion = "model-version";

        private const string LanguagesRoute = "/languages";
        private const string EntitiesRoute = "/entities/recognition/general";
        private const string SentimentRoute = "/sentiment";

        #region Detect Language
        private static async Task<Response<DocumentResultCollection<DetectedLanguage>>> CreateDetectLanguageResponseAsync(Response response, CancellationToken cancellation)
        {
            DocumentResultCollection<DetectedLanguage> result = await TextAnalyticsServiceSerializer.DeserializeDetectLanguageResponseAsync(response.ContentStream, cancellation).ConfigureAwait(false);
            return Response.FromValue(result, response);
        }

        private static Response<DocumentResultCollection<DetectedLanguage>> CreateDetectLanguageResponse(Response response)
        {
            return Response.FromValue(TextAnalyticsServiceSerializer.DeserializeDetectLanguageResponse(response.ContentStream), response);
        }

        private static async Task<Response<IEnumerable<DetectedLanguage>>> CreateDetectLanguageResponseSimpleAsync(Response response, CancellationToken cancellation)
        {
            IEnumerable<DetectedLanguage> result = await TextAnalyticsServiceSerializer.DeserializeDetectedLanguageCollectionAsync(response.ContentStream, cancellation).ConfigureAwait(false);
            return Response.FromValue(result, response);
        }

        private static Response<IEnumerable<DetectedLanguage>> CreateDetectLanguageResponseSimple(Response response)
        {
            return Response.FromValue(TextAnalyticsServiceSerializer.DeserializeDetectedLanguageCollection(response.ContentStream), response);
        }

        private static Response<DetectedLanguage> CreateDetectedLanguageResponseSimple(Response response, DetectedLanguage detectedLanguage)
        {
            return Response.FromValue(detectedLanguage, response);
        }

        private void BuildUriForLanguagesRoute(RequestUriBuilder builder, bool showStats, string modelVersion)
        {
            builder.Reset(_baseUri);
            builder.AppendPath(TextAnalyticsRoute, escape: false);
            builder.AppendPath(_apiVersion, escape: false);
            builder.AppendPath(LanguagesRoute, escape: false);

            if (showStats)
            {
                builder.AppendQuery(ShowStats, "true");
            }

            if (!string.IsNullOrEmpty(modelVersion))
            {
                builder.AppendQuery(ModelVersion, modelVersion);
            }
        }
        #endregion

        #region Recognize Entities
        private static async Task<Response<DocumentResultCollection<Entity>>> CreateRecognizeEntitiesResponseAsync(Response response, CancellationToken cancellation)
        {
            DocumentResultCollection<Entity> result = await TextAnalyticsServiceSerializer.DeserializeRecognizeEntitiesResponseAsync(response.ContentStream, cancellation).ConfigureAwait(false);
            return Response.FromValue(result, response);
        }

        private static Response<DocumentResultCollection<Entity>> CreateRecognizeEntitiesResponse(Response response)
        {
            return Response.FromValue(TextAnalyticsServiceSerializer.DeserializeRecognizeEntitiesResponse(response.ContentStream), response);
        }

        // TODO: Create EntityCollection to codify this response?  So we have a collection of something that makes sense,
        // rather than a collection of collections of a thing that folks have to think about?
        private static async Task<Response<IEnumerable<IEnumerable<Entity>>>> CreateRecognizeEntitiesResponseSimpleAsync(Response response, CancellationToken cancellation)
        {
            var result = await TextAnalyticsServiceSerializer.DeserializeEntityCollectionAsync(response.ContentStream, cancellation).ConfigureAwait(false);
            return Response.FromValue(result, response);
        }

        private static Response<IEnumerable<IEnumerable<Entity>>> CreateRecognizeEntitiesResponseSimple(Response response)
        {
            return Response.FromValue(TextAnalyticsServiceSerializer.DeserializeEntityCollection(response.ContentStream), response);
        }

        private static Response<IEnumerable<Entity>> CreateRecognizeEntitiesResponseSimple(Response response, IEnumerable<Entity> entities)
        {
            return Response.FromValue(entities, response);
        }

        private void BuildUriForEntitiesRoute(RequestUriBuilder builder, bool showStats, string modelVersion)
        {
            builder.Reset(_baseUri);
            builder.AppendPath(TextAnalyticsRoute, escape: false);
            builder.AppendPath(_apiVersion, escape: false);
            builder.AppendPath(EntitiesRoute, escape: false);

            if (showStats)
            {
                builder.AppendQuery(ShowStats, "true");
            }

            if (!string.IsNullOrEmpty(modelVersion))
            {
                builder.AppendQuery(ModelVersion, modelVersion);
            }
        }
        #endregion

        #region Analyze Sentiment
        private static async Task<Response<SentimentResultCollection>> CreateAnalyzeSentimentResponseAsync(Response response, CancellationToken cancellation)
        {
            SentimentResultCollection result = await TextAnalyticsServiceSerializer.DeserializeAnalyzeSentimentResponseAsync(response.ContentStream, cancellation).ConfigureAwait(false);
            return Response.FromValue(result, response);
        }

        private static Response<SentimentResultCollection> CreateAnalyzeSentimentResponse(Response response)
        {
            return Response.FromValue(TextAnalyticsServiceSerializer.DeserializeAnalyzeSentimentResponse(response.ContentStream), response);
        }

        private static async Task<Response<IEnumerable<Sentiment>>> CreateAnalyzeSentimentResponseSimpleAsync(Response response, CancellationToken cancellation)
        {
            var result = await TextAnalyticsServiceSerializer.DeserializeSentimentCollectionAsync(response.ContentStream, cancellation).ConfigureAwait(false);
            return Response.FromValue(result, response);
        }

        private static Response<IEnumerable<Sentiment>> CreateAnalyzeSentimentResponseSimple(Response response)
        {
            return Response.FromValue(TextAnalyticsServiceSerializer.DeserializeSentimentCollection(response.ContentStream), response);
        }

        private static Response<Sentiment> CreateAnalyzeSentimentResponseSimple(Response response, Sentiment sentiment)
        {
            return Response.FromValue(sentiment, response);
        }

        private void BuildUriForSentimentRoute(RequestUriBuilder builder, bool showStats, string modelVersion)
        {
            builder.Reset(_baseUri);
            builder.AppendPath(TextAnalyticsRoute, escape: false);
            builder.AppendPath(_apiVersion, escape: false);
            builder.AppendPath(SentimentRoute, escape: false);

            if (showStats)
            {
                builder.AppendQuery(ShowStats, "true");
            }

            if (!string.IsNullOrEmpty(modelVersion))
            {
                builder.AppendQuery(ModelVersion, modelVersion);
            }
        }
        #endregion  Analyze Sentiment

        #region nobody wants to see these
        /// <summary>
        /// Check if two ConfigurationSetting instances are equal.
        /// </summary>
        /// <param name="obj">The instance to compare to.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => base.Equals(obj);

        /// <summary>
        /// Get a hash code for the ConfigurationSetting
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => base.GetHashCode();

        /// <summary>
        /// Creates a Key Value string in reference to the ConfigurationSetting.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString() => base.ToString();
        #endregion
    }
}
