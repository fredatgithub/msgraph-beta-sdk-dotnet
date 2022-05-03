// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.TermStore
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Set.
    /// </summary>
    public partial class Set : Microsoft.Graph.Entity
    {
    
        /// <summary>
        /// Gets or sets created date time.
        /// Date and time of set creation. Read-only.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Description giving details on the term usage.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets localized names.
        /// Name of the set for each languageTag.
        /// </summary>
        [JsonPropertyName("localizedNames")]
        public IEnumerable<LocalizedName> LocalizedNames { get; set; }
    
        /// <summary>
        /// Gets or sets properties.
        /// Custom properties for the set.
        /// </summary>
        [JsonPropertyName("properties")]
        public IEnumerable<Microsoft.Graph.KeyValue> Properties { get; set; }
    
        /// <summary>
        /// Gets or sets children.
        /// Children terms of set in term [store].
        /// </summary>
        [JsonPropertyName("children")]
        public ISetChildrenCollectionPage Children { get; set; }

        /// <summary>
        /// Gets or sets childrenNextLink.
        /// </summary>
        [JsonPropertyName("children@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ChildrenNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets parent group.
        /// The parent [group] that contains the set.
        /// </summary>
        [JsonPropertyName("parentGroup")]
        public Group ParentGroup { get; set; }
    
        /// <summary>
        /// Gets or sets relations.
        /// Indicates which terms have been pinned or reused directly under the set.
        /// </summary>
        [JsonPropertyName("relations")]
        public ISetRelationsCollectionPage Relations { get; set; }

        /// <summary>
        /// Gets or sets relationsNextLink.
        /// </summary>
        [JsonPropertyName("relations@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string RelationsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets terms.
        /// All the terms under the set.
        /// </summary>
        [JsonPropertyName("terms")]
        public ISetTermsCollectionPage Terms { get; set; }

        /// <summary>
        /// Gets or sets termsNextLink.
        /// </summary>
        [JsonPropertyName("terms@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string TermsNextLink { get; set; }
    
    }
}

