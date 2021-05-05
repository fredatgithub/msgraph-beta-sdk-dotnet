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
    /// The type Device Management Configuration Policy.
    /// </summary>
    public partial class DeviceManagementConfigurationPolicy : Entity
    {
    
		///<summary>
		/// The DeviceManagementConfigurationPolicy constructor
		///</summary>
        public DeviceManagementConfigurationPolicy()
        {
            this.ODataType = "microsoft.graph.deviceManagementConfigurationPolicy";
        }
	
        /// <summary>
        /// Gets or sets created date time.
        /// Policy creation date and time. This property is read-only.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets creation source.
        /// Policy creation source
        /// </summary>
        [JsonPropertyName("creationSource")]
        public string CreationSource { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Policy description
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets is assigned.
        /// Policy assignment status. This property is read-only.
        /// </summary>
        [JsonPropertyName("isAssigned")]
        public bool? IsAssigned { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// Policy last modification date and time. This property is read-only.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// Policy name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets platforms.
        /// Platforms for this policy. Possible values are: none, macOS, windows10X, windows10.
        /// </summary>
        [JsonPropertyName("platforms")]
        public DeviceManagementConfigurationPlatforms? Platforms { get; set; }
    
        /// <summary>
        /// Gets or sets role scope tag ids.
        /// List of Scope Tags for this Entity instance.
        /// </summary>
        [JsonPropertyName("roleScopeTagIds")]
        public IEnumerable<string> RoleScopeTagIds { get; set; }
    
        /// <summary>
        /// Gets or sets setting count.
        /// Number of settings. This property is read-only.
        /// </summary>
        [JsonPropertyName("settingCount")]
        public Int32? SettingCount { get; set; }
    
        /// <summary>
        /// Gets or sets technologies.
        /// Technologies for this policy. Possible values are: none, mdm, windows10XManagement, configManager.
        /// </summary>
        [JsonPropertyName("technologies")]
        public DeviceManagementConfigurationTechnologies? Technologies { get; set; }
    
        /// <summary>
        /// Gets or sets template reference.
        /// Template reference information
        /// </summary>
        [JsonPropertyName("templateReference")]
        public DeviceManagementConfigurationPolicyTemplateReference TemplateReference { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// Policy assignments
        /// </summary>
        [JsonPropertyName("assignments")]
        public IDeviceManagementConfigurationPolicyAssignmentsCollectionPage Assignments { get; set; }

        /// <summary>
        /// Gets or sets assignmentsNextLink.
        /// </summary>
        [JsonPropertyName("assignments@odata.nextLink")]
        public string AssignmentsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets settings.
        /// Policy settings
        /// </summary>
        [JsonPropertyName("settings")]
        public IDeviceManagementConfigurationPolicySettingsCollectionPage Settings { get; set; }

        /// <summary>
        /// Gets or sets settingsNextLink.
        /// </summary>
        [JsonPropertyName("settings@odata.nextLink")]
        public string SettingsNextLink { get; set; }
    
    }
}

