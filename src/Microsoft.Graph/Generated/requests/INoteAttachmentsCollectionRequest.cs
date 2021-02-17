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
    /// The interface INoteAttachmentsCollectionRequest.
    /// </summary>
    public partial interface INoteAttachmentsCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified Attachment to the collection via POST.
        /// </summary>
        /// <param name="attachment">The Attachment to add.</param>
        /// <returns>The created Attachment.</returns>
        System.Threading.Tasks.Task<Attachment> AddAsync(Attachment attachment);

        /// <summary>
        /// Adds the specified Attachment to the collection via POST.
        /// </summary>
        /// <param name="attachment">The Attachment to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Attachment.</returns>
        System.Threading.Tasks.Task<Attachment> AddAsync(Attachment attachment, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds the specified Attachment to the collection via POST and returns a <see cref="GraphResponse{Attachment}"/> object of the request.
        /// </summary>
        /// <param name="attachment">The Attachment to add.</param>
        /// <returns>The <see cref="GraphResponse{Attachment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Attachment>> AddResponseAsync(Attachment attachment);

        /// <summary>
        /// Adds the specified Attachment to the collection via POST and returns a <see cref="GraphResponse{Attachment}"/> object of the request.
        /// </summary>
        /// <param name="attachment">The Attachment to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Attachment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Attachment>> AddResponseAsync(Attachment attachment, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<INoteAttachmentsCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<INoteAttachmentsCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{NoteAttachmentsCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{NoteAttachmentsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<NoteAttachmentsCollectionResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{NoteAttachmentsCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{NoteAttachmentsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<NoteAttachmentsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        INoteAttachmentsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        INoteAttachmentsCollectionRequest Expand(Expression<Func<Attachment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        INoteAttachmentsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        INoteAttachmentsCollectionRequest Select(Expression<Func<Attachment, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        INoteAttachmentsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        INoteAttachmentsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        INoteAttachmentsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        INoteAttachmentsCollectionRequest OrderBy(string value);
    }
}
