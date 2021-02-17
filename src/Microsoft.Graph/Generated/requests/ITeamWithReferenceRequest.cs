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
    /// The interface ITeamWithReferenceRequest.
    /// </summary>
    public partial interface ITeamWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified Team.
        /// </summary>
        /// <returns>The Team.</returns>
        System.Threading.Tasks.Task<Team> GetAsync();

        /// <summary>
        /// Gets the specified Team.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Team.</returns>
        System.Threading.Tasks.Task<Team> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Team and returns a <see cref="GraphResponse{Team}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{Team}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Team>> GetResponseAsync();

        /// <summary>
        /// Gets the specified Team and returns a <see cref="GraphResponse{Team}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Team}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Team>> GetResponseAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified Team using POST.
        /// </summary>
        /// <param name="teamToCreate">The Team to create.</param>
        /// <returns>The created Team.</returns>
        System.Threading.Tasks.Task<Team> CreateAsync(Team teamToCreate);

        /// <summary>
        /// Creates the specified Team using POST.
        /// </summary>
        /// <param name="teamToCreate">The Team to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Team.</returns>
        System.Threading.Tasks.Task<Team> CreateAsync(Team teamToCreate, CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified Team using POST and returns a <see cref="GraphResponse{Team}"/> object.
        /// </summary>
        /// <param name="teamToCreate">The Team to create.</param>
        /// <returns>The <see cref="GraphResponse{Team}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Team>> CreateResponseAsync(Team teamToCreate);

        /// <summary>
        /// Creates the specified Team using POST and returns a <see cref="GraphResponse{Team}"/> object.
        /// </summary>
        /// <param name="teamToCreate">The Team to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Team}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Team>> CreateResponseAsync(Team teamToCreate, CancellationToken cancellationToken);

		/// <summary>
        /// Updates the specified Team using PATCH.
        /// </summary>
        /// <param name="teamToUpdate">The Team to update.</param>
        /// <returns>The updated Team.</returns>
        System.Threading.Tasks.Task<Team> UpdateAsync(Team teamToUpdate);

        /// <summary>
        /// Updates the specified Team using PATCH.
        /// </summary>
        /// <param name="teamToUpdate">The Team to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Team.</returns>
        System.Threading.Tasks.Task<Team> UpdateAsync(Team teamToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Updates the specified Team using PATCH and returns a <see cref="GraphResponse{Team}"/> object.
        /// </summary>
        /// <param name="teamToUpdate">The Team to update.</param>
        /// <returns>The <see cref="GraphResponse{Team}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Team>> UpdateResponseAsync(Team teamToUpdate);

        /// <summary>
        /// Updates the specified Team using PATCH and returns a <see cref="GraphResponse{Team}"/> object.
        /// </summary>
        /// <param name="teamToUpdate">The Team to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Team}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Team>> UpdateResponseAsync(Team teamToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified Team.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Team.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified Team and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified Team and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamWithReferenceRequest Expand(Expression<Func<Team, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamWithReferenceRequest Select(Expression<Func<Team, object>> selectExpression);

    }
}
