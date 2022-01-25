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
    /// The type Governance Role Assignment Request.
    /// </summary>
    public partial class GovernanceRoleAssignmentRequestObject : Entity
    {
    
        /// <summary>
        /// Gets or sets assignment state.
        /// Required. The state of the assignment. The possible values are: Eligible (for eligible assignment),  Active (if it is directly assigned), Active (by administrators, or activated on an eligible assignment by the users).
        /// </summary>
        [JsonPropertyName("assignmentState")]
        public string AssignmentState { get; set; }
    
        /// <summary>
        /// Gets or sets linked eligible role assignment id.
        /// If this is a request for role activation, it represents the id of the eligible assignment being referred; Otherwise, the value is null.
        /// </summary>
        [JsonPropertyName("linkedEligibleRoleAssignmentId")]
        public string LinkedEligibleRoleAssignmentId { get; set; }
    
        /// <summary>
        /// Gets or sets reason.
        /// A message provided by users and administrators when create the request about why it is needed.
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }
    
        /// <summary>
        /// Gets or sets requested date time.
        /// Read-only. The request create time. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [JsonPropertyName("requestedDateTime")]
        public DateTimeOffset? RequestedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets resource id.
        /// Required. The unique identifier of the Azure resource that is associated with the role assignment request. Azure resources can include subscriptions, resource groups, virtual machines, and SQL databases.
        /// </summary>
        [JsonPropertyName("resourceId")]
        public string ResourceId { get; set; }
    
        /// <summary>
        /// Gets or sets role definition id.
        /// Required. The identifier of the Azure role definition that the role assignment request is associated with.
        /// </summary>
        [JsonPropertyName("roleDefinitionId")]
        public string RoleDefinitionId { get; set; }
    
        /// <summary>
        /// Gets or sets schedule.
        /// The schedule object of the role assignment request.
        /// </summary>
        [JsonPropertyName("schedule")]
        public GovernanceSchedule Schedule { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// The status of the role assignment request.
        /// </summary>
        [JsonPropertyName("status")]
        public GovernanceRoleAssignmentRequestStatus Status { get; set; }
    
        /// <summary>
        /// Gets or sets subject id.
        /// Required. The unique identifier of the principal or subject that the role assignment request is associated with. Principals can be users, groups, or service principals.
        /// </summary>
        [JsonPropertyName("subjectId")]
        public string SubjectId { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// Required. Representing the type of the operation on the role assignment. The possible values are: AdminAdd , UserAdd , AdminUpdate , AdminRemove , UserRemove , UserExtend , AdminExtend , UserRenew , AdminRenew.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
        /// <summary>
        /// Gets or sets resource.
        /// Read-only. The resource that the request aims to.
        /// </summary>
        [JsonPropertyName("resource")]
        public GovernanceResource Resource { get; set; }
    
        /// <summary>
        /// Gets or sets role definition.
        /// Read-only. The role definition that the request aims to.
        /// </summary>
        [JsonPropertyName("roleDefinition")]
        public GovernanceRoleDefinition RoleDefinition { get; set; }
    
        /// <summary>
        /// Gets or sets subject.
        /// Read-only. The user/group principal.
        /// </summary>
        [JsonPropertyName("subject")]
        public GovernanceSubject Subject { get; set; }
    
    }
}

