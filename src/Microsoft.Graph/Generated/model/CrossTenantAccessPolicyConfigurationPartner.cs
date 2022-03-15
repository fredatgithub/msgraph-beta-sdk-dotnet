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
    /// The type Cross Tenant Access Policy Configuration Partner.
    /// </summary>
    public partial class CrossTenantAccessPolicyConfigurationPartner : CrossTenantAccessPolicyConfigurationBase
    {
    
        ///<summary>
        /// The CrossTenantAccessPolicyConfigurationPartner constructor
        ///</summary>
        public CrossTenantAccessPolicyConfigurationPartner()
        {
            this.ODataType = "microsoft.graph.crossTenantAccessPolicyConfigurationPartner";
        }

        /// <summary>
        /// Gets or sets is service provider.
        /// Identifies whether the partner-specific configuration is a Cloud Service Provider for your organization.
        /// </summary>
        [JsonPropertyName("isServiceProvider")]
        public bool? IsServiceProvider { get; set; }
    
        /// <summary>
        /// Gets or sets tenant id.
        /// The tenant identifier for the partner Azure AD organization. Read-only. Key.
        /// </summary>
        [JsonPropertyName("tenantId")]
        public string TenantId { get; set; }
    
    }
}

