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
    /// The interface ISkypeForBusinessPeerToPeerActivityCountsRequest.
    /// </summary>
    public partial interface ISkypeForBusinessPeerToPeerActivityCountsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SkypeForBusinessPeerToPeerActivityCounts using POST.
        /// </summary>
        /// <param name="skypeForBusinessPeerToPeerActivityCountsToCreate">The SkypeForBusinessPeerToPeerActivityCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SkypeForBusinessPeerToPeerActivityCounts.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessPeerToPeerActivityCounts> CreateAsync(SkypeForBusinessPeerToPeerActivityCounts skypeForBusinessPeerToPeerActivityCountsToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified SkypeForBusinessPeerToPeerActivityCounts using POST and returns a <see cref="GraphResponse{SkypeForBusinessPeerToPeerActivityCounts}"/> object.
        /// </summary>
        /// <param name="skypeForBusinessPeerToPeerActivityCountsToCreate">The SkypeForBusinessPeerToPeerActivityCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessPeerToPeerActivityCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessPeerToPeerActivityCounts>> CreateResponseAsync(SkypeForBusinessPeerToPeerActivityCounts skypeForBusinessPeerToPeerActivityCountsToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified SkypeForBusinessPeerToPeerActivityCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified SkypeForBusinessPeerToPeerActivityCounts and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified SkypeForBusinessPeerToPeerActivityCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SkypeForBusinessPeerToPeerActivityCounts.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessPeerToPeerActivityCounts> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified SkypeForBusinessPeerToPeerActivityCounts and returns a <see cref="GraphResponse{SkypeForBusinessPeerToPeerActivityCounts}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessPeerToPeerActivityCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessPeerToPeerActivityCounts>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified SkypeForBusinessPeerToPeerActivityCounts using PATCH.
        /// </summary>
        /// <param name="skypeForBusinessPeerToPeerActivityCountsToUpdate">The SkypeForBusinessPeerToPeerActivityCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SkypeForBusinessPeerToPeerActivityCounts.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessPeerToPeerActivityCounts> UpdateAsync(SkypeForBusinessPeerToPeerActivityCounts skypeForBusinessPeerToPeerActivityCountsToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified SkypeForBusinessPeerToPeerActivityCounts using PATCH and returns a <see cref="GraphResponse{SkypeForBusinessPeerToPeerActivityCounts}"/> object.
        /// </summary>
        /// <param name="skypeForBusinessPeerToPeerActivityCountsToUpdate">The SkypeForBusinessPeerToPeerActivityCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessPeerToPeerActivityCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessPeerToPeerActivityCounts>> UpdateResponseAsync(SkypeForBusinessPeerToPeerActivityCounts skypeForBusinessPeerToPeerActivityCountsToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISkypeForBusinessPeerToPeerActivityCountsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISkypeForBusinessPeerToPeerActivityCountsRequest Expand(Expression<Func<SkypeForBusinessPeerToPeerActivityCounts, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISkypeForBusinessPeerToPeerActivityCountsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISkypeForBusinessPeerToPeerActivityCountsRequest Select(Expression<Func<SkypeForBusinessPeerToPeerActivityCounts, object>> selectExpression);

    }
}
