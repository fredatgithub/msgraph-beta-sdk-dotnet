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
    /// The type AttackSimulationTrainingUserCoverage.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AttackSimulationTrainingUserCoverage>))]
    public partial class AttackSimulationTrainingUserCoverage
    {

        /// <summary>
        /// Gets or sets attackSimulationUser.
        /// User in an attack simulation and training campaign.
        /// </summary>
        [JsonPropertyName("attackSimulationUser")]
        public AttackSimulationUser AttackSimulationUser { get; set; }
    
        /// <summary>
        /// Gets or sets userTrainings.
        /// List of assigned trainings' and their statuses for the user.
        /// </summary>
        [JsonPropertyName("userTrainings")]
        public IEnumerable<UserTrainingStatusInfo> UserTrainings { get; set; }
    
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
