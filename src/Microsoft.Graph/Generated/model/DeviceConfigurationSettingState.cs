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
    /// The type DeviceConfigurationSettingState.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DeviceConfigurationSettingState>))]
    public partial class DeviceConfigurationSettingState
    {

        /// <summary>
        /// Gets or sets currentValue.
        /// Current value of setting on device
        /// </summary>
        [JsonPropertyName("currentValue")]
        public string CurrentValue { get; set; }
    
        /// <summary>
        /// Gets or sets errorCode.
        /// Error code for the setting
        /// </summary>
        [JsonPropertyName("errorCode")]
        public Int64? ErrorCode { get; set; }
    
        /// <summary>
        /// Gets or sets errorDescription.
        /// Error description
        /// </summary>
        [JsonPropertyName("errorDescription")]
        public string ErrorDescription { get; set; }
    
        /// <summary>
        /// Gets or sets instanceDisplayName.
        /// Name of setting instance that is being reported.
        /// </summary>
        [JsonPropertyName("instanceDisplayName")]
        public string InstanceDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets setting.
        /// The setting that is being reported
        /// </summary>
        [JsonPropertyName("setting")]
        public string Setting { get; set; }
    
        /// <summary>
        /// Gets or sets settingInstanceId.
        /// SettingInstanceId
        /// </summary>
        [JsonPropertyName("settingInstanceId")]
        public string SettingInstanceId { get; set; }
    
        /// <summary>
        /// Gets or sets settingName.
        /// Localized/user friendly setting name that is being reported
        /// </summary>
        [JsonPropertyName("settingName")]
        public string SettingName { get; set; }
    
        /// <summary>
        /// Gets or sets sources.
        /// Contributing policies
        /// </summary>
        [JsonPropertyName("sources")]
        public IEnumerable<SettingSource> Sources { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// The compliance state of the setting. Possible values are: unknown, notApplicable, compliant, remediated, nonCompliant, error, conflict, notAssigned.
        /// </summary>
        [JsonPropertyName("state")]
        public ComplianceStatus? State { get; set; }
    
        /// <summary>
        /// Gets or sets userEmail.
        /// UserEmail
        /// </summary>
        [JsonPropertyName("userEmail")]
        public string UserEmail { get; set; }
    
        /// <summary>
        /// Gets or sets userId.
        /// UserId
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets userName.
        /// UserName
        /// </summary>
        [JsonPropertyName("userName")]
        public string UserName { get; set; }
    
        /// <summary>
        /// Gets or sets userPrincipalName.
        /// UserPrincipalName.
        /// </summary>
        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    
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
