// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ICaseTagsCollectionRequest.
    /// </summary>
    public partial interface ICaseTagsCollectionRequest : Microsoft.Graph.IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified Tag to the collection via POST.
        /// </summary>
        /// <param name="tag">The Tag to add.</param>
        /// <returns>The created Tag.</returns>
        System.Threading.Tasks.Task<Tag> AddAsync(Tag tag);

        /// <summary>
        /// Adds the specified Tag to the collection via POST.
        /// </summary>
        /// <param name="tag">The Tag to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Tag.</returns>
        System.Threading.Tasks.Task<Tag> AddAsync(Tag tag, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds the specified Tag to the collection via POST and returns a <see cref="GraphResponse{Tag}"/> object of the request.
        /// </summary>
        /// <param name="tag">The Tag to add.</param>
        /// <returns>The <see cref="GraphResponse{Tag}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Tag>> AddResponseAsync(Tag tag);

        /// <summary>
        /// Adds the specified Tag to the collection via POST and returns a <see cref="GraphResponse{Tag}"/> object of the request.
        /// </summary>
        /// <param name="tag">The Tag to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Tag}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Tag>> AddResponseAsync(Tag tag, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<ICaseTagsCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<ICaseTagsCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{CaseTagsCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{CaseTagsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<CaseTagsCollectionResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{CaseTagsCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CaseTagsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<CaseTagsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICaseTagsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICaseTagsCollectionRequest Expand(Expression<Func<Tag, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICaseTagsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICaseTagsCollectionRequest Select(Expression<Func<Tag, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        ICaseTagsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        ICaseTagsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        ICaseTagsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        ICaseTagsCollectionRequest OrderBy(string value);
    }
}
