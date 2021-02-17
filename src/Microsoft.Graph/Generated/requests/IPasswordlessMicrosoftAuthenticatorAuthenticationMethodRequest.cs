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
    /// The interface IPasswordlessMicrosoftAuthenticatorAuthenticationMethodRequest.
    /// </summary>
    public partial interface IPasswordlessMicrosoftAuthenticatorAuthenticationMethodRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PasswordlessMicrosoftAuthenticatorAuthenticationMethod using POST.
        /// </summary>
        /// <param name="passwordlessMicrosoftAuthenticatorAuthenticationMethodToCreate">The PasswordlessMicrosoftAuthenticatorAuthenticationMethod to create.</param>
        /// <returns>The created PasswordlessMicrosoftAuthenticatorAuthenticationMethod.</returns>
        System.Threading.Tasks.Task<PasswordlessMicrosoftAuthenticatorAuthenticationMethod> CreateAsync(PasswordlessMicrosoftAuthenticatorAuthenticationMethod passwordlessMicrosoftAuthenticatorAuthenticationMethodToCreate);

        /// <summary>
        /// Creates the specified PasswordlessMicrosoftAuthenticatorAuthenticationMethod using POST.
        /// </summary>
        /// <param name="passwordlessMicrosoftAuthenticatorAuthenticationMethodToCreate">The PasswordlessMicrosoftAuthenticatorAuthenticationMethod to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PasswordlessMicrosoftAuthenticatorAuthenticationMethod.</returns>
        System.Threading.Tasks.Task<PasswordlessMicrosoftAuthenticatorAuthenticationMethod> CreateAsync(PasswordlessMicrosoftAuthenticatorAuthenticationMethod passwordlessMicrosoftAuthenticatorAuthenticationMethodToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified PasswordlessMicrosoftAuthenticatorAuthenticationMethod using POST and returns a <see cref="GraphResponse{PasswordlessMicrosoftAuthenticatorAuthenticationMethod}"/> object.
        /// </summary>
        /// <param name="passwordlessMicrosoftAuthenticatorAuthenticationMethodToCreate">The PasswordlessMicrosoftAuthenticatorAuthenticationMethod to create.</param>
        /// <returns>The <see cref="GraphResponse{PasswordlessMicrosoftAuthenticatorAuthenticationMethod}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PasswordlessMicrosoftAuthenticatorAuthenticationMethod>> CreateResponseAsync(PasswordlessMicrosoftAuthenticatorAuthenticationMethod passwordlessMicrosoftAuthenticatorAuthenticationMethodToCreate);

        /// <summary>
        /// Creates the specified PasswordlessMicrosoftAuthenticatorAuthenticationMethod using POST and returns a <see cref="GraphResponse{PasswordlessMicrosoftAuthenticatorAuthenticationMethod}"/> object.
        /// </summary>
        /// <param name="passwordlessMicrosoftAuthenticatorAuthenticationMethodToCreate">The PasswordlessMicrosoftAuthenticatorAuthenticationMethod to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PasswordlessMicrosoftAuthenticatorAuthenticationMethod}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PasswordlessMicrosoftAuthenticatorAuthenticationMethod>> CreateResponseAsync(PasswordlessMicrosoftAuthenticatorAuthenticationMethod passwordlessMicrosoftAuthenticatorAuthenticationMethodToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified PasswordlessMicrosoftAuthenticatorAuthenticationMethod.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified PasswordlessMicrosoftAuthenticatorAuthenticationMethod.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified PasswordlessMicrosoftAuthenticatorAuthenticationMethod and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified PasswordlessMicrosoftAuthenticatorAuthenticationMethod and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified PasswordlessMicrosoftAuthenticatorAuthenticationMethod.
        /// </summary>
        /// <returns>The PasswordlessMicrosoftAuthenticatorAuthenticationMethod.</returns>
        System.Threading.Tasks.Task<PasswordlessMicrosoftAuthenticatorAuthenticationMethod> GetAsync();

        /// <summary>
        /// Gets the specified PasswordlessMicrosoftAuthenticatorAuthenticationMethod.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PasswordlessMicrosoftAuthenticatorAuthenticationMethod.</returns>
        System.Threading.Tasks.Task<PasswordlessMicrosoftAuthenticatorAuthenticationMethod> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified PasswordlessMicrosoftAuthenticatorAuthenticationMethod and returns a <see cref="GraphResponse{PasswordlessMicrosoftAuthenticatorAuthenticationMethod}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{PasswordlessMicrosoftAuthenticatorAuthenticationMethod}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PasswordlessMicrosoftAuthenticatorAuthenticationMethod>> GetResponseAsync();

        /// <summary>
        /// Gets the specified PasswordlessMicrosoftAuthenticatorAuthenticationMethod and returns a <see cref="GraphResponse{PasswordlessMicrosoftAuthenticatorAuthenticationMethod}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PasswordlessMicrosoftAuthenticatorAuthenticationMethod}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PasswordlessMicrosoftAuthenticatorAuthenticationMethod>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified PasswordlessMicrosoftAuthenticatorAuthenticationMethod using PATCH.
        /// </summary>
        /// <param name="passwordlessMicrosoftAuthenticatorAuthenticationMethodToUpdate">The PasswordlessMicrosoftAuthenticatorAuthenticationMethod to update.</param>
        /// <returns>The updated PasswordlessMicrosoftAuthenticatorAuthenticationMethod.</returns>
        System.Threading.Tasks.Task<PasswordlessMicrosoftAuthenticatorAuthenticationMethod> UpdateAsync(PasswordlessMicrosoftAuthenticatorAuthenticationMethod passwordlessMicrosoftAuthenticatorAuthenticationMethodToUpdate);

        /// <summary>
        /// Updates the specified PasswordlessMicrosoftAuthenticatorAuthenticationMethod using PATCH.
        /// </summary>
        /// <param name="passwordlessMicrosoftAuthenticatorAuthenticationMethodToUpdate">The PasswordlessMicrosoftAuthenticatorAuthenticationMethod to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PasswordlessMicrosoftAuthenticatorAuthenticationMethod.</returns>
        System.Threading.Tasks.Task<PasswordlessMicrosoftAuthenticatorAuthenticationMethod> UpdateAsync(PasswordlessMicrosoftAuthenticatorAuthenticationMethod passwordlessMicrosoftAuthenticatorAuthenticationMethodToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified PasswordlessMicrosoftAuthenticatorAuthenticationMethod using PATCH and returns a <see cref="GraphResponse{PasswordlessMicrosoftAuthenticatorAuthenticationMethod}"/> object.
        /// </summary>
        /// <param name="passwordlessMicrosoftAuthenticatorAuthenticationMethodToUpdate">The PasswordlessMicrosoftAuthenticatorAuthenticationMethod to update.</param>
        /// <returns>The <see cref="GraphResponse{PasswordlessMicrosoftAuthenticatorAuthenticationMethod}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PasswordlessMicrosoftAuthenticatorAuthenticationMethod>> UpdateResponseAsync(PasswordlessMicrosoftAuthenticatorAuthenticationMethod passwordlessMicrosoftAuthenticatorAuthenticationMethodToUpdate);

        /// <summary>
        /// Updates the specified PasswordlessMicrosoftAuthenticatorAuthenticationMethod using PATCH and returns a <see cref="GraphResponse{PasswordlessMicrosoftAuthenticatorAuthenticationMethod}"/> object.
        /// </summary>
        /// <param name="passwordlessMicrosoftAuthenticatorAuthenticationMethodToUpdate">The PasswordlessMicrosoftAuthenticatorAuthenticationMethod to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PasswordlessMicrosoftAuthenticatorAuthenticationMethod}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PasswordlessMicrosoftAuthenticatorAuthenticationMethod>> UpdateResponseAsync(PasswordlessMicrosoftAuthenticatorAuthenticationMethod passwordlessMicrosoftAuthenticatorAuthenticationMethodToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPasswordlessMicrosoftAuthenticatorAuthenticationMethodRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPasswordlessMicrosoftAuthenticatorAuthenticationMethodRequest Expand(Expression<Func<PasswordlessMicrosoftAuthenticatorAuthenticationMethod, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPasswordlessMicrosoftAuthenticatorAuthenticationMethodRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPasswordlessMicrosoftAuthenticatorAuthenticationMethodRequest Select(Expression<Func<PasswordlessMicrosoftAuthenticatorAuthenticationMethod, object>> selectExpression);

    }
}
