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
    /// The interface IExternalConnectionsCollectionRequest.
    /// </summary>
    public partial interface IExternalConnectionsCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified ExternalConnection to the collection via POST.
        /// </summary>
        /// <param name="externalConnection">The ExternalConnection to add.</param>
        /// <returns>The created ExternalConnection.</returns>
        System.Threading.Tasks.Task<ExternalConnection> AddAsync(ExternalConnection externalConnection);

        /// <summary>
        /// Adds the specified ExternalConnection to the collection via POST.
        /// </summary>
        /// <param name="externalConnection">The ExternalConnection to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ExternalConnection.</returns>
        System.Threading.Tasks.Task<ExternalConnection> AddAsync(ExternalConnection externalConnection, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds the specified ExternalConnection to the collection via POST and returns a <see cref="GraphResponse{ExternalConnection}"/> object of the request.
        /// </summary>
        /// <param name="externalConnection">The ExternalConnection to add.</param>
        /// <returns>The <see cref="GraphResponse{ExternalConnection}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ExternalConnection>> AddResponseAsync(ExternalConnection externalConnection);

        /// <summary>
        /// Adds the specified ExternalConnection to the collection via POST and returns a <see cref="GraphResponse{ExternalConnection}"/> object of the request.
        /// </summary>
        /// <param name="externalConnection">The ExternalConnection to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ExternalConnection}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ExternalConnection>> AddResponseAsync(ExternalConnection externalConnection, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IExternalConnectionsCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IExternalConnectionsCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{ExternalConnectionsCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{ExternalConnectionsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<ExternalConnectionsCollectionResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{ExternalConnectionsCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ExternalConnectionsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<ExternalConnectionsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IExternalConnectionsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IExternalConnectionsCollectionRequest Expand(Expression<Func<ExternalConnection, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IExternalConnectionsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IExternalConnectionsCollectionRequest Select(Expression<Func<ExternalConnection, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IExternalConnectionsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IExternalConnectionsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IExternalConnectionsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IExternalConnectionsCollectionRequest OrderBy(string value);
    }
}
