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
    /// The interface IGroupEventsCollectionRequest.
    /// </summary>
    public partial interface IGroupEventsCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified Event to the collection via POST.
        /// </summary>
        /// <param name="eventsEvent">The Event to add.</param>
        /// <returns>The created Event.</returns>
        System.Threading.Tasks.Task<Event> AddAsync(Event eventsEvent);

        /// <summary>
        /// Adds the specified Event to the collection via POST.
        /// </summary>
        /// <param name="eventsEvent">The Event to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Event.</returns>
        System.Threading.Tasks.Task<Event> AddAsync(Event eventsEvent, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds the specified Event to the collection via POST and returns a <see cref="GraphResponse{Event}"/> object of the request.
        /// </summary>
        /// <param name="eventsEvent">The Event to add.</param>
        /// <returns>The <see cref="GraphResponse{Event}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Event>> AddResponseAsync(Event eventsEvent);

        /// <summary>
        /// Adds the specified Event to the collection via POST and returns a <see cref="GraphResponse{Event}"/> object of the request.
        /// </summary>
        /// <param name="eventsEvent">The Event to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Event}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Event>> AddResponseAsync(Event eventsEvent, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IGroupEventsCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IGroupEventsCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{GroupEventsCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{GroupEventsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<GroupEventsCollectionResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{GroupEventsCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupEventsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<GroupEventsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IGroupEventsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IGroupEventsCollectionRequest Expand(Expression<Func<Event, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IGroupEventsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IGroupEventsCollectionRequest Select(Expression<Func<Event, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IGroupEventsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IGroupEventsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IGroupEventsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IGroupEventsCollectionRequest OrderBy(string value);
    }
}
