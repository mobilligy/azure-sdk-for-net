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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.DataFactories.Common.Models;

namespace Microsoft.Azure.Management.DataFactories.Core.Models
{
    /// <summary>
    /// Dataset properties.
    /// </summary>
    public partial class DatasetProperties
    {
        private Availability _availability;
        
        /// <summary>
        /// Required. Scheduler of the dataset.
        /// </summary>
        public Availability Availability
        {
            get { return this._availability; }
            set { this._availability = value; }
        }
        
        private System.DateTime? _createTime;
        
        /// <summary>
        /// Optional. The time it is created.
        /// </summary>
        public System.DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }
        
        private string _description;
        
        /// <summary>
        /// Optional. dataset description.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private string _errorMessage;
        
        /// <summary>
        /// Optional. Error in processing dataset request.
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }
        
        private bool? _external;
        
        /// <summary>
        /// Optional. If set to true, the dataset is an external data set.
        /// </summary>
        public bool? External
        {
            get { return this._external; }
            set { this._external = value; }
        }
        
        private string _linkedServiceName;
        
        /// <summary>
        /// Required. The referenced data linkedService name.
        /// </summary>
        public string LinkedServiceName
        {
            get { return this._linkedServiceName; }
            set { this._linkedServiceName = value; }
        }
        
        private Policy _policy;
        
        /// <summary>
        /// Optional. Policy applied to the dataset.
        /// </summary>
        public Policy Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }
        
        private string _provisioningState;
        
        /// <summary>
        /// Optional. The provisioning state of the dataset.
        /// </summary>
        public string ProvisioningState
        {
            get { return this._provisioningState; }
            set { this._provisioningState = value; }
        }
        
        private IList<DataElement> _structure;
        
        /// <summary>
        /// Optional. Columns that define the structure of the dataset.
        /// </summary>
        public IList<DataElement> Structure
        {
            get { return this._structure; }
            set { this._structure = value; }
        }
        
        private string _type;
        
        /// <summary>
        /// Required. The type of the dataset. May be the name of a build-in
        /// ADF type or a type registered by a user and available to the data
        /// factory this dataset is a member of.
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        private string _typeProperties;
        
        /// <summary>
        /// Required. The properties specific to the dataset type.
        /// </summary>
        public string TypeProperties
        {
            get { return this._typeProperties; }
            set { this._typeProperties = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DatasetProperties class.
        /// </summary>
        public DatasetProperties()
        {
            this.Structure = new LazyList<DataElement>();
        }
    }
}