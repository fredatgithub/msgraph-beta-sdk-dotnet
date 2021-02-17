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
    /// The interface IUserAppConsentRequestsForApprovalCollectionRequest.
    /// </summary>
    public partial interface IUserAppConsentRequestsForApprovalCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified AppConsentRequestObject to the collection via POST.
        /// </summary>
        /// <param name="appConsentRequest">The AppConsentRequestObject to add.</param>
        /// <returns>The created AppConsentRequestObject.</returns>
        System.Threading.Tasks.Task<AppConsentRequestObject> AddAsync(AppConsentRequestObject appConsentRequest);

        /// <summary>
        /// Adds the specified AppConsentRequestObject to the collection via POST.
        /// </summary>
        /// <param name="appConsentRequest">The AppConsentRequestObject to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AppConsentRequestObject.</returns>
        System.Threading.Tasks.Task<AppConsentRequestObject> AddAsync(AppConsentRequestObject appConsentRequest, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds the specified AppConsentRequestObject to the collection via POST and returns a <see cref="GraphResponse{AppConsentRequestObject}"/> object of the request.
        /// </summary>
        /// <param name="appConsentRequest">The AppConsentRequestObject to add.</param>
        /// <returns>The <see cref="GraphResponse{AppConsentRequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AppConsentRequestObject>> AddResponseAsync(AppConsentRequestObject appConsentRequest);

        /// <summary>
        /// Adds the specified AppConsentRequestObject to the collection via POST and returns a <see cref="GraphResponse{AppConsentRequestObject}"/> object of the request.
        /// </summary>
        /// <param name="appConsentRequest">The AppConsentRequestObject to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AppConsentRequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AppConsentRequestObject>> AddResponseAsync(AppConsentRequestObject appConsentRequest, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IUserAppConsentRequestsForApprovalCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IUserAppConsentRequestsForApprovalCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{UserAppConsentRequestsForApprovalCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{UserAppConsentRequestsForApprovalCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserAppConsentRequestsForApprovalCollectionResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{UserAppConsentRequestsForApprovalCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserAppConsentRequestsForApprovalCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserAppConsentRequestsForApprovalCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserAppConsentRequestsForApprovalCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserAppConsentRequestsForApprovalCollectionRequest Expand(Expression<Func<AppConsentRequestObject, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUserAppConsentRequestsForApprovalCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUserAppConsentRequestsForApprovalCollectionRequest Select(Expression<Func<AppConsentRequestObject, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IUserAppConsentRequestsForApprovalCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IUserAppConsentRequestsForApprovalCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IUserAppConsentRequestsForApprovalCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IUserAppConsentRequestsForApprovalCollectionRequest OrderBy(string value);
    }
}
