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
    /// The interface ISkypeForBusinessDeviceUsageDistributionUserCountsRequest.
    /// </summary>
    public partial interface ISkypeForBusinessDeviceUsageDistributionUserCountsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SkypeForBusinessDeviceUsageDistributionUserCounts using POST.
        /// </summary>
        /// <param name="skypeForBusinessDeviceUsageDistributionUserCountsToCreate">The SkypeForBusinessDeviceUsageDistributionUserCounts to create.</param>
        /// <returns>The created SkypeForBusinessDeviceUsageDistributionUserCounts.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessDeviceUsageDistributionUserCounts> CreateAsync(SkypeForBusinessDeviceUsageDistributionUserCounts skypeForBusinessDeviceUsageDistributionUserCountsToCreate);

        /// <summary>
        /// Creates the specified SkypeForBusinessDeviceUsageDistributionUserCounts using POST.
        /// </summary>
        /// <param name="skypeForBusinessDeviceUsageDistributionUserCountsToCreate">The SkypeForBusinessDeviceUsageDistributionUserCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SkypeForBusinessDeviceUsageDistributionUserCounts.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessDeviceUsageDistributionUserCounts> CreateAsync(SkypeForBusinessDeviceUsageDistributionUserCounts skypeForBusinessDeviceUsageDistributionUserCountsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified SkypeForBusinessDeviceUsageDistributionUserCounts using POST and returns a <see cref="GraphResponse{SkypeForBusinessDeviceUsageDistributionUserCounts}"/> object.
        /// </summary>
        /// <param name="skypeForBusinessDeviceUsageDistributionUserCountsToCreate">The SkypeForBusinessDeviceUsageDistributionUserCounts to create.</param>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessDeviceUsageDistributionUserCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessDeviceUsageDistributionUserCounts>> CreateResponseAsync(SkypeForBusinessDeviceUsageDistributionUserCounts skypeForBusinessDeviceUsageDistributionUserCountsToCreate);

        /// <summary>
        /// Creates the specified SkypeForBusinessDeviceUsageDistributionUserCounts using POST and returns a <see cref="GraphResponse{SkypeForBusinessDeviceUsageDistributionUserCounts}"/> object.
        /// </summary>
        /// <param name="skypeForBusinessDeviceUsageDistributionUserCountsToCreate">The SkypeForBusinessDeviceUsageDistributionUserCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessDeviceUsageDistributionUserCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessDeviceUsageDistributionUserCounts>> CreateResponseAsync(SkypeForBusinessDeviceUsageDistributionUserCounts skypeForBusinessDeviceUsageDistributionUserCountsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified SkypeForBusinessDeviceUsageDistributionUserCounts.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified SkypeForBusinessDeviceUsageDistributionUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified SkypeForBusinessDeviceUsageDistributionUserCounts and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified SkypeForBusinessDeviceUsageDistributionUserCounts and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SkypeForBusinessDeviceUsageDistributionUserCounts.
        /// </summary>
        /// <returns>The SkypeForBusinessDeviceUsageDistributionUserCounts.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessDeviceUsageDistributionUserCounts> GetAsync();

        /// <summary>
        /// Gets the specified SkypeForBusinessDeviceUsageDistributionUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SkypeForBusinessDeviceUsageDistributionUserCounts.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessDeviceUsageDistributionUserCounts> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SkypeForBusinessDeviceUsageDistributionUserCounts and returns a <see cref="GraphResponse{SkypeForBusinessDeviceUsageDistributionUserCounts}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessDeviceUsageDistributionUserCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessDeviceUsageDistributionUserCounts>> GetResponseAsync();

        /// <summary>
        /// Gets the specified SkypeForBusinessDeviceUsageDistributionUserCounts and returns a <see cref="GraphResponse{SkypeForBusinessDeviceUsageDistributionUserCounts}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessDeviceUsageDistributionUserCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessDeviceUsageDistributionUserCounts>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SkypeForBusinessDeviceUsageDistributionUserCounts using PATCH.
        /// </summary>
        /// <param name="skypeForBusinessDeviceUsageDistributionUserCountsToUpdate">The SkypeForBusinessDeviceUsageDistributionUserCounts to update.</param>
        /// <returns>The updated SkypeForBusinessDeviceUsageDistributionUserCounts.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessDeviceUsageDistributionUserCounts> UpdateAsync(SkypeForBusinessDeviceUsageDistributionUserCounts skypeForBusinessDeviceUsageDistributionUserCountsToUpdate);

        /// <summary>
        /// Updates the specified SkypeForBusinessDeviceUsageDistributionUserCounts using PATCH.
        /// </summary>
        /// <param name="skypeForBusinessDeviceUsageDistributionUserCountsToUpdate">The SkypeForBusinessDeviceUsageDistributionUserCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SkypeForBusinessDeviceUsageDistributionUserCounts.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessDeviceUsageDistributionUserCounts> UpdateAsync(SkypeForBusinessDeviceUsageDistributionUserCounts skypeForBusinessDeviceUsageDistributionUserCountsToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SkypeForBusinessDeviceUsageDistributionUserCounts using PATCH and returns a <see cref="GraphResponse{SkypeForBusinessDeviceUsageDistributionUserCounts}"/> object.
        /// </summary>
        /// <param name="skypeForBusinessDeviceUsageDistributionUserCountsToUpdate">The SkypeForBusinessDeviceUsageDistributionUserCounts to update.</param>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessDeviceUsageDistributionUserCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessDeviceUsageDistributionUserCounts>> UpdateResponseAsync(SkypeForBusinessDeviceUsageDistributionUserCounts skypeForBusinessDeviceUsageDistributionUserCountsToUpdate);

        /// <summary>
        /// Updates the specified SkypeForBusinessDeviceUsageDistributionUserCounts using PATCH and returns a <see cref="GraphResponse{SkypeForBusinessDeviceUsageDistributionUserCounts}"/> object.
        /// </summary>
        /// <param name="skypeForBusinessDeviceUsageDistributionUserCountsToUpdate">The SkypeForBusinessDeviceUsageDistributionUserCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessDeviceUsageDistributionUserCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessDeviceUsageDistributionUserCounts>> UpdateResponseAsync(SkypeForBusinessDeviceUsageDistributionUserCounts skypeForBusinessDeviceUsageDistributionUserCountsToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISkypeForBusinessDeviceUsageDistributionUserCountsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISkypeForBusinessDeviceUsageDistributionUserCountsRequest Expand(Expression<Func<SkypeForBusinessDeviceUsageDistributionUserCounts, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISkypeForBusinessDeviceUsageDistributionUserCountsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISkypeForBusinessDeviceUsageDistributionUserCountsRequest Select(Expression<Func<SkypeForBusinessDeviceUsageDistributionUserCounts, object>> selectExpression);

    }
}
