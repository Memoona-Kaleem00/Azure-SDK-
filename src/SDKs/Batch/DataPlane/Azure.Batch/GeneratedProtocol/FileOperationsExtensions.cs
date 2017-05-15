// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for FileOperations.
    /// </summary>
    public static partial class FileOperationsExtensions
    {
            /// <summary>
            /// Deletes the specified task file from the compute node where the task ran.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The ID of the job that contains the task.
            /// </param>
            /// <param name='taskId'>
            /// The ID of the task whose file you want to delete.
            /// </param>
            /// <param name='filePath'>
            /// The path to the task file that you want to delete.
            /// </param>
            /// <param name='recursive'>
            /// Whether to delete children of a directory. If the filePath parameter
            /// represents a directory instead of a file, you can set recursive to true to
            /// delete the directory and all of the files and subdirectories in it. If
            /// recursive is false then the directory must be empty or deletion will fail.
            /// </param>
            /// <param name='fileDeleteFromTaskOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static FileDeleteFromTaskHeaders DeleteFromTask(this IFileOperations operations, string jobId, string taskId, string filePath, bool? recursive = default(bool?), FileDeleteFromTaskOptions fileDeleteFromTaskOptions = default(FileDeleteFromTaskOptions))
            {
                return ((IFileOperations)operations).DeleteFromTaskAsync(jobId, taskId, filePath, recursive, fileDeleteFromTaskOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified task file from the compute node where the task ran.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The ID of the job that contains the task.
            /// </param>
            /// <param name='taskId'>
            /// The ID of the task whose file you want to delete.
            /// </param>
            /// <param name='filePath'>
            /// The path to the task file that you want to delete.
            /// </param>
            /// <param name='recursive'>
            /// Whether to delete children of a directory. If the filePath parameter
            /// represents a directory instead of a file, you can set recursive to true to
            /// delete the directory and all of the files and subdirectories in it. If
            /// recursive is false then the directory must be empty or deletion will fail.
            /// </param>
            /// <param name='fileDeleteFromTaskOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<FileDeleteFromTaskHeaders> DeleteFromTaskAsync(this IFileOperations operations, string jobId, string taskId, string filePath, bool? recursive = default(bool?), FileDeleteFromTaskOptions fileDeleteFromTaskOptions = default(FileDeleteFromTaskOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.DeleteFromTaskWithHttpMessagesAsync(jobId, taskId, filePath, recursive, fileDeleteFromTaskOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Returns the content of the specified task file.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The ID of the job that contains the task.
            /// </param>
            /// <param name='taskId'>
            /// The ID of the task whose file you want to retrieve.
            /// </param>
            /// <param name='filePath'>
            /// The path to the task file that you want to get the content of.
            /// </param>
            /// <param name='fileGetFromTaskOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static System.IO.Stream GetFromTask(this IFileOperations operations, string jobId, string taskId, string filePath, FileGetFromTaskOptions fileGetFromTaskOptions = default(FileGetFromTaskOptions))
            {
                return ((IFileOperations)operations).GetFromTaskAsync(jobId, taskId, filePath, fileGetFromTaskOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the content of the specified task file.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The ID of the job that contains the task.
            /// </param>
            /// <param name='taskId'>
            /// The ID of the task whose file you want to retrieve.
            /// </param>
            /// <param name='filePath'>
            /// The path to the task file that you want to get the content of.
            /// </param>
            /// <param name='fileGetFromTaskOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<System.IO.Stream> GetFromTaskAsync(this IFileOperations operations, string jobId, string taskId, string filePath, FileGetFromTaskOptions fileGetFromTaskOptions = default(FileGetFromTaskOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                var _result = await operations.GetFromTaskWithHttpMessagesAsync(jobId, taskId, filePath, fileGetFromTaskOptions, null, cancellationToken).ConfigureAwait(false);
                _result.Request.Dispose();
                return _result.Body;
            }

            /// <summary>
            /// Gets the properties of the specified task file.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The ID of the job that contains the task.
            /// </param>
            /// <param name='taskId'>
            /// The ID of the task whose file you want to get the properties of.
            /// </param>
            /// <param name='filePath'>
            /// The path to the task file that you want to get the properties of.
            /// </param>
            /// <param name='fileGetPropertiesFromTaskOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static FileGetPropertiesFromTaskHeaders GetPropertiesFromTask(this IFileOperations operations, string jobId, string taskId, string filePath, FileGetPropertiesFromTaskOptions fileGetPropertiesFromTaskOptions = default(FileGetPropertiesFromTaskOptions))
            {
                return ((IFileOperations)operations).GetPropertiesFromTaskAsync(jobId, taskId, filePath, fileGetPropertiesFromTaskOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the properties of the specified task file.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The ID of the job that contains the task.
            /// </param>
            /// <param name='taskId'>
            /// The ID of the task whose file you want to get the properties of.
            /// </param>
            /// <param name='filePath'>
            /// The path to the task file that you want to get the properties of.
            /// </param>
            /// <param name='fileGetPropertiesFromTaskOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<FileGetPropertiesFromTaskHeaders> GetPropertiesFromTaskAsync(this IFileOperations operations, string jobId, string taskId, string filePath, FileGetPropertiesFromTaskOptions fileGetPropertiesFromTaskOptions = default(FileGetPropertiesFromTaskOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetPropertiesFromTaskWithHttpMessagesAsync(jobId, taskId, filePath, fileGetPropertiesFromTaskOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Deletes the specified file from the compute node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The ID of the pool that contains the compute node.
            /// </param>
            /// <param name='nodeId'>
            /// The ID of the compute node from which you want to delete the file.
            /// </param>
            /// <param name='filePath'>
            /// The path to the file that you want to delete.
            /// </param>
            /// <param name='recursive'>
            /// Whether to delete children of a directory. If the filePath parameter
            /// represents a directory instead of a file, you can set recursive to true to
            /// delete the directory and all of the files and subdirectories in it. If
            /// recursive is false then the directory must be empty or deletion will fail.
            /// </param>
            /// <param name='fileDeleteFromComputeNodeOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static FileDeleteFromComputeNodeHeaders DeleteFromComputeNode(this IFileOperations operations, string poolId, string nodeId, string filePath, bool? recursive = default(bool?), FileDeleteFromComputeNodeOptions fileDeleteFromComputeNodeOptions = default(FileDeleteFromComputeNodeOptions))
            {
                return ((IFileOperations)operations).DeleteFromComputeNodeAsync(poolId, nodeId, filePath, recursive, fileDeleteFromComputeNodeOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified file from the compute node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The ID of the pool that contains the compute node.
            /// </param>
            /// <param name='nodeId'>
            /// The ID of the compute node from which you want to delete the file.
            /// </param>
            /// <param name='filePath'>
            /// The path to the file that you want to delete.
            /// </param>
            /// <param name='recursive'>
            /// Whether to delete children of a directory. If the filePath parameter
            /// represents a directory instead of a file, you can set recursive to true to
            /// delete the directory and all of the files and subdirectories in it. If
            /// recursive is false then the directory must be empty or deletion will fail.
            /// </param>
            /// <param name='fileDeleteFromComputeNodeOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<FileDeleteFromComputeNodeHeaders> DeleteFromComputeNodeAsync(this IFileOperations operations, string poolId, string nodeId, string filePath, bool? recursive = default(bool?), FileDeleteFromComputeNodeOptions fileDeleteFromComputeNodeOptions = default(FileDeleteFromComputeNodeOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.DeleteFromComputeNodeWithHttpMessagesAsync(poolId, nodeId, filePath, recursive, fileDeleteFromComputeNodeOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Returns the content of the specified compute node file.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The ID of the pool that contains the compute node.
            /// </param>
            /// <param name='nodeId'>
            /// The ID of the compute node that contains the file.
            /// </param>
            /// <param name='filePath'>
            /// The path to the compute node file that you want to get the content of.
            /// </param>
            /// <param name='fileGetFromComputeNodeOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static System.IO.Stream GetFromComputeNode(this IFileOperations operations, string poolId, string nodeId, string filePath, FileGetFromComputeNodeOptions fileGetFromComputeNodeOptions = default(FileGetFromComputeNodeOptions))
            {
                return ((IFileOperations)operations).GetFromComputeNodeAsync(poolId, nodeId, filePath, fileGetFromComputeNodeOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the content of the specified compute node file.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The ID of the pool that contains the compute node.
            /// </param>
            /// <param name='nodeId'>
            /// The ID of the compute node that contains the file.
            /// </param>
            /// <param name='filePath'>
            /// The path to the compute node file that you want to get the content of.
            /// </param>
            /// <param name='fileGetFromComputeNodeOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<System.IO.Stream> GetFromComputeNodeAsync(this IFileOperations operations, string poolId, string nodeId, string filePath, FileGetFromComputeNodeOptions fileGetFromComputeNodeOptions = default(FileGetFromComputeNodeOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                var _result = await operations.GetFromComputeNodeWithHttpMessagesAsync(poolId, nodeId, filePath, fileGetFromComputeNodeOptions, null, cancellationToken).ConfigureAwait(false);
                _result.Request.Dispose();
                return _result.Body;
            }

            /// <summary>
            /// Gets the properties of the specified compute node file.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The ID of the pool that contains the compute node.
            /// </param>
            /// <param name='nodeId'>
            /// The ID of the compute node that contains the file.
            /// </param>
            /// <param name='filePath'>
            /// The path to the compute node file that you want to get the properties of.
            /// </param>
            /// <param name='fileGetPropertiesFromComputeNodeOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static FileGetPropertiesFromComputeNodeHeaders GetPropertiesFromComputeNode(this IFileOperations operations, string poolId, string nodeId, string filePath, FileGetPropertiesFromComputeNodeOptions fileGetPropertiesFromComputeNodeOptions = default(FileGetPropertiesFromComputeNodeOptions))
            {
                return ((IFileOperations)operations).GetPropertiesFromComputeNodeAsync(poolId, nodeId, filePath, fileGetPropertiesFromComputeNodeOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the properties of the specified compute node file.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The ID of the pool that contains the compute node.
            /// </param>
            /// <param name='nodeId'>
            /// The ID of the compute node that contains the file.
            /// </param>
            /// <param name='filePath'>
            /// The path to the compute node file that you want to get the properties of.
            /// </param>
            /// <param name='fileGetPropertiesFromComputeNodeOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<FileGetPropertiesFromComputeNodeHeaders> GetPropertiesFromComputeNodeAsync(this IFileOperations operations, string poolId, string nodeId, string filePath, FileGetPropertiesFromComputeNodeOptions fileGetPropertiesFromComputeNodeOptions = default(FileGetPropertiesFromComputeNodeOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetPropertiesFromComputeNodeWithHttpMessagesAsync(poolId, nodeId, filePath, fileGetPropertiesFromComputeNodeOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Lists the files in a task's directory on its compute node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The ID of the job that contains the task.
            /// </param>
            /// <param name='taskId'>
            /// The ID of the task whose files you want to list.
            /// </param>
            /// <param name='recursive'>
            /// Whether to list children of a directory. This parameter can be used in
            /// combination with the filter parameter to list specific type of files.
            /// </param>
            /// <param name='fileListFromTaskOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static Microsoft.Rest.Azure.IPage<NodeFile> ListFromTask(this IFileOperations operations, string jobId, string taskId, bool? recursive = default(bool?), FileListFromTaskOptions fileListFromTaskOptions = default(FileListFromTaskOptions))
            {
                return ((IFileOperations)operations).ListFromTaskAsync(jobId, taskId, recursive, fileListFromTaskOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the files in a task's directory on its compute node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The ID of the job that contains the task.
            /// </param>
            /// <param name='taskId'>
            /// The ID of the task whose files you want to list.
            /// </param>
            /// <param name='recursive'>
            /// Whether to list children of a directory. This parameter can be used in
            /// combination with the filter parameter to list specific type of files.
            /// </param>
            /// <param name='fileListFromTaskOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<NodeFile>> ListFromTaskAsync(this IFileOperations operations, string jobId, string taskId, bool? recursive = default(bool?), FileListFromTaskOptions fileListFromTaskOptions = default(FileListFromTaskOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListFromTaskWithHttpMessagesAsync(jobId, taskId, recursive, fileListFromTaskOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all of the files in task directories on the specified compute node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The ID of the pool that contains the compute node.
            /// </param>
            /// <param name='nodeId'>
            /// The ID of the compute node whose files you want to list.
            /// </param>
            /// <param name='recursive'>
            /// Whether to list children of a directory.
            /// </param>
            /// <param name='fileListFromComputeNodeOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static Microsoft.Rest.Azure.IPage<NodeFile> ListFromComputeNode(this IFileOperations operations, string poolId, string nodeId, bool? recursive = default(bool?), FileListFromComputeNodeOptions fileListFromComputeNodeOptions = default(FileListFromComputeNodeOptions))
            {
                return ((IFileOperations)operations).ListFromComputeNodeAsync(poolId, nodeId, recursive, fileListFromComputeNodeOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the files in task directories on the specified compute node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The ID of the pool that contains the compute node.
            /// </param>
            /// <param name='nodeId'>
            /// The ID of the compute node whose files you want to list.
            /// </param>
            /// <param name='recursive'>
            /// Whether to list children of a directory.
            /// </param>
            /// <param name='fileListFromComputeNodeOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<NodeFile>> ListFromComputeNodeAsync(this IFileOperations operations, string poolId, string nodeId, bool? recursive = default(bool?), FileListFromComputeNodeOptions fileListFromComputeNodeOptions = default(FileListFromComputeNodeOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListFromComputeNodeWithHttpMessagesAsync(poolId, nodeId, recursive, fileListFromComputeNodeOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the files in a task's directory on its compute node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='fileListFromTaskNextOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static Microsoft.Rest.Azure.IPage<NodeFile> ListFromTaskNext(this IFileOperations operations, string nextPageLink, FileListFromTaskNextOptions fileListFromTaskNextOptions = default(FileListFromTaskNextOptions))
            {
                return ((IFileOperations)operations).ListFromTaskNextAsync(nextPageLink, fileListFromTaskNextOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the files in a task's directory on its compute node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='fileListFromTaskNextOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<NodeFile>> ListFromTaskNextAsync(this IFileOperations operations, string nextPageLink, FileListFromTaskNextOptions fileListFromTaskNextOptions = default(FileListFromTaskNextOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListFromTaskNextWithHttpMessagesAsync(nextPageLink, fileListFromTaskNextOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all of the files in task directories on the specified compute node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='fileListFromComputeNodeNextOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static Microsoft.Rest.Azure.IPage<NodeFile> ListFromComputeNodeNext(this IFileOperations operations, string nextPageLink, FileListFromComputeNodeNextOptions fileListFromComputeNodeNextOptions = default(FileListFromComputeNodeNextOptions))
            {
                return ((IFileOperations)operations).ListFromComputeNodeNextAsync(nextPageLink, fileListFromComputeNodeNextOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the files in task directories on the specified compute node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='fileListFromComputeNodeNextOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<NodeFile>> ListFromComputeNodeNextAsync(this IFileOperations operations, string nextPageLink, FileListFromComputeNodeNextOptions fileListFromComputeNodeNextOptions = default(FileListFromComputeNodeNextOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListFromComputeNodeNextWithHttpMessagesAsync(nextPageLink, fileListFromComputeNodeNextOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
