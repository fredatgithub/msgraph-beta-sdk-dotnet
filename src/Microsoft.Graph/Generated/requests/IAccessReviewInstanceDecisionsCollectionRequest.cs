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
    /// The interface IAccessReviewInstanceDecisionsCollectionRequest.
    /// </summary>
    public partial interface IAccessReviewInstanceDecisionsCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified AccessReviewInstanceDecisionItem to the collection via POST.
        /// </summary>
        /// <param name="accessReviewInstanceDecisionItem">The AccessReviewInstanceDecisionItem to add.</param>
        /// <returns>The created AccessReviewInstanceDecisionItem.</returns>
        System.Threading.Tasks.Task<AccessReviewInstanceDecisionItem> AddAsync(AccessReviewInstanceDecisionItem accessReviewInstanceDecisionItem);

        /// <summary>
        /// Adds the specified AccessReviewInstanceDecisionItem to the collection via POST.
        /// </summary>
        /// <param name="accessReviewInstanceDecisionItem">The AccessReviewInstanceDecisionItem to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AccessReviewInstanceDecisionItem.</returns>
        System.Threading.Tasks.Task<AccessReviewInstanceDecisionItem> AddAsync(AccessReviewInstanceDecisionItem accessReviewInstanceDecisionItem, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds the specified AccessReviewInstanceDecisionItem to the collection via POST and returns a <see cref="GraphResponse{AccessReviewInstanceDecisionItem}"/> object of the request.
        /// </summary>
        /// <param name="accessReviewInstanceDecisionItem">The AccessReviewInstanceDecisionItem to add.</param>
        /// <returns>The <see cref="GraphResponse{AccessReviewInstanceDecisionItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessReviewInstanceDecisionItem>> AddResponseAsync(AccessReviewInstanceDecisionItem accessReviewInstanceDecisionItem);

        /// <summary>
        /// Adds the specified AccessReviewInstanceDecisionItem to the collection via POST and returns a <see cref="GraphResponse{AccessReviewInstanceDecisionItem}"/> object of the request.
        /// </summary>
        /// <param name="accessReviewInstanceDecisionItem">The AccessReviewInstanceDecisionItem to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessReviewInstanceDecisionItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessReviewInstanceDecisionItem>> AddResponseAsync(AccessReviewInstanceDecisionItem accessReviewInstanceDecisionItem, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IAccessReviewInstanceDecisionsCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IAccessReviewInstanceDecisionsCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{AccessReviewInstanceDecisionsCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{AccessReviewInstanceDecisionsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessReviewInstanceDecisionsCollectionResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{AccessReviewInstanceDecisionsCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessReviewInstanceDecisionsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessReviewInstanceDecisionsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAccessReviewInstanceDecisionsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAccessReviewInstanceDecisionsCollectionRequest Expand(Expression<Func<AccessReviewInstanceDecisionItem, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAccessReviewInstanceDecisionsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAccessReviewInstanceDecisionsCollectionRequest Select(Expression<Func<AccessReviewInstanceDecisionItem, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IAccessReviewInstanceDecisionsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IAccessReviewInstanceDecisionsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IAccessReviewInstanceDecisionsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IAccessReviewInstanceDecisionsCollectionRequest OrderBy(string value);
    }
}
