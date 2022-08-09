// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IUserAppRoleAssignedResourcesCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial interface IUserAppRoleAssignedResourcesCollectionWithReferencesRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IUserAppRoleAssignedResourcesCollectionWithReferencesRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IUserAppRoleAssignedResourcesCollectionWithReferencesRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IServicePrincipalWithReferenceRequestBuilder"/> for the specified ServicePrincipal.
        /// </summary>
        /// <param name="id">The ID for the ServicePrincipal.</param>
        /// <returns>The <see cref="IServicePrincipalWithReferenceRequestBuilder"/>.</returns>
        IServicePrincipalWithReferenceRequestBuilder this[string id] { get; }
        
        /// <summary>
        /// Gets an <see cref="IUserAppRoleAssignedResourcesCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IUserAppRoleAssignedResourcesCollectionReferencesRequestBuilder"/>.</returns>
        IUserAppRoleAssignedResourcesCollectionReferencesRequestBuilder References { get; }

    }
}
