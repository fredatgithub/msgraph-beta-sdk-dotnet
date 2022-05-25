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
    /// The type Connector Group.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ConnectorGroup>))]
    public partial class ConnectorGroup : Entity
    {
    
        /// <summary>
        /// Gets or sets connector group type.
        /// Indicates the type of hybrid agent. This pre-set by the system. Possible values are: applicationProxy. Read-only.
        /// </summary>
        [JsonPropertyName("connectorGroupType")]
        public ConnectorGroupType? ConnectorGroupType { get; set; }
    
        /// <summary>
        /// Gets or sets is default.
        /// Indicates if the connectorGroup is the default connectorGroup. Only a single connector group can be the default connectorGroup and this is pre-set by the system. Read-only.
        /// </summary>
        [JsonPropertyName("isDefault")]
        public bool? IsDefault { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// The name associated with the connectorGroup.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets region.
        /// The region the connectorGroup is assigned to and will optimize traffic for. This region can only be set if no connectors or applications are assigned to the connectorGroup. The possible values are: nam (for North America), eur (for Europe), aus (for Australia), asia (for Asia), ind (for India), and unknownFutureValue.
        /// </summary>
        [JsonPropertyName("region")]
        public ConnectorGroupRegion? Region { get; set; }
    
        /// <summary>
        /// Gets or sets applications.
        /// Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("applications")]
        public IConnectorGroupApplicationsCollectionWithReferencesPage Applications { get; set; }

        /// <summary>
        /// Gets or sets applicationsNextLink.
        /// </summary>
        [JsonPropertyName("applications@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ApplicationsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets members.
        /// Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("members")]
        public IConnectorGroupMembersCollectionWithReferencesPage Members { get; set; }

        /// <summary>
        /// Gets or sets membersNextLink.
        /// </summary>
        [JsonPropertyName("members@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string MembersNextLink { get; set; }
    
    }
}

