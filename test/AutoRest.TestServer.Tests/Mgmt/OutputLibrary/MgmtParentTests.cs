// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Linq;
using System.Threading.Tasks;
using AutoRest.CSharp.Mgmt.AutoRest;
using AutoRest.CSharp.Mgmt.Decorator;
using NUnit.Framework;

namespace AutoRest.TestServer.Tests.Mgmt.OutputLibrary
{
    internal class MgmtParentTests : OutputLibraryTestBase
    {
        public MgmtParentTests() : base("MgmtParent") { }

        [TestCase("VirtualMachineExtensionImage", "SubscriptionExtensions")]
        [TestCase("AvailabilitySet", "ResourceGroupExtensions")]
        [TestCase("DedicatedHost", "DedicatedHostGroup")]
        public void TestParent(string resourceName, string parentName)
        {
            var resource = MgmtContext.Library.ArmResources.FirstOrDefault(r => r.Type.Name == resourceName);
            Assert.NotNull(resource);
            var parents = resource.Parent();
            Assert.IsTrue(parents.Any(p => p.Type.Name == parentName));
        }
    }
}
