// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ITeamsAppDefinitionWithReferenceRequest.
    /// </summary>
    public partial interface ITeamsAppDefinitionWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified TeamsAppDefinition.
        /// </summary>
        /// <returns>The TeamsAppDefinition.</returns>
        System.Threading.Tasks.Task<TeamsAppDefinition> GetAsync();

        /// <summary>
        /// Gets the specified TeamsAppDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TeamsAppDefinition.</returns>
        System.Threading.Tasks.Task<TeamsAppDefinition> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified TeamsAppDefinition and returns a <see cref="GraphResponse{TeamsAppDefinition}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{TeamsAppDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsAppDefinition>> GetResponseAsync();

        /// <summary>
        /// Gets the specified TeamsAppDefinition and returns a <see cref="GraphResponse{TeamsAppDefinition}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TeamsAppDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsAppDefinition>> GetResponseAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified TeamsAppDefinition using POST.
        /// </summary>
        /// <param name="teamsAppDefinitionToCreate">The TeamsAppDefinition to create.</param>
        /// <returns>The created TeamsAppDefinition.</returns>
        System.Threading.Tasks.Task<TeamsAppDefinition> CreateAsync(TeamsAppDefinition teamsAppDefinitionToCreate);

        /// <summary>
        /// Creates the specified TeamsAppDefinition using POST.
        /// </summary>
        /// <param name="teamsAppDefinitionToCreate">The TeamsAppDefinition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TeamsAppDefinition.</returns>
        System.Threading.Tasks.Task<TeamsAppDefinition> CreateAsync(TeamsAppDefinition teamsAppDefinitionToCreate, CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified TeamsAppDefinition using POST and returns a <see cref="GraphResponse{TeamsAppDefinition}"/> object.
        /// </summary>
        /// <param name="teamsAppDefinitionToCreate">The TeamsAppDefinition to create.</param>
        /// <returns>The <see cref="GraphResponse{TeamsAppDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsAppDefinition>> CreateResponseAsync(TeamsAppDefinition teamsAppDefinitionToCreate);

        /// <summary>
        /// Creates the specified TeamsAppDefinition using POST and returns a <see cref="GraphResponse{TeamsAppDefinition}"/> object.
        /// </summary>
        /// <param name="teamsAppDefinitionToCreate">The TeamsAppDefinition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TeamsAppDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsAppDefinition>> CreateResponseAsync(TeamsAppDefinition teamsAppDefinitionToCreate, CancellationToken cancellationToken);

		/// <summary>
        /// Updates the specified TeamsAppDefinition using PATCH.
        /// </summary>
        /// <param name="teamsAppDefinitionToUpdate">The TeamsAppDefinition to update.</param>
        /// <returns>The updated TeamsAppDefinition.</returns>
        System.Threading.Tasks.Task<TeamsAppDefinition> UpdateAsync(TeamsAppDefinition teamsAppDefinitionToUpdate);

        /// <summary>
        /// Updates the specified TeamsAppDefinition using PATCH.
        /// </summary>
        /// <param name="teamsAppDefinitionToUpdate">The TeamsAppDefinition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TeamsAppDefinition.</returns>
        System.Threading.Tasks.Task<TeamsAppDefinition> UpdateAsync(TeamsAppDefinition teamsAppDefinitionToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Updates the specified TeamsAppDefinition using PATCH and returns a <see cref="GraphResponse{TeamsAppDefinition}"/> object.
        /// </summary>
        /// <param name="teamsAppDefinitionToUpdate">The TeamsAppDefinition to update.</param>
        /// <returns>The <see cref="GraphResponse{TeamsAppDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsAppDefinition>> UpdateResponseAsync(TeamsAppDefinition teamsAppDefinitionToUpdate);

        /// <summary>
        /// Updates the specified TeamsAppDefinition using PATCH and returns a <see cref="GraphResponse{TeamsAppDefinition}"/> object.
        /// </summary>
        /// <param name="teamsAppDefinitionToUpdate">The TeamsAppDefinition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TeamsAppDefinition}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsAppDefinition>> UpdateResponseAsync(TeamsAppDefinition teamsAppDefinitionToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified TeamsAppDefinition.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified TeamsAppDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified TeamsAppDefinition and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified TeamsAppDefinition and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsAppDefinitionWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsAppDefinitionWithReferenceRequest Expand(Expression<Func<TeamsAppDefinition, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsAppDefinitionWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsAppDefinitionWithReferenceRequest Select(Expression<Func<TeamsAppDefinition, object>> selectExpression);

    }
}
