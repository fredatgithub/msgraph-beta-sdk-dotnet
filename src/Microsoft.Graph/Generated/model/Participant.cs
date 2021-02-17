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
    /// The type Participant.
    /// </summary>
    public partial class Participant : Entity
    {
    
		///<summary>
		/// The Participant constructor
		///</summary>
        public Participant()
        {
            this.ODataType = "microsoft.graph.participant";
        }
	
        /// <summary>
        /// Gets or sets info.
        /// Information about the participant.
        /// </summary>
        [JsonPropertyName("info")]
        public ParticipantInfo Info { get; set; }
    
        /// <summary>
        /// Gets or sets is in lobby.
        /// true if the participant is in lobby.
        /// </summary>
        [JsonPropertyName("isInLobby")]
        public bool? IsInLobby { get; set; }
    
        /// <summary>
        /// Gets or sets is muted.
        /// true if the participant is muted (client or server muted).
        /// </summary>
        [JsonPropertyName("isMuted")]
        public bool? IsMuted { get; set; }
    
        /// <summary>
        /// Gets or sets media streams.
        /// The list of media streams.
        /// </summary>
        [JsonPropertyName("mediaStreams")]
        public IEnumerable<MediaStream> MediaStreams { get; set; }
    
        /// <summary>
        /// Gets or sets metadata.
        /// A blob of data provided by the participant in the roster.
        /// </summary>
        [JsonPropertyName("metadata")]
        public string Metadata { get; set; }
    
        /// <summary>
        /// Gets or sets recording info.
        /// Information on whether the participant has recording capability.
        /// </summary>
        [JsonPropertyName("recordingInfo")]
        public RecordingInfo RecordingInfo { get; set; }
    
    }
}

