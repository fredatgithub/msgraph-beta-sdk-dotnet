// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.ExternalConnectors
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type External Group Member.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<ExternalGroupMember>))]
    public partial class ExternalGroupMember : Microsoft.Graph.Entity
    {
    
        /// <summary>
        /// Gets or sets identity source.
        /// </summary>
        [JsonPropertyName("identitySource")]
        public IdentitySourceType? IdentitySource { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// </summary>
        [JsonPropertyName("type")]
        public ExternalGroupMemberType? Type { get; set; }
    
    }
}

