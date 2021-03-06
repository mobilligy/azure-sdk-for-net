//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.DataFactories.Common.Models;
using Microsoft.Azure.Management.DataFactories.Models;

namespace Microsoft.Azure.Management.DataFactories
{
    /// <summary>
    /// Operations for managing data factory linkedServices.
    /// </summary>
    public static class LinkedServiceOperationsExtensions
    {
        /// <summary>
        /// Create or update a data factory linkedService.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ILinkedServiceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. The name of the data factory.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update a data
        /// factory linkedService.
        /// </param>
        /// <returns>
        /// The create or update data factory linkedService operation response.
        /// </returns>
        public static LinkedServiceCreateOrUpdateResponse BeginCreateOrUpdate(
            this ILinkedServiceOperations operations,
            string resourceGroupName,
            string dataFactoryName,
            LinkedServiceCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew(
                s => ((ILinkedServiceOperations)s).BeginCreateOrUpdateAsync(
                    resourceGroupName,
                    dataFactoryName,
                    parameters),
                operations,
                CancellationToken.None,
                TaskCreationOptions.None,
                TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create or update a data factory linkedService.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ILinkedServiceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. The name of the data factory.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update a data
        /// factory linkedService.
        /// </param>
        /// <returns>
        /// The create or update data factory linkedService operation response.
        /// </returns>
        public static Task<LinkedServiceCreateOrUpdateResponse> BeginCreateOrUpdateAsync(
            this ILinkedServiceOperations operations,
            string resourceGroupName,
            string dataFactoryName,
            LinkedServiceCreateOrUpdateParameters parameters)
        {
            return operations.BeginCreateOrUpdateAsync(
                resourceGroupName,
                dataFactoryName,
                parameters,
                CancellationToken.None);
        }

        /// <summary>
        /// Create or update a data factory linkedService with raw json content.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ILinkedServiceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. The name of the data factory.
        /// </param>
        /// <param name='linkedServiceName'>
        /// Required. The name of the data factory Linked Service to be created or
        /// updated.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update a data
        /// factory linkedService.
        /// </param>
        /// <returns>
        /// The create or update data factory linkedService operation response.
        /// </returns>
        public static LinkedServiceCreateOrUpdateResponse BeginCreateOrUpdateWithRawJsonContent(
            this ILinkedServiceOperations operations,
            string resourceGroupName,
            string dataFactoryName,
            string linkedServiceName,
            LinkedServiceCreateOrUpdateWithRawJsonContentParameters parameters)
        {
            return Task.Factory.StartNew(
                s => ((ILinkedServiceOperations)s).BeginCreateOrUpdateWithRawJsonContentAsync(
                    resourceGroupName,
                    dataFactoryName,
                    linkedServiceName,
                    parameters),
                operations,
                CancellationToken.None,
                TaskCreationOptions.None,
                TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create or update a data factory linkedService with raw json content.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ILinkedServiceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. The name of the data factory.
        /// </param>
        /// <param name='linkedServiceName'>
        /// Required. The name of the data factory Linked Service to be created or
        /// updated.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update a data
        /// factory linkedService.
        /// </param>
        /// <returns>
        /// The create or update data factory linkedService operation response.
        /// </returns>
        public static Task<LinkedServiceCreateOrUpdateResponse> BeginCreateOrUpdateWithRawJsonContentAsync(
            this ILinkedServiceOperations operations,
            string resourceGroupName,
            string dataFactoryName,
            string linkedServiceName,
            LinkedServiceCreateOrUpdateWithRawJsonContentParameters parameters)
        {
            return operations.BeginCreateOrUpdateWithRawJsonContentAsync(
                resourceGroupName,
                dataFactoryName,
                linkedServiceName,
                parameters,
                CancellationToken.None);
        }

        /// <summary>
        /// Delete a data factory linkedService instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ILinkedServiceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <param name='linkedServiceName'>
        /// Required. A unique data factory linkedService name.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResponse BeginDelete(
            this ILinkedServiceOperations operations,
            string resourceGroupName,
            string dataFactoryName,
            string linkedServiceName)
        {
            return Task.Factory.StartNew(
                s => ((ILinkedServiceOperations)s).BeginDeleteAsync(
                    resourceGroupName,
                    dataFactoryName,
                    linkedServiceName),
                operations,
                CancellationToken.None,
                TaskCreationOptions.None,
                TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a data factory linkedService instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ILinkedServiceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <param name='linkedServiceName'>
        /// Required. A unique data factory linkedService name.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResponse> BeginDeleteAsync(
            this ILinkedServiceOperations operations,
            string resourceGroupName,
            string dataFactoryName,
            string linkedServiceName)
        {
            return operations.BeginDeleteAsync(
                resourceGroupName,
                dataFactoryName,
                linkedServiceName,
                CancellationToken.None);
        }

        /// <summary>
        /// Create or update a data factory linkedService.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ILinkedServiceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. The name of the data factory.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update a data
        /// factory linkedService.
        /// </param>
        /// <returns>
        /// The create or update data factory linkedService operation response.
        /// </returns>
        public static LinkedServiceCreateOrUpdateResponse CreateOrUpdate(
            this ILinkedServiceOperations operations,
            string resourceGroupName,
            string dataFactoryName,
            LinkedServiceCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew(
                s => ((ILinkedServiceOperations)s).CreateOrUpdateAsync(
                    resourceGroupName,
                    dataFactoryName,
                    parameters),
                operations,
                CancellationToken.None,
                TaskCreationOptions.None,
                TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create or update a data factory linkedService.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ILinkedServiceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. The name of the data factory.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update a data
        /// factory linkedService.
        /// </param>
        /// <returns>
        /// The create or update data factory linkedService operation response.
        /// </returns>
        public static Task<LinkedServiceCreateOrUpdateResponse> CreateOrUpdateAsync(
            this ILinkedServiceOperations operations,
            string resourceGroupName,
            string dataFactoryName,
            LinkedServiceCreateOrUpdateParameters parameters)
        {
            return operations.CreateOrUpdateAsync(
                resourceGroupName,
                dataFactoryName,
                parameters,
                CancellationToken.None);
        }

        /// <summary>
        /// Create or update a data factory linkedService with raw json content.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ILinkedServiceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. The name of the data factory.
        /// </param>
        /// <param name='linkedServiceName'>
        /// Required. The name of the data factory Linked Service to be created or
        /// updated.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update a data
        /// factory linkedService.
        /// </param>
        /// <returns>
        /// The create or update data factory linkedService operation response.
        /// </returns>
        public static LinkedServiceCreateOrUpdateResponse CreateOrUpdateWithRawJsonContent(
            this ILinkedServiceOperations operations,
            string resourceGroupName,
            string dataFactoryName,
            string linkedServiceName,
            LinkedServiceCreateOrUpdateWithRawJsonContentParameters parameters)
        {
            return Task.Factory.StartNew(
                s => ((ILinkedServiceOperations)s).CreateOrUpdateWithRawJsonContentAsync(
                    resourceGroupName,
                    dataFactoryName,
                    linkedServiceName,
                    parameters),
                operations,
                CancellationToken.None,
                TaskCreationOptions.None,
                TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create or update a data factory linkedService with raw json content.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ILinkedServiceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. The name of the data factory.
        /// </param>
        /// <param name='linkedServiceName'>
        /// Required. The name of the data factory Linked Service to be created or
        /// updated.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update a data
        /// factory linkedService.
        /// </param>
        /// <returns>
        /// The create or update data factory linkedService operation response.
        /// </returns>
        public static Task<LinkedServiceCreateOrUpdateResponse> CreateOrUpdateWithRawJsonContentAsync(
            this ILinkedServiceOperations operations,
            string resourceGroupName,
            string dataFactoryName,
            string linkedServiceName,
            LinkedServiceCreateOrUpdateWithRawJsonContentParameters parameters)
        {
            return operations.CreateOrUpdateWithRawJsonContentAsync(
                resourceGroupName,
                dataFactoryName,
                linkedServiceName,
                parameters,
                CancellationToken.None);
        }

        /// <summary>
        /// Delete a data factory linkedService instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ILinkedServiceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <param name='linkedServiceName'>
        /// Required. A unique data factory linkedService name.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static LongRunningOperationResponse Delete(
            this ILinkedServiceOperations operations,
            string resourceGroupName,
            string dataFactoryName,
            string linkedServiceName)
        {
            return Task.Factory.StartNew(
                s => ((ILinkedServiceOperations)s).DeleteAsync(
                    resourceGroupName,
                    dataFactoryName,
                    linkedServiceName),
                operations,
                CancellationToken.None,
                TaskCreationOptions.None,
                TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a data factory linkedService instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ILinkedServiceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <param name='linkedServiceName'>
        /// Required. A unique data factory linkedService name.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        public static Task<LongRunningOperationResponse> DeleteAsync(
            this ILinkedServiceOperations operations,
            string resourceGroupName,
            string dataFactoryName,
            string linkedServiceName)
        {
            return operations.DeleteAsync(resourceGroupName, dataFactoryName, linkedServiceName, CancellationToken.None);
        }

        /// <summary>
        /// Gets a data factory linkedService instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ILinkedServiceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <param name='linkedServiceName'>
        /// Required. A unique data factory linkedService name.
        /// </param>
        /// <returns>
        /// The Get data factory linkedService operation response.
        /// </returns>
        public static LinkedServiceGetResponse Get(
            this ILinkedServiceOperations operations,
            string resourceGroupName,
            string dataFactoryName,
            string linkedServiceName)
        {
            return Task.Factory.StartNew(
                s => ((ILinkedServiceOperations)s).GetAsync(
                    resourceGroupName,
                    dataFactoryName,
                    linkedServiceName),
                operations,
                CancellationToken.None,
                TaskCreationOptions.None,
                TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets a data factory linkedService instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ILinkedServiceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <param name='linkedServiceName'>
        /// Required. A unique data factory linkedService name.
        /// </param>
        /// <returns>
        /// The Get data factory linkedService operation response.
        /// </returns>
        public static Task<LinkedServiceGetResponse> GetAsync(
            this ILinkedServiceOperations operations,
            string resourceGroupName,
            string dataFactoryName,
            string linkedServiceName)
        {
            return operations.GetAsync(resourceGroupName, dataFactoryName, linkedServiceName, CancellationToken.None);
        }

        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ILinkedServiceOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation.
        /// </param>
        /// <returns>
        /// The create or update data factory linkedService operation response.
        /// </returns>
        public static LinkedServiceCreateOrUpdateResponse GetCreateOrUpdateStatus(
            this ILinkedServiceOperations operations,
            string operationStatusLink)
        {
            return Task.Factory.StartNew(
                s => ((ILinkedServiceOperations)s).GetCreateOrUpdateStatusAsync(operationStatusLink),
                operations,
                CancellationToken.None,
                TaskCreationOptions.None,
                TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ILinkedServiceOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation.
        /// </param>
        /// <returns>
        /// The create or update data factory linkedService operation response.
        /// </returns>
        public static Task<LinkedServiceCreateOrUpdateResponse> GetCreateOrUpdateStatusAsync(
            this ILinkedServiceOperations operations,
            string operationStatusLink)
        {
            return operations.GetCreateOrUpdateStatusAsync(operationStatusLink, CancellationToken.None);
        }

        /// <summary>
        /// Gets the first page of linked service instances with the link to
        /// the next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ILinkedServiceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <returns>
        /// The List data factory linkedServices operation response.
        /// </returns>
        public static LinkedServiceListResponse List(
            this ILinkedServiceOperations operations,
            string resourceGroupName,
            string dataFactoryName)
        {
            return Task.Factory.StartNew(
                s => ((ILinkedServiceOperations)s).ListAsync(resourceGroupName, dataFactoryName),
                operations,
                CancellationToken.None,
                TaskCreationOptions.None,
                TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the first page of linked service instances with the link to
        /// the next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ILinkedServiceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <returns>
        /// The List data factory linkedServices operation response.
        /// </returns>
        public static Task<LinkedServiceListResponse> ListAsync(
            this ILinkedServiceOperations operations,
            string resourceGroupName,
            string dataFactoryName)
        {
            return operations.ListAsync(resourceGroupName, dataFactoryName, CancellationToken.None);
        }

        /// <summary>
        /// Gets the next page of linked service instances with the link to the
        /// next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ILinkedServiceOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The url to the next linked services page.
        /// </param>
        /// <returns>
        /// The List data factory linkedServices operation response.
        /// </returns>
        public static LinkedServiceListResponse ListNext(this ILinkedServiceOperations operations, string nextLink)
        {
            return Task.Factory.StartNew(
                s => ((ILinkedServiceOperations)s).ListNextAsync(nextLink),
                operations,
                CancellationToken.None,
                TaskCreationOptions.None,
                TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the next page of linked service instances with the link to the
        /// next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.ILinkedServiceOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The url to the next linked services page.
        /// </param>
        /// <returns>
        /// The List data factory linkedServices operation response.
        /// </returns>
        public static Task<LinkedServiceListResponse> ListNextAsync(
            this ILinkedServiceOperations operations,
            string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }
    }
}