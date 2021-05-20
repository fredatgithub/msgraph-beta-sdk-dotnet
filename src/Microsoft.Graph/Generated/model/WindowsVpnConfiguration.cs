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
    /// The type Windows Vpn Configuration.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<WindowsVpnConfiguration>))]
    public partial class WindowsVpnConfiguration : DeviceConfiguration
    {
    
        ///<summary>
        /// The internal WindowsVpnConfiguration constructor
        ///</summary>
        protected internal WindowsVpnConfiguration()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets connection name.
        /// Connection name displayed to the user.
        /// </summary>
        [JsonPropertyName("connectionName")]
        public string ConnectionName { get; set; }
    
        /// <summary>
        /// Gets or sets custom xml.
        /// Custom XML commands that configures the VPN connection. (UTF8 encoded byte array)
        /// </summary>
        [JsonPropertyName("customXml")]
        public byte[] CustomXml { get; set; }
    
        /// <summary>
        /// Gets or sets servers.
        /// List of VPN Servers on the network. Make sure end users can access these network locations. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonPropertyName("servers")]
        public IEnumerable<VpnServer> Servers { get; set; }
    
    }
}

