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
    /// The type User Experience Analytics Not Autopilot Ready Device.
    /// </summary>
    public partial class UserExperienceAnalyticsNotAutopilotReadyDevice : Entity
    {
    
		///<summary>
		/// The UserExperienceAnalyticsNotAutopilotReadyDevice constructor
		///</summary>
        public UserExperienceAnalyticsNotAutopilotReadyDevice()
        {
            this.ODataType = "microsoft.graph.userExperienceAnalyticsNotAutopilotReadyDevice";
        }
	
        /// <summary>
        /// Gets or sets auto pilot profile assigned.
        /// The intune device's autopilotProfileAssigned.
        /// </summary>
        [JsonPropertyName("autoPilotProfileAssigned")]
        public bool? AutoPilotProfileAssigned { get; set; }
    
        /// <summary>
        /// Gets or sets auto pilot registered.
        /// The intune device's autopilotRegistered.
        /// </summary>
        [JsonPropertyName("autoPilotRegistered")]
        public bool? AutoPilotRegistered { get; set; }
    
        /// <summary>
        /// Gets or sets azure ad join type.
        /// The intune device's azure Ad joinType.
        /// </summary>
        [JsonPropertyName("azureAdJoinType")]
        public string AzureAdJoinType { get; set; }
    
        /// <summary>
        /// Gets or sets azure ad registered.
        /// The intune device's azureAdRegistered.
        /// </summary>
        [JsonPropertyName("azureAdRegistered")]
        public bool? AzureAdRegistered { get; set; }
    
        /// <summary>
        /// Gets or sets device name.
        /// The intune device's name.
        /// </summary>
        [JsonPropertyName("deviceName")]
        public string DeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets managed by.
        /// The intune device's managed by.
        /// </summary>
        [JsonPropertyName("managedBy")]
        public string ManagedBy { get; set; }
    
        /// <summary>
        /// Gets or sets manufacturer.
        /// The intune device's manufacturer.
        /// </summary>
        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }
    
        /// <summary>
        /// Gets or sets model.
        /// The intune device's model.
        /// </summary>
        [JsonPropertyName("model")]
        public string Model { get; set; }
    
        /// <summary>
        /// Gets or sets serial number.
        /// The intune device's serial number.
        /// </summary>
        [JsonPropertyName("serialNumber")]
        public string SerialNumber { get; set; }
    
    }
}

