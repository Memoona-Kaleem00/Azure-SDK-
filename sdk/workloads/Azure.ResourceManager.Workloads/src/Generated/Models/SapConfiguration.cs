// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary>
    /// The SAP Configuration.
    /// Please note <see cref="SapConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="DeploymentConfiguration"/>, <see cref="DeploymentWithOSConfiguration"/> and <see cref="DiscoveryConfiguration"/>.
    /// </summary>
    [DeserializationProxy(typeof(UnknownSapConfiguration))]
    public abstract partial class SapConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SapConfiguration"/>. </summary>
        protected SapConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SapConfiguration"/>. </summary>
        /// <param name="configurationType"> The configuration Type. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SapConfiguration(SapConfigurationType configurationType, Dictionary<string, BinaryData> rawData)
        {
            ConfigurationType = configurationType;
            _rawData = rawData;
        }

        /// <summary> The configuration Type. </summary>
        internal SapConfigurationType ConfigurationType { get; set; }
    }
}
