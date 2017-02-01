﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Azure.Tests;
using Fluent.Tests.Common;
using Xunit;
using Xunit.Abstractions;

namespace Samples.Tests
{
    public class Compute
    {
        public Compute(ITestOutputHelper output)
        {
            Microsoft.Azure.Management.Samples.Common.Utilities.LoggerMethod = output.WriteLine;
            Microsoft.Azure.Management.Samples.Common.Utilities.PauseMethod = TestHelper.ReadLine;
        }

        [Fact]
        [Trait("Samples", "Compute")]
        public void CreateVirtualMachinesInParallelTest()
        {
            using (var context = FluentMockContext.Start(this.GetType().FullName))
            {
                var rollUpClient = TestHelper.CreateRollupClient();
                CreateVirtualMachinesInParallel.Program.RunSample(rollUpClient);
            }
        }

        [Fact]
        [Trait("Samples", "Compute")]
        public void CreateVMsUsingCustomImageOrSpecializedVHDTest()
        {
            using (var context = FluentMockContext.Start(this.GetType().FullName))
            {
                var rollUpClient = TestHelper.CreateRollupClient();
                CreateVMsUsingCustomImageOrSpecializedVHD.Program.RunSample(rollUpClient);
            }
        }

        [Fact]
        [Trait("Samples", "Compute")]
        public void ListVirtualMachineExtensionImagesTest()
        {
            using (var context = FluentMockContext.Start(this.GetType().FullName))
            {
                var rollUpClient = TestHelper.CreateRollupClient();
                ListVirtualMachineExtensionImages.Program.RunSample(rollUpClient);
            }
        }

        [Fact]
        [Trait("Samples", "Compute")]
        public void ListVirtualMachineImagesTest()
        {
            using (var context = FluentMockContext.Start(this.GetType().FullName))
            {
                var rollUpClient = TestHelper.CreateRollupClient();
                ListVirtualMachineImages.Program.RunSample(rollUpClient);
            }
        }

        [Fact(Skip = "TODO: Assets location needs to be properly set")]
        [Trait("Samples", "Compute")]
        public void ManageAvailabilitySetTest()
        {
            using (var context = FluentMockContext.Start(this.GetType().FullName))
            {
                var rollUpClient = TestHelper.CreateRollupClient();
                ManageAvailabilitySet.Program.RunSample(rollUpClient);
            }
        }

        [Fact(Skip = "TODO: Assets location needs to be properly set")]
        [Trait("Samples", "Compute")]
        public void ManageVirtualMachineTest()
        {
            using (var context = FluentMockContext.Start(this.GetType().FullName))
            {
                var rollUpClient = TestHelper.CreateRollupClient();
                ManageVirtualMachine.Program.RunSample(rollUpClient);
            }
        }

        [Fact(Skip = "TODO: Assets location needs to be properly set")]
        [Trait("Samples", "Compute")]
        public void ManageVirtualMachineExtensionTest()
        {
            using (var context = FluentMockContext.Start(this.GetType().FullName))
            {
                var rollUpClient = TestHelper.CreateRollupClient();
                ManageVirtualMachineExtension.Program.RunSample(rollUpClient);
            }
        }

        [Fact(Skip = "TODO: Assets location needs to be properly set")]
        [Trait("Samples", "Compute")]
        public void ManageVirtualMachineScaleSetTest()
        {
            using (var context = FluentMockContext.Start(this.GetType().FullName))
            {
                var rollUpClient = TestHelper.CreateRollupClient();
                ManageVirtualMachineScaleSet.Program.RunSample(rollUpClient);
            }
        }

        [Fact(Skip = "TODO: Assets location needs to be properly set")]
        [Trait("Samples", "Compute")]
        public void ManageVirtualMachinesInParallelTest()
        {
            using (var context = FluentMockContext.Start(this.GetType().FullName))
            {
                var rollUpClient = TestHelper.CreateRollupClient();
                ManageVirtualMachinesInParallel.Program.RunSample(rollUpClient);
            }
        }

        [Fact(Skip = "TODO: Assets location needs to be properly set")]
        [Trait("Samples", "Compute")]
        public void ManageVirtualMachinesInParallelWithNetworkTest()
        {
            using (var context = FluentMockContext.Start(this.GetType().FullName))
            {
                var rollUpClient = TestHelper.CreateRollupClient();
                ManageVirtualMachinesInParallelWithNetwork.Program.RunSample(rollUpClient);
            }
        }

        [Fact(Skip = "TODO: Assets location needs to be properly set")]
        [Trait("Samples", "Compute")]
        public void CreateVirtualMachineUsingCustomImageFromVHDTest()
        {
            using (var context = FluentMockContext.Start(this.GetType().FullName))
            {
                var rollUpClient = TestHelper.CreateRollupClient();
                CreateVirtualMachineUsingCustomImageFromVHD.Program.RunSample(rollUpClient);
            }
        }


        [Fact(Skip = "TODO: Assets location needs to be properly set")]
        [Trait("Samples", "Compute")]
        public void CreateVirtualMachineUsingCustomImageFromVMTest()
        {
            using (var context = FluentMockContext.Start(this.GetType().FullName))
            {
                var rollUpClient = TestHelper.CreateRollupClient();
                CreateVirtualMachineUsingCustomImageFromVM.Program.RunSample(rollUpClient);
            }
        }


        [Fact(Skip = "TODO: Assets location needs to be properly set")]
        [Trait("Samples", "Compute")]
        public void CreateVirtualMachineUsingSpecializedDiskFromSnapshotTest()
        {
            using (var context = FluentMockContext.Start(this.GetType().FullName))
            {
                var rollUpClient = TestHelper.CreateRollupClient();
                CreateVirtualMachineUsingSpecializedDiskFromSnapshot.Program.RunSample(rollUpClient);
            }
        }


        [Fact(Skip = "TODO: Assets location needs to be properly set")]
        [Trait("Samples", "Compute")]
        public void CreateVirtualMachineUsingSpecializedDiskFromVhdTest()
        {
            using (var context = FluentMockContext.Start(this.GetType().FullName))
            {
                var rollUpClient = TestHelper.CreateRollupClient();
                CreateVirtualMachineUsingSpecializedDiskFromVhd.Program.RunSample(rollUpClient);
            }
        }

        [Fact(Skip = "TODO: Assets location needs to be properly set")]
        [Trait("Samples", "Compute")]
        public void ManageVirtualMachineWithDiskTest()
        {
            using (var context = FluentMockContext.Start(this.GetType().FullName))
            {
                var rollUpClient = TestHelper.CreateRollupClient();
                ManageVirtualMachineWithDisk.Program.RunSample(rollUpClient);
            }
        }

        [Fact(Skip = "TODO: Assets location needs to be properly set")]
        [Trait("Samples", "Compute")]
        public void MigrateVirtualMachineTest()
        {
            using (var context = FluentMockContext.Start(this.GetType().FullName))
            {
                var rollUpClient = TestHelper.CreateRollupClient();
                MigrateVirtualMachine.Program.RunSample(rollUpClient);
            }
        }

    }
}
