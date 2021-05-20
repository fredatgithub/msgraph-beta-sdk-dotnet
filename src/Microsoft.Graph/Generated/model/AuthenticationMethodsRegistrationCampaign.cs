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
    /// The type AuthenticationMethodsRegistrationCampaign.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AuthenticationMethodsRegistrationCampaign>))]
    public partial class AuthenticationMethodsRegistrationCampaign
    {

        /// <summary>
        /// Gets or sets excludeTargets.
        /// </summary>
        [JsonPropertyName("excludeTargets")]
        public IEnumerable<ExcludeTarget> ExcludeTargets { get; set; }
    
        /// <summary>
        /// Gets or sets includeTargets.
        /// </summary>
        [JsonPropertyName("includeTargets")]
        public IEnumerable<AuthenticationMethodsRegistrationCampaignIncludeTarget> IncludeTargets { get; set; }
    
        /// <summary>
        /// Gets or sets snoozeDurationInDays.
        /// </summary>
        [JsonPropertyName("snoozeDurationInDays")]
        public Int32? SnoozeDurationInDays { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// </summary>
        [JsonPropertyName("state")]
        public AdvancedConfigState? State { get; set; }
    
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
