// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Analytics.Synapse.Artifacts;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The properties of the Spark job. </summary>
    public partial class SparkJobProperties
    {
        /// <summary> Initializes a new instance of <see cref="SparkJobProperties"/>. </summary>
        /// <param name="file"> File containing the application to execute. </param>
        /// <param name="driverMemory"> Amount of memory to use for the driver process. </param>
        /// <param name="driverCores"> Number of cores to use for the driver. </param>
        /// <param name="executorMemory"> Amount of memory to use per executor process. </param>
        /// <param name="executorCores"> Number of cores to use for each executor. </param>
        /// <param name="numExecutors"> Number of executors to launch for this job. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="file"/>, <paramref name="driverMemory"/> or <paramref name="executorMemory"/> is null. </exception>
        public SparkJobProperties(string file, string driverMemory, int driverCores, string executorMemory, int executorCores, int numExecutors)
        {
            Argument.AssertNotNull(file, nameof(file));
            Argument.AssertNotNull(driverMemory, nameof(driverMemory));
            Argument.AssertNotNull(executorMemory, nameof(executorMemory));

            File = file;
            Args = new ChangeTrackingList<string>();
            Jars = new ChangeTrackingList<string>();
            Files = new ChangeTrackingList<string>();
            Archives = new ChangeTrackingList<string>();
            DriverMemory = driverMemory;
            DriverCores = driverCores;
            ExecutorMemory = executorMemory;
            ExecutorCores = executorCores;
            NumExecutors = numExecutors;
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of <see cref="SparkJobProperties"/>. </summary>
        /// <param name="name"> The name of the job. </param>
        /// <param name="file"> File containing the application to execute. </param>
        /// <param name="className"> Main class for Java/Scala application. </param>
        /// <param name="conf"> Spark configuration properties. </param>
        /// <param name="args"> Command line arguments for the application. </param>
        /// <param name="jars"> Jars to be used in this job. </param>
        /// <param name="files"> files to be used in this job. </param>
        /// <param name="archives"> Archives to be used in this job. </param>
        /// <param name="driverMemory"> Amount of memory to use for the driver process. </param>
        /// <param name="driverCores"> Number of cores to use for the driver. </param>
        /// <param name="executorMemory"> Amount of memory to use per executor process. </param>
        /// <param name="executorCores"> Number of cores to use for each executor. </param>
        /// <param name="numExecutors"> Number of executors to launch for this job. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal SparkJobProperties(string name, string file, string className, object conf, IList<string> args, IList<string> jars, IList<string> files, IList<string> archives, string driverMemory, int driverCores, string executorMemory, int executorCores, int numExecutors, IDictionary<string, object> additionalProperties)
        {
            Name = name;
            File = file;
            ClassName = className;
            Conf = conf;
            Args = args;
            Jars = jars;
            Files = files;
            Archives = archives;
            DriverMemory = driverMemory;
            DriverCores = driverCores;
            ExecutorMemory = executorMemory;
            ExecutorCores = executorCores;
            NumExecutors = numExecutors;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The name of the job. </summary>
        public string Name { get; set; }
        /// <summary> File containing the application to execute. </summary>
        public string File { get; set; }
        /// <summary> Main class for Java/Scala application. </summary>
        public string ClassName { get; set; }
        /// <summary> Spark configuration properties. </summary>
        public object Conf { get; set; }
        /// <summary> Command line arguments for the application. </summary>
        public IList<string> Args { get; }
        /// <summary> Jars to be used in this job. </summary>
        public IList<string> Jars { get; }
        /// <summary> files to be used in this job. </summary>
        public IList<string> Files { get; }
        /// <summary> Archives to be used in this job. </summary>
        public IList<string> Archives { get; }
        /// <summary> Amount of memory to use for the driver process. </summary>
        public string DriverMemory { get; set; }
        /// <summary> Number of cores to use for the driver. </summary>
        public int DriverCores { get; set; }
        /// <summary> Amount of memory to use per executor process. </summary>
        public string ExecutorMemory { get; set; }
        /// <summary> Number of cores to use for each executor. </summary>
        public int ExecutorCores { get; set; }
        /// <summary> Number of executors to launch for this job. </summary>
        public int NumExecutors { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
