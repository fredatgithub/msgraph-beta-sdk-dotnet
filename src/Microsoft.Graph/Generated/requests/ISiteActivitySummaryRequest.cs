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
    /// The interface ISiteActivitySummaryRequest.
    /// </summary>
    public partial interface ISiteActivitySummaryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SiteActivitySummary using POST.
        /// </summary>
        /// <param name="siteActivitySummaryToCreate">The SiteActivitySummary to create.</param>
        /// <returns>The created SiteActivitySummary.</returns>
        System.Threading.Tasks.Task<SiteActivitySummary> CreateAsync(SiteActivitySummary siteActivitySummaryToCreate);

        /// <summary>
        /// Creates the specified SiteActivitySummary using POST.
        /// </summary>
        /// <param name="siteActivitySummaryToCreate">The SiteActivitySummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SiteActivitySummary.</returns>
        System.Threading.Tasks.Task<SiteActivitySummary> CreateAsync(SiteActivitySummary siteActivitySummaryToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified SiteActivitySummary using POST and returns a <see cref="GraphResponse{SiteActivitySummary}"/> object.
        /// </summary>
        /// <param name="siteActivitySummaryToCreate">The SiteActivitySummary to create.</param>
        /// <returns>The <see cref="GraphResponse{SiteActivitySummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SiteActivitySummary>> CreateResponseAsync(SiteActivitySummary siteActivitySummaryToCreate);

        /// <summary>
        /// Creates the specified SiteActivitySummary using POST and returns a <see cref="GraphResponse{SiteActivitySummary}"/> object.
        /// </summary>
        /// <param name="siteActivitySummaryToCreate">The SiteActivitySummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SiteActivitySummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SiteActivitySummary>> CreateResponseAsync(SiteActivitySummary siteActivitySummaryToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified SiteActivitySummary.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified SiteActivitySummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified SiteActivitySummary and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified SiteActivitySummary and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SiteActivitySummary.
        /// </summary>
        /// <returns>The SiteActivitySummary.</returns>
        System.Threading.Tasks.Task<SiteActivitySummary> GetAsync();

        /// <summary>
        /// Gets the specified SiteActivitySummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SiteActivitySummary.</returns>
        System.Threading.Tasks.Task<SiteActivitySummary> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SiteActivitySummary and returns a <see cref="GraphResponse{SiteActivitySummary}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{SiteActivitySummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SiteActivitySummary>> GetResponseAsync();

        /// <summary>
        /// Gets the specified SiteActivitySummary and returns a <see cref="GraphResponse{SiteActivitySummary}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SiteActivitySummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SiteActivitySummary>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SiteActivitySummary using PATCH.
        /// </summary>
        /// <param name="siteActivitySummaryToUpdate">The SiteActivitySummary to update.</param>
        /// <returns>The updated SiteActivitySummary.</returns>
        System.Threading.Tasks.Task<SiteActivitySummary> UpdateAsync(SiteActivitySummary siteActivitySummaryToUpdate);

        /// <summary>
        /// Updates the specified SiteActivitySummary using PATCH.
        /// </summary>
        /// <param name="siteActivitySummaryToUpdate">The SiteActivitySummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SiteActivitySummary.</returns>
        System.Threading.Tasks.Task<SiteActivitySummary> UpdateAsync(SiteActivitySummary siteActivitySummaryToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SiteActivitySummary using PATCH and returns a <see cref="GraphResponse{SiteActivitySummary}"/> object.
        /// </summary>
        /// <param name="siteActivitySummaryToUpdate">The SiteActivitySummary to update.</param>
        /// <returns>The <see cref="GraphResponse{SiteActivitySummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SiteActivitySummary>> UpdateResponseAsync(SiteActivitySummary siteActivitySummaryToUpdate);

        /// <summary>
        /// Updates the specified SiteActivitySummary using PATCH and returns a <see cref="GraphResponse{SiteActivitySummary}"/> object.
        /// </summary>
        /// <param name="siteActivitySummaryToUpdate">The SiteActivitySummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SiteActivitySummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SiteActivitySummary>> UpdateResponseAsync(SiteActivitySummary siteActivitySummaryToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISiteActivitySummaryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISiteActivitySummaryRequest Expand(Expression<Func<SiteActivitySummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISiteActivitySummaryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISiteActivitySummaryRequest Select(Expression<Func<SiteActivitySummary, object>> selectExpression);

    }
}
