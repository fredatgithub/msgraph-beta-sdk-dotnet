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
    /// The interface ITeamworkTagMemberRequest.
    /// </summary>
    public partial interface ITeamworkTagMemberRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified TeamworkTagMember using POST.
        /// </summary>
        /// <param name="teamworkTagMemberToCreate">The TeamworkTagMember to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TeamworkTagMember.</returns>
        System.Threading.Tasks.Task<TeamworkTagMember> CreateAsync(TeamworkTagMember teamworkTagMemberToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified TeamworkTagMember using POST and returns a <see cref="GraphResponse{TeamworkTagMember}"/> object.
        /// </summary>
        /// <param name="teamworkTagMemberToCreate">The TeamworkTagMember to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TeamworkTagMember}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamworkTagMember>> CreateResponseAsync(TeamworkTagMember teamworkTagMemberToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified TeamworkTagMember.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified TeamworkTagMember and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified TeamworkTagMember.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TeamworkTagMember.</returns>
        System.Threading.Tasks.Task<TeamworkTagMember> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified TeamworkTagMember and returns a <see cref="GraphResponse{TeamworkTagMember}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TeamworkTagMember}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamworkTagMember>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified TeamworkTagMember using PATCH.
        /// </summary>
        /// <param name="teamworkTagMemberToUpdate">The TeamworkTagMember to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TeamworkTagMember.</returns>
        System.Threading.Tasks.Task<TeamworkTagMember> UpdateAsync(TeamworkTagMember teamworkTagMemberToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified TeamworkTagMember using PATCH and returns a <see cref="GraphResponse{TeamworkTagMember}"/> object.
        /// </summary>
        /// <param name="teamworkTagMemberToUpdate">The TeamworkTagMember to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TeamworkTagMember}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamworkTagMember>> UpdateResponseAsync(TeamworkTagMember teamworkTagMemberToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamworkTagMemberRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamworkTagMemberRequest Expand(Expression<Func<TeamworkTagMember, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamworkTagMemberRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamworkTagMemberRequest Select(Expression<Func<TeamworkTagMember, object>> selectExpression);

    }
}
