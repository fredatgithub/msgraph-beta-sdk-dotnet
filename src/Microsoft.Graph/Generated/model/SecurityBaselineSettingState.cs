// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Security Baseline Setting State.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class SecurityBaselineSettingState : Entity
    {
    
		///<summary>
		/// The SecurityBaselineSettingState constructor
		///</summary>
        public SecurityBaselineSettingState()
        {
            this.ODataType = "microsoft.graph.securityBaselineSettingState";
        }
	
        /// <summary>
        /// Gets or sets contributing policies.
        /// The policies that contribute to this setting instance
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contributingPolicies", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<SecurityBaselineContributingPolicy> ContributingPolicies { get; set; }
    
        /// <summary>
        /// Gets or sets error code.
        /// The error code if the setting is in error state
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "errorCode", Required = Newtonsoft.Json.Required.Default)]
        public string ErrorCode { get; set; }
    
        /// <summary>
        /// Gets or sets setting category id.
        /// The setting category id which this setting belongs to
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settingCategoryId", Required = Newtonsoft.Json.Required.Default)]
        public string SettingCategoryId { get; set; }
    
        /// <summary>
        /// Gets or sets setting category name.
        /// The setting category name which this setting belongs to
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settingCategoryName", Required = Newtonsoft.Json.Required.Default)]
        public string SettingCategoryName { get; set; }
    
        /// <summary>
        /// Gets or sets setting id.
        /// The setting id guid
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settingId", Required = Newtonsoft.Json.Required.Default)]
        public string SettingId { get; set; }
    
        /// <summary>
        /// Gets or sets setting name.
        /// The setting name that is being reported
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settingName", Required = Newtonsoft.Json.Required.Default)]
        public string SettingName { get; set; }
    
        /// <summary>
        /// Gets or sets source policies.
        /// The policies that contribute to this setting instance
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sourcePolicies", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<SettingSource> SourcePolicies { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// The compliance state of the security baseline setting
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state", Required = Newtonsoft.Json.Required.Default)]
        public SecurityBaselineComplianceState? State { get; set; }
    
    }
}
