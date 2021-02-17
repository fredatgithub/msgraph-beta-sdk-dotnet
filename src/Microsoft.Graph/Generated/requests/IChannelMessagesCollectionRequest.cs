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
    /// The interface IChannelMessagesCollectionRequest.
    /// </summary>
    public partial interface IChannelMessagesCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified ChatMessage to the collection via POST.
        /// </summary>
        /// <param name="chatMessage">The ChatMessage to add.</param>
        /// <returns>The created ChatMessage.</returns>
        System.Threading.Tasks.Task<ChatMessage> AddAsync(ChatMessage chatMessage);

        /// <summary>
        /// Adds the specified ChatMessage to the collection via POST.
        /// </summary>
        /// <param name="chatMessage">The ChatMessage to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ChatMessage.</returns>
        System.Threading.Tasks.Task<ChatMessage> AddAsync(ChatMessage chatMessage, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds the specified ChatMessage to the collection via POST and returns a <see cref="GraphResponse{ChatMessage}"/> object of the request.
        /// </summary>
        /// <param name="chatMessage">The ChatMessage to add.</param>
        /// <returns>The <see cref="GraphResponse{ChatMessage}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ChatMessage>> AddResponseAsync(ChatMessage chatMessage);

        /// <summary>
        /// Adds the specified ChatMessage to the collection via POST and returns a <see cref="GraphResponse{ChatMessage}"/> object of the request.
        /// </summary>
        /// <param name="chatMessage">The ChatMessage to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ChatMessage}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ChatMessage>> AddResponseAsync(ChatMessage chatMessage, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IChannelMessagesCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IChannelMessagesCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{ChannelMessagesCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{ChannelMessagesCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<ChannelMessagesCollectionResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{ChannelMessagesCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ChannelMessagesCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<ChannelMessagesCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IChannelMessagesCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IChannelMessagesCollectionRequest Expand(Expression<Func<ChatMessage, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IChannelMessagesCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IChannelMessagesCollectionRequest Select(Expression<Func<ChatMessage, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IChannelMessagesCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IChannelMessagesCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IChannelMessagesCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IChannelMessagesCollectionRequest OrderBy(string value);
    }
}
