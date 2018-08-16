﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Build.Tasks.Tests
{
    using Microsoft.WindowsAzure.Build.Tasks;
    using System;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    public class BuildTestBase
    {
        internal string rootDir = string.Empty;
        internal string sourceRootDir = string.Empty;

        public string RootDir { get; private set; }
        public string SourceRootDir { get; private set; }

        public string BinariesRootDir { get; private set; }

        public string ToolsRootDir { get; private set; }

        public string SignManifestDir { get; private set; }

        public string TestBinaryOutputDir { get; set; }
        public string TestDataRuntimeDir { get; set; }

        public string RepoRestoreDir { get; set; }

        public BuildTestBase()
        {
            string codeBasePath = Assembly.GetExecutingAssembly().CodeBase;
            var uri = new UriBuilder(codeBasePath);
            string path = Uri.UnescapeDataString(uri.Path);
            path = Path.GetDirectoryName(path);
            TestBinaryOutputDir = path;
            TestDataRuntimeDir = Path.Combine(TestBinaryOutputDir, "TestData");

            RootDir = GetSourceRootDir();
            SourceRootDir = Path.Combine(RootDir, "src");
            BinariesRootDir = Path.Combine(RootDir, "binaries");
            ToolsRootDir = Path.Combine(RootDir, "Tools");
            SignManifestDir = Path.Combine(BinariesRootDir, "signManifest");
            RepoRestoreDir = Path.Combine(RootDir, "restoredPackages");
        }

        internal string GetSourceRootDir()
        {
            string srcRootDir = string.Empty;
            string currDir = Directory.GetCurrentDirectory();

            if (!Directory.Exists(currDir))
            {
                currDir = Path.GetDirectoryName(this.GetType().GetTypeInfo().Assembly.Location);
            }

            string dirRoot = Directory.GetDirectoryRoot(currDir);

            while (currDir != dirRoot)
            {
                var buildProjFile = Directory.EnumerateFiles(currDir, "build.proj", SearchOption.TopDirectoryOnly);

                if (buildProjFile.Any<string>())
                {
                    srcRootDir = Path.GetDirectoryName(buildProjFile.First<string>());
                    break;
                }

                currDir = Directory.GetParent(currDir).FullName;
                //buildProjFile = Directory.EnumerateFiles(currDir, "build.proj", SearchOption.TopDirectoryOnly);
            }

            return srcRootDir;
        }

        internal string GetSourceDir()
        {
            return Path.Combine(GetSourceRootDir(), "src");
        }



        protected SDKCategorizeProjects GetCategorizedProjects(string scope)
        {
            SDKCategorizeProjects cproj = new SDKCategorizeProjects();
            cproj.SourceRootDirPath = GetSourceDir();
            cproj.BuildScope = scope;
            cproj.Execute();

            return cproj;
        }
    }
}
