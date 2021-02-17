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
    /// The interface ISecurityBaselineCategoryStateSummaryRequest.
    /// </summary>
    public partial interface ISecurityBaselineCategoryStateSummaryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SecurityBaselineCategoryStateSummary using POST.
        /// </summary>
        /// <param name="securityBaselineCategoryStateSummaryToCreate">The SecurityBaselineCategoryStateSummary to create.</param>
        /// <returns>The created SecurityBaselineCategoryStateSummary.</returns>
        System.Threading.Tasks.Task<SecurityBaselineCategoryStateSummary> CreateAsync(SecurityBaselineCategoryStateSummary securityBaselineCategoryStateSummaryToCreate);

        /// <summary>
        /// Creates the specified SecurityBaselineCategoryStateSummary using POST.
        /// </summary>
        /// <param name="securityBaselineCategoryStateSummaryToCreate">The SecurityBaselineCategoryStateSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SecurityBaselineCategoryStateSummary.</returns>
        System.Threading.Tasks.Task<SecurityBaselineCategoryStateSummary> CreateAsync(SecurityBaselineCategoryStateSummary securityBaselineCategoryStateSummaryToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified SecurityBaselineCategoryStateSummary using POST and returns a <see cref="GraphResponse{SecurityBaselineCategoryStateSummary}"/> object.
        /// </summary>
        /// <param name="securityBaselineCategoryStateSummaryToCreate">The SecurityBaselineCategoryStateSummary to create.</param>
        /// <returns>The <see cref="GraphResponse{SecurityBaselineCategoryStateSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SecurityBaselineCategoryStateSummary>> CreateResponseAsync(SecurityBaselineCategoryStateSummary securityBaselineCategoryStateSummaryToCreate);

        /// <summary>
        /// Creates the specified SecurityBaselineCategoryStateSummary using POST and returns a <see cref="GraphResponse{SecurityBaselineCategoryStateSummary}"/> object.
        /// </summary>
        /// <param name="securityBaselineCategoryStateSummaryToCreate">The SecurityBaselineCategoryStateSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SecurityBaselineCategoryStateSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SecurityBaselineCategoryStateSummary>> CreateResponseAsync(SecurityBaselineCategoryStateSummary securityBaselineCategoryStateSummaryToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified SecurityBaselineCategoryStateSummary.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified SecurityBaselineCategoryStateSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified SecurityBaselineCategoryStateSummary and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified SecurityBaselineCategoryStateSummary and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SecurityBaselineCategoryStateSummary.
        /// </summary>
        /// <returns>The SecurityBaselineCategoryStateSummary.</returns>
        System.Threading.Tasks.Task<SecurityBaselineCategoryStateSummary> GetAsync();

        /// <summary>
        /// Gets the specified SecurityBaselineCategoryStateSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SecurityBaselineCategoryStateSummary.</returns>
        System.Threading.Tasks.Task<SecurityBaselineCategoryStateSummary> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SecurityBaselineCategoryStateSummary and returns a <see cref="GraphResponse{SecurityBaselineCategoryStateSummary}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{SecurityBaselineCategoryStateSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SecurityBaselineCategoryStateSummary>> GetResponseAsync();

        /// <summary>
        /// Gets the specified SecurityBaselineCategoryStateSummary and returns a <see cref="GraphResponse{SecurityBaselineCategoryStateSummary}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SecurityBaselineCategoryStateSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SecurityBaselineCategoryStateSummary>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SecurityBaselineCategoryStateSummary using PATCH.
        /// </summary>
        /// <param name="securityBaselineCategoryStateSummaryToUpdate">The SecurityBaselineCategoryStateSummary to update.</param>
        /// <returns>The updated SecurityBaselineCategoryStateSummary.</returns>
        System.Threading.Tasks.Task<SecurityBaselineCategoryStateSummary> UpdateAsync(SecurityBaselineCategoryStateSummary securityBaselineCategoryStateSummaryToUpdate);

        /// <summary>
        /// Updates the specified SecurityBaselineCategoryStateSummary using PATCH.
        /// </summary>
        /// <param name="securityBaselineCategoryStateSummaryToUpdate">The SecurityBaselineCategoryStateSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SecurityBaselineCategoryStateSummary.</returns>
        System.Threading.Tasks.Task<SecurityBaselineCategoryStateSummary> UpdateAsync(SecurityBaselineCategoryStateSummary securityBaselineCategoryStateSummaryToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SecurityBaselineCategoryStateSummary using PATCH and returns a <see cref="GraphResponse{SecurityBaselineCategoryStateSummary}"/> object.
        /// </summary>
        /// <param name="securityBaselineCategoryStateSummaryToUpdate">The SecurityBaselineCategoryStateSummary to update.</param>
        /// <returns>The <see cref="GraphResponse{SecurityBaselineCategoryStateSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SecurityBaselineCategoryStateSummary>> UpdateResponseAsync(SecurityBaselineCategoryStateSummary securityBaselineCategoryStateSummaryToUpdate);

        /// <summary>
        /// Updates the specified SecurityBaselineCategoryStateSummary using PATCH and returns a <see cref="GraphResponse{SecurityBaselineCategoryStateSummary}"/> object.
        /// </summary>
        /// <param name="securityBaselineCategoryStateSummaryToUpdate">The SecurityBaselineCategoryStateSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SecurityBaselineCategoryStateSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SecurityBaselineCategoryStateSummary>> UpdateResponseAsync(SecurityBaselineCategoryStateSummary securityBaselineCategoryStateSummaryToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityBaselineCategoryStateSummaryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityBaselineCategoryStateSummaryRequest Expand(Expression<Func<SecurityBaselineCategoryStateSummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityBaselineCategoryStateSummaryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityBaselineCategoryStateSummaryRequest Select(Expression<Func<SecurityBaselineCategoryStateSummary, object>> selectExpression);

    }
}
