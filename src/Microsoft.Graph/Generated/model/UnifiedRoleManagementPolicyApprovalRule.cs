// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Unified Role Management Policy Approval Rule.
    /// </summary>
    public partial class UnifiedRoleManagementPolicyApprovalRule : UnifiedRoleManagementPolicyRule
    {
    
		///<summary>
		/// The UnifiedRoleManagementPolicyApprovalRule constructor
		///</summary>
        public UnifiedRoleManagementPolicyApprovalRule()
        {
            this.ODataType = "microsoft.graph.unifiedRoleManagementPolicyApprovalRule";
        }
	
        /// <summary>
        /// Gets or sets setting.
        /// </summary>
        [JsonPropertyName("setting")]
        public ApprovalSettings Setting { get; set; }
    
    }
}

