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
    /// The type AttendanceRecord.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AttendanceRecord>))]
    public partial class AttendanceRecord
    {

        /// <summary>
        /// Gets or sets attendanceIntervals.
        /// List of time periods between joining and leaving.
        /// </summary>
        [JsonPropertyName("attendanceIntervals")]
        public IEnumerable<AttendanceInterval> AttendanceIntervals { get; set; }
    
        /// <summary>
        /// Gets or sets emailAddress.
        /// Email address.
        /// </summary>
        [JsonPropertyName("emailAddress")]
        public string EmailAddress { get; set; }
    
        /// <summary>
        /// Gets or sets identity.
        /// Identifier, such as display name.
        /// </summary>
        [JsonPropertyName("identity")]
        public Identity Identity { get; set; }
    
        /// <summary>
        /// Gets or sets role.
        /// Role of the attendee. Possible values are None, Attendee, Presenter, and Organizer.
        /// </summary>
        [JsonPropertyName("role")]
        public string Role { get; set; }
    
        /// <summary>
        /// Gets or sets totalAttendanceInSeconds.
        /// Total duration of the attendances in seconds.
        /// </summary>
        [JsonPropertyName("totalAttendanceInSeconds")]
        public Int32? TotalAttendanceInSeconds { get; set; }
    
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
