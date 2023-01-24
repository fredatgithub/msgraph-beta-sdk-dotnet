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
    /// The type Recommendation Base.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<RecommendationBase>))]
    public partial class RecommendationBase : Entity
    {
    
        /// <summary>
        /// Gets or sets action steps.
        /// </summary>
        [JsonPropertyName("actionSteps")]
        public IEnumerable<ActionStep> ActionSteps { get; set; }
    
        /// <summary>
        /// Gets or sets benefits.
        /// </summary>
        [JsonPropertyName("benefits")]
        public string Benefits { get; set; }
    
        /// <summary>
        /// Gets or sets category.
        /// </summary>
        [JsonPropertyName("category")]
        public RecommendationCategory? Category { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets current score.
        /// </summary>
        [JsonPropertyName("currentScore")]
        public double? CurrentScore { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets feature areas.
        /// </summary>
        [JsonPropertyName("featureAreas")]
        public IEnumerable<RecommendationFeatureAreas> FeatureAreas { get; set; }
    
        /// <summary>
        /// Gets or sets impact start date time.
        /// </summary>
        [JsonPropertyName("impactStartDateTime")]
        public DateTimeOffset? ImpactStartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets impact type.
        /// </summary>
        [JsonPropertyName("impactType")]
        public string ImpactType { get; set; }
    
        /// <summary>
        /// Gets or sets insights.
        /// </summary>
        [JsonPropertyName("insights")]
        public string Insights { get; set; }
    
        /// <summary>
        /// Gets or sets last checked date time.
        /// </summary>
        [JsonPropertyName("lastCheckedDateTime")]
        public DateTimeOffset? LastCheckedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last modified by.
        /// </summary>
        [JsonPropertyName("lastModifiedBy")]
        public string LastModifiedBy { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets max score.
        /// </summary>
        [JsonPropertyName("maxScore")]
        public double? MaxScore { get; set; }
    
        /// <summary>
        /// Gets or sets postpone until date time.
        /// </summary>
        [JsonPropertyName("postponeUntilDateTime")]
        public DateTimeOffset? PostponeUntilDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets priority.
        /// </summary>
        [JsonPropertyName("priority")]
        public RecommendationPriority? Priority { get; set; }
    
        /// <summary>
        /// Gets or sets recommendation type.
        /// </summary>
        [JsonPropertyName("recommendationType")]
        public RecommendationType? RecommendationType { get; set; }
    
        /// <summary>
        /// Gets or sets remediation impact.
        /// </summary>
        [JsonPropertyName("remediationImpact")]
        public string RemediationImpact { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [JsonPropertyName("status")]
        public RecommendationStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets impacted resources.
        /// </summary>
        [JsonPropertyName("impactedResources")]
        public IRecommendationBaseImpactedResourcesCollectionPage ImpactedResources { get; set; }

        /// <summary>
        /// Gets or sets impactedResourcesNextLink.
        /// </summary>
        [JsonPropertyName("impactedResources@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ImpactedResourcesNextLink { get; set; }
    
    }
}

