// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.BackupServices;
using Microsoft.Azure.Management.BackupServices.Models;

namespace Microsoft.Azure.Management.BackupServices
{
    /// <summary>
    /// Definition of DataSource operations for the Azure Backup extension.
    /// </summary>
    public partial interface IDataSourceOperations
    {
        /// <summary>
        /// Disable protection for given item
        /// </summary>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='containerName'>
        /// containerName.
        /// </param>
        /// <param name='itemName'>
        /// itemName.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a Operation Response.
        /// </returns>
        Task<OperationResponse> DisableProtectionCSMAsync(string resourceGroupName, string resourceName, CustomRequestHeaders customRequestHeaders, string containerName, string itemName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Enable protection for given item.
        /// </summary>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='containerName'>
        /// containerName.
        /// </param>
        /// <param name='itemName'>
        /// itemName.
        /// </param>
        /// <param name='csmparameters'>
        /// Set protection request input.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a Operation Response.
        /// </returns>
        Task<OperationResponse> EnableProtectionCSMAsync(string resourceGroupName, string resourceName, CustomRequestHeaders customRequestHeaders, string containerName, string itemName, CSMSetProtectionRequest csmparameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the list of all Datasources.
        /// </summary>
        /// <param name='csmparameters'>
        /// DataSource query parameter.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a CSMProtectedItemListOperationResponse.
        /// </returns>
        Task<CSMProtectedItemListOperationResponse> ListCSMAsync(string resourceGroupName, string resourceName, CSMProtectedItemQueryObject csmparameters, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken);
        
        /// <summary>
        /// Enable protection for given item.
        /// </summary>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='containerName'>
        /// containerName.
        /// </param>
        /// <param name='itemName'>
        /// itemName.
        /// </param>
        /// <param name='csmparameters'>
        /// Set protection request input.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The definition of a Operation Response.
        /// </returns>
        Task<OperationResponse> UpdateProtectionCSMAsync(string resourceGroupName, string resourceName, CustomRequestHeaders customRequestHeaders, string containerName, string itemName, CSMUpdateProtectionRequest csmparameters, CancellationToken cancellationToken);
    }
}
