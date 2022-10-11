// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ManagedTenantAlertEmailNotificationsCollectionReferencesRequestBuilder.
    /// </summary>
    public partial class ManagedTenantAlertEmailNotificationsCollectionReferencesRequestBuilder : Microsoft.Graph.BaseRequestBuilder, IManagedTenantAlertEmailNotificationsCollectionReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new ManagedTenantAlertEmailNotificationsCollectionReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public ManagedTenantAlertEmailNotificationsCollectionReferencesRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IManagedTenantAlertEmailNotificationsCollectionReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IManagedTenantAlertEmailNotificationsCollectionReferencesRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new ManagedTenantAlertEmailNotificationsCollectionReferencesRequest(this.RequestUrl, this.Client, options);
        }
    }
}
