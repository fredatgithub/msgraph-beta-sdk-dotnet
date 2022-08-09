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
    /// The type AuthenticationConditionsApplicationsIncludeApplicationsCollectionRequestBuilder.
    /// </summary>
    public partial class AuthenticationConditionsApplicationsIncludeApplicationsCollectionRequestBuilder : BaseRequestBuilder, IAuthenticationConditionsApplicationsIncludeApplicationsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new AuthenticationConditionsApplicationsIncludeApplicationsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AuthenticationConditionsApplicationsIncludeApplicationsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IAuthenticationConditionsApplicationsIncludeApplicationsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IAuthenticationConditionsApplicationsIncludeApplicationsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new AuthenticationConditionsApplicationsIncludeApplicationsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IAuthenticationConditionApplicationRequestBuilder"/> for the specified AuthenticationConditionsApplicationsAuthenticationConditionApplication.
        /// </summary>
        /// <param name="id">The ID for the AuthenticationConditionsApplicationsAuthenticationConditionApplication.</param>
        /// <returns>The <see cref="IAuthenticationConditionApplicationRequestBuilder"/>.</returns>
        public IAuthenticationConditionApplicationRequestBuilder this[string id]
        {
            get
            {
                return new AuthenticationConditionApplicationRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
