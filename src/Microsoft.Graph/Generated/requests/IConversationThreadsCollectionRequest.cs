// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IConversationThreadsCollectionRequest.
    /// </summary>
    public partial interface IConversationThreadsCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified ConversationThread to the collection via POST.
        /// </summary>
        /// <param name="conversationThread">The ConversationThread to add.</param>
        /// <returns>The created ConversationThread.</returns>
        System.Threading.Tasks.Task<ConversationThread> AddAsync(ConversationThread conversationThread);

        /// <summary>
        /// Adds the specified ConversationThread to the collection via POST.
        /// </summary>
        /// <param name="conversationThread">The ConversationThread to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ConversationThread.</returns>
        System.Threading.Tasks.Task<ConversationThread> AddAsync(ConversationThread conversationThread, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds the specified ConversationThread to the collection via POST and returns a <see cref="GraphResponse{ConversationThread}"/> object of the request.
        /// </summary>
        /// <param name="conversationThread">The ConversationThread to add.</param>
        /// <returns>The <see cref="GraphResponse{ConversationThread}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ConversationThread>> AddResponseAsync(ConversationThread conversationThread);

        /// <summary>
        /// Adds the specified ConversationThread to the collection via POST and returns a <see cref="GraphResponse{ConversationThread}"/> object of the request.
        /// </summary>
        /// <param name="conversationThread">The ConversationThread to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ConversationThread}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ConversationThread>> AddResponseAsync(ConversationThread conversationThread, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IConversationThreadsCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IConversationThreadsCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{ConversationThreadsCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{ConversationThreadsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<ConversationThreadsCollectionResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{ConversationThreadsCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ConversationThreadsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<ConversationThreadsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IConversationThreadsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IConversationThreadsCollectionRequest Expand(Expression<Func<ConversationThread, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IConversationThreadsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IConversationThreadsCollectionRequest Select(Expression<Func<ConversationThread, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IConversationThreadsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IConversationThreadsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IConversationThreadsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IConversationThreadsCollectionRequest OrderBy(string value);
    }
}
