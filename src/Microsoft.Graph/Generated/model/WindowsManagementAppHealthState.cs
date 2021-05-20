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
    /// The type Windows Management App Health State.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<WindowsManagementAppHealthState>))]
    public partial class WindowsManagementAppHealthState : Entity
    {
    
        /// <summary>
        /// Gets or sets device name.
        /// Name of the device on which Windows management app is installed.
        /// </summary>
        [JsonPropertyName("deviceName")]
        public string DeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets device osversion.
        /// Windows 10 OS version of the device on which Windows management app is installed.
        /// </summary>
        [JsonPropertyName("deviceOSVersion")]
        public string DeviceOSVersion { get; set; }
    
        /// <summary>
        /// Gets or sets health state.
        /// Windows management app health state. Possible values are: unknown, healthy, unhealthy.
        /// </summary>
        [JsonPropertyName("healthState")]
        public HealthState? HealthState { get; set; }
    
        /// <summary>
        /// Gets or sets installed version.
        /// Windows management app installed version.
        /// </summary>
        [JsonPropertyName("installedVersion")]
        public string InstalledVersion { get; set; }
    
        /// <summary>
        /// Gets or sets last check in date time.
        /// Windows management app last check-in time.
        /// </summary>
        [JsonPropertyName("lastCheckInDateTime")]
        public DateTimeOffset? LastCheckInDateTime { get; set; }
    
    }
}

