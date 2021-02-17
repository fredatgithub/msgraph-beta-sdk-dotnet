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
    /// The interface ILegalHoldSiteSourcesCollectionRequest.
    /// </summary>
    public partial interface ILegalHoldSiteSourcesCollectionRequest : Microsoft.Graph.IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified SiteSource to the collection via POST.
        /// </summary>
        /// <param name="siteSource">The SiteSource to add.</param>
        /// <returns>The created SiteSource.</returns>
        System.Threading.Tasks.Task<SiteSource> AddAsync(SiteSource siteSource);

        /// <summary>
        /// Adds the specified SiteSource to the collection via POST.
        /// </summary>
        /// <param name="siteSource">The SiteSource to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SiteSource.</returns>
        System.Threading.Tasks.Task<SiteSource> AddAsync(SiteSource siteSource, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds the specified SiteSource to the collection via POST and returns a <see cref="GraphResponse{SiteSource}"/> object of the request.
        /// </summary>
        /// <param name="siteSource">The SiteSource to add.</param>
        /// <returns>The <see cref="GraphResponse{SiteSource}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SiteSource>> AddResponseAsync(SiteSource siteSource);

        /// <summary>
        /// Adds the specified SiteSource to the collection via POST and returns a <see cref="GraphResponse{SiteSource}"/> object of the request.
        /// </summary>
        /// <param name="siteSource">The SiteSource to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SiteSource}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SiteSource>> AddResponseAsync(SiteSource siteSource, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<ILegalHoldSiteSourcesCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<ILegalHoldSiteSourcesCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{LegalHoldSiteSourcesCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{LegalHoldSiteSourcesCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<LegalHoldSiteSourcesCollectionResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{LegalHoldSiteSourcesCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{LegalHoldSiteSourcesCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<LegalHoldSiteSourcesCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ILegalHoldSiteSourcesCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ILegalHoldSiteSourcesCollectionRequest Expand(Expression<Func<SiteSource, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ILegalHoldSiteSourcesCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ILegalHoldSiteSourcesCollectionRequest Select(Expression<Func<SiteSource, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        ILegalHoldSiteSourcesCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        ILegalHoldSiteSourcesCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        ILegalHoldSiteSourcesCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        ILegalHoldSiteSourcesCollectionRequest OrderBy(string value);
    }
}
