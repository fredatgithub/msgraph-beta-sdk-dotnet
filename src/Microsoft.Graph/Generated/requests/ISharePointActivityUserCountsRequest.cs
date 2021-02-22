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
    /// The interface ISharePointActivityUserCountsRequest.
    /// </summary>
    public partial interface ISharePointActivityUserCountsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SharePointActivityUserCounts using POST.
        /// </summary>
        /// <param name="sharePointActivityUserCountsToCreate">The SharePointActivityUserCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SharePointActivityUserCounts.</returns>
        System.Threading.Tasks.Task<SharePointActivityUserCounts> CreateAsync(SharePointActivityUserCounts sharePointActivityUserCountsToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified SharePointActivityUserCounts using POST and returns a <see cref="GraphResponse{SharePointActivityUserCounts}"/> object.
        /// </summary>
        /// <param name="sharePointActivityUserCountsToCreate">The SharePointActivityUserCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SharePointActivityUserCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SharePointActivityUserCounts>> CreateResponseAsync(SharePointActivityUserCounts sharePointActivityUserCountsToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified SharePointActivityUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified SharePointActivityUserCounts and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified SharePointActivityUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SharePointActivityUserCounts.</returns>
        System.Threading.Tasks.Task<SharePointActivityUserCounts> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified SharePointActivityUserCounts and returns a <see cref="GraphResponse{SharePointActivityUserCounts}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SharePointActivityUserCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SharePointActivityUserCounts>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified SharePointActivityUserCounts using PATCH.
        /// </summary>
        /// <param name="sharePointActivityUserCountsToUpdate">The SharePointActivityUserCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SharePointActivityUserCounts.</returns>
        System.Threading.Tasks.Task<SharePointActivityUserCounts> UpdateAsync(SharePointActivityUserCounts sharePointActivityUserCountsToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified SharePointActivityUserCounts using PATCH and returns a <see cref="GraphResponse{SharePointActivityUserCounts}"/> object.
        /// </summary>
        /// <param name="sharePointActivityUserCountsToUpdate">The SharePointActivityUserCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SharePointActivityUserCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SharePointActivityUserCounts>> UpdateResponseAsync(SharePointActivityUserCounts sharePointActivityUserCountsToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISharePointActivityUserCountsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISharePointActivityUserCountsRequest Expand(Expression<Func<SharePointActivityUserCounts, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISharePointActivityUserCountsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISharePointActivityUserCountsRequest Select(Expression<Func<SharePointActivityUserCounts, object>> selectExpression);

    }
}
