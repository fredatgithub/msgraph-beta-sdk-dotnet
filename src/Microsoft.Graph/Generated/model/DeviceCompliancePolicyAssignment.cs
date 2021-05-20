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
    /// The type Device Compliance Policy Assignment.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DeviceCompliancePolicyAssignment>))]
    public partial class DeviceCompliancePolicyAssignment : Entity
    {
    
        /// <summary>
        /// Gets or sets source.
        /// The assignment source for the device compliance policy, direct or parcel/policySet. Possible values are: direct, policySets.
        /// </summary>
        [JsonPropertyName("source")]
        public DeviceAndAppManagementAssignmentSource? Source { get; set; }
    
        /// <summary>
        /// Gets or sets source id.
        /// The identifier of the source of the assignment.
        /// </summary>
        [JsonPropertyName("sourceId")]
        public string SourceId { get; set; }
    
        /// <summary>
        /// Gets or sets target.
        /// Target for the compliance policy assignment.
        /// </summary>
        [JsonPropertyName("target")]
        public DeviceAndAppManagementAssignmentTarget Target { get; set; }
    
    }
}

