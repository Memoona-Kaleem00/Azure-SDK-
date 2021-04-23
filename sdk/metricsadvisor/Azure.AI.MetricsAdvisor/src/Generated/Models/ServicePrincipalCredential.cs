// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The ServicePrincipalCredential. </summary>
    internal partial class ServicePrincipalCredential : DataSourceCredential
    {
        /// <summary> Initializes a new instance of ServicePrincipalCredential. </summary>
        /// <param name="dataSourceCredentialName"> Name of data source credential. </param>
        /// <param name="parameters"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSourceCredentialName"/> or <paramref name="parameters"/> is null. </exception>
        public ServicePrincipalCredential(string dataSourceCredentialName, ServicePrincipalParam parameters) : base(dataSourceCredentialName)
        {
            if (dataSourceCredentialName == null)
            {
                throw new ArgumentNullException(nameof(dataSourceCredentialName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            Parameters = parameters;
            DataSourceCredentialType = DataSourceCredentialType.ServicePrincipal;
        }

        /// <summary> Initializes a new instance of ServicePrincipalCredential. </summary>
        /// <param name="dataSourceCredentialType"> Type of data source credential. </param>
        /// <param name="dataSourceCredentialId"> Unique id of data source credential. </param>
        /// <param name="dataSourceCredentialName"> Name of data source credential. </param>
        /// <param name="dataSourceCredentialDescription"> Description of data source credential. </param>
        /// <param name="parameters"> . </param>
        internal ServicePrincipalCredential(DataSourceCredentialType dataSourceCredentialType, Guid? dataSourceCredentialId, string dataSourceCredentialName, string dataSourceCredentialDescription, ServicePrincipalParam parameters) : base(dataSourceCredentialType, dataSourceCredentialId, dataSourceCredentialName, dataSourceCredentialDescription)
        {
            Parameters = parameters;
            DataSourceCredentialType = dataSourceCredentialType;
        }

        public ServicePrincipalParam Parameters { get; set; }
    }
}
