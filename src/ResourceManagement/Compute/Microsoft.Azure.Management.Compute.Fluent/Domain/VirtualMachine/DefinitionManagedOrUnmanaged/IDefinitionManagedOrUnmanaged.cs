// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Compute.Fluent.VirtualMachine.DefinitionManagedOrUnmanaged
{
    using Microsoft.Azure.Management.Compute.Fluent.VirtualMachine.DefinitionShared;
    using Microsoft.Azure.Management.Compute.Fluent.VirtualMachine.Definition;

    /// <summary>
    /// The entirety of the virtual machine definition.
    /// </summary>
    public interface IDefinitionManagedOrUnmanaged  :
        IDefinitionShared,
        IWithLinuxRootUsernameManagedOrUnmanaged,
        IWithLinuxRootPasswordOrPublicKeyManagedOrUnmanaged,
        IWithWindowsAdminUsernameManagedOrUnmanaged,
        IWithWindowsAdminPasswordManagedOrUnmanaged,
        IWithFromImageCreateOptionsManagedOrUnmanaged,
        IWithLinuxCreateManagedOrUnmanaged,
        IWithWindowsCreateManagedOrUnmanaged,
        IWithManagedCreate,
        IWithUnmanagedCreate
    {
    }
}