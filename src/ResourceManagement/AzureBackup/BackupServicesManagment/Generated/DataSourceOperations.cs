// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Hyak.Common;
using Microsoft.Azure.Management.BackupServices;
using Microsoft.Azure.Management.BackupServices.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Management.BackupServices
{
    /// <summary>
    /// Definition of DataSource operations for the Azure Backup extension.
    /// </summary>
    internal partial class DataSourceOperations : IServiceOperations<BackupServicesManagementClient>, IDataSourceOperations
    {
        /// <summary>
        /// Initializes a new instance of the DataSourceOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal DataSourceOperations(BackupServicesManagementClient client)
        {
            this._client = client;
        }
        
        private BackupServicesManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.Azure.Management.BackupServices.BackupServicesManagementClient.
        /// </summary>
        public BackupServicesManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Disable protection for given item
        /// </summary>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <param name='containerName'>
        /// Optional.
        /// </param>
        /// <param name='dataSourceType'>
        /// Optional.
        /// </param>
        /// <param name='dataSourceId'>
        /// Optional.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the Disable Protection operation.
        /// </returns>
        public async Task<DisableProtectionResponse> DisableProtectionAsync(CustomRequestHeaders customRequestHeaders, string containerName, string dataSourceType, string dataSourceId, CancellationToken cancellationToken)
        {
            // Validate
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("customRequestHeaders", customRequestHeaders);
                tracingParameters.Add("containerName", containerName);
                tracingParameters.Add("dataSourceType", dataSourceType);
                tracingParameters.Add("dataSourceId", dataSourceId);
                TracingAdapter.Enter(invocationId, this, "DisableProtectionAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/Subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/resourceGroups/";
            url = url + Uri.EscapeDataString(this.Client.ResourceGroupName);
            url = url + "/providers/";
            url = url + "Microsoft.Backupseadev01";
            url = url + "/";
            url = url + "BackupVault";
            url = url + "/";
            url = url + Uri.EscapeDataString(this.Client.ResourceName);
            url = url + "/containers/";
            if (containerName != null)
            {
                url = url + Uri.EscapeDataString(containerName);
            }
            url = url + "/datasources/";
            if (dataSourceType != null)
            {
                url = url + Uri.EscapeDataString(dataSourceType);
            }
            url = url + "/";
            if (dataSourceId != null)
            {
                url = url + Uri.EscapeDataString(dataSourceId);
            }
            url = url + "/unprotect";
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2014-09-01");
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Post;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept-Language", "en-us");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    DisableProtectionResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new DisableProtectionResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            Guid jobIdInstance = Guid.Parse(((string)responseDoc));
                            result.JobId = jobIdInstance;
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-client-request-id"))
                    {
                        customRequestHeaders.ClientRequestId = httpResponse.Headers.GetValues("x-ms-client-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Enable protection for given item.
        /// </summary>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the Enable Protection operation.
        /// </returns>
        public async Task<EnableProtectionResponse> EnableProtectionAsync(CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken)
        {
            // Validate
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("customRequestHeaders", customRequestHeaders);
                TracingAdapter.Enter(invocationId, this, "EnableProtectionAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/Subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/resourceGroups/";
            url = url + Uri.EscapeDataString(this.Client.ResourceGroupName);
            url = url + "/providers/";
            url = url + "Microsoft.Backupseadev01";
            url = url + "/";
            url = url + "BackupVault";
            url = url + "/";
            url = url + Uri.EscapeDataString(this.Client.ResourceName);
            url = url + "/protectableobjects/protect";
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2014-09-01");
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Post;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept-Language", "en-us");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    EnableProtectionResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new EnableProtectionResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            Guid jobIdInstance = Guid.Parse(((string)responseDoc));
                            result.JobId = jobIdInstance;
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-client-request-id"))
                    {
                        customRequestHeaders.ClientRequestId = httpResponse.Headers.GetValues("x-ms-client-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Get the list of all DataSpurce.
        /// </summary>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list DataSource operation.
        /// </returns>
        public async Task<DataSourceListResponse> ListAsync(CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken)
        {
            // Validate
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("customRequestHeaders", customRequestHeaders);
                TracingAdapter.Enter(invocationId, this, "ListAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/Subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/resourceGroups/";
            url = url + Uri.EscapeDataString(this.Client.ResourceGroupName);
            url = url + "/providers/";
            url = url + "Microsoft.Backupseadev01";
            url = url + "/";
            url = url + "BackupVault";
            url = url + "/";
            url = url + Uri.EscapeDataString(this.Client.ResourceName);
            url = url + "/datasources";
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2014-09-01");
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept-Language", "en-us");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    DataSourceListResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new DataSourceListResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            DataSourceResponse dataSourcesInstance = new DataSourceResponse();
                            result.DataSources = dataSourcesInstance;
                            
                            JToken objectsArray = responseDoc["Objects"];
                            if (objectsArray != null && objectsArray.Type != JTokenType.Null)
                            {
                                foreach (JToken objectsValue in ((JArray)objectsArray))
                                {
                                    DataSourceInfo dataSourceInfoInstance = new DataSourceInfo();
                                    dataSourcesInstance.Objects.Add(dataSourceInfoInstance);
                                    
                                    JToken friendlyNameValue = objectsValue["FriendlyName"];
                                    if (friendlyNameValue != null && friendlyNameValue.Type != JTokenType.Null)
                                    {
                                        string friendlyNameInstance = ((string)friendlyNameValue);
                                        dataSourceInfoInstance.FriendlyName = friendlyNameInstance;
                                    }
                                    
                                    JToken containerNameValue = objectsValue["ContainerName"];
                                    if (containerNameValue != null && containerNameValue.Type != JTokenType.Null)
                                    {
                                        string containerNameInstance = ((string)containerNameValue);
                                        dataSourceInfoInstance.ContainerName = containerNameInstance;
                                    }
                                    
                                    JToken containerTypeValue = objectsValue["ContainerType"];
                                    if (containerTypeValue != null && containerTypeValue.Type != JTokenType.Null)
                                    {
                                        string containerTypeInstance = ((string)containerTypeValue);
                                        dataSourceInfoInstance.ContainerType = containerTypeInstance;
                                    }
                                    
                                    JToken workloadTypeValue = objectsValue["WorkloadType"];
                                    if (workloadTypeValue != null && workloadTypeValue.Type != JTokenType.Null)
                                    {
                                        string workloadTypeInstance = ((string)workloadTypeValue);
                                        dataSourceInfoInstance.Type = workloadTypeInstance;
                                    }
                                    
                                    JToken statusValue = objectsValue["Status"];
                                    if (statusValue != null && statusValue.Type != JTokenType.Null)
                                    {
                                        string statusInstance = ((string)statusValue);
                                        dataSourceInfoInstance.Status = statusInstance;
                                    }
                                    
                                    JToken protectionStatusValue = objectsValue["ProtectionStatus"];
                                    if (protectionStatusValue != null && protectionStatusValue.Type != JTokenType.Null)
                                    {
                                        string protectionStatusInstance = ((string)protectionStatusValue);
                                        dataSourceInfoInstance.ProtectionStatus = protectionStatusInstance;
                                    }
                                    
                                    JToken protectableObjectNameValue = objectsValue["ProtectableObjectName"];
                                    if (protectableObjectNameValue != null && protectableObjectNameValue.Type != JTokenType.Null)
                                    {
                                        string protectableObjectNameInstance = ((string)protectableObjectNameValue);
                                        dataSourceInfoInstance.ProtectableObjectName = protectableObjectNameInstance;
                                    }
                                    
                                    JToken protectionPolicyNameValue = objectsValue["ProtectionPolicyName"];
                                    if (protectionPolicyNameValue != null && protectionPolicyNameValue.Type != JTokenType.Null)
                                    {
                                        string protectionPolicyNameInstance = ((string)protectionPolicyNameValue);
                                        dataSourceInfoInstance.ProtectionPolicyName = protectionPolicyNameInstance;
                                    }
                                    
                                    JToken protectionPolicyIdValue = objectsValue["ProtectionPolicyId"];
                                    if (protectionPolicyIdValue != null && protectionPolicyIdValue.Type != JTokenType.Null)
                                    {
                                        string protectionPolicyIdInstance = ((string)protectionPolicyIdValue);
                                        dataSourceInfoInstance.ProtectionPolicyId = protectionPolicyIdInstance;
                                    }
                                    
                                    JToken policyInconsistentValue = objectsValue["PolicyInconsistent"];
                                    if (policyInconsistentValue != null && policyInconsistentValue.Type != JTokenType.Null)
                                    {
                                        bool policyInconsistentInstance = ((bool)policyInconsistentValue);
                                        dataSourceInfoInstance.PolicyInconsistent = policyInconsistentInstance;
                                    }
                                    
                                    JToken recoveryPointsCountValue = objectsValue["RecoveryPointsCount"];
                                    if (recoveryPointsCountValue != null && recoveryPointsCountValue.Type != JTokenType.Null)
                                    {
                                        int recoveryPointsCountInstance = ((int)recoveryPointsCountValue);
                                        dataSourceInfoInstance.RecoveryPointsCount = recoveryPointsCountInstance;
                                    }
                                    
                                    JToken lastRecoveryPointValue = objectsValue["LastRecoveryPoint"];
                                    if (lastRecoveryPointValue != null && lastRecoveryPointValue.Type != JTokenType.Null)
                                    {
                                        DateTime lastRecoveryPointInstance = ((DateTime)lastRecoveryPointValue);
                                        dataSourceInfoInstance.LastRecoveryPoint = lastRecoveryPointInstance;
                                    }
                                    
                                    JToken lastBackupTimeValue = objectsValue["LastBackupTime"];
                                    if (lastBackupTimeValue != null && lastBackupTimeValue.Type != JTokenType.Null)
                                    {
                                        DateTime lastBackupTimeInstance = ((DateTime)lastBackupTimeValue);
                                        dataSourceInfoInstance.LastBackupTime = lastBackupTimeInstance;
                                    }
                                    
                                    JToken lastBackupStatusValue = objectsValue["LastBackupStatus"];
                                    if (lastBackupStatusValue != null && lastBackupStatusValue.Type != JTokenType.Null)
                                    {
                                        string lastBackupStatusInstance = ((string)lastBackupStatusValue);
                                        dataSourceInfoInstance.LastBackupStatus = lastBackupStatusInstance;
                                    }
                                    
                                    JToken lastBackupJobIdValue = objectsValue["LastBackupJobId"];
                                    if (lastBackupJobIdValue != null && lastBackupJobIdValue.Type != JTokenType.Null)
                                    {
                                        string lastBackupJobIdInstance = ((string)lastBackupJobIdValue);
                                        dataSourceInfoInstance.LastBackupJobId = lastBackupJobIdInstance;
                                    }
                                    
                                    JToken instanceIdValue = objectsValue["InstanceId"];
                                    if (instanceIdValue != null && instanceIdValue.Type != JTokenType.Null)
                                    {
                                        string instanceIdInstance = ((string)instanceIdValue);
                                        dataSourceInfoInstance.InstanceId = instanceIdInstance;
                                    }
                                    
                                    JToken nameValue = objectsValue["Name"];
                                    if (nameValue != null && nameValue.Type != JTokenType.Null)
                                    {
                                        string nameInstance = ((string)nameValue);
                                        dataSourceInfoInstance.Name = nameInstance;
                                    }
                                    
                                    JToken operationInProgressValue = objectsValue["OperationInProgress"];
                                    if (operationInProgressValue != null && operationInProgressValue.Type != JTokenType.Null)
                                    {
                                        bool operationInProgressInstance = ((bool)operationInProgressValue);
                                        dataSourceInfoInstance.OperationInProgress = operationInProgressInstance;
                                    }
                                }
                            }
                            
                            JToken resultCountValue = responseDoc["ResultCount"];
                            if (resultCountValue != null && resultCountValue.Type != JTokenType.Null)
                            {
                                int resultCountInstance = ((int)resultCountValue);
                                dataSourcesInstance.ResultCount = resultCountInstance;
                            }
                            
                            JToken skiptokenValue = responseDoc["Skiptoken"];
                            if (skiptokenValue != null && skiptokenValue.Type != JTokenType.Null)
                            {
                                string skiptokenInstance = ((string)skiptokenValue);
                                dataSourcesInstance.Skiptoken = skiptokenInstance;
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-client-request-id"))
                    {
                        customRequestHeaders.ClientRequestId = httpResponse.Headers.GetValues("x-ms-client-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}
