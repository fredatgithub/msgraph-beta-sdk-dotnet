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
    /// The interface IOnenoteNotebooksCollectionRequest.
    /// </summary>
    public partial interface IOnenoteNotebooksCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified Notebook to the collection via POST.
        /// </summary>
        /// <param name="notebook">The Notebook to add.</param>
        /// <returns>The created Notebook.</returns>
        System.Threading.Tasks.Task<Notebook> AddAsync(Notebook notebook);

        /// <summary>
        /// Adds the specified Notebook to the collection via POST.
        /// </summary>
        /// <param name="notebook">The Notebook to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Notebook.</returns>
        System.Threading.Tasks.Task<Notebook> AddAsync(Notebook notebook, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds the specified Notebook to the collection via POST and returns a <see cref="GraphResponse{Notebook}"/> object of the request.
        /// </summary>
        /// <param name="notebook">The Notebook to add.</param>
        /// <returns>The <see cref="GraphResponse{Notebook}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Notebook>> AddResponseAsync(Notebook notebook);

        /// <summary>
        /// Adds the specified Notebook to the collection via POST and returns a <see cref="GraphResponse{Notebook}"/> object of the request.
        /// </summary>
        /// <param name="notebook">The Notebook to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Notebook}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Notebook>> AddResponseAsync(Notebook notebook, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IOnenoteNotebooksCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IOnenoteNotebooksCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{OnenoteNotebooksCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{OnenoteNotebooksCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<OnenoteNotebooksCollectionResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{OnenoteNotebooksCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OnenoteNotebooksCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<OnenoteNotebooksCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteNotebooksCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteNotebooksCollectionRequest Expand(Expression<Func<Notebook, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteNotebooksCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteNotebooksCollectionRequest Select(Expression<Func<Notebook, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteNotebooksCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteNotebooksCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteNotebooksCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IOnenoteNotebooksCollectionRequest OrderBy(string value);
    }
}
