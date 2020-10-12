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
    /// The type IPv6CidrRange.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class IPv6CidrRange : IpRange
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IPv6CidrRange"/> class.
        /// </summary>
        public IPv6CidrRange()
        {
            this.ODataType = "microsoft.graph.iPv6CidrRange";
        }

        /// <summary>
        /// Gets or sets cidrAddress.
        /// IPv6 address in CIDR notation
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cidrAddress", Required = Newtonsoft.Json.Required.Default)]
        public string CidrAddress { get; set; }
    
    }
}