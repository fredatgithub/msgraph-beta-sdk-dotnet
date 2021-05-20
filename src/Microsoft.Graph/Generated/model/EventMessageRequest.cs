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
    /// The type Event Message Request.
    /// </summary>
    public partial class EventMessageRequestObject : EventMessage
    {
    
        ///<summary>
        /// The EventMessageRequest constructor
        ///</summary>
        public EventMessageRequestObject()
        {
            this.ODataType = "microsoft.graph.eventMessageRequest";
        }
    
        /// <summary>
        /// Gets or sets allow new time proposals.
        /// True if the meeting organizer allows invitees to propose a new time when responding, false otherwise. Optional. Default is true.
        /// </summary>
        [JsonPropertyName("allowNewTimeProposals")]
        public bool? AllowNewTimeProposals { get; set; }
    
        /// <summary>
        /// Gets or sets previous end date time.
        /// If the meeting update changes the meeting end time, this property specifies the previous meeting end time.
        /// </summary>
        [JsonPropertyName("previousEndDateTime")]
        public DateTimeTimeZone PreviousEndDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets previous location.
        /// If the meeting update changes the meeting location, this property specifies the previous meeting location.
        /// </summary>
        [JsonPropertyName("previousLocation")]
        public Location PreviousLocation { get; set; }
    
        /// <summary>
        /// Gets or sets previous start date time.
        /// If the meeting update changes the meeting start time, this property specifies the previous meeting start time.
        /// </summary>
        [JsonPropertyName("previousStartDateTime")]
        public DateTimeTimeZone PreviousStartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets response requested.
        /// Set to true if the sender would like the invitee to send a response to the requested meeting.
        /// </summary>
        [JsonPropertyName("responseRequested")]
        public bool? ResponseRequested { get; set; }
    
    }
}

