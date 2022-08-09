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
    /// The type HttpRequestEndpoint.
    /// </summary>
    public partial class HttpRequestEndpoint : CustomExtensionEndpointConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpRequestEndpoint"/> class.
        /// </summary>
        public HttpRequestEndpoint()
        {
            this.ODataType = "microsoft.graph.httpRequestEndpoint";
        }

        /// <summary>
        /// Gets or sets targetUrl.
        /// </summary>
        [JsonPropertyName("targetUrl")]
        public string TargetUrl { get; set; }
    
    }
}
