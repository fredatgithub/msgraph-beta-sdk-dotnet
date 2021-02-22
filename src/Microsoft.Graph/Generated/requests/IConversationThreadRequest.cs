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
    /// The interface IConversationThreadRequest.
    /// </summary>
    public partial interface IConversationThreadRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ConversationThread using POST.
        /// </summary>
        /// <param name="conversationThreadToCreate">The ConversationThread to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ConversationThread.</returns>
        System.Threading.Tasks.Task<ConversationThread> CreateAsync(ConversationThread conversationThreadToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified ConversationThread using POST and returns a <see cref="GraphResponse{ConversationThread}"/> object.
        /// </summary>
        /// <param name="conversationThreadToCreate">The ConversationThread to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ConversationThread}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ConversationThread>> CreateResponseAsync(ConversationThread conversationThreadToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ConversationThread.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ConversationThread and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified ConversationThread.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ConversationThread.</returns>
        System.Threading.Tasks.Task<ConversationThread> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified ConversationThread and returns a <see cref="GraphResponse{ConversationThread}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ConversationThread}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ConversationThread>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ConversationThread using PATCH.
        /// </summary>
        /// <param name="conversationThreadToUpdate">The ConversationThread to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ConversationThread.</returns>
        System.Threading.Tasks.Task<ConversationThread> UpdateAsync(ConversationThread conversationThreadToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ConversationThread using PATCH and returns a <see cref="GraphResponse{ConversationThread}"/> object.
        /// </summary>
        /// <param name="conversationThreadToUpdate">The ConversationThread to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ConversationThread}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ConversationThread>> UpdateResponseAsync(ConversationThread conversationThreadToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IConversationThreadRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IConversationThreadRequest Expand(Expression<Func<ConversationThread, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IConversationThreadRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IConversationThreadRequest Select(Expression<Func<ConversationThread, object>> selectExpression);

    }
}
