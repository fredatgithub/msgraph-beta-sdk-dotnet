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
    /// The interface ITeamworkTagRequest.
    /// </summary>
    public partial interface ITeamworkTagRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified TeamworkTag using POST.
        /// </summary>
        /// <param name="teamworkTagToCreate">The TeamworkTag to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TeamworkTag.</returns>
        System.Threading.Tasks.Task<TeamworkTag> CreateAsync(TeamworkTag teamworkTagToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified TeamworkTag using POST and returns a <see cref="GraphResponse{TeamworkTag}"/> object.
        /// </summary>
        /// <param name="teamworkTagToCreate">The TeamworkTag to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TeamworkTag}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamworkTag>> CreateResponseAsync(TeamworkTag teamworkTagToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified TeamworkTag.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified TeamworkTag and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified TeamworkTag.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TeamworkTag.</returns>
        System.Threading.Tasks.Task<TeamworkTag> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified TeamworkTag and returns a <see cref="GraphResponse{TeamworkTag}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TeamworkTag}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamworkTag>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified TeamworkTag using PATCH.
        /// </summary>
        /// <param name="teamworkTagToUpdate">The TeamworkTag to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TeamworkTag.</returns>
        System.Threading.Tasks.Task<TeamworkTag> UpdateAsync(TeamworkTag teamworkTagToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified TeamworkTag using PATCH and returns a <see cref="GraphResponse{TeamworkTag}"/> object.
        /// </summary>
        /// <param name="teamworkTagToUpdate">The TeamworkTag to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TeamworkTag}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamworkTag>> UpdateResponseAsync(TeamworkTag teamworkTagToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamworkTagRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamworkTagRequest Expand(Expression<Func<TeamworkTag, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamworkTagRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamworkTagRequest Select(Expression<Func<TeamworkTag, object>> selectExpression);

    }
}
