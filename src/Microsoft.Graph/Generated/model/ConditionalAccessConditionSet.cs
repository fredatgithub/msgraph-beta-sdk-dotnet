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
    /// The type ConditionalAccessConditionSet.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ConditionalAccessConditionSet>))]
    public partial class ConditionalAccessConditionSet
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionalAccessConditionSet"/> class.
        /// </summary>
        public ConditionalAccessConditionSet()
        {
            this.ODataType = "microsoft.graph.conditionalAccessConditionSet";
        }

        /// <summary>
        /// Gets or sets applications.
        /// Applications and user actions included in and excluded from the policy. Required.
        /// </summary>
        [JsonPropertyName("applications")]
        public ConditionalAccessApplications Applications { get; set; }
    
        /// <summary>
        /// Gets or sets clientApplications.
        /// </summary>
        [JsonPropertyName("clientApplications")]
        public ConditionalAccessClientApplications ClientApplications { get; set; }
    
        /// <summary>
        /// Gets or sets clientAppTypes.
        /// Client application types included in the policy. Possible values are: all, browser, mobileAppsAndDesktopClients, exchangeActiveSync, easSupported, other.
        /// </summary>
        [JsonPropertyName("clientAppTypes")]
        public IEnumerable<ConditionalAccessClientApp> ClientAppTypes { get; set; }
    
        /// <summary>
        /// Gets or sets devices.
        /// Devices in the policy.
        /// </summary>
        [JsonPropertyName("devices")]
        public ConditionalAccessDevices Devices { get; set; }
    
        /// <summary>
        /// Gets or sets deviceStates.
        /// Device states in the policy.
        /// </summary>
        [JsonPropertyName("deviceStates")]
        public ConditionalAccessDeviceStates DeviceStates { get; set; }
    
        /// <summary>
        /// Gets or sets locations.
        /// Locations included in and excluded from the policy.
        /// </summary>
        [JsonPropertyName("locations")]
        public ConditionalAccessLocations Locations { get; set; }
    
        /// <summary>
        /// Gets or sets platforms.
        /// Platforms included in and excluded from the policy.
        /// </summary>
        [JsonPropertyName("platforms")]
        public ConditionalAccessPlatforms Platforms { get; set; }
    
        /// <summary>
        /// Gets or sets signInRiskLevels.
        /// Sign-in risk levels included in the policy. Possible values are: low, medium, high, none.
        /// </summary>
        [JsonPropertyName("signInRiskLevels")]
        public IEnumerable<RiskLevel> SignInRiskLevels { get; set; }
    
        /// <summary>
        /// Gets or sets userRiskLevels.
        /// User risk levels included in the policy. Possible values are: low, medium, high.
        /// </summary>
        [JsonPropertyName("userRiskLevels")]
        public IEnumerable<RiskLevel> UserRiskLevels { get; set; }
    
        /// <summary>
        /// Gets or sets users.
        /// Users, groups, and roles included in and excluded from the policy. Required.
        /// </summary>
        [JsonPropertyName("users")]
        public ConditionalAccessUsers Users { get; set; }
    
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
