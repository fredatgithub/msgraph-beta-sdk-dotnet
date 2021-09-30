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
    /// The type Subject Rights Request.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SubjectRightsRequestObject>))]
    public partial class SubjectRightsRequestObject : Entity
    {
    
        /// <summary>
        /// Gets or sets assigned to.
        /// </summary>
        [JsonPropertyName("assignedTo")]
        public Identity AssignedTo { get; set; }
    
        /// <summary>
        /// Gets or sets closed date time.
        /// </summary>
        [JsonPropertyName("closedDateTime")]
        public DateTimeOffset? ClosedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets created by.
        /// </summary>
        [JsonPropertyName("createdBy")]
        public IdentitySet CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets data subject.
        /// </summary>
        [JsonPropertyName("dataSubject")]
        public DataSubject DataSubject { get; set; }
    
        /// <summary>
        /// Gets or sets data subject type.
        /// </summary>
        [JsonPropertyName("dataSubjectType")]
        public DataSubjectType? DataSubjectType { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets history.
        /// </summary>
        [JsonPropertyName("history")]
        public IEnumerable<SubjectRightsRequestHistory> History { get; set; }
    
        /// <summary>
        /// Gets or sets insight.
        /// </summary>
        [JsonPropertyName("insight")]
        public SubjectRightsRequestDetail Insight { get; set; }
    
        /// <summary>
        /// Gets or sets internal due date time.
        /// </summary>
        [JsonPropertyName("internalDueDateTime")]
        public DateTimeOffset? InternalDueDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last modified by.
        /// </summary>
        [JsonPropertyName("lastModifiedBy")]
        public IdentitySet LastModifiedBy { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets regulations.
        /// </summary>
        [JsonPropertyName("regulations")]
        public IEnumerable<string> Regulations { get; set; }
    
        /// <summary>
        /// Gets or sets stages.
        /// </summary>
        [JsonPropertyName("stages")]
        public IEnumerable<SubjectRightsRequestStageDetail> Stages { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [JsonPropertyName("status")]
        public SubjectRightsRequestStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// </summary>
        [JsonPropertyName("type")]
        public SubjectRightsRequestType? Type { get; set; }
    
        /// <summary>
        /// Gets or sets notes.
        /// </summary>
        [JsonPropertyName("notes")]
        public ISubjectRightsRequestNotesCollectionPage Notes { get; set; }

        /// <summary>
        /// Gets or sets notesNextLink.
        /// </summary>
        [JsonPropertyName("notes@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string NotesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets team.
        /// </summary>
        [JsonPropertyName("team")]
        public Team Team { get; set; }
    
    }
}

