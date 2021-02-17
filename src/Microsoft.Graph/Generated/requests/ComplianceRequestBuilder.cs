// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ComplianceRequestBuilder.
    /// </summary>
    public partial class ComplianceRequestBuilder : BaseRequestBuilder, IComplianceRequestBuilder
    {

        /// <summary>
        /// Constructs a new ComplianceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ComplianceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IComplianceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IComplianceRequest Request(IEnumerable<Option> options)
        {
            return new ComplianceRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Ediscovery.
        /// </summary>
        /// <returns>The <see cref="Microsoft.Graph.Ediscovery.IEdiscoveryrootRequestBuilder"/>.</returns>
        public Microsoft.Graph.Ediscovery.IEdiscoveryrootRequestBuilder Ediscovery
        {
            get
            {
                return new Microsoft.Graph.Ediscovery.EdiscoveryrootRequestBuilder(this.AppendSegmentToRequestUrl("ediscovery"), this.Client);
            }
        }
    
    }
}
