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
    /// The interface IRiskyUserHistoryItemRequest.
    /// </summary>
    public partial interface IRiskyUserHistoryItemRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified RiskyUserHistoryItem using POST.
        /// </summary>
        /// <param name="riskyUserHistoryItemToCreate">The RiskyUserHistoryItem to create.</param>
        /// <returns>The created RiskyUserHistoryItem.</returns>
        System.Threading.Tasks.Task<RiskyUserHistoryItem> CreateAsync(RiskyUserHistoryItem riskyUserHistoryItemToCreate);

        /// <summary>
        /// Creates the specified RiskyUserHistoryItem using POST.
        /// </summary>
        /// <param name="riskyUserHistoryItemToCreate">The RiskyUserHistoryItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created RiskyUserHistoryItem.</returns>
        System.Threading.Tasks.Task<RiskyUserHistoryItem> CreateAsync(RiskyUserHistoryItem riskyUserHistoryItemToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified RiskyUserHistoryItem using POST and returns a <see cref="GraphResponse{RiskyUserHistoryItem}"/> object.
        /// </summary>
        /// <param name="riskyUserHistoryItemToCreate">The RiskyUserHistoryItem to create.</param>
        /// <returns>The <see cref="GraphResponse{RiskyUserHistoryItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RiskyUserHistoryItem>> CreateResponseAsync(RiskyUserHistoryItem riskyUserHistoryItemToCreate);

        /// <summary>
        /// Creates the specified RiskyUserHistoryItem using POST and returns a <see cref="GraphResponse{RiskyUserHistoryItem}"/> object.
        /// </summary>
        /// <param name="riskyUserHistoryItemToCreate">The RiskyUserHistoryItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{RiskyUserHistoryItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RiskyUserHistoryItem>> CreateResponseAsync(RiskyUserHistoryItem riskyUserHistoryItemToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified RiskyUserHistoryItem.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified RiskyUserHistoryItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified RiskyUserHistoryItem and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified RiskyUserHistoryItem and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified RiskyUserHistoryItem.
        /// </summary>
        /// <returns>The RiskyUserHistoryItem.</returns>
        System.Threading.Tasks.Task<RiskyUserHistoryItem> GetAsync();

        /// <summary>
        /// Gets the specified RiskyUserHistoryItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The RiskyUserHistoryItem.</returns>
        System.Threading.Tasks.Task<RiskyUserHistoryItem> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified RiskyUserHistoryItem and returns a <see cref="GraphResponse{RiskyUserHistoryItem}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{RiskyUserHistoryItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RiskyUserHistoryItem>> GetResponseAsync();

        /// <summary>
        /// Gets the specified RiskyUserHistoryItem and returns a <see cref="GraphResponse{RiskyUserHistoryItem}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{RiskyUserHistoryItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RiskyUserHistoryItem>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified RiskyUserHistoryItem using PATCH.
        /// </summary>
        /// <param name="riskyUserHistoryItemToUpdate">The RiskyUserHistoryItem to update.</param>
        /// <returns>The updated RiskyUserHistoryItem.</returns>
        System.Threading.Tasks.Task<RiskyUserHistoryItem> UpdateAsync(RiskyUserHistoryItem riskyUserHistoryItemToUpdate);

        /// <summary>
        /// Updates the specified RiskyUserHistoryItem using PATCH.
        /// </summary>
        /// <param name="riskyUserHistoryItemToUpdate">The RiskyUserHistoryItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated RiskyUserHistoryItem.</returns>
        System.Threading.Tasks.Task<RiskyUserHistoryItem> UpdateAsync(RiskyUserHistoryItem riskyUserHistoryItemToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified RiskyUserHistoryItem using PATCH and returns a <see cref="GraphResponse{RiskyUserHistoryItem}"/> object.
        /// </summary>
        /// <param name="riskyUserHistoryItemToUpdate">The RiskyUserHistoryItem to update.</param>
        /// <returns>The <see cref="GraphResponse{RiskyUserHistoryItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RiskyUserHistoryItem>> UpdateResponseAsync(RiskyUserHistoryItem riskyUserHistoryItemToUpdate);

        /// <summary>
        /// Updates the specified RiskyUserHistoryItem using PATCH and returns a <see cref="GraphResponse{RiskyUserHistoryItem}"/> object.
        /// </summary>
        /// <param name="riskyUserHistoryItemToUpdate">The RiskyUserHistoryItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{RiskyUserHistoryItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RiskyUserHistoryItem>> UpdateResponseAsync(RiskyUserHistoryItem riskyUserHistoryItemToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IRiskyUserHistoryItemRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IRiskyUserHistoryItemRequest Expand(Expression<Func<RiskyUserHistoryItem, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IRiskyUserHistoryItemRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IRiskyUserHistoryItemRequest Select(Expression<Func<RiskyUserHistoryItem, object>> selectExpression);

    }
}
