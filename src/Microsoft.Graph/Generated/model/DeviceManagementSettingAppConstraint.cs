// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type DeviceManagementSettingAppConstraint.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceManagementSettingAppConstraint : DeviceManagementConstraint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceManagementSettingAppConstraint"/> class.
        /// </summary>
        public DeviceManagementSettingAppConstraint()
        {
            this.ODataType = "microsoft.graph.deviceManagementSettingAppConstraint";
        }

        /// <summary>
        /// Gets or sets supportedTypes.
        /// Acceptable app types to allow for this setting
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "supportedTypes", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> SupportedTypes { get; set; }
    
    }
}