// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IEntitlementManagementRequest.
    /// </summary>
    public partial interface IEntitlementManagementRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EntitlementManagement using POST.
        /// </summary>
        /// <param name="entitlementManagementToCreate">The EntitlementManagement to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EntitlementManagement.</returns>
        System.Threading.Tasks.Task<EntitlementManagement> CreateAsync(EntitlementManagement entitlementManagementToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified EntitlementManagement using POST and returns a <see cref="GraphResponse{EntitlementManagement}"/> object.
        /// </summary>
        /// <param name="entitlementManagementToCreate">The EntitlementManagement to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EntitlementManagement}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EntitlementManagement>> CreateResponseAsync(EntitlementManagement entitlementManagementToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified EntitlementManagement.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified EntitlementManagement and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified EntitlementManagement.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EntitlementManagement.</returns>
        System.Threading.Tasks.Task<EntitlementManagement> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified EntitlementManagement and returns a <see cref="GraphResponse{EntitlementManagement}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EntitlementManagement}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EntitlementManagement>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified EntitlementManagement using PATCH.
        /// </summary>
        /// <param name="entitlementManagementToUpdate">The EntitlementManagement to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EntitlementManagement.</returns>
        System.Threading.Tasks.Task<EntitlementManagement> UpdateAsync(EntitlementManagement entitlementManagementToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified EntitlementManagement using PATCH and returns a <see cref="GraphResponse{EntitlementManagement}"/> object.
        /// </summary>
        /// <param name="entitlementManagementToUpdate">The EntitlementManagement to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EntitlementManagement}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EntitlementManagement>> UpdateResponseAsync(EntitlementManagement entitlementManagementToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEntitlementManagementRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEntitlementManagementRequest Expand(Expression<Func<EntitlementManagement, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEntitlementManagementRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEntitlementManagementRequest Select(Expression<Func<EntitlementManagement, object>> selectExpression);

    }
}
