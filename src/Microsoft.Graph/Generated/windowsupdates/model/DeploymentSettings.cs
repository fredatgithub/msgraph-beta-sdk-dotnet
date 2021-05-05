// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.WindowsUpdates
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type DeploymentSettings.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<DeploymentSettings>))]
    public partial class DeploymentSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentSettings"/> class.
        /// </summary>
        public DeploymentSettings()
        {
            this.ODataType = "microsoft.graph.windowsUpdates.deploymentSettings";
        }

        /// <summary>
        /// Gets or sets monitoring.
        /// Settings governing conditions to monitor and automated actions to take.
        /// </summary>
        [JsonPropertyName("monitoring")]
        public MonitoringSettings Monitoring { get; set; }
    
        /// <summary>
        /// Gets or sets rollout.
        /// Settings governing how the content is rolled out.
        /// </summary>
        [JsonPropertyName("rollout")]
        public RolloutSettings Rollout { get; set; }
    
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
