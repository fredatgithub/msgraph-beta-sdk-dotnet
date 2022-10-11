// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IManagedTenantAlertAlertLogsCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial interface IManagedTenantAlertAlertLogsCollectionWithReferencesRequestBuilder : Microsoft.Graph.IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IManagedTenantAlertAlertLogsCollectionWithReferencesRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IManagedTenantAlertAlertLogsCollectionWithReferencesRequest Request(IEnumerable<Microsoft.Graph.Option> options);

        /// <summary>
        /// Gets an <see cref="IManagedTenantAlertLogWithReferenceRequestBuilder"/> for the specified ManagedTenantAlertLog.
        /// </summary>
        /// <param name="id">The ID for the ManagedTenantAlertLog.</param>
        /// <returns>The <see cref="IManagedTenantAlertLogWithReferenceRequestBuilder"/>.</returns>
        IManagedTenantAlertLogWithReferenceRequestBuilder this[string id] { get; }
        
        /// <summary>
        /// Gets an <see cref="IManagedTenantAlertAlertLogsCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IManagedTenantAlertAlertLogsCollectionReferencesRequestBuilder"/>.</returns>
        IManagedTenantAlertAlertLogsCollectionReferencesRequestBuilder References { get; }

    }
}
