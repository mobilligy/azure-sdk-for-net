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
using Microsoft.WindowsAzure.Management.TrafficManager.Models;

namespace Microsoft.WindowsAzure.Management.TrafficManager.Models
{
    /// <summary>
    /// Specifies a monitoring policy.
    /// </summary>
    public partial class DefinitionPolicyCreateParameters
    {
        private IList<DefinitionEndpointCreateParameters> _endpoints;
        
        /// <summary>
        /// Required. Encapsulates the list of Windows Azure Traffic Manager
        /// endpoints. You can define up to 100 endpoints in the list. If the
        /// load balancing method is set to Failover, traffic to the endpoints
        /// is load balanced in the sequential order in which the endpoints
        /// are defined.
        /// </summary>
        public IList<DefinitionEndpointCreateParameters> Endpoints
        {
            get
            {
                if (this._endpoints == null)
                {
                    this._endpoints = new List<DefinitionEndpointCreateParameters>();
                }
                return this._endpoints;
            }
            set { this._endpoints = value; }
        }
        
        /// <summary>
        /// Required. Encapsulates the list of Windows Azure Traffic Manager
        /// endpoints. You can define up to 100 endpoints in the list. If the
        /// load balancing method is set to Failover, traffic to the endpoints
        /// is load balanced in the sequential order in which the endpoints
        /// are defined.
        /// </summary>
        public IList<DefinitionEndpointCreateParameters> EndpointsValue
        {
            get { return this._endpoints; }
            set { this._endpoints = value; }
        }
        
        private LoadBalancingMethod _loadBalancingMethod;
        
        /// <summary>
        /// Required. Specifies the load balancing method to use to distribute
        /// connections.
        /// </summary>
        public LoadBalancingMethod LoadBalancingMethod
        {
            get { return this._loadBalancingMethod; }
            set { this._loadBalancingMethod = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DefinitionPolicyCreateParameters
        /// class.
        /// </summary>
        public DefinitionPolicyCreateParameters()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the DefinitionPolicyCreateParameters
        /// class with required arguments.
        /// </summary>
        public DefinitionPolicyCreateParameters(LoadBalancingMethod loadBalancingMethod, IList<DefinitionEndpointCreateParameters> endpoints)
            : this()
        {
            if (endpoints == null)
            {
                throw new ArgumentNullException("endpoints");
            }
            this.LoadBalancingMethod = loadBalancingMethod;
            this.EndpointsValue = endpoints;
        }
    }
}