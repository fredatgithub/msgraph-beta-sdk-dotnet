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
    /// The interface IAuthenticationPasswordMethodsCollectionRequest.
    /// </summary>
    public partial interface IAuthenticationPasswordMethodsCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified PasswordAuthenticationMethod to the collection via POST.
        /// </summary>
        /// <param name="passwordAuthenticationMethod">The PasswordAuthenticationMethod to add.</param>
        /// <returns>The created PasswordAuthenticationMethod.</returns>
        System.Threading.Tasks.Task<PasswordAuthenticationMethod> AddAsync(PasswordAuthenticationMethod passwordAuthenticationMethod);

        /// <summary>
        /// Adds the specified PasswordAuthenticationMethod to the collection via POST.
        /// </summary>
        /// <param name="passwordAuthenticationMethod">The PasswordAuthenticationMethod to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PasswordAuthenticationMethod.</returns>
        System.Threading.Tasks.Task<PasswordAuthenticationMethod> AddAsync(PasswordAuthenticationMethod passwordAuthenticationMethod, CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds the specified PasswordAuthenticationMethod to the collection via POST and returns a <see cref="GraphResponse{PasswordAuthenticationMethod}"/> object of the request.
        /// </summary>
        /// <param name="passwordAuthenticationMethod">The PasswordAuthenticationMethod to add.</param>
        /// <returns>The <see cref="GraphResponse{PasswordAuthenticationMethod}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PasswordAuthenticationMethod>> AddResponseAsync(PasswordAuthenticationMethod passwordAuthenticationMethod);

        /// <summary>
        /// Adds the specified PasswordAuthenticationMethod to the collection via POST and returns a <see cref="GraphResponse{PasswordAuthenticationMethod}"/> object of the request.
        /// </summary>
        /// <param name="passwordAuthenticationMethod">The PasswordAuthenticationMethod to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PasswordAuthenticationMethod}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PasswordAuthenticationMethod>> AddResponseAsync(PasswordAuthenticationMethod passwordAuthenticationMethod, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IAuthenticationPasswordMethodsCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IAuthenticationPasswordMethodsCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{AuthenticationPasswordMethodsCollectionResponse}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{AuthenticationPasswordMethodsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<AuthenticationPasswordMethodsCollectionResponse>> GetResponseAsync();

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{AuthenticationPasswordMethodsCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AuthenticationPasswordMethodsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<AuthenticationPasswordMethodsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationPasswordMethodsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationPasswordMethodsCollectionRequest Expand(Expression<Func<PasswordAuthenticationMethod, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationPasswordMethodsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationPasswordMethodsCollectionRequest Select(Expression<Func<PasswordAuthenticationMethod, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationPasswordMethodsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationPasswordMethodsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationPasswordMethodsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationPasswordMethodsCollectionRequest OrderBy(string value);
    }
}
