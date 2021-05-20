// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type PlannerTeamsPublicationInfo.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<PlannerTeamsPublicationInfo>))]
    public partial class PlannerTeamsPublicationInfo
    {

        /// <summary>
        /// Gets or sets lastModifiedDateTime.
        /// The date and time when this task was last modified by the publication process. Read-only.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets publicationId.
        /// The identifier of the publication. Read-only.
        /// </summary>
        [JsonPropertyName("publicationId")]
        public string PublicationId { get; set; }
    
        /// <summary>
        /// Gets or sets publishedToPlanId.
        /// The identifier of the plannerPlan this task was originally placed in. Read-only.
        /// </summary>
        [JsonPropertyName("publishedToPlanId")]
        public string PublishedToPlanId { get; set; }
    
        /// <summary>
        /// Gets or sets publishingTeamId.
        /// The identifier of the team that initiated the publication process. Read-only.
        /// </summary>
        [JsonPropertyName("publishingTeamId")]
        public string PublishingTeamId { get; set; }
    
        /// <summary>
        /// Gets or sets publishingTeamName.
        /// The display name of the team that initiated the publication process. This display name is for reference only, and might not represent the most up-to-date name of the team. Read-only.
        /// </summary>
        [JsonPropertyName("publishingTeamName")]
        public string PublishingTeamName { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
