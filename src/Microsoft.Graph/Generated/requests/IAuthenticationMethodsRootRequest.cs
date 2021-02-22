// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IAuthenticationMethodsRootRequest.
    /// </summary>
    public partial interface IAuthenticationMethodsRootRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AuthenticationMethodsRoot using POST.
        /// </summary>
        /// <param name="authenticationMethodsRootToCreate">The AuthenticationMethodsRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AuthenticationMethodsRoot.</returns>
        System.Threading.Tasks.Task<AuthenticationMethodsRoot> CreateAsync(AuthenticationMethodsRoot authenticationMethodsRootToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified AuthenticationMethodsRoot using POST and returns a <see cref="GraphResponse{AuthenticationMethodsRoot}"/> object.
        /// </summary>
        /// <param name="authenticationMethodsRootToCreate">The AuthenticationMethodsRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AuthenticationMethodsRoot}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AuthenticationMethodsRoot>> CreateResponseAsync(AuthenticationMethodsRoot authenticationMethodsRootToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AuthenticationMethodsRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AuthenticationMethodsRoot and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AuthenticationMethodsRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AuthenticationMethodsRoot.</returns>
        System.Threading.Tasks.Task<AuthenticationMethodsRoot> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AuthenticationMethodsRoot and returns a <see cref="GraphResponse{AuthenticationMethodsRoot}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AuthenticationMethodsRoot}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AuthenticationMethodsRoot>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AuthenticationMethodsRoot using PATCH.
        /// </summary>
        /// <param name="authenticationMethodsRootToUpdate">The AuthenticationMethodsRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AuthenticationMethodsRoot.</returns>
        System.Threading.Tasks.Task<AuthenticationMethodsRoot> UpdateAsync(AuthenticationMethodsRoot authenticationMethodsRootToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AuthenticationMethodsRoot using PATCH and returns a <see cref="GraphResponse{AuthenticationMethodsRoot}"/> object.
        /// </summary>
        /// <param name="authenticationMethodsRootToUpdate">The AuthenticationMethodsRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AuthenticationMethodsRoot}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AuthenticationMethodsRoot>> UpdateResponseAsync(AuthenticationMethodsRoot authenticationMethodsRootToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationMethodsRootRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationMethodsRootRequest Expand(Expression<Func<AuthenticationMethodsRoot, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationMethodsRootRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationMethodsRootRequest Select(Expression<Func<AuthenticationMethodsRoot, object>> selectExpression);

    }
}
