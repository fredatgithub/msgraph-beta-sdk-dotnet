// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ManagedTenantAlertAlertLogsCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class ManagedTenantAlertAlertLogsCollectionWithReferencesRequestBuilder : Microsoft.Graph.BaseRequestBuilder, IManagedTenantAlertAlertLogsCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new ManagedTenantAlertAlertLogsCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public ManagedTenantAlertAlertLogsCollectionWithReferencesRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IManagedTenantAlertAlertLogsCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IManagedTenantAlertAlertLogsCollectionWithReferencesRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new ManagedTenantAlertAlertLogsCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IManagedTenantAlertLogWithReferenceRequestBuilder"/> for the specified ManagedTenantAlertManagedTenantAlertLog.
        /// </summary>
        /// <param name="id">The ID for the ManagedTenantAlertManagedTenantAlertLog.</param>
        /// <returns>The <see cref="IManagedTenantAlertLogWithReferenceRequestBuilder"/>.</returns>
        public IManagedTenantAlertLogWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new ManagedTenantAlertLogWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IManagedTenantAlertAlertLogsCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IManagedTenantAlertAlertLogsCollectionReferencesRequestBuilder"/>.</returns>
        public IManagedTenantAlertAlertLogsCollectionReferencesRequestBuilder References
        {
            get
            {
                return new ManagedTenantAlertAlertLogsCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
