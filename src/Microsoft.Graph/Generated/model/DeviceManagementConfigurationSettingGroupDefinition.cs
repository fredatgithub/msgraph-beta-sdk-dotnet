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
    /// The type Device Management Configuration Setting Group Definition.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DeviceManagementConfigurationSettingGroupDefinition>))]
    public partial class DeviceManagementConfigurationSettingGroupDefinition : DeviceManagementConfigurationSettingDefinition
    {
    
        ///<summary>
        /// The DeviceManagementConfigurationSettingGroupDefinition constructor
        ///</summary>
        public DeviceManagementConfigurationSettingGroupDefinition()
        {
            this.ODataType = "microsoft.graph.deviceManagementConfigurationSettingGroupDefinition";
        }
    
        /// <summary>
        /// Gets or sets child ids.
        /// Dependent child settings to this group of settings
        /// </summary>
        [JsonPropertyName("childIds")]
        public IEnumerable<string> ChildIds { get; set; }
    
        /// <summary>
        /// Gets or sets depended on by.
        /// List of child settings that depend on this setting
        /// </summary>
        [JsonPropertyName("dependedOnBy")]
        public IEnumerable<DeviceManagementConfigurationSettingDependedOnBy> DependedOnBy { get; set; }
    
        /// <summary>
        /// Gets or sets dependent on.
        /// List of Dependencies for the setting group
        /// </summary>
        [JsonPropertyName("dependentOn")]
        public IEnumerable<DeviceManagementConfigurationDependentOn> DependentOn { get; set; }
    
    }
}

