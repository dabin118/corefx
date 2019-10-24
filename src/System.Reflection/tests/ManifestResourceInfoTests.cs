// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Xunit;

namespace System.Reflection.Tests
{
    public class ManifestResourceInfoTests
    {
        [Fact]
        public void FileName()
        {
            Assembly assembly = typeof(ManifestResourceInfoTests).GetTypeInfo().Assembly;
            ManifestResourceInfo manifestResourceInfo = assembly.GetManifestResourceInfo("ResourceTextFile.txt");
            Assert.Null(manifestResourceInfo.FileName);
        }

        [Fact]
        public void ReferencedAssembly()
        {
            Assembly assembly = typeof(ManifestResourceInfoTests).GetTypeInfo().Assembly;
            ManifestResourceInfo manifestResourceInfo = assembly.GetManifestResourceInfo("ResourceTextFile.txt");
            Assert.Null(manifestResourceInfo.ReferencedAssembly);
        }

        [Fact]
        public void ResourceLocation()
        {
            Assembly assembly = typeof(ManifestResourceInfoTests).GetTypeInfo().Assembly;
            ManifestResourceInfo manifestResourceInfo = assembly.GetManifestResourceInfo("ResourceTextFile.txt");
            Assert.Equal("Embedded, ContainedInManifestFile", manifestResourceInfo.ResourceLocation.ToString());
        }
    }
}
