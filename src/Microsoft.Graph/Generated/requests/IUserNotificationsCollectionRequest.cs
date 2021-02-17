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
    /// The interface IUserNotificationsCollectionRequest.
    /// </summary>
    public partial interface IUserNotificationsCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified Notification to the collection via POST.
        /// </summary>
        /// <param name="notification">The Notification to add.</param>
        /// <returns>The created Notification.</returns>
        System.Threading.Tasks.Task<Notification> AddAsync(Notification notification);

        /// <summary>
        /// Adds the specified Notification to the collection via POST.
        /// </summary>
        /// <param name="notification">The Notification to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Notification.</returns>
        System.Threading.Tasks.Task<Notification> AddAsync(Notification notification, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds the specified Notification to the collection via POST and returns a <see cref="GraphResponse{Notification}"/> object of the request.
        /// </summary>
        /// <param name="notification">The Notification to add.</param>
        /// <returns>The <see cref="GraphResponse{Notification}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Notification>> AddResponseAsync(Notification notification);

        /// <summary>
        /// Adds the specified Notification to the collection via POST and returns a <see cref="GraphResponse{Notification}"/> object of the request.
        /// </summary>
        /// <param name="notification">The Notification to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Notification}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Notification>> AddResponseAsync(Notification notification, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IUserNotificationsCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IUserNotificationsCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{UserNotificationsCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{UserNotificationsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserNotificationsCollectionResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{UserNotificationsCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserNotificationsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserNotificationsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserNotificationsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserNotificationsCollectionRequest Expand(Expression<Func<Notification, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUserNotificationsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUserNotificationsCollectionRequest Select(Expression<Func<Notification, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IUserNotificationsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IUserNotificationsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IUserNotificationsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IUserNotificationsCollectionRequest OrderBy(string value);
    }
}
