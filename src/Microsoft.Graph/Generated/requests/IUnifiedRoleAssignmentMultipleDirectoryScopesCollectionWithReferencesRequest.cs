// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionWithReferencesRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IUnifiedRoleAssignmentMultipleDirectoryScopesCollectionWithReferencesRequest.
    /// </summary>
    public partial interface IUnifiedRoleAssignmentMultipleDirectoryScopesCollectionWithReferencesRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IUnifiedRoleAssignmentMultipleDirectoryScopesCollectionWithReferencesPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IUnifiedRoleAssignmentMultipleDirectoryScopesCollectionWithReferencesPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{UnifiedRoleAssignmentMultipleDirectoryScopesCollectionWithReferencesResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleAssignmentMultipleDirectoryScopesCollectionWithReferencesResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleAssignmentMultipleDirectoryScopesCollectionWithReferencesResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{UnifiedRoleAssignmentMultipleDirectoryScopesCollectionWithReferencesResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleAssignmentMultipleDirectoryScopesCollectionWithReferencesResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleAssignmentMultipleDirectoryScopesCollectionWithReferencesResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleAssignmentMultipleDirectoryScopesCollectionWithReferencesRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleAssignmentMultipleDirectoryScopesCollectionWithReferencesRequest Expand(Expression<Func<DirectoryObject, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleAssignmentMultipleDirectoryScopesCollectionWithReferencesRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleAssignmentMultipleDirectoryScopesCollectionWithReferencesRequest Select(Expression<Func<DirectoryObject, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleAssignmentMultipleDirectoryScopesCollectionWithReferencesRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleAssignmentMultipleDirectoryScopesCollectionWithReferencesRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleAssignmentMultipleDirectoryScopesCollectionWithReferencesRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleAssignmentMultipleDirectoryScopesCollectionWithReferencesRequest OrderBy(string value);
    }
}
