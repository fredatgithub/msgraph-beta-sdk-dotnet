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
    /// The type Unified Role Eligibility Request.
    /// </summary>
    public partial class UnifiedRoleEligibilityRequestObject : RequestObject
    {
    
		///<summary>
		/// The UnifiedRoleEligibilityRequest constructor
		///</summary>
        public UnifiedRoleEligibilityRequestObject()
        {
            this.ODataType = "microsoft.graph.unifiedRoleEligibilityRequest";
        }
	
        /// <summary>
        /// Gets or sets action.
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }
    
        /// <summary>
        /// Gets or sets app scope id.
        /// </summary>
        [JsonPropertyName("appScopeId")]
        public string AppScopeId { get; set; }
    
        /// <summary>
        /// Gets or sets directory scope id.
        /// </summary>
        [JsonPropertyName("directoryScopeId")]
        public string DirectoryScopeId { get; set; }
    
        /// <summary>
        /// Gets or sets is validation only.
        /// </summary>
        [JsonPropertyName("isValidationOnly")]
        public bool? IsValidationOnly { get; set; }
    
        /// <summary>
        /// Gets or sets justification.
        /// </summary>
        [JsonPropertyName("justification")]
        public string Justification { get; set; }
    
        /// <summary>
        /// Gets or sets principal id.
        /// </summary>
        [JsonPropertyName("principalId")]
        public string PrincipalId { get; set; }
    
        /// <summary>
        /// Gets or sets role definition id.
        /// </summary>
        [JsonPropertyName("roleDefinitionId")]
        public string RoleDefinitionId { get; set; }
    
        /// <summary>
        /// Gets or sets schedule info.
        /// </summary>
        [JsonPropertyName("scheduleInfo")]
        public RequestSchedule ScheduleInfo { get; set; }
    
        /// <summary>
        /// Gets or sets target schedule id.
        /// </summary>
        [JsonPropertyName("targetScheduleId")]
        public string TargetScheduleId { get; set; }
    
        /// <summary>
        /// Gets or sets ticket info.
        /// </summary>
        [JsonPropertyName("ticketInfo")]
        public TicketInfo TicketInfo { get; set; }
    
        /// <summary>
        /// Gets or sets app scope.
        /// </summary>
        [JsonPropertyName("appScope")]
        public AppScope AppScope { get; set; }
    
        /// <summary>
        /// Gets or sets directory scope.
        /// </summary>
        [JsonPropertyName("directoryScope")]
        public DirectoryObject DirectoryScope { get; set; }
    
        /// <summary>
        /// Gets or sets principal.
        /// </summary>
        [JsonPropertyName("principal")]
        public DirectoryObject Principal { get; set; }
    
        /// <summary>
        /// Gets or sets role definition.
        /// </summary>
        [JsonPropertyName("roleDefinition")]
        public UnifiedRoleDefinition RoleDefinition { get; set; }
    
        /// <summary>
        /// Gets or sets target schedule.
        /// </summary>
        [JsonPropertyName("targetSchedule")]
        public UnifiedRoleEligibilitySchedule TargetSchedule { get; set; }
    
    }
}

