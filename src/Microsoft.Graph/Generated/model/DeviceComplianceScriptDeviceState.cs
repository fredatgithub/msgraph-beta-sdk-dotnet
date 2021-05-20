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
    /// The type Device Compliance Script Device State.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DeviceComplianceScriptDeviceState>))]
    public partial class DeviceComplianceScriptDeviceState : Entity
    {
    
        /// <summary>
        /// Gets or sets detection state.
        /// Detection state from the lastest device compliance script execution. Possible values are: unknown, success, fail, scriptError, pending, notApplicable.
        /// </summary>
        [JsonPropertyName("detectionState")]
        public RunState? DetectionState { get; set; }
    
        /// <summary>
        /// Gets or sets expected state update date time.
        /// The next timestamp of when the device compliance script is expected to execute
        /// </summary>
        [JsonPropertyName("expectedStateUpdateDateTime")]
        public DateTimeOffset? ExpectedStateUpdateDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last state update date time.
        /// The last timestamp of when the device compliance script executed
        /// </summary>
        [JsonPropertyName("lastStateUpdateDateTime")]
        public DateTimeOffset? LastStateUpdateDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last sync date time.
        /// The last time that Intune Managment Extension synced with Intune
        /// </summary>
        [JsonPropertyName("lastSyncDateTime")]
        public DateTimeOffset? LastSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets script error.
        /// Error from the detection script
        /// </summary>
        [JsonPropertyName("scriptError")]
        public string ScriptError { get; set; }
    
        /// <summary>
        /// Gets or sets script output.
        /// Output of the detection script
        /// </summary>
        [JsonPropertyName("scriptOutput")]
        public string ScriptOutput { get; set; }
    
        /// <summary>
        /// Gets or sets managed device.
        /// The managed device on which the device compliance script executed
        /// </summary>
        [JsonPropertyName("managedDevice")]
        public ManagedDevice ManagedDevice { get; set; }
    
    }
}

