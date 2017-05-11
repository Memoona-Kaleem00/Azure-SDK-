// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A specification for uploading files from an Azure Batch node to another location after the Batch service has finished 
    /// executing the task process.
    /// </summary>
    public partial class OutputFile : ITransportObjectProvider<Models.OutputFile>, IPropertyMetadata
    {
        private readonly OutputFileDestination destination;
        private readonly string filePattern;
        private readonly OutputFileUploadOptions uploadOptions;

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="OutputFile"/> class.
        /// </summary>
        /// <param name='filePattern'>A pattern indicating which file(s) to upload.</param>
        /// <param name='destination'>The destination for the output file(s).</param>
        /// <param name='uploadOptions'>Additional options for the upload operation, including under what conditions to perform the upload.</param>
        public OutputFile(
            string filePattern,
            OutputFileDestination destination,
            OutputFileUploadOptions uploadOptions)
        {
            this.filePattern = filePattern;
            this.destination = destination;
            this.uploadOptions = uploadOptions;
        }

        internal OutputFile(Models.OutputFile protocolObject)
        {
            this.destination = UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.Destination, o => new OutputFileDestination(o).Freeze());
            this.filePattern = protocolObject.FilePattern;
            this.uploadOptions = UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.UploadOptions, o => new OutputFileUploadOptions(o).Freeze());
        }

        #endregion Constructors

        #region OutputFile

        /// <summary>
        /// Gets the destination for the output file(s).
        /// </summary>
        public OutputFileDestination Destination
        {
            get { return this.destination; }
        }

        /// <summary>
        /// Gets a pattern indicating which file(s) to upload.
        /// </summary>
        /// <remarks>
        /// Both relative and absolute paths are supported. Relative paths are relative to the task working directory. For 
        /// wildcards, use * to match any character and ** to match any directory. For example, **\*.txt matches any file 
        /// ending in .txt in the task working directory or any subdirectory. Note that \ and / are treated interchangeably 
        /// and mapped to the correct directory separator on the compute node operating system.
        /// </remarks>
        public string FilePattern
        {
            get { return this.filePattern; }
        }

        /// <summary>
        /// Gets additional options for the upload operation, including under what conditions to perform the upload.
        /// </summary>
        public OutputFileUploadOptions UploadOptions
        {
            get { return this.uploadOptions; }
        }

        #endregion // OutputFile

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata

        #region Internal/private methods

        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.OutputFile ITransportObjectProvider<Models.OutputFile>.GetTransportObject()
        {
            Models.OutputFile result = new Models.OutputFile()
            {
                Destination = UtilitiesInternal.CreateObjectWithNullCheck(this.Destination, (o) => o.GetTransportObject()),
                FilePattern = this.FilePattern,
                UploadOptions = UtilitiesInternal.CreateObjectWithNullCheck(this.UploadOptions, (o) => o.GetTransportObject()),
            };

            return result;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects.
        /// </summary>
        internal static IList<OutputFile> ConvertFromProtocolCollection(IEnumerable<Models.OutputFile> protoCollection)
        {
            ConcurrentChangeTrackedModifiableList<OutputFile> converted = UtilitiesInternal.CollectionToThreadSafeCollectionIModifiable(
                items: protoCollection,
                objectCreationFunc: o => new OutputFile(o));

            return converted;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects, in a frozen state.
        /// </summary>
        internal static IList<OutputFile> ConvertFromProtocolCollectionAndFreeze(IEnumerable<Models.OutputFile> protoCollection)
        {
            ConcurrentChangeTrackedModifiableList<OutputFile> converted = UtilitiesInternal.CollectionToThreadSafeCollectionIModifiable(
                items: protoCollection,
                objectCreationFunc: o => new OutputFile(o).Freeze());

            converted = UtilitiesInternal.CreateObjectWithNullCheck(converted, o => o.Freeze());

            return converted;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects, with each object marked readonly
        /// and returned as a readonly collection.
        /// </summary>
        internal static IReadOnlyList<OutputFile> ConvertFromProtocolCollectionReadOnly(IEnumerable<Models.OutputFile> protoCollection)
        {
            IReadOnlyList<OutputFile> converted =
                UtilitiesInternal.CreateObjectWithNullCheck(
                    UtilitiesInternal.CollectionToNonThreadSafeCollection(
                        items: protoCollection,
                        objectCreationFunc: o => new OutputFile(o).Freeze()), o => o.AsReadOnly());

            return converted;
        }

        #endregion // Internal/private methods
    }
}