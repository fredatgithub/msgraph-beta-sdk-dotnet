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
    /// The interface IPersonExtensionRequest.
    /// </summary>
    public partial interface IPersonExtensionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PersonExtension using POST.
        /// </summary>
        /// <param name="personExtensionToCreate">The PersonExtension to create.</param>
        /// <returns>The created PersonExtension.</returns>
        System.Threading.Tasks.Task<PersonExtension> CreateAsync(PersonExtension personExtensionToCreate);

        /// <summary>
        /// Creates the specified PersonExtension using POST.
        /// </summary>
        /// <param name="personExtensionToCreate">The PersonExtension to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PersonExtension.</returns>
        System.Threading.Tasks.Task<PersonExtension> CreateAsync(PersonExtension personExtensionToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified PersonExtension using POST and returns a <see cref="GraphResponse{PersonExtension}"/> object.
        /// </summary>
        /// <param name="personExtensionToCreate">The PersonExtension to create.</param>
        /// <returns>The <see cref="GraphResponse{PersonExtension}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PersonExtension>> CreateResponseAsync(PersonExtension personExtensionToCreate);

        /// <summary>
        /// Creates the specified PersonExtension using POST and returns a <see cref="GraphResponse{PersonExtension}"/> object.
        /// </summary>
        /// <param name="personExtensionToCreate">The PersonExtension to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PersonExtension}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PersonExtension>> CreateResponseAsync(PersonExtension personExtensionToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified PersonExtension.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified PersonExtension.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified PersonExtension and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified PersonExtension and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified PersonExtension.
        /// </summary>
        /// <returns>The PersonExtension.</returns>
        System.Threading.Tasks.Task<PersonExtension> GetAsync();

        /// <summary>
        /// Gets the specified PersonExtension.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PersonExtension.</returns>
        System.Threading.Tasks.Task<PersonExtension> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified PersonExtension and returns a <see cref="GraphResponse{PersonExtension}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{PersonExtension}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PersonExtension>> GetResponseAsync();

        /// <summary>
        /// Gets the specified PersonExtension and returns a <see cref="GraphResponse{PersonExtension}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PersonExtension}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PersonExtension>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified PersonExtension using PATCH.
        /// </summary>
        /// <param name="personExtensionToUpdate">The PersonExtension to update.</param>
        /// <returns>The updated PersonExtension.</returns>
        System.Threading.Tasks.Task<PersonExtension> UpdateAsync(PersonExtension personExtensionToUpdate);

        /// <summary>
        /// Updates the specified PersonExtension using PATCH.
        /// </summary>
        /// <param name="personExtensionToUpdate">The PersonExtension to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PersonExtension.</returns>
        System.Threading.Tasks.Task<PersonExtension> UpdateAsync(PersonExtension personExtensionToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified PersonExtension using PATCH and returns a <see cref="GraphResponse{PersonExtension}"/> object.
        /// </summary>
        /// <param name="personExtensionToUpdate">The PersonExtension to update.</param>
        /// <returns>The <see cref="GraphResponse{PersonExtension}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PersonExtension>> UpdateResponseAsync(PersonExtension personExtensionToUpdate);

        /// <summary>
        /// Updates the specified PersonExtension using PATCH and returns a <see cref="GraphResponse{PersonExtension}"/> object.
        /// </summary>
        /// <param name="personExtensionToUpdate">The PersonExtension to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PersonExtension}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PersonExtension>> UpdateResponseAsync(PersonExtension personExtensionToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPersonExtensionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPersonExtensionRequest Expand(Expression<Func<PersonExtension, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPersonExtensionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPersonExtensionRequest Select(Expression<Func<PersonExtension, object>> selectExpression);

    }
}
