// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type MicrosoftTunnelSiteMicrosoftTunnelServersCollectionRequestBuilder.
    /// </summary>
    public partial class MicrosoftTunnelSiteMicrosoftTunnelServersCollectionRequestBuilder : BaseRequestBuilder, IMicrosoftTunnelSiteMicrosoftTunnelServersCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new MicrosoftTunnelSiteMicrosoftTunnelServersCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public MicrosoftTunnelSiteMicrosoftTunnelServersCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IMicrosoftTunnelSiteMicrosoftTunnelServersCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IMicrosoftTunnelSiteMicrosoftTunnelServersCollectionRequest Request(IEnumerable<Option> options)
        {
            return new MicrosoftTunnelSiteMicrosoftTunnelServersCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IMicrosoftTunnelServerRequestBuilder"/> for the specified MicrosoftTunnelSiteMicrosoftTunnelServer.
        /// </summary>
        /// <param name="id">The ID for the MicrosoftTunnelSiteMicrosoftTunnelServer.</param>
        /// <returns>The <see cref="IMicrosoftTunnelServerRequestBuilder"/>.</returns>
        public IMicrosoftTunnelServerRequestBuilder this[string id]
        {
            get
            {
                return new MicrosoftTunnelServerRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}