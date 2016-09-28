// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.V2.Network.PublicFrontend.Update
{

    using Microsoft.Azure.Management.V2.Network.HasPublicIpAddress.Update;
    using Microsoft.Azure.Management.V2.Network.LoadBalancer.Update;
    using Microsoft.Azure.Management.V2.Resource.Core.ChildResourceActions;
    /// <summary>
    /// The stage of a public frontend update allowing to specify an existing public IP address.
    /// </summary>
    public interface IWithPublicIpAddress  :
        IWithExistingPublicIpAddress<Microsoft.Azure.Management.V2.Network.PublicFrontend.Update.IUpdate>
    {
    }
    /// <summary>
    /// The entirety of a public frontend update as part of an Internet-facing load balancer update.
    /// </summary>
    public interface IUpdate  :
        ISettable<Microsoft.Azure.Management.V2.Network.LoadBalancer.Update.IUpdate>,
        IWithPublicIpAddress
    {
    }
}