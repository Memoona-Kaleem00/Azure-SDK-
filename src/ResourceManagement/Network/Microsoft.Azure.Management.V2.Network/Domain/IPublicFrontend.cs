// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.V2.Network
{


    /// <summary>
    /// An immutable client-side representation of a public frontend of an Internet-facing load balancer.
    /// </summary>
    public interface IPublicFrontend  :
        IFrontend,
        IHasPublicIpAddress
    {
    }
}