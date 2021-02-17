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
    /// The interface IChatMembersCollectionRequest.
    /// </summary>
    public partial interface IChatMembersCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified ConversationMember to the collection via POST.
        /// </summary>
        /// <param name="conversationMember">The ConversationMember to add.</param>
        /// <returns>The created ConversationMember.</returns>
        System.Threading.Tasks.Task<ConversationMember> AddAsync(ConversationMember conversationMember);

        /// <summary>
        /// Adds the specified ConversationMember to the collection via POST.
        /// </summary>
        /// <param name="conversationMember">The ConversationMember to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ConversationMember.</returns>
        System.Threading.Tasks.Task<ConversationMember> AddAsync(ConversationMember conversationMember, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds the specified ConversationMember to the collection via POST and returns a <see cref="GraphResponse{ConversationMember}"/> object of the request.
        /// </summary>
        /// <param name="conversationMember">The ConversationMember to add.</param>
        /// <returns>The <see cref="GraphResponse{ConversationMember}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ConversationMember>> AddResponseAsync(ConversationMember conversationMember);

        /// <summary>
        /// Adds the specified ConversationMember to the collection via POST and returns a <see cref="GraphResponse{ConversationMember}"/> object of the request.
        /// </summary>
        /// <param name="conversationMember">The ConversationMember to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ConversationMember}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ConversationMember>> AddResponseAsync(ConversationMember conversationMember, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IChatMembersCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IChatMembersCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{ChatMembersCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{ChatMembersCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<ChatMembersCollectionResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{ChatMembersCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ChatMembersCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<ChatMembersCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IChatMembersCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IChatMembersCollectionRequest Expand(Expression<Func<ConversationMember, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IChatMembersCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IChatMembersCollectionRequest Select(Expression<Func<ConversationMember, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IChatMembersCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IChatMembersCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IChatMembersCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IChatMembersCollectionRequest OrderBy(string value);
    }
}
