// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type TeamworkTeamTemplatesCollectionRequestBuilder.
    /// </summary>
    public partial class TeamworkTeamTemplatesCollectionRequestBuilder : BaseRequestBuilder, ITeamworkTeamTemplatesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new TeamworkTeamTemplatesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public TeamworkTeamTemplatesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ITeamworkTeamTemplatesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ITeamworkTeamTemplatesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new TeamworkTeamTemplatesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ITeamTemplateRequestBuilder"/> for the specified TeamworkTeamTemplate.
        /// </summary>
        /// <param name="id">The ID for the TeamworkTeamTemplate.</param>
        /// <returns>The <see cref="ITeamTemplateRequestBuilder"/>.</returns>
        public ITeamTemplateRequestBuilder this[string id]
        {
            get
            {
                return new TeamTemplateRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
