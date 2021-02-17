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
    /// The type ProtectOnlineMeetingAction.
    /// </summary>
    public partial class ProtectOnlineMeetingAction : LabelActionBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectOnlineMeetingAction"/> class.
        /// </summary>
        public ProtectOnlineMeetingAction()
        {
            this.ODataType = "microsoft.graph.protectOnlineMeetingAction";
        }

        /// <summary>
        /// Gets or sets allowedForwarders.
        /// </summary>
        [JsonPropertyName("allowedForwarders")]
        public OnlineMeetingForwarders? AllowedForwarders { get; set; }
    
        /// <summary>
        /// Gets or sets allowedPresenters.
        /// </summary>
        [JsonPropertyName("allowedPresenters")]
        public OnlineMeetingPresenters? AllowedPresenters { get; set; }
    
        /// <summary>
        /// Gets or sets isCopyToClipboardEnabled.
        /// </summary>
        [JsonPropertyName("isCopyToClipboardEnabled")]
        public bool? IsCopyToClipboardEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets isLobbyEnabled.
        /// </summary>
        [JsonPropertyName("isLobbyEnabled")]
        public bool? IsLobbyEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets lobbyBypassSettings.
        /// </summary>
        [JsonPropertyName("lobbyBypassSettings")]
        public LobbyBypassSettings LobbyBypassSettings { get; set; }
    
    }
}
