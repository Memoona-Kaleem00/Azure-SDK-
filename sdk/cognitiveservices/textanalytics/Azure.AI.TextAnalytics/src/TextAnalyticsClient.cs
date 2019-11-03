﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using Azure.Core.Pipeline;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.AI.TextAnalytics
{
    /// <summary>
    /// The client to use for interacting with the Azure Configuration Store.
    /// </summary>
    public partial class TextAnalyticsClient
    {
        private readonly Uri _baseUri;
        private readonly HttpPipeline _pipeline;
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly string _subscriptionKey;
        private readonly string _apiVersion;

        /// <summary>
        /// Protected constructor to allow mocking.
        /// </summary>
        protected TextAnalyticsClient()
        {
        }

        // TODO: How are we doing AAD auth?

        /// <summary>
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="subscriptionKey"></param>
        public TextAnalyticsClient(string endpoint, string subscriptionKey)
            : this(endpoint, subscriptionKey, new TextAnalyticsClientOptions())
        {
        }

        /// <summary>
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="subscriptionKey"></param>
        /// <param name="options"></param>
        public TextAnalyticsClient(string endpoint, string subscriptionKey, TextAnalyticsClientOptions options)
        {
            Argument.AssertNotNullOrEmpty(endpoint, nameof(endpoint));
            Argument.AssertNotNullOrEmpty(subscriptionKey, nameof(endpoint));

            _baseUri = new Uri(endpoint);
            _subscriptionKey = subscriptionKey;
            _apiVersion = options.GetVersionString();
            _pipeline = HttpPipelineBuilder.Build(options);
            _clientDiagnostics = new ClientDiagnostics(options);
        }

        /// <summary>
        /// </summary>
        /// <param name="inputText"></param>
        /// <param name="countryHint"></param>
        /// <param name="showStats"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<Response<LanguageResult>> DetectLanguageAsync(string inputText, string countryHint = "en", bool showStats = false, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inputText, nameof(inputText));

            using DiagnosticScope scope = _clientDiagnostics.CreateScope("Azure.AI.TextAnalytics.TextAnalyticsClient.DetectLanguage");
            scope.AddAttribute("inputText", inputText);
            scope.Start();

            try
            {
                using Request request = CreateDetectLanguageRequest(inputText, countryHint, showStats);
                Response response = await _pipeline.SendRequestAsync(request, cancellationToken).ConfigureAwait(false);

                switch (response.Status)
                {
                    // TODO: Set of acceptable response status codes here?

                    case 200:
                    case 201:
                        return await CreateLanguageResponseAsync(response, cancellationToken).ConfigureAwait(false);
                    default:
                        throw await response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="inputText"></param>
        /// <param name="countryHint"></param>
        /// <param name="showStats"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual Response<LanguageResult> DetectLanguage(string inputText, string countryHint = "en", bool showStats = false, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inputText, nameof(inputText));

            using DiagnosticScope scope = _clientDiagnostics.CreateScope("Azure.AI.TextAnalytics.TextAnalyticsClient.DetectLanguage");
            scope.AddAttribute("inputText", inputText);
            scope.Start();

            try
            {
                using Request request = CreateDetectLanguageRequest(inputText, countryHint, showStats);
                Response response = _pipeline.SendRequest(request, cancellationToken);

                switch (response.Status)
                {
                    // TODO: Set of acceptable response status codes here?

                    case 200:
                    case 201:
                        return CreateLanguageResponse(response);
                    default:
                        throw response.CreateRequestFailedException();
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        private Request CreateDetectLanguageRequest(string inputText, string countryHint, bool showStats)
        {
            Argument.AssertNotNull(inputText, nameof(inputText));
            Argument.AssertNotNull(countryHint, nameof(countryHint));

            Request request = _pipeline.CreateRequest();

            ReadOnlyMemory<byte> content = TextAnalyticsServiceSerializer.SerializeLanguageInput(inputText, countryHint);

            request.Method = RequestMethod.Post;

            BuildUriForLanguagesRoute(request.Uri);

            request.Headers.Add(HttpHeader.Common.JsonContentType);
            request.Content = RequestContent.Create(content);

            request.Headers.Add("Ocp-Apim-Subscription-Key", _subscriptionKey);

            if (showStats)
            {
                // TODO: do something with showStats
            }

            return request;
        }

        #region Commented out AppConfiguration stuff
        ///// <summary>
        ///// Creates a <see cref="ConfigurationSetting"/>, uniquely identified by key and label, if it doesn't exist or overwrites the existing setting in the configuration store.
        ///// </summary>
        ///// <param name="key">The primary identifier of the configuration setting.</param>
        ///// <param name="value">The configuration setting's value.</param>
        ///// <param name="label">A label used to group this configuration setting with others.</param>
        ///// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        ///// <returns>A response containing the <see cref="ConfigurationSetting"/> written to the configuration store.</returns>
        //public virtual async Task<Response<ConfigurationSetting>> SetConfigurationSettingAsync(string key, string value, string label = default, CancellationToken cancellationToken = default)
        //{
        //    Argument.AssertNotNullOrEmpty(key, nameof(key));
        //    return await SetConfigurationSettingAsync(new ConfigurationSetting(key, value, label), default(MatchConditions), cancellationToken).ConfigureAwait(false);
        //}

        ///// <summary>
        ///// Creates a <see cref="ConfigurationSetting"/>, uniquely identified by key and label, if it doesn't exist or overwrites the existing setting in the configuration store.
        ///// </summary>
        ///// <param name="key">The primary identifier of the configuration setting.</param>
        ///// <param name="value">The configuration setting's value.</param>
        ///// <param name="label">A label used to group this configuration setting with others.</param>
        ///// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        ///// <returns>A response containing the <see cref="ConfigurationSetting"/> written to the configuration store.</returns>
        //public virtual Response<ConfigurationSetting> SetConfigurationSetting(string key, string value, string label = default, CancellationToken cancellationToken = default)
        //{
        //    Argument.AssertNotNullOrEmpty(key, nameof(key));
        //    return SetConfigurationSetting(new ConfigurationSetting(key, value, label), default(MatchConditions), cancellationToken);
        //}

        ///// <summary>
        ///// Creates a <see cref="ConfigurationSetting"/> if it doesn't exist or overwrites the existing setting in the configuration store.
        ///// </summary>
        ///// <param name="setting">The <see cref="ConfigurationSetting"/> to create.</param>
        ///// <param name="onlyIfUnchanged">If set to true and the configuration setting exists in the configuration store, overwrite the setting
        ///// if the passed-in <see cref="ConfigurationSetting"/> is the same version as the one in the configuration store.  The setting versions
        ///// are the same if their ETag fields match.  If the two settings are different versions, this method will throw an exception to indicate
        ///// that the setting in the configuration store was modified since it was last obtained by the client.</param>
        ///// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        ///// <returns>A response containing the <see cref="ConfigurationSetting"/> written to the configuration store.</returns>
        //public virtual async Task<Response<ConfigurationSetting>> SetConfigurationSettingAsync(ConfigurationSetting setting, bool onlyIfUnchanged = false, CancellationToken cancellationToken = default)
        //{
        //    if (setting == null)
        //        throw new ArgumentNullException($"{nameof(setting)}");

        //    MatchConditions requestOptions = default;
        //    if (onlyIfUnchanged)
        //    {
        //        requestOptions = new MatchConditions();
        //        requestOptions.IfMatch = setting.ETag;
        //    }

        //    return await SetConfigurationSettingAsync(setting, requestOptions, cancellationToken).ConfigureAwait(false);
        //}

        ///// <summary>
        ///// Creates a <see cref="ConfigurationSetting"/> if it doesn't exist or overwrites the existing setting in the configuration store.
        ///// </summary>
        ///// <param name="setting">The <see cref="ConfigurationSetting"/> to create.</param>
        ///// <param name="onlyIfUnchanged">If set to true and the configuration setting exists in the configuration store, overwrite the setting
        ///// if the passed-in <see cref="ConfigurationSetting"/> is the same version as the one in the configuration store.  The setting versions
        ///// are the same if their ETag fields match.  If the two settings are different versions, this method will throw an exception to indicate
        ///// that the setting in the configuration store was modified since it was last obtained by the client.</param>
        ///// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        ///// <returns>A response containing the <see cref="ConfigurationSetting"/> written to the configuration store.</returns>
        //public virtual Response<ConfigurationSetting> SetConfigurationSetting(ConfigurationSetting setting, bool onlyIfUnchanged = false, CancellationToken cancellationToken = default)
        //{
        //    if (setting == null)
        //        throw new ArgumentNullException($"{nameof(setting)}");

        //    MatchConditions requestOptions = default;
        //    if (onlyIfUnchanged)
        //    {
        //        requestOptions = new MatchConditions();
        //        requestOptions.IfMatch = setting.ETag;
        //    }

        //    return SetConfigurationSetting(setting, requestOptions, cancellationToken);
        //}

        //internal virtual async Task<Response<ConfigurationSetting>> SetConfigurationSettingAsync(ConfigurationSetting setting, MatchConditions requestOptions, CancellationToken cancellationToken = default)
        //{
        //    using DiagnosticScope scope = _clientDiagnostics.CreateScope("Azure.AI.TextAnalytics.ConfigurationClient.SetConfigurationSetting");
        //    scope.AddAttribute("key", setting?.Key);
        //    scope.Start();

        //    try
        //    {
        //        using Request request = CreateSetRequest(setting, requestOptions);
        //        Response response = await _pipeline.SendRequestAsync(request, cancellationToken).ConfigureAwait(false);

        //        return response.Status switch
        //        {
        //            200 => await CreateResponseAsync(response, cancellationToken).ConfigureAwait(false),
        //            409 => throw await response.CreateRequestFailedExceptionAsync("The setting is read only").ConfigureAwait(false),

        //            // Throws on 412 if resource was modified.
        //            _ => throw await response.CreateRequestFailedExceptionAsync().ConfigureAwait(false),
        //        };
        //    }
        //    catch (Exception e)
        //    {
        //        scope.Failed(e);
        //        throw;
        //    }
        //}

        //internal virtual Response<ConfigurationSetting> SetConfigurationSetting(ConfigurationSetting setting, MatchConditions requestOptions, CancellationToken cancellationToken = default)
        //{
        //    using DiagnosticScope scope = _clientDiagnostics.CreateScope("Azure.AI.TextAnalytics.ConfigurationClient.SetConfigurationSetting");
        //    scope.AddAttribute("key", setting?.Key);
        //    scope.Start();

        //    try
        //    {
        //        using Request request = CreateSetRequest(setting, requestOptions);

        //        Response response = _pipeline.SendRequest(request, cancellationToken);

        //        return response.Status switch
        //        {
        //            200 => CreateResponse(response),
        //            409 => throw response.CreateRequestFailedException("The setting is read only"),

        //            // Throws on 412 if resource was modified.
        //            _ => throw response.CreateRequestFailedException(),
        //        };
        //    }
        //    catch (Exception e)
        //    {
        //        scope.Failed(e);
        //        throw;
        //    }
        //}

        //private Request CreateSetRequest(ConfigurationSetting setting, MatchConditions requestOptions)
        //{
        //    Argument.AssertNotNull(setting, nameof(setting));
        //    Argument.AssertNotNullOrEmpty(setting.Key, $"{nameof(setting)}.{nameof(setting.Key)}");

        //    Request request = _pipeline.CreateRequest();
        //    ReadOnlyMemory<byte> content = ConfigurationServiceSerializer.SerializeRequestBody(setting);

        //    request.Method = RequestMethod.Put;
        //    BuildUriForKvRoute(request.Uri, setting);
        //    request.Headers.Add(s_mediaTypeKeyValueApplicationHeader);
        //    request.Headers.Add(HttpHeader.Common.JsonContentType);

        //    if (requestOptions != null)
        //    {
        //        ConditionalRequestOptionsExtensions.ApplyHeaders(request, requestOptions);
        //    }

        //    request.Content = RequestContent.Create(content);
        //    return request;
        //}

        ///// <summary>
        ///// Delete a <see cref="ConfigurationSetting"/> from the configuration store.
        ///// </summary>
        ///// <param name="key">The primary identifier of the configuration setting.</param>
        ///// <param name="label">A label used to group this configuration setting with others.</param>
        ///// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        ///// <returns>A response indicating the success of the operation.</returns>
        //public virtual async Task<Response> DeleteConfigurationSettingAsync(string key, string label = default, CancellationToken cancellationToken = default)
        //{
        //    return await DeleteConfigurationSettingAsync(key, label, default, cancellationToken).ConfigureAwait(false);
        //}

        ///// <summary>
        ///// Delete a <see cref="ConfigurationSetting"/> from the configuration store.
        ///// </summary>
        ///// <param name="key">The primary identifier of the configuration setting.</param>
        ///// <param name="label">A label used to group this configuration setting with others.</param>
        ///// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        ///// <returns>A response indicating the success of the operation.</returns>
        //public virtual Response DeleteConfigurationSetting(string key, string label = default, CancellationToken cancellationToken = default)
        //{
        //    return DeleteConfigurationSetting(key, label, default, cancellationToken);
        //}

        ///// <param name="setting">The <see cref="ConfigurationSetting"/> to delete.</param>
        ///// <param name="onlyIfUnchanged">If set to true and the configuration setting exists in the configuration store, delete the setting
        ///// if the passed-in <see cref="ConfigurationSetting"/> is the same version as the one in the configuration store.  The setting versions
        ///// are the same if their ETag fields match.  If the two settings are different versions, this method will throw an exception to indicate
        ///// that the setting in the configuration store was modified since it was last obtained by the client.</param>
        ///// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        ///// <returns>A response indicating the success of the operation.</returns>
        //public virtual async Task<Response> DeleteConfigurationSettingAsync(ConfigurationSetting setting, bool onlyIfUnchanged = false, CancellationToken cancellationToken = default)
        //{
        //    if (setting == null)
        //        throw new ArgumentNullException($"{nameof(setting)}");

        //    MatchConditions requestOptions = default;
        //    if (onlyIfUnchanged)
        //    {
        //        requestOptions = new MatchConditions();
        //        requestOptions.IfMatch = setting.ETag;
        //    }

        //    return await DeleteConfigurationSettingAsync(setting.Key, setting.Label, requestOptions, cancellationToken).ConfigureAwait(false);
        //}

        ///// <param name="setting">The <see cref="ConfigurationSetting"/> to delete.</param>
        ///// <param name="onlyIfUnchanged">If set to true and the configuration setting exists in the configuration store, delete the setting
        ///// if the passed-in <see cref="ConfigurationSetting"/> is the same version as the one in the configuration store.  The setting versions
        ///// are the same if their ETag fields match.  If the two settings are different versions, this method will throw an exception to indicate
        ///// that the setting in the configuration store was modified since it was last obtained by the client.</param>
        ///// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        ///// <returns>A response indicating the success of the operation.</returns>
        //public virtual Response DeleteConfigurationSetting(ConfigurationSetting setting, bool onlyIfUnchanged = false, CancellationToken cancellationToken = default)
        //{
        //    if (setting == null)
        //        throw new ArgumentNullException($"{nameof(setting)}");

        //    MatchConditions requestOptions = default;
        //    if (onlyIfUnchanged)
        //    {
        //        requestOptions = new MatchConditions();
        //        requestOptions.IfMatch = setting.ETag;
        //    }

        //    return DeleteConfigurationSetting(setting.Key, setting.Label, requestOptions, cancellationToken);
        //}

        //internal virtual async Task<Response> DeleteConfigurationSettingAsync(string key, string label, MatchConditions requestOptions, CancellationToken cancellationToken = default)
        //{
        //    using DiagnosticScope scope = _clientDiagnostics.CreateScope("Azure.AI.TextAnalytics.ConfigurationClient.DeleteConfigurationSetting");
        //    scope.AddAttribute("key", key);
        //    scope.Start();

        //    try
        //    {
        //        using Request request = CreateDeleteRequest(key, label, requestOptions);
        //        Response response = await _pipeline.SendRequestAsync(request, cancellationToken).ConfigureAwait(false);

        //        return response.Status switch
        //        {
        //            200 => response,
        //            204 => response,
        //            409 => throw response.CreateRequestFailedException("The setting is read only"),

        //            // Throws on 412 if resource was modified.
        //            _ => throw response.CreateRequestFailedException()
        //        };
        //    }
        //    catch (Exception e)
        //    {
        //        scope.Failed(e);
        //        throw;
        //    }
        //}

        //internal virtual Response DeleteConfigurationSetting(string key, string label, MatchConditions requestOptions, CancellationToken cancellationToken = default)
        //{
        //    using DiagnosticScope scope = _clientDiagnostics.CreateScope("Azure.AI.TextAnalytics.ConfigurationClient.DeleteConfigurationSetting");
        //    scope.AddAttribute("key", key);
        //    scope.Start();

        //    try
        //    {
        //        using Request request = CreateDeleteRequest(key, label, requestOptions);
        //        Response response = _pipeline.SendRequest(request, cancellationToken);

        //        return response.Status switch
        //        {
        //            200 => response,
        //            204 => response,
        //            409 => throw response.CreateRequestFailedException("The setting is read only."),

        //            // Throws on 412 if resource was modified.
        //            _ => throw response.CreateRequestFailedException()
        //        };
        //    }
        //    catch (Exception e)
        //    {
        //        scope.Failed(e);
        //        throw;
        //    }
        //}

        //private Request CreateDeleteRequest(string key, string label, MatchConditions requestOptions)
        //{
        //    Argument.AssertNotNullOrEmpty(key, nameof(key));

        //    Request request = _pipeline.CreateRequest();
        //    request.Method = RequestMethod.Delete;
        //    BuildUriForKvRoute(request.Uri, key, label);

        //    if (requestOptions != null)
        //    {
        //        ConditionalRequestOptionsExtensions.ApplyHeaders(request, requestOptions);
        //    }

        //    return request;
        //}

        ///// <summary>
        ///// Retrieve an existing <see cref="ConfigurationSetting"/>, uniquely identified by key and label, from the configuration store.
        ///// </summary>
        ///// <param name="key">The primary identifier of the configuration setting to retrieve.</param>
        ///// <param name="label">A label used to group this configuration setting with others.</param>
        ///// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        ///// <returns>A response containing the retrieved <see cref="ConfigurationSetting"/>.</returns>
        //public virtual async Task<Response<ConfigurationSetting>> GetConfigurationSettingAsync(string key, string label = default, CancellationToken cancellationToken = default)
        //{
        //    return await GetConfigurationSettingAsync(key, label, acceptDateTime: default, requestOptions: default, cancellationToken).ConfigureAwait(false);
        //}

        ///// <summary>
        ///// Retrieve an existing <see cref="ConfigurationSetting"/>, uniquely identified by key and label, from the configuration store.
        ///// </summary>
        ///// <param name="key">The primary identifier of the configuration setting to retrieve.</param>
        ///// <param name="label">A label used to group this configuration setting with others.</param>
        ///// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        ///// <returns>A response containing the retrieved <see cref="ConfigurationSetting"/>.</returns>
        //public virtual Response<ConfigurationSetting> GetConfigurationSetting(string key, string label = default, CancellationToken cancellationToken = default)
        //{
        //    return GetConfigurationSetting(key, label, acceptDateTime: default, requestOptions: default, cancellationToken);
        //}

        ///// <summary>
        ///// Retrieve an existing <see cref="ConfigurationSetting"/> from the configuration store.
        ///// </summary>
        ///// <param name="setting">The <see cref="ConfigurationSetting"/> to retrieve.</param>
        ///// <param name="onlyIfChanged">If set to true, only retrieve the setting from the configuration store if it has changed since the client last retrieved it.
        ///// It is determined to have changed if the ETag field on the passed-in <see cref="ConfigurationSetting"/> is different from the ETag of the setting in the
        ///// configuration store.  If it has not changed, the returned response will have have no value, and will throw if response.Value is accessed.  Callers may
        ///// check the status code on the response to avoid triggering the exception.</param>
        ///// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        ///// <returns>A response containing the retrieved <see cref="ConfigurationSetting"/>.</returns>
        //public virtual async Task<Response<ConfigurationSetting>> GetConfigurationSettingAsync(ConfigurationSetting setting, bool onlyIfChanged = false, CancellationToken cancellationToken = default)
        //{
        //    if (setting == null)
        //        throw new ArgumentNullException($"{nameof(setting)}");

        //    MatchConditions requestOptions = default;
        //    if (onlyIfChanged)
        //    {
        //        requestOptions = new MatchConditions();
        //        requestOptions.IfNoneMatch = setting.ETag;
        //    }

        //    return await GetConfigurationSettingAsync(setting.Key, setting.Label, acceptDateTime: default, requestOptions, cancellationToken).ConfigureAwait(false);
        //}

        ///// <summary>
        ///// Retrieve an existing <see cref="ConfigurationSetting"/> from the configuration store.
        ///// </summary>
        ///// <param name="setting">The <see cref="ConfigurationSetting"/> to retrieve.</param>
        ///// <param name="onlyIfChanged">If set to true, only retrieve the setting from the configuration store if it has changed since the client last retrieved it.
        ///// It is determined to have changed if the ETag field on the passed-in <see cref="ConfigurationSetting"/> is different from the ETag of the setting in the
        ///// configuration store.  If it has not changed, the returned response will have have no value, and will throw if response.Value is accessed.  Callers may
        ///// check the status code on the response to avoid triggering the exception.</param>
        ///// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        ///// <returns>A response containing the retrieved <see cref="ConfigurationSetting"/>.</returns>
        //public virtual Response<ConfigurationSetting> GetConfigurationSetting(ConfigurationSetting setting, bool onlyIfChanged = false, CancellationToken cancellationToken = default)
        //{
        //    if (setting == null)
        //        throw new ArgumentNullException($"{nameof(setting)}");

        //    MatchConditions requestOptions = default;
        //    if (onlyIfChanged)
        //    {
        //        requestOptions = new MatchConditions();
        //        requestOptions.IfNoneMatch = setting.ETag;
        //    }

        //    return GetConfigurationSetting(setting.Key, setting.Label, acceptDateTime: default, requestOptions, cancellationToken);
        //}

        //internal virtual async Task<Response<ConfigurationSetting>> GetConfigurationSettingAsync(string key, string label, DateTimeOffset acceptDateTime, MatchConditions requestOptions, CancellationToken cancellationToken = default)
        //{
        //    using DiagnosticScope scope = _clientDiagnostics.CreateScope("Azure.AI.TextAnalytics.ConfigurationClient.GetConfigurationSetting");
        //    scope.AddAttribute("key", key);
        //    scope.Start();

        //    try
        //    {
        //        using Request request = CreateGetRequest(key, label, acceptDateTime, requestOptions);
        //        Response response = await _pipeline.SendRequestAsync(request, cancellationToken).ConfigureAwait(false);

        //        return response.Status switch
        //        {
        //            200 => await CreateResponseAsync(response, cancellationToken).ConfigureAwait(false),
        //            304 => CreateResourceModifiedResponse(response),
        //            _ => throw await response.CreateRequestFailedExceptionAsync().ConfigureAwait(false),
        //        };
        //    }
        //    catch (Exception e)
        //    {
        //        scope.Failed(e);
        //        throw;
        //    }
        //}

        //internal virtual Response<ConfigurationSetting> GetConfigurationSetting(string key, string label, DateTimeOffset acceptDateTime, MatchConditions requestOptions, CancellationToken cancellationToken = default)
        //{
        //    using DiagnosticScope scope = _clientDiagnostics.CreateScope("Azure.AI.TextAnalytics.ConfigurationClient.GetConfigurationSetting");
        //    scope.AddAttribute(nameof(key), key);
        //    scope.Start();

        //    try
        //    {
        //        using (Request request = CreateGetRequest(key, label, acceptDateTime, requestOptions))
        //        {
        //            Response response = _pipeline.SendRequest(request, cancellationToken);

        //            return response.Status switch
        //            {
        //                200 => CreateResponse(response),
        //                304 => CreateResourceModifiedResponse(response),
        //                _ => throw response.CreateRequestFailedException(),
        //            };
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        scope.Failed(e);
        //        throw;
        //    }
        //}

        ///// <summary>
        ///// Retrieves one or more <see cref="ConfigurationSetting"/> that satisfy the options set in the <see cref="SettingSelector"/>.
        ///// </summary>
        ///// <param name="selector">Options used to select a set of <see cref="ConfigurationSetting"/> entities from the configuration store.</param>
        ///// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        ///// <returns>An enumerable collection containing the retrieved <see cref="ConfigurationSetting"/> entities.</returns>
        //public virtual AsyncPageable<ConfigurationSetting> GetConfigurationSettingsAsync(SettingSelector selector, CancellationToken cancellationToken = default)
        //{
        //    Argument.AssertNotNull(selector, nameof(selector));
        //    return PageResponseEnumerator.CreateAsyncEnumerable(nextLink => GetConfigurationSettingsPageAsync(selector, nextLink, cancellationToken));
        //}

        ///// <summary>
        ///// Retrieves one or more <see cref="ConfigurationSetting"/> that satisfies the options of the <see cref="SettingSelector"/>
        ///// </summary>
        ///// <param name="selector">Set of options for selecting <see cref="ConfigurationSetting"/> from the configuration store.</param>
        ///// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        //public virtual Pageable<ConfigurationSetting> GetConfigurationSettings(SettingSelector selector, CancellationToken cancellationToken = default)
        //{
        //    Argument.AssertNotNull(selector, nameof(selector));
        //    return PageResponseEnumerator.CreateEnumerable(nextLink => GetConfigurationSettingsPage(selector, nextLink, cancellationToken));
        //}

        ///// <summary>
        ///// Retrieves the different revisions of specific <see cref="ConfigurationSetting"/> that satisfies the options of the <see cref="SettingSelector"/>
        ///// </summary>
        ///// <param name="selector">Set of options for selecting <see cref="ConfigurationSetting"/> from the configuration store.</param>
        ///// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        //public virtual AsyncPageable<ConfigurationSetting> GetRevisionsAsync(SettingSelector selector, CancellationToken cancellationToken = default)
        //{
        //    Argument.AssertNotNull(selector, nameof(selector));
        //    return PageResponseEnumerator.CreateAsyncEnumerable(nextLink => GetRevisionsPageAsync(selector, nextLink, cancellationToken));
        //}

        ///// <summary>
        ///// Retrieves the different revisions of specific <see cref="ConfigurationSetting"/> that satisfies the options of the <see cref="SettingSelector"/>
        ///// </summary>
        ///// <param name="selector">Set of options for selecting <see cref="ConfigurationSetting"/> from the configuration store.</param>
        ///// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        //public virtual Pageable<ConfigurationSetting> GetRevisions(SettingSelector selector, CancellationToken cancellationToken = default)
        //{
        //    Argument.AssertNotNull(selector, nameof(selector));
        //    return PageResponseEnumerator.CreateEnumerable(nextLink => GetRevisionsPage(selector, nextLink, cancellationToken));
        //}

        //private Request CreateGetRequest(string key, string label, DateTimeOffset acceptDateTime, MatchConditions requestOptions)
        //{
        //    Argument.AssertNotNullOrEmpty(key, nameof(key));

        //    Request request = _pipeline.CreateRequest();
        //    request.Method = RequestMethod.Get;
        //    BuildUriForKvRoute(request.Uri, key, label);
        //    request.Headers.Add(s_mediaTypeKeyValueApplicationHeader);

        //    if (acceptDateTime != default)
        //    {
        //        var dateTime = acceptDateTime.UtcDateTime.ToString(AcceptDateTimeFormat, CultureInfo.InvariantCulture);
        //        request.Headers.Add(AcceptDatetimeHeader, dateTime);
        //    }

        //    if (requestOptions != null)
        //    {
        //        ConditionalRequestOptionsExtensions.ApplyHeaders(request, requestOptions);
        //    }

        //    request.Headers.Add(HttpHeader.Common.JsonContentType);
        //    return request;
        //}

        ///// <summary>
        ///// Fetches the <see cref="ConfigurationSetting"/> from the configuration store that match the options selected in the <see cref="SettingSelector"/>.
        ///// </summary>
        ///// <param name="selector">Set of options for selecting settings from the configuration store.</param>
        ///// <param name="pageLink"></param>
        ///// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        //private async Task<Page<ConfigurationSetting>> GetConfigurationSettingsPageAsync(SettingSelector selector, string pageLink, CancellationToken cancellationToken = default)
        //{
        //    using DiagnosticScope scope = _clientDiagnostics.CreateScope("Azure.AI.TextAnalytics.ConfigurationClient.GetConfigurationSettingsPage");
        //    scope.Start();

        //    try
        //    {
        //        using Request request = CreateBatchRequest(selector, pageLink);
        //        Response response = await _pipeline.SendRequestAsync(request, cancellationToken).ConfigureAwait(false);

        //        switch (response.Status)
        //        {
        //            case 200:
        //            case 206:
        //                SettingBatch settingBatch = await ConfigurationServiceSerializer.ParseBatchAsync(response, cancellationToken).ConfigureAwait(false);
        //                return Page<ConfigurationSetting>.FromValues(settingBatch.Settings, settingBatch.NextBatchLink, response);
        //            default:
        //                throw await response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        scope.Failed(e);
        //        throw;
        //    }
        //}

        ///// <summary>
        ///// Fetches the <see cref="ConfigurationSetting"/> from the configuration store that match the options selected in the <see cref="SettingSelector"/>.
        ///// </summary>
        ///// <param name="selector">Set of options for selecting settings from the configuration store.</param>
        ///// <param name="pageLink"></param>
        ///// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        //private Page<ConfigurationSetting> GetConfigurationSettingsPage(SettingSelector selector, string pageLink, CancellationToken cancellationToken = default)
        //{
        //    using DiagnosticScope scope = _clientDiagnostics.CreateScope("Azure.AI.TextAnalytics.ConfigurationClient.GetConfigurationSettingsPage");
        //    scope.Start();

        //    try
        //    {
        //        using Request request = CreateBatchRequest(selector, pageLink);
        //        Response response = _pipeline.SendRequest(request, cancellationToken);

        //        switch (response.Status)
        //        {
        //            case 200:
        //            case 206:
        //                SettingBatch settingBatch = ConfigurationServiceSerializer.ParseBatch(response);
        //                return Page<ConfigurationSetting>.FromValues(settingBatch.Settings, settingBatch.NextBatchLink, response);
        //            default:
        //                throw response.CreateRequestFailedException();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        scope.Failed(e);
        //        throw;
        //    }
        //}

        //private Request CreateBatchRequest(SettingSelector selector, string pageLink)
        //{
        //    Request request = _pipeline.CreateRequest();
        //    request.Method = RequestMethod.Get;
        //    BuildUriForGetBatch(request.Uri, selector, pageLink);
        //    request.Headers.Add(s_mediaTypeKeyValueApplicationHeader);
        //    if (selector.AsOf.HasValue)
        //    {
        //        var dateTime = selector.AsOf.Value.UtcDateTime.ToString(AcceptDateTimeFormat, CultureInfo.InvariantCulture);
        //        request.Headers.Add(AcceptDatetimeHeader, dateTime);
        //    }

        //    return request;
        //}

        ///// <summary>
        ///// Lists chronological/historical representation of <see cref="ConfigurationSetting"/> from the configuration store that match the options selected in the <see cref="SettingSelector"/>.
        ///// </summary>
        ///// <remarks>Revisions are provided in descending order from their respective <see cref="ConfigurationSetting.LastModified"/> date.</remarks>
        ///// <param name="selector">Set of options for selecting settings from the configuration store.</param>
        ///// <param name="pageLink"></param>
        ///// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        //private async Task<Page<ConfigurationSetting>> GetRevisionsPageAsync(SettingSelector selector, string pageLink, CancellationToken cancellationToken = default)
        //{
        //    using DiagnosticScope scope = _clientDiagnostics.CreateScope("Azure.AI.TextAnalytics.ConfigurationClient.GetRevisionsPage");
        //    scope.Start();

        //    try
        //    {
        //        using Request request = CreateGetRevisionsRequest(selector, pageLink);
        //        Response response = await _pipeline.SendRequestAsync(request, cancellationToken).ConfigureAwait(false);
        //        switch (response.Status)
        //        {
        //            case 200:
        //            case 206:
        //                SettingBatch settingBatch = await ConfigurationServiceSerializer.ParseBatchAsync(response, cancellationToken).ConfigureAwait(false);
        //                return Page<ConfigurationSetting>.FromValues(settingBatch.Settings, settingBatch.NextBatchLink, response);
        //            default:
        //                throw await response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        scope.Failed(e);
        //        throw;
        //    }
        //}

        ///// <summary>
        ///// Lists chronological/historical representation of <see cref="ConfigurationSetting"/> from the configuration store that match the options selected in the <see cref="SettingSelector"/>.
        ///// </summary>
        ///// <remarks>Revisions are provided in descending order from their respective <see cref="ConfigurationSetting.LastModified"/> date.</remarks>
        ///// <param name="selector">Set of options for selecting settings from the configuration store.</param>
        ///// <param name="pageLink"></param>
        ///// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        //private Page<ConfigurationSetting> GetRevisionsPage(SettingSelector selector, string pageLink, CancellationToken cancellationToken = default)
        //{
        //    using DiagnosticScope scope = _clientDiagnostics.CreateScope("Azure.AI.TextAnalytics.ConfigurationClient.GetRevisionsPage");
        //    scope.Start();

        //    try
        //    {
        //        using Request request = CreateGetRevisionsRequest(selector, pageLink);
        //        Response response = _pipeline.SendRequest(request, cancellationToken);
        //        switch (response.Status)
        //        {
        //            case 200:
        //            case 206:
        //                SettingBatch settingBatch = ConfigurationServiceSerializer.ParseBatch(response);
        //                return Page<ConfigurationSetting>.FromValues(settingBatch.Settings, settingBatch.NextBatchLink, response);
        //            default:
        //                throw response.CreateRequestFailedException();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        scope.Failed(e);
        //        throw;
        //    }
        //}

        //private Request CreateGetRevisionsRequest(SettingSelector selector, string pageLink)
        //{
        //    Request request = _pipeline.CreateRequest();
        //    request.Method = RequestMethod.Get;
        //    BuildUriForRevisions(request.Uri, selector, pageLink);
        //    request.Headers.Add(s_mediaTypeKeyValueApplicationHeader);
        //    if (selector.AsOf.HasValue)
        //    {
        //        var dateTime = selector.AsOf.Value.UtcDateTime.ToString(AcceptDateTimeFormat, CultureInfo.InvariantCulture);
        //        request.Headers.Add(AcceptDatetimeHeader, dateTime);
        //    }

        //    return request;
        //}

        ///// <summary>
        ///// Sets an existing <see cref="ConfigurationSetting"/> as read only in the configuration store.
        ///// </summary>
        ///// <param name="key">The primary identifier of the configuration setting.</param>
        ///// <param name="label">A label used to group this configuration setting with others.</param>
        ///// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        //public virtual async Task<Response<ConfigurationSetting>> SetReadOnlyAsync(string key, string label = default, CancellationToken cancellationToken = default)
        //{
        //    using DiagnosticScope scope = _clientDiagnostics.CreateScope("Azure.AI.TextAnalytics.ConfigurationClient.SetReadOnly");
        //    scope.AddAttribute("key", key);
        //    scope.Start();

        //    try
        //    {
        //        using Request request = CreateSetReadOnlyRequest(key, label);
        //        Response response = await _pipeline.SendRequestAsync(request, cancellationToken).ConfigureAwait(false);

        //        switch (response.Status)
        //        {
        //            case 200:
        //                return CreateResponse(response);
        //            default:
        //                throw await response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        scope.Failed(e);
        //        throw;
        //    }
        //}

        ///// <summary>
        ///// Sets an existing <see cref="ConfigurationSetting"/> as read only in the configuration store.
        ///// </summary>
        ///// <param name="key">The primary identifier of the configuration setting.</param>
        ///// <param name="label">A label used to group this configuration setting with others.</param>
        ///// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        //public virtual Response<ConfigurationSetting> SetReadOnly(string key, string label = default, CancellationToken cancellationToken = default)
        //{
        //    using DiagnosticScope scope = _clientDiagnostics.CreateScope("Azure.AI.TextAnalytics.ConfigurationClient.SetReadOnly");
        //    scope.AddAttribute("key", key);
        //    scope.Start();

        //    try
        //    {
        //        using Request request = CreateSetReadOnlyRequest(key, label);
        //        Response response = _pipeline.SendRequest(request, cancellationToken);

        //        switch (response.Status)
        //        {
        //            case 200:
        //                return CreateResponse(response);
        //            default:
        //                throw response.CreateRequestFailedException();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        scope.Failed(e);
        //        throw;
        //    }
        //}

        //private Request CreateSetReadOnlyRequest(string key, string label)
        //{
        //    Argument.AssertNotNullOrEmpty(key, nameof(key));

        //    Request request = _pipeline.CreateRequest();
        //    request.Method = RequestMethod.Put;
        //    BuildUriForLocksRoute(request.Uri, key, label);

        //    return request;
        //}

        ///// <summary>
        ///// Sets an existing <see cref="ConfigurationSetting"/> as read write in the configuration store.
        ///// </summary>
        ///// <param name="key">The primary identifier of the configuration setting.</param>
        ///// <param name="label">A label used to group this configuration setting with others.</param>
        ///// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        //public virtual async Task<Response<ConfigurationSetting>> ClearReadOnlyAsync(string key, string label = default, CancellationToken cancellationToken = default)
        //{
        //    using DiagnosticScope scope = _clientDiagnostics.CreateScope("Azure.AI.TextAnalytics.ConfigurationClient.ClearReadOnly");
        //    scope.AddAttribute("key", key);
        //    scope.Start();

        //    try
        //    {
        //        using Request request = CreateClearReadOnlyRequest(key, label);
        //        Response response = await _pipeline.SendRequestAsync(request, cancellationToken).ConfigureAwait(false);

        //        switch (response.Status)
        //        {
        //            case 200:
        //                return CreateResponse(response);
        //            default:
        //                throw await response.CreateRequestFailedExceptionAsync().ConfigureAwait(false);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        scope.Failed(e);
        //        throw;
        //    }
        //}

        ///// <summary>
        ///// Sets an existing <see cref="ConfigurationSetting"/> as read write in the configuration store.
        ///// </summary>
        ///// <param name="key">The primary identifier of the configuration setting.</param>
        ///// <param name="label">A label used to group this configuration setting with others.</param>
        ///// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        //public virtual Response<ConfigurationSetting> ClearReadOnly(string key, string label = default, CancellationToken cancellationToken = default)
        //{
        //    using DiagnosticScope scope = _clientDiagnostics.CreateScope("Azure.AI.TextAnalytics.ConfigurationClient.ClearReadOnly");
        //    scope.AddAttribute("key", key);
        //    scope.Start();

        //    try
        //    {
        //        using Request request = CreateClearReadOnlyRequest(key, label);
        //        Response response = _pipeline.SendRequest(request, cancellationToken);

        //        switch (response.Status)
        //        {
        //            case 200:
        //                return CreateResponse(response);
        //            default:
        //                throw response.CreateRequestFailedException();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        scope.Failed(e);
        //        throw;
        //    }
        //}

        //private Request CreateClearReadOnlyRequest(string key, string label)
        //{
        //    Argument.AssertNotNullOrEmpty(key, nameof(key));

        //    Request request = _pipeline.CreateRequest();
        //    request.Method = RequestMethod.Delete;
        //    BuildUriForLocksRoute(request.Uri, key, label);

        //    return request;
        //}
        #endregion
    }
}
