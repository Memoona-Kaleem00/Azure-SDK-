// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.V2.Network.HttpProbe.UpdateDefinition
{

    using Microsoft.Azure.Management.V2.Resource.Core.ChildResource.Update;
    /// <summary>
    /// The stage of the HTTP probe definition allowing to specify the number of unsuccessful probes before failure is determined.
    /// @param <ParentT> the parent type
    /// </summary>
    public interface IWithNumberOfProbes<ParentT> 
    {
        /// <summary>
        /// Specifies the number of unsuccessful probes before failure is determined.
        /// </summary>
        /// <param name="probes">probes number of probes</param>
        /// <returns>the next stage of the definition</returns>
        IWithAttach<ParentT> WithNumberOfProbes (int probes);

    }
    /// <summary>
    /// The stage of the probe definition allowing to specify the HTTP request path for the probe to monitor.
    /// @param <ParentT> the parent type
    /// </summary>
    public interface IWithRequestPath<ParentT> 
    {
        IWithAttach<ParentT> WithRequestPath (string requestPath);

    }
    /// <summary>
    /// The stage of the HTTP probe definition allowing to specify the probe interval.
    /// @param <ParentT> the parent resource type
    /// </summary>
    public interface IWithIntervalInSeconds<ParentT> 
    {
        /// <summary>
        /// Specifies the interval between probes, in seconds.
        /// </summary>
        /// <param name="seconds">seconds number of seconds</param>
        /// <returns>the next stage of the definition</returns>
        IWithAttach<ParentT> WithIntervalInSeconds (int seconds);

    }
    /// <summary>
    /// The entirety of a probe definition as part of a load balancer update.
    /// @param <ParentT> the return type of the final {@link UpdateDefinitionStages.WithAttach#attach()}
    /// </summary>
    public interface IUpdateDefinition<ParentT>  :
        IBlank<ParentT>,
        IWithAttach<ParentT>,
        IWithRequestPath<ParentT>
    {
    }
    /// <summary>
    /// The final stage of the probe definition.
    /// <p>
    /// At this stage, any remaining optional settings can be specified, or the probe definition
    /// can be attached to the parent load balancer definition using {@link WithAttach#attach()}.
    /// @param <ParentT> the return type of {@link WithAttach#attach()}
    /// </summary>
    public interface IWithAttach<ParentT>  :
        IInUpdate<ParentT>,
        IWithPort<ParentT>,
        IWithIntervalInSeconds<ParentT>,
        IWithNumberOfProbes<ParentT>
    {
    }
    /// <summary>
    /// The first stage of the probe definition.
    /// @param <ParentT> the return type of the final {@link WithAttach#attach()}
    /// </summary>
    public interface IBlank<ParentT>  :
        IWithRequestPath<ParentT>
    {
    }
    /// <summary>
    /// The stage of the probe definition allowing to specify the port to monitor.
    /// @param <ParentT> the parent type
    /// </summary>
    public interface IWithPort<ParentT> 
    {
        /// <summary>
        /// Specifies the port number to call for health monitoring.
        /// </summary>
        /// <param name="port">port a port number</param>
        /// <returns>the next stage of the definition</returns>
        IWithAttach<ParentT> WithPort (int port);

    }
}