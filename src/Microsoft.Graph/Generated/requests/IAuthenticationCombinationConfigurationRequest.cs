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
    /// The interface IAuthenticationCombinationConfigurationRequest.
    /// </summary>
    public partial interface IAuthenticationCombinationConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AuthenticationCombinationConfiguration using POST.
        /// </summary>
        /// <param name="authenticationCombinationConfigurationToCreate">The AuthenticationCombinationConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AuthenticationCombinationConfiguration.</returns>
        System.Threading.Tasks.Task<AuthenticationCombinationConfiguration> CreateAsync(AuthenticationCombinationConfiguration authenticationCombinationConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified AuthenticationCombinationConfiguration using POST and returns a <see cref="GraphResponse{AuthenticationCombinationConfiguration}"/> object.
        /// </summary>
        /// <param name="authenticationCombinationConfigurationToCreate">The AuthenticationCombinationConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AuthenticationCombinationConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AuthenticationCombinationConfiguration>> CreateResponseAsync(AuthenticationCombinationConfiguration authenticationCombinationConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AuthenticationCombinationConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AuthenticationCombinationConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AuthenticationCombinationConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AuthenticationCombinationConfiguration.</returns>
        System.Threading.Tasks.Task<AuthenticationCombinationConfiguration> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AuthenticationCombinationConfiguration and returns a <see cref="GraphResponse{AuthenticationCombinationConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AuthenticationCombinationConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AuthenticationCombinationConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AuthenticationCombinationConfiguration using PATCH.
        /// </summary>
        /// <param name="authenticationCombinationConfigurationToUpdate">The AuthenticationCombinationConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AuthenticationCombinationConfiguration.</returns>
        System.Threading.Tasks.Task<AuthenticationCombinationConfiguration> UpdateAsync(AuthenticationCombinationConfiguration authenticationCombinationConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AuthenticationCombinationConfiguration using PATCH and returns a <see cref="GraphResponse{AuthenticationCombinationConfiguration}"/> object.
        /// </summary>
        /// <param name="authenticationCombinationConfigurationToUpdate">The AuthenticationCombinationConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AuthenticationCombinationConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AuthenticationCombinationConfiguration>> UpdateResponseAsync(AuthenticationCombinationConfiguration authenticationCombinationConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AuthenticationCombinationConfiguration using PUT.
        /// </summary>
        /// <param name="authenticationCombinationConfigurationToUpdate">The AuthenticationCombinationConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<AuthenticationCombinationConfiguration> PutAsync(AuthenticationCombinationConfiguration authenticationCombinationConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AuthenticationCombinationConfiguration using PUT and returns a <see cref="GraphResponse{AuthenticationCombinationConfiguration}"/> object.
        /// </summary>
        /// <param name="authenticationCombinationConfigurationToUpdate">The AuthenticationCombinationConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{AuthenticationCombinationConfiguration}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<AuthenticationCombinationConfiguration>> PutResponseAsync(AuthenticationCombinationConfiguration authenticationCombinationConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationCombinationConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationCombinationConfigurationRequest Expand(Expression<Func<AuthenticationCombinationConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationCombinationConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAuthenticationCombinationConfigurationRequest Select(Expression<Func<AuthenticationCombinationConfiguration, object>> selectExpression);

    }
}
