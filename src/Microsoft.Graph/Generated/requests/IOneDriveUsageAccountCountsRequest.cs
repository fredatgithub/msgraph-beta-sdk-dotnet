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
    /// The interface IOneDriveUsageAccountCountsRequest.
    /// </summary>
    public partial interface IOneDriveUsageAccountCountsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified OneDriveUsageAccountCounts using POST.
        /// </summary>
        /// <param name="oneDriveUsageAccountCountsToCreate">The OneDriveUsageAccountCounts to create.</param>
        /// <returns>The created OneDriveUsageAccountCounts.</returns>
        System.Threading.Tasks.Task<OneDriveUsageAccountCounts> CreateAsync(OneDriveUsageAccountCounts oneDriveUsageAccountCountsToCreate);

        /// <summary>
        /// Creates the specified OneDriveUsageAccountCounts using POST.
        /// </summary>
        /// <param name="oneDriveUsageAccountCountsToCreate">The OneDriveUsageAccountCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OneDriveUsageAccountCounts.</returns>
        System.Threading.Tasks.Task<OneDriveUsageAccountCounts> CreateAsync(OneDriveUsageAccountCounts oneDriveUsageAccountCountsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified OneDriveUsageAccountCounts using POST and returns a <see cref="GraphResponse{OneDriveUsageAccountCounts}"/> object.
        /// </summary>
        /// <param name="oneDriveUsageAccountCountsToCreate">The OneDriveUsageAccountCounts to create.</param>
        /// <returns>The <see cref="GraphResponse{OneDriveUsageAccountCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OneDriveUsageAccountCounts>> CreateResponseAsync(OneDriveUsageAccountCounts oneDriveUsageAccountCountsToCreate);

        /// <summary>
        /// Creates the specified OneDriveUsageAccountCounts using POST and returns a <see cref="GraphResponse{OneDriveUsageAccountCounts}"/> object.
        /// </summary>
        /// <param name="oneDriveUsageAccountCountsToCreate">The OneDriveUsageAccountCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OneDriveUsageAccountCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OneDriveUsageAccountCounts>> CreateResponseAsync(OneDriveUsageAccountCounts oneDriveUsageAccountCountsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified OneDriveUsageAccountCounts.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified OneDriveUsageAccountCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified OneDriveUsageAccountCounts and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified OneDriveUsageAccountCounts and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified OneDriveUsageAccountCounts.
        /// </summary>
        /// <returns>The OneDriveUsageAccountCounts.</returns>
        System.Threading.Tasks.Task<OneDriveUsageAccountCounts> GetAsync();

        /// <summary>
        /// Gets the specified OneDriveUsageAccountCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OneDriveUsageAccountCounts.</returns>
        System.Threading.Tasks.Task<OneDriveUsageAccountCounts> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified OneDriveUsageAccountCounts and returns a <see cref="GraphResponse{OneDriveUsageAccountCounts}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{OneDriveUsageAccountCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OneDriveUsageAccountCounts>> GetResponseAsync();

        /// <summary>
        /// Gets the specified OneDriveUsageAccountCounts and returns a <see cref="GraphResponse{OneDriveUsageAccountCounts}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OneDriveUsageAccountCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OneDriveUsageAccountCounts>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified OneDriveUsageAccountCounts using PATCH.
        /// </summary>
        /// <param name="oneDriveUsageAccountCountsToUpdate">The OneDriveUsageAccountCounts to update.</param>
        /// <returns>The updated OneDriveUsageAccountCounts.</returns>
        System.Threading.Tasks.Task<OneDriveUsageAccountCounts> UpdateAsync(OneDriveUsageAccountCounts oneDriveUsageAccountCountsToUpdate);

        /// <summary>
        /// Updates the specified OneDriveUsageAccountCounts using PATCH.
        /// </summary>
        /// <param name="oneDriveUsageAccountCountsToUpdate">The OneDriveUsageAccountCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OneDriveUsageAccountCounts.</returns>
        System.Threading.Tasks.Task<OneDriveUsageAccountCounts> UpdateAsync(OneDriveUsageAccountCounts oneDriveUsageAccountCountsToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified OneDriveUsageAccountCounts using PATCH and returns a <see cref="GraphResponse{OneDriveUsageAccountCounts}"/> object.
        /// </summary>
        /// <param name="oneDriveUsageAccountCountsToUpdate">The OneDriveUsageAccountCounts to update.</param>
        /// <returns>The <see cref="GraphResponse{OneDriveUsageAccountCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OneDriveUsageAccountCounts>> UpdateResponseAsync(OneDriveUsageAccountCounts oneDriveUsageAccountCountsToUpdate);

        /// <summary>
        /// Updates the specified OneDriveUsageAccountCounts using PATCH and returns a <see cref="GraphResponse{OneDriveUsageAccountCounts}"/> object.
        /// </summary>
        /// <param name="oneDriveUsageAccountCountsToUpdate">The OneDriveUsageAccountCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{OneDriveUsageAccountCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OneDriveUsageAccountCounts>> UpdateResponseAsync(OneDriveUsageAccountCounts oneDriveUsageAccountCountsToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOneDriveUsageAccountCountsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOneDriveUsageAccountCountsRequest Expand(Expression<Func<OneDriveUsageAccountCounts, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOneDriveUsageAccountCountsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOneDriveUsageAccountCountsRequest Select(Expression<Func<OneDriveUsageAccountCounts, object>> selectExpression);

    }
}
