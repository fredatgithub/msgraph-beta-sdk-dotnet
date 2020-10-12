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
    /// The type AppConsentRequestUserConsentRequestsCollectionRequestBuilder.
    /// </summary>
    public partial class AppConsentRequestUserConsentRequestsCollectionRequestBuilder : BaseRequestBuilder, IAppConsentRequestUserConsentRequestsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new AppConsentRequestUserConsentRequestsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AppConsentRequestUserConsentRequestsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IAppConsentRequestUserConsentRequestsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IAppConsentRequestUserConsentRequestsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new AppConsentRequestUserConsentRequestsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IUserConsentRequestRequestBuilder"/> for the specified AppConsentRequestUserConsentRequest.
        /// </summary>
        /// <param name="id">The ID for the AppConsentRequestUserConsentRequest.</param>
        /// <returns>The <see cref="IUserConsentRequestRequestBuilder"/>.</returns>
        public IUserConsentRequestRequestBuilder this[string id]
        {
            get
            {
                return new UserConsentRequestRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}