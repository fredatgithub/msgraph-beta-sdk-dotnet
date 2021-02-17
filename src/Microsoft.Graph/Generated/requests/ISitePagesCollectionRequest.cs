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
    /// The interface ISitePagesCollectionRequest.
    /// </summary>
    public partial interface ISitePagesCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified SitePage to the collection via POST.
        /// </summary>
        /// <param name="sitePage">The SitePage to add.</param>
        /// <returns>The created SitePage.</returns>
        System.Threading.Tasks.Task<SitePage> AddAsync(SitePage sitePage);

        /// <summary>
        /// Adds the specified SitePage to the collection via POST.
        /// </summary>
        /// <param name="sitePage">The SitePage to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SitePage.</returns>
        System.Threading.Tasks.Task<SitePage> AddAsync(SitePage sitePage, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds the specified SitePage to the collection via POST and returns a <see cref="GraphResponse{SitePage}"/> object of the request.
        /// </summary>
        /// <param name="sitePage">The SitePage to add.</param>
        /// <returns>The <see cref="GraphResponse{SitePage}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SitePage>> AddResponseAsync(SitePage sitePage);

        /// <summary>
        /// Adds the specified SitePage to the collection via POST and returns a <see cref="GraphResponse{SitePage}"/> object of the request.
        /// </summary>
        /// <param name="sitePage">The SitePage to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SitePage}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SitePage>> AddResponseAsync(SitePage sitePage, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<ISitePagesCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<ISitePagesCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{SitePagesCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{SitePagesCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<SitePagesCollectionResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{SitePagesCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SitePagesCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<SitePagesCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISitePagesCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISitePagesCollectionRequest Expand(Expression<Func<SitePage, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISitePagesCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISitePagesCollectionRequest Select(Expression<Func<SitePage, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        ISitePagesCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        ISitePagesCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        ISitePagesCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        ISitePagesCollectionRequest OrderBy(string value);
    }
}
