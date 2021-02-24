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
    /// The type Access Review Schedule Definition.
    /// </summary>
    public partial class AccessReviewScheduleDefinition : Entity
    {
    
		///<summary>
		/// The AccessReviewScheduleDefinition constructor
		///</summary>
        public AccessReviewScheduleDefinition()
        {
            this.ODataType = "microsoft.graph.accessReviewScheduleDefinition";
        }
	
        /// <summary>
        /// Gets or sets backup reviewers.
        /// This collection of reviewer scopes is used to define the list of fallback reviewers. These fallback reviewers will be notified to take action if no users are found from the list of reviewers specified. This could occur when either the group owner is specified as the reviewer but the group owner does not exist, or manager is specified as reviewer but a user's manager does not exist. See accessReviewReviewerScope.
        /// </summary>
        [JsonPropertyName("backupReviewers")]
        public IEnumerable<AccessReviewReviewerScope> BackupReviewers { get; set; }
    
        /// <summary>
        /// Gets or sets created by.
        /// User who created this review.
        /// </summary>
        [JsonPropertyName("createdBy")]
        public UserIdentity CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// DateTime when review series was created.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description for admins.
        /// Description provided by review creators to provide more context of the review to admins.
        /// </summary>
        [JsonPropertyName("descriptionForAdmins")]
        public string DescriptionForAdmins { get; set; }
    
        /// <summary>
        /// Gets or sets description for reviewers.
        /// Description provided  by review creators to provide more context of the review to reviewers. Reviewers will see this description in the email sent to them requesting their review.
        /// </summary>
        [JsonPropertyName("descriptionForReviewers")]
        public string DescriptionForReviewers { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Name of access review series. Required on create.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets instance enumeration scope.
        /// In the case of a review of guest users across all Microsoft 365 groups, this determines the scope of which groups will be reviewed. Each group will become a unique accessReviewInstance of the access review series.  For supported scopes, see accessReviewScope.
        /// </summary>
        [JsonPropertyName("instanceEnumerationScope")]
        public AccessReviewScope InstanceEnumerationScope { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// DateTime when review series was last modified.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets reviewers.
        /// This collection of access review scopes is used to define who are the reviewers. See accessReviewReviewerScope. Required on create.
        /// </summary>
        [JsonPropertyName("reviewers")]
        public IEnumerable<AccessReviewReviewerScope> Reviewers { get; set; }
    
        /// <summary>
        /// Gets or sets scope.
        /// Defines scope of users reviewed. For supported scopes, see accessReviewScope. Required on create.
        /// </summary>
        [JsonPropertyName("scope")]
        public AccessReviewScope Scope { get; set; }
    
        /// <summary>
        /// Gets or sets settings.
        /// The settings for an access review series, see type definition below.
        /// </summary>
        [JsonPropertyName("settings")]
        public AccessReviewScheduleSettings Settings { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// This read-only field specifies the status of an accessReview. The typical states include Initializing, NotStarted, Starting, InProgress, Completing, Completed, AutoReviewing, and AutoReviewed.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    
        /// <summary>
        /// Gets or sets instances.
        /// Set of access reviews instances for this access review series. Access reviews that do not recur will only have one instance; otherwise, there will be an instance for each recurrence.
        /// </summary>
        [JsonPropertyName("instances")]
        public IAccessReviewScheduleDefinitionInstancesCollectionPage Instances { get; set; }
    
    }
}

