// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph.ExternalConnectors
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ExternalActivityResultRequestBuilder.
    /// </summary>
    public partial class ExternalActivityResultRequestBuilder : ExternalActivityRequestBuilder, IExternalActivityResultRequestBuilder
    {

        /// <summary>
        /// Constructs a new ExternalActivityResultRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public ExternalActivityResultRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IExternalActivityResultRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IExternalActivityResultRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new ExternalActivityResultRequest(this.RequestUrl, this.Client, options);
        }
    
    }
}
