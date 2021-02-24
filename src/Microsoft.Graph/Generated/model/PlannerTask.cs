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
    /// The type Planner Task.
    /// </summary>
    public partial class PlannerTask : PlannerDelta
    {
    
		///<summary>
		/// The PlannerTask constructor
		///</summary>
        public PlannerTask()
        {
            this.ODataType = "microsoft.graph.plannerTask";
        }
	
        /// <summary>
        /// Gets or sets active checklist item count.
        /// Number of checklist items with value set to false, representing incomplete items.
        /// </summary>
        [JsonPropertyName("activeChecklistItemCount")]
        public Int32? ActiveChecklistItemCount { get; set; }
    
        /// <summary>
        /// Gets or sets applied categories.
        /// The categories to which the task has been applied. See applied Categories for possible values.
        /// </summary>
        [JsonPropertyName("appliedCategories")]
        public PlannerAppliedCategories AppliedCategories { get; set; }
    
        /// <summary>
        /// Gets or sets assignee priority.
        /// Hint used to order items of this type in a list view. The format is defined as outlined here.
        /// </summary>
        [JsonPropertyName("assigneePriority")]
        public string AssigneePriority { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// The set of assignees the task is assigned to.
        /// </summary>
        [JsonPropertyName("assignments")]
        public PlannerAssignments Assignments { get; set; }
    
        /// <summary>
        /// Gets or sets bucket id.
        /// Bucket ID to which the task belongs. The bucket needs to be in the plan that the task is in. It is 28 characters long and case-sensitive. Format validation is done on the service.
        /// </summary>
        [JsonPropertyName("bucketId")]
        public string BucketId { get; set; }
    
        /// <summary>
        /// Gets or sets checklist item count.
        /// Number of checklist items that are present on the task.
        /// </summary>
        [JsonPropertyName("checklistItemCount")]
        public Int32? ChecklistItemCount { get; set; }
    
        /// <summary>
        /// Gets or sets completed by.
        /// Identity of the user that completed the task.
        /// </summary>
        [JsonPropertyName("completedBy")]
        public IdentitySet CompletedBy { get; set; }
    
        /// <summary>
        /// Gets or sets completed date time.
        /// Read-only. Date and time at which the 'percentComplete' of the task is set to '100'. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        /// </summary>
        [JsonPropertyName("completedDateTime")]
        public DateTimeOffset? CompletedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets conversation thread id.
        /// Thread ID of the conversation on the task. This is the ID of the conversation thread object created in the group.
        /// </summary>
        [JsonPropertyName("conversationThreadId")]
        public string ConversationThreadId { get; set; }
    
        /// <summary>
        /// Gets or sets created by.
        /// Identity of the user that created the task.
        /// </summary>
        [JsonPropertyName("createdBy")]
        public IdentitySet CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Read-only. Date and time at which the task is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets creation source.
        /// Contains information about the origin of the task.
        /// </summary>
        [JsonPropertyName("creationSource")]
        public PlannerTaskCreation CreationSource { get; set; }
    
        /// <summary>
        /// Gets or sets due date time.
        /// Date and time at which the task is due. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        /// </summary>
        [JsonPropertyName("dueDateTime")]
        public DateTimeOffset? DueDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets has description.
        /// Read-only. Value is true if the details object of the task has a non-empty description and false otherwise.
        /// </summary>
        [JsonPropertyName("hasDescription")]
        public bool? HasDescription { get; set; }
    
        /// <summary>
        /// Gets or sets order hint.
        /// Hint used to order items of this type in a list view. The format is defined as outlined here.
        /// </summary>
        [JsonPropertyName("orderHint")]
        public string OrderHint { get; set; }
    
        /// <summary>
        /// Gets or sets percent complete.
        /// Percentage of task completion. When set to 100, the task is considered completed.
        /// </summary>
        [JsonPropertyName("percentComplete")]
        public Int32? PercentComplete { get; set; }
    
        /// <summary>
        /// Gets or sets plan id.
        /// Plan ID to which the task belongs.
        /// </summary>
        [JsonPropertyName("planId")]
        public string PlanId { get; set; }
    
        /// <summary>
        /// Gets or sets preview type.
        /// This sets the type of preview that shows up on the task. The possible values are: automatic, noPreview, checklist, description, reference.
        /// </summary>
        [JsonPropertyName("previewType")]
        public PlannerPreviewType? PreviewType { get; set; }
    
        /// <summary>
        /// Gets or sets priority.
        /// Priority of the task. Valid range of values is between 0 and 10 (inclusive), with increasing value being lower priority (0 has the highest priority and 10 has the lowest priority).  Currently, Planner interprets values 0 and 1 as 'urgent', 2 and 3 and 4 as 'important', 5, 6, and 7 as 'medium', and 8, 9, and 10 as 'low'.  Currently, Planner sets the value 1 for 'urgent', 3 for 'important', 5 for 'medium', and 9 for 'low'.
        /// </summary>
        [JsonPropertyName("priority")]
        public Int32? Priority { get; set; }
    
        /// <summary>
        /// Gets or sets reference count.
        /// Number of external references that exist on the task.
        /// </summary>
        [JsonPropertyName("referenceCount")]
        public Int32? ReferenceCount { get; set; }
    
        /// <summary>
        /// Gets or sets start date time.
        /// Date and time at which the task starts. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        /// </summary>
        [JsonPropertyName("startDateTime")]
        public DateTimeOffset? StartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets title.
        /// Title of the task.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    
        /// <summary>
        /// Gets or sets assigned to task board format.
        /// Read-only. Nullable. Used to render the task correctly in the task board view when grouped by assignedTo.
        /// </summary>
        [JsonPropertyName("assignedToTaskBoardFormat")]
        public PlannerAssignedToTaskBoardTaskFormat AssignedToTaskBoardFormat { get; set; }
    
        /// <summary>
        /// Gets or sets bucket task board format.
        /// Read-only. Nullable. Used to render the task correctly in the task board view when grouped by bucket.
        /// </summary>
        [JsonPropertyName("bucketTaskBoardFormat")]
        public PlannerBucketTaskBoardTaskFormat BucketTaskBoardFormat { get; set; }
    
        /// <summary>
        /// Gets or sets details.
        /// Read-only. Nullable. Additional details about the task.
        /// </summary>
        [JsonPropertyName("details")]
        public PlannerTaskDetails Details { get; set; }
    
        /// <summary>
        /// Gets or sets progress task board format.
        /// Read-only. Nullable. Used to render the task correctly in the task board view when grouped by progress.
        /// </summary>
        [JsonPropertyName("progressTaskBoardFormat")]
        public PlannerProgressTaskBoardTaskFormat ProgressTaskBoardFormat { get; set; }
    
    }
}

