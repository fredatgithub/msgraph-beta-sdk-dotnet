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
    /// The interface IGroupExtensionsCollectionRequest.
    /// </summary>
    public partial interface IGroupExtensionsCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified Extension to the collection via POST.
        /// </summary>
        /// <param name="extension">The Extension to add.</param>
        /// <returns>The created Extension.</returns>
        System.Threading.Tasks.Task<Extension> AddAsync(Extension extension);

        /// <summary>
        /// Adds the specified Extension to the collection via POST.
        /// </summary>
        /// <param name="extension">The Extension to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Extension.</returns>
        System.Threading.Tasks.Task<Extension> AddAsync(Extension extension, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds the specified Extension to the collection via POST and returns a <see cref="GraphResponse{Extension}"/> object of the request.
        /// </summary>
        /// <param name="extension">The Extension to add.</param>
        /// <returns>The <see cref="GraphResponse{Extension}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Extension>> AddResponseAsync(Extension extension);

        /// <summary>
        /// Adds the specified Extension to the collection via POST and returns a <see cref="GraphResponse{Extension}"/> object of the request.
        /// </summary>
        /// <param name="extension">The Extension to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Extension}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Extension>> AddResponseAsync(Extension extension, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IGroupExtensionsCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IGroupExtensionsCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{GroupExtensionsCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{GroupExtensionsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<GroupExtensionsCollectionResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{GroupExtensionsCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupExtensionsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<GroupExtensionsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IGroupExtensionsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IGroupExtensionsCollectionRequest Expand(Expression<Func<Extension, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IGroupExtensionsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IGroupExtensionsCollectionRequest Select(Expression<Func<Extension, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IGroupExtensionsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IGroupExtensionsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IGroupExtensionsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IGroupExtensionsCollectionRequest OrderBy(string value);
    }
}
