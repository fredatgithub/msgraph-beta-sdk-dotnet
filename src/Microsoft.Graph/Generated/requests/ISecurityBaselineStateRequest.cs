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
    /// The interface ISecurityBaselineStateRequest.
    /// </summary>
    public partial interface ISecurityBaselineStateRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SecurityBaselineState using POST.
        /// </summary>
        /// <param name="securityBaselineStateToCreate">The SecurityBaselineState to create.</param>
        /// <returns>The created SecurityBaselineState.</returns>
        System.Threading.Tasks.Task<SecurityBaselineState> CreateAsync(SecurityBaselineState securityBaselineStateToCreate);

        /// <summary>
        /// Creates the specified SecurityBaselineState using POST.
        /// </summary>
        /// <param name="securityBaselineStateToCreate">The SecurityBaselineState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SecurityBaselineState.</returns>
        System.Threading.Tasks.Task<SecurityBaselineState> CreateAsync(SecurityBaselineState securityBaselineStateToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified SecurityBaselineState using POST and returns a <see cref="GraphResponse{SecurityBaselineState}"/> object.
        /// </summary>
        /// <param name="securityBaselineStateToCreate">The SecurityBaselineState to create.</param>
        /// <returns>The <see cref="GraphResponse{SecurityBaselineState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SecurityBaselineState>> CreateResponseAsync(SecurityBaselineState securityBaselineStateToCreate);

        /// <summary>
        /// Creates the specified SecurityBaselineState using POST and returns a <see cref="GraphResponse{SecurityBaselineState}"/> object.
        /// </summary>
        /// <param name="securityBaselineStateToCreate">The SecurityBaselineState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SecurityBaselineState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SecurityBaselineState>> CreateResponseAsync(SecurityBaselineState securityBaselineStateToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified SecurityBaselineState.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified SecurityBaselineState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified SecurityBaselineState and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified SecurityBaselineState and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SecurityBaselineState.
        /// </summary>
        /// <returns>The SecurityBaselineState.</returns>
        System.Threading.Tasks.Task<SecurityBaselineState> GetAsync();

        /// <summary>
        /// Gets the specified SecurityBaselineState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SecurityBaselineState.</returns>
        System.Threading.Tasks.Task<SecurityBaselineState> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SecurityBaselineState and returns a <see cref="GraphResponse{SecurityBaselineState}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{SecurityBaselineState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SecurityBaselineState>> GetResponseAsync();

        /// <summary>
        /// Gets the specified SecurityBaselineState and returns a <see cref="GraphResponse{SecurityBaselineState}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SecurityBaselineState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SecurityBaselineState>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SecurityBaselineState using PATCH.
        /// </summary>
        /// <param name="securityBaselineStateToUpdate">The SecurityBaselineState to update.</param>
        /// <returns>The updated SecurityBaselineState.</returns>
        System.Threading.Tasks.Task<SecurityBaselineState> UpdateAsync(SecurityBaselineState securityBaselineStateToUpdate);

        /// <summary>
        /// Updates the specified SecurityBaselineState using PATCH.
        /// </summary>
        /// <param name="securityBaselineStateToUpdate">The SecurityBaselineState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SecurityBaselineState.</returns>
        System.Threading.Tasks.Task<SecurityBaselineState> UpdateAsync(SecurityBaselineState securityBaselineStateToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SecurityBaselineState using PATCH and returns a <see cref="GraphResponse{SecurityBaselineState}"/> object.
        /// </summary>
        /// <param name="securityBaselineStateToUpdate">The SecurityBaselineState to update.</param>
        /// <returns>The <see cref="GraphResponse{SecurityBaselineState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SecurityBaselineState>> UpdateResponseAsync(SecurityBaselineState securityBaselineStateToUpdate);

        /// <summary>
        /// Updates the specified SecurityBaselineState using PATCH and returns a <see cref="GraphResponse{SecurityBaselineState}"/> object.
        /// </summary>
        /// <param name="securityBaselineStateToUpdate">The SecurityBaselineState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SecurityBaselineState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SecurityBaselineState>> UpdateResponseAsync(SecurityBaselineState securityBaselineStateToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityBaselineStateRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityBaselineStateRequest Expand(Expression<Func<SecurityBaselineState, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityBaselineStateRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISecurityBaselineStateRequest Select(Expression<Func<SecurityBaselineState, object>> selectExpression);

    }
}
