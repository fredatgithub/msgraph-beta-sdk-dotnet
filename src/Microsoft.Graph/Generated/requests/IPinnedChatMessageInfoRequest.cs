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
    /// The interface IPinnedChatMessageInfoRequest.
    /// </summary>
    public partial interface IPinnedChatMessageInfoRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PinnedChatMessageInfo using POST.
        /// </summary>
        /// <param name="pinnedChatMessageInfoToCreate">The PinnedChatMessageInfo to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PinnedChatMessageInfo.</returns>
        System.Threading.Tasks.Task<PinnedChatMessageInfo> CreateAsync(PinnedChatMessageInfo pinnedChatMessageInfoToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified PinnedChatMessageInfo using POST and returns a <see cref="GraphResponse{PinnedChatMessageInfo}"/> object.
        /// </summary>
        /// <param name="pinnedChatMessageInfoToCreate">The PinnedChatMessageInfo to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PinnedChatMessageInfo}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PinnedChatMessageInfo>> CreateResponseAsync(PinnedChatMessageInfo pinnedChatMessageInfoToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified PinnedChatMessageInfo.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified PinnedChatMessageInfo and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified PinnedChatMessageInfo.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PinnedChatMessageInfo.</returns>
        System.Threading.Tasks.Task<PinnedChatMessageInfo> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified PinnedChatMessageInfo and returns a <see cref="GraphResponse{PinnedChatMessageInfo}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PinnedChatMessageInfo}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PinnedChatMessageInfo>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified PinnedChatMessageInfo using PATCH.
        /// </summary>
        /// <param name="pinnedChatMessageInfoToUpdate">The PinnedChatMessageInfo to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PinnedChatMessageInfo.</returns>
        System.Threading.Tasks.Task<PinnedChatMessageInfo> UpdateAsync(PinnedChatMessageInfo pinnedChatMessageInfoToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified PinnedChatMessageInfo using PATCH and returns a <see cref="GraphResponse{PinnedChatMessageInfo}"/> object.
        /// </summary>
        /// <param name="pinnedChatMessageInfoToUpdate">The PinnedChatMessageInfo to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PinnedChatMessageInfo}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PinnedChatMessageInfo>> UpdateResponseAsync(PinnedChatMessageInfo pinnedChatMessageInfoToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified PinnedChatMessageInfo using PUT.
        /// </summary>
        /// <param name="pinnedChatMessageInfoToUpdate">The PinnedChatMessageInfo object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<PinnedChatMessageInfo> PutAsync(PinnedChatMessageInfo pinnedChatMessageInfoToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified PinnedChatMessageInfo using PUT and returns a <see cref="GraphResponse{PinnedChatMessageInfo}"/> object.
        /// </summary>
        /// <param name="pinnedChatMessageInfoToUpdate">The PinnedChatMessageInfo object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{PinnedChatMessageInfo}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<PinnedChatMessageInfo>> PutResponseAsync(PinnedChatMessageInfo pinnedChatMessageInfoToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPinnedChatMessageInfoRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPinnedChatMessageInfoRequest Expand(Expression<Func<PinnedChatMessageInfo, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPinnedChatMessageInfoRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPinnedChatMessageInfoRequest Select(Expression<Func<PinnedChatMessageInfo, object>> selectExpression);

    }
}
